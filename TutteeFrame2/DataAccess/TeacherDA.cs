using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.DataAccess
{
    class TeacherDA : BaseDA
    {
        private TeacherDA() { }

        static readonly TeacherDA instance = new TeacherDA();

        public static new TeacherDA Instance => instance;
        public Teacher GetTeacher(string teacherID)
        {
            bool success = Connect();

            if (!success)
                return null;

            Teacher teacher = new Teacher();
            try
            {
                string strQuery = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID" +
                    " WHERE TeacherID=@teacherid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", teacherID);
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        dataReader.Read();
                        teacher.Subject = new Subject();
                        teacher.ID = dataReader.GetString(0);
                        teacher.SurName = dataReader.GetString(1);
                        teacher.FirstName = dataReader.GetString(2);
                        if (!(dataReader["TeacherImage"] is DBNull))
                            teacher.Avatar = ImageHelper.BytesToImage((byte[])dataReader["TeacherImage"]);
                        else
                            teacher.Avatar = null;
                        teacher.DateBorn = dataReader.GetDateTime(4);
                        teacher.Sex = dataReader.GetBoolean(5);
                        teacher.Address = dataReader.GetString(6);
                        teacher.Phone = dataReader.GetString(7);
                        teacher.Mail = dataReader.GetString(8);
                        teacher.Subject.ID = dataReader.GetString(9);
                        if (dataReader.GetBoolean(10))
                        {
                            teacher.Type = TeacherType.Ministry;
                            teacher.Position = "Giáo vụ";
                        }
                        else if (dataReader.GetBoolean(11))
                        {
                            teacher.Type = TeacherType.Adminstrator;
                            teacher.Position = "Ban giám hiệu";
                        }
                        else
                        {
                            teacher.Type = TeacherType.Teacher;
                            teacher.Position = "Giáo viên";
                        }
                        teacher.Subject.Name = dataReader["SubjectName"].ToString();
                        teacher.Position = dataReader.GetString(12);
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return teacher;
        }
        public List<Teacher> GetTeachers(string order = "TeacherID")
        {
            bool success = Connect();

            if (!success)
                return null;
            List<Teacher> teachers = new List<Teacher>();
            try
            {
                string query = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID ORDER BY " + order;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Teacher teacher = new Teacher();
                            teacher.Subject = new Subject();
                            teacher.ID = reader.GetString(0);
                            if (teacher.ID == "AD999999")
                                continue;
                            teacher.SurName = reader.GetString(1);
                            teacher.FirstName = reader.GetString(2);
                            if (!(reader["TeacherImage"] is DBNull))
                                teacher.Avatar = ImageHelper.BytesToImage((byte[])reader["TeacherImage"]);
                            else
                                teacher.Avatar = null;
                            teacher.DateBorn = reader.GetDateTime(4);
                            teacher.Sex = reader.GetBoolean(5);
                            teacher.Address = reader.GetString(6);
                            teacher.Phone = reader.GetString(7);
                            teacher.Mail = reader.GetString(8);
                            teacher.Subject.ID = reader.GetString(9);
                            if (reader.GetBoolean(10))
                            {
                                teacher.Type = TeacherType.Ministry;
                                teacher.Position = "Giáo vụ";
                            }
                            else if (reader.GetBoolean(11))
                            {
                                teacher.Type = TeacherType.Adminstrator;
                                teacher.Position = "Ban giám hiệu";
                            }
                            else
                            {
                                teacher.Type = TeacherType.Teacher;
                                teacher.Position = "Giáo viên";
                            }
                            teacher.Subject.Name = reader["SubjectName"].ToString();
                            teacher.Position = reader.GetString(12);
                            teachers.Add(teacher);
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return teachers;
        }
        public bool GetTeacherNum(ref int _totalMinstry, ref int _totalAdmin)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT COUNT(*) FROM TEACHER WHERE IsMinistry = 1 AND TeacherID != @adminid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalMinstry = (int)command.ExecuteScalar();
                query = "SELECT COUNT(*) FROM TEACHER WHERE IsAdmin = 1 AND TeacherID != @adminid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalAdmin = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                int is_admin = 0;
                int is_ministry = 0;

                switch (teacher.Type)
                {
                    case TeacherType.Teacher:
                        {
                            break;
                        }
                    case TeacherType.Adminstrator:
                        {
                            is_admin = 1;
                            break;
                        }
                    case TeacherType.Ministry:
                        is_ministry = 1;
                        break;
                }
                string query = "INSERT INTO TEACHER(TeacherID,Surname,FirstName,TeacherImage,DateBorn,Sex,Address,Phone,Maill,SubjectID,IsMinistry,IsAdmin,Posittion) " +
                    "VALUES(@teacherid,@surname,@firstname,@avatar,@date,@sex,@address,@phone,@mail,@subjectid,@is_ministry,@is_admin,@position)";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", teacher.ID);
                    sqlCommand.Parameters.AddWithValue("@surname", teacher.SurName);
                    sqlCommand.Parameters.AddWithValue("@date", teacher.DateBorn);
                    sqlCommand.Parameters.AddWithValue("@sex", teacher.Sex);
                    sqlCommand.Parameters.AddWithValue("@firstname", teacher.FirstName);
                    sqlCommand.Parameters.AddWithValue("@avatar", teacher.GetAvatar());
                    sqlCommand.Parameters.AddWithValue("@phone", teacher.Phone);
                    sqlCommand.Parameters.AddWithValue("@address", teacher.Address);
                    sqlCommand.Parameters.AddWithValue("@mail", teacher.Mail);
                    sqlCommand.Parameters.AddWithValue("@subjectid", teacher.Subject.ID);
                    sqlCommand.Parameters.AddWithValue("@is_ministry", is_ministry);
                    sqlCommand.Parameters.AddWithValue("@is_admin", is_admin);
                    sqlCommand.Parameters.AddWithValue("@position", teacher.Position);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return teacher;
        }
        public Teacher UpdateTeacher(string teacherID, Teacher newTeacher)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                int isMinistry = 0, isAdmin = 0;
                strQuery = $"UPDATE TEACHER SET " +
                    $"Surname = @surname, " +
                    $"FirstName = @firstname, " +
                    $"TeacherImage = @avatar, " +
                    $"DateBorn = @dateborn, " +
                    $"Sex = @sex, " +
                    $"Address = @address, " +
                    $"Phone = @phone, " +
                    $"Maill = @mail, " +
                    $"SubjectID = @subjectid, " +
                    $"IsMinistry = @is_ministry, " +
                    $"IsAdmin = @is_admin, " +
                    $"Posittion = @position " +
                    $"WHERE TeacherID = @teacherid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", newTeacher.ID);
                    sqlCommand.Parameters.AddWithValue("@surname", newTeacher.SurName);
                    sqlCommand.Parameters.AddWithValue("@dateborn", newTeacher.DateBorn);
                    sqlCommand.Parameters.AddWithValue("@sex", newTeacher.Sex);
                    sqlCommand.Parameters.AddWithValue("@firstname", newTeacher.FirstName);
                    sqlCommand.Parameters.AddWithValue("@avatar", newTeacher.GetAvatar());
                    sqlCommand.Parameters.AddWithValue("@phone", newTeacher.Phone);
                    sqlCommand.Parameters.AddWithValue("@address", newTeacher.Address);
                    sqlCommand.Parameters.AddWithValue("@mail", newTeacher.Mail);
                    sqlCommand.Parameters.AddWithValue("@subjectid", newTeacher.Subject.ID);
                    sqlCommand.Parameters.AddWithValue("@is_ministry", isMinistry);
                    sqlCommand.Parameters.AddWithValue("@is_admin", isAdmin);
                    sqlCommand.Parameters.AddWithValue("@position", newTeacher.Position);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return newTeacher;
        }
        public string DeleteTeacher(string _teacherID)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                //strQuery = $"UPDATE TEACHING SET TEACHING.TeacherID = NULL WHERE TEACHING.TeacherID = '{_teacherID}'";
                //using (SqlCommand command = new SqlCommand(strQuery, connection))
                //    command.ExecuteNonQuery();
                //strQuery = $"UPDATE CLASS SET CLASS.TeacherID = NULL WHERE CLASS.TeacherID = '{_teacherID}'";
                //using (SqlCommand command = new SqlCommand(strQuery, connection))
                //    command.ExecuteNonQuery();
                strQuery = $"DELETE TEACHER WHERE TeacherID = '{_teacherID}'";
                using (SqlCommand command = new SqlCommand(strQuery, connection))
                    command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return _teacherID;
        }
        public string GetInchargeClass(string _teacherID)
        {
            bool success = Connect();

            if (!success)
                return null;

            string classID = null;
            try
            {
                string strQuery = "SELECT * FROM CLASS WHERE TeacherID=@teacherid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        if (!dataReader.HasRows)
                            classID = null;
                        else
                        {
                            dataReader.Read();
                            classID = dataReader.GetString(0);
                        }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return classID;
        }
        public List<string> GetClasses(string teacherID)
        {
            List<string> classes = new List<string>();
            bool success = Connect();
            if (!success)
                return null;
            if (teacherID == "AD999999")
                return null;
            try
            {
                string strQuery = "SELECT * FROM TEACHING WHERE TeacherID=@teacherID AND Semester = 2";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", teacherID);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        string s = sqlDataReader["ClassID"] != null ? (string)sqlDataReader["ClassID"] : null;
                        if (s != null) 
                        {
                            classes.Add(s);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return classes;
        }
        public List<int> GetSessions(Teacher teacher, int day, string schedulesid)
        {
            List<int> sessions = new List<int>();
            bool success = Connect();
            if (!success)
                return null;
            try
            {
                string strQuery = "SELECT * FROM SCHEDULE WHERE SchedulesID = @scheduleid AND Day = @day AND SubjectID = @subid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@scheduleid", schedulesid);
                    sqlCommand.Parameters.AddWithValue("@day", day);
                    sqlCommand.Parameters.AddWithValue("@subid", teacher.Subject.ID);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        int i = sqlDataReader.GetByte(4);
                        sessions.Add(i);
                    }    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return sessions;
        }
    }
}
