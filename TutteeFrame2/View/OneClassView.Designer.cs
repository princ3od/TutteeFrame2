
namespace TutteeFrame2.View
{
    partial class OneClassView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OneClassView));
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnSubmit = new MaterialSurface.ContainedButton();
            this.mainProgressbar = new MaterialSurface.MaterialProgressbar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtClassID = new MaterialSurface.MaterialTextfield();
            this.txtClassRoom = new MaterialSurface.MaterialTextfield();
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
            this.btnClose.Location = new System.Drawing.Point(455, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 42;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.OnExit);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.EffectType = MaterialSurface.ET.Custom;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(172, 216);
            this.btnSubmit.MouseState = MaterialSurface.MouseState.OUT;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnSubmit.Radius = 2;
            this.btnSubmit.ShawdowDepth = 3;
            this.btnSubmit.ShawdowOpacity = 50;
            this.btnSubmit.Size = new System.Drawing.Size(157, 50);
            this.btnSubmit.TabIndex = 70;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnSubmit);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mainProgressbar.ChangeDelay = 80;
            this.mainProgressbar.CircularWidth = 3.8F;
            this.mainProgressbar.IsIndetermine = true;
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 294);
            this.mainProgressbar.Maximum = 100;
            this.mainProgressbar.Minimum = 0;
            this.mainProgressbar.MouseState = MaterialSurface.MouseState.HOVER;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.mainProgressbar.Size = new System.Drawing.Size(502, 6);
            this.mainProgressbar.Step = 10;
            this.mainProgressbar.TabIndex = 72;
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
            this.lbInformation.Location = new System.Drawing.Point(5, 278);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(118, 13);
            this.lbInformation.TabIndex = 71;
            this.lbInformation.Text = "*Đang lấy thông tin...";
            this.lbInformation.Visible = false;
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(12, 9);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(61, 30);
            this.lbTittle.TabIndex = 73;
            this.lbTittle.Text = "------";
            // 
            // txtClassID
            // 
            this.txtClassID.AutoScaleColor = true;
            this.txtClassID.BackColor = System.Drawing.Color.White;
            this.txtClassID.CountText = true;
            this.txtClassID.FieldType = MaterialSurface.BoxType.Normal;
            this.txtClassID.FloatingLabelText = "FloatingLabel";
            this.txtClassID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClassID.HandleError = true;
            this.txtClassID.HelperText = "";
            this.txtClassID.HideSelection = true;
            this.txtClassID.HintText = "Tên lớp";
            this.txtClassID.Location = new System.Drawing.Point(50, 70);
            this.txtClassID.MaxLength = 4;
            this.txtClassID.MouseState = MaterialSurface.MouseState.OUT;
            this.txtClassID.Multiline = false;
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.PasswordChar = '\0';
            this.txtClassID.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtClassID.ReadOnly = false;
            this.txtClassID.ShortcutsEnable = true;
            this.txtClassID.ShowCaret = true;
            this.txtClassID.Size = new System.Drawing.Size(395, 67);
            this.txtClassID.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtClassID.TabIndex = 74;
            this.txtClassID.UseSystemPasswordChar = false;
            // 
            // txtClassRoom
            // 
            this.txtClassRoom.AutoScaleColor = true;
            this.txtClassRoom.BackColor = System.Drawing.Color.White;
            this.txtClassRoom.CountText = true;
            this.txtClassRoom.FieldType = MaterialSurface.BoxType.Normal;
            this.txtClassRoom.FloatingLabelText = "FloatingLabel";
            this.txtClassRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtClassRoom.HandleError = true;
            this.txtClassRoom.HelperText = "";
            this.txtClassRoom.HideSelection = true;
            this.txtClassRoom.HintText = "Số phòng";
            this.txtClassRoom.Location = new System.Drawing.Point(50, 143);
            this.txtClassRoom.MaxLength = 10;
            this.txtClassRoom.MouseState = MaterialSurface.MouseState.OUT;
            this.txtClassRoom.Multiline = false;
            this.txtClassRoom.Name = "txtClassRoom";
            this.txtClassRoom.PasswordChar = '\0';
            this.txtClassRoom.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtClassRoom.ReadOnly = false;
            this.txtClassRoom.ShortcutsEnable = true;
            this.txtClassRoom.ShowCaret = true;
            this.txtClassRoom.Size = new System.Drawing.Size(395, 67);
            this.txtClassRoom.Style = MaterialSurface.MaterialTextfield.TextfieldStyle.HintAsFloatingLabel;
            this.txtClassRoom.TabIndex = 75;
            this.txtClassRoom.UseSystemPasswordChar = false;
            // 
            // OneClassView
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.txtClassRoom);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OneClassView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OneClassView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnClose;
        private MaterialSurface.ContainedButton btnSubmit;
        private MaterialSurface.MaterialProgressbar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label lbTittle;
        private MaterialSurface.MaterialTextfield txtClassID;
        private MaterialSurface.MaterialTextfield txtClassRoom;
    }
}