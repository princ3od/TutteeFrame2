using System;

namespace TutteeFrame2.Reports.ReportModel
{
    class StudentPointResouce
    {
        public String id;
        public String classID;
        public float averageSE01;
        public float averageSE02;
        public float averageYear
        {
            get => (averageSE01 + averageSE02) / 2;
        }

    }
}
