using System.Data;

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
