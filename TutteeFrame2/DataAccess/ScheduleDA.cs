using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Utils;

namespace TutteeFrame2.DataAccess
{
    class ScheduleDA : BaseDA
    {
        private static readonly ScheduleDA Schedule = new ScheduleDA();
        private ScheduleDA()
        {

        }
        public static new ScheduleDA Instance => Schedule;
        #region Methods
        #endregion
        public string GetSchedule(string classID, int semester, int year)
        {
            string scheduleID = new string(new char[] { });
            bool success = Connect();
            if (!success)
                return null;
            try
            {
                string sqrQuery = "SELECT * FROM SCHEDULES WHERE ClassID = @classid AND Semester = @semester AND Year = @year";
                using (SqlCommand sqlcomannd = new SqlCommand(sqrQuery, connection))
                {
                    sqlcomannd.Parameters.AddWithValue("@classid", classID);
                    sqlcomannd.Parameters.AddWithValue("@semester", semester);
                    sqlcomannd.Parameters.AddWithValue("@year", year);
                    SqlDataReader sqlDataReader = sqlcomannd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        scheduleID = sqlDataReader["SchedulesID"] != null ? (string)sqlDataReader["SchedulesID"] : null;
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
            if (scheduleID == "")
            {
                scheduleID = CreateSchedule(classID, semester, year);
                return scheduleID;
            }
            return scheduleID;
        }

        public string CreateSchedule(string classid, int semester, int year)
        {
            string scheduleid = IdentifierFactory.GenerateNumberID(6);
            bool success = Connect();
            if (!success)
                return null;
            try
            {
                strQuery = "INSERT INTO SCHEDULES(SchedulesID, ClassID, Semester, Year) " + 
                    "VALUES(@scheduleid, @classid, @semester, @year)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@scheduleid", scheduleid);
                    sqlCommand.Parameters.AddWithValue("@classid", classid);
                    sqlCommand.Parameters.AddWithValue("@semester", semester.ToString());
                    sqlCommand.Parameters.AddWithValue("@year", year.ToString());
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
            return scheduleid;
        }
        public List<Session> GetSessions(string scheduleID)
        {
            List<Session> sessions = new List<Session>();
            bool success = Connect();
            if (!success)
                return null;
            try
            {
                string strQuery = "SELECT * FROM SCHEDULE WHERE SchedulesID = @scheduleid";
                using (SqlCommand sqlcommand = new SqlCommand(strQuery, connection))
                {
                    sqlcommand.Parameters.AddWithValue("@scheduleid", scheduleID);
                    SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Session session = new Session();
                        session.thu = sqlDataReader.GetByte(2);
                        session.tiet = sqlDataReader.GetByte(3);
                        session.mon = sqlDataReader["SubjectID"] != DBNull.Value ? (string)sqlDataReader["SubjectID"] : null;
                        sessions.Add(session);
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
            return sessions;
        }
        public bool UpdateSchedule(Session Session, string scheduleID)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                string query = $"UPDATE  SCHEDULE SET" +
                    "SubjectID = @mon" +
                    $" WHERE Day = @thu" +
                    $" AND Session = @tiet" +
                    $" AND SchedulesID = @scheduleid";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@scheduleid", scheduleID.ToString());
                    sqlCommand.Parameters.AddWithValue("@thu", Session.thu.ToString());
                    sqlCommand.Parameters.AddWithValue("@tiet", Session.tiet.ToString());
                    sqlCommand.Parameters.AddWithValue("@mon", Session.mon);
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
        public bool AddSession(Session session, string scheduleID)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                string strQuery = "INSERT INTO SCHEDULE(ID, SubjectID, Day, Session, SchedulesID) " + 
                    "VALUES(@id, @subjectID, @day, @session, @scheduleID)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", session.ID);
                    sqlCommand.Parameters.AddWithValue("@subjectID", session.mon);
                    sqlCommand.Parameters.AddWithValue("@day", session.thu);
                    sqlCommand.Parameters.AddWithValue("@session", session.tiet);
                    sqlCommand.Parameters.AddWithValue("@scheduleID", scheduleID);
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
        public bool Delete(string id)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                string strQuery = $"DELETE FROM SCHEDULE WHERE SCHEDULE.ID = @id";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);
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
    }
}
