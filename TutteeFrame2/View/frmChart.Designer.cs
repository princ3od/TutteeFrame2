
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnGenarate = new MaterialSurface.ContainedButton();
            this.cbbType = new MaterialSurface.MaterialComboBox();
            this.cbbGrade = new MaterialSurface.MaterialComboBox();
            this.cbbClass = new MaterialSurface.MaterialComboBox();
            this.cbbSemester = new MaterialSurface.MaterialComboBox();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Depth = 0;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = ((System.Drawing.Image)(resources.GetObject("btnExit.Icon")));
            this.btnExit.Location = new System.Drawing.Point(1032, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 66;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnGenarate
            // 
            this.btnGenarate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenarate.BackColor = System.Drawing.Color.White;
            this.btnGenarate.EffectType = MaterialSurface.ET.Custom;
            this.btnGenarate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnGenarate.Icon = null;
            this.btnGenarate.Location = new System.Drawing.Point(873, 615);
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
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbType.AutoSizing = false;
            this.cbbType.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.DropDownWidth = 121;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbType.FormattingEnabled = true;
            this.cbbType.HintText = "Loại Biểu Đồ";
            this.cbbType.ItemHeight = 41;
            this.cbbType.Items.AddRange(new object[] {
            "TBHK Lớp ",
            "TBHK Khối",
            "TBHK Môn-Lớp"});
            this.cbbType.Location = new System.Drawing.Point(11, 131);
            this.cbbType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbType.MaxDropDownItems = 4;
            this.cbbType.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbType.Name = "cbbType";
            this.cbbType.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbType.Size = new System.Drawing.Size(195, 47);
            this.cbbType.TabIndex = 70;
            // 
            // cbbGrade
            // 
            this.cbbGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbGrade.AutoSizing = false;
            this.cbbGrade.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGrade.DropDownWidth = 121;
            this.cbbGrade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbGrade.FormattingEnabled = true;
            this.cbbGrade.HintText = "Khối";
            this.cbbGrade.ItemHeight = 41;
            this.cbbGrade.Items.AddRange(new object[] {
            "Khối 10",
            "Khối 11",
            "Khối 12"});
            this.cbbGrade.Location = new System.Drawing.Point(11, 216);
            this.cbbGrade.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGrade.MaxDropDownItems = 4;
            this.cbbGrade.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbGrade.Size = new System.Drawing.Size(195, 47);
            this.cbbGrade.TabIndex = 70;
            // 
            // cbbClass
            // 
            this.cbbClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbClass.AutoSizing = false;
            this.cbbClass.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.DropDownWidth = 121;
            this.cbbClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.HintText = "Lớp";
            this.cbbClass.ItemHeight = 41;
            this.cbbClass.Location = new System.Drawing.Point(11, 305);
            this.cbbClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbbClass.MaxDropDownItems = 4;
            this.cbbClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbClass.Size = new System.Drawing.Size(195, 47);
            this.cbbClass.TabIndex = 71;
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.AutoSizing = false;
            this.cbbSemester.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.DropDownWidth = 121;
            this.cbbSemester.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.HintText = "Học kì";
            this.cbbSemester.ItemHeight = 41;
            this.cbbSemester.Items.AddRange(new object[] {
            "Học kì 1",
            "Học kì 2"});
            this.cbbSemester.Location = new System.Drawing.Point(11, 393);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSemester.Size = new System.Drawing.Size(195, 47);
            this.cbbSemester.TabIndex = 71;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(285, 63);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(780, 513);
            this.cartesianChart.TabIndex = 72;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 687);
            this.Controls.Add(this.cartesianChart);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbGrade);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChart";
            this.Text = "frmChartcs";
            this.Load += new System.EventHandler(this.frmChart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSurface.ContainedButton btnGenarate;
        private MaterialSurface.MaterialComboBox cbbType;
        private MaterialSurface.MaterialComboBox cbbGrade;
        private MaterialSurface.MaterialComboBox cbbClass;
        private MaterialSurface.MaterialComboBox cbbSemester;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
    }
}