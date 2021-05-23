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
        StudentView studentView;
        List<Class> classes = new List<Class>();
        public OneStudentView(object passValue, StudentView studentView)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            if (passValue is null)
            {
                this.Close();
            }
            if (passValue is string)
            {
                this.studentID = (string)passValue;
                this.student = new Student();
                this.mode = Mode.Add;
            }
            else
            {
                if (passValue is Student)
                {
                    this.student = (Student)passValue;
                    this.mode = Mode.Edit;
                }
            }
            this.studentView = studentView;
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvatar.Width, ptbAvatar.Height);
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;
            await Task.Run(() =>
            {
                ClassController classController = new ClassController();
                this.classes = classController.GetClasses();
            });
            if (classes.Count > 0)
            {
                cbbCurrentClass.Items.Clear();
                foreach (var _class in classes)
                {
                    cbbCurrentClass.Items.Add(_class.classID);
                }
            }
            OnFirstLoad();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            studentView.homeView.Activate();
        }
        void OnFirstLoad()
        {
            if (mode == Mode.Edit && student != null)
            {

                lbID.Text = student.ID;
                txtSurname.Text = student.SurName;
                txtFirstname.Text = student.FirstName;
                txtAddress.Text = student.Address;
                dateBornPicker.Value = student.DateBorn;
                cbbSex.SelectedIndex = (student.Sex) ? 1 : 0;
                txtPhone.Text = student.Phone;
                txtMail.Text = student.Mail;
                txtCurrentClass.Text = student.ClassID;
                cbbStatus.SelectedIndex = (student.Status) ? 1 : 0;
                ptbAvatar.Image = student.Avatar;
            }
            else
            {
                if (mode == Mode.Add)
                {
                    lbID.Text = this.studentID;
                }
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

        private void FetchDataOfStudentFromUI()
        {
            student.ID = lbID.Text;
            student.SurName = txtSurname.Text;
            student.FirstName = txtFirstname.Text;
            student.Address = txtAddress.Text;
            student.DateBorn = dateBornPicker.Value;
            student.Sex = cbbSex.SelectedIndex == 0 ? false : true;
            student.Phone = txtPhone.Text;
            student.Mail = txtMail.Text;
            student.ClassID = txtCurrentClass.Text;
            student.Status = cbbStatus.SelectedIndex == 0 ? false : true;
            student.Avatar = ptbAvatar.Image;
        }
        private void OnClickConfirmButton(object sender, EventArgs e)
        {
            FetchDataOfStudentFromUI();
            if (!CheckeInputValue())
            {
                Dialog.Show(this, "Dữ liệu thông tin học sinh không hợp lệ, vui lòng kiểm tra và thử lại.", tittle: "Cảnh báo");
                return;
            }
            OnUpdateData();


        }
        private bool CheckeInputValue()
        {
            if (lbID.Text == "") return false;
            if (txtSurname.Text == "") return false;
            if (txtFirstname.Text == "") return false;
            if (txtAddress.Text == "") return false;
            if (txtCurrentClass.Text == "") return false;
            if (txtPhone.Text == "") return false;
            if (DateTime.Now.Year - dateBornPicker.Value.Year < 10) return false;
            if (cbbSex.SelectedIndex < 0) return false;
            if (cbbStatus.SelectedIndex < 0) return false;
            return true;

        }


        private async void OnUpdateData()
        {
            SetLoad(true, "Đang thực hiện cập nhật dữ liệu...");

            bool progressResult = false;
             await Task.Run(() =>
            {

                StudentController studentController = new StudentController(null);
                 progressResult = (this.mode == Mode.Edit) ? studentController.UpdateStudent(this.student) :
                studentController.AddStudent(this.student);

            });
            SetLoad(false);
            if (progressResult)
            {
                SetLoad(false);
                Dialog.Show(this, "Cập nhật thành công.", tittle: "Thông báo");
                if(mode == Mode.Add)
                {
                    Snackbar.MakeSnackbar(studentView.homeView, $"Đã thêm mới  học sinh  {this.student.ID}  thành công", buttonText:"Thông báo");

                }
                else
                {
                    Snackbar.MakeSnackbar(studentView.homeView, $"Đã cập nhật thông tin  học sinh {this.student.ID} thành công", buttonText: "Thông báo");
                }
                this.studentView.FetchData();
                this.Close();
                
            }
            else
            {
                SetLoad(false);
                Dialog.Show(this, "Cập nhật thất bại, vui lòng kiển tra dữ liệu và thử lại.", tittle: "Cảnh báo");
            }

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
        

    }
}
