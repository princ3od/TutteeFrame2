
namespace TutteeFrame2.View
{
    partial class ChooseServerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseServerView));
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.rbtnServer = new MaterialSurface.MaterialRadioButton();
            this.txtServer = new MaterialSurface.MaterialTextfield();
            this.txtPort = new MaterialSurface.MaterialTextfield();
            this.txtAccount = new MaterialSurface.MaterialTextfield();
            this.txtPassword = new MaterialSurface.MaterialTextfield();
            this.rbtnLocal = new MaterialSurface.MaterialRadioButton();
            this.txtConnectionString = new MaterialSurface.MaterialTextfield();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(507, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 39;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // rbtnServer
            // 
            this.rbtnServer.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.rbtnServer.Location = new System.Drawing.Point(12, 45);
            this.rbtnServer.MinimumSize = new System.Drawing.Size(25, 24);
            this.rbtnServer.MouseState = MaterialSurface.MouseState.OUT;
            this.rbtnServer.Name = "rbtnServer";
            this.rbtnServer.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.rbtnServer.Size = new System.Drawing.Size(257, 28);
            this.rbtnServer.TabIndex = 40;
            this.rbtnServer.TabStop = true;
            this.rbtnServer.UseVisualStyleBackColor = true;
            this.rbtnServer.CheckedChanged += new System.EventHandler(this.OnConnectionTypeChanged);
            // 
            // txtServer
            // 
            this.txtServer.AutoScaleColor = true;
            this.txtServer.BackColor = System.Drawing.SystemColors.Control;
            this.txtServer.CountText = false;
            this.txtServer.Enabled = false;
            this.txtServer.FieldType = MaterialSurface.BoxType.Normal;
            this.txtServer.FloatingLabelText = "FloatingLabel";
            this.txtServer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtServer.HandleError = true;
            this.txtServer.HelperText = "Có thể là địa chỉ ip của server";
            this.txtServer.HideSelection = true;
            this.txtServer.HintText = "Tên server";
            this.txtServer.Location = new System.Drawing.Point(28, 83);
            this.txtServer.MaxLength = 32767;
            this.txtServer.MouseState = MaterialSurface.MouseState.OUT;
            this.txtServer.Multiline = false;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtServer.ReadOnly = false;
            this.txtServer.ShortcutsEnable = true;
            this.txtServer.ShowCaret = true;
            this.txtServer.Size = new System.Drawing.Size(241, 67);
            this.txtServer.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtServer.TabIndex = 41;
            this.txtServer.UseSystemPasswordChar = false;
            // 
            // txtPort
            // 
            this.txtPort.AutoScaleColor = true;
            this.txtPort.BackColor = System.Drawing.SystemColors.Control;
            this.txtPort.CountText = false;
            this.txtPort.Enabled = false;
            this.txtPort.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPort.FloatingLabelText = "FloatingLabel";
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPort.HandleError = true;
            this.txtPort.HelperText = "*số";
            this.txtPort.HideSelection = true;
            this.txtPort.HintText = "Cổng";
            this.txtPort.Location = new System.Drawing.Point(275, 83);
            this.txtPort.MaxLength = 32767;
            this.txtPort.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPort.ReadOnly = false;
            this.txtPort.ShortcutsEnable = true;
            this.txtPort.ShowCaret = true;
            this.txtPort.Size = new System.Drawing.Size(187, 67);
            this.txtPort.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPort.TabIndex = 42;
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.TextChanged += new System.EventHandler(this.DigitOnly);
            // 
            // txtAccount
            // 
            this.txtAccount.AutoScaleColor = true;
            this.txtAccount.BackColor = System.Drawing.SystemColors.Control;
            this.txtAccount.CountText = false;
            this.txtAccount.Enabled = false;
            this.txtAccount.FieldType = MaterialSurface.BoxType.Normal;
            this.txtAccount.FloatingLabelText = "FloatingLabel";
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAccount.HandleError = true;
            this.txtAccount.HelperText = "";
            this.txtAccount.HideSelection = true;
            this.txtAccount.HintText = "Tên tài khoản";
            this.txtAccount.Location = new System.Drawing.Point(28, 156);
            this.txtAccount.MaxLength = 32767;
            this.txtAccount.MouseState = MaterialSurface.MouseState.OUT;
            this.txtAccount.Multiline = false;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAccount.ReadOnly = false;
            this.txtAccount.ShortcutsEnable = true;
            this.txtAccount.ShowCaret = true;
            this.txtAccount.Size = new System.Drawing.Size(241, 67);
            this.txtAccount.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtAccount.TabIndex = 43;
            this.txtAccount.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoScaleColor = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.CountText = false;
            this.txtPassword.Enabled = false;
            this.txtPassword.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPassword.FloatingLabelText = "FloatingLabel";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.HandleError = true;
            this.txtPassword.HelperText = "";
            this.txtPassword.HideSelection = true;
            this.txtPassword.HintText = "Mật khẩu";
            this.txtPassword.Location = new System.Drawing.Point(275, 156);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ShortcutsEnable = true;
            this.txtPassword.ShowCaret = true;
            this.txtPassword.Size = new System.Drawing.Size(241, 67);
            this.txtPassword.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPassword.TabIndex = 44;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.rbtnLocal.Location = new System.Drawing.Point(12, 240);
            this.rbtnLocal.MinimumSize = new System.Drawing.Size(25, 24);
            this.rbtnLocal.MouseState = MaterialSurface.MouseState.OUT;
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.rbtnLocal.Size = new System.Drawing.Size(190, 28);
            this.rbtnLocal.TabIndex = 45;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.UseVisualStyleBackColor = true;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.OnConnectionTypeChanged);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.AutoScaleColor = true;
            this.txtConnectionString.BackColor = System.Drawing.SystemColors.Control;
            this.txtConnectionString.CountText = false;
            this.txtConnectionString.Enabled = false;
            this.txtConnectionString.FieldType = MaterialSurface.BoxType.Normal;
            this.txtConnectionString.FloatingLabelText = "FloatingLabel";
            this.txtConnectionString.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConnectionString.HandleError = true;
            this.txtConnectionString.HelperText = "Chuỗi kết nối đến server tại máy";
            this.txtConnectionString.HideSelection = true;
            this.txtConnectionString.HintText = "Chuỗi kết nối";
            this.txtConnectionString.Location = new System.Drawing.Point(28, 278);
            this.txtConnectionString.MaxLength = 32767;
            this.txtConnectionString.MouseState = MaterialSurface.MouseState.OUT;
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.PasswordChar = '\0';
            this.txtConnectionString.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtConnectionString.ReadOnly = false;
            this.txtConnectionString.ShortcutsEnable = true;
            this.txtConnectionString.ShowCaret = true;
            this.txtConnectionString.Size = new System.Drawing.Size(488, 104);
            this.txtConnectionString.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtConnectionString.TabIndex = 46;
            this.txtConnectionString.UseSystemPasswordChar = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(181, 388);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(192, 50);
            this.btnSubmit.TabIndex = 47;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 48;
            this.label1.Text = "KẾT NỐI SERVER (LAN)";
            this.label1.Click += new System.EventHandler(this.OnServerClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 49;
            this.label2.Text = "KẾT NỐI LOCAL";
            this.label2.Click += new System.EventHandler(this.OnLocalClicked);
            // 
            // ChooseServerView
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.rbtnLocal);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.rbtnServer);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseServerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChooseServerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSurface.MaterialRadioButton rbtnServer;
        private MaterialSurface.MaterialTextfield txtServer;
        private MaterialSurface.MaterialTextfield txtPort;
        private MaterialSurface.MaterialTextfield txtAccount;
        private MaterialSurface.MaterialTextfield txtPassword;
        private MaterialSurface.MaterialRadioButton rbtnLocal;
        private MaterialSurface.MaterialTextfield txtConnectionString;
        private MaterialSurface.ContainedButton btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}