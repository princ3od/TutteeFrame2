using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
