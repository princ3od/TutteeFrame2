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
            subjectView.homeView.SetLoad(true, "Đang tải thông tin danh sách môn học");
            await Task.Delay(600);
            await Task.Run(()=> {
                 subjects = SubjectDA.Instance.GetSubjects();

            });
            subjectView.ShowData();
            subjectView.homeView.SetLoad(false);
        }


    }
}
