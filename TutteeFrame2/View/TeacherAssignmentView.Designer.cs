
namespace TutteeFrame2.View
{
    partial class TeacherAssignmentView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("----", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("----", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherAssignmentView));
            this.cbbFilterByGrade = new MaterialSurface.MaterialComboBox();
            this.ckbHideDoneClass = new MaterialSurface.MaterialCheckbox();
            this.listViewTeachingClass = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAssign = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // cbbFilterByGrade
            // 
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
            this.cbbFilterByGrade.Location = new System.Drawing.Point(30, 15);
            this.cbbFilterByGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByGrade.MaxDropDownItems = 4;
            this.cbbFilterByGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByGrade.Name = "cbbFilterByGrade";
            this.cbbFilterByGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByGrade.Size = new System.Drawing.Size(102, 47);
            this.cbbFilterByGrade.TabIndex = 45;
            this.cbbFilterByGrade.SelectedIndexChanged += new System.EventHandler(this.OnChangeGrade);
            // 
            // ckbRemember
            // 
            this.ckbHideDoneClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbHideDoneClass.BorderColor = System.Drawing.Color.Gray;
            this.ckbHideDoneClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ckbHideDoneClass.Location = new System.Drawing.Point(861, 38);
            this.ckbHideDoneClass.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.ckbHideDoneClass.MinimumSize = new System.Drawing.Size(25, 24);
            this.ckbHideDoneClass.MouseState = MaterialSurface.MouseState.OUT;
            this.ckbHideDoneClass.Name = "ckbRemember";
            this.ckbHideDoneClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.ckbHideDoneClass.Size = new System.Drawing.Size(245, 24);
            this.ckbHideDoneClass.TabIndex = 46;
            this.ckbHideDoneClass.Text = "Ẩn các lớp đã phân công xong";
            this.ckbHideDoneClass.UseVisualStyleBackColor = true;
            this.ckbHideDoneClass.CheckedChanged += new System.EventHandler(this.OnHideDoneClass);
            // 
            // listViewTeachingClass
            // 
            this.listViewTeachingClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTeachingClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewTeachingClass.HideSelection = false;
            this.listViewTeachingClass.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listViewTeachingClass.LargeImageList = this.imageList1;
            this.listViewTeachingClass.Location = new System.Drawing.Point(30, 86);
            this.listViewTeachingClass.MultiSelect = false;
            this.listViewTeachingClass.Name = "listViewTeachingClass";
            this.listViewTeachingClass.Size = new System.Drawing.Size(1091, 440);
            this.listViewTeachingClass.TabIndex = 47;
            this.listViewTeachingClass.UseCompatibleStateImageBehavior = false;
            this.listViewTeachingClass.DoubleClick += new System.EventHandler(this.OnAssignClass);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "classroom.png");
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.EffectType = MaterialSurface.ET.Custom;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAssign.Icon = null;
            this.btnAssign.Location = new System.Drawing.Point(726, 532);
            this.btnAssign.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAssign.Radius = 2;
            this.btnAssign.ShawdowDepth = 3;
            this.btnAssign.ShawdowOpacity = 50;
            this.btnAssign.Size = new System.Drawing.Size(270, 50);
            this.btnAssign.TabIndex = 48;
            this.btnAssign.Text = "Phân công giáo viên";
            this.btnAssign.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.OnAssignClass);
            // 
            // TeacherAssignmentView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.listViewTeachingClass);
            this.Controls.Add(this.ckbHideDoneClass);
            this.Controls.Add(this.cbbFilterByGrade);
            this.Name = "TeacherAssignmentView";
            this.Size = new System.Drawing.Size(1150, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialComboBox cbbFilterByGrade;
        private MaterialSurface.MaterialCheckbox ckbHideDoneClass;
        private System.Windows.Forms.ListView listViewTeachingClass;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSurface.ContainedButton btnAssign;
    }
}
