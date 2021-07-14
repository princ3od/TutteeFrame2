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
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class StudentScoreboardView : UserControl
    {
        public HomeView Home;
        StudentScoreboardController controller;
        public bool firstLoad = true;
        public string classFilter;
        public int semesterFilter;

        public StudentScoreboardView()
        {
            InitializeComponent();
            controller = new StudentScoreboardController(this);
        }
        public void SetHome(HomeView homeView)
        {
            Home = homeView;
        }
        public void SetMainTeacher(Teacher teacher)
        {
            controller.mainTeacher = teacher;

        }
        public void Fetch()
        {
            RemoveFlickerHelper.DoubleBufferedGridView(gridviewStudentScore, true);
            lbTeachingSubject.Text = controller.mainTeacher.Subject.Name;
            controller.FetchData();
        }
        public void ShowData()
        {
            cbbFilterByClass.Items.Clear();
            foreach (string _class in controller.teachingClasses)
            {
                cbbFilterByClass.Items.Add(_class);
            }
            if (cbbFilterByClass.Items.Count > 0)
            {
                cbbFilterByClass.SelectedIndex = 0;
                classFilter = cbbFilterByClass.Text;
            }
            lbTotalTeachingClass.Text = cbbFilterByClass.Items.Count.ToString("00");
        }

        public async void ShowStudent()
        {
            int index = 1;
            lbScoreTittle.Text = string.Format("Bảng điểm lớp {0} - môn {1} - HK {2} - năm {3}",
                              cbbFilterByClass.Text, controller.mainTeacher.Subject.Name, cbbFilterBySemester.Text, DateTime.Now.Year);
            gridviewStudentScore.Rows.Clear();
            foreach (Student student in controller.students)
            {
                gridviewStudentScore.Rows.Add(index.ToString(), student.ID, student.GetName());
                List<Score> scores = await controller.GetScores(student);
                LoadStudentScore(index, scores);
                index++;
            }
        }
        public void LoadSemester()
        {
            cbbFilterBySemester.Items.Clear();
            foreach (Teaching sem in controller.teachings)
            {
                cbbFilterBySemester.Items.Add(sem.Semester);
            }
            if (cbbFilterBySemester.Items.Count > 0)
                cbbFilterBySemester.SelectedIndex = 0;
        }

        void LoadStudentScore(int studentIndex, List<Score> scores)
        {
            for (int i = 0; i < 9; i++)
            {
                try
                {
                    if (scores[i].Value != -1)
                        gridviewStudentScore.Rows[studentIndex - 1].Cells[i + 3].Value = scores[i].Value;
                }
                catch
                {
                    //break;
                }
            }
        }
        private void OnChangeClass(object sender, EventArgs e)
        {
            if (cbbFilterByClass.SelectedIndex < 0)
                return;
            classFilter = cbbFilterByClass.Text;
            if (!string.IsNullOrEmpty(classFilter))
                controller.FetchSemester();
        }

        private void OnChangeSemester(object sender, EventArgs e)
        {
            if (cbbFilterBySemester.SelectedIndex < 0)
            {
                return;
            }
            semesterFilter = Int32.Parse(cbbFilterBySemester.Text);
            if (controller.teachings[cbbFilterBySemester.SelectedIndex].Editable)
            {
                lbEditable.Text = "Bảng điểm chưa khoá.";
                lbEditable.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                lbEditable.Text = "Bảng điểm đã bị khoá.";
                lbEditable.ForeColor = Color.Red;
            }
            btnSubmit.Enabled = controller.teachings[cbbFilterBySemester.SelectedIndex].Editable;
            gridviewStudentScore.ReadOnly = !controller.teachings[cbbFilterBySemester.SelectedIndex].Editable;
            controller.FetchStudent();
        }
        private void OnlyNumberCell(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyDigit);
            if (gridviewStudentScore.CurrentCell.ColumnIndex > 2 && gridviewStudentScore.CurrentCell.ColumnIndex < 11) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(OnlyDigit);
                }
            }
        }
        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void OnScoreUpdated(object sender, DataGridViewCellEventArgs e)
        {
            if (firstLoad)
                return;
            double temp;
            bool fullScore = true;
            int tongHeSo = 0;
            double sum = 0;
            if (gridviewStudentScore.CurrentCell.Value == null)
                fullScore = false;
            else if (Double.TryParse(gridviewStudentScore.CurrentCell.Value.ToString(), out temp))
            {
                if (temp > 10)
                    gridviewStudentScore.CurrentCell.ErrorText = "Điểm không hợp lệ (>10). Vui lòng nhập lại!";
                else
                    gridviewStudentScore.CurrentCell.ErrorText = string.Empty;

            }
            List<Score> scores = new List<Score>();
            if (fullScore)
                foreach (DataGridViewCell cell in gridviewStudentScore.Rows[e.RowIndex].Cells)
                {
                    Score score;
                    if (cell.ColumnIndex < 3 || cell.ColumnIndex > 10)
                        continue;
                    if (cell.Value == null || cell.ErrorText.Length > 0)
                    {
                        fullScore = false;
                        break;
                    }
                    if (cell.ColumnIndex < 7)
                    {
                        score = new Score(Score.ScoreType.MuoiLamPhut);
                        tongHeSo += score.GetHeSo();
                        score.Value = Double.Parse(cell.Value.ToString());
                        sum += score.Value * score.GetHeSo();
                    }
                    else if (cell.ColumnIndex < 10)
                    {
                        score = new Score(Score.ScoreType.MotTiet);
                        tongHeSo += score.GetHeSo();
                        score.Value = Double.Parse(cell.Value.ToString());
                        sum += score.Value * score.GetHeSo();
                    }
                    else if (cell.ColumnIndex < 11)
                    {
                        score = new Score(Score.ScoreType.HocKi);
                        tongHeSo += score.GetHeSo();
                        score.Value = Double.Parse(cell.Value.ToString());
                        sum += score.Value * score.GetHeSo();
                    }
                }
            if (fullScore)
            {
                double averageScore = Math.Round((double)(sum / tongHeSo), 2);
                gridviewStudentScore.Rows[e.RowIndex].Cells[11].Value = averageScore.ToString();
            }
            else
            {
                if (gridviewStudentScore.Rows[e.RowIndex].Cells[11].Value != null)
                    gridviewStudentScore.Rows[e.RowIndex].Cells[11].Value = null;
            }
        }

        private void OnUpdate(object sender, EventArgs e)
        {
            controller.UpdateStudentScore(gridviewStudentScore.Rows, controller.mainTeacher.Subject.ID, semesterFilter, Int32.Parse(classFilter.Substring(0, 2)));
        }
    }
}
