
namespace TutteeFrame2.View
{
    partial class StudentCardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCardView));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBasicInfor = new MaterialSkin.Controls.MaterialCard();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.ptbStudentAvatar = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            this.pnBasicInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudentAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbPhone);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(171, 295);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(372, 111);
            this.materialCard1.TabIndex = 55;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.lbPhone.Location = new System.Drawing.Point(31, 51);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(63, 23);
            this.lbPhone.TabIndex = 44;
            this.lbPhone.Text = "SĐT: --";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Thông tin liên lạc";
            // 
            // pnBasicInfor
            // 
            this.pnBasicInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnBasicInfor.Controls.Add(this.lbAddress);
            this.pnBasicInfor.Controls.Add(this.lbSex);
            this.pnBasicInfor.Controls.Add(this.lbBirthday);
            this.pnBasicInfor.Controls.Add(this.lbName);
            this.pnBasicInfor.Controls.Add(this.lbID);
            this.pnBasicInfor.Controls.Add(this.label1);
            this.pnBasicInfor.Depth = 0;
            this.pnBasicInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBasicInfor.Location = new System.Drawing.Point(171, 23);
            this.pnBasicInfor.Margin = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnBasicInfor.Name = "pnBasicInfor";
            this.pnBasicInfor.Padding = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.Size = new System.Drawing.Size(372, 254);
            this.pnBasicInfor.TabIndex = 54;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbAddress.Location = new System.Drawing.Point(31, 185);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(324, 58);
            this.lbAddress.TabIndex = 45;
            this.lbAddress.Text = "Địa chỉ: --";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbSex.Location = new System.Drawing.Point(31, 153);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(89, 21);
            this.lbSex.TabIndex = 44;
            this.lbSex.Text = "Giới tính: --";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbBirthday.Location = new System.Drawing.Point(31, 121);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(99, 21);
            this.lbBirthday.TabIndex = 43;
            this.lbBirthday.Text = "Ngày sinh: --";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbName.Location = new System.Drawing.Point(31, 91);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 21);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Họ tên: --";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbID.Location = new System.Drawing.Point(31, 57);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(113, 21);
            this.lbID.TabIndex = 41;
            this.lbID.Text = "Mã học sinh: --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(0, 444);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(602, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 51;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 32;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(6, 428);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(117, 13);
            this.lbInformation.TabIndex = 50;
            this.lbInformation.Text = "*Đang tải thông tin...";
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
            this.btnClose.Location = new System.Drawing.Point(555, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 57;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // ptbStudentAvatar
            // 
            this.ptbStudentAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptbStudentAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbStudentAvatar.Location = new System.Drawing.Point(24, 44);
            this.ptbStudentAvatar.Name = "ptbStudentAvatar";
            this.ptbStudentAvatar.Size = new System.Drawing.Size(130, 150);
            this.ptbStudentAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStudentAvatar.TabIndex = 58;
            this.ptbStudentAvatar.TabStop = false;
            // 
            // StudentCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.ptbStudentAvatar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pnBasicInfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentCardView";
            this.Text = "StudentCardView";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnBasicInfor.ResumeLayout(false);
            this.pnBasicInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudentAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard pnBasicInfor;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.PictureBox ptbStudentAvatar;
    }
}