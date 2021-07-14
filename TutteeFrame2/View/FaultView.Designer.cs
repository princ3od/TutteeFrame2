
namespace TutteeFrame2.View
{
    partial class FaultView
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
            this.lbFormClass = new MaterialSkin.Controls.MaterialLabel();
            this.lbFormClass2 = new System.Windows.Forms.Label();
            this.listViewFault = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new MaterialSurface.ContainedButton();
            this.btnDelete = new MaterialSurface.ContainedButton();
            this.lbTotalFault = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFormClass
            // 
            this.lbFormClass.AutoSize = true;
            this.lbFormClass.Depth = 0;
            this.lbFormClass.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbFormClass.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbFormClass.HighEmphasis = true;
            this.lbFormClass.Location = new System.Drawing.Point(28, 35);
            this.lbFormClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFormClass.Name = "lbFormClass";
            this.lbFormClass.Size = new System.Drawing.Size(15, 24);
            this.lbFormClass.TabIndex = 16;
            this.lbFormClass.Text = "--";
            this.lbFormClass.UseAccent = true;
            // 
            // lbFormClass2
            // 
            this.lbFormClass2.AutoSize = true;
            this.lbFormClass2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbFormClass2.Location = new System.Drawing.Point(15, 12);
            this.lbFormClass2.Name = "lbFormClass2";
            this.lbFormClass2.Size = new System.Drawing.Size(114, 21);
            this.lbFormClass2.TabIndex = 15;
            this.lbFormClass2.Text = "Lớp chủ nhiệm";
            // 
            // listViewFault
            // 
            this.listViewFault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFault.AutoSizeTable = false;
            this.listViewFault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewFault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewFault.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader20,
            this.columnHeader17});
            this.listViewFault.Depth = 0;
            this.listViewFault.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.listViewFault.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewFault.FullRowSelect = true;
            this.listViewFault.HideSelection = false;
            this.listViewFault.Location = new System.Drawing.Point(6, 80);
            this.listViewFault.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewFault.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewFault.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewFault.Name = "listViewFault";
            this.listViewFault.OwnerDraw = true;
            this.listViewFault.Size = new System.Drawing.Size(1094, 411);
            this.listViewFault.TabIndex = 14;
            this.listViewFault.UseCompatibleStateImageBehavior = false;
            this.listViewFault.View = System.Windows.Forms.View.Details;
            this.listViewFault.SelectedIndexChanged += new System.EventHandler(this.OnChooseFault);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "STT";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Mã vi phạm";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Mã học sinh";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Họ tên";
            this.columnHeader16.Width = 250;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Học kì";
            this.columnHeader20.Width = 80;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Lỗi vi phạm";
            this.columnHeader17.Width = 424;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.EffectType = MaterialSurface.ET.Custom;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(98, 500);
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
            this.btnUpdate.Click += new System.EventHandler(this.OnUpdateFault);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.EffectType = MaterialSurface.ET.Custom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(762, 497);
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
            this.btnDelete.Click += new System.EventHandler(this.OnDeleteFault);
            // 
            // lbTotalFault
            // 
            this.lbTotalFault.AutoSize = true;
            this.lbTotalFault.Depth = 0;
            this.lbTotalFault.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalFault.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTotalFault.HighEmphasis = true;
            this.lbTotalFault.Location = new System.Drawing.Point(148, 35);
            this.lbTotalFault.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotalFault.Name = "lbTotalFault";
            this.lbTotalFault.Size = new System.Drawing.Size(15, 24);
            this.lbTotalFault.TabIndex = 50;
            this.lbTotalFault.Text = "--";
            this.lbTotalFault.UseAccent = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(135, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tổng số vi phạm";
            // 
            // FaultView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbTotalFault);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbFormClass);
            this.Controls.Add(this.lbFormClass2);
            this.Controls.Add(this.listViewFault);
            this.Name = "FaultView";
            this.Size = new System.Drawing.Size(1100, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbFormClass;
        private System.Windows.Forms.Label lbFormClass2;
        private MaterialSkin.Controls.MaterialListView listViewFault;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private MaterialSurface.ContainedButton btnUpdate;
        private MaterialSurface.ContainedButton btnDelete;
        private MaterialSkin.Controls.MaterialLabel lbTotalFault;
        private System.Windows.Forms.Label label1;
    }
}
