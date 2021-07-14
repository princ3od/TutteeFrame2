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
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class FaultView : UserControl
    {
        FaultController controller;
        public HomeView Home;
        public Teacher mainTeacher;
        public bool firstLoad = true;
        public FaultView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            controller = new FaultController(this);
        }
        public void SetHome(HomeView _home, Teacher _teacher)
        {
            this.Home = _home;
            mainTeacher = _teacher;
            lbFormClass.Text = _teacher.FormClassID;
        }
        public async void Fetch()
        {
            await controller.FetchFault();
        }
        public void ShowData()
        {
            lbTotalFault.Text = controller.punishments.Count.ToString();
            listViewFault.Items.Clear();
            for (int i = 0; i < controller.punishments.Count; i++)
            {
                listViewFault.Items.Add(new ListViewItem(new string[]
                    {
                            (i + 1).ToString(),
                            controller.punishments[i].ID,
                            controller.punishments[i].StudentID,
                            controller.studentName[controller.punishments[i].StudentID],
                            controller.punishments[i].Semester.ToString(),
                            controller.punishments[i].Fault
                    }));
            }
        }

        private void OnUpdateFault(object sender, EventArgs e)
        {
            string studentID = listViewFault.SelectedItems[0].SubItems[2].Text;
            string punishmentID = listViewFault.SelectedItems[0].SubItems[1].Text;

            OnePunishmentView punishmentView = new OnePunishmentView(studentID, OnePunishmentView.Mode.Edit, OnePunishmentView.OpenMode.FaultOnly, punishmentID);
            punishmentView.FormClosed += (s, ev) =>
            {
                if (punishmentView.success)
                {
                    Snackbar.MakeSnackbar(Home, string.Format("Đã cập nhật thành công vi phạm ({0}) của học sinh {1} ({2})", punishmentID, controller.studentName[studentID], studentID), "OK");
                    Fetch();
                }
            };
            OverlayForm _ = new OverlayForm(Home, punishmentView);
            punishmentView.Show();
        }

        private void OnDeleteFault(object sender, EventArgs e)
        {
            if (listViewFault.SelectedItems.Count > 0)
            {
                if (Dialog.Show(Home, "Bạn chắc chắn muốn xoá vi phạm này?", "Xác nhận", Buttons.YesNo) == DialogResult.Yes)
                    controller.DeletePunishment(listViewFault.SelectedItems[0].SubItems[1].Text);
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

        private void OnChooseFault(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = (listViewFault.SelectedItems.Count > 0);
        }
    }
}
