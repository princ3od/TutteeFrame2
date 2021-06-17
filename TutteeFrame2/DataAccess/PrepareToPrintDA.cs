using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.Reports.ReportModel;
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

        public bool GetSchoolInfoPrepareToPrint(DataSet input)
        {
            base.CreateLocalConnect();
            bool success = Connect();
            if (!success) return false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    strQuery = "SELECT * FROM SCHOOLINFO";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(input, "SCHOOLINFO");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State == ConnectionState.Open) Disconnect();
                return false;
            }
        }

        public bool GetAllInfoAndResultOfStudentPrepareToPrint(InformationOfStudentResultPrepareForPrint input, string studentID)
        {
            input.scoreBoards = new DataSet();
            if (!GetDataStudentResultPrepareToPrint(input.scoreBoards, studentID)) return false;
            if (!GetAnotherInforOfStudentPrepareToPrint(input, studentID)) return false;
            if (!GetSchoolInfoPrepareToPrint(input.BaseInforSchool)) return false;
            return true;
        }

        public bool GetDataStudentResultPrepareToPrint(DataSet input, string studentID)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                SqlDataAdapter adapter;
                strQuery = $"SELECT   SubjectName,Quiz,_15MinuteS01 AS MN1501,_15MinuteS02 AS MN1502,_15MinuteS03 AS MN1503,_45MinuteS01 AS MN4501,_45MinuteS02 AS MN4502,_45MinuteS03 AS MN4503,Final,SubjectAverage FROM LEARNRESULT INNER JOIN SCOREBOARD ON LEARNRESULT.ScoreBoardSE01ID = SCOREBOARD.ScoreBoardID INNER JOIN SUBJECTSCORE ON SUBJECTSCORE.ScoreBoardID = SCOREBOARD.ScoreBoardID INNER JOIN SUBJECT ON SUBJECT.SubjectID = SUBJECTSCORE.SubjectID WHERE LEARNRESULT.StudentID = @studentID";
                using (SqlCommand command = new SqlCommand(strQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(input, "RESULTSTUDENT");
                }
                strQuery = $"SELECT   SubjectName,Quiz,_15MinuteS01 AS MN1501,_15MinuteS02 AS MN1502,_15MinuteS03 AS MN1503,_45MinuteS01 AS MN4501,_45MinuteS02 AS MN4502,_45MinuteS03 AS MN4503,Final,SubjectAverage FROM LEARNRESULT INNER JOIN SCOREBOARD ON LEARNRESULT.ScoreBoardSE02ID = SCOREBOARD.ScoreBoardID INNER JOIN SUBJECTSCORE ON SUBJECTSCORE.ScoreBoardID = SCOREBOARD.ScoreBoardID INNER JOIN SUBJECT ON SUBJECT.SubjectID = SUBJECTSCORE.SubjectID WHERE LEARNRESULT.StudentID = @studentID";
                using (SqlCommand command = new SqlCommand(strQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    adapter = new SqlDataAdapter(command);
                    adapter.Fill(input, "RESULTSTUDENTS2");
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
        public bool GetAnotherInforOfStudentPrepareToPrint(InformationOfStudentResultPrepareForPrint input, string studentID)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string strQuery = "SELECT Surname,Firstname,CLASS.ClassID,ConductSE01,ConductSE02,YearConduct,AverageScore " +
                        "FROM STUDENT INNER JOIN LEARNRESULT ON STUDENT.StudentID = LEARNRESULT.StudentID  " +
                        "INNER JOIN CLASS ON CLASS.ClassID = STUDENT.ClassID " +
                        "WHERE STUDENT.StudentID = @studentID";
                    cmd.Parameters.AddWithValue("studentID", studentID);
                    cmd.CommandText = strQuery;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        if (reader.Read())
                        {
                            input.nameOfStudent = reader.GetString(0) + " " + reader.GetString(1);
                            input.classOfStudent = reader.GetString(2);
                            if (!reader.IsDBNull(3)) input.conductS1 = reader.GetString(3);
                            if (!reader.IsDBNull(4)) input.conductS2 = reader.GetString(4);
                            if (!reader.IsDBNull(5)) input.conductS3 = reader.GetString(5);
                            if (!reader.IsDBNull(6)) input.averageResult = reader.GetDouble(6);
                        }
                };
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
