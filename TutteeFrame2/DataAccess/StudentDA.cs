using MaterialSurface;
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

    }
}
