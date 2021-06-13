using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TutteeFrame2.Model;

namespace TutteeFrame2.DataAccess
{
    class TeachingDA : BaseDA
    {
        private static readonly TeachingDA _instance = new TeachingDA() { };
        private TeachingDA() { }

        public static new TeachingDA Instance => _instance;

        public Teaching AddTeaching(Teaching _teaching)
        {
            bool success = Connect();

            if (!success)
                return null;

            try
            {
                strQuery = "INSERT INTO TEACHING(TeachingID, ClassID, SubjectID, TeacherID, Semester, Schoolyear, Editable)" +
                    "VALUES(@teachingid, @classid, @subjectid, @teacherid, @semester, @year, @editable)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teachingid", _teaching.ID);
                    sqlCommand.Parameters.AddWithValue("@classid", _teaching.ClassID);
                    sqlCommand.Parameters.AddWithValue("@subjectid", _teaching.Subject.ID);
                    if (_teaching.TeacherID == null)
                        sqlCommand.Parameters.AddWithValue("@teacherid", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue("@teacherid", _teaching.TeacherID);
                    sqlCommand.Parameters.AddWithValue("@semester", _teaching.Semester);
                    sqlCommand.Parameters.AddWithValue("@year", _teaching.Year);
                    sqlCommand.Parameters.AddWithValue("@editable", _teaching.Editable);
                    sqlCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return _teaching;
        }
        public Dictionary<string, Teaching> GetClassTeachings(string classID, int sem)
        {

            bool success = Connect();

            if (!success)
                return null;

            Dictionary<string, Teaching> teachings = new Dictionary<string, Teaching>();
            try
            {
                strQuery = "SELECT TEACHING.TeacherID, TEACHER.Surname, TEACHER.Firstname, SUBJECT.SubjectID, SUBJECT.SubjectName, Editable, SchoolYear" +
                    " FROM TEACHING JOIN SUBJECT ON TEACHING.SubjectID = SUBJECT.SubjectID" +
                    " JOIN TEACHER ON TEACHING.TeacherID = TEACHER.TeacherID WHERE ClassID = @classid AND Semester = @sem";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@classid", classID);
                    sqlCommand.Parameters.AddWithValue("@sem", sem);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0) && !string.IsNullOrEmpty(reader.GetString(0)))
                            {
                                Teaching teaching = new Teaching()
                                {
                                    ID = "",
                                    ClassID = classID,
                                    Semester = sem,
                                    TeacherID = reader.GetString(0),
                                    TeacherName = reader.GetString(1) + " " + reader.GetString(2),
                                    Subject = new Subject(reader.GetString(3), reader.GetString(4)),
                                    Editable = reader.GetBoolean(5),
                                    Year = reader.GetInt32(6),
                                };
                                teachings.Add(teaching.Subject.ID, teaching);
                            }
                            else
                            {
                                Teaching teaching = new Teaching()
                                {
                                    ID = "",
                                    ClassID = classID,
                                    Semester = sem,
                                    TeacherID = null,
                                    TeacherName = null,
                                    Subject = new Subject(reader.GetString(3), reader.GetString(4)),
                                    Editable = reader.GetBoolean(5),
                                    Year = reader.GetInt32(6),
                                };
                                teachings.Add(teaching.Subject.ID, teaching);
                            }
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
            return teachings;
        }
        public Teaching UpdateTeaching(Teaching teaching)
        {
            bool success = Connect();

            if (!success)
                return null;

            try
            {
                strQuery = "UPDATE TEACHING SET TeacherID = @teacherid, Editable = @editable WHERE ClassID = @classid AND SubjectID = @subjectid AND Semester = @sem";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@classid", teaching.ClassID);
                    if (teaching.TeacherID == null)
                        sqlCommand.Parameters.AddWithValue("@teacherid", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue("@teacherid", teaching.TeacherID);
                    sqlCommand.Parameters.AddWithValue("@editable", teaching.Editable);
                    sqlCommand.Parameters.AddWithValue("@subjectid", teaching.Subject.ID);
                    sqlCommand.Parameters.AddWithValue("@sem", teaching.Semester);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return teaching;
        }
        public int GetLastTeachingID()
        {
            bool success = Connect();

            if (!success)
                return -1;

            int _lastTeachingID = -1;
            try
            {
                strQuery = "SELECT COUNT(*) FROM TEACHING";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                if ((int)sqlCommand.ExecuteScalar() <= 0)
                {
                    _lastTeachingID = 10000;
                    return _lastTeachingID;
                }
                strQuery = "SELECT TOP 1 TeachingID FROM TEACHING ORDER BY TeachingID DESC";
                sqlCommand = new SqlCommand(strQuery, connection);
                _lastTeachingID = (int)sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                Disconnect();
            }
            return _lastTeachingID;
        }
        public List<string> GetAssignedDoneClass()
        {
            bool success = Connect();
            if (!success)
                return null;

            List<string> classes = new List<string>();
            try
            {
                strQuery = "SELECT DISTINCT teach1.ClassID FROM TEACHING teach1 WHERE NOT EXISTS " +
                    "(SELECT * FROM TEACHING teach2 WHERE teach1.ClassID = teach2.ClassID AND teach2.TeacherID IS NULL)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        while (reader.Read())
                        {
                            classes.Add(reader.GetString(0));
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();

            }
            return classes;
        }
    }
}
