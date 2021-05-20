using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSurface;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.Utils;
using TutteeFrame2.Model;

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
        /// <summary>
        /// Set homeView for subjectView, avariable subjectView is in another part of HomeView (design code)
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            subjectView.SetHome(this);

        }

        public void CreateLoginView()
        {
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();
            this.Hide();
            Application.Restart();
        }

        public void LoadTeacher(string teacherID, string sessionID)
        {
            controller.sessionID = sessionID;
            controller.logined = true;
            controller.LoadTeacher(teacherID);
        }
        public void ShowData()
        {
            lbNameBig.Text = lbName.Text = controller.mainTeacher.GetName();
            ptbSmallAvatar.Image = ImageHelper.CropCircle(controller.mainTeacher.Avatar);
            ptbAvatarBig.Image = ImageHelper.CropCircle(controller.mainTeacher.Avatar);
            lbPositionBig.Text = lbPosition.Text = controller.mainTeacher.Position;
            Decentralize();
        }

        private void Decentralize()
        {
            mainTabControl.TabPages.Clear();
            if (controller.mainTeacher.Type != Teacher.TeacherType.SuperUser)
            {
                mainTabControl.TabPages.Add(home);
                switch (controller.mainTeacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        mainTabControl.TabPages.Add(bangDiemHocSinh);
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        mainTabControl.TabPages.Add(quanLiGiaoVien);
                        mainTabControl.TabPages.Add(phanCongGiaoVien);
                        mainTabControl.TabPages.Add(quanLiMon);
                        mainTabControl.TabPages.Add(baoCao);
                        break;
                    case Teacher.TeacherType.Ministry:
                        mainTabControl.TabPages.Add(quanLiHocSinh);
                        mainTabControl.TabPages.Add(quanLiLop);
                        mainTabControl.TabPages.Add(quanLiKiLuat);
                        mainTabControl.TabPages.Add(quanLiTKB);
                        mainTabControl.TabPages.Add(baoCao);
                        break;
                    case Teacher.TeacherType.FormerTeacher:
                        mainTabControl.TabPages.Add(bangDiemHocSinh);
                        mainTabControl.TabPages.Add(lopChuNhiem);
                        mainTabControl.TabPages.Add(quanLiViPham);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                mainTabControl.TabPages.Add(home);
                mainTabControl.TabPages.Add(quanLiGiaoVien);
                mainTabControl.TabPages.Add(phanCongGiaoVien);
                mainTabControl.TabPages.Add(quanLiMon);
                mainTabControl.TabPages.Add(quanLiHocSinh);
                mainTabControl.TabPages.Add(quanLiLop);
                mainTabControl.TabPages.Add(quanLiKiLuat);
                mainTabControl.TabPages.Add(quanLiTKB);
                mainTabControl.TabPages.Add(baoCao);
            }
        }

        public void OnCorrupt(DataAccess.SessionStatus sessionStatus)
        {
            switch (sessionStatus)
            {
                case DataAccess.SessionStatus.Valid:
                    break;
                case DataAccess.SessionStatus.NotValid:
                    if (Dialog.Show(this, "Tài khoản này bị đăng nhập tại nơi khác.\n Bạn sẽ bị đăng xuất!", "Lỗi đăng nhập", Buttons.Ok) == DialogResult.OK)
                        controller.Logout();
                    break;
                case DataAccess.SessionStatus.NoConnection:
                    controller.StartCheckSession();
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
        public void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
        }
        private void OnLogout(object sender, EventArgs e)
        {
            controller.Logout();
            utilityBar.Height = 55;
        }

        private void CloseUtilityBar(object sender, EventArgs e)
        {
            utilityBar.Height = 55;
        }

        private void OpenUtilityBar(object sender, EventArgs e)
        {
            if (utilityBar.Height <= 55)
                utilityBar.Height = 250;
            else
                utilityBar.Height = 55;
        }

        private void OnTabpageChanged(object sender, EventArgs e)
        {
            switch (mainTabControl.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        //Dialog.Show(this, "13132131321", tittle: "Thông báo");
                        subjectView.LoadSubjects();
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                        break;
                    }
                case 8:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
