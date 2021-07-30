using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

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
            catch (Exception)
            {
                return null;

            }
            finally
            {
                Disconnect();
            }

        }
   
       public bool Update(School newSchool)
        {

            bool success = Connect();
            if (!success)
            {
                return false;
            }

            try
            {
                byte[] photo = ImageHelper.ImageToBytes(newSchool.Logo);
                string query = $"UPDATE  SCHOOLINFO SET " +
                    "Slogan = @slogan," +
                    "FullName = @fullName," +
                    "Logo = @logo" +
                    $" WHERE STT = @stt";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@stt", newSchool.STT);
                    sqlCommand.Parameters.AddWithValue("@slogan", newSchool.Slogan);
                    sqlCommand.Parameters.AddWithValue("@fullName", newSchool.FullName);
                    sqlCommand.Parameters.Add("@logo", SqlDbType.Image, photo.Length).Value = photo;
                    sqlCommand.ExecuteNonQuery();
                }
                Disconnect();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Disconnect();
                return false;

            }
        }
    }
}
