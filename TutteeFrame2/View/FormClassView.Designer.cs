
namespace TutteeFrame2.View
{
    partial class FormClassView
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
            this.listviewStudentInClass = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbFormClass = new MaterialSkin.Controls.MaterialLabel();
            this.lbFormClassTittle = new System.Windows.Forms.Label();
            this.lbTotalStudentInClass = new MaterialSkin.Controls.MaterialLabel();
            this.lbTotalStudentInClasTittle = new System.Windows.Forms.Label();
            this.btnViewInfo = new MaterialSurface.ContainedButton();
            this.btnViewStudentScore = new MaterialSurface.ContainedButton();
            this.btnSetConduct = new MaterialSurface.ContainedButton();
            this.btnAddFault = new MaterialSurface.ContainedButton();
            this.btnStudentReport = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // listviewStudentInClass
            // 
            this.listviewStudentInClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewStudentInClass.AutoSizeTable = false;
            this.listviewStudentInClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listviewStudentInClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewStudentInClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader12,
            this.columnHeader9});
            this.listviewStudentInClass.Depth = 0;
            this.listviewStudentInClass.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.listviewStudentInClass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listviewStudentInClass.FullRowSelect = true;
            this.listviewStudentInClass.HideSelection = false;
            this.listviewStudentInClass.Location = new System.Drawing.Point(-3, 50);
            this.listviewStudentInClass.MinimumSize = new System.Drawing.Size(200, 100);
            this.listviewStudentInClass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listviewStudentInClass.MouseState = MaterialSkin.MouseState.OUT;
            this.listviewStudentInClass.MultiSelect = false;
            this.listviewStudentInClass.Name = "listviewStudentInClass";
            this.listviewStudentInClass.OwnerDraw = true;
            this.listviewStudentInClass.Size = new System.Drawing.Size(1110, 453);
            this.listviewStudentInClass.TabIndex = 17;
            this.listviewStudentInClass.UseCompatibleStateImageBehavior = false;
            this.listviewStudentInClass.View = System.Windows.Forms.View.Details;
            this.listviewStudentInClass.SelectedIndexChanged += new System.EventHandler(this.OnChooseStudent);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã học sinh";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Họ tên học sinh";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 230;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ĐTB HK1";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Hạnh kiểm HK1";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ĐTB HK2";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hạnh kiểm HK2";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ĐTB Cả năm";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hạnh kiểm cả năm";
            this.columnHeader9.Width = 150;
            // 
            // lbFormClass
            // 
            this.lbFormClass.AutoSize = true;
            this.lbFormClass.Depth = 0;
            this.lbFormClass.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbFormClass.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbFormClass.HighEmphasis = true;
            this.lbFormClass.Location = new System.Drawing.Point(17, 25);
            this.lbFormClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFormClass.Name = "lbFormClass";
            this.lbFormClass.Size = new System.Drawing.Size(15, 24);
            this.lbFormClass.TabIndex = 16;
            this.lbFormClass.Text = "--";
            this.lbFormClass.UseAccent = true;
            // 
            // lbFormClassTittle
            // 
            this.lbFormClassTittle.AutoSize = true;
            this.lbFormClassTittle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbFormClassTittle.Location = new System.Drawing.Point(6, 2);
            this.lbFormClassTittle.Name = "lbFormClassTittle";
            this.lbFormClassTittle.Size = new System.Drawing.Size(114, 21);
            this.lbFormClassTittle.TabIndex = 15;
            this.lbFormClassTittle.Text = "Lớp chủ nhiệm";
            // 
            // lbTotalStudentInClass
            // 
            this.lbTotalStudentInClass.AutoSize = true;
            this.lbTotalStudentInClass.Depth = 0;
            this.lbTotalStudentInClass.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalStudentInClass.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTotalStudentInClass.HighEmphasis = true;
            this.lbTotalStudentInClass.Location = new System.Drawing.Point(173, 25);
            this.lbTotalStudentInClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotalStudentInClass.Name = "lbTotalStudentInClass";
            this.lbTotalStudentInClass.Size = new System.Drawing.Size(15, 24);
            this.lbTotalStudentInClass.TabIndex = 14;
            this.lbTotalStudentInClass.Text = "--";
            this.lbTotalStudentInClass.UseAccent = true;
            // 
            // lbTotalStudentInClasTittle
            // 
            this.lbTotalStudentInClasTittle.AutoSize = true;
            this.lbTotalStudentInClasTittle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbTotalStudentInClasTittle.Location = new System.Drawing.Point(162, 2);
            this.lbTotalStudentInClasTittle.Name = "lbTotalStudentInClasTittle";
            this.lbTotalStudentInClasTittle.Size = new System.Drawing.Size(105, 21);
            this.lbTotalStudentInClasTittle.TabIndex = 13;
            this.lbTotalStudentInClasTittle.Text = "Sỉ số học sinh";
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewInfo.EffectType = MaterialSurface.ET.Custom;
            this.btnViewInfo.Enabled = false;
            this.btnViewInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnViewInfo.Icon = null;
            this.btnViewInfo.Location = new System.Drawing.Point(10, 506);
            this.btnViewInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewInfo.MouseState = MaterialSurface.MouseState.OUT;
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnViewInfo.Radius = 2;
            this.btnViewInfo.ShawdowDepth = 3;
            this.btnViewInfo.ShawdowOpacity = 50;
            this.btnViewInfo.Size = new System.Drawing.Size(180, 50);
            this.btnViewInfo.TabIndex = 37;
            this.btnViewInfo.Text = "Xem thông tin";
            this.btnViewInfo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnViewInfo.UseVisualStyleBackColor = true;
            this.btnViewInfo.Click += new System.EventHandler(this.OnViewStudent);
            // 
            // btnViewStudentScore
            // 
            this.btnViewStudentScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewStudentScore.EffectType = MaterialSurface.ET.Custom;
            this.btnViewStudentScore.Enabled = false;
            this.btnViewStudentScore.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudentScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnViewStudentScore.Icon = null;
            this.btnViewStudentScore.Location = new System.Drawing.Point(198, 506);
            this.btnViewStudentScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewStudentScore.MouseState = MaterialSurface.MouseState.OUT;
            this.btnViewStudentScore.Name = "btnViewStudentScore";
            this.btnViewStudentScore.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnViewStudentScore.Radius = 2;
            this.btnViewStudentScore.ShawdowDepth = 3;
            this.btnViewStudentScore.ShawdowOpacity = 50;
            this.btnViewStudentScore.Size = new System.Drawing.Size(180, 50);
            this.btnViewStudentScore.TabIndex = 38;
            this.btnViewStudentScore.Text = "Xem bảng điểm";
            this.btnViewStudentScore.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnViewStudentScore.UseVisualStyleBackColor = true;
            this.btnViewStudentScore.Click += new System.EventHandler(this.OnViewDetailScoreboard);
            // 
            // btnSetConduct
            // 
            this.btnSetConduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSetConduct.EffectType = MaterialSurface.ET.Custom;
            this.btnSetConduct.Enabled = false;
            this.btnSetConduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetConduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSetConduct.Icon = null;
            this.btnSetConduct.Location = new System.Drawing.Point(386, 506);
            this.btnSetConduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetConduct.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSetConduct.Name = "btnSetConduct";
            this.btnSetConduct.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSetConduct.Radius = 2;
            this.btnSetConduct.ShawdowDepth = 3;
            this.btnSetConduct.ShawdowOpacity = 50;
            this.btnSetConduct.Size = new System.Drawing.Size(180, 50);
            this.btnSetConduct.TabIndex = 39;
            this.btnSetConduct.Text = "Xếp hạnh kiểm";
            this.btnSetConduct.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSetConduct.UseVisualStyleBackColor = true;
            this.btnSetConduct.Click += new System.EventHandler(this.OnUpdateStudentConduct);
            // 
            // btnAddFault
            // 
            this.btnAddFault.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddFault.EffectType = MaterialSurface.ET.Custom;
            this.btnAddFault.Enabled = false;
            this.btnAddFault.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAddFault.Icon = null;
            this.btnAddFault.Location = new System.Drawing.Point(574, 506);
            this.btnAddFault.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFault.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAddFault.Name = "btnAddFault";
            this.btnAddFault.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAddFault.Radius = 2;
            this.btnAddFault.ShawdowDepth = 3;
            this.btnAddFault.ShawdowOpacity = 50;
            this.btnAddFault.Size = new System.Drawing.Size(180, 50);
            this.btnAddFault.TabIndex = 40;
            this.btnAddFault.Text = "Thêm vi phạm";
            this.btnAddFault.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddFault.UseVisualStyleBackColor = true;
            this.btnAddFault.Click += new System.EventHandler(this.OnAddFault);
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStudentReport.EffectType = MaterialSurface.ET.Custom;
            this.btnStudentReport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnStudentReport.Icon = null;
            this.btnStudentReport.Location = new System.Drawing.Point(916, 506);
            this.btnStudentReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentReport.MouseState = MaterialSurface.MouseState.OUT;
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnStudentReport.Radius = 2;
            this.btnStudentReport.ShawdowDepth = 3;
            this.btnStudentReport.ShawdowOpacity = 50;
            this.btnStudentReport.Size = new System.Drawing.Size(180, 50);
            this.btnStudentReport.TabIndex = 41;
            this.btnStudentReport.Text = "Tạo báo cáo";
            this.btnStudentReport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStudentReport.UseVisualStyleBackColor = true;
            // 
            // FormClassView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnStudentReport);
            this.Controls.Add(this.btnAddFault);
            this.Controls.Add(this.btnSetConduct);
            this.Controls.Add(this.btnViewStudentScore);
            this.Controls.Add(this.btnViewInfo);
            this.Controls.Add(this.listviewStudentInClass);
            this.Controls.Add(this.lbFormClass);
            this.Controls.Add(this.lbFormClassTittle);
            this.Controls.Add(this.lbTotalStudentInClass);
            this.Controls.Add(this.lbTotalStudentInClasTittle);
            this.Name = "FormClassView";
            this.Size = new System.Drawing.Size(1100, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView listviewStudentInClass;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private MaterialSkin.Controls.MaterialLabel lbFormClass;
        private System.Windows.Forms.Label lbFormClassTittle;
        private MaterialSkin.Controls.MaterialLabel lbTotalStudentInClass;
        private System.Windows.Forms.Label lbTotalStudentInClasTittle;
        private MaterialSurface.ContainedButton btnViewInfo;
        private MaterialSurface.ContainedButton btnViewStudentScore;
        private MaterialSurface.ContainedButton btnSetConduct;
        private MaterialSurface.ContainedButton btnAddFault;
        private MaterialSurface.ContainedButton btnStudentReport;
    }
}
