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
                        if (!reader.IsDBNull(2))
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

        public List<StudentSubjectScore> GetStudentSubjectScore()
        {
            List<StudentSubjectScore> results = new List<StudentSubjectScore>();
            bool success = Connect();
            if (!success) return null;
            try
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    strQuery = "SELECT STUDENT.StudentID,ClassID,SUBJECTSCORE.SubjectID,SUBJECT.SubjectName,Semester,SubjectAverage";
                    strQuery += " FROM STUDENT,SCOREBOARD,SUBJECTSCORE ,SUBJECT";
                    strQuery += " WHERE STUDENT.StudentID = SCOREBOARD.StudentID AND SUBJECTSCORE.ScoreBoardID =SCOREBOARD.ScoreBoardID";
                    strQuery += " AND SUBJECT.SubjectID = SUBJECTSCORE.SubjectID";

                    cmd.CommandText = strQuery;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        String studentID = reader.GetString(0);
                        String classID = reader.GetString(1);
                        String subjectID = reader.GetString(2);
                        String subjectName = reader.GetString(3);
                        int semester =-1;
                        double subjectAverage = -1;
                        if (!reader.IsDBNull(4))
                             semester = reader.GetInt32(4);
                        if (!reader.IsDBNull(5))
                            subjectAverage = reader.GetDouble(5);
                        StudentSubjectScore item = new StudentSubjectScore(studentID, classID, subjectID, subjectName, semester, subjectAverage);
                        results.Add(item);
                    }
                    Disconnect();
                    return results;
                }

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
