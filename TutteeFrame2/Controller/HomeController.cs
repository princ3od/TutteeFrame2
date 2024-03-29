﻿using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.View;
using TutteeFrame2.Model;

namespace TutteeFrame2.Controller
{
    class HomeController
    {
        HomeView view;
        SessionStatus currentStatus = SessionStatus.Valid;

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
            LoginView loginView = new LoginView(view);
            view.Hide();
            loginView.FormClosed += (s, ev) =>
            {
                if (loginView.DialogResult == DialogResult.OK)
                    view.Show();
                else
                    Application.Exit();
            };
            loginView.ShowDialog();
        }
        public async void LoadTeacher(string teacherID)
        {
            view.SetLoad(true, "Đang tải thông tin người dùng...");
            await Task.Delay(200);
            await Task.Run(() =>
            {
                mainTeacher = TeacherDA.Instance.GetTeacher(teacherID);
                mainTeacher.FormClassID = TeacherDA.Instance.GetInchargeClass(mainTeacher.ID);
                if (!string.IsNullOrEmpty(mainTeacher.FormClassID))
                {
                    mainTeacher.Type = TeacherType.FormerTeacher;
                }
                if (mainTeacher.ID.ToUpper() == "AD999999")
                {
                    mainTeacher.Type = TeacherType.SuperUser;
                    mainTeacher.Position = "Tài khoản admin";
                }
            });
            view.ShowData();
            view.SetLoad(false);
            currentStatus = SessionStatus.Valid;
            StartCheckSession();
        }
        public async void StartCheckSession()
        {
            SessionStatus sessionStatus = currentStatus;
            await Task.Run(async () =>
            {
                while (currentStatus == sessionStatus && logined)
                {
                    await Task.Delay(550);
                    if (!SessionDA.Instance.isChannelBusy && mainTeacher != null)
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
                    break;
                case SessionStatus.NoConnection:
                    break;
                default:
                    break;
            }
        }
    }
}
