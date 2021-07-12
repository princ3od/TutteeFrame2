using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame2.Controller;

namespace TutteeFrame2.Model
{
    public enum TeacherType { SuperUser = 5, Teacher = 4, Adminstrator = 3, Ministry = 2, FormerTeacher = 1 };
    public class Teacher : Person
    {
        public TeacherController controller;

        private Subject subject;
        private TeacherType teacherType;
        private string formClassID;
        private string position;
        private List<string> classes;

        public Subject Subject { get => subject; set => subject = value; }
        public TeacherType Type { get => teacherType; set => teacherType = value; }
        public string FormClassID { get => formClassID; set => formClassID = value; }
        public string Position { get => (string.IsNullOrEmpty(position)) ? "Không" : position; set => position = value; }
        public List<string> Classes { get => classes; set => classes = value; }
        //public async void GetClasses()
        //{
        //    await Task.Delay(600);
        //    await Task.Run(() =>
        //    {
        //        controller.GetClasses(this);
        //    });
        //}
        public string GetNote()
        {
            string teacherNote = "";
            switch (teacherType)
            {
                case TeacherType.Teacher:
                    teacherNote = "";
                    break;
                case TeacherType.Adminstrator:
                    teacherNote = "Ban giám hiệu.";
                    break;
                case TeacherType.Ministry:
                    teacherNote = "Giáo vụ.";
                    break;
                case TeacherType.FormerTeacher:
                    teacherNote = "GVCN lớp " + formClassID + ".";
                    break;
                default:
                    break;
            }
            return teacherNote;
        }
        public string GetSubject()
        {
            return subject.Name;
        }
        public string GetPosition()
        {
            return position;
        }
    }
}
