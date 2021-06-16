using MaterialSurface;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;

namespace TutteeFrame2.View
{
    public partial class OnePunishmentView : Form
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
        string studentID;
        Punishment punishment;
        public string punishmentID;
        public enum OpenMode { FaultOnly = 0, Full = 1 };
        OpenMode openMode;
        public enum Mode { Add = 0, Edit = 1 };
        Mode mode;
        public OnePunishmentView(string _studentID, Mode _mode, OpenMode _openMode, string _punishmentID = "")
        {
            InitializeComponent();
            this.openMode = _openMode;
            this.mode = _mode;
            this.studentID = _studentID;
            punishmentID = _punishmentID;
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Student student = new Student();
            switch (openMode)
            {
                case OpenMode.FaultOnly:
                    txtPunishmentContent.Visible = false;
                    this.Size = new Size(this.Width, 330);
                    btnSubmit.Text = "Thêm vi phạm";
                    break;
                case OpenMode.Full:
                    btnSubmit.Text = "Xác nhận";
                    break;
                default:
                    break;
            }
            SetLoad(true, "Đang lấy dữ liệu...");
            await Task.Run(() => student = StudentDA.Instance.GetStudentByID(studentID));
            SetLoad(false);
            if (student == null)
            {
                Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                return;
            }
            switch (mode)
            {
                case Mode.Add:
                    cbbSemester.SelectedIndex = 0;
                    txtYear.Enabled = true;
                    punishment = new Punishment(student.ExactID);
                    punishment.StudentID = student.ID;
                    punishment.Grade = Int32.Parse(student.GetGrade);
                    punishment.Semester = Int32.Parse(cbbSemester.Text);
                    punishment.Year = DateTime.Now.Year;
                    txtYear.Text = punishment.Year.ToString();
                    txtID.Text = punishment.ID;
                    lbName.Text = string.Format("{0} ({1}) - {2}", student.GetName(), studentID, student.ClassID);
                    lbSex.Text = string.Format("Giới tính: {0}", student.GetSex);
                    btnSubmit.Enabled = true;
                    break;
                case Mode.Edit:
                    btnSubmit.Text = "Cập nhật";
                    SetLoad(true, "Đang lấy dữ liệu...");
                    await Task.Run(() => punishment = PunishmentDA.Instance.GetPunishment(punishmentID));
                    SetLoad(false);
                    if (punishment == null)
                    {
                        Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                        this.Close();
                    }
                    txtPunishmentContent.Focus();
                    txtID.Text = punishmentID;
                    txtYear.Text = punishment.Year.ToString();
                    txtFaultContent.Text = punishment.Fault;
                    txtPunishmentContent.Text = punishment.Content;
                    cbbSemester.SelectedIndex = punishment.Semester - 1;
                    lbName.Text = string.Format("{0} ({1}) - {2}", student.GetName(), studentID, student.ClassID);
                    lbSex.Text = string.Format("Giới tính: {0}", student.GetSex);
                    btnSubmit.Enabled = true;
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
            if (string.IsNullOrEmpty(txtFaultContent.Text))
            {
                Dialog.Show(this, "Vui lòng nhập nội dung vi phạm.", "Lỗi");
                txtFaultContent.Focus();
                return;
            }
            if (mode == Mode.Add)
            {
                punishment.Content = txtPunishmentContent.Text;
                punishment.Fault = txtFaultContent.Text;
                punishment.Semester = Int32.Parse(cbbSemester.Text);
                Punishment result = new Punishment();
                SetLoad(true, "Đang thêm vi phạm...");
                await Task.Run(() => result = PunishmentDA.Instance.AddPunishment(punishment));
                SetLoad(false);
                if (result != null)
                {
                    punishmentID = punishment.ID;
                    success = true;
                    this.Close();
                }
                else
                    Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
            }
            else
            {
                punishment.Content = txtPunishmentContent.Text;
                punishment.Fault = txtFaultContent.Text;
                punishment.Semester = Int32.Parse(cbbSemester.Text);
                Punishment result = new Punishment();
                SetLoad(true, "Đang cập nhật vi phạm...");
                await Task.Run(() => result = PunishmentDA.Instance.UpdatePunishment(punishmentID, punishment));
                SetLoad(false);
                if (result != null)
                {
                    success = true;
                    this.Close();
                }
                else
                    Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
            }
        }
    }
}

