using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.Model
{
    class Class
    {
        private string _classID;
        private string _roomNumber;
        private int _studentNumber;
        private string _teacherFormalID;
        public string classID
        {
            get
            {
                return  _classID;
            }
            set
            {
                _classID = value;
            }
        }
        public string roomNumber
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
        public int studentNumber
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
        public string teacherFormalID
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
