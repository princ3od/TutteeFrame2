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

    }
}
