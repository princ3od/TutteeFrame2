using MaterialSurface;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;

namespace TutteeFrame2.View
{
    public partial class OneClassView : Form
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
        public string classID;
        Class _class;
        public bool success = false;
        public enum Mode { Add = 0, Edit = 1 };
        Mode mode;

        public OneClassView(Mode mode, string classID = "")
        {
            InitializeComponent();
            this.mode = mode;
            if (mode == Mode.Edit)
                this.classID = classID;
            else
                this.classID = null;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            switch (mode)
            {
                case Mode.Add:
                    lbTittle.Text = "Thêm lớp";
                    break;
                case Mode.Edit:
                    lbTittle.Text = "Cập nhật lớp";
                    SetLoad(true, "Đang tải thông tin lớp...");
                    await Task.Run(() => _class = ClassDA.Instance.GetClass(classID));
                    SetLoad(false);
                    if (_class == null)
                    {
                        Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                        this.Close();
                    }
                    txtClassID.Text = _class.ClassID;
                    txtClassRoom.Text = _class.RoomNumber;
                    txtClassID.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                _class = new Class();
                _class.ClassID = txtClassID.Text;
                _class.RoomNumber = txtClassRoom.Text;
                _class.FormalTeacherID = null;
                _class.StudentNumber = 0;
                Class result = new Class();
                SetLoad(true, "Đang thêm lớp...");
                await Task.Run(() => result = ClassDA.Instance.AddClass(_class));
                if (result != null)
                {
                    classID = _class.ClassID;
                    List<Subject> subjects = new List<Subject>();
                    await Task.Run(() => subjects = SubjectDA.Instance.GetSubjects());
                    int lastTeachingID = await Task.Run(() => TeachingDA.Instance.GetLastTeachingID()) + 1;
                    if (subjects != null)
                    {
                        foreach (Subject subject in subjects)
                        {
                            for (int sem = 1; sem < 3; sem++)
                            {
                                Teaching teaching = new Teaching();
                                teaching.ID = lastTeachingID.ToString();
                                teaching.ClassID = classID;
                                teaching.Semester = sem;
                                teaching.TeacherID = null;
                                teaching.Subject = subject;
                                teaching.Year = DateTime.Now.Year;
                                teaching.Editable = true;
                                await Task.Run(() => teaching = TeachingDA.Instance.AddTeaching(teaching));
                                lastTeachingID++;
                            }
                        }
                    }
                    success = true;
                    this.Close();
                }
                else
                    Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                SetLoad(false);
            }
            else
            {
                _class.ClassID = txtClassID.Text;
                _class.RoomNumber = txtClassRoom.Text;
                Class result = new Class();
                SetLoad(true, "Đang cập nhật lớp...");
                await Task.Run(() => result = ClassDA.Instance.UpdateClassInfo(_class));
                SetLoad(false);
                if (result != null)
                {
                    classID = _class.ClassID;
                    success = true;
                    this.Close();
                }
                else
                    Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
            }
        }
    }
}
