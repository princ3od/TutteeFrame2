
namespace TutteeFrame2.Controls
{
    partial class UtilityBar
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
            this.mainCard = new MaterialSurface.MaterialCard();
            this.SuspendLayout();
            // 
            // mainCard
            // 
            this.mainCard.BackColor = System.Drawing.Color.White;
            this.mainCard.CardColor = System.Drawing.Color.White;
            this.mainCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCard.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainCard.Location = new System.Drawing.Point(0, 0);
            this.mainCard.Margin = new System.Windows.Forms.Padding(5);
            this.mainCard.MouseInteract = false;
            this.mainCard.MouseState = MaterialSurface.MouseState.OUT;
            this.mainCard.Name = "mainCard";
            this.mainCard.Radius = 8;
            this.mainCard.ShawdowDepth = 2;
            this.mainCard.ShawdowOpacity = 50;
            this.mainCard.Size = new System.Drawing.Size(250, 80);
            this.mainCard.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.mainCard.TabIndex = 0;
            // 
            // UtilityBar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainCard);
            this.Name = "UtilityBar";
            this.Size = new System.Drawing.Size(250, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSurface.MaterialCard mainCard;
    }
}
