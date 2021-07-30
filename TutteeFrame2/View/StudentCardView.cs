using MaterialSurface;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;

namespace TutteeFrame2.View
{
    public partial class StudentCardView : Form
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
        string studentID;
        Student student;
        public StudentCardView(string _studentID)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            studentID = _studentID;
            student = new Student();
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetLoad(true, "Đang tải thông tin...");
            await Task.Run(() =>
            {
                student = StudentDA.Instance.GetStudentByID(studentID);
            });

            if (student == null)
            {
                Dialog.Show(this, "Không tải được dữ liệu của học sinh này.", "Lỗi");
                return;
            }
            ptbStudentAvatar.Image = student.Avatar;
            lbID.Text = lbID.Text.Replace("--", student.ID);
            lbName.Text = lbName.Text.Replace("--", student.GetName());
            lbBirthday.Text = lbBirthday.Text.Replace("--", student.DateBorn.ToString("dd/MM/yyyy"));
            lbSex.Text = lbSex.Text.Replace("--", student.GetSex);
            lbAddress.Text = lbAddress.Text.Replace("--", student.Address);
            lbPhone.Text = lbPhone.Text.Replace("--", student.Phone);
            SetLoad(false);
        }

        public void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
        }
    }
}
