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
        #region variable secsion
        List<Subject> subjects;

        #endregion
        /// <summary>
        /// This function get all subjects from database where subject detail was saved.
        /// </summary>
        /// <returns></returns>

        public List<Subject> GetSubjects()
        {
            bool success = Connect();
            if (!success)
                return null;

            try
            {
                String strQuery = "SELECT * FROM SUBJECT";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    //add paramester here - but there no need paramester so pass to next line
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        subjects = new  List<Subject>();
                        while (dataReader.Read())
                        {
                            Subject subject = new Subject();
                            subject.ID = dataReader.GetString(0);
                            subject.Name = dataReader.GetString(1);
                            subjects.Add(subject);
                        }
                    }

                };

            }
            catch(Exception e)
            {

            }
            finally
            {
                Disconnect();
            }
            return subjects;
        }
    }
}
