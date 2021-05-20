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
using TutteeFrame2.Controller;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;
using static System.Windows.Forms.ListView;

namespace TutteeFrame2.View
{
    public partial class SubjectView : UserControl
    {
       
        readonly SubjectController subjectController;
        public  HomeView homeView;
        public SubjectView()
        {
            InitializeComponent();
            subjectController = new SubjectController(this);
            
        }
        /// <summary>
        /// Set HomeView for this View
        /// </summary>
        /// <param name="homeView"> A parrent view of this view</param>
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }
        
        /// <summary>
        /// Load list of subjects in the database to show in this view
        /// </summary>
        public void LoadSubjects()
        {
            subjectController.LoadSubjects();
        }

        public void ShowData()
        {
            this.lvSubjectManage.Items.Clear();
            foreach(Subject item in subjectController.subjects)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.ID,item.Name});
                this.lvSubjectManage.Items.Add(listViewItem);
            }
        }

        private void btnAddNewSubject_Click(object sender, EventArgs e)
        {
            object subject = null;
            DetailSubject detailSubject = new DetailSubject(ref subject);
            OverlayForm overlay = new OverlayForm(homeView, detailSubject);
            var dialogResult = detailSubject.ShowDialog();
            if (subject != null && subject is Subject&& dialogResult == DialogResult.OK)
            {
                subjectController.AddSubject((Subject)subject);
            }

        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            if (lvSubjectManage.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSubjectManage.SelectedItems[0];
                object subject = new Subject(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                DetailSubject detailSubject = new DetailSubject(ref subject);
                OverlayForm overlay = new OverlayForm(homeView, detailSubject);
                var dialogResult =  detailSubject.ShowDialog();
                if (subject != null && subject is Subject && dialogResult == DialogResult.OK)
                {
                   
                    subjectController.UpdateSubject((Subject)subject);
                }
            }

        }

        private void btnDelSubject_Click(object sender, EventArgs e)
        {
            if (lvSubjectManage.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSubjectManage.SelectedItems[0];
                Subject subject = new Subject(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                 var dialogResult = Dialog.Show(homeView, "Bạn có chắc là muốn xóa môn này?", "Cảnh báo", MaterialSurface.Buttons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    subjectController.DeleteSubject(subject);
                }
                
            }
        }
    }
       
}
