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

namespace TutteeFrame2.View
{
    public partial class PunishmentView : UserControl
    {
        PunishmentController controller;
        public HomeView Home;
        public string classIDFilter = "";
        public string gradeFilter = "";
        public bool firstLoad;
        public PunishmentView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            controller = new PunishmentController(this);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            cbbFilterByGrade.SelectedIndex = 0;
        }
        public void SetHome(HomeView home)
        {
            Home = home;
        }
        public void Fetch()
        {
            controller.FetchData();
        }
        public void ShowClasses(List<Class> classes)
        {
            cbbFilterByClass.Items.Clear();
            cbbFilterByClass.Items.Add("Tất cả");
            foreach (Class _class in classes)
            {
                cbbFilterByClass.Items.Add(_class.ClassID);
            }
            classIDFilter = "";
            cbbFilterByClass.SelectedIndex = 0;
        }
        public void ShowData()
        {
            listViewPunishment.Items.Clear();
            for (int i = 0; i < controller.punishments.Count; i++)
            {
                Punishment punishment = controller.punishments[i];
                listViewPunishment.Items.Add(new ListViewItem(new string[]
                    {
                        (i + 1).ToString(), punishment.ID, punishment.StudentID,
                        controller.studentName[punishment.ID],
                        string.Format("Học kì {0} ({1}", punishment.Semester, punishment.Year),
                        controller.studentClass[punishment.ID],
                        punishment.Fault,
                        punishment.Content
                    }));
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
            txtSearch.Clear();
            _ = controller.FetchClasses();
        }

        private void OnChangeClass(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            if (cbbFilterByClass.SelectedIndex == 0)
                classIDFilter = "";
            else
                classIDFilter = cbbFilterByClass.Text;
            txtSearch.Clear();
            cbbFilterByGrade.Enabled = false;
            _ = controller.FetchPunishments();
            cbbFilterByGrade.Enabled = true;
        }

        private void OnSearch(object sender, EventArgs e)
        {
            controller.FilterSearch(txtSearch.Text);
        }
    }
}
