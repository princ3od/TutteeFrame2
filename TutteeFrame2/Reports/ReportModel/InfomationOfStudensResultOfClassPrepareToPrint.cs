using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.Reports.ReportModel
{
   public class InfomationOfStudensResultOfClassPrepareToPrint

    {
        public DataSet BaseInforSchool = new DataSet();
        public DataSet ds = new DataSet();
        public string formalTeacher { get; set; }
        public string classID { get; set; }
    }
}
