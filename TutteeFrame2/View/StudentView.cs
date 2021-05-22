using System;
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
    public partial class StudentView : UserControl
    {
        public HomeView homeView;
        readonly StudentController studentController;
        public StudentView()
        {
            InitializeComponent();
            studentController = new  StudentController(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbbFilterByGrade.SelectedIndex = 0;
            cbbSortBy.SelectedIndex = 0;
          
        }
        public void SetHome(HomeView homeView)
        {
            this.homeView = homeView;
        }
        public void FetchData()
        {
            studentController.FetchData();
        }

        public void ShowStudentsOnListView()
        {

            listViewStudents.Items.Clear();
            foreach (Student student in studentController.students)
            {
                
                ListViewItem lvi = new ListViewItem(new string[] {student.ID,student.SurName,student.FirstName,
                    student.DateBorn.ToString("dd/mm/yyyy"),student.GetSex,student.Address,
                    student.Phone,student.ClassID,student.Status?"Nam":"Nữ" });
                listViewStudents.Items.Add(lvi);
            }
        }

    }
}
