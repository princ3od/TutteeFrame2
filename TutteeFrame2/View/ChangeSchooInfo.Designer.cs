﻿
namespace TutteeFrame2.View
{
    partial class ChangeSchooInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeSchooInfo));
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSologan = new MaterialSurface.MaterialTextfield();
            this.txtFullSchoolName = new MaterialSurface.MaterialTextfield();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnChooseAvatar = new TutteeFrame2.Controls.CircularButton();
            this.ptbAvatar = new TutteeFrame2.Controls.CircularPicture();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.ChangeDelay = 85;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(0, 455);
            this.mainProgressbar.Margin = new System.Windows.Forms.Padding(4);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(800, 7);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 56;
            this.mainProgressbar.Text = "mainProgressBar";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 35;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(13, 440);
            this.lbInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(188, 13);
            this.lbInformation.TabIndex = 55;
            this.lbInformation.Text = "*Đang cập nhật thông tin trường...";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(350, 363);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(144, 48);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitle.Location = new System.Drawing.Point(287, 50);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(287, 37);
            this.lbTitle.TabIndex = 48;
            this.lbTitle.Text = "THÔNG TIN TRƯỜNG";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSologan
            // 
            this.txtSologan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSologan.AutoScaleColor = true;
            this.txtSologan.BackColor = System.Drawing.Color.White;
            this.txtSologan.CountText = false;
            this.txtSologan.Enabled = false;
            this.txtSologan.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSologan.FloatingLabelText = "FloatingLabel";
            this.txtSologan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSologan.HandleError = false;
            this.txtSologan.HelperText = "";
            this.txtSologan.HideSelection = true;
            this.txtSologan.HintText = "Sologan";
            this.txtSologan.Location = new System.Drawing.Point(295, 178);
            this.txtSologan.Margin = new System.Windows.Forms.Padding(30);
            this.txtSologan.MaxLength = 32767;
            this.txtSologan.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSologan.Multiline = false;
            this.txtSologan.Name = "txtSologan";
            this.txtSologan.PasswordChar = '\0';
            this.txtSologan.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSologan.ReadOnly = false;
            this.txtSologan.ShortcutsEnable = true;
            this.txtSologan.ShowCaret = true;
            this.txtSologan.Size = new System.Drawing.Size(360, 49);
            this.txtSologan.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSologan.TabIndex = 74;
            this.txtSologan.UseSystemPasswordChar = false;
            // 
            // txtFullSchoolName
            // 
            this.txtFullSchoolName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullSchoolName.AutoScaleColor = true;
            this.txtFullSchoolName.BackColor = System.Drawing.Color.White;
            this.txtFullSchoolName.CountText = false;
            this.txtFullSchoolName.Enabled = false;
            this.txtFullSchoolName.FieldType = MaterialSurface.BoxType.Normal;
            this.txtFullSchoolName.FloatingLabelText = "FloatingLabel";
            this.txtFullSchoolName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullSchoolName.HandleError = false;
            this.txtFullSchoolName.HelperText = "";
            this.txtFullSchoolName.HideSelection = true;
            this.txtFullSchoolName.HintText = "Tên trường";
            this.txtFullSchoolName.Location = new System.Drawing.Point(295, 265);
            this.txtFullSchoolName.Margin = new System.Windows.Forms.Padding(30);
            this.txtFullSchoolName.MaxLength = 32767;
            this.txtFullSchoolName.MouseState = MaterialSurface.MouseState.OUT;
            this.txtFullSchoolName.Multiline = false;
            this.txtFullSchoolName.Name = "txtFullSchoolName";
            this.txtFullSchoolName.PasswordChar = '\0';
            this.txtFullSchoolName.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFullSchoolName.ReadOnly = false;
            this.txtFullSchoolName.ShortcutsEnable = true;
            this.txtFullSchoolName.ShowCaret = true;
            this.txtFullSchoolName.Size = new System.Drawing.Size(360, 49);
            this.txtFullSchoolName.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtFullSchoolName.TabIndex = 75;
            this.txtFullSchoolName.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TutteeFrame2.Properties.Resources.slogan_3317101_27879741;
            this.pictureBox1.Location = new System.Drawing.Point(238, 182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox10.Image = global::TutteeFrame2.Properties.Resources.school;
            this.pictureBox10.Location = new System.Drawing.Point(238, 269);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 45;
            this.pictureBox10.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = false;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(756, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 49;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChooseAvatar.BackColor = System.Drawing.Color.Silver;
            this.btnChooseAvatar.FlatAppearance.BorderSize = 0;
            this.btnChooseAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseAvatar.ForeColor = System.Drawing.Color.Transparent;
            this.btnChooseAvatar.Image = global::TutteeFrame2.Properties.Resources.outline_edit_black_24dp1;
            this.btnChooseAvatar.Location = new System.Drawing.Point(106, 102);
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(40, 40);
            this.btnChooseAvatar.TabIndex = 82;
            this.btnChooseAvatar.UseVisualStyleBackColor = false;
            this.btnChooseAvatar.Click += new System.EventHandler(this.btnChooseAvatar_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbAvatar.Image = global::TutteeFrame2.Properties.Resources.enemy_spot;
            this.ptbAvatar.Location = new System.Drawing.Point(12, 8);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(134, 134);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 81;
            this.ptbAvatar.TabStop = false;
            // 
            // ChangeSchooInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.btnChooseAvatar);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFullSchoolName);
            this.Controls.Add(this.txtSologan);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeSchooInfo";
            this.Text = "ChangeSchooInfo";
            this.Load += new System.EventHandler(this.ChangeSchooInfo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeSchoolInfo_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox10;
        private MaterialSurface.MaterialTextfield txtSologan;
        private MaterialSurface.MaterialTextfield txtFullSchoolName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.CircularPicture ptbAvatar;
        private Controls.CircularButton btnChooseAvatar;
    }
}