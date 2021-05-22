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
        public List<Student> originalStudents;
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
                originalStudents = DataAccess.StudentDA.Instance.GetStudents();
          
            });
            FilterStudentByGrade();
            isLoading = false;
            studentView.homeView.SetLoad(false);
        }

        private void FilterStudentsInOrginalByGrade(String grade)
        {
            students = new List<Student>();
            foreach(var student in originalStudents)
            {
                if(student.ClassID.Substring(0,2) == grade)
                {
                    students.Add(student);
                }
            }
        }
        public void FilterStudentByGrade()
        {
            switch (studentView.gradeFilter)
            {
                case StudentView.GradeFilter.All:
                    students = originalStudents;
                    break;
                case StudentView.GradeFilter.Grade10:
                    FilterStudentsInOrginalByGrade("10");
                    break;
                case StudentView.GradeFilter.Grade11:
                    FilterStudentsInOrginalByGrade("11");
                    break;
                case StudentView.GradeFilter.Grade12:
                    FilterStudentsInOrginalByGrade("12");
                    break;
                default:
                    break;
            }
            studentView.ShowStudentsOnListView();
        }
        public void ChangeSortType()
        {
            switch (studentView.sortType)
            {
                case StudentView.SortType.ByID:
                    students = students.OrderBy(o => o.ID).ToList();
                    break;
                case StudentView.SortType.ByBirthday:
                    students = students.OrderBy(o => o.DateBorn).ToList();
                    break;
                case StudentView.SortType.ByName:
                    students = students.OrderBy(o => o.FirstName).ThenBy(o=>o.SurName).ToList();
                    break;
                case StudentView.SortType.BySex:
                    students = students.OrderBy(o => o.Sex).ToList();
                    break;
                default:
                    break;
            }
            studentView.ShowStudentsOnListView();
        }


    }
}
