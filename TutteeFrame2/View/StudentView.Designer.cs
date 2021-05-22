
namespace TutteeFrame2.View
{
    partial class StudentView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.lbTotalStudentTittle = new System.Windows.Forms.Label();
            this.lbFrmSumClass = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new MaterialSurface.ContainedButton();
            this.btnUpdateStudent = new MaterialSurface.ContainedButton();
            this.btnAddStudent = new MaterialSurface.ContainedButton();
            this.btnAddPunis = new MaterialSurface.ContainedButton();
            this.txtSearch = new MaterialSurface.MaterialTextfield();
            this.cbbFilterByGrade = new MaterialSurface.MaterialComboBox();
            this.cbbFilterByClass = new MaterialSurface.MaterialComboBox();
            this.cbbSortBy = new MaterialSurface.MaterialComboBox();
            this.lbSumStudent = new MaterialSkin.Controls.MaterialLabel();
            this.lbSumClass = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
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
            this.listViewStudents.Location = new System.Drawing.Point(18, 130);
            this.listViewStudents.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewStudents.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewStudents.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.OwnerDraw = true;
            this.listViewStudents.Size = new System.Drawing.Size(1124, 345);
            this.listViewStudents.TabIndex = 11;
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
            // lbTotalStudentTittle
            // 
            this.lbTotalStudentTittle.AutoSize = true;
            this.lbTotalStudentTittle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbTotalStudentTittle.Location = new System.Drawing.Point(293, 10);
            this.lbTotalStudentTittle.Name = "lbTotalStudentTittle";
            this.lbTotalStudentTittle.Size = new System.Drawing.Size(159, 28);
            this.lbTotalStudentTittle.TabIndex = 16;
            this.lbTotalStudentTittle.Text = "Tổng số học sinh";
            // 
            // lbFrmSumClass
            // 
            this.lbFrmSumClass.AutoSize = true;
            this.lbFrmSumClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbFrmSumClass.Location = new System.Drawing.Point(61, 10);
            this.lbFrmSumClass.Name = "lbFrmSumClass";
            this.lbFrmSumClass.Size = new System.Drawing.Size(153, 28);
            this.lbFrmSumClass.TabIndex = 15;
            this.lbFrmSumClass.Text = "Tổng số lớp học";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStudent.EffectType = MaterialSurface.ET.Custom;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDeleteStudent.Icon = null;
            this.btnDeleteStudent.Location = new System.Drawing.Point(790, 481);
            this.btnDeleteStudent.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnDeleteStudent.Radius = 2;
            this.btnDeleteStudent.ShawdowDepth = 3;
            this.btnDeleteStudent.ShawdowOpacity = 50;
            this.btnDeleteStudent.Size = new System.Drawing.Size(144, 50);
            this.btnDeleteStudent.TabIndex = 41;
            this.btnDeleteStudent.Text = "Xoá";
            this.btnDeleteStudent.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateStudent.EffectType = MaterialSurface.ET.Custom;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnUpdateStudent.Icon = null;
            this.btnUpdateStudent.Location = new System.Drawing.Point(167, 481);
            this.btnUpdateStudent.MouseState = MaterialSurface.MouseState.OUT;
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnUpdateStudent.Radius = 2;
            this.btnUpdateStudent.ShawdowDepth = 3;
            this.btnUpdateStudent.ShawdowOpacity = 50;
            this.btnUpdateStudent.Size = new System.Drawing.Size(144, 50);
            this.btnUpdateStudent.TabIndex = 40;
            this.btnUpdateStudent.Text = "Cập nhật";
            this.btnUpdateStudent.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddStudent.EffectType = MaterialSurface.ET.Custom;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAddStudent.Icon = null;
            this.btnAddStudent.Location = new System.Drawing.Point(18, 481);
            this.btnAddStudent.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAddStudent.Radius = 2;
            this.btnAddStudent.ShawdowDepth = 3;
            this.btnAddStudent.ShawdowOpacity = 50;
            this.btnAddStudent.Size = new System.Drawing.Size(144, 50);
            this.btnAddStudent.TabIndex = 39;
            this.btnAddStudent.Text = "Thêm";
            this.btnAddStudent.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnAddPunis
            // 
            this.btnAddPunis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPunis.EffectType = MaterialSurface.ET.Custom;
            this.btnAddPunis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPunis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAddPunis.Icon = null;
            this.btnAddPunis.Location = new System.Drawing.Point(329, 481);
            this.btnAddPunis.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAddPunis.Name = "btnAddPunis";
            this.btnAddPunis.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAddPunis.Radius = 2;
            this.btnAddPunis.ShawdowDepth = 3;
            this.btnAddPunis.ShawdowOpacity = 50;
            this.btnAddPunis.Size = new System.Drawing.Size(162, 50);
            this.btnAddPunis.TabIndex = 40;
            this.btnAddPunis.Text = "Thêm vi phạm";
            this.btnAddPunis.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddPunis.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoScaleColor = true;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.CountText = false;
            this.txtSearch.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSearch.FloatingLabelText = "FloatingLabel";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.HandleError = false;
            this.txtSearch.HelperText = "";
            this.txtSearch.HideSelection = true;
            this.txtSearch.HintText = "Tìm kiếm";
            this.txtSearch.Location = new System.Drawing.Point(36, 70);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ShortcutsEnable = true;
            this.txtSearch.ShowCaret = true;
            this.txtSearch.Size = new System.Drawing.Size(348, 54);
            this.txtSearch.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSearch.TabIndex = 42;
            this.txtSearch.UseSystemPasswordChar = false;
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
            this.cbbFilterByGrade.Location = new System.Drawing.Point(443, 73);
            this.cbbFilterByGrade.MaxDropDownItems = 4;
            this.cbbFilterByGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByGrade.Name = "cbbFilterByGrade";
            this.cbbFilterByGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByGrade.Size = new System.Drawing.Size(135, 47);
            this.cbbFilterByGrade.TabIndex = 43;
            this.cbbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.OnFilterGradeTypeChanged);
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
            this.cbbFilterByClass.Location = new System.Drawing.Point(616, 73);
            this.cbbFilterByClass.MaxDropDownItems = 4;
            this.cbbFilterByClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByClass.Name = "cbbFilterByClass";
            this.cbbFilterByClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByClass.Size = new System.Drawing.Size(135, 47);
            this.cbbFilterByClass.TabIndex = 43;
            this.cbbFilterByClass.SelectedIndexChanged += new System.EventHandler(this.OnFilterClassChanged);
            // 
            // cbbSortBy
            // 
            this.cbbSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSortBy.AutoSizing = false;
            this.cbbSortBy.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbSortBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortBy.DropDownWidth = 121;
            this.cbbSortBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSortBy.FormattingEnabled = true;
            this.cbbSortBy.HintText = "Sắp xếp theo";
            this.cbbSortBy.ItemHeight = 41;
            this.cbbSortBy.Items.AddRange(new object[] {
            "ID",
            "Ngày sinh",
            "Họ tên",
            "Giới tính"});
            this.cbbSortBy.Location = new System.Drawing.Point(800, 73);
            this.cbbSortBy.MaxDropDownItems = 4;
            this.cbbSortBy.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSortBy.Size = new System.Drawing.Size(135, 47);
            this.cbbSortBy.TabIndex = 44;
            this.cbbSortBy.SelectedIndexChanged += new System.EventHandler(this.OnSortTypeChaned);
            // 
            // lbSumStudent
            // 
            this.lbSumStudent.AutoSize = true;
            this.lbSumStudent.Depth = 0;
            this.lbSumStudent.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbSumStudent.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbSumStudent.HighEmphasis = true;
            this.lbSumStudent.Location = new System.Drawing.Point(350, 43);
            this.lbSumStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSumStudent.Name = "lbSumStudent";
            this.lbSumStudent.Size = new System.Drawing.Size(15, 24);
            this.lbSumStudent.TabIndex = 45;
            this.lbSumStudent.Text = "--";
            this.lbSumStudent.UseAccent = true;
            // 
            // lbSumClass
            // 
            this.lbSumClass.AutoSize = true;
            this.lbSumClass.Depth = 0;
            this.lbSumClass.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbSumClass.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbSumClass.HighEmphasis = true;
            this.lbSumClass.Location = new System.Drawing.Point(114, 38);
            this.lbSumClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSumClass.Name = "lbSumClass";
            this.lbSumClass.Size = new System.Drawing.Size(15, 24);
            this.lbSumClass.TabIndex = 46;
            this.lbSumClass.Text = "--";
            this.lbSumClass.UseAccent = true;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbSumClass);
            this.Controls.Add(this.lbSumStudent);
            this.Controls.Add(this.cbbSortBy);
            this.Controls.Add(this.cbbFilterByClass);
            this.Controls.Add(this.cbbFilterByGrade);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddPunis);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.lbTotalStudentTittle);
            this.Controls.Add(this.lbFrmSumClass);
            this.Name = "StudentView";
            this.Size = new System.Drawing.Size(1165, 632);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lbTotalStudentTittle;
        private System.Windows.Forms.Label lbFrmSumClass;
        private MaterialSurface.ContainedButton btnDeleteStudent;
        private MaterialSurface.ContainedButton btnUpdateStudent;
        private MaterialSurface.ContainedButton btnAddStudent;
        private MaterialSurface.ContainedButton btnAddPunis;
        private MaterialSurface.MaterialTextfield txtSearch;
        private MaterialSurface.MaterialComboBox cbbFilterByGrade;
        private MaterialSurface.MaterialComboBox cbbFilterByClass;
        private MaterialSurface.MaterialComboBox cbbSortBy;
        private MaterialSkin.Controls.MaterialLabel lbSumStudent;
        private MaterialSkin.Controls.MaterialLabel lbSumClass;
    }
}
