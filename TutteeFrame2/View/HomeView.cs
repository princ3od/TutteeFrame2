﻿using MaterialSurface;
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
        public enum TabName
        {
            TrangChu,
            QuanLiGiaoVien,
            QuanLiHocSinh,
            BangDiemHocSinh,
            QuanLiMon,
            QuanLiLop,
            QuanLiKiLuat,
            BaoCao,
            LopChuNhiem,
            PhanCongGiaoVien,
            QuanLiViPham,
            QuanLiTKB,
            QuanLiLichHop,
        };
        HomeController controller;
        public bool isChildShowing = false;
        NoConnectionView noConnectionView;

        public HomeView()
        {
            InitializeComponent();
            DoubleBuffered = true;
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
            teacherView.SetHome(this);
            subjectView.SetHome(this);
            classView.SetHome(this);
            studentView.SetHome(this);
            punishmentView.SetHome(this);
            teacherAssignmentView.SetHome(this);
            studentScoreboardView.SetHome(this);
            reportView.SetHome(this);
            schedule.SetHome(this);
        }

        public void LoadTeacher(string teacherID, string sessionID)
        {
            controller.sessionID = sessionID;
            controller.logined = true;
            controller.LoadTeacher(teacherID);  
        }

        public void ShowData()
        {
            lbName.Text = materialLabel1.Text = controller.mainTeacher.GetName();
            materialLabel2.Text = controller.mainTeacher.GetSubject();
            materialLabel3.Text = controller.mainTeacher.GetID();
            materialLabel4.Text = controller.mainTeacher.GetPosition();
            materialLabel5.Text = (controller.mainTeacher.Sex) ? "Nam" : "Nữ";
            materialLabel6.Text = controller.mainTeacher.GetBirthday().Substring(0, 10);
            materialLabel7.Text = "Tổ " + controller.mainTeacher.GetSubject();
            materialLabel8.Text = controller.mainTeacher.GetAdress();
            materialLabel9.Text = controller.mainTeacher.GetMail();
            materialLabel10.Text = controller.mainTeacher.GetNumber();
            ptbSmallAvatar.Image = ImageHelper.CropCircle(controller.mainTeacher.Avatar);
            ptbAvatarBig.Image = ImageHelper.CropCircle(controller.mainTeacher.Avatar);
            lbPosition.Text = controller.mainTeacher.Position;
            Snackbar.MakeSnackbar(this, string.Format("Xin chào {0}", controller.mainTeacher.GetName()), "HELLO");
            studentScoreboardView.SetMainTeacher(controller.mainTeacher);
            formClassView.SetHome(this, controller.mainTeacher);
            faultView.SetHome(this, controller.mainTeacher);
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
            mainTabControl.Enabled = !isLoading;
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
            if (mainTabControl.SelectedTab == null)
                return;
            lbTittle.Text = mainTabControl.SelectedTab.Text;
            switch ((TabName)(Int32.Parse(mainTabControl.SelectedTab.Tag.ToString())))
            {
                case TabName.TrangChu:
                    break;
                case TabName.QuanLiGiaoVien:
                    teacherView.Fetch();
                    break;
                case TabName.QuanLiHocSinh:
                    studentView.FetchData();
                    break;
                case TabName.BangDiemHocSinh:
                    studentScoreboardView.Fetch();
                    break;
                case TabName.QuanLiMon:
                    subjectView.LoadSubjects();
                    break;
                case TabName.QuanLiLop:
                    classView.Fetch();
                    break;
                case TabName.QuanLiKiLuat:
                    punishmentView.Fetch();
                    break;
                case TabName.BaoCao:
                    break;
                case TabName.LopChuNhiem:
                    formClassView.Fetch();
                    break;
                case TabName.PhanCongGiaoVien:
                    teacherAssignmentView.Fetch();
                    break;
                case TabName.QuanLiViPham:
                    faultView.Fetch();
                    break;
                case TabName.QuanLiTKB:
                    schedule.FetchData();
                    break;
                case TabName.QuanLiLichHop:
                    break;
                default:
                    break;
            }
        }

        private void OnChangePassword(object sender, EventArgs e)
        {
            ChangePassView changePassView = new ChangePassView(controller.mainTeacher.ID);
            OverlayForm _ = new OverlayForm(this, changePassView);
            changePassView.Show();
        }

        private void OnChangeSchoolInfo(object sender, EventArgs e)
        {
            ChangeSchooInfo changeSchoolInfoView = new ChangeSchooInfo(controller.mainTeacher.ID.ToUpper());
            OverlayForm _ = new OverlayForm(this, changeSchoolInfoView);
            changeSchoolInfoView.Show();
        }
    }
}
