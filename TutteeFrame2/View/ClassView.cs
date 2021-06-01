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
    public partial class ClassView : UserControl
    {
        public HomeView Home;
        public string gradeFilter = "";
        public bool firstLoad = true;
        ClassController controller;
        public ClassView()
        {
            InitializeComponent();
            controller = new ClassController(this);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            cbbFilterByGrade.SelectedIndex = 0;
        }
        public void Fetch()
        {
            controller.FetchData();
        }
        public void SetHome(HomeView homeView)
        {
            Home = homeView;
        }
        public void ShowData()
        {
            int index = 0;
            listViewClass.Items.Clear();
            foreach (Class _class in controller.classes)
            {
                index++;
                ListViewItem lvi = new ListViewItem(index.ToString());
                lvi.SubItems.Add(_class.ClassID);
                lvi.SubItems.Add(_class.RoomNumber);
                lvi.SubItems.Add(_class.StudentNumber.ToString());
                lvi.SubItems.Add(_class.FormalTeacherID);
                listViewClass.Items.Add(lvi);
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
            controller.FetchData();
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
        private void OnDeleteClass(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count > 0)
            {
                if (Dialog.Show(Home, "Bạn chắc chắn muốn xoá lớp học này?", "Xác nhận", Buttons.YesNo) == DialogResult.Yes)
                    controller.DeleteClass(listViewClass.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void OnChooseClass(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = (listViewClass.SelectedItems.Count > 0);
        }

        private void OnAddClass(object sender, EventArgs e)
        {
            OneClassView oneClassView = new OneClassView(OneClassView.Mode.Add);
            OverlayForm _ = new OverlayForm(Home, oneClassView);
            oneClassView.FormClosing += (s, ev) =>
            {
                Home.Activate();
                if (oneClassView.success)
                {
                    Snackbar.MakeSnackbar(Home, string.Format("Thêm lớp mới thành công (ClassID: {0})", oneClassView.classID), "OK");
                    Fetch();
                }
            };
            oneClassView.Show();
        }

        private void OnUpdateClass(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count <= 0)
                return;
            OneClassView oneClassView = new OneClassView(OneClassView.Mode.Edit, listViewClass.SelectedItems[0].SubItems[1].Text);
            OverlayForm _ = new OverlayForm(Home, oneClassView);
            oneClassView.FormClosing += (s, ev) =>
            {
                Home.Activate();
                if (oneClassView.success)
                {
                    Snackbar.MakeSnackbar(Home, string.Format("Cập nhật lớp thành công (ClassID: {0})", oneClassView.classID), "OK");
                    Fetch();
                }
            };
            oneClassView.Show();
        }
    }
}
