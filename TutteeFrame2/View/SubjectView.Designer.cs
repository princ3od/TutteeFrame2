
namespace TutteeFrame2.View
{
    partial class SubjectView
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
            this.lvSubjectManage = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbListNameSubject = new System.Windows.Forms.Label();
            this.btnAddNewSubject = new MaterialSurface.ContainedButton();
            this.btnDelSubject = new MaterialSurface.ContainedButton();
            this.btnEditSubject = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // lvSubjectManage
            // 
            this.lvSubjectManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSubjectManage.AutoSizeTable = false;
            this.lvSubjectManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvSubjectManage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSubjectManage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSubjectManage.Depth = 0;
            this.lvSubjectManage.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lvSubjectManage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lvSubjectManage.FullRowSelect = true;
            this.lvSubjectManage.HideSelection = false;
            this.lvSubjectManage.Location = new System.Drawing.Point(19, 78);
            this.lvSubjectManage.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvSubjectManage.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvSubjectManage.MouseState = MaterialSkin.MouseState.OUT;
            this.lvSubjectManage.Name = "lvSubjectManage";
            this.lvSubjectManage.OwnerDraw = true;
            this.lvSubjectManage.Size = new System.Drawing.Size(548, 332);
            this.lvSubjectManage.TabIndex = 3;
            this.lvSubjectManage.UseCompatibleStateImageBehavior = false;
            this.lvSubjectManage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số thứ tự";
            this.columnHeader1.Width = 209;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên môn học";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 392;
            // 
            // lbListNameSubject
            // 
            this.lbListNameSubject.AutoSize = true;
            this.lbListNameSubject.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbListNameSubject.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbListNameSubject.Location = new System.Drawing.Point(13, 19);
            this.lbListNameSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListNameSubject.Name = "lbListNameSubject";
            this.lbListNameSubject.Size = new System.Drawing.Size(182, 32);
            this.lbListNameSubject.TabIndex = 30;
            this.lbListNameSubject.Text = "Danh sách môn";
            // 
            // btnAddNewSubject
            // 
            this.btnAddNewSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddNewSubject.EffectType = MaterialSurface.ET.Custom;
            this.btnAddNewSubject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAddNewSubject.Icon = null;
            this.btnAddNewSubject.Location = new System.Drawing.Point(19, 456);
            this.btnAddNewSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewSubject.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAddNewSubject.Name = "btnAddNewSubject";
            this.btnAddNewSubject.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAddNewSubject.Radius = 2;
            this.btnAddNewSubject.ShawdowDepth = 3;
            this.btnAddNewSubject.ShawdowOpacity = 50;
            this.btnAddNewSubject.Size = new System.Drawing.Size(200, 62);
            this.btnAddNewSubject.TabIndex = 36;
            this.btnAddNewSubject.Text = "Thêm môn học";
            this.btnAddNewSubject.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAddNewSubject.UseVisualStyleBackColor = true;
            // 
            // btnDelSubject
            // 
            this.btnDelSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelSubject.EffectType = MaterialSurface.ET.Custom;
            this.btnDelSubject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDelSubject.Icon = null;
            this.btnDelSubject.Location = new System.Drawing.Point(301, 456);
            this.btnDelSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelSubject.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDelSubject.Name = "btnDelSubject";
            this.btnDelSubject.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnDelSubject.Radius = 2;
            this.btnDelSubject.ShawdowDepth = 3;
            this.btnDelSubject.ShawdowOpacity = 50;
            this.btnDelSubject.Size = new System.Drawing.Size(200, 62);
            this.btnDelSubject.TabIndex = 37;
            this.btnDelSubject.Text = "Chỉnh sửa";
            this.btnDelSubject.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDelSubject.UseVisualStyleBackColor = true;
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditSubject.EffectType = MaterialSurface.ET.Custom;
            this.btnEditSubject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnEditSubject.Icon = null;
            this.btnEditSubject.Location = new System.Drawing.Point(563, 456);
            this.btnEditSubject.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSubject.MouseState = MaterialSurface.MouseState.OUT;
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnEditSubject.Radius = 2;
            this.btnEditSubject.ShawdowDepth = 3;
            this.btnEditSubject.ShawdowOpacity = 50;
            this.btnEditSubject.Size = new System.Drawing.Size(200, 62);
            this.btnEditSubject.TabIndex = 38;
            this.btnEditSubject.Text = "Xóa môn học";
            this.btnEditSubject.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEditSubject.UseVisualStyleBackColor = true;
            // 
            // SubjectView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnDelSubject);
            this.Controls.Add(this.btnAddNewSubject);
            this.Controls.Add(this.lbListNameSubject);
            this.Controls.Add(this.lvSubjectManage);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "SubjectView";
            this.Size = new System.Drawing.Size(834, 560);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvSubjectManage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbListNameSubject;
        private MaterialSurface.ContainedButton btnAddNewSubject;
        private MaterialSurface.ContainedButton btnDelSubject;
        private MaterialSurface.ContainedButton btnEditSubject;
    }
}
