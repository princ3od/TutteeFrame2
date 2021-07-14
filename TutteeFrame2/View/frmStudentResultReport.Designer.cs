
namespace TutteeFrame2.View
{
    partial class frmStudentResultReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentResultReport));
            this.listStudentResult = new MaterialSkin.Controls.MaterialListView();
            this.clmStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAveragePoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSemester = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbFilterByClass = new MaterialSurface.MaterialComboBox();
            this.cbbFilterByGrade = new MaterialSurface.MaterialComboBox();
            this.btnPrintStudents = new MaterialSurface.ContainedButton();
            this.lbTittle = new System.Windows.Forms.Label();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.cbbSemester = new MaterialSurface.MaterialComboBox();
            this.cbbType = new MaterialSurface.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listStudentResult
            // 
            this.listStudentResult.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listStudentResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStudentResult.AutoSizeTable = false;
            this.listStudentResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listStudentResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listStudentResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStudentID,
            this.clmStudentSurname,
            this.clmStudentFirstname,
            this.clmStudentClassID,
            this.clmAveragePoint,
            this.clmSemester});
            this.listStudentResult.Depth = 0;
            this.listStudentResult.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.listStudentResult.FullRowSelect = true;
            this.listStudentResult.HideSelection = false;
            this.listStudentResult.HoverSelection = true;
            this.listStudentResult.Location = new System.Drawing.Point(48, 155);
            this.listStudentResult.Margin = new System.Windows.Forms.Padding(2);
            this.listStudentResult.MinimumSize = new System.Drawing.Size(150, 81);
            this.listStudentResult.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listStudentResult.MouseState = MaterialSkin.MouseState.OUT;
            this.listStudentResult.Name = "listStudentResult";
            this.listStudentResult.OwnerDraw = true;
            this.listStudentResult.Size = new System.Drawing.Size(1106, 400);
            this.listStudentResult.TabIndex = 78;
            this.listStudentResult.UseCompatibleStateImageBehavior = false;
            this.listStudentResult.View = System.Windows.Forms.View.Details;
            // 
            // clmStudentID
            // 
            this.clmStudentID.Text = "Mã học sinh";
            this.clmStudentID.Width = 120;
            // 
            // clmStudentSurname
            // 
            this.clmStudentSurname.Text = "Họ";
            this.clmStudentSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentSurname.Width = 120;
            // 
            // clmStudentFirstname
            // 
            this.clmStudentFirstname.Text = "Tên";
            this.clmStudentFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentFirstname.Width = 120;
            // 
            // clmStudentClassID
            // 
            this.clmStudentClassID.Text = "Tên lớp";
            this.clmStudentClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentClassID.Width = 120;
            // 
            // clmAveragePoint
            // 
            this.clmAveragePoint.Text = "Điểm trung bình";
            this.clmAveragePoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmAveragePoint.Width = 150;
            // 
            // clmSemester
            // 
            this.clmSemester.Text = "Học kì";
            this.clmSemester.Width = 120;
            // 
            // cbbFilterByClass
            // 
            this.cbbFilterByClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFilterByClass.AutoSizing = false;
            this.cbbFilterByClass.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbFilterByClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbFilterByClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterByClass.DropDownWidth = 121;
            this.cbbFilterByClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbFilterByClass.FormattingEnabled = true;
            this.cbbFilterByClass.HintText = "Lớp";
            this.cbbFilterByClass.ItemHeight = 41;
            this.cbbFilterByClass.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbbFilterByClass.Location = new System.Drawing.Point(797, 72);
            this.cbbFilterByClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByClass.MaxDropDownItems = 4;
            this.cbbFilterByClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByClass.Name = "cbbFilterByClass";
            this.cbbFilterByClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByClass.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByClass.TabIndex = 76;
            this.cbbFilterByClass.SelectedIndexChanged += new System.EventHandler(this.cbbFilterByClass_SelectedIndexChanged);
            // 
            // cbbFilterByGrade
            // 
            this.cbbFilterByGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFilterByGrade.AutoSizing = false;
            this.cbbFilterByGrade.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbFilterByGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbFilterByGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterByGrade.DropDownWidth = 121;
            this.cbbFilterByGrade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbFilterByGrade.FormattingEnabled = true;
            this.cbbFilterByGrade.HintText = "Khối";
            this.cbbFilterByGrade.ItemHeight = 41;
            this.cbbFilterByGrade.Items.AddRange(new object[] {
            "Tất cả",
            "10",
            "11",
            "12"});
            this.cbbFilterByGrade.Location = new System.Drawing.Point(575, 72);
            this.cbbFilterByGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByGrade.MaxDropDownItems = 4;
            this.cbbFilterByGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByGrade.Name = "cbbFilterByGrade";
            this.cbbFilterByGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByGrade.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByGrade.TabIndex = 77;
            this.cbbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.cbbFilterByGrade_SelectedIndexChanged);
            // 
            // btnPrintStudents
            // 
            this.btnPrintStudents.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintStudents.EffectType = MaterialSurface.ET.Custom;
            this.btnPrintStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnPrintStudents.Icon = null;
            this.btnPrintStudents.Location = new System.Drawing.Point(439, 593);
            this.btnPrintStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintStudents.MouseState = MaterialSurface.MouseState.OUT;
            this.btnPrintStudents.Name = "btnPrintStudents";
            this.btnPrintStudents.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnPrintStudents.Radius = 2;
            this.btnPrintStudents.ShawdowDepth = 3;
            this.btnPrintStudents.ShawdowOpacity = 50;
            this.btnPrintStudents.Size = new System.Drawing.Size(346, 69);
            this.btnPrintStudents.TabIndex = 75;
            this.btnPrintStudents.Text = "In Biểu Mẫu";
            this.btnPrintStudents.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPrintStudents.UseVisualStyleBackColor = true;
            this.btnPrintStudents.Click += new System.EventHandler(this.btnPrintStudents_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbTittle.Location = new System.Drawing.Point(93, 15);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(252, 35);
            this.lbTittle.TabIndex = 74;
            this.lbTittle.Text = "TutteeFrame - Báo cáo";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Depth = 0;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = ((System.Drawing.Image)(resources.GetObject("btnExit.Icon")));
            this.btnExit.Location = new System.Drawing.Point(1160, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 73;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
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
            "Kì 1",
            "Kì 2"});
            this.cbbSemester.Location = new System.Drawing.Point(983, 72);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSemester.Size = new System.Drawing.Size(102, 47);
            this.cbbSemester.TabIndex = 79;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.cbbSemester_SelectedIndexChanged);
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbType.AutoSizing = false;
            this.cbbType.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.DropDownWidth = 121;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbType.FormattingEnabled = true;
            this.cbbType.HintText = "Loại bảng điểm";
            this.cbbType.ItemHeight = 41;
            this.cbbType.Items.AddRange(new object[] {
            "Danh sách",
            "Cá nhân"});
            this.cbbType.Location = new System.Drawing.Point(110, 72);
            this.cbbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbType.MaxDropDownItems = 4;
            this.cbbType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbType.Name = "cbbType";
            this.cbbType.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbType.Size = new System.Drawing.Size(186, 47);
            this.cbbType.TabIndex = 80;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(399, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "____________________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // frmStudentResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.listStudentResult);
            this.Controls.Add(this.cbbFilterByClass);
            this.Controls.Add(this.cbbFilterByGrade);
            this.Controls.Add(this.btnPrintStudents);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentResultReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentResultReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStudentResultReport_FormClosed);
            this.Shown += new System.EventHandler(this.frmStudentResultReport_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmStudentResultReport_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listStudentResult;
        private System.Windows.Forms.ColumnHeader clmStudentID;
        private System.Windows.Forms.ColumnHeader clmStudentSurname;
        private System.Windows.Forms.ColumnHeader clmStudentFirstname;
        private System.Windows.Forms.ColumnHeader clmStudentClassID;
        private System.Windows.Forms.ColumnHeader clmAveragePoint;
        private MaterialSurface.MaterialComboBox cbbFilterByClass;
        private MaterialSurface.MaterialComboBox cbbFilterByGrade;
        private MaterialSurface.ContainedButton btnPrintStudents;
        private System.Windows.Forms.Label lbTittle;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.ColumnHeader clmSemester;
        private MaterialSurface.MaterialComboBox cbbSemester;
        private MaterialSurface.MaterialComboBox cbbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}