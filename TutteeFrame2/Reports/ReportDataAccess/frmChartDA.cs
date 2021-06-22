using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Reports.ReportModel;

namespace TutteeFrame2.Reports.ReportDataAccess
{
    class frmChartDA : BaseDA
    {
        private frmChartDA() { }
        private static frmChartDA _instance = new frmChartDA();
        public static frmChartDA istance => _instance;

        public List<StudentPointResouce> GetStudentPointResouce()
        {
            List<StudentPointResouce> results = new List<StudentPointResouce>();
            bool success = Connect();
            if (!success) return null;
            try
            {

                using (SqlCommand cmd = connection.CreateCommand())
                {
                    strQuery = "SELECT LNRS.StudentID,ST.ClassID,SCB01.SemesterAverage,SCB02.SemesterAverage";
                    strQuery += " FROM LEARNRESULT AS LNRS,SCOREBOARD AS SCB01, SCOREBOARD AS SCB02, STUDENT AS ST";
                    strQuery += " WHERE LNRS.ScoreBoardSE01ID = SCB01.ScoreBoardID AND LNRS.ScoreBoardSE02ID = SCB02.ScoreBoardID " +
                        "AND ST.StudentID = LNRS.StudentID";

                    cmd.CommandText = strQuery;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        StudentPointResouce result = new StudentPointResouce();
                        result.id = reader.GetString(0);
                        result.classID = reader.GetString(1);
                        if(!reader.IsDBNull(2))
                        result.averageSE01 = (float)reader.GetDouble(2);
                        if (!reader.IsDBNull(3))
                            result.averageSE02 = (float)reader.GetDouble(3);
                        results.Add(result);
                    }
                    Disconnect();
                    return results;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

    }
}
