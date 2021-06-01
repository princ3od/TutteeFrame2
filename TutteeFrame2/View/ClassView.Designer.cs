
namespace TutteeFrame2.View
{
    partial class ClassView
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
            this.cbbFilterByGrade = new MaterialSurface.MaterialComboBox();
            this.listViewClass = new MaterialSkin.Controls.MaterialListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRumNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStudenNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeacherId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new MaterialSurface.ContainedButton();
            this.btnUpdate = new MaterialSurface.ContainedButton();
            this.btnAdd = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // cbbFilterByGrade
            // 
            this.cbbFilterByGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFilterByGrade.AutoSizing = false;
            this.cbbFilterByGrade.ComboBoxType = MaterialSurface.BoxType.Filled;
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
            this.cbbFilterByGrade.Location = new System.Drawing.Point(65, 13);
            this.cbbFilterByGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByGrade.MaxDropDownItems = 4;
            this.cbbFilterByGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByGrade.Name = "cbbFilterByGrade";
            this.cbbFilterByGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByGrade.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByGrade.TabIndex = 44;
            this.cbbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.OnChangeGrade);
            // 
            // listViewClass
            // 
            this.listViewClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClass.AutoSizeTable = false;
            this.listViewClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colClassId,
            this.colRumNum,
            this.colStudenNum,
            this.colTeacherId});
            this.listViewClass.Depth = 0;
            this.listViewClass.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.listViewClass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewClass.FullRowSelect = true;
            this.listViewClass.HideSelection = false;
            this.listViewClass.Location = new System.Drawing.Point(31, 65);
            this.listViewClass.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewClass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewClass.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewClass.Name = "listViewClass";
            this.listViewClass.OwnerDraw = true;
            this.listViewClass.Size = new System.Drawing.Size(1039, 421);
            this.listViewClass.TabIndex = 45;
            this.listViewClass.UseCompatibleStateImageBehavior = false;
            this.listViewClass.View = System.Windows.Forms.View.Details;
            this.listViewClass.SelectedIndexChanged += new System.EventHandler(this.OnChooseClass);
            // 
            // colSTT
            // 
            this.colSTT.Text = "Số thứ tự";
            this.colSTT.Width = 180;
            // 
            // colClassId
            // 
            this.colClassId.Text = "Mã lớp";
            this.colClassId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colClassId.Width = 180;
            // 
            // colRumNum
            // 
            this.colRumNum.Text = "Phòng";
            this.colRumNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRumNum.Width = 180;
            // 
            // colStudenNum
            // 
            this.colStudenNum.Text = "Tổng số học sinh";
            this.colStudenNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStudenNum.Width = 180;
            // 
            // colTeacherId
            // 
            this.colTeacherId.Text = "Mã GVCN";
            this.colTeacherId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTeacherId.Width = 180;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(848, 492);
            this.btnDelete.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnDelete.Radius = 2;
            this.btnDelete.ShawdowDepth = 3;
            this.btnDelete.ShawdowOpacity = 50;
            this.btnDelete.Size = new System.Drawing.Size(144, 50);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteClass);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.EffectType = MaterialSurface.ET.Custom;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(230, 492);
            this.btnUpdate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnUpdate.Radius = 2;
            this.btnUpdate.ShawdowDepth = 3;
            this.btnUpdate.ShawdowOpacity = 50;
            this.btnUpdate.Size = new System.Drawing.Size(144, 50);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.OnUpdateClass);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.EffectType = MaterialSurface.ET.Custom;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(81, 492);
            this.btnAdd.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAdd.Radius = 2;
            this.btnAdd.ShawdowDepth = 3;
            this.btnAdd.ShawdowOpacity = 50;
            this.btnAdd.Size = new System.Drawing.Size(144, 50);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAddClass);
            // 
            // ClassView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewClass);
            this.Controls.Add(this.cbbFilterByGrade);
            this.Name = "ClassView";
            this.Size = new System.Drawing.Size(1100, 550);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialComboBox cbbFilterByGrade;
        private MaterialSkin.Controls.MaterialListView listViewClass;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colClassId;
        private System.Windows.Forms.ColumnHeader colRumNum;
        private System.Windows.Forms.ColumnHeader colStudenNum;
        private System.Windows.Forms.ColumnHeader colTeacherId;
        private MaterialSurface.ContainedButton btnDelete;
        private MaterialSurface.ContainedButton btnUpdate;
        private MaterialSurface.ContainedButton btnAdd;
    }
}
