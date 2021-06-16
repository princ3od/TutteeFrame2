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
    public partial class ReportViewTag : UserControl
    {
        HomeView homeView;
        public ReportViewTag()
        {
            InitializeComponent();
            
        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmStudentReport frmStudentReport = new frmStudentReport();
            frmStudentReport.SetHome(this.homeView);
            OverlayForm overlayForm = new OverlayForm(homeView, frmStudentReport);
            frmStudentReport.ShowDialog();
        }
    }
}
