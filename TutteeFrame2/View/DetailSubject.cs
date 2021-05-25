using MaterialSurface;
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

namespace TutteeFrame2.View
{
    public partial class DetailSubject : Form
    {
        Subject subject;
        public DetailSubject(ref object input)
        {
            InitializeComponent();
         
            if(input is Subject)
            {
                
                this.subject = (Subject)input;
                LoadData();
            }
            else
            {

                this.subject = new Subject();
                this.subject.ID = (input is string) ? (string)input : null;
                input = this.subject;
                txtSubjectId.Text = this.subject.ID;
            }
            txtSubjectId.Enabled = false;
        }
        public  void LoadData()
        {
            txtSubjectId.Text = this.subject.ID;
            txtNameSubject.Text = this.subject.Name;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDenie_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAccepte_Click(object sender, EventArgs e)
        {
            if(txtNameSubject.Text!="" && txtSubjectId.Text !="")
            {
                subject.ID = txtSubjectId.Text;
                subject.Name = txtNameSubject.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Dialog.Show(this,"Dữ liệu không hợp lệ",tittle:"Cảnh báo");
            }
        }
    }
}
