using MaterialSurface;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using TutteeFrame2.Controller;
using TutteeFrame2.Model;
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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (Dialog.Show(this, "Bạn chắc chắn muốn thoát?", "Xác nhận", Buttons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Snackbar.PrimaryColor = Color.FromArgb(47, 144, 176);
            Dialog.PrimaryColor = Color.FromArgb(47, 144, 176);
            teacherView1.SetHome(this);
            subjectView.SetHome(this);
            studentView.SetHome(this);
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
            if (controller.mainTeacher.Type != TeacherType.SuperUser)
            {
                mainTabControl.TabPages.Add(home);
                switch (controller.mainTeacher.Type)
                {
                    case TeacherType.Teacher:
                        mainTabControl.TabPages.Add(bangDiemHocSinh);
                        break;
                    case TeacherType.Adminstrator:
                        mainTabControl.TabPages.Add(quanLiGiaoVien);
                        mainTabControl.TabPages.Add(phanCongGiaoVien);
                        mainTabControl.TabPages.Add(quanLiMon);
                        mainTabControl.TabPages.Add(baoCao);
                        break;
                    case TeacherType.Ministry:
                        mainTabControl.TabPages.Add(quanLiHocSinh);
                        mainTabControl.TabPages.Add(quanLiLop);
                        mainTabControl.TabPages.Add(quanLiKiLuat);
                        mainTabControl.TabPages.Add(quanLiTKB);
                        mainTabControl.TabPages.Add(baoCao);
                        break;
                    case TeacherType.FormerTeacher:
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
                        teacherView1.Fetch();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        subjectView.LoadSubjects();
                        break;
                    }
                case 4:
                    {
                        studentView.FetchData();
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
