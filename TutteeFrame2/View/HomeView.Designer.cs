
namespace TutteeFrame2.View
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.textButton1 = new MaterialSurface.TextButton();
            this.mainDrawer = new MaterialSkin.Controls.MaterialDrawer();
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textButton1
            // 
            this.textButton1.EffectType = MaterialSurface.ET.Custom;
            this.textButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton1.ForeColor = System.Drawing.Color.BlueViolet;
            this.textButton1.Icon = null;
            this.textButton1.Location = new System.Drawing.Point(1017, 13);
            this.textButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.textButton1.Name = "textButton1";
            this.textButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.textButton1.Radius = 6;
            this.textButton1.Size = new System.Drawing.Size(159, 39);
            this.textButton1.TabIndex = 0;
            this.textButton1.Text = "Đăng xuất";
            this.textButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.textButton1.UseVisualStyleBackColor = true;
            this.textButton1.Click += new System.EventHandler(this.OnLogout);
            // 
            // mainDrawer
            // 
            this.mainDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainDrawer.AutoHide = false;
            this.mainDrawer.BackgroundWithAccent = false;
            this.mainDrawer.BaseTabControl = this.mainTabControl;
            this.mainDrawer.Depth = 0;
            this.mainDrawer.HighlightWithAccent = true;
            this.mainDrawer.IndicatorWidth = 5;
            this.mainDrawer.IsOpen = true;
            this.mainDrawer.Location = new System.Drawing.Point(0, 96);
            this.mainDrawer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainDrawer.Name = "mainDrawer";
            this.mainDrawer.ShowIconsWhenHidden = false;
            this.mainDrawer.Size = new System.Drawing.Size(249, 593);
            this.mainDrawer.TabIndex = 1;
            this.mainDrawer.Text = "materialDrawer1";
            this.mainDrawer.UseColors = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Controls.Add(this.tabPage5);
            this.mainTabControl.Controls.Add(this.tabPage6);
            this.mainTabControl.Controls.Add(this.tabPage7);
            this.mainTabControl.Controls.Add(this.tabPage8);
            this.mainTabControl.Controls.Add(this.tabPage9);
            this.mainTabControl.Controls.Add(this.tabPage10);
            this.mainTabControl.Controls.Add(this.tabPage11);
            this.mainTabControl.Controls.Add(this.tabPage12);
            this.mainTabControl.Controls.Add(this.tabPage13);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Location = new System.Drawing.Point(255, 52);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(925, 606);
            this.mainTabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(917, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(907, 593);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lí giáo viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(907, 593);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lí học sinh";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(907, 593);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bảng điểm học sinh";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(907, 593);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Quản lí môn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(907, 593);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Quản lí lớp";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(907, 593);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Quản lí kỉ luật";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(907, 593);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Báo cáo";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(907, 593);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Lớp chủ nhiệm";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(907, 593);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Phân công giáo viên";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(907, 593);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Quản lí giáo viên";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 40);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(907, 575);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "Quản lí vi phạm";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 40);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(907, 575);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "Quản lí thời khóa biểu";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 100);
            this.panel2.TabIndex = 3;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(40, 86);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(175, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.ChangeDelay = 50;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = false;
            this.mainProgressbar.Location = new System.Drawing.Point(247, 675);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.mainProgressbar.Size = new System.Drawing.Size(940, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 4;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 0;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(257, 661);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 27;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // HomeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 681);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.textButton1);
            this.Controls.Add(this.mainDrawer);
            this.Controls.Add(this.mainProgressbar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TutteeFrame 2.0";
            this.mainTabControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.TextButton textButton1;
        private MaterialSkin.Controls.MaterialDrawer mainDrawer;
        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
    }
}

