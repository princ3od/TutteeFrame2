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
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;

namespace TutteeFrame2.View
{
    public partial class DetailScoreboardView : Form
    {
        string studentID, studentName;
        int grade;
        List<Subject> subjects = new List<Subject>();
        Dictionary<string, List<Score>> subjectScores = new Dictionary<string, List<Score>>();
        Dictionary<string, List<Score>> subjectScores2 = new Dictionary<string, List<Score>>();
        Dictionary<string, double> averageSubjectScore = new Dictionary<string, double>();
        Dictionary<string, double> averageSubjectScoreSem1 = new Dictionary<string, double>();
        Dictionary<string, double> averageSubjectScoreSem2 = new Dictionary<string, double>();
        List<AverageScore> averageScores = new List<AverageScore>(3);
        public DetailScoreboardView(string _studentID, string _studentName, int _grade)
        {
            InitializeComponent();
            studentID = _studentID;
            grade = _grade;
            studentName = _studentName;
            RemoveFlickerHelper.DoubleBufferedGridView(gridviewStudentScore, true);
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetLoad(true, "Đang tải bảng điểm...");
            await Task.Run(() =>
            {
                subjects = SubjectDA.Instance.GetSubjects();
                if (subjects != null)
                {
                    foreach (Subject subject in subjects)
                    {
                        List<Score> scores = new List<Score>();
                        scores = ScoreboardDA.Instance.GetStudentScore(studentID, subject.ID, 1, grade);
                        subjectScores.Add(subject.ID, scores);
                        averageSubjectScoreSem1.Add(subject.ID, scores[8].Value);
                        scores = ScoreboardDA.Instance.GetStudentScore(studentID, subject.ID, 2, grade);
                        subjectScores2.Add(subject.ID, scores);
                        averageSubjectScoreSem2.Add(subject.ID, scores[8].Value);
                        double score = -1;
                        score = ScoreboardDA.Instance.GetAverageYearSubjectScore(studentID, subject.ID, grade);
                        averageSubjectScore.Add(subject.ID, score);

                    }
                    averageScores = ScoreboardDA.Instance.GetAverageScore(studentID, grade);
                }
            });
            if (subjects == null || averageScores == null)
            {
                Dialog.Show(this, "Đã có lỗi xảy ra, vui lòng thử lại", "Lỗi");
                return;
            }
            cbbSemester.SelectedIndex = 0;
        }
        private void OnSemesterChanged(object sender, EventArgs e)
        {
            SetLoad(true, "Đang tải bảng điểm...");
            lbScoreTittle.Text = string.Format("Bảng điểm của học sinh {0} ({1}) - HK {2} - năm {3}", studentName, studentID, cbbSemester.Text, DateTime.Now.Year.ToString());
            gridviewStudentScore.Rows.Clear();

            LearniningCapacity learniningCapacitySemester = new LearniningCapacity();
            LearniningCapacity learniningCapacityYear = new LearniningCapacity();
            int semester = Int32.Parse(cbbSemester.Text);
            learniningCapacitySemester = new LearniningCapacity(averageScores, averageSubjectScoreSem1.Values.ToList(), averageSubjectScoreSem2.Values.ToList(), semester);
            learniningCapacityYear = new LearniningCapacity(averageScores, averageSubjectScoreSem1.Values.ToList(), averageSubjectScoreSem2.Values.ToList(), 3);
            int index = 0;
            if (averageScores != null && learniningCapacitySemester != null)
                lbLearningCapacitySem.Text = string.Format("Điểm trung bình HK {0}: {1} - Học lực: {2}", semester.ToString(),
                    (averageScores[semester - 1].Value > -1) ? averageScores[semester - 1].Value.ToString() : "Chưa có", learniningCapacitySemester.ToString());
            if (averageScores != null && learniningCapacitySemester != null)
                lbLearningCapacityYear.Text = string.Format("Điểm trung bình cả năm: {0} - Học lực cả năm: {1}",
                    (averageScores[2].Value > -1) ? averageScores[2].Value.ToString() : "Chưa có", learniningCapacityYear.ToString());
            foreach (Subject subject in subjects)
            {
                gridviewStudentScore.Rows.Add(subject.Name);
                if (semester == 1)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        try
                        {
                            if (subjectScores[subject.ID][i].Value != -1)
                                gridviewStudentScore.Rows[index].Cells[i + 1].Value = subjectScores[subject.ID][i].Value;
                        }
                        catch (Exception ex)
                        {
                            break;
                            //MessageBox.Show(ex.Message);
                        }
                    }
                    if (averageSubjectScore[subject.ID] != -1)
                        gridviewStudentScore.Rows[index].Cells[10].Value = averageSubjectScore[subject.ID];
                    index++;
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        try
                        {
                            if (subjectScores2[subject.ID][i].Value != -1)
                                gridviewStudentScore.Rows[index].Cells[i + 1].Value = subjectScores2[subject.ID][i].Value;
                        }
                        catch (Exception ex)
                        {
                            break;
                            //MessageBox.Show(ex.Message);
                        }
                    }
                    if (averageSubjectScore[subject.ID] != -1)
                        gridviewStudentScore.Rows[index].Cells[10].Value = averageSubjectScore[subject.ID];
                    index++;
                }
            }
            SetLoad(false);
        }
        public void SetLoad(bool isLoading, string loadInformation = "")
        {
            lbInformation.Text = loadInformation;
            mainProgressbar.Visible = lbInformation.Visible = isLoading;
            cbbSemester.Enabled = gridviewStudentScore.Enabled = !isLoading;

        }
        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
