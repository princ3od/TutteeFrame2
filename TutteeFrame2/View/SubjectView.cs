﻿using MaterialSurface;
using System;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class SubjectView : UserControl
    {
        readonly SubjectController subjectController;
        public HomeView homeView;

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
            foreach (Subject item in subjectController.subjects)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.ID, item.Name });
                this.lvSubjectManage.Items.Add(listViewItem);
            }
        }

        private void btnAddNewSubject_Click(object sender, EventArgs e)
        {
            string subjectID;
            do
            {
                subjectID = "SJ" + IdentifierFactory.GenerateNumberID(length: 4);
            }
            while (subjectController.subjects.FindIndex(x => x.ID == subjectID) != -1);
            object subject = subjectID;
            DetailSubject detailSubject = new DetailSubject(ref subject);
            OverlayForm overlay = new OverlayForm(homeView, detailSubject);
            var dialogResult = detailSubject.ShowDialog();
            if (subject != null && subject is Subject && dialogResult == DialogResult.OK)
            {
                subjectController.AddSubject((Subject)subject);
            }
            homeView.Activate();
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            if (lvSubjectManage.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSubjectManage.SelectedItems[0];
                object subject = new Subject(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                DetailSubject detailSubject = new DetailSubject(ref subject);
                OverlayForm overlay = new OverlayForm(homeView, detailSubject);
                var dialogResult = detailSubject.ShowDialog();
                if (subject != null && subject is Subject && dialogResult == DialogResult.OK)
                {

                    subjectController.UpdateSubject((Subject)subject);
                }
                homeView.Activate();
            }

        }

        private void btnDelSubject_Click(object sender, EventArgs e)
        {
            if (lvSubjectManage.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSubjectManage.SelectedItems[0];
                Subject subject = new Subject(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
                var dialogResult = Dialog.Show(homeView, "Bạn có chắc là muốn xóa môn này?", "Cảnh báo", MaterialSurface.Buttons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    subjectController.DeleteSubject(subject);
                }
            }
        }
    }
}
