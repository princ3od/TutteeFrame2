using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutteeFrame2.Controls
{
    public enum Mouse { Veritcal, Horizontal, None }
    public partial class Shedule : UserControl
    {
        Graphics graphics;
        Bitmap bitmap;
        Rim rim = new Rim();
        Point Lastmouse = new Point(0, 0);
        bool ismousedown = false;
        bool chosen = false;
        bool edge = false;
        Mouse mouse = Mouse.None;
        public Shedule()
        {
            InitializeComponent();
        }
        private void DrawBoard()
        {
            graphics.Clear(Color.White);
            Font f = new Font("Arial", 12);
            Brush br = new SolidBrush(Color.Black);
            for (int i = 0; i < 8; i++)
            {
                graphics.DrawLine(new Pen(Color.Black, 1), rim.Ver[i], 0, rim.Ver[i], Height);
            }
            for (int i = 0; i < 12; i++)
            {
                graphics.DrawLine(new Pen(Color.Black, 1), 0, rim.Hori[i], Width, rim.Hori[i]);
            }
            for (int i = 1; i < 7; i++)
            {
                graphics.DrawString("Thứ " + (i + 1).ToString(), f, br, rim.Intersec[0, i]);
            }
            for (int i = 1; i < 11; i++)
            {
                graphics.DrawString(i.ToString(), f, br, rim.Intersec[i, 0]);
            }
            UpdateScoreboard();
        }
        void UpdateScoreboard()
        {
            this.BackgroundImage = bitmap;
        }
        private void Create()
        {
            for (int i = 0; i < 12; i++)
            {
                rim.Hori[i] = i * this.Height / 11;
            }
            rim.Hori[11] = rim.Hori[11] - 1;
            for (int i = 0; i < 8; i++)
            {
                rim.Ver[i] = i * this.Width / 7;
            }
            rim.Ver[7] = rim.Ver[7] - 1;
            UpdateIntersec();
        }
        private void UpdateIntersec()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    rim.Intersec[i, j].X = rim.Ver[j];
                    rim.Intersec[i, j].Y = rim.Hori[i];
                }
            }
        }
    }
}
