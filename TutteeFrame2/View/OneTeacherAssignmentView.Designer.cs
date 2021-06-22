
namespace TutteeFrame2.View
{
    partial class OneTeacherAssignmentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneTeacherAssignmentView));
            this.lbClassInfor = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.txtFormTeacher = new MaterialSurface.MaterialTextfield();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpgSem1 = new System.Windows.Forms.TabPage();
            this.tbpgSem2 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClassInfor
            // 
            this.lbClassInfor.AutoSize = true;
            this.lbClassInfor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassInfor.Location = new System.Drawing.Point(41, 41);
            this.lbClassInfor.Name = "lbClassInfor";
            this.lbClassInfor.Size = new System.Drawing.Size(246, 30);
            this.lbClassInfor.TabIndex = 49;
            this.lbClassInfor.Text = "Phòng học: ---- - Sỉ số: --";
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassID.Location = new System.Drawing.Point(12, 9);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(103, 32);
            this.lbClassID.TabIndex = 48;
            this.lbClassID.Text = "Lớp ----";
            // 
            // txtFormTeacher
            // 
            this.txtFormTeacher.AutoScaleColor = false;
            this.txtFormTeacher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFormTeacher.CountText = false;
            this.txtFormTeacher.FieldType = MaterialSurface.BoxType.Filled;
            this.txtFormTeacher.FloatingLabelText = "Giáo viên chủ nhiệm";
            this.txtFormTeacher.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFormTeacher.HandleError = false;
            this.txtFormTeacher.HelperText = "";
            this.txtFormTeacher.HideSelection = false;
            this.txtFormTeacher.HintText = "Giáo viên chủ nhiệm";
            this.txtFormTeacher.Location = new System.Drawing.Point(46, 92);
            this.txtFormTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormTeacher.MaxLength = 32767;
            this.txtFormTeacher.MouseState = MaterialSurface.MouseState.OUT;
            this.txtFormTeacher.Multiline = false;
            this.txtFormTeacher.Name = "txtFormTeacher";
            this.txtFormTeacher.PasswordChar = '\0';
            this.txtFormTeacher.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFormTeacher.ReadOnly = true;
            this.txtFormTeacher.ShortcutsEnable = true;
            this.txtFormTeacher.ShowCaret = false;
            this.txtFormTeacher.Size = new System.Drawing.Size(494, 49);
            this.txtFormTeacher.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtFormTeacher.TabIndex = 51;
            this.txtFormTeacher.Tag = "GVCN";
            this.txtFormTeacher.UseSystemPasswordChar = false;
            this.txtFormTeacher.Enter += new System.EventHandler(this.OnChooseTeacher);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = this.materialTabControl1;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = true;
            this.materialDrawer1.Location = new System.Drawing.Point(0, 156);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(166, 379);
            this.materialDrawer1.TabIndex = 52;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tbpgSem1);
            this.materialTabControl1.Controls.Add(this.tbpgSem2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(174, 156);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(623, 379);
            this.materialTabControl1.TabIndex = 53;
            // 
            // tbpgSem1
            // 
            this.tbpgSem1.AutoScroll = true;
            this.tbpgSem1.BackColor = System.Drawing.Color.White;
            this.tbpgSem1.Location = new System.Drawing.Point(4, 22);
            this.tbpgSem1.Name = "tbpgSem1";
            this.tbpgSem1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSem1.Size = new System.Drawing.Size(615, 353);
            this.tbpgSem1.TabIndex = 0;
            this.tbpgSem1.Text = "Học Kì 1";
            // 
            // tbpgSem2
            // 
            this.tbpgSem2.AutoScroll = true;
            this.tbpgSem2.BackColor = System.Drawing.Color.White;
            this.tbpgSem2.Location = new System.Drawing.Point(4, 22);
            this.tbpgSem2.Name = "tbpgSem2";
            this.tbpgSem2.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSem2.Size = new System.Drawing.Size(615, 353);
            this.tbpgSem2.TabIndex = 1;
            this.tbpgSem2.Text = "Học Kì 2";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(299, 537);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(198, 50);
            this.btnSubmit.TabIndex = 54;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 594);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(802, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 65;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 36;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(12, 578);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 66;
            this.lbInformation.Text = "*Đang kết nối...";
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
            this.btnClose.Location = new System.Drawing.Point(753, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 50;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // OneTeacherAssignmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.txtFormTeacher);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbClassInfor);
            this.Controls.Add(this.lbClassID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneTeacherAssignmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OneTeacherAssignmentView";
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClassInfor;
        private System.Windows.Forms.Label lbClassID;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSurface.MaterialTextfield txtFormTeacher;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbpgSem1;
        private System.Windows.Forms.TabPage tbpgSem2;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
    }
}