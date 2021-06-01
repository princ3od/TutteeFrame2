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
    public partial class ChangePassView : Form
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
        string teacherID;
        public bool passUpdated = false;
        public ChangePassView(string _teacherID)
        {
            InitializeComponent();
            teacherID = _teacherID;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtID.Text = teacherID;
        }
        public void SetLoading(bool isLoading, string infor = "")
        {
            lbInformation.Visible = mainProgressbar.Visible = isLoading;
            if (!string.IsNullOrEmpty(infor))
                lbInformation.Text = infor;
        }
        private void OnExit(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtPassword.Text))
            //    txtPassword.Text = " ";
            //if (string.IsNullOrEmpty(txtNewPass.Text))
            //    txtNewPass.Text = " ";
            //if (string.IsNullOrEmpty(txtConfirmPass.Text))
            //    txtConfirmPass.Text = " ";
            this.Close();
        }

        private async void OnSubmit(object sender, EventArgs e)
        {
            SetLoading(true);
            bool verified = false;
            await Task.Run(() =>
            {
                Account returnAccount = AccountDA.Instance.GetAccount(teacherID);

                if (returnAccount == null)
                {
                    Dialog.Show(this, "Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
                }
                else
                {
                    if (PasswordHasher.Verify(txtPassword.Text, returnAccount.Password))
                    {
                        verified = true;
                        passUpdated = AccountDA.Instance.UpdatePassword(teacherID, PasswordHasher.Hash(txtNewPass.Text));
                    }
                }
            });
            SetLoading(false);
            if (!verified)
            {
                Dialog.Show(this, "Sai mật khẩu, vui lòng kiểm tra lại!", "Lỗi");
                txtPassword.Focus();
            }
            else
            {
                if (passUpdated)
                {
                    Dialog.Show(this, "Bạn đã cập nhật mật khẩu thành công. Vui lòng đăng nhập lại!", "Thông báo");
                    Application.Restart();
                }
                else
                    Dialog.Show(this, "Có lỗi xảy ra, vui lòng thử lại.", "Lỗi");
            }
        }

        private void OnNewPassChanged(object sender, EventArgs e)
        {
            txtConfirmPass.Clear();
            if (string.IsNullOrEmpty(txtNewPass.Text))
            {
                if (txtNewPass.hasError)
                    txtNewPass.RemoveError();
                return;
            }
            if (txtNewPass.hasError)
                txtNewPass.RemoveError();
            if (txtPassword.Text == txtNewPass.Text)
                txtNewPass.RaiseError("Mật khẩu mới không thể giống mật khẩu cũ.");
        }

        private void OnCofirmedPassChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                if (txtConfirmPass.hasError)
                    txtConfirmPass.RemoveError();
                return;
            }
            if (txtConfirmPass.hasError)
                txtConfirmPass.RemoveError();
            if (txtNewPass.Text != txtConfirmPass.Text)
                txtConfirmPass.RaiseError("Mật khẩu xác nhận không khớp.");
        }

        private void OnPassTextChanged(object sender, EventArgs e)
        {
            txtNewPass.Clear();
        }
    }
}
