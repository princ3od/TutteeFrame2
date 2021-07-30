using System;
using System.Windows.Forms;

namespace TutteeFrame2.View
{
    public partial class ReportViewTab : UserControl
    {
        HomeView homeView;

        public ReportViewTab()
        {
            InitializeComponent();
        }

        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmStudentInfoReport frmStudentReport = new frmStudentInfoReport();
            frmStudentReport.SetHome(this.homeView);
            frmStudentReport.Show();
        }

        private void btnPrintResluts_Click(object sender, EventArgs e)
        {
            frmStudentResultReport frmStudentResultReport = new frmStudentResultReport();
            frmStudentResultReport.ShowDialog();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            frmChart chart = new frmChart();
            chart.ShowDialog();
        }
    }
}
