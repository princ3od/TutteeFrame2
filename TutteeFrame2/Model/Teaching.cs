namespace TutteeFrame2.Model
{
    class Teaching
    {
        private string teachingID;
        private string classID;
        private Subject subject;
        private int semester;
        private int year;
        private bool editable;
        private string teacherID;
        private string teacherName;

       
        public Teaching()
        {

        }
        public string ID { get => teachingID; set => teachingID = value; }
        public string ClassID { get => classID; set => classID = value; }
        public Subject Subject { get => subject; set => subject = value; }
        public int Semester { get => semester; set => semester = value; }
        public int Year { get => year; set => year = value; }
        public bool Editable { get => editable; set => editable = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }

    }
}