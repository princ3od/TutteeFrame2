using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Reports.ReportModel;

namespace TutteeFrame2.DataAccess
{
    class PrepareToPrintDA : BaseDA
    {
        private PrepareToPrintDA() { }
        public static PrepareToPrintDA instance =new  PrepareToPrintDA();

        public List<StudentResult> GetStudentResults()
        {
            List<StudentResult> results = new List<StudentResult>();
            bool success = Connect();
            if (!success)
            {
                return null;
            }
            try
            {
                strQuery = "SELECT STUDENT.StudentID,STUDENT.SurName,STUDENT.FirstName,SCOREBOARD.Semester,SCOREBOARD.SemesterAverage,STUDENT.ClassID " +
                    "FROM SCOREBOARD, STUDENT " +
                    "WHERE STUDENT.StudentID = SCOREBOARD.StudentID";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strQuery;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StudentResult result = new StudentResult();
                        if (!reader.IsDBNull(0)) { result.studentID = reader.GetString(0); }
                        if (!reader.IsDBNull(1)) { result.surName = reader.GetString(1); }
                        if (!reader.IsDBNull(2)) { result.firstName = reader.GetString(2); }
                        if (!reader.IsDBNull(3)) { result.semester = reader.GetInt32(3); }
                        if (!reader.IsDBNull(4)) { result.averagePoint = reader.GetDouble(4); }
                        if (!reader.IsDBNull(5)) { result.classID = reader.GetString(5); }
                       
                        results.Add(result);
                    }
                    
                }
                Disconnect();
                return results;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Disconnect();
                return null;
            }
        }

    }
}
