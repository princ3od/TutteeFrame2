using MaterialSurface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                strQuery = "SELECT * FROM SUBJECT";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    //add paramester here - but there no need paramester so pass to next line
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        subjects = new List<Subject>();
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
            catch (Exception e)
            {

            }
            finally
            {
                Disconnect();
            }
            return subjects;
        }
        /// <summary>
        ///  This function add subject into database 
        /// </summary>
        /// <param name="subject"> The object data of subject want to add into database</param>
        /// <returns> Return true if the progress is successed else return false</returns>

        public bool AddSubject(Subject subject)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "INSERT INTO SUBJECT(SubjectID, SubjectName) VALUES(@id,@name)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", subject.ID);
                    sqlCommand.Parameters.AddWithValue("@name", subject.Name);
                    sqlCommand.ExecuteNonQuery();
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
        /// <summary>
        /// This function find the object subject in database and delete it
        /// </summary>
        /// <param name="sbj">The object contain the data want to deleted in database</param>
        /// <returns>Return true if the progress is successed else return false</returns>

        public bool DeleteSubject(Subject subject)
        {
            bool succsess = Connect();

            if (!succsess)
                return false;
            try
            {
                strQuery = "DELETE FROM SUBJECT WHERE SubjectID =@SubjectID";
                using (SqlCommand sqlCommand = new SqlCommand())
                {

                    sqlCommand.CommandText = strQuery;
                    sqlCommand.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = subject.ID;
                    sqlCommand.Connection = connection;
                    sqlCommand.ExecuteNonQuery();
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
        /// <summary>
        /// Update data of the subject 
        /// </summary>
        /// <param name="sbj"> The subject want to update into the database</param>
        /// <returns>
        /// Return true if the progress is successed else return false<</returns>

        public bool UpdateSubject(Subject subject)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "UPDATE SUBJECT SET SubjectName = @sbjName WHERE SubjectID = @sbjId";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = strQuery;
                sqlCommand.Parameters.Add("@sbjName", SqlDbType.NVarChar).Value = subject.Name;
                sqlCommand.Parameters.Add("@sbjId", SqlDbType.VarChar).Value = subject.ID;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

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
