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
    public partial class FormClassView : UserControl
    {
        FormClassController controller;
        public HomeView Home;
        public Teacher mainTeacher;
        public FormClassView()
        {
            InitializeComponent();
            controller = new FormClassController(this);
        }
        public void Fetch()
        {
            controller.FetchData();
        }
        public void SetHome(HomeView _home, Teacher _teacher)
        {
            this.Home = _home;
            mainTeacher = _teacher;
            lbFormClass.Text = _teacher.FormClassID;
        }
        public void ShowData()
        {
            if (controller.students == null)
            {
                Dialog.Show(Home, "Đã có lỗi xảy ra, vui lòng thử lại", "Lỗi");
                return;
            }

            lbTotalStudentInClass.Text = controller.students.Count.ToString();
            listviewStudentInClass.Items.Clear();
            for (int i = 0; i < controller.students.Count; i++)
            {
                listviewStudentInClass.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), controller.students[i].ID, controller.students[i].GetName(),
                                "--","","--","","--",""}));
                if (controller.averageScoreList[controller.students[i].ID][0].Value > -1)
                    listviewStudentInClass.Items[i].SubItems[3].Text = controller.averageScoreList[controller.students[i].ID][0].Value.ToString("F");
                listviewStudentInClass.Items[i].SubItems[4].Text = controller.studentConducts[controller.students[i].ID].Conducts[0].GetReadableValue();
                if (controller.averageScoreList[controller.students[i].ID][1].Value > -1)
                    listviewStudentInClass.Items[i].SubItems[5].Text = controller.averageScoreList[controller.students[i].ID][1].Value.ToString("F");
                listviewStudentInClass.Items[i].SubItems[6].Text = controller.studentConducts[controller.students[i].ID].Conducts[1].GetReadableValue();
                if (controller.averageScoreList[controller.students[i].ID][2].Value > -1)
                    listviewStudentInClass.Items[i].SubItems[7].Text = controller.averageScoreList[controller.students[i].ID][2].Value.ToString("F");
                listviewStudentInClass.Items[i].SubItems[8].Text = controller.studentConducts[controller.students[i].ID].Conducts[2].GetReadableValue();


            }
        }

        private void OnChooseStudent(object sender, EventArgs e)
        {
            btnViewInfo.Enabled = btnViewStudentScore.Enabled = btnSetConduct.Enabled = btnAddFault.Enabled = (listviewStudentInClass.SelectedItems.Count > 0);
        }

        private void OnViewStudent(object sender, EventArgs e)
        {
            string selectedStudentID = listviewStudentInClass.SelectedItems[0].SubItems[1].Text;
            StudentCardView cardView = new StudentCardView(selectedStudentID);
            OverlayForm _ = new OverlayForm(this.Home, cardView);
            cardView.Show();
        }

        private void OnUpdateStudentConduct(object sender, EventArgs e)
        {
            string selectedStudentID = listviewStudentInClass.SelectedItems[0].SubItems[1].Text;
            string studentName = listviewStudentInClass.SelectedItems[0].SubItems[2].Text;
            int grade = int.Parse(mainTeacher.FormClassID.Substring(0, 2));
            UpdateConductView updateConduct = new UpdateConductView(selectedStudentID, grade);
            OverlayForm _ = new OverlayForm(this.Home, updateConduct);
            updateConduct.FormClosed += (s, ev) =>
            {
                if (updateConduct.doneSet)
                {
                    Snackbar.MakeSnackbar(this.Home, string.Format("Đã cập nhật hạnh kiểm thành công cho học sinh {0} ({1})", studentName, selectedStudentID), "OK");
                    Fetch();
                }
            };
            updateConduct.Show();
        }

        private void OnAddFault(object sender, EventArgs e)
        {
            string selectedStudentID = listviewStudentInClass.SelectedItems[0].SubItems[1].Text;
            OnePunishmentView addFault = new OnePunishmentView(selectedStudentID, OnePunishmentView.Mode.Add, OnePunishmentView.OpenMode.FaultOnly);
            OverlayForm _ = new OverlayForm(this.Home, addFault);
            addFault.Show();
        }

        private void OnViewDetailScoreboard(object sender, EventArgs e)
        {
            string selectedStudentID = listviewStudentInClass.SelectedItems[0].SubItems[1].Text;
            string studentName = listviewStudentInClass.SelectedItems[0].SubItems[2].Text;
            int grade = int.Parse(mainTeacher.FormClassID.Substring(0, 2));
            DetailScoreboardView detailScoreboard = new DetailScoreboardView(selectedStudentID, studentName, grade);
            OverlayForm _ = new OverlayForm(this.Home, detailScoreboard);
            detailScoreboard.Show();
        }
    }
}
