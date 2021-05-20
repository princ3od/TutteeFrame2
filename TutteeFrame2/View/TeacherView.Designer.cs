
namespace TutteeFrame2.View
{
    partial class TeacherView
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
            this.lbTotalAdmin = new MaterialSkin.Controls.MaterialLabel();
            this.lbTotalMinistry = new MaterialSkin.Controls.MaterialLabel();
            this.lbTotalTeacher = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new MaterialSurface.MaterialTextfield();
            this.cbbSortBy = new MaterialSurface.MaterialComboBox();
            this.cbbSubject = new MaterialSurface.MaterialComboBox();
            this.cbbRole = new MaterialSurface.MaterialComboBox();
            this.listviewTeacher = new MaterialSkin.Controls.MaterialListView();
            this.clmTeacherSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTeacherType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new MaterialSurface.ContainedButton();
            this.btnUpdate = new MaterialSurface.ContainedButton();
            this.btnDelete = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // lbTotalAdmin
            // 
            this.lbTotalAdmin.AutoSize = true;
            this.lbTotalAdmin.Depth = 0;
            this.lbTotalAdmin.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalAdmin.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTotalAdmin.HighEmphasis = true;
            this.lbTotalAdmin.Location = new System.Drawing.Point(501, 21);
            this.lbTotalAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotalAdmin.Name = "lbTotalAdmin";
            this.lbTotalAdmin.Size = new System.Drawing.Size(15, 24);
            this.lbTotalAdmin.TabIndex = 11;
            this.lbTotalAdmin.Text = "--";
            this.lbTotalAdmin.UseAccent = true;
            // 
            // lbTotalMinistry
            // 
            this.lbTotalMinistry.AutoSize = true;
            this.lbTotalMinistry.Depth = 0;
            this.lbTotalMinistry.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalMinistry.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTotalMinistry.HighEmphasis = true;
            this.lbTotalMinistry.Location = new System.Drawing.Point(256, 21);
            this.lbTotalMinistry.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotalMinistry.Name = "lbTotalMinistry";
            this.lbTotalMinistry.Size = new System.Drawing.Size(15, 24);
            this.lbTotalMinistry.TabIndex = 10;
            this.lbTotalMinistry.Text = "--";
            this.lbTotalMinistry.UseAccent = true;
            // 
            // lbTotalTeacher
            // 
            this.lbTotalTeacher.AutoSize = true;
            this.lbTotalTeacher.Depth = 0;
            this.lbTotalTeacher.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalTeacher.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTotalTeacher.HighEmphasis = true;
            this.lbTotalTeacher.Location = new System.Drawing.Point(11, 21);
            this.lbTotalTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotalTeacher.Name = "lbTotalTeacher";
            this.lbTotalTeacher.Size = new System.Drawing.Size(15, 24);
            this.lbTotalTeacher.TabIndex = 9;
            this.lbTotalTeacher.Text = "--";
            this.lbTotalTeacher.UseAccent = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(489, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng số giáo viên thuộc BGH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(246, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng số giáo vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng số giáo viên";
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
            this.txtSearch.Location = new System.Drawing.Point(15, 48);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ShortcutsEnable = true;
            this.txtSearch.ShowCaret = true;
            this.txtSearch.Size = new System.Drawing.Size(416, 49);
            this.txtSearch.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnSearching);
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
            "Mã giáo viên",
            "Họ tên",
            "Ngày sinh"});
            this.cbbSortBy.Location = new System.Drawing.Point(740, 52);
            this.cbbSortBy.MaxDropDownItems = 4;
            this.cbbSortBy.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSortBy.Name = "cbbSortBy";
            this.cbbSortBy.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSortBy.Size = new System.Drawing.Size(135, 47);
            this.cbbSortBy.TabIndex = 13;
            this.cbbSortBy.SelectedIndexChanged += new System.EventHandler(this.OnSortTypeChanged);
            // 
            // cbbSubject
            // 
            this.cbbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSubject.AutoSizing = false;
            this.cbbSubject.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.DropDownWidth = 121;
            this.cbbSubject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.HintText = "Môn giảng dạy";
            this.cbbSubject.ItemHeight = 41;
            this.cbbSubject.Location = new System.Drawing.Point(881, 52);
            this.cbbSubject.MaxDropDownItems = 4;
            this.cbbSubject.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSubject.Size = new System.Drawing.Size(141, 47);
            this.cbbSubject.TabIndex = 14;
            this.cbbSubject.SelectedIndexChanged += new System.EventHandler(this.OnSubjectFilterChanged);
            // 
            // cbbRole
            // 
            this.cbbRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbRole.AutoSizing = true;
            this.cbbRole.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.DropDownWidth = 121;
            this.cbbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.HintText = "Thuộc";
            this.cbbRole.ItemHeight = 41;
            this.cbbRole.Items.AddRange(new object[] {
            "Tất cả",
            "Giáo viên",
            "GVCN",
            "Giáo vụ",
            "BGH"});
            this.cbbRole.Location = new System.Drawing.Point(1028, 52);
            this.cbbRole.MaxDropDownItems = 4;
            this.cbbRole.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbRole.Size = new System.Drawing.Size(106, 47);
            this.cbbRole.TabIndex = 15;
            this.cbbRole.SelectedIndexChanged += new System.EventHandler(this.OnRoleFilterChanged);
            // 
            // listviewTeacher
            // 
            this.listviewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewTeacher.AutoSizeTable = false;
            this.listviewTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listviewTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTeacherSTT,
            this.clmTeacherID,
            this.clmTeacherName,
            this.clmTeacherBirth,
            this.clmTeacherSex,
            this.clmTeacherAddress,
            this.clmTeacherPhone,
            this.clmTeacherMail,
            this.clmTeacherSubject,
            this.clmTeacherType});
            this.listviewTeacher.Depth = 0;
            this.listviewTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.listviewTeacher.FullRowSelect = true;
            this.listviewTeacher.HideSelection = false;
            this.listviewTeacher.Location = new System.Drawing.Point(15, 105);
            this.listviewTeacher.MinimumSize = new System.Drawing.Size(200, 100);
            this.listviewTeacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listviewTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.listviewTeacher.Name = "listviewTeacher";
            this.listviewTeacher.OwnerDraw = true;
            this.listviewTeacher.Size = new System.Drawing.Size(1135, 382);
            this.listviewTeacher.TabIndex = 16;
            this.listviewTeacher.UseCompatibleStateImageBehavior = false;
            this.listviewTeacher.View = System.Windows.Forms.View.Details;
            this.listviewTeacher.SelectedIndexChanged += new System.EventHandler(this.OnChooseTeacher);
            this.listviewTeacher.DoubleClick += new System.EventHandler(this.OnUpdateTeacher);
            // 
            // clmTeacherSTT
            // 
            this.clmTeacherSTT.Text = "STT";
            this.clmTeacherSTT.Width = 58;
            // 
            // clmTeacherID
            // 
            this.clmTeacherID.Text = "Mã số gv";
            this.clmTeacherID.Width = 110;
            // 
            // clmTeacherName
            // 
            this.clmTeacherName.Text = "Họ tên";
            this.clmTeacherName.Width = 170;
            // 
            // clmTeacherBirth
            // 
            this.clmTeacherBirth.Text = "Ngày sinh";
            this.clmTeacherBirth.Width = 110;
            // 
            // clmTeacherSex
            // 
            this.clmTeacherSex.Text = "Giới tính";
            this.clmTeacherSex.Width = 90;
            // 
            // clmTeacherAddress
            // 
            this.clmTeacherAddress.Text = "Địa chỉ";
            this.clmTeacherAddress.Width = 160;
            // 
            // clmTeacherPhone
            // 
            this.clmTeacherPhone.Text = "SĐT";
            this.clmTeacherPhone.Width = 85;
            // 
            // clmTeacherMail
            // 
            this.clmTeacherMail.Text = "Mail";
            this.clmTeacherMail.Width = 112;
            // 
            // clmTeacherSubject
            // 
            this.clmTeacherSubject.Text = "Môn dạy";
            this.clmTeacherSubject.Width = 100;
            // 
            // clmTeacherType
            // 
            this.clmTeacherType.Text = "Thuộc";
            this.clmTeacherType.Width = 122;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.EffectType = MaterialSurface.ET.Custom;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(71, 493);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAdd.Radius = 2;
            this.btnAdd.ShawdowDepth = 3;
            this.btnAdd.ShawdowOpacity = 50;
            this.btnAdd.Size = new System.Drawing.Size(144, 50);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAddTeacher);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.EffectType = MaterialSurface.ET.Custom;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(220, 493);
            this.btnUpdate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnUpdate.Radius = 2;
            this.btnUpdate.ShawdowDepth = 3;
            this.btnUpdate.ShawdowOpacity = 50;
            this.btnUpdate.Size = new System.Drawing.Size(144, 50);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.OnUpdateTeacher);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(838, 493);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnDelete.Radius = 2;
            this.btnDelete.ShawdowDepth = 3;
            this.btnDelete.ShawdowOpacity = 50;
            this.btnDelete.Size = new System.Drawing.Size(144, 50);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteTeacher);
            // 
            // TeacherView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listviewTeacher);
            this.Controls.Add(this.cbbRole);
            this.Controls.Add(this.cbbSubject);
            this.Controls.Add(this.cbbSortBy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbTotalAdmin);
            this.Controls.Add(this.lbTotalMinistry);
            this.Controls.Add(this.lbTotalTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherView";
            this.Size = new System.Drawing.Size(1150, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbTotalAdmin;
        private MaterialSkin.Controls.MaterialLabel lbTotalMinistry;
        private MaterialSkin.Controls.MaterialLabel lbTotalTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSurface.MaterialTextfield txtSearch;
        private MaterialSurface.MaterialComboBox cbbSortBy;
        private MaterialSurface.MaterialComboBox cbbSubject;
        private MaterialSurface.MaterialComboBox cbbRole;
        private MaterialSkin.Controls.MaterialListView listviewTeacher;
        private System.Windows.Forms.ColumnHeader clmTeacherSTT;
        private System.Windows.Forms.ColumnHeader clmTeacherID;
        private System.Windows.Forms.ColumnHeader clmTeacherName;
        private System.Windows.Forms.ColumnHeader clmTeacherBirth;
        private System.Windows.Forms.ColumnHeader clmTeacherSex;
        private System.Windows.Forms.ColumnHeader clmTeacherAddress;
        private System.Windows.Forms.ColumnHeader clmTeacherPhone;
        private System.Windows.Forms.ColumnHeader clmTeacherMail;
        private System.Windows.Forms.ColumnHeader clmTeacherSubject;
        private System.Windows.Forms.ColumnHeader clmTeacherType;
        private MaterialSurface.ContainedButton btnAdd;
        private MaterialSurface.ContainedButton btnUpdate;
        private MaterialSurface.ContainedButton btnDelete;
    }
}
