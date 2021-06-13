using MaterialSurface;
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
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class OneTeacherAssignmentView : Form
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
        public bool success = false;
        public string classID;
        Teacher runnerTeacher = new Teacher();
        Dictionary<string, Teaching> teachingSem1 = new Dictionary<string, Teaching>();
        Dictionary<string, Teaching> teachingSem2 = new Dictionary<string, Teaching>();
        Class _class = new Class();
        public OneTeacherAssignmentView(string _classID)
        {
            InitializeComponent();
            classID = _classID;
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetLoad(true, "Đang lấy thông tin lớp...");
            await Task.Run(() => _class = ClassDA.Instance.GetClass(classID));
            if (_class.FormalTeacherID != null)
            {
                runnerTeacher = await Task.Run(() => TeacherDA.Instance.GetTeacher(_class.FormalTeacherID));
                txtFormTeacher.Text = runnerTeacher.ID + " | " + runnerTeacher.GetName();
            }
            lbClassID.Text = string.Format("Lớp {0}", _class.ClassID);
            lbClassInfor.Text = string.Format("Phòng học: {0} - Sỉ số: {1}", _class.RoomNumber, _class.StudentNumber);
            SetLoad(true, "Đamg lấy danh sách môn học...");
            List<Subject> subjects = new List<Subject>();
            await Task.Run(() => subjects = SubjectDA.Instance.GetSubjects());
            teachingSem1 = await Task.Run(() => TeachingDA.Instance.GetClassTeachings(classID, 1));
            teachingSem2 = await Task.Run(() => TeachingDA.Instance.GetClassTeachings(classID, 2));
            if (subjects != null)
            {
                for (int index = 0; index < subjects.Count; index++)
                {
                    if (!teachingSem1.ContainsKey(subjects[index].ID))
                    {
                        Teaching teaching = new Teaching()
                        {
                            ClassID = classID,
                            Semester = 1,
                            Subject = subjects[index],
                            TeacherID = null,
                            TeacherName = null,
                            Editable = true,
                            Year = DateTime.Now.Year,
                            ID = "",
                        };
                        teachingSem1.Add(subjects[index].ID, teaching);
                    }
                    if (!teachingSem2.ContainsKey(subjects[index].ID))
                    {
                        Teaching teaching = new Teaching()
                        {
                            ClassID = classID,
                            Semester = 2,
                            Subject = subjects[index],
                            TeacherID = null,
                            TeacherName = null,
                            Editable = true,
                            Year = DateTime.Now.Year,
                            ID = "",
                        };
                        teachingSem2.Add(subjects[index].ID, teaching);
                    }
                    Add(index, subjects[index]);
                }
            }
            SetLoad(false);
        }
        void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
            txtFormTeacher.Enabled = materialTabControl1.Enabled = btnSubmit.Enabled = !isLoading;
        }
        void Add(int index, Subject subject)
        {
            MaterialTextfield textfield1 = new MaterialTextfield()
            {
                ReadOnly = true,
                Location = new Point(5, 20 + 55 * index),
                Width = 380,
                Tag = subject.ID,
                HintText = subject.Name,
                FieldType = BoxType.Outlined,
                ShowCaret = false,
                PrimaryColor = Color.FromArgb(47, 144, 176),
                TabStop = false,
                Style = MaterialTextfield.TextfieldStyle.HintAsFloatingLabel,
                Text = (teachingSem1[subject.ID].TeacherID != null) ? (teachingSem1[subject.ID].TeacherID + " | " + teachingSem1[subject.ID].TeacherName) : "",
            };
            textfield1.Enter += OnChooseTeacher;
            textfield1.TextChanged += OnTeacherSet;
            MaterialCheckbox checkbox1 = new MaterialCheckbox()
            {
                Location = new Point(390, 35 + 55 * index),
                Text = "Khoá bảng điểm",
                Tag = subject.ID,
                PrimaryColor = Color.FromArgb(47, 144, 176),
                Checked = teachingSem1[subject.ID].Editable,
            };
            checkbox1.CheckedChanged += OnChangeEditable;
            tbpgSem1.Controls.Add(textfield1);
            tbpgSem1.Controls.Add(checkbox1);
            MaterialTextfield textfield2 = new MaterialTextfield
            {
                ReadOnly = true,
                Location = new Point(5, 20 + 55 * index),
                Width = 380,
                Tag = subject.ID,
                HintText = subject.Name,
                FieldType = BoxType.Outlined,
                ShowCaret = false,
                PrimaryColor = Color.FromArgb(47, 144, 176),
                TabStop = false,
                Style = MaterialTextfield.TextfieldStyle.HintAsFloatingLabel,
                Text = (teachingSem2[subject.ID].TeacherID != null) ? (teachingSem2[subject.ID].TeacherID + " | " + teachingSem2[subject.ID].TeacherName) : "",
            };
            textfield2.Enter += OnChooseTeacher;
            textfield2.TextChanged += OnTeacherSet;
            MaterialCheckbox checkbox2 = new MaterialCheckbox()
            {
                Location = new Point(390, 35 + 55 * index),
                Text = "Khoá bảng điểm",
                Tag = subject.ID,
                PrimaryColor = Color.FromArgb(47, 144, 176),
                Checked = teachingSem2[subject.ID].Editable,
            };
            checkbox2.CheckedChanged += OnChangeEditable;
            tbpgSem2.Controls.Add(textfield2);
            tbpgSem2.Controls.Add(checkbox2);
        }

        private void OnChangeEditable(object sender, EventArgs e)
        {
            MaterialCheckbox checkbox = (MaterialCheckbox)sender;
            if (materialTabControl1.SelectedTab == tbpgSem1)
            {
                teachingSem1[checkbox.Tag.ToString()].Editable = checkbox.Checked;
            }
            else
            {
                teachingSem2[checkbox.Tag.ToString()].Editable = checkbox.Checked;
            }
        }

        private void OnTeacherSet(object sender, EventArgs e)
        {
            MaterialTextfield textfield = (MaterialTextfield)sender;
            if (materialTabControl1.SelectedTab == tbpgSem1)
            {
                teachingSem1[textfield.Tag.ToString()].TeacherID = (textfield.Text.Length > 0) ?
                    textfield.Text.Split(new string[] { " | " }, StringSplitOptions.None)[0] : null;
            }
            else
            {
                teachingSem2[textfield.Tag.ToString()].TeacherID = (textfield.Text.Length > 0) ?
                    textfield.Text.Split(new string[] { " | " }, StringSplitOptions.None)[0] : null;
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnChooseTeacher(object sender, EventArgs e)
        {
            MaterialTextfield textfield = (MaterialTextfield)sender;
            string currentTeacher = (textfield.Text.Length > 0) ? textfield.Text : null;
            ChooseTeacherView frmChooseTeacher = new ChooseTeacherView(textfield.Tag.ToString(),
                textfield.HintText, currentTeacher);
            OverlayForm overlay = new OverlayForm(this, frmChooseTeacher, setChild: false);
            frmChooseTeacher.FormClosed += (s, ev) =>
            {
                this.Activate();
                btnSubmit.Focus();
                if (!frmChooseTeacher.success)
                    return;
                if (frmChooseTeacher.chosenTeacherID.Length > 0)
                    textfield.Text = frmChooseTeacher.chosenTeacherID;
                else
                    textfield.Text = "";
            };
            frmChooseTeacher.Show();
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            SetLoad(true, "Đang cập nhật GVCN...");
            _class.FormalTeacherID = (txtFormTeacher.Text.Length > 0) ?
                txtFormTeacher.Text.Split(new string[] { " | " }, StringSplitOptions.None)[0] : null;
            Class resultClass = await Task.Run(() => ClassDA.Instance.UpdateClassInfo(_class));
            if (resultClass == null)
            {
                Dialog.Show(this, "Đã có vấn đề xảy ra. Vui lòng hử lại sau ít giây!", "Lỗi");
                return;
            }
            SetLoad(true, "Đang cập nhật thông tin giảng dạy...");
            foreach (KeyValuePair<string, Teaching> teaching in teachingSem1)
            {
                if (teaching.Value.TeacherID == null)
                    continue;
                Teaching resultTeaching = await Task.Run(() => TeachingDA.Instance.UpdateTeaching(teaching.Value));
            }
            foreach (KeyValuePair<string, Teaching> teaching in teachingSem2)
            {
                if (teaching.Value.TeacherID == null)
                    continue;
                Teaching resultTeaching = await Task.Run(() => TeachingDA.Instance.UpdateTeaching(teaching.Value));
            }
            success = true;
            SetLoad(false);
            this.Close();
        }
    }
}
