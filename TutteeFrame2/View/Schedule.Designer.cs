
namespace TutteeFrame2.View
{
    partial class Schedule
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.containedButton2 = new MaterialSurface.ContainedButton();
            this.materialComboBox6 = new MaterialSurface.MaterialComboBox();
            this.materialComboBox4 = new MaterialSurface.MaterialComboBox();
            this.materialComboBox5 = new MaterialSurface.MaterialComboBox();
            this.containedButton1 = new MaterialSurface.ContainedButton();
            this.materialComboBox3 = new MaterialSurface.MaterialComboBox();
            this.materialComboBox2 = new MaterialSurface.MaterialComboBox();
            this.materialComboBox1 = new MaterialSurface.MaterialComboBox();
            this.containedButton3 = new MaterialSurface.ContainedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(306, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // containedButton2
            // 
            this.containedButton2.EffectType = MaterialSurface.ET.Custom;
            this.containedButton2.Enabled = false;
            this.containedButton2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.containedButton2.Icon = null;
            this.containedButton2.Location = new System.Drawing.Point(116, 327);
            this.containedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.containedButton2.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton2.Name = "containedButton2";
            this.containedButton2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.containedButton2.Radius = 2;
            this.containedButton2.ShawdowDepth = 3;
            this.containedButton2.ShawdowOpacity = 50;
            this.containedButton2.Size = new System.Drawing.Size(100, 50);
            this.containedButton2.TabIndex = 53;
            this.containedButton2.Text = "Xóa";
            this.containedButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton2.UseVisualStyleBackColor = true;
            this.containedButton2.Click += new System.EventHandler(this.containedButton2_Click);
            // 
            // materialComboBox6
            // 
            this.materialComboBox6.AutoSizing = false;
            this.materialComboBox6.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox6.DropDownWidth = 121;
            this.materialComboBox6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox6.FormattingEnabled = true;
            this.materialComboBox6.HintText = "Môn";
            this.materialComboBox6.ItemHeight = 41;
            this.materialComboBox6.Location = new System.Drawing.Point(31, 223);
            this.materialComboBox6.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox6.MaxDropDownItems = 4;
            this.materialComboBox6.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox6.Name = "materialComboBox6";
            this.materialComboBox6.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.materialComboBox6.Size = new System.Drawing.Size(102, 47);
            this.materialComboBox6.TabIndex = 48;
            this.materialComboBox6.SelectedIndexChanged += new System.EventHandler(this.materialComboBox6_SelectedIndexChanged);
            // 
            // materialComboBox4
            // 
            this.materialComboBox4.AutoSizing = false;
            this.materialComboBox4.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox4.DropDownWidth = 121;
            this.materialComboBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox4.FormattingEnabled = true;
            this.materialComboBox4.HintText = "Thứ";
            this.materialComboBox4.ItemHeight = 41;
            this.materialComboBox4.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.materialComboBox4.Location = new System.Drawing.Point(31, 90);
            this.materialComboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox4.MaxDropDownItems = 4;
            this.materialComboBox4.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox4.Name = "materialComboBox4";
            this.materialComboBox4.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.materialComboBox4.Size = new System.Drawing.Size(102, 47);
            this.materialComboBox4.TabIndex = 49;
            this.materialComboBox4.SelectedIndexChanged += new System.EventHandler(this.materialComboBox4_SelectedIndexChanged);
            // 
            // materialComboBox5
            // 
            this.materialComboBox5.AutoSizing = false;
            this.materialComboBox5.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox5.DropDownWidth = 121;
            this.materialComboBox5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox5.FormattingEnabled = true;
            this.materialComboBox5.HintText = "Tiết";
            this.materialComboBox5.ItemHeight = 41;
            this.materialComboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.materialComboBox5.Location = new System.Drawing.Point(31, 155);
            this.materialComboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox5.MaxDropDownItems = 4;
            this.materialComboBox5.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox5.Name = "materialComboBox5";
            this.materialComboBox5.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.materialComboBox5.Size = new System.Drawing.Size(102, 47);
            this.materialComboBox5.TabIndex = 50;
            this.materialComboBox5.SelectedIndexChanged += new System.EventHandler(this.materialComboBox4_SelectedIndexChanged);
            // 
            // containedButton1
            // 
            this.containedButton1.EffectType = MaterialSurface.ET.Custom;
            this.containedButton1.Enabled = false;
            this.containedButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.containedButton1.Icon = null;
            this.containedButton1.Location = new System.Drawing.Point(12, 327);
            this.containedButton1.Margin = new System.Windows.Forms.Padding(2);
            this.containedButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton1.Name = "containedButton1";
            this.containedButton1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.containedButton1.Radius = 2;
            this.containedButton1.ShawdowDepth = 3;
            this.containedButton1.ShawdowOpacity = 50;
            this.containedButton1.Size = new System.Drawing.Size(100, 50);
            this.containedButton1.TabIndex = 51;
            this.containedButton1.Text = "OK";
            this.containedButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton1.UseVisualStyleBackColor = true;
            this.containedButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialComboBox3
            // 
            this.materialComboBox3.AutoSizing = false;
            this.materialComboBox3.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox3.DropDownWidth = 121;
            this.materialComboBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox3.FormattingEnabled = true;
            this.materialComboBox3.HintText = "Lớp";
            this.materialComboBox3.ItemHeight = 41;
            this.materialComboBox3.Location = new System.Drawing.Point(306, 21);
            this.materialComboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox3.MaxDropDownItems = 4;
            this.materialComboBox3.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox3.Name = "materialComboBox3";
            this.materialComboBox3.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.materialComboBox3.Size = new System.Drawing.Size(102, 47);
            this.materialComboBox3.TabIndex = 46;
            this.materialComboBox3.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoSizing = false;
            this.materialComboBox2.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.HintText = "Khối";
            this.materialComboBox2.ItemHeight = 41;
            this.materialComboBox2.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.materialComboBox2.Location = new System.Drawing.Point(173, 21);
            this.materialComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.materialComboBox2.Size = new System.Drawing.Size(102, 47);
            this.materialComboBox2.TabIndex = 46;
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoSizing = false;
            this.materialComboBox1.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.HintText = "HK";
            this.materialComboBox1.ItemHeight = 41;
            this.materialComboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.materialComboBox1.Location = new System.Drawing.Point(51, 21);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.materialComboBox1.Size = new System.Drawing.Size(102, 47);
            this.materialComboBox1.TabIndex = 45;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // containedButton3
            // 
            this.containedButton3.EffectType = MaterialSurface.ET.Custom;
            this.containedButton3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containedButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.containedButton3.Icon = null;
            this.containedButton3.Location = new System.Drawing.Point(767, 21);
            this.containedButton3.Margin = new System.Windows.Forms.Padding(2);
            this.containedButton3.MouseState = MaterialSurface.MouseState.OUT;
            this.containedButton3.Name = "containedButton3";
            this.containedButton3.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.containedButton3.Radius = 2;
            this.containedButton3.ShawdowDepth = 3;
            this.containedButton3.ShawdowOpacity = 50;
            this.containedButton3.Size = new System.Drawing.Size(100, 50);
            this.containedButton3.TabIndex = 54;
            this.containedButton3.Text = "Xuất";
            this.containedButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.containedButton3.UseVisualStyleBackColor = true;
            this.containedButton3.Click += new System.EventHandler(this.containedButton3_Click);
            // 
            // Schedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.containedButton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.containedButton2);
            this.Controls.Add(this.containedButton1);
            this.Controls.Add(this.materialComboBox6);
            this.Controls.Add(this.materialComboBox5);
            this.Controls.Add(this.materialComboBox4);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialComboBox3);
            this.Controls.Add(this.materialComboBox2);
            this.DoubleBuffered = true;
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(1116, 558);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSurface.ContainedButton containedButton2;
        private MaterialSurface.MaterialComboBox materialComboBox6;
        private MaterialSurface.MaterialComboBox materialComboBox4;
        private MaterialSurface.MaterialComboBox materialComboBox5;
        private MaterialSurface.ContainedButton containedButton1;
        private MaterialSurface.MaterialComboBox materialComboBox3;
        private MaterialSurface.MaterialComboBox materialComboBox2;
        private MaterialSurface.MaterialComboBox materialComboBox1;
        private MaterialSurface.ContainedButton containedButton3;
    }
}
