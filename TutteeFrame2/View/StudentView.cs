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
using MaterialSurface;

namespace TutteeFrame2.View
{
    public partial class StudentView : UserControl
    {
        public HomeView homeView;
        readonly StudentController studentController;
        public bool firstLoad = true;
        public enum SortType
        {
            ByID = 0,
            ByBirthday = 1,
            ByName = 2,
            BySex = 3,
            ByClassID = 4,
            ByStatus = 5,
        }
        public enum GradeFilter
        {
            All = 0,
            Grade10 = 1,
            Grade11 = 2,
            Grade12 = 3,
        }
        public SortType sortType = SortType.ByClassID;
        public GradeFilter gradeFilter = GradeFilter.All;
        public string classFilter = "Tất cả";


        public StudentView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            studentController = new StudentController(this);
        }
        public void SetIndexOfCbbClassItemSelected(int index)
        {
            cbbFilterByClass.SelectedIndex = index;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbbFilterByGrade.SelectedIndex = 0;
            cbbSortBy.SelectedIndex = 4;
        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }
        public void FetchData()
        {
            studentController.FetchData();
        }
        public void ShowStudentsOnListView()
        {

            listViewStudents.Items.Clear();
            foreach (Student student in studentController.students)
            {
                ListViewItem lvi = new ListViewItem(new string[] {student.ID,student.SurName,student.FirstName,
                    student.DateBorn.ToString("dd/MM/yyyy"),student.GetSex,student.Address,
                    student.Phone,student.ClassID,student.Status?"Đang học":"Đã nghĩ học" });
                lvi.Tag = student;
                listViewStudents.Items.Add(lvi);
            }

            lbSumStudent.Text = studentController.students.Count.ToString();

            if (firstLoad == true)
            {
                firstLoad = false;
            };
        }
        public void FetchCbbClassItems()
        {
            cbbFilterByClass.Items.Clear();
            cbbFilterByClass.Items.Add("Tất cả");
            foreach (var item in studentController.cbbClassItems)
            {
                cbbFilterByClass.Items.Add(item);
            }
        }
        private void OnSortTypeChaned(object sender, EventArgs e)
        {
            if (cbbSortBy.SelectedIndex < 0 || firstLoad)
                return;
            sortType = (SortType)cbbSortBy.SelectedIndex;
            studentController.ChangeSortType();

        }

        private void OnFilterGradeTypeChanged(object sender, EventArgs e)
        {
            if (cbbFilterByGrade.SelectedIndex < 0 || firstLoad)
                return;
            gradeFilter = (GradeFilter)cbbFilterByGrade.SelectedIndex;
            studentController.FilterStudentByGrade();
            studentController.FetchCbbClassItems();
        }

        private void OnFilterClassChanged(object sender, EventArgs e)
        {
            if (cbbFilterByClass.SelectedIndex < 0 || firstLoad) return;
            classFilter = (String)cbbFilterByClass.SelectedItem;
            studentController.FilterStudentByClass();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listViewStudents.SelectedItems[0];
                OneStudentView oneStudentView = new OneStudentView(lvi.Tag, this);
                OverlayForm overlayForm = new OverlayForm(homeView, oneStudentView);
                var dialogResult = oneStudentView.ShowDialog();
            }

        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentID;

            do
            {
                studentID = DateTime.Now.ToString("yyyy") + IdentifierFactory.GenerateNumberID(length: 4);
            }
            while (studentController.originalStudents.FindIndex(x => x.ID == studentID) != -1);
            OneStudentView oneStudentView = new OneStudentView(studentID, this);
            OverlayForm overlayForm = new OverlayForm(homeView, oneStudentView);
            var dialogResult = oneStudentView.ShowDialog();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count > 0)
            {
                var dialogResult = Dialog.Show(homeView, "Bạn có chắc muốn xóa học sinh này?", tittle: "Cảnh báo", Buttons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ListViewItem lvi = listViewStudents.SelectedItems[0];
                    Student student = (lvi.Tag is Student) ? (Student)lvi.Tag : null;
                    if (student != null)
                    {
                        studentController.DeleteStudent(student.ID);
                    };
                }
            }
        }



        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentController.FindStudent(txtSearch.Text);
            }
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            txtSearch.HelperText = "Nhập tên hoặc mã số học sinh";
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            txtSearch.HelperText = "";
        }

        private void OnAddFault(object sender, EventArgs e)
        {
            OnePunishmentView onePunishmentView = new OnePunishmentView(listViewStudents.SelectedItems[0].SubItems[0].Text,
               OnePunishmentView.Mode.Add, OnePunishmentView.OpenMode.FaultOnly);
            OverlayForm _ = new OverlayForm(homeView, onePunishmentView);
            onePunishmentView.FormClosing += (s, ev) =>
            {
                if (onePunishmentView.success)
                {
                    ListViewItem lvi = listViewStudents.SelectedItems[0];
                    Student student = (lvi.Tag is Student) ? (Student)lvi.Tag : new Student();
                    Snackbar.MakeSnackbar(homeView, string.Format("Thêm vi phạm (ID: {0}) cho học sinh {1} thành công.",
                        onePunishmentView.punishmentID, student.GetName()), "OK");
                }
            };
            onePunishmentView.Show();
        }
    }
}
