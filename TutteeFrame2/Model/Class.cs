namespace TutteeFrame2.Model
{
    public class Class
    {
        private string _classID;
        private string _roomNumber;
        private int _studentNumber;
        private string _teacherFormalID;
        public string ClassID
        {
            get
            {
                return _classID;
            }
            set
            {
                _classID = value;
            }
        }
        public string RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
            }
        }
        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }
            set
            {
                _studentNumber = value;
            }
        }
        public string FormalTeacherID
        {
            get
            {
                return _teacherFormalID;
            }
            set
            {
                _teacherFormalID = value;
            }
        }

    }
}
