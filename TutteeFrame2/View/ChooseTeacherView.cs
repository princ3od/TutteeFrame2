using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;

namespace TutteeFrame2.View
{
    public partial class ChooseTeacherView : Form
    {
        #region Win32 Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion
        string loadType;
        public bool success = false;
        public string chosenTeacherID = "";
        public ChooseTeacherView(string _subjectLoad, string _subjectName, string _currentTeacher = null)
        {
            InitializeComponent();
            loadType = _subjectLoad;
            string title = (_subjectLoad == "GVCN") ? "chủ nhiệm" : "môn " + _subjectName;
            lbTittle.Text = string.Format("Chọn giáo viên {0}", title);
            if (_currentTeacher != null)
            {
                txtCurrentTeacher.Text = _currentTeacher;
                txtCurrentTeacher.Tag = _currentTeacher.Split(new string[] { " | " }, StringSplitOptions.None)[0];
                if (_subjectLoad != "GVCN")
                    return;
                listviewTeacher.Items.Add(new ListViewItem(new string[] { "0", _currentTeacher.Split('|')[0].Trim(), _currentTeacher.Split('|')[1].Trim() }));
                listviewTeacher.Items[0].Selected = true;
                listviewTeacher.Select();
            }
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<Teacher> teachers = new List<Teacher>();
            teachers = await GetTeachers();
            txtTeacherSearch.Enabled = listviewTeacher.Enabled = true;
            txtTeacherSearch.Focus();
            int index = 1;
            foreach (Teacher teacher in teachers)
            {
                if (txtCurrentTeacher.Tag != null && teacher.ID == txtCurrentTeacher.Tag.ToString())
                    continue;
                if (loadType == "GVCN")
                {
                    if (teacher.Type == TeacherType.Teacher)
                    {
                        listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(), teacher.ID, teacher.GetName() }));
                        index++;
                    }
                }
                else
                {
                    if (teacher.Subject.ID == loadType && teacher.Type != TeacherType.Adminstrator && teacher.Type != TeacherType.Ministry)
                    {
                        listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(), teacher.ID, teacher.GetName() }));
                        index++;
                    }
                }
            }
        }
        async Task<List<Teacher>> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            await Task.Run(() => teachers = TeacherDA.Instance.GetTeachers());
            foreach (Teacher teacher in teachers)
            {
                string classID = null;
                await Task.Run(() => classID = TeacherDA.Instance.GetInchargeClass(teacher.ID));
                if (classID != null)
                {
                    teacher.Type = TeacherType.FormerTeacher;
                }
            }
            return teachers;

        }
        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            if (txtCurrentTeacher.Text.Length > 0)
                chosenTeacherID = txtCurrentTeacher.Text;
            success = true;
            this.Close();
        }

        private void OnSelected(object sender, EventArgs e)
        {
            if (listviewTeacher.SelectedItems.Count > 0)
                txtCurrentTeacher.Text = listviewTeacher.SelectedItems[0].SubItems[1].Text + " | " + listviewTeacher.SelectedItems[0].SubItems[2].Text;
        }

        private void OnDeleteTeacher(object sender, EventArgs e)
        {
            chosenTeacherID = "";
            txtCurrentTeacher.Text = "";
        }
    }
}
