using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Model;

namespace TutteeFrame2.DataAccess
{
    class PunishmentDA : BaseDA
    {
        private PunishmentDA() { }

        static readonly PunishmentDA instance = new PunishmentDA();

        public static new PunishmentDA Instance => instance;
        public Punishment GetPunishment(string punishmentID)
        {
            bool success = Connect();

            if (!success)
                return null;

            Punishment punishment = new Punishment();

            try
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM PUNISHMENT WHERE PUNISHMENT.PunishmentID = @id";
                    cmd.Parameters.AddWithValue("@id", punishmentID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        punishment.ID = reader.GetString(0);
                        punishment.StudentID = reader.GetString(1);
                        if (!reader.IsDBNull(2))
                            punishment.Content = reader.GetString(2);
                        else
                            punishment.Content = string.Empty;
                        punishment.Fault = reader.GetString(3);
                        punishment.Grade = Int32.Parse(reader.GetString(4));
                        punishment.Semester = reader.GetInt32(5);
                        punishment.Year = reader.GetInt32(6);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return punishment;
        }
        public Punishment AddPunishment(Punishment punishment)
        {
            bool success = Connect();

            if (!success)
                return null;

            try
            {
                strQuery = "INSERT INTO PUNISHMENT(PunishmentID, StudentID, Fault, Grade, Semester, Year) " +
                    "VALUES(@punishmentid, @studentid, @fault, @grade, @semester, @year)";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@punishmentid", punishment.ID);
                    cmd.Parameters.AddWithValue("@studentid", punishment.StudentID);
                    cmd.Parameters.AddWithValue("@fault", punishment.Fault);
                    cmd.Parameters.AddWithValue("@grade", punishment.Grade);
                    cmd.Parameters.AddWithValue("@semester", punishment.Semester);
                    cmd.Parameters.AddWithValue("@year", punishment.Year);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return punishment;
        }
        public Punishment UpdatePunishment(string punishmentID, Punishment newPunishment)
        {
            bool success = Connect();

            if (!success)
                return null;

            try
            {
                strQuery = "UPDATE PUNISHMENT SET Content = @content, Fault = @fault, Semester = @sem, Grade = @grade, Year = @year" +
                    " WHERE PunishmentID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", punishmentID);
                    cmd.Parameters.AddWithValue("@content", newPunishment.Content);
                    cmd.Parameters.AddWithValue("@fault", newPunishment.Fault);
                    cmd.Parameters.AddWithValue("@sem", newPunishment.Semester);
                    cmd.Parameters.AddWithValue("@grade", newPunishment.Grade);
                    cmd.Parameters.AddWithValue("@year", newPunishment.Year);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return newPunishment;
        }
        public string DeletePunishment(string punishmentID)
        {
            bool success = Connect();

            if (!success)
                return null;

            try
            {
                strQuery = "DELETE FROM PUNISHMENT WHERE PunishmentID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", punishmentID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return punishmentID;
        }
        public List<Punishment> GetPunishments(string classID = "", string grade = "")
        {
            bool success = Connect();

            if (!success)
                return null;

            List<Punishment> punishments = new List<Punishment>();
            try
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (string.IsNullOrEmpty(grade) && string.IsNullOrEmpty(classID))
                        cmd.CommandText = "SELECT * FROM PUNISHMENT";
                    else
                    {
                        if (string.IsNullOrEmpty(classID))
                        {
                            cmd.CommandText = "SELECT * FROM PUNISHMENT JOIN STUDENT ON PUNISHMENT.StudentID = STUDENT.StudentID WHERE ClassID LIKE @grade";
                            cmd.Parameters.AddWithValue("@grade", string.Format(grade + "%%"));
                        }
                        else
                        {
                            cmd.CommandText = "SELECT * FROM PUNISHMENT JOIN STUDENT ON PUNISHMENT.StudentID = STUDENT.StudentID WHERE ClassID = @classid";
                            cmd.Parameters.AddWithValue("@classid", classID);
                        }
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Punishment punishment = new Punishment();
                            punishment.ID = reader.GetString(0);
                            punishment.StudentID = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                                punishment.Content = reader.GetString(2);
                            else
                                punishment.Content = string.Empty;
                            punishment.Fault = reader.GetString(3);
                            punishment.Grade = Int32.Parse(reader.GetString(4));
                            punishment.Semester = reader.GetInt32(5);
                            punishment.Year = reader.GetInt32(6);
                            punishments.Add(punishment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return punishments;
            }
            finally
            {
                Disconnect();
            }
            return punishments;
        }
    }
}
