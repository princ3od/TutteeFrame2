
namespace TutteeFrame2.View
{
    partial class DetailSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailSubject));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.txtNameSubject = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSubjectId = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAccepte = new MaterialSurface.ContainedButton();
            this.btnDenie = new MaterialSurface.ContainedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 41);
            this.label1.TabIndex = 74;
            this.label1.Text = "Môn học";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = true;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(647, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 73;
            this.btnClose.TabStop = false;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNameSubject
            // 
            this.txtNameSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSubject.Depth = 0;
            this.txtNameSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNameSubject.Hint = "Tên môn học";
            this.txtNameSubject.Location = new System.Drawing.Point(28, 86);
            this.txtNameSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSubject.MaxLength = 50;
            this.txtNameSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNameSubject.Multiline = false;
            this.txtNameSubject.Name = "txtNameSubject";
            this.txtNameSubject.Size = new System.Drawing.Size(517, 50);
            this.txtNameSubject.TabIndex = 71;
            this.txtNameSubject.Text = "";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectId.Depth = 0;
            this.txtSubjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSubjectId.Hint = "Mã môn học";
            this.txtSubjectId.Location = new System.Drawing.Point(28, 155);
            this.txtSubjectId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectId.MaxLength = 50;
            this.txtSubjectId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubjectId.Multiline = false;
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(517, 50);
            this.txtSubjectId.TabIndex = 72;
            this.txtSubjectId.Text = "";
            // 
            // btnAccepte
            // 
            this.btnAccepte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAccepte.EffectType = MaterialSurface.ET.Custom;
            this.btnAccepte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccepte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAccepte.Icon = null;
            this.btnAccepte.Location = new System.Drawing.Point(128, 326);
            this.btnAccepte.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccepte.MouseState = MaterialSurface.MouseState.OUT;
            this.btnAccepte.Name = "btnAccepte";
            this.btnAccepte.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAccepte.Radius = 2;
            this.btnAccepte.ShawdowDepth = 3;
            this.btnAccepte.ShawdowOpacity = 50;
            this.btnAccepte.Size = new System.Drawing.Size(200, 62);
            this.btnAccepte.TabIndex = 75;
            this.btnAccepte.Text = "Xác nhận";
            this.btnAccepte.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAccepte.UseVisualStyleBackColor = true;
            this.btnAccepte.Click += new System.EventHandler(this.btnAccepte_Click);
            // 
            // btnDenie
            // 
            this.btnDenie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDenie.EffectType = MaterialSurface.ET.Custom;
            this.btnDenie.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnDenie.Icon = null;
            this.btnDenie.Location = new System.Drawing.Point(419, 326);
            this.btnDenie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDenie.MouseState = MaterialSurface.MouseState.OUT;
            this.btnDenie.Name = "btnDenie";
            this.btnDenie.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnDenie.Radius = 2;
            this.btnDenie.ShawdowDepth = 3;
            this.btnDenie.ShawdowOpacity = 50;
            this.btnDenie.Size = new System.Drawing.Size(200, 62);
            this.btnDenie.TabIndex = 76;
            this.btnDenie.Text = "Hủy";
            this.btnDenie.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDenie.UseVisualStyleBackColor = true;
            this.btnDenie.Click += new System.EventHandler(this.btnDenie_Click);
            // 
            // DetailSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(695, 401);
            this.Controls.Add(this.btnDenie);
            this.Controls.Add(this.btnAccepte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNameSubject);
            this.Controls.Add(this.txtSubjectId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailSubject";
            this.Text = "DetailSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSkin.Controls.MaterialTextBox txtNameSubject;
        private MaterialSkin.Controls.MaterialTextBox txtSubjectId;
        private MaterialSurface.ContainedButton btnAccepte;
        private MaterialSurface.ContainedButton btnDenie;
    }
}