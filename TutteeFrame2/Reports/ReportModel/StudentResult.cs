using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutteeFrame2.Reports.ReportModel
{
    public class StudentResult
    {
         public String studentID;
         public String surName;
         public String firstName;
         public  String classID;
         public int semester;
         public double averagePoint;
        StudentResult(String studentID,String surName,String firstName,String classID,int semester,double averagePoint)
        {
            this.studentID = studentID;
            this.surName = surName;
            this.firstName = firstName;
            this.classID = classID;
            this.semester = semester;
            this.averagePoint = averagePoint;
        }
        public StudentResult() { }
    }
}
