using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TutteeFrame2.DataAccess
{
    public enum SessionStatus
    {
        Valid,
        NotValid,
        NoConnection,
    }
    class SessionDA : BaseDA
    {
        private SessionDA() { }

        static readonly SessionDA instance = new SessionDA();

        public static new SessionDA Instance => instance;

        public string CreateSession(string _accountID, string _sessionID)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = "INSERT INTO SESSION(AccountID, SessionID) VALUES(@accountid,@sessionid)";
                    sqlCommand.Parameters.AddWithValue("@accountid", _accountID);
                    sqlCommand.Parameters.AddWithValue("@sessionid", _sessionID);
                    sqlCommand.ExecuteNonQuery();
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
            return _sessionID;
        }
        public string DeleteSession(string _accountID, string _sessionID)
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = "DELETE FROM SESSION WHERE AccountID = @accountid AND SessionID = @sessionid";
                    sqlCommand.Parameters.AddWithValue("@accountid", _accountID);
                    sqlCommand.Parameters.AddWithValue("@sessionid", _sessionID);
                    sqlCommand.ExecuteNonQuery();
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
            return _sessionID;
        }
        public SessionStatus CheckSession(string _accountID, string _sessionID)
        {
            bool success = Connect(), isExist = false;

            if (!success)
                return SessionStatus.NoConnection;
            try
            {
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM SESSION WHERE AccountID = @accountid AND SessionID = @sessionid";
                    sqlCommand.Parameters.AddWithValue("@accountid", _accountID);
                    sqlCommand.Parameters.AddWithValue("@sessionid", _sessionID);
                    isExist = ((int)sqlCommand.ExecuteScalar() > 0);
                }
            }
            catch (Exception)
            {
                return SessionStatus.NoConnection;
            }
            finally
            {
                Disconnect();
            }
            if (isExist)
                return SessionStatus.Valid;
            return SessionStatus.NotValid;
        }
    }
}
