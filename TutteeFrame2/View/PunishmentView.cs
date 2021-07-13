using MaterialSurface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class PunishmentView : UserControl
    {
        PunishmentController controller;
        public HomeView Home;
        public string classIDFilter = "";
        public string gradeFilter = "";
        public bool firstLoad = true;
        public PunishmentView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            controller = new PunishmentController(this);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            cbbFilterByGrade.SelectedIndex = 0;
        }
        public void SetHome(HomeView home)
        {
            Home = home;
        }
        public void Fetch()
        {
            controller.FetchData();
        }
        public void ShowClasses(List<Class> classes)
        {
            cbbFilterByClass.Items.Clear();
            cbbFilterByClass.Items.Add("Tất cả");
            foreach (Class _class in classes)
            {
                cbbFilterByClass.Items.Add(_class.ClassID);
            }
            classIDFilter = "";
            cbbFilterByClass.SelectedIndex = 0;
        }
        public void ShowData()
        {
            listViewPunishment.Items.Clear();
            for (int i = 0; i < controller.punishments.Count; i++)
            {
                Punishment punishment = controller.punishments[i];
                listViewPunishment.Items.Add(new ListViewItem(new string[]
                    {
                        (i + 1).ToString(), punishment.ID, punishment.StudentID,
                        controller.studentName[punishment.ID],
                        string.Format("Học kì {0} ({1}", punishment.Semester, punishment.Year),
                        controller.studentClass[punishment.ID],
                        punishment.Fault,
                        punishment.Content
                    }));
            }
        }
        public void ShowDeleteResult(TeacherController.DeleteResult result)
        {
            switch (result)
            {
                case TeacherController.DeleteResult.Success:
                    Snackbar.MakeSnackbar(Home, "Đã xoá thành công!", "OK");
                    Fetch();
                    break;
                case TeacherController.DeleteResult.Fail:
                    Dialog.Show(Home, "Xoá thất bại, đã có lỗi xảy ra!", "Lỗi");
                    break;
                default:
                    break;
            }
        }
        private void OnChangeGrade(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            if (cbbFilterByGrade.SelectedIndex == 0)
                gradeFilter = "";
            else
                gradeFilter = cbbFilterByGrade.Text;
            txtSearch.Clear();
            _ = controller.FetchClasses();
        }

        private void OnChangeClass(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            if (cbbFilterByClass.SelectedIndex == 0)
                classIDFilter = "";
            else
                classIDFilter = cbbFilterByClass.Text;
            txtSearch.Clear();
            cbbFilterByGrade.Enabled = false;
            _ = controller.FetchPunishments();
            cbbFilterByGrade.Enabled = true;
        }

        private void OnSearch(object sender, EventArgs e)
        {
            controller.FilterSearch(txtSearch.Text);
        }

        private void OnChoosePunishment(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = (listViewPunishment.SelectedItems.Count > 0);
        }

        private void OnDeletePunishment(object sender, EventArgs e)
        {
            if (listViewPunishment.SelectedItems.Count > 0)
            {
                if (Dialog.Show(Home, "Bạn chắc chắn muốn xoá vi phạm này?", "Xác nhận", Buttons.YesNo) == DialogResult.Yes)
                    controller.DeletePunishment(listViewPunishment.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void OnAddPunishment(object sender, EventArgs e)
        {
            if (listViewPunishment.SelectedItems.Count <= 0)
                return;
            OnePunishmentView onePunishmentView = new OnePunishmentView(listViewPunishment.SelectedItems[0].SubItems[2].Text,
                OnePunishmentView.Mode.Edit, OnePunishmentView.OpenMode.Full, listViewPunishment.SelectedItems[0].SubItems[1].Text);
            OverlayForm _ = new OverlayForm(Home, onePunishmentView);
            onePunishmentView.FormClosing += (s, ev) =>
            {
                if (onePunishmentView.success)
                {
                    Snackbar.MakeSnackbar(Home, string.Format("Cập nhật/thêm vi phạm thành công (ID: {0})", onePunishmentView.punishmentID), "OK");
                    Fetch();
                }
            };
            onePunishmentView.Show();
        }
    }
}
