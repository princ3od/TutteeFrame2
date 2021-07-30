using MaterialSurface;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;

namespace TutteeFrame2.View
{
    public partial class UpdateConductView : Form
    {
        string studentID;
        int grade;
        public bool doneSet = false;

        public UpdateConductView(string _studentID, int _grade)
        {
            InitializeComponent();
            studentID = _studentID;
            grade = _grade;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetLoad(true, "Đang tải dữ liệu...");
            cbbConductSem2.SelectedIndex = cbbConductSem1.SelectedIndex = cbbYearConduct.SelectedIndex = 4;
            Student student = new Student();
            StudentConduct studentConduct = new StudentConduct();
            await Task.Run(() =>
            {
                student = StudentDA.Instance.GetStudentByID(studentID);
                if (student != null)
                {
                    studentConduct = StudentDA.Instance.GetStudentConduct(studentID, grade);
                }
            });
            if (student == null)
            {
                Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại", "Lỗi");
                return;
            }
            if (studentConduct == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Không tải được dữ liệu hạnh kiểm học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cbbConductSem1.SelectedIndex = (int)studentConduct.Conducts[0].conductType;
            cbbConductSem2.SelectedIndex = (int)studentConduct.Conducts[1].conductType;
            cbbYearConduct.SelectedIndex = (int)studentConduct.Conducts[2].conductType;
            lbName.Text = string.Format("Học sinh: {1} - {0}", studentID, student.GetName());
            lbSex.Text = string.Format("Giới tính: {0}", student.GetSex);
            SetLoad(false);
        }

        public void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
        }

        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void OnUpdateConduct(object sender, EventArgs e)
        {
            SetLoad(true, "Đang cập nhật hạnh kiểm...");
            StudentConduct studentConduct = new StudentConduct();
            studentConduct.Conducts[0].conductType = (Conduct.ConductType)cbbConductSem1.SelectedIndex;
            studentConduct.Conducts[1].conductType = (Conduct.ConductType)cbbConductSem2.SelectedIndex;
            studentConduct.Conducts[2].conductType = (Conduct.ConductType)cbbYearConduct.SelectedIndex;
            await Task.Run(() =>
            {
                doneSet = StudentDA.Instance.UpdateStudentConduct(studentID, grade, studentConduct);
            });
            SetLoad(false);
            if (!doneSet)
            {
                Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại", "Lỗi");
                return;
            }
            this.Close();
        }
    }
}
