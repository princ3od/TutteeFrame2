using MaterialSurface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.Controller;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;
namespace TutteeFrame2.View
{
    public partial class OneStudentView : Form
    {
        public enum Mode { Add, Edit };
        #region Win32
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion
        public Mode mode;
        public string studentID;
        public Student student;
        public bool doneSuccess = false;
        List<Class> classes = new List<Class>();
        public OneStudentView(Mode mode,string studentID =null)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (!string.IsNullOrEmpty(studentID)) this.studentID = studentID;
            this.mode = mode;
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvatar.Width, ptbAvatar.Height);
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;
            SetLoad(true, "Đang tải dữ liệu...");

            await Task.Run(()=> {
                ClassController classController = new ClassController();
                StudentController studentController = new StudentController(null);

                this.classes = classController.GetClasses();
                this.student = studentController.GetStudentByID(this.studentID);

            });
            if (classes.Count > 0)
            {
                cbbCurrentClass.Items.Clear();
                foreach (var _class in classes)
                {
                    cbbCurrentClass.Items.Add(_class.classID);
                }
            }
            if (student != null)
            {
                lbID.Text = student.ID;
                txtSurname.Text = student.SurName;
                txtFirstname.Text = student.FirstName;
                txtAddress.Text = student.Address;
                dateBornPicker.Value = student.DateBorn;
                cbbSex.SelectedIndex = (student.Sex) ?1 : 0;
                txtPhone.Text = student.Phone;
                txtMail.Text = student.Mail;
                txtCurrentClass.Text = student.ClassID;
                cbbStatus.SelectedIndex = (student.Status) ? 0 : 1;
                ptbAvatar.Image = student.Avatar;
            }
        }
        void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
        }

        private void cbbCurrentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCurrentClass.Text = (string)cbbCurrentClass.SelectedItem;
        }
    }
}
