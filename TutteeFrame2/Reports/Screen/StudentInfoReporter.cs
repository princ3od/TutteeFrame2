using Microsoft.Reporting.WinForms;
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

namespace TutteeFrame2.Reports
{
    public partial class StudentInfoReporter : Form
    {
        ReportStudentController controller;
        public StudentInfoReporter(ReportStudentController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void StudentInfoReporter_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TutteeFrame2.Reports.PagePrint.ReportStudentInfo.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet2";
            rds.Value = controller.LoadDataToStudentInfoReporter();
            ReportParameter[] pars = new ReportParameter[]
            {
                    new ReportParameter("namePage", $"{"Pamramester Class"}"),
                    new ReportParameter("formalTeacher", $"{"Teacher fomal"}")
            };

            ReportDataSource rds1 = new ReportDataSource();
            rds1.Name = "DataSet1";
            rds1.Value = controller.LoadDataInfoShool();
            this.reportViewer1.LocalReport.SetParameters(pars);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.DataSources.Add(rds1);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.ShowExportButton = false;
        }
    }
}
