using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TutteeFrame2.Model;
using TutteeFrame2.View;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Data;
using TutteeFrame2.DataAccess;

namespace TutteeFrame2.Controller
{
    public class ReportStudentController
    {
        public ReportStudentController(frmStudentReport frmStudentReport) {
            this.frmStudentReport = frmStudentReport;
        }
        private frmStudentReport frmStudentReport;
        private List<Student> originalStudents = new List<Student>();
        public List<Student> students;
        public List<string> cbbClassItems;
        private void FilterStudentsInOrginalByGrade(String grade)
        {
            students = new List<Student>();
            cbbClassItems = new List<string>();
            if (grade != "All")
            {
                foreach (var student in originalStudents)
                {
                    if (student.ClassID.Substring(0, 2) == grade)
                    {
                        students.Add(student);
                    }
                }
            }
            else
            {
                students = originalStudents;
            }
        }



        public void FilterStudentByGrade()
        {
            switch (frmStudentReport.gradeFilter)
            {
                case frmStudentReport.GradeFilter.All:
                    FilterStudentsInOrginalByGrade("All");
                    break;
                case frmStudentReport.GradeFilter.Grade10:
                    FilterStudentsInOrginalByGrade("10");
                    break;
                case frmStudentReport.GradeFilter.Grade11:
                    FilterStudentsInOrginalByGrade("11");
                    break;
                case frmStudentReport.GradeFilter.Grade12:
                    FilterStudentsInOrginalByGrade("12");
                    break;
                default:
                    break;
            }
           // frmStudentReport.ShowStudentsOnListView();
        }
        public void FetchCbbClassItems()
        {
            cbbClassItems = new List<string>();
            foreach (var item in students)
            {
                if (cbbClassItems.IndexOf(item.ClassID) == -1)
                {
                    cbbClassItems.Add(item.ClassID);
                }
            }
            frmStudentReport.FetchCbbClassItems();
        }


        public void FilterStudentByClass()
        {
            List<Student> classStudents = new List<Student>();
            if (frmStudentReport.classFilter == "Tất cả")
            {
                FilterStudentByGrade();
                classStudents = students;
            }
            else
            {
                foreach (var student in originalStudents)
                {
                    if (student.ClassID == frmStudentReport.classFilter)
                    {
                        classStudents.Add(student);
                    }
                }
            }
            students = classStudents;
            frmStudentReport.ShowStudentsOnListView();
        }


        public async void FetchData()
        {
            await Task.Run(() => {
                originalStudents = DataAccess.StudentDA.Instance.GetStudents();

            });
            FilterStudentByGrade();
            FetchCbbClassItems();
        }
        public DataTable convertListStudentToDataTable(List<Student> students)
        {
            System.Data.DataTable table = new DataTable("STUDENT");
            DataColumn column;
            DataRow row;

            //id
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "StudentID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);

            //first name
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "FirstName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //surname
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "SurName";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //sex
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Sex";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //date of born
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "DateBorn";
            column.ReadOnly = true;
            table.Columns.Add(column);

            //
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["ID"];
            table.PrimaryKey = PrimaryKeyColumns;

            foreach(var student in students)
            {
                row = table.NewRow();
                row["StudentID"] = student.ID;
                row["FirstName"] = student.FirstName;
                row["SurName"] = student.SurName;
                row["Sex"] = student.GetSex;
                row["DateBorn"] = student.DateBorn;
                table.Rows.Add(row);
            }
            return table;
        }

        public DataTable LoadDataInfoShool()
        {
            DataTable schoolInfo = SchoolDA.instance.getSchoolInfo();
            return schoolInfo;

        }
        public DataTable LoadDataToStudentInfoReporter()
        {
            DataTable studentInfoTable = convertListStudentToDataTable(students);
            return studentInfoTable;
        }


    }
}
