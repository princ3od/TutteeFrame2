
namespace TutteeFrame2.View
{
    partial class PunishmentView
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
            this.listViewPunishment = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new MaterialSurface.ContainedButton();
            this.btnDelete = new MaterialSurface.ContainedButton();
            this.cbbFilterByClass = new MaterialSurface.MaterialComboBox();
            this.cbbFilterByGrade = new MaterialSurface.MaterialComboBox();
            this.txtSearch = new MaterialSurface.MaterialTextfield();
            this.SuspendLayout();
            // 
            // listViewPunishment
            // 
            this.listViewPunishment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPunishment.AutoSizeTable = false;
            this.listViewPunishment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewPunishment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPunishment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader25,
            this.columnHeader24,
            this.columnHeader26});
            this.listViewPunishment.Depth = 0;
            this.listViewPunishment.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.listViewPunishment.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewPunishment.FullRowSelect = true;
            this.listViewPunishment.HideSelection = false;
            this.listViewPunishment.Location = new System.Drawing.Point(-8, 100);
            this.listViewPunishment.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewPunishment.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewPunishment.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewPunishment.Name = "listViewPunishment";
            this.listViewPunishment.OwnerDraw = true;
            this.listViewPunishment.Size = new System.Drawing.Size(1108, 391);
            this.listViewPunishment.TabIndex = 18;
            this.listViewPunishment.UseCompatibleStateImageBehavior = false;
            this.listViewPunishment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "STT";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Mã vi phạm";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader19.Width = 110;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Mã học sinh";
            this.columnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader21.Width = 110;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Họ tên";
            this.columnHeader22.Width = 180;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Học kì (năm)";
            this.columnHeader23.Width = 115;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Lớp";
            this.columnHeader25.Width = 68;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Lỗi vi phạm";
            this.columnHeader24.Width = 270;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Hình thức kỉ luật";
            this.columnHeader26.Width = 195;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.EffectType = MaterialSurface.ET.Custom;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(83, 497);
            this.btnUpdate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnUpdate.Radius = 2;
            this.btnUpdate.ShawdowDepth = 3;
            this.btnUpdate.ShawdowOpacity = 50;
            this.btnUpdate.Size = new System.Drawing.Size(219, 50);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Cập nhật/Thêm kỉ luật";
            this.btnUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(856, 497);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnDelete.Radius = 2;
            this.btnDelete.ShawdowDepth = 3;
            this.btnDelete.ShawdowOpacity = 50;
            this.btnDelete.Size = new System.Drawing.Size(144, 50);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.cbbFilterByClass.Location = new System.Drawing.Point(929, 33);
            this.cbbFilterByClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByClass.MaxDropDownItems = 4;
            this.cbbFilterByClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByClass.Name = "cbbFilterByClass";
            this.cbbFilterByClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByClass.Size = new System.Drawing.Size(115, 47);
            this.cbbFilterByClass.TabIndex = 46;
            this.cbbFilterByClass.SelectedIndexChanged += new System.EventHandler(this.OnChangeClass);
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
            this.cbbFilterByGrade.Location = new System.Drawing.Point(823, 33);
            this.cbbFilterByGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByGrade.MaxDropDownItems = 4;
            this.cbbFilterByGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByGrade.Name = "cbbFilterByGrade";
            this.cbbFilterByGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByGrade.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByGrade.TabIndex = 45;
            this.cbbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.OnChangeGrade);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoScaleColor = true;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.CountText = false;
            this.txtSearch.FieldType = MaterialSurface.BoxType.Normal;
            this.txtSearch.FloatingLabelText = "FloatingLabel";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.HandleError = true;
            this.txtSearch.HelperText = "Tìm theo mã học sinh hoặc họ tên học sinh";
            this.txtSearch.HideSelection = true;
            this.txtSearch.HintText = "Tìm kiếm";
            this.txtSearch.Location = new System.Drawing.Point(21, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSurface.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ShortcutsEnable = true;
            this.txtSearch.ShowCaret = true;
            this.txtSearch.Size = new System.Drawing.Size(375, 67);
            this.txtSearch.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtSearch.TabIndex = 44;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnSearch);
            // 
            // PunishmentView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbbFilterByClass);
            this.Controls.Add(this.cbbFilterByGrade);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listViewPunishment);
            this.Name = "PunishmentView";
            this.Size = new System.Drawing.Size(1100, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listViewPunishment;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private MaterialSurface.ContainedButton btnUpdate;
        private MaterialSurface.ContainedButton btnDelete;
        private MaterialSurface.MaterialComboBox cbbFilterByClass;
        private MaterialSurface.MaterialComboBox cbbFilterByGrade;
        private MaterialSurface.MaterialTextfield txtSearch;
    }
}
