
namespace TutteeFrame2.View
{
    partial class OnePunishmentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnePunishmentView));
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtID = new MaterialSurface.MaterialTextfield();
            this.txtYear = new MaterialSurface.MaterialTextfield();
            this.cbbSemester = new MaterialSurface.MaterialComboBox();
            this.txtFaultContent = new MaterialSurface.MaterialTextfield();
            this.txtPunishmentContent = new MaterialSurface.MaterialTextfield();
            this.btnSubmit = new MaterialSurface.ContainedButton();
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
            this.btnClose.Location = new System.Drawing.Point(555, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 41;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 444);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(602, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 49;
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
            this.lbInformation.Location = new System.Drawing.Point(5, 428);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(118, 13);
            this.lbInformation.TabIndex = 48;
            this.lbInformation.Text = "*Đang lấy thông tin...";
            this.lbInformation.Visible = false;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(115, 64);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(101, 21);
            this.lbSex.TabIndex = 62;
            this.lbSex.Text = "Giới tính: ----";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(176, 36);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(92, 25);
            this.lbName.TabIndex = 61;
            this.lbName.Text = "----------";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(48, 39);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(137, 21);
            this.lbTittle.TabIndex = 60;
            this.lbTittle.Text = "Học sinh vi phạm: ";
            // 
            // txtID
            // 
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CountText = false;
            this.txtID.Enabled = false;
            this.txtID.FieldType = MaterialSurface.BoxType.Normal;
            this.txtID.FloatingLabelText = "FloatingLabel";
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.HandleError = false;
            this.txtID.HelperText = "";
            this.txtID.HideSelection = true;
            this.txtID.HintText = "Mã vi phạm";
            this.txtID.Location = new System.Drawing.Point(49, 88);
            this.txtID.MaxLength = 32767;
            this.txtID.MouseState = MaterialSurface.MouseState.OUT;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Size = new System.Drawing.Size(283, 49);
            this.txtID.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtID.TabIndex = 64;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtYear
            // 
            this.txtYear.AutoScaleColor = true;
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.CountText = false;
            this.txtYear.Enabled = false;
            this.txtYear.FieldType = MaterialSurface.BoxType.Normal;
            this.txtYear.FloatingLabelText = "FloatingLabel";
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtYear.HandleError = false;
            this.txtYear.HelperText = "";
            this.txtYear.HideSelection = true;
            this.txtYear.HintText = "Năm";
            this.txtYear.Location = new System.Drawing.Point(325, 88);
            this.txtYear.MaxLength = 32767;
            this.txtYear.MouseState = MaterialSurface.MouseState.OUT;
            this.txtYear.Multiline = false;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtYear.ReadOnly = false;
            this.txtYear.ShortcutsEnable = true;
            this.txtYear.ShowCaret = true;
            this.txtYear.Size = new System.Drawing.Size(102, 49);
            this.txtYear.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtYear.TabIndex = 65;
            this.txtYear.UseSystemPasswordChar = false;
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.AutoSizing = false;
            this.cbbSemester.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.DropDownWidth = 121;
            this.cbbSemester.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.HintText = "Học kì";
            this.cbbSemester.ItemHeight = 41;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbSemester.Location = new System.Drawing.Point(432, 93);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSemester.Size = new System.Drawing.Size(102, 47);
            this.cbbSemester.TabIndex = 66;
            // 
            // txtFaultContent
            // 
            this.txtFaultContent.AutoScaleColor = true;
            this.txtFaultContent.BackColor = System.Drawing.Color.White;
            this.txtFaultContent.CountText = false;
            this.txtFaultContent.FieldType = MaterialSurface.BoxType.Normal;
            this.txtFaultContent.FloatingLabelText = "FloatingLabel";
            this.txtFaultContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFaultContent.HandleError = false;
            this.txtFaultContent.HelperText = "";
            this.txtFaultContent.HideSelection = true;
            this.txtFaultContent.HintText = "Nội dung vi phạm";
            this.txtFaultContent.Location = new System.Drawing.Point(44, 143);
            this.txtFaultContent.MaxLength = 32767;
            this.txtFaultContent.MouseState = MaterialSurface.MouseState.OUT;
            this.txtFaultContent.Multiline = true;
            this.txtFaultContent.Name = "txtFaultContent";
            this.txtFaultContent.PasswordChar = '\0';
            this.txtFaultContent.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFaultContent.ReadOnly = false;
            this.txtFaultContent.ShortcutsEnable = true;
            this.txtFaultContent.ShowCaret = true;
            this.txtFaultContent.Size = new System.Drawing.Size(510, 112);
            this.txtFaultContent.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtFaultContent.TabIndex = 67;
            this.txtFaultContent.UseSystemPasswordChar = false;
            // 
            // txtPunishmentContent
            // 
            this.txtPunishmentContent.AutoScaleColor = true;
            this.txtPunishmentContent.BackColor = System.Drawing.Color.White;
            this.txtPunishmentContent.CountText = false;
            this.txtPunishmentContent.FieldType = MaterialSurface.BoxType.Normal;
            this.txtPunishmentContent.FloatingLabelText = "FloatingLabel";
            this.txtPunishmentContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPunishmentContent.HandleError = false;
            this.txtPunishmentContent.HelperText = "";
            this.txtPunishmentContent.HideSelection = true;
            this.txtPunishmentContent.HintText = "Hình thức kỉ luật";
            this.txtPunishmentContent.Location = new System.Drawing.Point(44, 261);
            this.txtPunishmentContent.MaxLength = 32767;
            this.txtPunishmentContent.MouseState = MaterialSurface.MouseState.OUT;
            this.txtPunishmentContent.Multiline = true;
            this.txtPunishmentContent.Name = "txtPunishmentContent";
            this.txtPunishmentContent.PasswordChar = '\0';
            this.txtPunishmentContent.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPunishmentContent.ReadOnly = false;
            this.txtPunishmentContent.ShortcutsEnable = true;
            this.txtPunishmentContent.ShowCaret = true;
            this.txtPunishmentContent.Size = new System.Drawing.Size(510, 112);
            this.txtPunishmentContent.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtPunishmentContent.TabIndex = 68;
            this.txtPunishmentContent.UseSystemPasswordChar = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(189, 382);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(222, 50);
            this.btnSubmit.TabIndex = 69;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // OnePunishmentView
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPunishmentContent);
            this.Controls.Add(this.txtFaultContent);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OnePunishmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OnePunishmentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTittle;
        private MaterialSurface.MaterialTextfield txtID;
        private MaterialSurface.MaterialTextfield txtYear;
        private MaterialSurface.MaterialComboBox cbbSemester;
        private MaterialSurface.MaterialTextfield txtFaultContent;
        private MaterialSurface.MaterialTextfield txtPunishmentContent;
        private MaterialSurface.ContainedButton btnSubmit;
    }
}