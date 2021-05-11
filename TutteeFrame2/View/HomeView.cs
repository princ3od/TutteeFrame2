using MaterialSkin.Controls;
using MaterialSurface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class HomeView : Form
    {
        HomeController controller;
        public bool isChildShowing = false;
        NoConnectionView noConnectionView;
        public HomeView()
        {
            InitializeComponent();
            controller = new HomeController(this);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        public void CreateLoginView()
        {
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
            this.Hide();
            LoginView loginView = new LoginView(this);
            loginView.ShowDialog();
            if (loginView.DialogResult == DialogResult.OK)
                this.Show();
            else
                this.Close();
        }

        public void LoadTeacher(string teacherID, string sessionID)
        {
            controller.sessionID = sessionID;
            controller.logined = true;
            controller.StartCheckSession();
            controller.LoadTeacher(teacherID);
        }
        public void OnCorrupt(TutteeFrame2.DataAccess.SessionStatus sessionStatus)
        {
            controller.StartCheckSession();
            switch (sessionStatus)
            {
                case DataAccess.SessionStatus.Valid:
                    break;
                case DataAccess.SessionStatus.NotValid:
                    Dialog.Show(this, "Tài khoản này bị đăng nhập tại nơi khác.\n Bạn sẽ bị đăng xuất!");
                    break;
                case DataAccess.SessionStatus.NoConnection:
                    noConnectionView = new NoConnectionView();
                    OverlayForm overlayForm = new OverlayForm(this, noConnectionView);
                    noConnectionView.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        public void OnReconnect()
        {
            noConnectionView?.Close();
        }
        public void Decentralize(string[] accessPart)
        {
        }
        public void SetLoad(bool isLoading, string loadInformation)
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = isLoading;
        }
        private void OnLogout(object sender, EventArgs e)
        {
            controller.Logout();
        }
    }
}
