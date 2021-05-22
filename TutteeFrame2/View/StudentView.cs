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
        bool isClassFiltterChanged = false;
        public StudentView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            studentController = new  StudentController(this);
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
                listViewStudents.Items.Add(lvi);
            }
            
            lbSumStudent.Text = studentController.students.Count.ToString();
            if(!isClassFiltterChanged)FetchCbbClassItems();
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
            isClassFiltterChanged = false;
            studentController.FilterStudentByGrade();
        }

        private void OnFilterClassChanged(object sender, EventArgs e)
        {
            if (cbbFilterByClass.SelectedIndex < 0 || firstLoad) return;
            classFilter = (String)cbbFilterByClass.SelectedItem;
            isClassFiltterChanged = true;
            studentController.FilterStudentByClass();
        }

    }
}
