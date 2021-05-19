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
    public enum Mode { Add, Edit };

    public partial class OneTeacherView : Form
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

        public Mode mode;
        public string teacherID;
        public Teacher teacher;
        public bool doneSuccess = false;
        List<Subject> subjects = new List<Subject>();
        public OneTeacherView(Mode _mode, string _teacherID = null)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (!string.IsNullOrEmpty(_teacherID))
                teacherID = _teacherID;
            mode = _mode;
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvatar.Width, ptbAvatar.Height);
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;

            SetLoad(true, "Đang tải dữ liệu...");
            await Task.Run(() =>
            {
                subjects = SubjectDA.Instance.GetSubjects();
            });
            foreach (Subject subject in subjects)
            {
                cbbSubject.Items.Add(subject.Name);
            }
            SetLoad(false);
            switch (mode)
            {
                case Mode.Add:
                    btnSubmit.Text = "Thêm";
                    teacherID = "TC" + IdentifierFactory.GenerateNumberID();
                    lbID.Text = teacherID;
                    lbID.ForeColor = Color.Green;
                    lbName.Text = "--";
                    break;
                case Mode.Edit:
                    btnSubmit.Text = "Cập nhật";
                    SetLoad(true, "Đang lấy thông tin giáo viên...");
                    await Task.Run(() => teacher = TeacherDA.Instance.GetTeacher(teacherID));
                    lbID.Text = teacher.ID;
                    lbName.Text = teacher.SurName + " " + teacher.FirstName;
                    txtFirstname.Text = teacher.FirstName;
                    txtSurename.Text = teacher.SurName;
                    dateBorn.Value = teacher.DateBorn;
                    cbbSex.SelectedIndex = Convert.ToInt32(teacher.Sex);
                    txtAddress.Text = teacher.Address;
                    txtPhone.Text = teacher.Phone;
                    txtMail.Text = teacher.Mail;
                    ptbAvatar.Image = teacher.Avatar;
                    txtPosition.Text = teacher.Position;
                    switch (teacher.Type)
                    {
                        case TeacherType.FormerTeacher:
                        case TeacherType.Teacher:
                            cbbType.SelectedIndex = 0;
                            break;
                        case TeacherType.Adminstrator:
                            cbbType.SelectedIndex = 2;
                            break;
                        case TeacherType.Ministry:
                            cbbType.SelectedIndex = 1;
                            break;
                        default:
                            break;
                    }
                    SetLoad(false);
                    break;
                default:
                    break;
            }
            cbbSex.SelectedIndex = 0;
            cbbSubject.SelectedIndex = 0;
            cbbType.SelectedIndex = 0;
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

        private void OnUpdateName(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    if (string.IsNullOrEmpty(txtSurename.Text) && string.IsNullOrEmpty(txtFirstname.Text))
                        lbName.Text = "--";
                    else
                        lbName.Text = txtSurename.Text + " " + txtFirstname.Text;
                    break;
                case Mode.Edit:
                    break;
                default:
                    break;
            }
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            teacher = new Teacher()
            {
                ID = lbID.Text,
                SurName = txtSurename.Text,
                FirstName = txtFirstname.Text,
                DateBorn = dateBorn.Value,
                Sex = Convert.ToBoolean(cbbSex.SelectedIndex),
                Address = txtAddress.Text,
                Mail = txtMail.Text,
                Phone = txtPhone.Text,
                Subject = subjects[cbbSubject.SelectedIndex],
                Avatar = ptbAvatar.Image,
                Position = txtPosition.Text,
            };
            switch (cbbType.SelectedIndex)
            {
                case 0:
                    teacher.Type = TeacherType.Teacher;
                    break;
                case 1:
                    teacher.Type = TeacherType.Ministry;
                    break;
                case 2:
                    teacher.Type = TeacherType.Adminstrator;
                    break;
                default:
                    break;
            }
            switch (mode)
            {
                case Mode.Add:
                    SetLoad(true, "Đang thêm giáo viên...");
                    await Task.Run(() => teacher = TeacherDA.Instance.AddTeacher(teacher));
                    if (teacher != null)
                    {
                        SetLoad(true, "Đang thêm tài khoản giáo viên...");
                        Account account = new Account()
                        {
                            ID = teacher.ID,
                            TeacherID = teacher.ID,
                            Password = PasswordHasher.Hash("1"),
                        };
                        await Task.Run(() => account = AccountDA.Instance.AddAccount(account));
                        doneSuccess = true;
                        SetLoad(false);
                        Dialog.Show(this, "Đã thêm giáo viên mới thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        doneSuccess = false;
                        SetLoad(false);
                        Dialog.Show(this, "Thêm giáo viên thất bại, đã có lỗi xảy ra!", "Lỗi");
                    }
                    break;
                case Mode.Edit:
                    SetLoad(true, "Đang cập nhật giáo viên...");
                    await Task.Run(() => teacher = TeacherDA.Instance.UpdateTeacher(teacherID, teacher));
                    if (teacher != null)
                    {
                        teacherID = teacher.ID;
                        doneSuccess = true;
                        SetLoad(false);
                        Dialog.Show(this, "Đã cập nhật giáo viên thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        doneSuccess = false;
                        SetLoad(false);
                        Dialog.Show(this, "Cập nhật giáo viên thất bại, đã có lỗi xảy ra!", "Lỗi");
                    }
                    break;
                default:
                    break;
            }
        }
    }

}
