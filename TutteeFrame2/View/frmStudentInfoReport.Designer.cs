
namespace TutteeFrame2.View
{
    partial class frmStudentInfoReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentInfoReport));
            this.lbTittle = new System.Windows.Forms.Label();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintStudents = new MaterialSurface.ContainedButton();
            this.cbbFilterByClass = new MaterialSurface.MaterialComboBox();
            this.cbbFilterByGrade = new MaterialSurface.MaterialComboBox();
            this.listViewStudents = new MaterialSkin.Controls.MaterialListView();
            this.clmStudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentBornDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentClassID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStudentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbTittle.Location = new System.Drawing.Point(93, 11);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(252, 35);
            this.lbTittle.TabIndex = 66;
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
            this.btnExit.Location = new System.Drawing.Point(1157, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 65;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintStudents
            // 
            this.btnPrintStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintStudents.EffectType = MaterialSurface.ET.Custom;
            this.btnPrintStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnPrintStudents.Icon = null;
            this.btnPrintStudents.Location = new System.Drawing.Point(404, 588);
            this.btnPrintStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintStudents.MouseState = MaterialSurface.MouseState.OUT;
            this.btnPrintStudents.Name = "btnPrintStudents";
            this.btnPrintStudents.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnPrintStudents.Radius = 2;
            this.btnPrintStudents.ShawdowDepth = 3;
            this.btnPrintStudents.ShawdowOpacity = 50;
            this.btnPrintStudents.Size = new System.Drawing.Size(346, 69);
            this.btnPrintStudents.TabIndex = 67;
            this.btnPrintStudents.Text = "In Danh Sách";
            this.btnPrintStudents.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPrintStudents.UseVisualStyleBackColor = true;
            this.btnPrintStudents.Click += new System.EventHandler(this.btnPrintStudents_Click);
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
            this.cbbFilterByClass.Location = new System.Drawing.Point(825, 61);
            this.cbbFilterByClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByClass.MaxDropDownItems = 4;
            this.cbbFilterByClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByClass.Name = "cbbFilterByClass";
            this.cbbFilterByClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByClass.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByClass.TabIndex = 68;
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
            this.cbbFilterByGrade.Location = new System.Drawing.Point(603, 61);
            this.cbbFilterByGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByGrade.MaxDropDownItems = 4;
            this.cbbFilterByGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByGrade.Name = "cbbFilterByGrade";
            this.cbbFilterByGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByGrade.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByGrade.TabIndex = 69;
            this.cbbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.cbbFilterByGrade_SelectedIndexChanged);
            // 
            // listViewStudents
            // 
            this.listViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStudents.AutoSizeTable = false;
            this.listViewStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStudentID,
            this.clmStudentSurname,
            this.clmStudentFirstname,
            this.clmStudentBornDate,
            this.clmStudentSex,
            this.clmStudentAddress,
            this.clmStudentPhone,
            this.clmStudentClassID,
            this.clmStudentStatus});
            this.listViewStudents.Depth = 0;
            this.listViewStudents.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.listViewStudents.FullRowSelect = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(11, 112);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStudents.MinimumSize = new System.Drawing.Size(150, 81);
            this.listViewStudents.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewStudents.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.OwnerDraw = true;
            this.listViewStudents.Size = new System.Drawing.Size(1183, 472);
            this.listViewStudents.TabIndex = 72;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
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
            // clmStudentBornDate
            // 
            this.clmStudentBornDate.Text = "Ngày Sinh";
            this.clmStudentBornDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentBornDate.Width = 120;
            // 
            // clmStudentSex
            // 
            this.clmStudentSex.Text = "Giới tính";
            this.clmStudentSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentSex.Width = 120;
            // 
            // clmStudentAddress
            // 
            this.clmStudentAddress.Text = "Địa chỉ";
            this.clmStudentAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentAddress.Width = 120;
            // 
            // clmStudentPhone
            // 
            this.clmStudentPhone.Text = "Số điện thoại";
            this.clmStudentPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentPhone.Width = 120;
            // 
            // clmStudentClassID
            // 
            this.clmStudentClassID.Text = "Tên lớp";
            this.clmStudentClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentClassID.Width = 120;
            // 
            // clmStudentStatus
            // 
            this.clmStudentStatus.Text = "Tình trạng";
            this.clmStudentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmStudentStatus.Width = 120;
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 668);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.cbbFilterByClass);
            this.Controls.Add(this.cbbFilterByGrade);
            this.Controls.Add(this.btnPrintStudents);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentReport";
            this.Text = "frmStudentReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStudentReport_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTittle;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSurface.ContainedButton btnPrintStudents;
        private MaterialSurface.MaterialComboBox cbbFilterByClass;
        private MaterialSurface.MaterialComboBox cbbFilterByGrade;
        private MaterialSkin.Controls.MaterialListView listViewStudents;
        private System.Windows.Forms.ColumnHeader clmStudentID;
        private System.Windows.Forms.ColumnHeader clmStudentSurname;
        private System.Windows.Forms.ColumnHeader clmStudentFirstname;
        private System.Windows.Forms.ColumnHeader clmStudentBornDate;
        private System.Windows.Forms.ColumnHeader clmStudentSex;
        private System.Windows.Forms.ColumnHeader clmStudentAddress;
        private System.Windows.Forms.ColumnHeader clmStudentPhone;
        private System.Windows.Forms.ColumnHeader clmStudentClassID;
        private System.Windows.Forms.ColumnHeader clmStudentStatus;
    }
}