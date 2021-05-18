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
    public partial class TeacherView : UserControl
    {
        public enum SortType
        {
            ByID = 0,
            ByName = 1,
            ByBirthday = 2,
        };
        public enum RoleFilter
        {
            All = 0,
            Teacher = 1,
            GVCN = 2,
            Ministry = 3,
            Adminstrator = 4,
        }
        public bool firstLoad = true;
        public HomeView Home;
        public SortType sortType = SortType.ByID;
        public RoleFilter roleFilter = RoleFilter.All;
        public string subjectFilter = "";
        TeacherController controller;
        public TeacherView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            controller = new TeacherController(this);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            cbbRole.SelectedIndex = 0;
            cbbSortBy.SelectedIndex = 0;
        }
        public void SetHome(HomeView _homeView)
        {
            Home = _homeView;
        }
        public void Fetch()
        {
            controller.FetchData();

        }
        public void ShowSubjects(List<Subject> subjects)
        {
            cbbSubject.Items.Clear();
            cbbSubject.Items.Add("Tất cả");
            foreach (Subject subject in subjects)
            {
                cbbSubject.Items.Add(subject.Name);
            }
            cbbSubject.SelectedIndex = 0;
        }
        public void ShowData()
        {
            listviewTeacher.Items.Clear();
            int index = 1;
            foreach (Teacher teacher in controller.teachers)
            {
                listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateBorn.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                }));
                index++;
            }
        }

        private void OnSortTypeChanged(object sender, EventArgs e)
        {
            if (cbbSortBy.SelectedIndex < 0 || firstLoad)
                return;
            sortType = (SortType)cbbSortBy.SelectedIndex;
            controller.ChangeSortType();
        }

        private void OnRoleFilterChanged(object sender, EventArgs e)
        {
            if (cbbRole.SelectedIndex < 0 || firstLoad)
                return;
            roleFilter = (RoleFilter)cbbRole.SelectedIndex;
            controller.CreateFilter(txtSearch.Text);
        }

        private void OnSubjectFilterChanged(object sender, EventArgs e)
        {
            if (cbbSubject.SelectedIndex < 0 || firstLoad)
                return;
            if (cbbSubject.SelectedIndex == 0)
                subjectFilter = "";
            else
                subjectFilter = cbbSubject.Text;
            controller.CreateFilter(txtSearch.Text);
        }

        private void OnChooseTeacher(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = !(listviewTeacher.SelectedItems.Count <= 0);
        }
        private void OnAddTeacher(object sender, EventArgs e)
        {
            OneTeacherView frmTeacher = new OneTeacherView(Mode.Add);
            OverlayForm _ = new OverlayForm(Home, frmTeacher);
            frmTeacher.Show();
            frmTeacher.FormClosed += (s, ev) =>
            {
                if (frmTeacher.doneSuccess)
                {
                    Snackbar.MakeSnackbar(Home,
                        string.Format("Thêm mới giáo viên (ID: {0}) thành công!", frmTeacher.teacherID), "OK");
                }
            };
        }

        private void OnUpdateTeacher(object sender, EventArgs e)
        {
            OneTeacherView oneTeacherView = new OneTeacherView(Mode.Edit, listviewTeacher.SelectedItems[0].SubItems[1].Text);
            OverlayForm _ = new OverlayForm(Home, oneTeacherView);
            oneTeacherView.Show();
            oneTeacherView.FormClosed += (s, ev) =>
            {
                if (oneTeacherView.doneSuccess)
                {
                    Snackbar.MakeSnackbar(Home,
                        string.Format("Cập nhật giáo viên (ID: {0}) thành công!", oneTeacherView.teacherID), "OK");
                }
            };
        }

        private void OnDeleteTeacher(object sender, EventArgs e)
        {

        }

        private void OnSearching(object sender, EventArgs e)
        {
            controller.CreateFilter(txtSearch.Text);
        }
    }
}
