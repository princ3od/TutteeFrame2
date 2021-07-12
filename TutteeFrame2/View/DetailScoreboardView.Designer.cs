
namespace TutteeFrame2.View
{
    partial class DetailScoreboardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailScoreboardView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.lbLearningCapacityYear = new System.Windows.Forms.Label();
            this.lbLearningCapacitySem = new System.Windows.Forms.Label();
            this.lbScoreTittle = new System.Windows.Forms.Label();
            this.gridviewStudentScore = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFifteen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFifteen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFifteen3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFortyfive1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFortyfive2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFortyfive3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbSemester = new MaterialSurface.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = false;
            this.btnClose.HighEmphasis = false;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(906, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 43;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 494);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(952, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 74;
            this.mainProgressbar.Text = "materialProgressbar1";
            this.mainProgressbar.Type = MaterialSurface.MaterialProgressbar.ProgressBarType.Normal;
            this.mainProgressbar.Value = 32;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(5, 478);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(117, 13);
            this.lbInformation.TabIndex = 73;
            this.lbInformation.Text = "*Đang tải thông tin...";
            this.lbInformation.Visible = false;
            // 
            // lbLearningCapacityYear
            // 
            this.lbLearningCapacityYear.AutoSize = true;
            this.lbLearningCapacityYear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbLearningCapacityYear.Location = new System.Drawing.Point(27, 442);
            this.lbLearningCapacityYear.Name = "lbLearningCapacityYear";
            this.lbLearningCapacityYear.Size = new System.Drawing.Size(376, 21);
            this.lbLearningCapacityYear.TabIndex = 78;
            this.lbLearningCapacityYear.Text = "Điểm trung bình cả năm : ---- - Học lực cả năm: ----\r\n";
            // 
            // lbLearningCapacitySem
            // 
            this.lbLearningCapacitySem.AutoSize = true;
            this.lbLearningCapacitySem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbLearningCapacitySem.Location = new System.Drawing.Point(27, 419);
            this.lbLearningCapacitySem.Name = "lbLearningCapacitySem";
            this.lbLearningCapacitySem.Size = new System.Drawing.Size(304, 21);
            this.lbLearningCapacitySem.TabIndex = 77;
            this.lbLearningCapacitySem.Text = "Điểm trung bình HK --: ---- - Học lực: ----\r\n";
            // 
            // lbScoreTittle
            // 
            this.lbScoreTittle.AutoSize = true;
            this.lbScoreTittle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbScoreTittle.Location = new System.Drawing.Point(12, 65);
            this.lbScoreTittle.Name = "lbScoreTittle";
            this.lbScoreTittle.Size = new System.Drawing.Size(384, 21);
            this.lbScoreTittle.TabIndex = 76;
            this.lbScoreTittle.Text = "Bảng điểm của học sinh ---- (------) - HK -- - năm ----";
            // 
            // gridviewStudentScore
            // 
            this.gridviewStudentScore.AllowUserToAddRows = false;
            this.gridviewStudentScore.AllowUserToDeleteRows = false;
            this.gridviewStudentScore.AllowUserToResizeRows = false;
            this.gridviewStudentScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewStudentScore.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridviewStudentScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewStudentScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridviewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudentScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmQuiz,
            this.clmFifteen1,
            this.clmFifteen2,
            this.clmFifteen3,
            this.clmFortyfive1,
            this.clmFortyfive2,
            this.clmFortyfive3,
            this.clmFinal,
            this.clmAverage,
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewStudentScore.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridviewStudentScore.GridColor = System.Drawing.Color.Black;
            this.gridviewStudentScore.Location = new System.Drawing.Point(12, 91);
            this.gridviewStudentScore.Name = "gridviewStudentScore";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewStudentScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridviewStudentScore.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridviewStudentScore.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridviewStudentScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridviewStudentScore.Size = new System.Drawing.Size(926, 325);
            this.gridviewStudentScore.TabIndex = 75;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Môn học";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 110;
            // 
            // clmQuiz
            // 
            this.clmQuiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQuiz.FillWeight = 90F;
            this.clmQuiz.HeaderText = "Điểm miệng";
            this.clmQuiz.Name = "clmQuiz";
            this.clmQuiz.ReadOnly = true;
            // 
            // clmFifteen1
            // 
            this.clmFifteen1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen1.HeaderText = "Điểm 15p_1";
            this.clmFifteen1.Name = "clmFifteen1";
            this.clmFifteen1.ReadOnly = true;
            this.clmFifteen1.ToolTipText = "Hệ số 1";
            // 
            // clmFifteen2
            // 
            this.clmFifteen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen2.HeaderText = "Điểm 15p_2";
            this.clmFifteen2.Name = "clmFifteen2";
            this.clmFifteen2.ReadOnly = true;
            this.clmFifteen2.ToolTipText = "Hệ số 1";
            // 
            // clmFifteen3
            // 
            this.clmFifteen3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen3.HeaderText = "Điểm 15p_3";
            this.clmFifteen3.Name = "clmFifteen3";
            this.clmFifteen3.ToolTipText = "Hệ số 1";
            // 
            // clmFortyfive1
            // 
            this.clmFortyfive1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive1.HeaderText = "Điểm 1tiết_1";
            this.clmFortyfive1.Name = "clmFortyfive1";
            this.clmFortyfive1.ReadOnly = true;
            this.clmFortyfive1.ToolTipText = "Hệ số 2";
            // 
            // clmFortyfive2
            // 
            this.clmFortyfive2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive2.HeaderText = "Điểm 1tiết_2";
            this.clmFortyfive2.Name = "clmFortyfive2";
            this.clmFortyfive2.ReadOnly = true;
            this.clmFortyfive2.ToolTipText = "Hệ số 2";
            // 
            // clmFortyfive3
            // 
            this.clmFortyfive3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive3.HeaderText = "Điểm 1tiết_3";
            this.clmFortyfive3.Name = "clmFortyfive3";
            this.clmFortyfive3.ReadOnly = true;
            this.clmFortyfive3.ToolTipText = "Hệ số 2";
            // 
            // clmFinal
            // 
            this.clmFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFinal.FillWeight = 90F;
            this.clmFinal.HeaderText = "Điểm cuối kì";
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ReadOnly = true;
            this.clmFinal.ToolTipText = "Hệ số 3";
            // 
            // clmAverage
            // 
            this.clmAverage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAverage.FillWeight = 110F;
            this.clmAverage.HeaderText = "Điểm trung bình";
            this.clmAverage.Name = "clmAverage";
            this.clmAverage.ReadOnly = true;
            this.clmAverage.ToolTipText = "Điểm trung bình môn ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TB cả năm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.AutoSizing = false;
            this.cbbSemester.ComboBoxType = MaterialSurface.BoxType.Filled;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.DropDownWidth = 121;
            this.cbbSemester.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.HintText = "Học kì";
            this.cbbSemester.ItemHeight = 41;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbSemester.Location = new System.Drawing.Point(748, 39);
            this.cbbSemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbSemester.Size = new System.Drawing.Size(128, 47);
            this.cbbSemester.TabIndex = 79;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.OnSemesterChanged);
            // 
            // DetailScoreboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.lbLearningCapacityYear);
            this.Controls.Add(this.lbLearningCapacitySem);
            this.Controls.Add(this.lbScoreTittle);
            this.Controls.Add(this.gridviewStudentScore);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailScoreboardView";
            this.Text = "DetailScoreboardView";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label lbLearningCapacityYear;
        private System.Windows.Forms.Label lbLearningCapacitySem;
        private System.Windows.Forms.Label lbScoreTittle;
        private System.Windows.Forms.DataGridView gridviewStudentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFifteen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFifteen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFifteen3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFortyfive1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFortyfive2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFortyfive3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MaterialSurface.MaterialComboBox cbbSemester;
    }
}