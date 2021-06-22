using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame.Reports.ReportModel;
using TutteeFrame2.Controller;
using TutteeFrame2.Reports.ReportControll;
using TutteeFrame2.Reports.ReportModel;

namespace TutteeFrame2.Reports
{
    public enum TypePrint
    {
        Individual,
        List,
        ClassResult
    }
    public partial class StudentInfoReporter : Form
    {

        ReportStudentController reportStudentController;
        ReportStudentResultController reportStudentResultController;
        private TypePrint typePrint;
        private TutteeFrame.Reports.ReportModel.InformationOfStudentResultPrepareForPrint informationOfStudent = new InformationOfStudentResultPrepareForPrint();
        public StudentInfoReporter(TypePrint typePrint, ReportStudentController reportStudentController,
            ReportStudentResultController reportStudentResultController)
        {
            this.reportStudentController = reportStudentController;
            this.reportStudentResultController = reportStudentResultController;
            this.typePrint = typePrint;
            InitializeComponent();
        }

        private void StudentInfoReporter_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            switch (typePrint)
            {
                case TypePrint.List:

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "TutteeFrame2.Reports.PagePrint.ReportStudentInfo.rdlc";
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet2";
                    rds.Value = reportStudentController.LoadDataToStudentInfoReporter();
                    ReportParameter[] pars = new ReportParameter[]
                    {
                    new ReportParameter("namePage", $"{reportStudentController.cbbSlectedItem}"),
                    new ReportParameter("formalTeacher", $"{reportStudentController.GetTeachername(reportStudentController.cbbSlectedItem)}")
                    };

                    ReportDataSource rds1 = new ReportDataSource();
                    rds1.Name = "DataSet1";
                    rds1.Value = reportStudentController.LoadDataInfoShool();
                    this.reportViewer1.LocalReport.SetParameters(pars);
                    this.reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.LocalReport.DataSources.Add(rds1);

                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.ShowExportButton = false;
                    break;
                case TypePrint.Individual:

                    if (!reportStudentResultController.GetAllInfoAndResultOfStudentPrepareToPrint(informationOfStudent, reportStudentResultController.GetIDOfSelectedStudent())) return;

                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "TutteeFrame2.Reports.PagePrint.ReportStudentResult.rdlc";
                    ReportDataSource rds4 = new ReportDataSource("DataSet1", informationOfStudent.scoreBoards.Tables[0]);
                    ReportDataSource rds5 = new ReportDataSource("DataSet2", informationOfStudent.scoreBoards.Tables[1]);
                    ReportDataSource rds6 = new ReportDataSource("DataSet3", informationOfStudent.BaseInforSchool.Tables[0]);

                    ReportParameter[] pars2 = new ReportParameter[]
                    {
                        new ReportParameter("studentName",$"{this.informationOfStudent.nameOfStudent}"),
                        new ReportParameter("studentClass",$"{ this.informationOfStudent.classOfStudent}"),
                        new ReportParameter("averageYearPoint",$"{ this.informationOfStudent.averageResult}"),
                        new ReportParameter("emulationTitle",$"{ this.informationOfStudent.emulationTitle}"),
                        new ReportParameter("conductS1",$"{ this.informationOfStudent.conductS1}"),
                        new ReportParameter("conductS2",$"{ this.informationOfStudent.conductS2}"),
                        new ReportParameter("conductYear",$"{ this.informationOfStudent.conductS3}")
                    };

                    this.reportViewer1.LocalReport.SetParameters(pars2);
                    this.reportViewer1.LocalReport.DataSources.Add(rds4);
                    this.reportViewer1.LocalReport.DataSources.Add(rds5);
                    this.reportViewer1.LocalReport.DataSources.Add(rds6);

                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.ShowExportButton = true;
                    break;
                case TypePrint.ClassResult:


                    InfomationOfStudensResultOfClassPrepareToPrint containerInfo
                        = new InfomationOfStudensResultOfClassPrepareToPrint();
                    if (!reportStudentResultController.GetDataOfAllStudentsInClassPrepareToPrint(containerInfo)) return;
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "TutteeFrame2.Reports.PagePrint.ReportClassResult.rdlc";

                    ReportDataSource rds3 = new ReportDataSource();
                    rds3.Name = "DataSet1";
                    rds3.Value = containerInfo.ds.Tables[0];
                    ReportDataSource rds2 = new ReportDataSource();
                    rds2.Name = "DataSet2";
                    rds2.Value = containerInfo.BaseInforSchool.Tables[0];

                    ReportParameter[] pars3 = new ReportParameter[]
                    {
                            new ReportParameter("fomalTeacher",$"{containerInfo.formalTeacher}"),
                            new ReportParameter("className",$"{containerInfo.classID}")
                    };
                    this.reportViewer1.LocalReport.SetParameters(pars3);
                    this.reportViewer1.LocalReport.DataSources.Add(rds2);
                    this.reportViewer1.LocalReport.DataSources.Add(rds3);
                    this.reportViewer1.RefreshReport();
                    this.reportViewer1.ShowExportButton = true;
                    break;
                default:
                    break;

            }
        }

    }
}
