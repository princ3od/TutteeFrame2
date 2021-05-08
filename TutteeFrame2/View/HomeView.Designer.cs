
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
            this.textButton1 = new MaterialSurface.TextButton();
            this.SuspendLayout();
            // 
            // textButton1
            // 
            this.textButton1.EffectType = MaterialSurface.ET.Custom;
            this.textButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton1.ForeColor = System.Drawing.Color.BlueViolet;
            this.textButton1.Icon = null;
            this.textButton1.Location = new System.Drawing.Point(201, 171);
            this.textButton1.MouseState = MaterialSurface.MouseState.OUT;
            this.textButton1.Name = "textButton1";
            this.textButton1.PrimaryColor = System.Drawing.Color.BlueViolet;
            this.textButton1.Radius = 6;
            this.textButton1.Size = new System.Drawing.Size(160, 40);
            this.textButton1.TabIndex = 0;
            this.textButton1.Text = "Đăng xuất";
            this.textButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.textButton1.UseVisualStyleBackColor = true;
            this.textButton1.Click += new System.EventHandler(this.OnLogout);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textButton1);
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TutteeFrame 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.TextButton textButton1;
    }
}

