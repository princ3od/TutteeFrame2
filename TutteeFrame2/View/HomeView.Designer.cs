
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
            this.btnLogout = new MaterialSurface.TextButton();
            this.mainDrawer = new MaterialSkin.Controls.MaterialDrawer();
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSurface.MaterialCard();
            this.choiceChip8 = new MaterialSurface.ChoiceChip();
            this.choiceChip9 = new MaterialSurface.ChoiceChip();
            this.label2 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.choiceChip6 = new MaterialSurface.ChoiceChip();
            this.choiceChip7 = new MaterialSurface.ChoiceChip();
            this.choiceChip4 = new MaterialSurface.ChoiceChip();
            this.choiceChip5 = new MaterialSurface.ChoiceChip();
            this.choiceChip3 = new MaterialSurface.ChoiceChip();
            this.choiceChip2 = new MaterialSurface.ChoiceChip();
            this.choiceChip1 = new MaterialSurface.ChoiceChip();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPositionBig = new System.Windows.Forms.Label();
            this.lbNameBig = new System.Windows.Forms.Label();
            this.ptbAvatarBig = new System.Windows.Forms.PictureBox();
            this.quanLiGiaoVien = new System.Windows.Forms.TabPage();
            this.teacherView1 = new TutteeFrame2.View.TeacherView();
            this.quanLiHocSinh = new System.Windows.Forms.TabPage();
            this.studentView = new TutteeFrame2.View.StudentView();
            this.bangDiemHocSinh = new System.Windows.Forms.TabPage();
            this.quanLiMon = new System.Windows.Forms.TabPage();
            this.subjectView = new TutteeFrame2.View.SubjectView();
            this.quanLiLop = new System.Windows.Forms.TabPage();
            this.quanLiKiLuat = new System.Windows.Forms.TabPage();
            this.baoCao = new System.Windows.Forms.TabPage();
            this.lopChuNhiem = new System.Windows.Forms.TabPage();
            this.phanCongGiaoVien = new System.Windows.Forms.TabPage();
            this.quanLiViPham = new System.Windows.Forms.TabPage();
            this.quanLiTKB = new System.Windows.Forms.TabPage();
            this.quanLiLichHop = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.utilityBar = new MaterialSurface.MaterialCard();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.ptbSmallAvatar = new System.Windows.Forms.PictureBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnInformation = new MaterialSurface.TextButton();
            this.btnSetting = new MaterialSurface.TextButton();
            this.btnChangePass = new MaterialSurface.TextButton();
            this.btnShowMore = new MaterialSkin.Controls.MaterialButton();
            this.mainTabControl.SuspendLayout();
            this.home.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatarBig)).BeginInit();
            this.quanLiGiaoVien.SuspendLayout();
            this.quanLiHocSinh.SuspendLayout();
            this.quanLiMon.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.utilityBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSmallAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.EffectType = MaterialSurface.ET.Custom;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Icon = null;
            this.btnLogout.Location = new System.Drawing.Point(8, 195);
            this.btnLogout.MouseState = MaterialSurface.MouseState.OUT;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PrimaryColor = System.Drawing.Color.Red;
            this.btnLogout.Radius = 8;
            this.btnLogout.Size = new System.Drawing.Size(252, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.OnLogout);
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
            this.mainDrawer.Size = new System.Drawing.Size(249, 623);
            this.mainDrawer.TabIndex = 1;
            this.mainDrawer.Text = "materialDrawer1";
            this.mainDrawer.UseColors = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.home);
            this.mainTabControl.Controls.Add(this.quanLiGiaoVien);
            this.mainTabControl.Controls.Add(this.quanLiHocSinh);
            this.mainTabControl.Controls.Add(this.bangDiemHocSinh);
            this.mainTabControl.Controls.Add(this.quanLiMon);
            this.mainTabControl.Controls.Add(this.quanLiLop);
            this.mainTabControl.Controls.Add(this.quanLiKiLuat);
            this.mainTabControl.Controls.Add(this.baoCao);
            this.mainTabControl.Controls.Add(this.lopChuNhiem);
            this.mainTabControl.Controls.Add(this.phanCongGiaoVien);
            this.mainTabControl.Controls.Add(this.quanLiViPham);
            this.mainTabControl.Controls.Add(this.quanLiTKB);
            this.mainTabControl.Controls.Add(this.quanLiLichHop);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Location = new System.Drawing.Point(255, 76);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1124, 612);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.OnTabpageChanged);
            // 
            // home
            // 
            this.home.AutoScroll = true;
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Controls.Add(this.materialCard2);
            this.home.Controls.Add(this.materialCard1);
            this.home.Controls.Add(this.lbPositionBig);
            this.home.Controls.Add(this.lbNameBig);
            this.home.Controls.Add(this.ptbAvatarBig);
            this.home.Location = new System.Drawing.Point(4, 44);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1116, 564);
            this.home.TabIndex = 0;
            this.home.Text = "Trang chủ";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard2.BackColor = System.Drawing.Color.White;
            this.materialCard2.CardColor = System.Drawing.Color.White;
            this.materialCard2.Controls.Add(this.choiceChip8);
            this.materialCard2.Controls.Add(this.choiceChip9);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard2.Location = new System.Drawing.Point(530, 191);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseInteract = false;
            this.materialCard2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Radius = 8;
            this.materialCard2.ShawdowDepth = 2;
            this.materialCard2.ShawdowOpacity = 50;
            this.materialCard2.Size = new System.Drawing.Size(377, 194);
            this.materialCard2.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard2.TabIndex = 31;
            // 
            // choiceChip8
            // 
            this.choiceChip8.Checked = true;
            this.choiceChip8.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip8.Location = new System.Drawing.Point(137, 44);
            this.choiceChip8.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip8.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip8.Name = "choiceChip8";
            this.choiceChip8.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip8.Size = new System.Drawing.Size(125, 25);
            this.choiceChip8.TabIndex = 18;
            this.choiceChip8.TabStop = true;
            this.choiceChip8.Text = "Sắp diễn ra";
            this.choiceChip8.UseVisualStyleBackColor = true;
            // 
            // choiceChip9
            // 
            this.choiceChip9.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip9.Location = new System.Drawing.Point(21, 44);
            this.choiceChip9.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip9.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip9.Name = "choiceChip9";
            this.choiceChip9.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip9.Size = new System.Drawing.Size(110, 25);
            this.choiceChip9.TabIndex = 17;
            this.choiceChip9.Text = "Đã diễn ra";
            this.choiceChip9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lịch họp";
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialCard1.BackColor = System.Drawing.Color.White;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.choiceChip6);
            this.materialCard1.Controls.Add(this.choiceChip7);
            this.materialCard1.Controls.Add(this.choiceChip4);
            this.materialCard1.Controls.Add(this.choiceChip5);
            this.materialCard1.Controls.Add(this.choiceChip3);
            this.materialCard1.Controls.Add(this.choiceChip2);
            this.materialCard1.Controls.Add(this.choiceChip1);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(11, 191);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(509, 194);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 30;
            // 
            // choiceChip6
            // 
            this.choiceChip6.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip6.Location = new System.Drawing.Point(430, 44);
            this.choiceChip6.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip6.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip6.Name = "choiceChip6";
            this.choiceChip6.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip6.Size = new System.Drawing.Size(62, 25);
            this.choiceChip6.TabIndex = 21;
            this.choiceChip6.Text = "Thứ 7";
            this.choiceChip6.UseVisualStyleBackColor = true;
            // 
            // choiceChip7
            // 
            this.choiceChip7.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip7.Location = new System.Drawing.Point(362, 44);
            this.choiceChip7.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip7.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip7.Name = "choiceChip7";
            this.choiceChip7.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip7.Size = new System.Drawing.Size(62, 25);
            this.choiceChip7.TabIndex = 20;
            this.choiceChip7.Text = "Thứ 6";
            this.choiceChip7.UseVisualStyleBackColor = true;
            // 
            // choiceChip4
            // 
            this.choiceChip4.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip4.Location = new System.Drawing.Point(294, 44);
            this.choiceChip4.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip4.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip4.Name = "choiceChip4";
            this.choiceChip4.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip4.Size = new System.Drawing.Size(62, 25);
            this.choiceChip4.TabIndex = 19;
            this.choiceChip4.Text = "Thứ 5";
            this.choiceChip4.UseVisualStyleBackColor = true;
            // 
            // choiceChip5
            // 
            this.choiceChip5.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip5.Location = new System.Drawing.Point(226, 44);
            this.choiceChip5.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip5.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip5.Name = "choiceChip5";
            this.choiceChip5.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip5.Size = new System.Drawing.Size(62, 25);
            this.choiceChip5.TabIndex = 18;
            this.choiceChip5.Text = "Thứ 4";
            this.choiceChip5.UseVisualStyleBackColor = true;
            // 
            // choiceChip3
            // 
            this.choiceChip3.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip3.Location = new System.Drawing.Point(158, 44);
            this.choiceChip3.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip3.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip3.Name = "choiceChip3";
            this.choiceChip3.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip3.Size = new System.Drawing.Size(62, 25);
            this.choiceChip3.TabIndex = 17;
            this.choiceChip3.Text = "Thứ 3";
            this.choiceChip3.UseVisualStyleBackColor = true;
            // 
            // choiceChip2
            // 
            this.choiceChip2.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip2.Location = new System.Drawing.Point(90, 44);
            this.choiceChip2.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip2.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip2.Name = "choiceChip2";
            this.choiceChip2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip2.Size = new System.Drawing.Size(62, 25);
            this.choiceChip2.TabIndex = 16;
            this.choiceChip2.Text = "Thứ 2";
            this.choiceChip2.UseVisualStyleBackColor = true;
            // 
            // choiceChip1
            // 
            this.choiceChip1.Checked = true;
            this.choiceChip1.ChipType = MaterialSurface.ChoiceChip.ChipStyle.Outlined;
            this.choiceChip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.choiceChip1.Location = new System.Drawing.Point(21, 44);
            this.choiceChip1.MinimumSize = new System.Drawing.Size(25, 24);
            this.choiceChip1.MouseState = MaterialSurface.MouseState.OUT;
            this.choiceChip1.Name = "choiceChip1";
            this.choiceChip1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.choiceChip1.Size = new System.Drawing.Size(63, 25);
            this.choiceChip1.TabIndex = 15;
            this.choiceChip1.TabStop = true;
            this.choiceChip1.Text = "Tất cả";
            this.choiceChip1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lịch dạy tuần";
            // 
            // lbPositionBig
            // 
            this.lbPositionBig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPositionBig.BackColor = System.Drawing.Color.White;
            this.lbPositionBig.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbPositionBig.ForeColor = System.Drawing.Color.Blue;
            this.lbPositionBig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPositionBig.Location = new System.Drawing.Point(5, 160);
            this.lbPositionBig.Name = "lbPositionBig";
            this.lbPositionBig.Size = new System.Drawing.Size(911, 26);
            this.lbPositionBig.TabIndex = 29;
            this.lbPositionBig.Text = "----";
            this.lbPositionBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNameBig
            // 
            this.lbNameBig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNameBig.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameBig.Location = new System.Drawing.Point(7, 119);
            this.lbNameBig.Name = "lbNameBig";
            this.lbNameBig.Size = new System.Drawing.Size(908, 41);
            this.lbNameBig.TabIndex = 14;
            this.lbNameBig.Text = "-----";
            this.lbNameBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbAvatarBig
            // 
            this.ptbAvatarBig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbAvatarBig.Image = global::TutteeFrame2.Properties.Resources.default_avatar;
            this.ptbAvatarBig.Location = new System.Drawing.Point(419, 20);
            this.ptbAvatarBig.Name = "ptbAvatarBig";
            this.ptbAvatarBig.Size = new System.Drawing.Size(96, 96);
            this.ptbAvatarBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatarBig.TabIndex = 1;
            this.ptbAvatarBig.TabStop = false;
            // 
            // quanLiGiaoVien
            // 
            this.quanLiGiaoVien.Controls.Add(this.teacherView1);
            this.quanLiGiaoVien.Location = new System.Drawing.Point(4, 22);
            this.quanLiGiaoVien.Name = "quanLiGiaoVien";
            this.quanLiGiaoVien.Size = new System.Drawing.Size(1116, 586);
            this.quanLiGiaoVien.TabIndex = 1;
            this.quanLiGiaoVien.Text = "Quản lí giáo viên";
            this.quanLiGiaoVien.UseVisualStyleBackColor = true;
            // 
            // teacherView1
            // 
            this.teacherView1.BackColor = System.Drawing.Color.White;
            this.teacherView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherView1.Location = new System.Drawing.Point(0, 0);
            this.teacherView1.Name = "teacherView1";
            this.teacherView1.Size = new System.Drawing.Size(1116, 586);
            this.teacherView1.TabIndex = 0;
            // 
            // quanLiHocSinh
            // 
            this.quanLiHocSinh.Controls.Add(this.studentView);
            this.quanLiHocSinh.Location = new System.Drawing.Point(4, 22);
            this.quanLiHocSinh.Name = "quanLiHocSinh";
            this.quanLiHocSinh.Size = new System.Drawing.Size(1116, 586);
            this.quanLiHocSinh.TabIndex = 2;
            this.quanLiHocSinh.Text = "Quản lí học sinh";
            this.quanLiHocSinh.UseVisualStyleBackColor = true;
            // 
            // studentView
            // 
            this.studentView.BackColor = System.Drawing.Color.White;
            this.studentView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentView.Location = new System.Drawing.Point(0, 0);
            this.studentView.Margin = new System.Windows.Forms.Padding(2);
            this.studentView.Name = "studentView";
            this.studentView.Size = new System.Drawing.Size(1116, 586);
            this.studentView.TabIndex = 0;
            // 
            // bangDiemHocSinh
            // 
            this.bangDiemHocSinh.Location = new System.Drawing.Point(4, 22);
            this.bangDiemHocSinh.Name = "bangDiemHocSinh";
            this.bangDiemHocSinh.Size = new System.Drawing.Size(1116, 586);
            this.bangDiemHocSinh.TabIndex = 3;
            this.bangDiemHocSinh.Text = "Bảng điểm học sinh";
            this.bangDiemHocSinh.UseVisualStyleBackColor = true;
            // 
            // quanLiMon
            // 
            this.quanLiMon.Controls.Add(this.subjectView);
            this.quanLiMon.Location = new System.Drawing.Point(4, 22);
            this.quanLiMon.Name = "quanLiMon";
            this.quanLiMon.Size = new System.Drawing.Size(1116, 586);
            this.quanLiMon.TabIndex = 4;
            this.quanLiMon.Text = "Quản lí môn";
            this.quanLiMon.UseVisualStyleBackColor = true;
            // 
            // subjectView
            // 
            this.subjectView.BackColor = System.Drawing.Color.White;
            this.subjectView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.subjectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjectView.Location = new System.Drawing.Point(0, 0);
            this.subjectView.Name = "subjectView";
            this.subjectView.Size = new System.Drawing.Size(1116, 586);
            this.subjectView.TabIndex = 1;
            // 
            // quanLiLop
            // 
            this.quanLiLop.Location = new System.Drawing.Point(4, 22);
            this.quanLiLop.Name = "quanLiLop";
            this.quanLiLop.Size = new System.Drawing.Size(1116, 586);
            this.quanLiLop.TabIndex = 5;
            this.quanLiLop.Text = "Quản lí lớp";
            this.quanLiLop.UseVisualStyleBackColor = true;
            // 
            // quanLiKiLuat
            // 
            this.quanLiKiLuat.Location = new System.Drawing.Point(4, 22);
            this.quanLiKiLuat.Name = "quanLiKiLuat";
            this.quanLiKiLuat.Size = new System.Drawing.Size(1116, 586);
            this.quanLiKiLuat.TabIndex = 6;
            this.quanLiKiLuat.Text = "Quản lí kỉ luật";
            this.quanLiKiLuat.UseVisualStyleBackColor = true;
            // 
            // baoCao
            // 
            this.baoCao.Location = new System.Drawing.Point(4, 22);
            this.baoCao.Name = "baoCao";
            this.baoCao.Size = new System.Drawing.Size(1116, 586);
            this.baoCao.TabIndex = 7;
            this.baoCao.Text = "Báo cáo";
            this.baoCao.UseVisualStyleBackColor = true;
            // 
            // lopChuNhiem
            // 
            this.lopChuNhiem.Location = new System.Drawing.Point(4, 22);
            this.lopChuNhiem.Name = "lopChuNhiem";
            this.lopChuNhiem.Size = new System.Drawing.Size(1116, 586);
            this.lopChuNhiem.TabIndex = 8;
            this.lopChuNhiem.Text = "Lớp chủ nhiệm";
            this.lopChuNhiem.UseVisualStyleBackColor = true;
            // 
            // phanCongGiaoVien
            // 
            this.phanCongGiaoVien.Location = new System.Drawing.Point(4, 22);
            this.phanCongGiaoVien.Name = "phanCongGiaoVien";
            this.phanCongGiaoVien.Size = new System.Drawing.Size(1116, 586);
            this.phanCongGiaoVien.TabIndex = 9;
            this.phanCongGiaoVien.Text = "Phân công giáo viên";
            this.phanCongGiaoVien.UseVisualStyleBackColor = true;
            // 
            // quanLiViPham
            // 
            this.quanLiViPham.Location = new System.Drawing.Point(4, 22);
            this.quanLiViPham.Name = "quanLiViPham";
            this.quanLiViPham.Size = new System.Drawing.Size(1116, 586);
            this.quanLiViPham.TabIndex = 11;
            this.quanLiViPham.Text = "Quản lí vi phạm";
            this.quanLiViPham.UseVisualStyleBackColor = true;
            // 
            // quanLiTKB
            // 
            this.quanLiTKB.Location = new System.Drawing.Point(4, 22);
            this.quanLiTKB.Name = "quanLiTKB";
            this.quanLiTKB.Size = new System.Drawing.Size(1116, 586);
            this.quanLiTKB.TabIndex = 12;
            this.quanLiTKB.Text = "Quản lí thời khóa biểu";
            this.quanLiTKB.UseVisualStyleBackColor = true;
            // 
            // quanLiLichHop
            // 
            this.quanLiLichHop.Location = new System.Drawing.Point(4, 22);
            this.quanLiLichHop.Name = "quanLiLichHop";
            this.quanLiLichHop.Size = new System.Drawing.Size(1116, 586);
            this.quanLiLichHop.TabIndex = 13;
            this.quanLiLichHop.Text = "Quản lí lịch họp";
            this.quanLiLichHop.UseVisualStyleBackColor = true;
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
            this.mainProgressbar.ChangeDelay = 70;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(247, 705);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(1139, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 4;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 36;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(257, 691);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 27;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // utilityBar
            // 
            this.utilityBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.utilityBar.BackColor = System.Drawing.Color.White;
            this.utilityBar.CardColor = System.Drawing.Color.White;
            this.utilityBar.Controls.Add(this.lbPosition);
            this.utilityBar.Controls.Add(this.lbName);
            this.utilityBar.Controls.Add(this.ptbSmallAvatar);
            this.utilityBar.Controls.Add(this.materialDivider2);
            this.utilityBar.Controls.Add(this.btnInformation);
            this.utilityBar.Controls.Add(this.btnSetting);
            this.utilityBar.Controls.Add(this.btnChangePass);
            this.utilityBar.Controls.Add(this.btnLogout);
            this.utilityBar.Controls.Add(this.btnShowMore);
            this.utilityBar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilityBar.Location = new System.Drawing.Point(1109, 14);
            this.utilityBar.Margin = new System.Windows.Forms.Padding(5);
            this.utilityBar.MouseInteract = false;
            this.utilityBar.MouseState = MaterialSurface.MouseState.OUT;
            this.utilityBar.Name = "utilityBar";
            this.utilityBar.Radius = 9;
            this.utilityBar.ShawdowDepth = 2;
            this.utilityBar.ShawdowOpacity = 60;
            this.utilityBar.Size = new System.Drawing.Size(270, 55);
            this.utilityBar.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.utilityBar.TabIndex = 1;
            this.utilityBar.Leave += new System.EventHandler(this.CloseUtilityBar);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.Color.White;
            this.lbPosition.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbPosition.ForeColor = System.Drawing.Color.Gray;
            this.lbPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPosition.Location = new System.Drawing.Point(55, 32);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(23, 13);
            this.lbPosition.TabIndex = 28;
            this.lbPosition.Text = "----";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(54, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(40, 21);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "-----";
            // 
            // ptbSmallAvatar
            // 
            this.ptbSmallAvatar.Image = global::TutteeFrame2.Properties.Resources.default_avatar;
            this.ptbSmallAvatar.Location = new System.Drawing.Point(13, 12);
            this.ptbSmallAvatar.Name = "ptbSmallAvatar";
            this.ptbSmallAvatar.Size = new System.Drawing.Size(32, 32);
            this.ptbSmallAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSmallAvatar.TabIndex = 0;
            this.ptbSmallAvatar.TabStop = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(38, 55);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(175, 1);
            this.materialDivider2.TabIndex = 12;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnInformation
            // 
            this.btnInformation.EffectType = MaterialSurface.ET.Custom;
            this.btnInformation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.Black;
            this.btnInformation.Icon = null;
            this.btnInformation.Location = new System.Drawing.Point(8, 72);
            this.btnInformation.MouseState = MaterialSurface.MouseState.OUT;
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.PrimaryColor = System.Drawing.Color.Black;
            this.btnInformation.Radius = 8;
            this.btnInformation.Size = new System.Drawing.Size(252, 40);
            this.btnInformation.TabIndex = 11;
            this.btnInformation.Text = "Thông tin cá nhân";
            this.btnInformation.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnInformation.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.EffectType = MaterialSurface.ET.Custom;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Icon = null;
            this.btnSetting.Location = new System.Drawing.Point(9, 113);
            this.btnSetting.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PrimaryColor = System.Drawing.Color.Black;
            this.btnSetting.Radius = 8;
            this.btnSetting.Size = new System.Drawing.Size(252, 40);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.EffectType = MaterialSurface.ET.Custom;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Icon = null;
            this.btnChangePass.Location = new System.Drawing.Point(8, 154);
            this.btnChangePass.MouseState = MaterialSurface.MouseState.OUT;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.PrimaryColor = System.Drawing.Color.Black;
            this.btnChangePass.Radius = 8;
            this.btnChangePass.Size = new System.Drawing.Size(252, 40);
            this.btnChangePass.TabIndex = 9;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.OnChangePassword);
            // 
            // btnShowMore
            // 
            this.btnShowMore.AutoSize = false;
            this.btnShowMore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMore.Depth = 0;
            this.btnShowMore.DrawShadows = false;
            this.btnShowMore.HighEmphasis = false;
            this.btnShowMore.Icon = ((System.Drawing.Image)(resources.GetObject("btnShowMore.Icon")));
            this.btnShowMore.Location = new System.Drawing.Point(213, 10);
            this.btnShowMore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowMore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(42, 32);
            this.btnShowMore.TabIndex = 8;
            this.btnShowMore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnShowMore.UseAccentColor = false;
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.OpenUtilityBar);
            // 
            // HomeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.utilityBar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainDrawer);
            this.Controls.Add(this.mainProgressbar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TutteeFrame 2.0";
            this.mainTabControl.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatarBig)).EndInit();
            this.quanLiGiaoVien.ResumeLayout(false);
            this.quanLiHocSinh.ResumeLayout(false);
            this.quanLiMon.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.utilityBar.ResumeLayout(false);
            this.utilityBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSmallAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.TextButton btnLogout;
        private MaterialSkin.Controls.MaterialDrawer mainDrawer;
        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage quanLiGiaoVien;
        private System.Windows.Forms.TabPage quanLiHocSinh;
        private System.Windows.Forms.TabPage bangDiemHocSinh;
        private System.Windows.Forms.TabPage quanLiMon;
        private System.Windows.Forms.TabPage quanLiLop;
        private System.Windows.Forms.TabPage quanLiKiLuat;
        private System.Windows.Forms.TabPage baoCao;
        private System.Windows.Forms.TabPage lopChuNhiem;
        private System.Windows.Forms.TabPage phanCongGiaoVien;
        private System.Windows.Forms.TabPage quanLiViPham;
        private System.Windows.Forms.TabPage quanLiTKB;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSurface.MaterialCard utilityBar;
        private MaterialSkin.Controls.MaterialButton btnShowMore;
        private MaterialSurface.TextButton btnInformation;
        private MaterialSurface.TextButton btnSetting;
        private MaterialSurface.TextButton btnChangePass;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox ptbSmallAvatar;
        private System.Windows.Forms.Label lbPositionBig;
        private System.Windows.Forms.Label lbNameBig;
        private System.Windows.Forms.PictureBox ptbAvatarBig;
        private MaterialSurface.MaterialCard materialCard2;
        private System.Windows.Forms.Label label2;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSurface.ChoiceChip choiceChip6;
        private MaterialSurface.ChoiceChip choiceChip7;
        private MaterialSurface.ChoiceChip choiceChip4;
        private MaterialSurface.ChoiceChip choiceChip5;
        private MaterialSurface.ChoiceChip choiceChip3;
        private MaterialSurface.ChoiceChip choiceChip2;
        private MaterialSurface.ChoiceChip choiceChip1;
        private System.Windows.Forms.Label label1;
        private MaterialSurface.ChoiceChip choiceChip8;
        private MaterialSurface.ChoiceChip choiceChip9;
        private System.Windows.Forms.TabPage quanLiLichHop;
        private TeacherView teacherView1;
        private SubjectView subjectView;
        private StudentView studentView;
    }
}

