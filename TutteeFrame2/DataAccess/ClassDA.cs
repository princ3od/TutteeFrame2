using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Model;

namespace TutteeFrame2.DataAccess
{
    class ClassDA : BaseDA
    {
        private static readonly ClassDA _classDA = new ClassDA() { };
        private ClassDA() { }

        public static new ClassDA Instance => _classDA;
        public Class AddClass(Class _class)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                string query = "INSERT INTO CLASS(ClassID,RoomNum,StudentNum,TeacherID) VALUES (@classid,@classroom,@studentnum,@teacherid)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@classid", _class.ClassID);
                command.Parameters.AddWithValue("@classroom", _class.RoomNumber);
                command.Parameters.AddWithValue("@studentnum", _class.StudentNumber);
                command.Parameters.AddWithValue("@teacherid", DBNull.Value);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            finally
            {
                Disconnect();
            }
            return _class;
        }

        public string DeletedClass(string classId)
        {
            bool success = Connect();

            if (!success)
                return classId;

            try
            {
                strQuery = "DELETE  FROM CLASS WHERE ClassID = @classId";
                using (SqlCommand cmd = new SqlCommand(strQuery, connection))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.Add("@classId", System.Data.SqlDbType.VarChar).Value = classId;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return classId;
        }

        public Class UpdateClassInfo(Class _class)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                strQuery = "UPDATE CLASS SET RoomNum = @romNumber, StudentNum = @studentNumber, TeacherID =@teacherFormalID  WHERE ClassID = @classID";
                using (SqlCommand cmd = new SqlCommand(strQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@romNumber", _class.RoomNumber);
                    cmd.Parameters.AddWithValue("@classID", _class.ClassID);
                    cmd.Parameters.AddWithValue("@studentNumber", _class.StudentNumber);
                    if (_class.FormalTeacherID == null)
                        cmd.Parameters.AddWithValue("@teacherFormalID", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@teacherFormalID", _class.FormalTeacherID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return _class;

        }
        public Class GetClass(string classID)
        {
            bool success = Connect();
            if (!success)
                return null;

            Class _class = new Class();
            try
            {
                strQuery = "SELECT * FROM CLASS WHERE ClassID = @classid";
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = strQuery;
                    command.Parameters.AddWithValue("@classid", classID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        _class.ClassID = reader.GetString(0);
                        _class.RoomNumber = reader.GetString(1);
                        _class.StudentNumber = reader.GetByte(2);
                        if (!reader.IsDBNull(3))
                            _class.FormalTeacherID = reader.GetString(3);
                        else
                            _class.FormalTeacherID = null;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return _class;
        }
        public List<Class> GetClasses(string grade = "")
        {
            bool success = Connect();

            if (!success)
                return null;

            List<Class> classes = new List<Class>();
            try
            {
                if (string.IsNullOrEmpty(grade))
                    strQuery = $"SELECT * FROM CLASS ";
                else
                    strQuery = $"SELECT * FROM CLASS WHERE ClassID LIKE @khoi";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strQuery;
                if (!string.IsNullOrEmpty(grade))
                    cmd.Parameters.AddWithValue("@khoi", grade + "%%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Class _class = new Class();
                        _class.ClassID = reader.GetString(0);
                        _class.RoomNumber = reader.GetString(1);
                        _class.StudentNumber = (byte)reader.GetByte(2);
                        _class.FormalTeacherID = !reader.IsDBNull(3) ? reader.GetString(3) : "Chưa phân công";
                        classes.Add(_class);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return classes;
            }
            finally
            {
                Disconnect();
            }
            return classes;
        }

        public  String GetTeacherFromClassID(String classID)
        {
            bool success = Connect();

            if (!success)
                return null;
            
            try
            {
                strQuery = $"SELECT TEACHER.Surname,TEACHER.Firstname FROM CLASS,TEACHER  " +
                    $"WHERE CLASS.TeacherID = TEACHER.TeacherID AND CLASS.ClassID = '{classID}' ";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strQuery;
                String nameTeacher ="";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                         nameTeacher = reader.GetString(0) + " " + reader.GetString(1);
                        break;
                    }
                }
                Disconnect();
                return nameTeacher;
            }
            catch (Exception e)
            {
                return null;
            }

        }


    }
}
