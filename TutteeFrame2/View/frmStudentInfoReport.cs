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
using TutteeFrame2.Reports;

namespace TutteeFrame2.View
{
    public partial class frmStudentInfoReport : Form

    {
        HomeView homeView;
        public enum GradeFilter
        {
            All = 0,
            Grade10 = 1,
            Grade11 = 2,
            Grade12 = 3,
        }
        public GradeFilter gradeFilter = GradeFilter.All;
        public string classFilter = "Tất cả";
        public ReportStudentController controller;
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }
        public frmStudentInfoReport()
        {

            controller = new ReportStudentController(this);
            controller.FetchData();
            InitializeComponent();
            cbbFilterByGrade.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbFilterByGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilterByGrade.SelectedIndex < 0)
                return;
            gradeFilter = (GradeFilter)cbbFilterByGrade.SelectedIndex;
            controller.FilterStudentByGrade();
            controller.FetchCbbClassItems();
        }
        public void ShowStudentsOnListView()
        {

            listViewStudents.Items.Clear();
            foreach (Student student in controller.students)
            {
                ListViewItem lvi = new ListViewItem(new string[] {student.ID,student.SurName,student.FirstName,
                    student.DateBorn.ToString("dd/MM/yyyy"),student.GetSex,student.Address,
                    student.Phone,student.ClassID,student.Status?"Đang học":"Đã nghĩ học" });
                lvi.Tag = student;
                listViewStudents.Items.Add(lvi);
            }

        }
        public void FetchCbbClassItems()
        {
            cbbFilterByClass.Items.Clear();
            cbbFilterByClass.Items.Add("Tất cả");
            foreach (var item in controller.cbbClassItems)
            {
                cbbFilterByClass.Items.Add(item);
            }
            cbbFilterByClass.SelectedIndex = 0;
        }

        private void cbbFilterByClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilterByClass.SelectedIndex < 0) return;
            classFilter = (String)cbbFilterByClass.SelectedItem;
            controller.cbbSlectedItem = (String)cbbFilterByClass.SelectedItem;
            controller.FilterStudentByClass();
        }

        private void btnPrintStudents_Click(object sender, EventArgs e)
        {
            StudentInfoReporter studentInfoReporter = new StudentInfoReporter(TypePrint.List,controller,null);
            studentInfoReporter.ShowDialog();

            DataTable table = controller.convertListStudentToDataTable(controller.students);
            Console.WriteLine(table);
        }

        private void frmStudentReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.homeView.Select();
        }
    }
}
