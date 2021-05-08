using MaterialSurface;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class LoginView : Form
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

        readonly HomeView homeView;
        readonly LoginController controller;
        public LoginView(HomeView home)
        {
            InitializeComponent();
            controller = new LoginController(this);
            homeView = home;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Dialog.PrimaryColor = Color.FromArgb(47, 144, 176);
            pictureBox1.MouseDown += MovingForm;
            pictureBox2.MouseDown += MovingForm;
            label1.MouseDown += MovingForm;
            label2.MouseDown += MovingForm;
            label3.MouseDown += MovingForm;
            txtID.TextChanged += (s, ev) =>
            {
                if (txtID.hasError)
                    txtID.RemoveError();
            };
            txtPassword.TextChanged += (s, ev) =>
            {
                if (txtPassword.hasError)
                    txtPassword.RemoveError();
            };
            ckbRemember.Checked = AppSettings.Instance.RememberMe;
            if (AppSettings.Instance.RememberMe)
            {
                txtID.Text = AppSettings.Instance.LastID;
                txtPassword.Text = AppSettings.Instance.LastPassword;
            }
        }
        private void MovingForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            base.OnMouseDown(e);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (controller.logined)
            {
                homeView.LoadTeacher(controller.teacherID, controller.sessionID);
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (Dialog.Show(this, "Bạn chắc chắn muốn thoát?", "Xác nhận", Buttons.YesNo) == DialogResult.No)
                    e.Cancel = true;
            }
        }
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
        public Account GetLoginedAccount()
        {
            return new Account(txtID.Text, txtPassword.Text);
        }
        public void LoginSuccess()
        {
            controller.teacherID = txtID.Text;
            controller.logined = true;
            AppSettings.Instance.LastID = txtID.Text;
            AppSettings.Instance.LastPassword = txtPassword.Text;
            AppSettings.Instance.RememberMe = ckbRemember.Checked;
            AppSettings.Instance.Save();
            this.Close();
        }

        public enum LoginFailReason
        {
            NoConnection,
            WrongPassword,
            InvalidID,
            UnbleToCreateSession
        }
        public void LoginFail(LoginFailReason reason)
        {
            controller.logined = false;
            switch (reason)
            {
                case LoginFailReason.UnbleToCreateSession:
                    Dialog.Show(this, "Không thể khởi tạo phiên đăng nhập!", "Đăng nhập thất bại");
                    break;
                case LoginFailReason.WrongPassword:
                    Dialog.Show(this, "Sai mật khẩu, vui lòng kiểm tra lại!", "Đăng nhập thất bại");
                    break;
                case LoginFailReason.InvalidID:
                    Dialog.Show(this, "Tài khoản không tồn tại, vui lòng kiểm tra lại!", "Đăng nhập thất bại");
                    break;
                case LoginFailReason.NoConnection:
                    Dialog.Show(this, "Không thể kết nối đến máy chủ, vui lòng kiểm tra lại kết nối bạn của bạn hoặc liên hệ admmin!", "Đăng nhập thất bại");
                    break;
                default:
                    break;
            }
        }
        public void SetLoading(bool isLoading, string infor = "")
        {
            lbInformation.Visible = mainProgressbar.Visible = isLoading;
            if (!string.IsNullOrEmpty(infor))
                lbInformation.Text = infor;
        }
        private void OnLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtID.RaiseError("Vui lòng nhập ID.");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.RaiseError("Vui lòng nhập mật khẩu.");
                return;
            }
            controller.Login();
        }

        private void OnChangeRemember(object sender, EventArgs e)
        {
            AppSettings.Instance.RememberMe = ckbRemember.Checked;
            AppSettings.Instance.Save();
        }
    }
}
