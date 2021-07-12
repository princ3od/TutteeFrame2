using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.DataAccess;
using TutteeFrame2.Model;
using TutteeFrame2.View;
namespace TutteeFrame2.Controller
{
    class FormClassController
    {
        FormClassView view;
        public List<Student> students = new List<Student>();
        public Dictionary<string, List<AverageScore>> averageScoreList = new Dictionary<string, List<AverageScore>>();
        public Dictionary<string, StudentConduct> studentConducts = new Dictionary<string, StudentConduct>();
        public FormClassController(FormClassView _view)
        {
            this.view = _view;
        }
        public async void FetchData()
        {
            view.Home.SetLoad(true, "Đang lấy danh sách học sinh...");
            averageScoreList.Clear();
            studentConducts.Clear();
            await Task.Run(() =>
            {
                int grade = int.Parse(view.mainTeacher.FormClassID.Substring(0, 2));
                students = StudentDA.Instance.GetStudents(view.mainTeacher.FormClassID);
                for (int index = 0; index < students.Count; index++)
                {
                    List<AverageScore> averageScores = ScoreboardDA.Instance.GetAverageScore(students[index].ID, grade);
                    averageScoreList.Add(students[index].ID, averageScores);

                    StudentConduct studentConduct = StudentDA.Instance.GetStudentConduct(students[index].ID, grade);
                    studentConducts.Add(students[index].ID, studentConduct);
                }
            });
            view.ShowData();
            view.Home.SetLoad(false);
        }
    }
}
