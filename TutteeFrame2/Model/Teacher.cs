using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.Model
{
    class Teacher : Person
    {
        public enum TeacherType { Teacher = 4, Adminstrator = 3, Ministry = 2, FormerTeacher = 1 };

        private Subject subject;
        private TeacherType teacherType;
        private string formClassID;
        private string position;

        public Subject Subject { get => subject; set => subject = value; }
        public TeacherType Type { get => teacherType; set => teacherType = value; }
        public string FormClassID { get => formClassID; set => formClassID = value; }
        public string Position { get => (string.IsNullOrEmpty(position)) ? "Không" : position; set => position = value; }
    }
}
