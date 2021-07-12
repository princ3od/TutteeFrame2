using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class ReportView : UserControl
    {
        HomeView homeView;
        public ReportView()
        {
            InitializeComponent();
            
        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StudentInfoReport frmStudentReport = new StudentInfoReport();
            frmStudentReport.SetHome(this.homeView);
            frmStudentReport.Show();
        }

        private void btnPrintResluts_Click(object sender, EventArgs e)
        {
            StudentResultReport frmStudentResultReport = new StudentResultReport();
            frmStudentResultReport.SetHome(this.homeView);
            //OverlayForm overlayForm = new OverlayForm(homeView, frmStudentResultReport);
            frmStudentResultReport.ShowDialog();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            ChartView chart = new ChartView();
            //OverlayForm overlayForm = new OverlayForm(homeView, chart);
            chart.ShowDialog();
        }
    }
}
