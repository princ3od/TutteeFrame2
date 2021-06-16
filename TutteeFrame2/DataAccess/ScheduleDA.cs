using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                String sqrQuery = $"SELECT * FROM SCHEDULES WHERE ClassID = @classid AND Semester = @semester AND Year = @year";
                using (SqlCommand sqlcomannd = new SqlCommand(strQuery, connection))
                {
                    sqlcomannd.Parameters.AddWithValue("@classid", classID.ToString());
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
            return scheduleID;
        }
        public List<Session> GetSessions(string scheduleID)
        {
            List<Session> sessions = new List<Session>();
            bool success = Connect();
            if (!success)
                return null;
            try
            {
                string sqrQuery = $"SELLECT * FROM SCHEDULE WHERE SchedulesID = @scheduleid";
                using (SqlCommand sqlcommand = new SqlCommand(strQuery, connection))
                {
                    sqlcommand.Parameters.AddWithValue("@scheduleid", scheduleID.ToString());
                    SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Session session = new Session();
                        session.thu = sqlDataReader["Day"] != null ? (int)sqlDataReader["Day"] : 0;
                        session.tiet = sqlDataReader["Session"] != null ? (int)sqlDataReader["Session"] : 0;
                        session.mon = sqlDataReader["SubjectID"] != null ? (string)sqlDataReader["SubjectID"] : null;
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
                strQuery = "INSERT INTO SCHEDULE(id, subjectID, day, session, scheduleID) " + 
                    "VALUE(@id, @subjectID, @day, @session, @scheduleID)";
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
    }
}
