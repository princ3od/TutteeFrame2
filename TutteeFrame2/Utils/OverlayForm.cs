using System.Drawing;
using System.Windows.Forms;
using TutteeFrame2.View;

namespace TutteeFrame2.Utils
{
    class OverlayForm : Form
    {
        public OverlayForm() { this.Close(); }
        public OverlayForm(Form parent, Form child, float _opacity = 0.6f, int _offSet = 5, bool setChild = true)
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            if (setChild)
                ((HomeView)parent).isChildShowing = true;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.ShowInTaskbar = false;
            this.Opacity = _opacity;
            this.BackColor = Color.Black;
            this.Size = parent.Size;
            this.Location = parent.Location;
            if (parent.FormBorderStyle != FormBorderStyle.None)
            {
                this.Location = new Point(this.Location.X + 7, this.Location.Y);
                this.Width -= 14;
                this.Height -= 7;
            }
            this.Enabled = false;
            this.Owner = parent;
            this.Activated += (s, e) =>
            {
                child.Activate();
            };
            child.StartPosition = FormStartPosition.Manual;
            child.Owner = parent;
            child.ShowInTaskbar = false;
            child.Location = new Point(this.Location.X + this.Width / 2 - child.Width / 2, this.Location.Y + this.Height / 2 - child.Height / 2 - _offSet);
            child.FormClosed += (s, e) =>
            {
                if (setChild)
                    ((HomeView)parent).isChildShowing = false;
                this.Close();
                //_parent.Focus();
            };
            this.Show();
        }
    }
}