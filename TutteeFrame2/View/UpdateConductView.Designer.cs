
namespace TutteeFrame2.View
{
    partial class UpdateConductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateConductView));
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnSetConduct = new MaterialSurface.ContainedButton();
            this.cbbConductSem1 = new MaterialSurface.MaterialComboBox();
            this.cbbConductSem2 = new MaterialSurface.MaterialComboBox();
            this.cbbYearConduct = new MaterialSurface.MaterialComboBox();
            this.SuspendLayout();
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-3, 244);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(602, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 53;
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
            this.lbInformation.Location = new System.Drawing.Point(3, 228);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(117, 13);
            this.lbInformation.TabIndex = 52;
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
            this.btnClose.Location = new System.Drawing.Point(556, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 58;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbSex.Location = new System.Drawing.Point(37, 59);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(82, 25);
            this.lbSex.TabIndex = 60;
            this.lbSex.Text = "Giới tính:";
            this.lbSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(12, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 28);
            this.lbName.TabIndex = 59;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetConduct
            // 
            this.btnSetConduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetConduct.EffectType = MaterialSurface.ET.Custom;
            this.btnSetConduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetConduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSetConduct.Icon = null;
            this.btnSetConduct.Location = new System.Drawing.Point(206, 187);
            this.btnSetConduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetConduct.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSetConduct.Name = "btnSetConduct";
            this.btnSetConduct.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSetConduct.Radius = 2;
            this.btnSetConduct.ShawdowDepth = 3;
            this.btnSetConduct.ShawdowOpacity = 50;
            this.btnSetConduct.Size = new System.Drawing.Size(194, 50);
            this.btnSetConduct.TabIndex = 61;
            this.btnSetConduct.Text = "Cập nhật hạnh kiểm";
            this.btnSetConduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetConduct.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSetConduct.UseVisualStyleBackColor = true;
            this.btnSetConduct.Click += new System.EventHandler(this.OnUpdateConduct);
            // 
            // cbbConductSem1
            // 
            this.cbbConductSem1.AutoSizing = false;
            this.cbbConductSem1.ComboBoxType = MaterialSurface.BoxType.Filled;
            this.cbbConductSem1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbConductSem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConductSem1.DropDownWidth = 121;
            this.cbbConductSem1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbConductSem1.FormattingEnabled = true;
            this.cbbConductSem1.HintText = "Hạnh kiểm HK1";
            this.cbbConductSem1.ItemHeight = 43;
            this.cbbConductSem1.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu",
            "Chưa xét"});
            this.cbbConductSem1.Location = new System.Drawing.Point(17, 105);
            this.cbbConductSem1.MaxDropDownItems = 4;
            this.cbbConductSem1.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbConductSem1.Name = "cbbConductSem1";
            this.cbbConductSem1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbConductSem1.Size = new System.Drawing.Size(176, 49);
            this.cbbConductSem1.TabIndex = 65;
            // 
            // cbbConductSem2
            // 
            this.cbbConductSem2.AutoSizing = false;
            this.cbbConductSem2.ComboBoxType = MaterialSurface.BoxType.Filled;
            this.cbbConductSem2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbConductSem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConductSem2.DropDownWidth = 121;
            this.cbbConductSem2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbConductSem2.FormattingEnabled = true;
            this.cbbConductSem2.HintText = "Hạnh kiểm HK1";
            this.cbbConductSem2.ItemHeight = 43;
            this.cbbConductSem2.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu",
            "Chưa xét"});
            this.cbbConductSem2.Location = new System.Drawing.Point(199, 105);
            this.cbbConductSem2.MaxDropDownItems = 4;
            this.cbbConductSem2.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbConductSem2.Name = "cbbConductSem2";
            this.cbbConductSem2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbConductSem2.Size = new System.Drawing.Size(176, 49);
            this.cbbConductSem2.TabIndex = 66;
            // 
            // cbbYearConduct
            // 
            this.cbbYearConduct.AutoSizing = false;
            this.cbbYearConduct.ComboBoxType = MaterialSurface.BoxType.Filled;
            this.cbbYearConduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbYearConduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYearConduct.DropDownWidth = 121;
            this.cbbYearConduct.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.cbbYearConduct.FormattingEnabled = true;
            this.cbbYearConduct.HintText = "Hạnh kiểm Cả năm";
            this.cbbYearConduct.ItemHeight = 43;
            this.cbbYearConduct.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu",
            "Chưa xét"});
            this.cbbYearConduct.Location = new System.Drawing.Point(381, 105);
            this.cbbYearConduct.MaxDropDownItems = 4;
            this.cbbYearConduct.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbYearConduct.Name = "cbbYearConduct";
            this.cbbYearConduct.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbYearConduct.Size = new System.Drawing.Size(188, 49);
            this.cbbYearConduct.TabIndex = 67;
            // 
            // UpdateConductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.cbbYearConduct);
            this.Controls.Add(this.cbbConductSem2);
            this.Controls.Add(this.cbbConductSem1);
            this.Controls.Add(this.btnSetConduct);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateConductView";
            this.Text = "UpdateConductView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbName;
        private MaterialSurface.ContainedButton btnSetConduct;
        private MaterialSurface.MaterialComboBox cbbConductSem1;
        private MaterialSurface.MaterialComboBox cbbConductSem2;
        private MaterialSurface.MaterialComboBox cbbYearConduct;
    }
}