using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutteeFrame2
{
    enum mouse { Ver, Hori, none }
    public partial class Schedule : UserControl
    {
        Graphics g;
        List<Tkb> t = new List<Tkb>();
        Bitmap bitmap;
        Rim r = new Rim();
        Point Lastmouse = new Point(0, 0);
        bool ismousedown = false;
        bool chosen = false;
        mouse m = mouse.none;
        public Schedule()
        {
            InitializeComponent();
            Create();
            redraw();
            pictureBox1.MouseMove += (s, e) =>
            {
                if (!ismousedown)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (e.X == r.Ver[i])
                        {
                            pictureBox1.Cursor = Cursors.VSplit;
                            return;
                        }
                    }
                    for (int i = 1; i < 11; i++)
                    {
                        if (e.Y == r.Hori[i])
                        {
                            pictureBox1.Cursor = Cursors.HSplit;
                            return;
                        }
                    }
                    pictureBox1.Cursor = Cursors.Default;
                }
                else
                {
                    if (m == mouse.Ver)
                    {
                        int j = new int();
                        for (int i = 1; i < 7; i++)
                        {
                            if (r.Ver[i] == Lastmouse.X)
                            {
                                j = i;
                                break;
                            }
                        }
                        r.Ver[j] = e.X;
                        Lastmouse = e.Location;
                        UpdateIntersec();
                        redraw();
                    }
                    if (m == mouse.Hori)
                    {
                        int j = new int();
                        for (int i = 1; i < 11; i++)
                        {
                            if (r.Hori[i] == Lastmouse.Y)
                            {
                                j = i;
                                break;
                            }
                        }
                        r.Hori[j] = e.Y;
                        Lastmouse = e.Location;
                        UpdateIntersec();
                        redraw();
                    }
                }
            };
            pictureBox1.MouseDown += (s, e) =>
            {
                if (pictureBox1.Cursor == Cursors.VSplit)
                {
                    Lastmouse = e.Location;
                    ismousedown = true;
                    m = mouse.Ver;
                }
                if (pictureBox1.Cursor == Cursors.HSplit)
                {
                    Lastmouse = e.Location;
                    ismousedown = true;
                    m = mouse.Hori;
                }
                if (pictureBox1.Cursor == Cursors.Default)
                {
                    bool found1 = false;
                    bool found2 = false;
                    int a = new int();
                    int b = new int();
                    int c = new int();
                    int d = new int();
                    for (int i = 1; i < 8 && !found1; i++)
                    {
                        for (int j = i; j < 8; j++)
                        {
                            if (r.Ver[i] < e.X && r.Ver[j] > e.X && j - i == 1)
                            {
                                a = i;
                                b = j;
                                found1 = true;
                                break;
                            }
                        }
                    }
                    for (int i = 1; i < 12 && !found2; i++)
                    {
                        for (int j = i; j < 12; j++)
                        {
                            if (r.Hori[i] < e.Y && r.Hori[j] > e.Y && j - i == 1)
                            {
                                c = i;
                                d = j;
                                found2 = true;
                                break;
                            }
                        }
                    }
                    if (found1 && found2)
                    {
                        if (chosen == false)
                        {
                            drawline(a, b, c, d);
                            getinfo(a, c);
                            chosen = true;
                        }
                        else
                        {
                            if (textBox1.Text == (a + 1).ToString() && textBox2.Text == c.ToString())
                            {
                                redraw();
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox4.Clear();
                                chosen = false;
                            }
                            else
                            {
                                redraw();
                                drawline(a, b, c, d);
                                getinfo(a, c);
                            }
                        }
                    }
                }
            };
            pictureBox1.MouseUp += (s, e) =>
            {
                ismousedown = false;
            };
        }
        private void VeBang()
        {
            g.Clear(Color.White);
            Font f = new Font("Arial", 12);
            Brush br = new SolidBrush(Color.Black);
            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(new Pen(Color.Black, 1), r.Ver[i], 0, r.Ver[i], pictureBox1.Height);
            }
            for (int i = 0; i < 12; i++)
            {
                g.DrawLine(new Pen(Color.Black, 1), 0, r.Hori[i], pictureBox1.Width, r.Hori[i]);
            }
            for (int i = 1; i < 7; i++)
            {
                g.DrawString("Thứ " + (i + 1).ToString(), f, br, r.Intersec[0, i]);
            }
            for (int i = 1; i < 11; i++)
            {
                g.DrawString(i.ToString(), f, br, r.Intersec[i, 0]);
            }
            update();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tkb tkb = new Tkb();
            if (Int32.TryParse(textBox1.Text, out int i))
            {
                if (i > 1 && i < 8)
                {
                    tkb.thu = i;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            if (Int32.TryParse(textBox2.Text, out int j))
            {
                if (j > 0 && j < 11)
                {
                    tkb.tiet = j;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            tkb.mon = textBox3.Text;
            tkb.gv = textBox4.Text;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            add(tkb);
        }
        private void add(Tkb tkb)
        {
            foreach (Tkb s in t)
            {
                if (s.thu == tkb.thu && s.tiet == tkb.tiet)
                {
                    s.mon = tkb.mon;
                    redraw();
                    return;
                }
            }
            t.Add(tkb);
            draw(tkb);
        }
        private void update()
        {
            pictureBox1.Image = bitmap;
        }
        private void draw(Tkb tkb)
        {
            Font f = new Font("Arial", 12);
            Brush br = new SolidBrush(Color.Black);
            g.DrawString(tkb.mon, f, br, r.Intersec[tkb.tiet, tkb.thu - 1]);
            update();
        }
        private void redraw()
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            VeBang();
            foreach (Tkb tkb in t)
            {
                draw(tkb);
            }
        }
        private void Create()
        {
            for (int i = 0; i < 12; i++)
            {
                r.Hori[i] = i * pictureBox1.Height / 11;
            }
            r.Hori[11] = r.Hori[11] - 1;
            for (int i = 0; i < 8; i++)
            {
                r.Ver[i] = i * pictureBox1.Width / 7;
            }
            r.Ver[7] = r.Ver[7] - 1;
            UpdateIntersec();
        }
        private void UpdateIntersec()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    r.Intersec[i, j].X = r.Ver[j];
                    r.Intersec[i, j].Y = r.Hori[i];
                }
            }
        }
        private void drawline(int a, int b, int c, int d)
        {
            g.DrawLine(new Pen(Color.Red), r.Ver[a] + 1, r.Hori[c] + 1, r.Ver[b] - 1, r.Hori[c] + 1);
            g.DrawLine(new Pen(Color.Red), r.Ver[a] + 1, r.Hori[d] - 1, r.Ver[b] - 1, r.Hori[d] - 1);
            g.DrawLine(new Pen(Color.Red), r.Ver[a] + 1, r.Hori[c] + 1, r.Ver[a] + 1, r.Hori[d] - 1);
            g.DrawLine(new Pen(Color.Red), r.Ver[b] - 1, r.Hori[c] + 1, r.Ver[b] - 1, r.Hori[d] - 1);
            update();
        }
        private void getinfo(int a, int b)
        {
            textBox1.Text = (a + 1).ToString();
            textBox2.Text = b.ToString();
            foreach (Tkb tkb in t)
            {
                if (tkb.thu == a + 1 && tkb.tiet == b)
                {
                    textBox3.Text = tkb.mon;
                    textBox4.Text = tkb.gv;
                    return;
                }
            }
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (g == null) return;
            Create();
            redraw();
            if (chosen)
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                drawline(a - 1, a, b, b + 1);
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (g == null) return;
            Create();
            redraw();
            if (chosen)
            {
                int a = Int32.Parse(textBox1.Text);
                int b = Int32.Parse(textBox2.Text);
                drawline(a - 1, a, b, b + 1);
            }
        }
    }
}
