using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;
using TutteeFrame2.View;

namespace TutteeFrame2.Controller
{
    public class SchoolInfoController
    {
        private ChangeSchooInfo changeSchoolInfoView;
        private SchoolDA schoolDA;
        public School mySchool;
        private String userID;
        public SchoolInfoController(ChangeSchooInfo changeSchoolInfoView, String userID)
        {
            this.changeSchoolInfoView = changeSchoolInfoView;
            this.schoolDA = SchoolDA.instance;
            this.userID = userID;
        }

        public async void UpdateSchool(School newSchool)
        {
            bool succes = false;
            await Task.Run( () =>
            {
                if (schoolDA.Update(newSchool))
                {
                    succes = true;
                }
            }
                );
            if (succes) {
                await FetchDataAsync();
            }
        }
        public async Task FetchDataAsync()
        {
            await Task.Run(
                 () =>
                 {
                     School result = null;
                     DataTable table = schoolDA.getSchoolInfo();
                     if (table != null)
                     {
                         result = new School();
                         foreach (DataRow row in table.Rows)
                         {
                             result.STT = row["STT"].ToString();
                             result.Logo = ImageHelper.BytesToImage((byte[])row["Logo"]);
                             result.Slogan = row["Slogan"].ToString();
                             result.FullName = row["FullName"].ToString();
                         }
                     };
                     mySchool = result;
                 }
                 );

            changeSchoolInfoView.ShowData();

        }
    }
}
