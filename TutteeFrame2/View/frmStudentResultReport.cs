using MaterialSkin.Controls;
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
using TutteeFrame2.Reports.ReportControll;
using TutteeFrame2.Reports.ReportModel;

namespace TutteeFrame2.View
{
    public partial class frmStudentResultReport : Form
    {
        private HomeView homeView;
        private ReportStudentResultController controller;
        public frmStudentResultReport()
        {

            InitializeComponent();
            controller = new ReportStudentResultController(this, this.cbbFilterByClass,
                this.cbbFilterByGrade,this.cbbSemester,this.listStudentResult,this.cbbType);

        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }

        private void cbbFilterByGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(controller!=null)
            controller.FilterByGrade();
        }

        private void cbbFilterByClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (controller != null)
                controller.FilterByClass();
        }

        private void frmStudentResultReport_Shown(object sender, EventArgs e)
        {
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
            if(controller!=null) controller.FilterBySemester();
        }



        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrintStudents_Click(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 1)
            {
                if (listStudentResult.SelectedItems.Count ==0)
                {
                    Dialog.Show(this, "Hãy chọn học sinh bạn muốn in kết quả", "Thông báo", Buttons.Ok);
                    return;
                }
                controller.ProgressPrintIndividualStudentResult();
            }
            else if(cbbType.SelectedIndex == 0)
            {
                controller.ProgressPrintListResultOfClass();
            }
            else
            {
                Dialog.Show(this, "Bạn cần chọn loại bảng điểm", "Thông báo", Buttons.Ok);
            }
        }

        private void frmStudentResultReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.homeView.Select();
        }
    }
}
