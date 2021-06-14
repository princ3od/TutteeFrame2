
namespace TutteeFrame2.View
{
    partial class StudentScoreboardView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTeachingSubject = new MaterialSkin.Controls.MaterialLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotalTeachingClass = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEditable = new System.Windows.Forms.Label();
            this.lbScoreTittle = new System.Windows.Forms.Label();
            this.gridviewStudentScore = new System.Windows.Forms.DataGridView();
            this.clmStt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.cbbFilterByClass = new MaterialSurface.MaterialComboBox();
            this.cbbFilterBySemester = new MaterialSurface.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(629, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(453, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "*Quý thầy cô sau khi cập nhật vui lòng bấm nút \"Cập nhật điểm\" ở dưới.";
            // 
            // lbTeachingSubject
            // 
            this.lbTeachingSubject.AutoSize = true;
            this.lbTeachingSubject.Depth = 0;
            this.lbTeachingSubject.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTeachingSubject.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTeachingSubject.HighEmphasis = true;
            this.lbTeachingSubject.Location = new System.Drawing.Point(17, 33);
            this.lbTeachingSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTeachingSubject.Name = "lbTeachingSubject";
            this.lbTeachingSubject.Size = new System.Drawing.Size(15, 24);
            this.lbTeachingSubject.TabIndex = 31;
            this.lbTeachingSubject.Text = "--";
            this.lbTeachingSubject.UseAccent = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(5, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Môn giảng dạy";
            // 
            // lbTotalTeachingClass
            // 
            this.lbTotalTeachingClass.AutoSize = true;
            this.lbTotalTeachingClass.Depth = 0;
            this.lbTotalTeachingClass.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbTotalTeachingClass.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbTotalTeachingClass.HighEmphasis = true;
            this.lbTotalTeachingClass.Location = new System.Drawing.Point(183, 33);
            this.lbTotalTeachingClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTotalTeachingClass.Name = "lbTotalTeachingClass";
            this.lbTotalTeachingClass.Size = new System.Drawing.Size(15, 24);
            this.lbTotalTeachingClass.TabIndex = 29;
            this.lbTotalTeachingClass.Text = "--";
            this.lbTotalTeachingClass.UseAccent = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(171, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tổng số lớp đang dạy";
            // 
            // lbEditable
            // 
            this.lbEditable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbEditable.AutoSize = true;
            this.lbEditable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEditable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbEditable.Location = new System.Drawing.Point(17, 501);
            this.lbEditable.Name = "lbEditable";
            this.lbEditable.Size = new System.Drawing.Size(170, 21);
            this.lbEditable.TabIndex = 35;
            this.lbEditable.Text = "Bảng điểm chưa khóa.";
            // 
            // lbScoreTittle
            // 
            this.lbScoreTittle.AutoSize = true;
            this.lbScoreTittle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.lbScoreTittle.Location = new System.Drawing.Point(16, 76);
            this.lbScoreTittle.Name = "lbScoreTittle";
            this.lbScoreTittle.Size = new System.Drawing.Size(372, 25);
            this.lbScoreTittle.TabIndex = 34;
            this.lbScoreTittle.Text = "Bảng điểm lớp -- - môn -- - HK -- - năm ----";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewStudentScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudentScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStt,
            this.clmID,
            this.clmName,
            this.clmQuiz,
            this.clmFifteen1,
            this.clmFifteen2,
            this.clmFifteen3,
            this.clmFortyfive1,
            this.clmFortyfive2,
            this.clmFortyfive3,
            this.clmFinal,
            this.clmAverage});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewStudentScore.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewStudentScore.GridColor = System.Drawing.Color.Black;
            this.gridviewStudentScore.Location = new System.Drawing.Point(6, 106);
            this.gridviewStudentScore.Name = "gridviewStudentScore";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewStudentScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewStudentScore.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridviewStudentScore.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewStudentScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridviewStudentScore.Size = new System.Drawing.Size(1089, 389);
            this.gridviewStudentScore.TabIndex = 33;
            this.gridviewStudentScore.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnScoreUpdated);
            this.gridviewStudentScore.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.OnlyNumberCell);
            // 
            // clmStt
            // 
            this.clmStt.Frozen = true;
            this.clmStt.HeaderText = "STT";
            this.clmStt.Name = "clmStt";
            this.clmStt.Width = 40;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "Mã học sinh";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 105;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Họ tên";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 220;
            // 
            // clmQuiz
            // 
            this.clmQuiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQuiz.HeaderText = "Điểm miệng";
            this.clmQuiz.Name = "clmQuiz";
            // 
            // clmFifteen1
            // 
            this.clmFifteen1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen1.HeaderText = "Điểm 15p_1";
            this.clmFifteen1.Name = "clmFifteen1";
            this.clmFifteen1.ToolTipText = "Hệ số 1";
            // 
            // clmFifteen2
            // 
            this.clmFifteen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen2.HeaderText = "Điểm 15p_2";
            this.clmFifteen2.Name = "clmFifteen2";
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
            this.clmFortyfive1.ToolTipText = "Hệ số 2";
            // 
            // clmFortyfive2
            // 
            this.clmFortyfive2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive2.HeaderText = "Điểm 1tiết_2";
            this.clmFortyfive2.Name = "clmFortyfive2";
            this.clmFortyfive2.ToolTipText = "Hệ số 2";
            // 
            // clmFortyfive3
            // 
            this.clmFortyfive3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive3.HeaderText = "Điểm 1tiết_3";
            this.clmFortyfive3.Name = "clmFortyfive3";
            this.clmFortyfive3.ToolTipText = "Hệ số 2";
            // 
            // clmFinal
            // 
            this.clmFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFinal.HeaderText = "Điểm cuối kì";
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ToolTipText = "Hệ số 3";
            // 
            // clmAverage
            // 
            this.clmAverage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAverage.HeaderText = "Điểm trung bình";
            this.clmAverage.Name = "clmAverage";
            this.clmAverage.ReadOnly = true;
            this.clmAverage.ToolTipText = "Điểm trung bình môn ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(728, 501);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(228, 50);
            this.btnSubmit.TabIndex = 67;
            this.btnSubmit.Text = "CẬP NHẬT ĐIỂM";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnUpdate);
            // 
            // cbbFilterByClass
            // 
            this.cbbFilterByClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFilterByClass.AutoSizing = false;
            this.cbbFilterByClass.ComboBoxType = MaterialSurface.BoxType.Filled;
            this.cbbFilterByClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbFilterByClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterByClass.DropDownWidth = 121;
            this.cbbFilterByClass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbFilterByClass.FormattingEnabled = true;
            this.cbbFilterByClass.HintText = "Lớp giảng dạy";
            this.cbbFilterByClass.ItemHeight = 41;
            this.cbbFilterByClass.Items.AddRange(new object[] {
            "Tất cả",
            "10",
            "11",
            "12"});
            this.cbbFilterByClass.Location = new System.Drawing.Point(804, 54);
            this.cbbFilterByClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterByClass.MaxDropDownItems = 4;
            this.cbbFilterByClass.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterByClass.Name = "cbbFilterByClass";
            this.cbbFilterByClass.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterByClass.Size = new System.Drawing.Size(166, 47);
            this.cbbFilterByClass.TabIndex = 68;
            this.cbbFilterByClass.SelectedIndexChanged += new System.EventHandler(this.OnChangeClass);
            // 
            // cbbFilterBySemester
            // 
            this.cbbFilterBySemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFilterBySemester.AutoSizing = false;
            this.cbbFilterBySemester.ComboBoxType = MaterialSurface.BoxType.Filled;
            this.cbbFilterBySemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbFilterBySemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilterBySemester.DropDownWidth = 121;
            this.cbbFilterBySemester.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbbFilterBySemester.FormattingEnabled = true;
            this.cbbFilterBySemester.HintText = "Học kỳ";
            this.cbbFilterBySemester.ItemHeight = 41;
            this.cbbFilterBySemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbFilterBySemester.Location = new System.Drawing.Point(974, 54);
            this.cbbFilterBySemester.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFilterBySemester.MaxDropDownItems = 4;
            this.cbbFilterBySemester.MouseState = MaterialSurface.MouseState.OUT;
            this.cbbFilterBySemester.Name = "cbbFilterBySemester";
            this.cbbFilterBySemester.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbbFilterBySemester.Size = new System.Drawing.Size(108, 47);
            this.cbbFilterBySemester.TabIndex = 69;
            this.cbbFilterBySemester.SelectedIndexChanged += new System.EventHandler(this.OnChangeSemester);
            // 
            // StudentScoreboardView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbbFilterBySemester);
            this.Controls.Add(this.cbbFilterByClass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbEditable);
            this.Controls.Add(this.lbScoreTittle);
            this.Controls.Add(this.gridviewStudentScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTeachingSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalTeachingClass);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "StudentScoreboardView";
            this.Size = new System.Drawing.Size(1100, 560);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialLabel lbTeachingSubject;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialLabel lbTotalTeachingClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEditable;
        private System.Windows.Forms.Label lbScoreTittle;
        private System.Windows.Forms.DataGridView gridviewStudentScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
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
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.MaterialComboBox cbbFilterByClass;
        private MaterialSurface.MaterialComboBox cbbFilterBySemester;
    }
}
