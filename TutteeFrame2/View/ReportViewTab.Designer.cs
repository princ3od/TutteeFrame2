
namespace TutteeFrame2.View
{
    partial class ReportViewTab
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
            this.btnChart = new MaterialSurface.ContainedButton();
            this.btnPrint = new MaterialSurface.ContainedButton();
            this.btnPrintResluts = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // btnChart
            // 
            this.btnChart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnChart.BackColor = System.Drawing.Color.White;
            this.btnChart.EffectType = MaterialSurface.ET.Custom;
            this.btnChart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnChart.Icon = null;
            this.btnChart.Location = new System.Drawing.Point(26, 225);
            this.btnChart.Margin = new System.Windows.Forms.Padding(2);
            this.btnChart.MouseState = MaterialSurface.MouseState.OUT;
            this.btnChart.Name = "btnChart";
            this.btnChart.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnChart.Radius = 2;
            this.btnChart.ShawdowDepth = 3;
            this.btnChart.ShawdowOpacity = 50;
            this.btnChart.Size = new System.Drawing.Size(156, 50);
            this.btnChart.TabIndex = 42;
            this.btnChart.Text = "Xuất Biểu Đồ";
            this.btnChart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.EffectType = MaterialSurface.ET.Custom;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(293, 225);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.MouseState = MaterialSurface.MouseState.OUT;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnPrint.Radius = 2;
            this.btnPrint.ShawdowDepth = 3;
            this.btnPrint.ShawdowOpacity = 50;
            this.btnPrint.Size = new System.Drawing.Size(155, 50);
            this.btnPrint.TabIndex = 43;
            this.btnPrint.Text = "In Danh Sách";
            this.btnPrint.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintResluts
            // 
            this.btnPrintResluts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrintResluts.BackColor = System.Drawing.Color.White;
            this.btnPrintResluts.EffectType = MaterialSurface.ET.Custom;
            this.btnPrintResluts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintResluts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnPrintResluts.Icon = null;
            this.btnPrintResluts.Location = new System.Drawing.Point(559, 225);
            this.btnPrintResluts.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintResluts.MouseState = MaterialSurface.MouseState.OUT;
            this.btnPrintResluts.Name = "btnPrintResluts";
            this.btnPrintResluts.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnPrintResluts.Radius = 2;
            this.btnPrintResluts.ShawdowDepth = 3;
            this.btnPrintResluts.ShawdowOpacity = 50;
            this.btnPrintResluts.Size = new System.Drawing.Size(161, 50);
            this.btnPrintResluts.TabIndex = 44;
            this.btnPrintResluts.Text = "In Bảng Điểm";
            this.btnPrintResluts.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPrintResluts.UseVisualStyleBackColor = false;
            this.btnPrintResluts.Click += new System.EventHandler(this.btnPrintResluts_Click);
            // 
            // ReportViewTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrintResluts);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnChart);
            this.Name = "ReportViewTag";
            this.Size = new System.Drawing.Size(784, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.ContainedButton btnChart;
        private MaterialSurface.ContainedButton btnPrint;
        private MaterialSurface.ContainedButton btnPrintResluts;
    }
}
