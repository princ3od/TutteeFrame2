using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Model;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Controller;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    enum mouse { Ver, Hori, none }
    class Cs
    {
        public string name;
        public int index;
    }
    public partial class Schedule : UserControl
    {
        Graphics g;
        List<Session> t = new List<Session>();
        List<Subject> subject = new List<Subject>();
        List<Cs> cs = new List<Cs>(); 
        public string scheduleID;
        Bitmap bitmap;
        Rim r = new Rim();
        Point Lastmouse = new Point(0, 0);
        bool ismousedown = false;
        bool chosen = false;
        bool edge = false;
        mouse m = mouse.none;
        readonly ScheduleController scheduleController;
        public HomeView homeView;
        List<Class> classes;
        public Schedule()
        {
            InitializeComponent();
            scheduleController = new ScheduleController(this);
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
                            edge = true;
                            return;
                        }
                    }
                    for (int i = 1; i < 11; i++)
                    {
                        if (e.Y == r.Hori[i])
                        {
                            edge = true;
                            return;
                        }
                    }
                    edge = false;
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
                //if (pictureBox1.Cursor == Cursors.VSplit)
                //{
                //    Lastmouse = e.Location;
                //    ismousedown = true;
                //    m = mouse.Ver;
                //}
                //if (pictureBox1.Cursor == Cursors.HSplit)
                //{
                //    Lastmouse = e.Location;
                //    ismousedown = true;
                //    m = mouse.Hori;
                //}
                if (!edge)
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
                            containedButton2.Enabled = true;
                        }
                        else
                        {
                            if (materialTextfield0.Text == (a + 1).ToString() && materialTextfield1.Text == c.ToString())
                            {
                                redraw();
                                materialTextfield0.Clear();
                                materialTextfield1.Clear();
                                materialTextfield2.Clear();
                                materialComboBox4.SelectedIndex = -1;
                                materialComboBox5.SelectedIndex = -1;
                                materialComboBox6.SelectedIndex = -1;
                                chosen = false;
                                containedButton1.Enabled = false;
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
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
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
                g.DrawString("Thứ " + (i + 1).ToString(), f, br, r.Intersec[0, i].X + pictureBox1.Width / 35, r.Intersec[0, i].Y + pictureBox1.Height / 55);
            }
            for (int i = 1; i < 11; i++)
            {
                g.DrawString(i.ToString(), f, br, r.Intersec[i, 0].X + pictureBox1.Width / 21, r.Intersec[i, 0].Y + pictureBox1.Height / 55);
            }
            update();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Session tkb = new Session();
            string day = materialComboBox4.SelectedItem.ToString();
            tkb.thu = Int32.Parse(day);
            string session = materialComboBox5.SelectedItem.ToString();
            tkb.tiet = Int32.Parse(session);
            tkb.mon = ConvertToID(materialComboBox6.SelectedItem.ToString());
            materialComboBox4.SelectedIndex = -1;
            materialComboBox5.SelectedIndex = -1;
            materialComboBox6.SelectedIndex = -1;
            tkb.ID = scheduleID + (tkb.thu*10 + tkb.tiet).ToString();
            add(tkb);
        }
        private async void add(Session tkb)
        {
            foreach (Session s in t)
            {
                if (s.thu == tkb.thu && s.tiet == tkb.tiet)
                {
                    s.mon = tkb.mon;
                    await Task.Delay(600);
                    await Task.Run(() =>
                    {
                        scheduleController.Detele(tkb.ID);
                    });
                    await Task.Delay(600);
                    await Task.Run(() =>
                    {
                        scheduleController.Add(tkb, scheduleID);
                    });                    
                    redraw();
                    return;
                }
            }
            await Task.Delay(600);
            await Task.Run(() =>
            {
                scheduleController.Add(tkb, scheduleID);
            });
            t.Add(tkb);
            draw(tkb);
        }
        private void update()
        {
            pictureBox1.Image = bitmap;
        }
        private void draw(Session tkb)
        {
            Font f = this.Font;
            Brush br = new SolidBrush(Color.Black);
            g.DrawString(ConvertToName(tkb.mon), f, br, r.Intersec[tkb.tiet, tkb.thu - 1].X + pictureBox1.Width / 35, r.Intersec[tkb.tiet, tkb.thu - 1].Y + pictureBox1.Height / 55);
            update();
        }
        public void redraw()
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            VeBang();
            foreach (Session tkb in t)
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
            materialTextfield0.Text = (a + 1).ToString();
            materialTextfield1.Text = b.ToString();
            materialComboBox4.SelectedIndex = a - 1;
            materialComboBox5.SelectedIndex = b - 1;
            foreach (Session tkb in t)
            {
                if (tkb.thu == a + 1 && tkb.tiet == b)
                {
                    materialTextfield2.Text = ConvertToName(tkb.mon);
                    return;
                }
            }
            materialTextfield2.Clear();
            materialComboBox6.SelectedIndex = -1;
        }

        private void Schedule_SizeChanged(object sender, EventArgs e)
        {
            if (g == null) return;
            Create();
            redraw();
            if (chosen)
            {
                int a = Int32.Parse(materialTextfield0.Text);
                int b = Int32.Parse(materialTextfield1.Text);
                drawline(a - 1, a, b, b + 1);
            }
        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBox2.SelectedItem)
            {
                case "10":
                {
                    materialComboBox3.Items.Clear();                    
                    materialComboBox3.Items.Add("10A1");
                    materialComboBox3.Items.Add("10A2");
                    materialComboBox3.SelectedIndex = -1;
                    break;
                }
                case "11":
                {
                    materialComboBox3.Items.Clear();
                    materialComboBox3.Items.Add("11A1");
                    materialComboBox3.Items.Add("11A2");
                    materialComboBox3.SelectedIndex = -1;
                    break;
                }
                case "12":
                {
                    materialComboBox3.Items.Clear();
                    materialComboBox3.Items.Add("12A1");
                    materialComboBox3.Items.Add("12A2");
                    materialComboBox3.Items.Add("12A3");
                    materialComboBox3.SelectedIndex = -1;
                    break;
                }
                default:
                    materialComboBox3.Items.Clear();
                    break;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            homeView.SetLoad(true, "Đang tải thời khóa biểu");
            string lop = materialComboBox3.Text;
            int hk = Int32.Parse(materialComboBox1.Text);
            int nam = 2020;
            await Task.Delay(600);
            await Task.Run(() => 
            {
                scheduleController.GetSchedule(lop, hk, nam);
            });
            homeView.SetLoad(false);
        }
        private async void AutoViewSchedule()
        {
            homeView.SetLoad(true, "Đang tải thời khóa biểu");
            string lop = materialComboBox3.Text;
            int hk = Int32.Parse(materialComboBox1.Text);
            int nam = 2020;
            await Task.Delay(600);
            await Task.Run(() =>
            {
                scheduleController.GetSchedule(lop, hk, nam);
            });
            homeView.SetLoad(false);
        }
        public async void GetSchedule()
        {
            await Task.Run(() =>
            {
                scheduleID = scheduleController.scheduleID;
                scheduleController.FetchSchedule(scheduleID);
            });
        }
        private string ConvertToID(string sub)
        {
            string id = new string(new char[] { });
            foreach (Subject s in subject)
            {
                if (s.Name == sub)
                {
                    id = s.ID;
                    return id;
                }                                  
            }
            return null;
        }
        private string ConvertToName(string id)
        {
            string sub = new string(new char[] { });
            foreach (Subject s in subject)
            {
                if (s.ID == id)
                {
                    sub = s.Name;
                    return sub;
                }
            }
            return null;
        }
        public void FetchData()
        {
            scheduleController.FetchData();
        }
        public void GetSubject()
        {
            //materialComboBox6.Items.Clear();
            subject = scheduleController.subject;
            foreach (Subject s in scheduleController.subject)
            {
                materialComboBox6.Items.Add(s.Name);
                Cs c = new Cs();
                c.name = s.Name;
                c.index = cs.Count;
                cs.Add(c);
            }
        }
        public void FetchSchedule()
        {            
            t = scheduleController.sessions;
            redraw();
        }

        private async void containedButton2_Click(object sender, EventArgs e)
        {
            int thu = Int32.Parse(materialTextfield0.Text);
            int tiet = Int32.Parse(materialTextfield1.Text);
            string id = scheduleID + (thu * 10 + tiet).ToString();
            await Task.Delay(600);
            await Task.Run(() =>
            {
                scheduleController.Detele(id);
            });
            materialTextfield0.Clear();
            materialTextfield1.Clear();
            materialTextfield2.Clear();
            foreach (Session s in t)
            {
                if (s.thu == thu && s.tiet == tiet) 
                {
                    t.Remove(s);
                    redraw();
                    return;
                }
            }
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialComboBox1.SelectedIndex != -1 && materialComboBox3.SelectedIndex != -1)
            {
                AutoViewSchedule();
                containedButton0.Enabled = true;
            }
            else
                containedButton0.Enabled = false;
        }

        private void materialComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialComboBox4.SelectedIndex != -1 && materialComboBox5.SelectedIndex != -1 && materialComboBox6.SelectedIndex != -1)
            {
                containedButton1.Enabled = true;
            }
            else
                containedButton1.Enabled = false;
        }

        private void materialTextfield2_TextChanged(object sender, EventArgs e)
        {
            if (materialTextfield2.Text != "")
            {
                containedButton2.Enabled = true;
            }
            else
                containedButton2.Enabled = false;
        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }

        private void materialTextfield0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
