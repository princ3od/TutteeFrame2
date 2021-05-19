using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TutteeFrame2.Model;
namespace TutteeFrame2.DataAccess
{
    class AccountDA : BaseDA
    {
        private AccountDA() { }
        static readonly AccountDA _instance = new AccountDA();
        public static new AccountDA Instance => _instance;
        public Account AddAccount(Account account)
        {
            bool success = Connect();

            if (!success)
                return null;

            try
            {
                string query = "INSERT INTO ACCOUNT(AccountID,TeacherID,Password) VALUES(@id,@teacherid, @pass)";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", account.ID.ToString());
                    sqlCommand.Parameters.AddWithValue("@teacherid", account.TeacherID);
                    sqlCommand.Parameters.AddWithValue("@pass", account.Password);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return account;

        }

        public bool UpdatePassword(string accountID, string newPass)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = $"UPDATE ACCOUNT SET Password = @newpass WHERE TeacherID = @teacherid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newpass", newPass);
                    command.Parameters.AddWithValue("@teacherid", accountID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }

        public Account GetAccount(string teacherID)
        {

            bool success = Connect();

            if (!success)
                return null;

            Account account = new Account();

            try
            {
                string strQuery = "SELECT TOP 1 * FROM ACCOUNT WHERE TeacherID = @teacherid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", teacherID);
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            dataReader.Read();
                            account = new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
                        }
                        else
                            return null;
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return account;
        }

        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            bool success = Connect();

            if (!success)
                return null;
            try
            {
                Account account;
                string strQuery = "SELECT * FROM ACCOUNT";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    while (dataReader.Read())
                    {
                        account = new Account(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
                        accounts.Add(account);
                    }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return accounts;
        }

    }
}

