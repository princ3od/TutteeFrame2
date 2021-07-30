using System;

namespace TutteeFrame2.Reports.ReportModel
{
    public class StudentSubjectScore
    {
        public String studentID;
        public String classID;
        public String subjectID;
        public String subjectName;
        public int semester;
        public  double subjectAverage;

        public StudentSubjectScore(String studentID,
        String classID,
        String subjectID,
        String subjectName,
        int semester,
        double subjectAverage
            )
        {
            this.studentID = studentID;
            this.classID = classID;
            this.subjectID = subjectID;
            this.subjectName = subjectName;
            this.semester = semester;
            this.subjectAverage = subjectAverage;
        }
    }
}
