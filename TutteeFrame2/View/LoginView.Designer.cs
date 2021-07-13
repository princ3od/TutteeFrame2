
namespace TutteeFrame2.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.lbInformation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new MaterialSurface.MaterialTextfield();
            this.txtPassword = new MaterialSurface.MaterialTextfield();
            this.ckbRemember = new MaterialSurface.MaterialCheckbox();
            this.btnLogin = new MaterialSurface.ContainedButton();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnChooseServer = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(432, 578);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 31;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(517, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Hãy nhập ID và mật khẩu của bạn để bắt đầu.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Xin chào";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(599, 472);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "TutteeFrame © 2021";
            // 
            // txtID
            // 
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CountText = false;
            this.txtID.FieldType = MaterialSurface.BoxType.Normal;
            this.txtID.FloatingLabelText = "FloatingLabel";
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.HandleError = true;
            this.txtID.HelperText = "";
            this.txtID.HideSelection = true;
            this.txtID.HintText = "Số ID";
            this.txtID.Location = new System.Drawing.Point(535, 245);
            this.txtID.MaxLength = 32767;
            this.txtID.MouseState = MaterialSurface.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Size = new System.Drawing.Size(270, 67);
            this.txtID.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtID.TabIndex = 32;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoScaleColor = true;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.CountText = false;
            this.txtPassword.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPassword.FloatingLabelText = "FloatingLabel";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.HandleError = true;
            this.txtPassword.HelperText = "";
            this.txtPassword.HideSelection = true;
            this.txtPassword.HintText = "Mật khẩu";
            this.txtPassword.Location = new System.Drawing.Point(535, 314);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ShortcutsEnable = true;
            this.txtPassword.ShowCaret = true;
            this.txtPassword.Size = new System.Drawing.Size(270, 67);
            this.txtPassword.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPassword.TabIndex = 33;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // ckbRemember
            // 
            this.ckbRemember.BorderColor = System.Drawing.Color.Gray;
            this.ckbRemember.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ckbRemember.Location = new System.Drawing.Point(547, 383);
            this.ckbRemember.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.ckbRemember.MinimumSize = new System.Drawing.Size(25, 24);
            this.ckbRemember.MouseState = MaterialSurface.MouseState.OUT;
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.ckbRemember.Size = new System.Drawing.Size(165, 24);
            this.ckbRemember.TabIndex = 34;
            this.ckbRemember.Text = "Ghi nhớ tôi";
            this.ckbRemember.UseVisualStyleBackColor = true;
            this.ckbRemember.CheckedChanged += new System.EventHandler(this.OnChangeRemember);
            // 
            // btnLogin
            // 
            this.btnLogin.EffectType = MaterialSurface.ET.Custom;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(535, 413);
            this.btnLogin.MouseState = MaterialSurface.MouseState.OUT;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnLogin.Radius = 2;
            this.btnLogin.ShawdowDepth = 3;
            this.btnLogin.ShawdowOpacity = 50;
            this.btnLogin.Size = new System.Drawing.Size(270, 50);
            this.btnLogin.TabIndex = 35;
            this.btnLogin.Text = "Đăng nhập ";
            this.btnLogin.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.OnLogin);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.ChangeDelay = 85;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(426, 594);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(475, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 36;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 35;
            this.mainProgressbar.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = false;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(857, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 38;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Exit);
            // 
            // btnChooseServer
            // 
            this.btnChooseServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseServer.Depth = 0;
            this.btnChooseServer.DrawShadows = false;
            this.btnChooseServer.HighEmphasis = false;
            this.btnChooseServer.Icon = ((System.Drawing.Image)(resources.GetObject("btnChooseServer.Icon")));
            this.btnChooseServer.Location = new System.Drawing.Point(810, 0);
            this.btnChooseServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChooseServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseServer.Name = "btnChooseServer";
            this.btnChooseServer.Size = new System.Drawing.Size(44, 36);
            this.btnChooseServer.TabIndex = 37;
            this.btnChooseServer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnChooseServer.UseAccentColor = false;
            this.btnChooseServer.UseVisualStyleBackColor = true;
            this.btnChooseServer.Click += new System.EventHandler(this.OnChooseServer);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(535, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 74);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // LoginView
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChooseServer);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ckbRemember);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.MaterialTextfield txtID;
        private MaterialSurface.MaterialTextfield txtPassword;
        private MaterialSurface.MaterialCheckbox ckbRemember;
        private MaterialSurface.ContainedButton btnLogin;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private MaterialSkin.Controls.MaterialButton btnChooseServer;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}