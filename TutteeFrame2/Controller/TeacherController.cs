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
    class TeacherController
    {
        bool isLoading = false;
        public List<Teacher> teachers;
        List<Teacher> originalTeachers;
        TeacherView view;
        public TeacherController(TeacherView _view)
        {
            view = _view;
        }
        public async void FetchData()
        {
            if (isLoading)
                return;
            isLoading = true;
            view.Home.SetLoad(true, "Đang tải danh sách giáo viên...");
            if (view.firstLoad)
            {
                List<Subject> subjects = new List<Subject>();
                await Task.Run(() => subjects = SubjectDA.Instance.GetSubjects());
                view.ShowSubjects(subjects);
                view.firstLoad = false;
            }
            //await Task.Delay(1000);
            await Task.Run(() =>
            {
                originalTeachers = TeacherDA.Instance.GetTeachers();
                switch (view.sortType)
                {
                    case TeacherView.SortType.ByID:
                        originalTeachers = originalTeachers.OrderBy(o => o.ID).ToList();
                        break;
                    case TeacherView.SortType.ByName:
                        originalTeachers = originalTeachers.OrderBy(o => o.FirstName).ThenBy(o => o.SurName).ToList();

                        break;
                    case TeacherView.SortType.ByBirthday:
                        originalTeachers = originalTeachers.OrderBy(o => o.DateBorn).ToList();
                        break;
                    default:
                        break;
                }
                Filter();
            });
            view.ShowData();
            view.Home.SetLoad(false);
            isLoading = false;
        }
        public void ChangeSortType()
        {
            switch (view.sortType)
            {
                case TeacherView.SortType.ByID:
                    teachers = teachers.OrderBy(o => o.ID).ToList();
                    break;
                case TeacherView.SortType.ByName:
                    teachers = teachers.OrderBy(o => o.FirstName).ThenBy(o => o.SurName).ToList();

                    break;
                case TeacherView.SortType.ByBirthday:
                    teachers = teachers.OrderBy(o => o.DateBorn).ToList();
                    break;
                default:
                    break;
            }
            view.ShowData();
        }
        public void CreateFilter(string searchText = "")
        {
            Filter(searchText);
            view.ShowData();
        }
        void Filter(string searchText = "")
        {
            if (!string.IsNullOrEmpty(view.subjectFilter))
            {
                teachers = GetTeachersBySubject(originalTeachers);
            }
            else
                teachers = originalTeachers;
            if (view.roleFilter != TeacherView.RoleFilter.All)
                teachers = GetTeachersByRole(teachers);
            if (!string.IsNullOrEmpty(searchText))
                teachers = GetTeachersBySearch(teachers, searchText);
        }
        List<Teacher> GetTeachersBySubject(List<Teacher> _origin)
        {
            List<Teacher> result = new List<Teacher>();
            foreach (Teacher teacher in _origin)
            {
                if (teacher.Subject.Name == view.subjectFilter)
                    result.Add(teacher);
            }
            return result;
        }
        List<Teacher> GetTeachersBySearch(List<Teacher> _origin, string searchText)
        {
            List<Teacher> result = new List<Teacher>();
            foreach (Teacher teacher in _origin)
            {
                if (teacher.ID.Contains(searchText) || teacher.GetName().Contains(searchText))
                    result.Add(teacher);
            }
            return result;
        }
        List<Teacher> GetTeachersByRole(List<Teacher> _origin)
        {
            List<Teacher> result = new List<Teacher>();
            switch (view.roleFilter)
            {
                case TeacherView.RoleFilter.All:
                    break;
                case TeacherView.RoleFilter.Teacher:
                    foreach (Teacher teacher in _origin)
                    {
                        if (teacher.Type == TeacherType.Teacher)
                            result.Add(teacher);
                    }
                    break;
                case TeacherView.RoleFilter.GVCN:
                    foreach (Teacher teacher in _origin)
                    {
                        if (teacher.Type == TeacherType.FormerTeacher)
                            result.Add(teacher);
                    }
                    break;
                case TeacherView.RoleFilter.Ministry:
                    foreach (Teacher teacher in _origin)
                    {
                        if (teacher.Type == TeacherType.Ministry)
                            result.Add(teacher);
                    }
                    break;
                case TeacherView.RoleFilter.Adminstrator:
                    foreach (Teacher teacher in _origin)
                    {
                        if (teacher.Type == TeacherType.Adminstrator)
                            result.Add(teacher);
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
