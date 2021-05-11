using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.DataAccess
{
    class TeacherDA : BaseDA
    {
        private TeacherDA() { }

        static readonly TeacherDA instance = new TeacherDA();

        public static new TeacherDA Instance => instance;
        public Teacher GetTeacher(string teacherID)
        {
            bool success = Connect();

            if (!success)
                return null;

            Teacher teacher = new Teacher();
            try
            {
                string strQuery = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID" +
                    " WHERE TeacherID=@teacherid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", teacherID);
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        dataReader.Read();
                        teacher.Subject = new Subject();
                        teacher.ID = dataReader.GetString(0);
                        teacher.SurName = dataReader.GetString(1);
                        teacher.FirstName = dataReader.GetString(2);
                        if (!(dataReader["TeacherImage"] is DBNull))
                            teacher.Avatar = ImageHelper.BytesToImage((byte[])dataReader["TeacherImage"]);
                        else
                            teacher.Avatar = null;
                        teacher.DateBorn = dataReader.GetDateTime(4);
                        teacher.Sex = dataReader.GetBoolean(5);
                        teacher.Address = dataReader.GetString(6);
                        teacher.Phone = dataReader.GetString(7);
                        teacher.Mail = dataReader.GetString(8);
                        teacher.Subject.ID = dataReader.GetString(9);
                        if (dataReader.GetBoolean(10))
                            teacher.Type = Teacher.TeacherType.Ministry;
                        else if (dataReader.GetBoolean(11))
                            teacher.Type = Teacher.TeacherType.Adminstrator;
                        else
                            teacher.Type = Teacher.TeacherType.Teacher;
                        //teacher.Subject.Name = dataReader["SubjectName"].ToString();
                        teacher.Position = dataReader.GetString(12);
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
            return teacher;
        }
    }
}
