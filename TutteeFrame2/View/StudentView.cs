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
using System.Collections.Generic;
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
        }
        public enum GradeFilter
        {
            All = 0,
            Grade10 = 1,
            Grade11 = 2,
            Grade12 = 3,
        }
        public SortType sortType = SortType.ByID;
        public GradeFilter gradeFilter = GradeFilter.All;
        public string  classFilter = "Tất cả";


        public StudentView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            studentController = new  StudentController(this);
        }
        public void SetIndexOfCbbClassItemSelected(int index)
        {
            cbbFilterByClass.SelectedIndex = index;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbbFilterByGrade.SelectedIndex = 0;
            cbbSortBy.SelectedIndex = 0;
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
            if(listViewStudents.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listViewStudents.SelectedItems[0];
                OneStudentView oneStudentView = new OneStudentView(lvi.Tag,this.homeView);
                OverlayForm overlayForm = new OverlayForm(homeView, oneStudentView);
                var dialogResult = oneStudentView.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    this.FetchData();
                    Snackbar.MakeSnackbar(homeView, "Đã thêm cập nhật thông tin 1 học sinh thành công");
                }

            }

        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentID;

            do
            {
                studentID = DateTime.Now.ToString("yyyy")+IdentifierFactoryV2.GenerateNumberID(length: 4);
            }
            while (studentController.originalStudents.FindIndex(x=>x.ID==studentID)!=-1);

            OneStudentView oneStudentView = new OneStudentView(studentID, this.homeView);
            OverlayForm overlayForm = new OverlayForm(homeView, oneStudentView);
            oneStudentView.ShowDialog();
            var dialogResult = oneStudentView.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.FetchData();
                Snackbar.MakeSnackbar(homeView, "Đã thêm mới 1 học sinh thành công");
            }

        }
    }
}
