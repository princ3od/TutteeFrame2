using MaterialSkin.Controls;
using MaterialSurface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Reports.ReportControll;
using TutteeFrame2.Reports.ReportModel;

namespace TutteeFrame2.View
{
    public partial class frmStudentResultReport : Form
    {
        #region Win32 Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        private HomeView homeView;
        private ReportStudentResultController controller;
        public frmStudentResultReport()
        {

            InitializeComponent();
            controller = new ReportStudentResultController(this, this.cbbFilterByClass,
                this.cbbFilterByGrade, this.cbbSemester, this.listStudentResult, this.cbbType);

        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }

        private void cbbFilterByGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controller != null)
                controller.FilterByGrade();
        }

        private void cbbFilterByClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controller != null)
                controller.FilterByClass();
        }

        private void frmStudentResultReport_Shown(object sender, EventArgs e)
        {
            homeView.Visible = false;
            controller.FetchData();
        }

        public void ShowData()
        {
            List<StudentResult> results = controller.studentResults;
            listStudentResult.Items.Clear();
            foreach (var result in results)
            {
                ListViewItem lvi = new ListViewItem(new string[] {
                    result.studentID,result.surName,result.firstName,result.classID,result.averagePoint.ToString(),result.semester.ToString()
                });
                lvi.Tag = result;
                listStudentResult.Items.Add(lvi);
            }
        }

        private void cbbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controller != null) controller.FilterBySemester();
        }



        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintStudents_Click(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 1)
            {
                if (listStudentResult.SelectedItems.Count == 0)
                {
                    Dialog.Show(this, "Hãy chọn học sinh bạn muốn in kết quả", "Thông báo", Buttons.Ok);
                    return;
                }
                controller.ProgressPrintIndividualStudentResult();
            }
            else if (cbbType.SelectedIndex == 0)
            {
                if(cbbFilterByClass.SelectedIndex == 0)
                {
                    Dialog.Show(this, "Hãy chọn lớp bạn muốn in kết quả", "Thông báo", Buttons.Ok);
                    return;
                }
                controller.ProgressPrintListResultOfClass();
            }
            else
            {
                Dialog.Show(this, "Bạn cần chọn loại bảng điểm", "Thông báo", Buttons.Ok);
            }
        }

        private void frmStudentResultReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            homeView.Visible = true;
            this.homeView.Select();
   
        }
        private void frmStudentResultReport_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
