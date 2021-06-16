using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.DataAccess
{
    class SchoolDA:BaseDA
    {
        private SchoolDA() { }
        public  static SchoolDA instance = new SchoolDA();
       public  DataTable getSchoolInfo()
        {
            bool success = Connect();

            if (!success)
                return null;
            try
            {
                DataTable dataTable = new DataTable();
                using (SqlCommand sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.CommandText = "SELECT * FROM SCHOOLINFO";

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dataTable);
                    Disconnect();
                    adapter.Dispose();
                    return dataTable;
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

        }
    }
}
