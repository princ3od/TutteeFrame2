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
    class StudentController
    {
        public readonly StudentView studentView;
        public  List<Student> students;
        bool isLoading = false;
        public StudentController(StudentView studentView)
        {
            this.studentView = studentView;
        }
        public async void FetchData()
        {
            if (isLoading) return;
            isLoading = true;
            studentView.homeView.SetLoad(true, "Đang đồng bộ hóa dữ liệu, vui lòng chờ trong ít phút...");
            await Task.Run(() => {
                students = DataAccess.StudentDA.Instance.GetStudents();
          
            });
            studentView.ShowStudentsOnListView();
            isLoading = false;
            studentView.homeView.SetLoad(false);
        }
        
    }
}
