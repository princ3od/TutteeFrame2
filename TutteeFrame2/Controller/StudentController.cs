using MaterialSurface;
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
        public List<string> cbbClassItems;
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
            FetchCbbClassItems();
            isLoading = false;
            studentView.homeView.SetLoad(false);
        }

        private void FilterStudentsInOrginalByGrade(String grade)
        {
            students = new List<Student>();
            cbbClassItems = new List<string>();
            if (grade != "All")
            {
                foreach (var student in originalStudents)
                {
                    if (student.ClassID.Substring(0, 2) == grade)
                    {
                        students.Add(student);
                    }
                }
            }
            else
            {
                students = originalStudents;
            }
        }
        public void FilterStudentByGrade()
        {
            switch (studentView.gradeFilter)
            {
                case StudentView.GradeFilter.All:
                    FilterStudentsInOrginalByGrade("All");
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

        public void FilterStudentByClass()
        {
            List<Student> classStudents = new List<Student>();
            if(studentView.classFilter=="Tất cả")
            {
                FilterStudentByGrade();
                classStudents = students;
            }
            else
            {
                foreach(var student in originalStudents)
                {
                    if(student.ClassID == studentView.classFilter)
                    {
                        classStudents.Add(student);
                    }
                }
            }
            students = classStudents;
            studentView.ShowStudentsOnListView();
        }
        
        public void FetchCbbClassItems()
        {
            cbbClassItems = new List<string>();
            foreach(var item in students)
            {
                if (cbbClassItems.IndexOf(item.ClassID) == -1)
                {
                    cbbClassItems.Add(item.ClassID);
                }
            }
            studentView.FetchCbbClassItems();
            studentView.SetIndexOfCbbClassItemSelected(0);
        }
    
        public Student GetStudentByID(string studentID)
        {
            return StudentDA.Instance.GetStudentByID(studentID);
        }

        public bool UpdateStudent(Student student)
        {
            return DataAccess.StudentDA.Instance.UpdateStudent(student);
        }

        public bool AddStudent(Student student)
        {
            return DataAccess.StudentDA.Instance.AddStudent(student);
        }

        public async void DeleteStudent(string studentID)
        {
            bool progressResult = false ;
            studentView.homeView.SetLoad(true, "Thao tác đang được thực hiện");
            Task.Delay(1000);
            await Task.Run(()=> {
                progressResult =  StudentDA.Instance.DeleteStudent(studentID);
            });
            studentView.homeView.SetLoad(false);
            if (progressResult)
            {
                Snackbar.MakeSnackbar(studentView.homeView, $"Đã xóa thành công học sinh có mã học sinh {studentID}", buttonText: "Thông báo");
                studentView.FetchData();
            }
        }
        public void FindStudent(String searchStr)
        {
            students = new List<Student>();
            if(searchStr.All(Char.IsDigit) && searchStr.Length == 8)
            {
                foreach (var student in originalStudents)
                {
                    if (student.ID == searchStr)
                    {
                        students.Add(student);
                        break;
                    }
                }
            }
            else
            {
                foreach (var student in originalStudents)
                {
                    if (student.FirstName == searchStr)
                    {
                        students.Add(student);
                    }
                }
            }

            this.studentView.ShowStudentsOnListView();
        }

    }
}
