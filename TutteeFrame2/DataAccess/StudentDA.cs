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
                        student.ID = (String)sqlDataReader["StudentId"];
                        student.SurName = (String)sqlDataReader["Surname"];
                        student.FirstName = (String)sqlDataReader["Firstname"];
                        student.Avatar  = ImageHelper.BytesToImage((byte[])sqlDataReader["StudentImage"]);
                        student.DateBorn = (DateTime)sqlDataReader["DateBorn"];
                        student.Sex = (bool)sqlDataReader["Sex"];
                        student.Address = (String)sqlDataReader["Address"];
                        student.Phone = (String)sqlDataReader["Phonne"];
                        student.ClassID = (String)sqlDataReader["ClassID"];
                        student.Status = (bool)sqlDataReader["Status"];
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

    }
}
