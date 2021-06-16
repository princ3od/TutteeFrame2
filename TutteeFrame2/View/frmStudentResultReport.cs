using MaterialSkin.Controls;
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

        private ReportStudentResultControll controller;
        public frmStudentResultReport()
        {

            InitializeComponent();
            controller = new ReportStudentResultControll(this, this.cbbFilterByClass, this.cbbFilterByGrade,this.cbbSemester,this.listStudentResult);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            controller.ChangeTypeOfResult();
        }
    }
}
