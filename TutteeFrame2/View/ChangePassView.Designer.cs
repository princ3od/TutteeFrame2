
namespace TutteeFrame2.View
{
    partial class ChangePassView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassView));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new MaterialSurface.MaterialTextfield();
            this.txtConfirmPass = new MaterialSurface.MaterialTextfield();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.txtPassword = new MaterialSurface.MaterialTextfield();
            this.txtID = new MaterialSurface.MaterialTextfield();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 41);
            this.label1.TabIndex = 32;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtNewPass
            // 
            this.txtNewPass.AutoScaleColor = true;
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPass.CountText = false;
            this.txtNewPass.FieldType = MaterialSurface.BoxType.Normal;
            this.txtNewPass.FloatingLabelText = "FloatingLabel";
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewPass.HandleError = true;
            this.txtNewPass.HelperText = "";
            this.txtNewPass.HideSelection = true;
            this.txtNewPass.HintText = "Mật khẩu mới";
            this.txtNewPass.Location = new System.Drawing.Point(161, 220);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.MouseState = MaterialSurface.MouseState.OUT;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtNewPass.ReadOnly = false;
            this.txtNewPass.ShortcutsEnable = true;
            this.txtNewPass.ShowCaret = true;
            this.txtNewPass.Size = new System.Drawing.Size(360, 72);
            this.txtNewPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtNewPass.TabIndex = 43;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.TextChanged += new System.EventHandler(this.OnNewPassChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.AutoScaleColor = true;
            this.txtConfirmPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPass.CountText = false;
            this.txtConfirmPass.FieldType = MaterialSurface.BoxType.Normal;
            this.txtConfirmPass.FloatingLabelText = "FloatingLabel";
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPass.HandleError = true;
            this.txtConfirmPass.HelperText = "";
            this.txtConfirmPass.HideSelection = true;
            this.txtConfirmPass.HintText = "Xác nhận mật khẩu mới";
            this.txtConfirmPass.Location = new System.Drawing.Point(161, 310);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.MouseState = MaterialSurface.MouseState.OUT;
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtConfirmPass.ReadOnly = false;
            this.txtConfirmPass.ShortcutsEnable = true;
            this.txtConfirmPass.ShowCaret = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(360, 72);
            this.txtConfirmPass.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtConfirmPass.TabIndex = 44;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.OnCofirmedPassChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(189, 400);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(296, 62);
            this.btnSubmit.TabIndex = 45;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.ChangeDelay = 85;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 485);
            this.mainProgressbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(669, 7);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 47;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 35;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(7, 465);
            this.lbInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(176, 19);
            this.lbInformation.TabIndex = 46;
            this.lbInformation.Text = "*Đang cập nhật mật khẩu...";
            this.lbInformation.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = false;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(619, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 40;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoScaleColor = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.CountText = false;
            this.txtPassword.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPassword.FloatingLabelText = "FloatingLabel";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.HandleError = true;
            this.txtPassword.HelperText = "";
            this.txtPassword.HideSelection = true;
            this.txtPassword.HintText = "Mật khẩu hiện tại";
            this.txtPassword.Location = new System.Drawing.Point(161, 122);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ShortcutsEnable = true;
            this.txtPassword.ShowCaret = true;
            this.txtPassword.Size = new System.Drawing.Size(360, 72);
            this.txtPassword.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPassword.TabIndex = 42;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.OnPassTextChanged);
            // 
            // txtID
            // 
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.CountText = false;
            this.txtID.Enabled = false;
            this.txtID.FieldType = MaterialSurface.BoxType.Normal;
            this.txtID.FloatingLabelText = "FloatingLabel";
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.HandleError = false;
            this.txtID.HelperText = "";
            this.txtID.HideSelection = true;
            this.txtID.HintText = "Số ID";
            this.txtID.Location = new System.Drawing.Point(161, 54);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 32767;
            this.txtID.MouseState = MaterialSurface.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Size = new System.Drawing.Size(360, 54);
            this.txtID.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtID.TabIndex = 41;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // ChangePassView
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(667, 492);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePassView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSurface.MaterialTextfield txtNewPass;
        private MaterialSurface.MaterialTextfield txtConfirmPass;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSurface.MaterialTextfield txtPassword;
        private MaterialSurface.MaterialTextfield txtID;
    }
}