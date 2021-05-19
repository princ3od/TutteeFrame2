using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.Model;

namespace TutteeFrame2.DataAccess
{
    class SubjectDA : BaseDA
    {
        private SubjectDA() { }

        static readonly SubjectDA instance = new SubjectDA();

        public static new SubjectDA Instance => instance;

        public List<Subject> GetSubjects ()
        {
            bool success = Connect();

            if (!success)
                return null;

            List<Subject> subjects = new List<Subject>();
            try
            {
                string query = "SELECT * FROM SUBJECT";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        Subject subject = new Subject(reader.GetString(0), reader.GetString(1));
                        subjects.Add(subject);
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
            return subjects;
        }
    }
}
