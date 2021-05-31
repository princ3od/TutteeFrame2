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
        public bool AddClass(Class _class)
        {
            bool success = Connect();

            if (!success)
                return false;
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
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }

        public bool DeletedClass(string classId)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                strQuery = "DELETE  FROM CLASS WHERE ClassID = @classId";
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Parameters.Add("@classId", System.Data.SqlDbType.VarChar).Value = classId;
                cmd.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open) Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool UpdateClassInfo(Class _class)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "UPDATE CLASS SET RoomNum = @romNumber,StudentNum = @studentNumber, TeacherID =@teacherFormalID  WHERE ClassID = @classID";
                using (SqlCommand cmd = new SqlCommand(strQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@romNumber", _class.RoomNumber);
                    cmd.Parameters.AddWithValue("@classID", _class.ClassID);
                    cmd.Parameters.AddWithValue("@studentNumber", _class.StudentNumber);
                    cmd.Parameters.AddWithValue("@teacherFormalID", _class.FormalTeacherID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;

        }
        public List<Class> GetClasses(string grade = "")
        {

            List<Class> NhomLops = new List<Class>();
            bool success = Connect();
            if (!success)
                return null;
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
                        Class i = new Class();
                        i.ClassID = reader.GetString(0);
                        i.RoomNumber = reader.GetString(1);
                        i.StudentNumber = (byte)reader.GetByte(2);
                        i.FormalTeacherID = !reader.IsDBNull(3) ? reader.GetString(3) : "Chưa phân công";
                        NhomLops.Add(i);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return NhomLops;
            }
            finally
            {
                Disconnect();
            }
            return NhomLops;
        }

    }
}
