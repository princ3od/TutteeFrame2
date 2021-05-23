using MaterialSurface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.DataAccess
{
    class StudentDA:BaseDA
    {
        private static readonly StudentDA student = new StudentDA();
        private StudentDA() { }
        public static new  StudentDA Instance => student;


        #region Methods
        #endregion
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                String strQuery = "SELECT * FROM STUDENT";
                using(SqlCommand sqlcomannd = new SqlCommand(strQuery,connection))
                {
                    SqlDataReader sqlDataReader = sqlcomannd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Student student = new Student();
                        student.ID = sqlDataReader["StudentId"]!=null? (String)sqlDataReader["StudentId"] : null;
                        student.SurName = sqlDataReader["Surname"]!=null?(String)sqlDataReader["Surname"]:null;
                        student.FirstName = sqlDataReader["Firstname"] != null? (String)sqlDataReader["Firstname"]:null;
                        student.Avatar  = sqlDataReader["StudentImage"]!=null? ImageHelper.BytesToImage((byte[])sqlDataReader["StudentImage"]):null;
                        student.DateBorn = sqlDataReader["DateBorn"]!=null?(DateTime)sqlDataReader["DateBorn"]: DateTime.Now;
                        student.Sex = sqlDataReader["Sex"]!=null?(bool)sqlDataReader["Sex"]:false;
                        student.Address = sqlDataReader["Address"]!=null?(String)sqlDataReader["Address"]:null;
                        student.Phone = sqlDataReader["Phonne"]!=null?(String)sqlDataReader["Phonne"]:null;
                        student.ClassID = sqlDataReader["ClassID"]!=null?(String)sqlDataReader["ClassID"]:null;
                        student.Status = sqlDataReader["Status"]!=null?(bool)sqlDataReader["Status"]:false;
                        students.Add(student);
                    }
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }

            return students;
        }

        public Student GetStudentByID(string _studentID)
        {
            bool success = Connect();
            Student _student = new Student();
            if (!success)
                return null;
            try
            {
                string query = $"SELECT * FROM STUDENT WHERE StudentID = @studentid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentid", _studentID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _student.ID = reader.GetString(0);
                            _student.SurName = reader.GetString(1);
                            _student.FirstName = reader.GetString(2);
                            if (reader.IsDBNull(3) == false)
                                _student.Avatar = ImageHelper.BytesToImage((byte[])reader["StudentImage"]);
                            if (reader.IsDBNull(4) == false)
                                _student.DateBorn = reader.GetDateTime(4);
                            _student.Sex = reader.GetBoolean(5);
                            _student.Address = reader.GetString(6);
                            _student.Phone = reader.GetString(7);
                            _student.ClassID = reader.GetString(8);
                            _student.Status = reader.GetBoolean(9);
                            //if (reader.IsDBNull(10) == false)
                            //    _student.PunishmentList = reader.GetString(10);
                        }
                    }
                }
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
            return _student;
        }

        public bool UpdateStudent( Student student)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                byte[] photo = ImageHelper.ImageToBytes(student.Avatar);
                string query = $"UPDATE  STUDENT SET " +
                    "Surname = @surname," +
                    "Firstname = @firstname," +
                    "StudentImage =@studentimage," +
                    "DateBorn =@dateborn, " +
                    "Sex =@sex, " +
                    "Address= @address," +
                    "Phonne = @phone," +
                    "ClassID =@classid, " +
                    "Status = @status" +
                    $" WHERE StudentID = @studentid";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                    sqlCommand.Parameters.AddWithValue("@surname", student.SurName);
                    sqlCommand.Parameters.AddWithValue("@firstname", student.FirstName);
                    sqlCommand.Parameters.AddWithValue("@dateborn", student.DateBorn);
                    sqlCommand.Parameters.AddWithValue("@sex", student.Sex);
                    sqlCommand.Parameters.AddWithValue("@phone", student.Phone);
                    sqlCommand.Parameters.AddWithValue("@classid", student.ClassID);
                    sqlCommand.Parameters.AddWithValue("@address", student.Address);
                    sqlCommand.Parameters.AddWithValue("@status", student.Status);
                    sqlCommand.Parameters.Add("@studentimage", SqlDbType.Image, photo.Length).Value = photo;
                    sqlCommand.ExecuteNonQuery();
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

        public bool AddStudent(Student student)
        {
            bool success = Connect();

            if (!success)
                return false;

            byte[] photo = ImageHelper.ImageToBytes(student.Avatar);

            try
            {
                strQuery = "INSERT INTO STUDENT(StudentID,Surname,FirstName,DateBorn,Sex,Address,Phonne,ClassID,Status,StudentImage) " +
                "VALUES(@studentid,@surname,@firstname,@dateborn,@sex,@address,@phone,@classid,@status,@studentimage)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                    sqlCommand.Parameters.AddWithValue("@surname", student.SurName);
                    sqlCommand.Parameters.AddWithValue("@firstname", student.FirstName);
                    sqlCommand.Parameters.AddWithValue("@dateborn", student.DateBorn);
                    sqlCommand.Parameters.AddWithValue("@sex", student.Sex);
                    sqlCommand.Parameters.AddWithValue("@phone", student.Phone);
                    sqlCommand.Parameters.AddWithValue("@classid", student.ClassID);
                    sqlCommand.Parameters.AddWithValue("@address", student.Address);
                    sqlCommand.Parameters.AddWithValue("@status", student.Status);
                    sqlCommand.Parameters.Add("@studentimage", SqlDbType.Image, photo.Length).Value = photo;
                    sqlCommand.ExecuteNonQuery();
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

        public bool DeleteStudent(string _studentID)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = $"SELECT ClassID FROM STUDENT WHERE STUDENT.StudentID = @studentid";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                string classID = (string)sqlCommand.ExecuteScalar();
                strQuery = $"DELETE FROM STUDENT WHERE STUDENT.StudentID = @studentid";
                sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = strQuery;
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                sqlCommand.ExecuteNonQuery();
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
    }
}
