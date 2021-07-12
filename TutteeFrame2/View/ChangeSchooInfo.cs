﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.Model;

namespace TutteeFrame2.View
{
    public partial class ChangeSchooInfo : Form
    {
        private String userID;
        private SchoolInfoController schoolInfoController;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void ChangeSchoolInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void  FetchData()
        {
            lbInformation.Visible = true;
            lbInformation.Text = "Đang thực hiển đồng bộ hóa dữ liệu...";
            mainProgressbar.Visible = true;
            schoolInfoController.FetchDataAsync();
        }

        public void ShowData() {
            txtSologan.Text = schoolInfoController.mySchool.Slogan;
            txtFullSchoolName.Text = schoolInfoController.mySchool.FullName;
            ptbAvatar.Image = schoolInfoController.mySchool.Logo;
            lbInformation.Visible = false;
            mainProgressbar.Visible = false;
        }


        public ChangeSchooInfo(String userID)
        {
            InitializeComponent();
            this.userID = userID;
            if(this.userID == "AD999999")
            {
                ptbAvatar.Enabled = true;
                txtSologan.Enabled = true;
                txtFullSchoolName.Enabled = true;
                btnSubmit.Enabled = true;
            }
            else
            {
                ptbAvatar.Enabled = false;
                txtSologan.Enabled = false;
                txtFullSchoolName.Enabled = false;
                btnSubmit.Enabled = false;
            }
            schoolInfoController = new SchoolInfoController(this,this.userID);
           

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            School mySchool = new School();
            mySchool.STT = schoolInfoController.mySchool.STT;
            mySchool.Logo = ptbAvatar.Image;
            mySchool.Slogan = txtSologan.Text;
            mySchool.FullName = txtFullSchoolName.Text;
            schoolInfoController.UpdateSchool(mySchool);
            lbInformation.Visible = true;
            lbInformation.Text = "Đang thực hiện cập nhật thông tin...";
            mainProgressbar.Visible = true;
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                ptbAvatar.ImageLocation = of.FileName;

            }
        }

        private void ChangeSchooInfo_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
