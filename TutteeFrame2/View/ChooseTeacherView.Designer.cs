
namespace TutteeFrame2.View
{
    partial class ChooseTeacherView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTeacherView));
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtCurrentTeacher = new MaterialSurface.MaterialTextfield();
            this.txtTeacherSearch = new MaterialSurface.MaterialTextfield();
            this.listviewTeacher = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.btnDelete = new MaterialSurface.TextButton();
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
            this.btnClose.Location = new System.Drawing.Point(454, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 51;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(12, 9);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(5);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(158, 28);
            this.lbTittle.TabIndex = 55;
            this.lbTittle.Text = "Chọn giáo viên --";
            // 
            // txtCurrentTeacher
            // 
            this.txtCurrentTeacher.AutoScaleColor = true;
            this.txtCurrentTeacher.BackColor = System.Drawing.Color.White;
            this.txtCurrentTeacher.CountText = false;
            this.txtCurrentTeacher.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCurrentTeacher.FieldType = MaterialSurface.BoxType.Outlined;
            this.txtCurrentTeacher.FloatingLabelText = "Giáo viên chủ nhiệm";
            this.txtCurrentTeacher.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCurrentTeacher.HandleError = false;
            this.txtCurrentTeacher.HelperText = "";
            this.txtCurrentTeacher.HideSelection = false;
            this.txtCurrentTeacher.HintText = "Giáo viên đang được chọn";
            this.txtCurrentTeacher.Location = new System.Drawing.Point(17, 44);
            this.txtCurrentTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentTeacher.MaxLength = 32767;
            this.txtCurrentTeacher.MouseState = MaterialSurface.MouseState.OUT;
            this.txtCurrentTeacher.Multiline = false;
            this.txtCurrentTeacher.Name = "txtCurrentTeacher";
            this.txtCurrentTeacher.PasswordChar = '\0';
            this.txtCurrentTeacher.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtCurrentTeacher.ReadOnly = true;
            this.txtCurrentTeacher.ShortcutsEnable = true;
            this.txtCurrentTeacher.ShowCaret = false;
            this.txtCurrentTeacher.Size = new System.Drawing.Size(328, 49);
            this.txtCurrentTeacher.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtCurrentTeacher.TabIndex = 56;
            this.txtCurrentTeacher.UseSystemPasswordChar = false;
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.AutoScaleColor = false;
            this.txtTeacherSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTeacherSearch.CountText = false;
            this.txtTeacherSearch.Enabled = false;
            this.txtTeacherSearch.FieldType = MaterialSurface.BoxType.Filled;
            this.txtTeacherSearch.FloatingLabelText = "Giáo viên chủ nhiệm";
            this.txtTeacherSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTeacherSearch.HandleError = false;
            this.txtTeacherSearch.HelperText = "";
            this.txtTeacherSearch.HideSelection = false;
            this.txtTeacherSearch.HintText = "Tìm kiếm (theo ID hoặc tên)";
            this.txtTeacherSearch.Location = new System.Drawing.Point(17, 107);
            this.txtTeacherSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeacherSearch.MaxLength = 32767;
            this.txtTeacherSearch.MouseState = MaterialSurface.MouseState.OUT;
            this.txtTeacherSearch.Multiline = false;
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.PasswordChar = '\0';
            this.txtTeacherSearch.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtTeacherSearch.ReadOnly = true;
            this.txtTeacherSearch.ShortcutsEnable = true;
            this.txtTeacherSearch.ShowCaret = true;
            this.txtTeacherSearch.Size = new System.Drawing.Size(472, 49);
            this.txtTeacherSearch.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtTeacherSearch.TabIndex = 57;
            this.txtTeacherSearch.UseSystemPasswordChar = false;
            // 
            // listviewTeacher
            // 
            this.listviewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewTeacher.AutoSizeTable = false;
            this.listviewTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listviewTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listviewTeacher.Depth = 0;
            this.listviewTeacher.Enabled = false;
            this.listviewTeacher.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.listviewTeacher.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listviewTeacher.FullRowSelect = true;
            this.listviewTeacher.HideSelection = false;
            this.listviewTeacher.Location = new System.Drawing.Point(12, 161);
            this.listviewTeacher.MinimumSize = new System.Drawing.Size(200, 100);
            this.listviewTeacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listviewTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.listviewTeacher.MultiSelect = false;
            this.listviewTeacher.Name = "listviewTeacher";
            this.listviewTeacher.OwnerDraw = true;
            this.listviewTeacher.Size = new System.Drawing.Size(476, 221);
            this.listviewTeacher.TabIndex = 58;
            this.listviewTeacher.UseCompatibleStateImageBehavior = false;
            this.listviewTeacher.View = System.Windows.Forms.View.Details;
            this.listviewTeacher.SelectedIndexChanged += new System.EventHandler(this.OnSelected);
            this.listviewTeacher.DoubleClick += new System.EventHandler(this.OnSubmit);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã giáo viên";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ tên giáo viên";
            this.columnHeader3.Width = 270;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(147, 388);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(198, 50);
            this.btnSubmit.TabIndex = 59;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // btnDelete
            // 
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(350, 53);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.Red;
            this.btnDelete.Radius = 8;
            this.btnDelete.Size = new System.Drawing.Size(127, 40);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteTeacher);
            // 
            // ChooseTeacherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.listviewTeacher);
            this.Controls.Add(this.txtTeacherSearch);
            this.Controls.Add(this.txtCurrentTeacher);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTeacherView";
            this.Text = "ChooseTeacherView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.Label lbTittle;
        private MaterialSurface.MaterialTextfield txtCurrentTeacher;
        private MaterialSurface.MaterialTextfield txtTeacherSearch;
        private MaterialSkin.Controls.MaterialListView listviewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.TextButton btnDelete;
    }
}