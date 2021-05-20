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
    class SubjectController
    {
        readonly SubjectView subjectView;
        public List<Subject> subjects;
        public SubjectController(SubjectView subjectView)
        {
            this.subjectView = subjectView;
        }
        public async void LoadSubjects()
        {
            subjectView.homeView.SetLoad(true, "Đang tải thông tin danh sách môn học..");
            await Task.Delay(600);
            await Task.Run(()=> {
                 subjects = SubjectDA.Instance.GetSubjects();

            });
            subjectView.ShowData();
            subjectView.homeView.SetLoad(false);
        }
        public async void AddSubject(Subject subject)
        {
            subjectView.homeView.SetLoad(true, "Đang thực hiện, vui lòng đợi trong giây lát..");
            await Task.Delay(600);
            await Task.Run(()=> {
                SubjectDA.Instance.AddSubject(subject);
            });
            LoadSubjects();
        }
        public async void DeleteSubject(Subject subject)
        {
            subjectView.homeView.SetLoad(true, "Đang thực hiện, vui lòng đợi trong giây lát..");
            await Task.Delay(600);
            await Task.Run(() => {
                SubjectDA.Instance.DeleteSubject(subject);
            });
            LoadSubjects();
        }
        public async void UpdateSubject(Subject subject)
        {
            subjectView.homeView.SetLoad(true, "Đang thực hiện, vui lòng đợi trong giây lát..");
            await Task.Delay(600);
            await Task.Run(() => {
                SubjectDA.Instance.UpdateSubject(subject);
            });
            LoadSubjects();
        }
    }
}
