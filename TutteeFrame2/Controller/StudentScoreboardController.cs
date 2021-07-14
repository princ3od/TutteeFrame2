using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.View;
using TutteeFrame2.Model;
using TutteeFrame2.Utils;
using TutteeFrame2.DataAccess;
using MaterialSurface;
using System.Windows.Forms;

namespace TutteeFrame2.Controller
{
    class StudentScoreboardController
    {
        public Teacher mainTeacher;
        StudentScoreboardView view;
        bool isLoading = false;
        public List<string> teachingClasses;
        public List<Student> students;
        public List<Teaching> teachings;
        public StudentScoreboardController(StudentScoreboardView _view)
        {
            view = _view;
        }
        public async void FetchData()
        {
            if (isLoading)
                return;
            isLoading = true;
            view.Home.SetLoad(true, "Đang lấy danh sách lớp giảng dạy...");
            teachingClasses = await Task.Run(() => TeachingDA.Instance.GetTeachingClasses(mainTeacher.ID));
            if (teachingClasses == null)
            {
                Dialog.Show(view.Home, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                isLoading = false;
                view.Home.SetLoad(false);
                return;
            }
            view.ShowData();
            view.firstLoad = false;
            isLoading = false;
        }
        public async void FetchStudent()
        {
            view.Home.SetLoad(true, "Đang tải danh sách học sinh...");
            students = await Task.Run(() => StudentDA.Instance.GetStudents(view.classFilter));
            if (students == null)
            {
                Dialog.Show(view.Home, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                view.Home.SetLoad(false);
                return;
            }
            view.Home.SetLoad(false);
            view.ShowStudent();
        }
        public async void FetchSemester()
        {
            view.Home.SetLoad(true, "Đang tải thông tin giảng dạy...");
            teachings = await Task.Run(() => TeachingDA.Instance.GetTeachings(mainTeacher, view.classFilter));
            if (teachings == null)
            {
                Dialog.Show(view.Home, "Đã có lỗi xảy ra, vui lòng thử lại!", "Lỗi");
                view.Home.SetLoad(false);
                return;
            }
            view.LoadSemester();
            view.Home.SetLoad(false);
        }
        public async Task<List<Score>> GetScores(Student student)
        {
            return await Task.Run(() => ScoreboardDA.Instance.GetStudentScore(student.ID, mainTeacher.Subject.ID, view.semesterFilter, Int32.Parse(student.GetGrade)));
        }
        public async void UpdateStudentScore(DataGridViewRowCollection rows, string _subjectid, int _semester, int _grade)
        {
            view.Home.SetLoad(true, "Đang cập nhật...");
            string studentid = "";
            bool success = true;
            foreach (DataGridViewRow row in rows)
            {
                studentid = row.Cells[1].Value.ToString();
                List<Score> scores = new List<Score>();
                Score score = new Score(Score.ScoreType.Mieng);
                score.Value = (row.Cells[3].Value == null) ? -1 : Double.Parse(row.Cells[3].Value.ToString());
                scores.Add(score);
                for (int i = 4; i < 7; i++)
                {
                    score = new Score(Score.ScoreType.MuoiLamPhut);
                    score.Value = (row.Cells[i].Value == null) ? -1 : Double.Parse(row.Cells[i].Value.ToString());
                    scores.Add(score);
                }
                for (int i = 7; i < 10; i++)
                {
                    score = new Score(Score.ScoreType.MotTiet);
                    score.Value = (row.Cells[i].Value == null) ? -1 : Double.Parse(row.Cells[i].Value.ToString());
                    scores.Add(score);
                }
                score = new Score(Score.ScoreType.HocKi);
                score.Value = (row.Cells[10].Value == null) ? -1 : Double.Parse(row.Cells[10].Value.ToString());
                scores.Add(score);
                score = new Score(Score.ScoreType.TrungBinh);
                score.Value = (row.Cells[11].Value == null) ? -1 : Double.Parse(row.Cells[11].Value.ToString());
                scores.Add(score);
                if (success)
                    await Task.Run(() => success = ScoreboardDA.Instance.UpdateStudentScore(studentid, _subjectid, _semester, _grade, scores));
                else
                    await Task.Run(() => ScoreboardDA.Instance.UpdateStudentScore(studentid, _subjectid, _semester, _grade, scores));
            }
            await Task.Delay(500);
            if (success)
            {
                Snackbar.MakeSnackbar(view.Home, "Cập nhật thành công!", "OK");
            }
            else
            {
                Dialog.Show(view.Home, "Cập nhật thất bại, đã có lỗi xảy ra. Vui lòng thử lại!", "Lỗi");
            }
            view.Home.SetLoad(false);
        }
    }
}
