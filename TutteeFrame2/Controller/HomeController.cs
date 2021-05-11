using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.View;
using MaterialSkin.Controls;
using TutteeFrame2.Model;

namespace TutteeFrame2.Controller
{
    class HomeController
    {
        HomeView view;
        SessionStatus currentStatus;

        public Teacher mainTeacher;
        public string sessionID;
        public bool logined = false;
        public HomeController(HomeView view)
        {
            this.view = view;
        }
        public void Logout()
        {
            SessionDA.Instance.DeleteSession(mainTeacher.ID, sessionID);
            logined = false;
            view.CreateLoginView();
        }
        public void LoadTeacher(string teacherID)
        {
            mainTeacher = TeacherDA.Instance.GetTeacher(teacherID);
        }
        public async void StartCheckSession()
        {
            SessionStatus sessionStatus = currentStatus;
            await Task.Run(async () =>
            {
                while (currentStatus == sessionStatus && logined)
                {
                    await Task.Delay(550);
                    if (!SessionDA.Instance.isChannelBusy)
                    {
                        sessionStatus = SessionDA.Instance.CheckSession(mainTeacher.ID, sessionID);
                    }
                }
            });
            if (!logined)
                return;
            currentStatus = sessionStatus;
            view.OnCorrupt(currentStatus);
            switch (currentStatus)
            {
                case SessionStatus.Valid:
                    view.OnReconnect();
                    break;
                case SessionStatus.NotValid:
                    Logout();
                    break;
                case SessionStatus.NoConnection:
                    break;
                default:
                    break;
            }
        }
    }
}
