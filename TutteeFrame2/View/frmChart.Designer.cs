
namespace TutteeFrame2.View
{
    partial class frmChart
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
            this.btnGenarate = new MaterialSurface.ContainedButton();
            this.cbbType = new MaterialSurface.MaterialComboBox();
            this.cbbGrade = new MaterialSurface.MaterialComboBox();
            this.cbbClass = new MaterialSurface.MaterialComboBox();
            this.cbbSemester = new MaterialSurface.MaterialComboBox();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.lbInformation = new System.Windows.Forms.Label();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.SuspendLayout();
            // 
            // btnGenarate
            // 
            this.btnGenarate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenarate.BackColor = System.Drawing.Color.White;
            this.btnGenarate.EffectType = MaterialSurface.ET.Custom;
            this.btnGenarate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnGenarate.Icon = null;
            this.btnGenarate.Location = new System.Drawing.Point(917, 655);
            this.btnGenarate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenarate.MouseState = MaterialSurface.MouseState.OUT;
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnGenarate.Radius = 2;
            this.btnGenarate.ShawdowDepth = 3;
            this.btnGenarate.ShawdowOpacity = 50;
            this.btnGenarate.Size = new System.Drawing.Size(142, 50);
            this.btnGenarate.TabIndex = 69;
            this.btnGenarate.Text = "Khởi tạo";
            this.btnGenarate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnGenarate.UseVisualStyleBackColor = false;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbType.AutoSizing = false;
            this.cbbType.ComboBoxType = MaterialSurface.BoxType.Outlined;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.DropDownWidth = 121;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.HintText = "Loại Biểu Đồ";
            this.cbbType.ItemHeight = 38;
            this.cbbType.Items.AddRange(new object[] {
            "TBHK Lớp",
            "TBHK Khối",
            "TBHK Môn-Lớp"});
            this.cbbType.Location = new System.Drawing.Point(11, 63);
            this.cbbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbType.MaxDropDownItems = 4;
            this.cbbType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbType.Name = "cbbType";
            this.cbbType.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbType.Size = new System.Drawing.Size(203, 44);
            this.cbbType.TabIndex = 70;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // cbbGrade
            // 
            this.cbbGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbGrade.AutoSizing = false;
            this.cbbGrade.ComboBoxType = MaterialSurface.BoxType.Outlined;
            this.cbbGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGrade.DropDownWidth = 121;
            this.cbbGrade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGrade.FormattingEnabled = true;
            this.cbbGrade.HintText = "Khối";
            this.cbbGrade.ItemHeight = 38;
            this.cbbGrade.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbbGrade.Location = new System.Drawing.Point(11, 148);
            this.cbbGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGrade.MaxDropDownItems = 4;
            this.cbbGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbGrade.Size = new System.Drawing.Size(199, 44);
            this.cbbGrade.TabIndex = 70;
            this.cbbGrade.SelectedIndexChanged += new System.EventHandler(this.cbbGrade_SelectedIndexChanged);
            // 
            // cbbClass
            // 
            this.cbbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbClass.AutoSizing = false;
            this.cbbClass.ComboBoxType = MaterialSurface.BoxType.Outlined;
            this.cbbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.DropDownWidth = 121;
            this.cbbClass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.HintText = "Lớp";
            this.cbbClass.ItemHeight = 38;
            this.cbbClass.Location = new System.Drawing.Point(11, 237);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbbClass.MaxDropDownItems = 4;
            this.cbbClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbClass.Size = new System.Drawing.Size(199, 44);
            this.cbbClass.TabIndex = 71;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.cbbClass_SelectedIndexChanged);
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbSemester.AutoSizing = false;
            this.cbbSemester.ComboBoxType = MaterialSurface.BoxType.Outlined;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.DropDownWidth = 121;
            this.cbbSemester.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.HintText = "Học kì";
            this.cbbSemester.ItemHeight = 38;
            this.cbbSemester.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2",
            "Cả năm"});
            this.cbbSemester.Location = new System.Drawing.Point(11, 325);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSemester.Size = new System.Drawing.Size(199, 44);
            this.cbbSemester.TabIndex = 71;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart.Location = new System.Drawing.Point(268, 23);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(815, 602);
            this.cartesianChart.TabIndex = 72;
            this.cartesianChart.Text = "cartesianChart";
            // 
            // lbInformation
            // 
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(0, 708);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(103, 19);
            this.lbInformation.TabIndex = 74;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.ChangeDelay = 70;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(0, 727);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(1095, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 73;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 36;
            this.mainProgressbar.Visible = false;
            // 
            // frmChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1095, 733);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.cartesianChart);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbGrade);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnGenarate);
            this.Name = "frmChart";
            this.Text = "frmChartcs";
            this.Load += new System.EventHandler(this.frmChart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSurface.ContainedButton btnGenarate;
        private MaterialSurface.MaterialComboBox cbbType;
        private MaterialSurface.MaterialComboBox cbbGrade;
        private MaterialSurface.MaterialComboBox cbbClass;
        private MaterialSurface.MaterialComboBox cbbSemester;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
    }
}