using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.Utils;

namespace TutteeFrame2.DataAccess
{
    public enum ConnectionType { Server, Local };
    class BaseDA
    {

        protected BaseDA() { }

        private static readonly BaseDA instance = new BaseDA();
        public static BaseDA Instance => instance;

        #region Variables
        protected static string connectionString;

        protected SqlConnection connection;
        protected string strQuery;
        public bool isChannelBusy = false;
        #endregion


        #region Server Function
        /// <summary>
        /// Hàm thực hiện kết nối ban đầu, nếu thành công sẽ lưu lại chuỗi kết nối.
        /// </summary>
        /// <param name="_server"></param>
        /// <param name="_port"></param>
        /// <param name="_userid"></param>
        /// <param name="_pass"></param>
        /// <returns> Việc kết nối đến server lúc đầu có thành công hay không. </returns>
        public bool CreateConnect(string _server, string _port, string _userid, string _pass)
        {
            bool success = true;
            string strConnect = string.Format(AppSettings.Instance.ServerConnectionString,
                   _server, _port, _userid, _pass);
            try
            {
                connection = new SqlConnection(strConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            connectionString = strConnect;
            return success;
        }

        public bool CreateLocalConnect()
        {
            bool success = true;

            string strConnect = AppSettings.Instance.LocalConnectionString;
            try
            {
                connection = new SqlConnection(strConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }
            connectionString = strConnect;
            return success;
        }
        /// <summary>
        /// Hàm mở kết nối đến server.
        /// </summary>
        /// <returns> Thực hiện kết nối thành công hay không. </returns>
        protected bool Connect()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                isChannelBusy = false;
                return false;
            }
            isChannelBusy = true;
            return true;
        }
        /// <summary>
        /// Ngắt kết nối server.
        /// </summary>
        protected void Disconnect()
        {
            if (connection != null)
                connection.Close();
            isChannelBusy = false;
        }
        #endregion

    }
}
