﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TutteeFrame2.Model;

namespace TutteeFrame2.DataAccess
{
    class ScoreboardDA : BaseDA
    {
        private static readonly ScoreboardDA _instance = new ScoreboardDA() { };
        private ScoreboardDA() { }

        public static new ScoreboardDA Instance => _instance;
        public bool AddStudentLearnResult(Student student, List<Subject> _subjects)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                SqlCommand sqlCommand;
                //Thêm 2 bảng điểm
                for (int semester = 1; semester < 3; semester++)
                {
                    string boardID = student.ExactID + student.GetGrade + semester.ToString();
                    strQuery = "INSERT INTO SCOREBOARD(ScoreBoardID,StudentID,Semester) VALUES(@scoardboardid,@studentid,@semester)";
                    sqlCommand = new SqlCommand(strQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@scoardboardid", boardID);
                    sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                    sqlCommand.Parameters.AddWithValue("@semester", semester);
                    sqlCommand.ExecuteNonQuery();

                    strQuery = "INSERT INTO SUBJECTSCORE(SubjectScoreID,ScoreBoardID,SubjectID) VALUES(@subjectscoreid,@board,@subjectid)";
                    foreach (Subject subject in _subjects)
                    {
                        sqlCommand = new SqlCommand(strQuery, connection);
                        sqlCommand.Parameters.AddWithValue("@subjectscoreid", boardID + subject.ID);
                        sqlCommand.Parameters.AddWithValue("@board", boardID);
                        sqlCommand.Parameters.AddWithValue("@subjectid", subject.ID);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                int year = DateTime.Now.Year;
                //Thêm learn-result
                strQuery = "INSERT INTO LEARNRESULT(LearnResultID,StudentID,ScoreBoardSE01ID,ScoreBoardSE02ID,Grade,Year) " +
                    "VALUES(@learnid,@studentid,@board1,@board2,@grade,@year)";
                sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@learnid", student.ID + student.GetGrade);
                sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                sqlCommand.Parameters.AddWithValue("@board1", student.ExactID + student.GetGrade + 1.ToString());
                sqlCommand.Parameters.AddWithValue("@board2", student.ExactID + student.GetGrade + 2.ToString());
                sqlCommand.Parameters.AddWithValue("@grade", student.GetGrade);
                sqlCommand.Parameters.AddWithValue("@year", year);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public List<Score> GetStudentScore(string _studentID, string _subjectID, int _semester, int _grade)
        {
            bool success = Connect();

            if (!success)
                return null;

            List<Score> scores = new List<Score>();

            try
            {
                string[] scoreboardClm = { "ScoreBoardSE01ID", "ScoreBoardSE02ID" };
                strQuery = $"SELECT {scoreboardClm[_semester - 1]} FROM LEARNRESULT WHERE StudentID = @studentid AND Grade = @grade";
                SqlCommand command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@studentid", _studentID);
                command.Parameters.AddWithValue("@grade", _grade);
                string scoreBoardID = (string)command.ExecuteScalar();
                strQuery = "SELECT * FROM SUBJECTSCORE WHERE ScoreBoardID = @id AND SubjectID = @subjectid";
                command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@subjectid", _subjectID);
                command.Parameters.AddWithValue("@id", scoreBoardID);
                using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.Read())
                    {
                        Score score = new Score(Score.ScoreType.Mieng);
                        if (!reader.IsDBNull(3))
                            score.Value = reader.GetDouble(3);
                        else
                            score.Value = -1;
                        scores.Add(score);
                        for (int i = 4; i < 7; i++)
                        {
                            score = new Score(Score.ScoreType.MuoiLamPhut);
                            if (!reader.IsDBNull(i))
                                score.Value = reader.GetDouble(i);
                            else
                                score.Value = -1;
                            scores.Add(score);
                        }
                        for (int i = 7; i < 10; i++)
                        {
                            score = new Score(Score.ScoreType.MotTiet);
                            if (!reader.IsDBNull(i))
                                score.Value = reader.GetDouble(i);
                            else
                                score.Value = -1;
                            scores.Add(score);
                        }
                        score = new Score(Score.ScoreType.HocKi);
                        if (!reader.IsDBNull(10))
                            score.Value = reader.GetDouble(10);
                        else
                            score.Value = -1;
                        scores.Add(score);
                        score = new Score(Score.ScoreType.TrungBinh);
                        if (!reader.IsDBNull(11))
                            score.Value = reader.GetDouble(11);
                        else
                            score.Value = -1;
                        score.SubjectID = _subjectID;
                        scores.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            scores.Add(new Score(Score.ScoreType.TrungBinh));
                        }
                    }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return scores;
        }
        public bool UpdateStudentScore(string _studentID, string _subjectID, int _semester, int _grade, List<Score> _scores)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                string[] scoreboardClm = { "ScoreBoardSE01ID", "ScoreBoardSE02ID" };
                strQuery = $"SELECT {scoreboardClm[_semester - 1]} FROM LEARNRESULT WHERE StudentID = @studentid AND Grade = @grade";
                SqlCommand command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@studentid", _studentID);
                command.Parameters.AddWithValue("@grade", _grade);
                string scoreBoardID = (string)command.ExecuteScalar();
                strQuery = "UPDATE SUBJECTSCORE " +
                    "SET Quiz = @mieng, _15minuteS01 = @fifteen1, _15minuteS02 = @fifteen2, _15minuteS03 = @fifteen3, " +
                    "_45minuteS01 = @fortyfive1, _45minuteS02 = @fortyfive2, _45minuteS03 = @fortyfive3, " +
                    "Final = @final, SubjectAverage = @averagescore" +
                    " WHERE ScoreBoardID = @id AND SubjectID = @subjectid";
                command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@subjectid", _subjectID);
                command.Parameters.AddWithValue("@id", scoreBoardID);
                if (_scores[0].Value != -1)
                    command.Parameters.AddWithValue("@mieng", _scores[0].Value);
                else
                    command.Parameters.AddWithValue("@mieng", DBNull.Value);
                //15p - 1 tiết
                for (int i = 1; i < 4; i++)
                {
                    if (_scores[i].Value != -1)
                        command.Parameters.AddWithValue("@fifteen" + i.ToString(), _scores[i].Value);
                    else
                        command.Parameters.AddWithValue("@fifteen" + i.ToString(), DBNull.Value);
                    if (_scores[i + 3].Value != -1)
                        command.Parameters.AddWithValue("@fortyfive" + i.ToString(), _scores[i + 3].Value);
                    else
                        command.Parameters.AddWithValue("@fortyfive" + i.ToString(), DBNull.Value);
                }
                //Cuối kì
                if (_scores[7].Value != -1)
                    command.Parameters.AddWithValue("@final", _scores[7].Value);
                else
                    command.Parameters.AddWithValue("@final", DBNull.Value);
                //trung bình
                if (_scores[8].Value != -1)
                    command.Parameters.AddWithValue("@averagescore", _scores[8].Value);
                else
                    command.Parameters.AddWithValue("@averagescore", DBNull.Value);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }

        public List<AverageScore> GetAverageScore(string _studentID, int _grade)
        {
            bool success = Connect();

            if (!success)
                return null;

            List<AverageScore> averageScores = new List<AverageScore>();
            try
            {
                AverageScore score;
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT SCOREBOARD.SemesterAverage FROM LEARNRESULT JOIN SCOREBOARD ON LEARNRESULT.ScoreBoardSE01ID = SCOREBOARD.ScoreBoardID " +
                                 "WHERE LEARNRESULT.StudentID = @studentid AND Grade = @grade";
                    command.Parameters.AddWithValue("@studentid", _studentID);
                    command.Parameters.AddWithValue("@grade", _grade);
                    score = new AverageScore(AverageScore.ScoreType.HK1);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.IsDBNull(0))
                            score.Value = reader.GetDouble(0);
                    }
                    averageScores.Add(score);
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT SCOREBOARD.SemesterAverage FROM LEARNRESULT JOIN SCOREBOARD ON LEARNRESULT.ScoreBoardSE02ID = SCOREBOARD.ScoreBoardID " +
                                 "WHERE LEARNRESULT.StudentID = @studentid AND Grade = @grade";
                    command.Parameters.AddWithValue("@studentid", _studentID);
                    command.Parameters.AddWithValue("@grade", _grade);
                    score = new AverageScore(AverageScore.ScoreType.HK2);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.IsDBNull(0))
                            score.Value = reader.GetDouble(0);
                    }
                    averageScores.Add(score);
                }
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT AverageScore FROM LEARNRESULT WHERE StudentID = @studentid AND Grade = @grade";
                    command.Parameters.AddWithValue("@studentid", _studentID);
                    command.Parameters.AddWithValue("@grade", _grade);
                    score = new AverageScore(AverageScore.ScoreType.CaNam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.IsDBNull(0))
                            score.Value = reader.GetDouble(0);
                    }
                    averageScores.Add(score);
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return averageScores;
        }
        public double GetAverageSubjectScore(string _studentID, int _grade, int _semester, string _subjectID)
        {
            bool success = Connect();

            if (!success)
                return -1;

            double score = -1;
            try
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT SubjectAverage FROM SUBJECTSCORE JOIN SCOREBOARD ON SUBJECTSCORE.ScoreBoardID = SCOREBOARD.ScoreBoardID " +
                        "JOIN LEARNRESULT ON LEARNRESULT.ScoreBoardSE01ID = SCOREBOARD.ScoreBoardID OR LEARNRESULT.ScoreBoardSE02ID = SCOREBOARD.ScoreBoardID " +
                        "WHERE LEARNRESULT.StudentID = @studentid AND LEARNRESULT.Grade = @grade AND SCOREBOARD.Semester = @sem AND SUBJECTSCORE.SubjectID = @subjectid";
                    sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                    sqlCommand.Parameters.AddWithValue("@grade", _grade);
                    sqlCommand.Parameters.AddWithValue("@sem", _semester);
                    sqlCommand.Parameters.AddWithValue("@subjectid", _subjectID);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                score = reader.GetDouble(0);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                Disconnect();
            }
            return score;
        }
        public List<Score> GetAllAverageSubjectScore(string _studentID, int _grade, int _semester)
        {
            bool success = Connect();

            if (!success)
                return null;

            List<Score> _subjectScores = new List<Score>();
            try
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT SubjectID, SubjectAverage FROM SUBJECTSCORE JOIN SCOREBOARD ON SUBJECTSCORE.ScoreBoardID = SCOREBOARD.ScoreBoardID " +
                        "JOIN LEARNRESULT ON LEARNRESULT.ScoreBoardSE01ID = SCOREBOARD.ScoreBoardID OR LEARNRESULT.ScoreBoardSE02ID = SCOREBOARD.ScoreBoardID " +
                        "WHERE LEARNRESULT.StudentID = @studentid AND LEARNRESULT.Grade = @grade AND SCOREBOARD.Semester = @sem";
                    sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                    sqlCommand.Parameters.AddWithValue("@grade", _grade);
                    sqlCommand.Parameters.AddWithValue("@sem", _semester);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Score score = new Score(Score.ScoreType.TrungBinh);
                            score.SubjectID = reader.GetString(0);
                            if (!reader.IsDBNull(1))
                                score.Value = reader.GetDouble(1);
                            _subjectScores.Add(score);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return _subjectScores;
        }
        public double GetAverageYearSubjectScore(string _studentID, string _subjectID, int _grade)
        {
            double _score = -1;
            bool success = Connect();

            if (!success)
                return _score;

            try
            {
                double scoreSem1 = -1, scoreSem2 = -1;
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT SUBJECTSCORE.SubjectAverage FROM LEARNRESULT JOIN SCOREBOARD ON LEARNRESULT.ScoreBoardSE01ID = SCOREBOARD.ScoreBoardID " +
                        "JOIN SUBJECTSCORE ON SCOREBOARD.ScoreBoardID = SUBJECTSCORE.ScoreBoardID " +
                                 "WHERE LEARNRESULT.StudentID = @studentid AND Grade = @grade AND SUBJECTSCORE.SubjectID = @subjectid";
                    sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                    sqlCommand.Parameters.AddWithValue("@grade", _grade);
                    sqlCommand.Parameters.AddWithValue("@subjectid", _subjectID);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.IsDBNull(0))
                            scoreSem1 = reader.GetDouble(0);
                    }
                }
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT SUBJECTSCORE.SubjectAverage FROM LEARNRESULT JOIN SCOREBOARD ON LEARNRESULT.ScoreBoardSE02ID = SCOREBOARD.ScoreBoardID " +
                        "JOIN SUBJECTSCORE ON SCOREBOARD.ScoreBoardID = SUBJECTSCORE.ScoreBoardID " +
                                 "WHERE LEARNRESULT.StudentID = @studentid AND Grade = @grade AND SUBJECTSCORE.SubjectID = @subjectid";
                    sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                    sqlCommand.Parameters.AddWithValue("@grade", _grade);
                    sqlCommand.Parameters.AddWithValue("@subjectid", _subjectID);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        reader.Read();
                        if (!reader.IsDBNull(0))
                            scoreSem2 = reader.GetDouble(0);
                    }
                }
                if (scoreSem1 != -1 && scoreSem2 != -1)
                    _score = Math.Round(((scoreSem1 + scoreSem2 * 2) / 3), 2);
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                Disconnect();
            }
            return _score;
        }
        public double GetClassAverageScore(string _classID, int _semester = 3, string _subjectID = "")
        {
            double _score = -1.0;
            bool success = Connect();

            if (!success)
                return -1.0;

            try
            {
                //cả năm
                if (_semester == 3)
                {
                    if (string.IsNullOrEmpty(_subjectID))
                    {
                        bool _canCalc = false;
                        using (SqlCommand sqlCommand = connection.CreateCommand())
                        {
                            sqlCommand.CommandType = System.Data.CommandType.Text;
                            sqlCommand.CommandText = "SELECT COUNT(*) FROM LEARNRESULT JOIN STUDENT ON LEARNRESULT.StudentID = STUDENT.StudentID " +
                                "WHERE AverageScore IS NULL AND STUDENT.ClassID = @classid";
                            sqlCommand.Parameters.AddWithValue("@classid", _classID);
                            _canCalc = ((int)sqlCommand.ExecuteScalar() == 0);
                        }
                        if (_canCalc)
                        {
                            using (SqlCommand sqlCommand = connection.CreateCommand())
                            {
                                sqlCommand.CommandType = System.Data.CommandType.Text;
                                sqlCommand.CommandText = "SELECT AVG(AverageScore) FROM LEARNRESULT JOIN STUDENT ON LEARNRESULT.StudentID = STUDENT.StudentID " +
                                    "WHERE STUDENT.ClassID = @classid";
                                sqlCommand.Parameters.AddWithValue("@classid", _classID);
                                _score = (double)sqlCommand.ExecuteScalar();
                            }
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                return -1.0;
            }
            finally
            {
                Disconnect();
            }
            return _score;
        }
    }
}
