using MaterialSurface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class TeacherAssignmentView : UserControl
    {
        List<Class> classes = new List<Class>();
        bool firstLoad = true;
        HomeView Home;

        public TeacherAssignmentView()
        {
            InitializeComponent();
            cbbFilterByGrade.SelectedIndex = 0;
        }

        public void SetHome(HomeView homeView)
        {
            Home = homeView;
        }

        public async void Fetch()
        {
            listViewTeachingClass.Items.Clear();
            Home.SetLoad(true, "Đang lấy danh sách lớp...");
            await Task.Run(() => classes = ClassDA.Instance.GetClasses());
            if (classes != null)
            {
                foreach (Class _class in classes)
                {
                    listViewTeachingClass.Items.Add(_class.ClassID, 0);
                }
            }
            Home.SetLoad(false);
            if (firstLoad)
                firstLoad = false;
        }

        private async void OnChangeGrade(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            string gradeFilter = (cbbFilterByGrade.SelectedIndex == 0) ? "" : cbbFilterByGrade.Text;
            listViewTeachingClass.Items.Clear();
            Home.SetLoad(true, "Đang lấy danh sách lớp...");
            await Task.Run(() => classes = ClassDA.Instance.GetClasses(gradeFilter));
            List<string> doneClasses = await Task.Run(() => TeachingDA.Instance.GetAssignedDoneClass());
            if (doneClasses == null)
            {
                ckbHideDoneClass.Checked = false;
            }
            if (classes != null)
            {
                foreach (Class _class in classes)
                {
                    if (ckbHideDoneClass.Checked && doneClasses.Contains(_class.ClassID) && !string.IsNullOrEmpty(_class.FormalTeacherID))
                        continue;
                    listViewTeachingClass.Items.Add(_class.ClassID, 0);
                }
            }
            else
            {
                Dialog.Show(Home, "Đã có lỗi xảy ra. Vui lòng tải lại sau ít phút!", "Lỗi");
                return;
            }
            Home.SetLoad(false);
        }

        private void OnHideDoneClass(object sender, EventArgs e)
        {
            OnChangeGrade(cbbFilterByGrade, EventArgs.Empty);
        }

        private void OnAssignClass(object sender, EventArgs e)
        {
            if (listViewTeachingClass.SelectedItems.Count <= 0)
                return;
            OneTeacherAssignmentView assignmentView = new OneTeacherAssignmentView(listViewTeachingClass.SelectedItems[0].Text);
            OverlayForm _ = new OverlayForm(this.Home, assignmentView);
            assignmentView.FormClosed += (s, ev) =>
            {
                if (assignmentView.success)
                {
                    Snackbar.MakeSnackbar(Home, string.Format("Phân công giáo viên cho lớp {0} thành công!", assignmentView.classID), "OK", timeShow: 3f);
                }
            };
            assignmentView.Show();
        }
    }
}
