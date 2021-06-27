using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.DataVisualization.Charting;
using TutteeFrame2.Reports.ReportDataAccess;
using TutteeFrame2.Reports.ReportModel;
using TutteeFrame2.View;


namespace TutteeFrame2.Reports.ReportControll
{
    class frmChartController
    {

        private frmChart frmchart;
        private List<StudentPointResouce> ogrinalStudentPoint = new List<StudentPointResouce>();
        private List<StudentSubjectScore> orinalStudentSubjectScore = new List<StudentSubjectScore>();
        public List<String> cbbClassItem;
        public List<String> cbbSubjectItems;
        public List<double> value = new List<double>();
        public frmChartController(frmChart frmChart)
        {
            this.frmchart = frmChart;
        }

        public void FetchData()
        {
            frmchart.SetProgressBar(true, "On featching data from sever..");
            var t = Task.Run(() =>
             {
                 ogrinalStudentPoint = frmChartDA.istance.GetStudentPointResouce();
                 orinalStudentSubjectScore = frmChartDA.istance.GetStudentSubjectScore();
                 FetchItemCbbSubject();
             });
            t.Wait(1000);
            frmchart.SetProgressBar(false);
            frmchart.FetchSubjectItems();
        }
        public void FilterClassByGrade(String grade)
        {
            cbbClassItem = new List<String>();
            foreach (var item in ogrinalStudentPoint)
            {
                if (item.classID.Substring(0, 2) == grade && cbbClassItem.IndexOf(item.classID) == -1)
                {
                    cbbClassItem.Add(item.classID);
                }
            }
        }

        public void FetchItemCbbSubject()
        {
            cbbSubjectItems = new List<String>();
            Dictionary<String, String> subjectItems = new Dictionary<String, String> ();

            foreach(StudentSubjectScore item in orinalStudentSubjectScore)
            {

                if (!subjectItems.ContainsKey(item.subjectID))
                {
                    cbbSubjectItems.Add(item.subjectName);
                    subjectItems.Add(item.subjectID, item.subjectName);
                }
            }

           
        }

        public async void GeneralChartOfAveragePointOfClass(String classID)
        {
          
            await Task.Run(() =>
            {
                int[] y = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (var item in ogrinalStudentPoint)
                {
                    if (item.classID == classID)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            if (i <= item.averageYear && item.averageYear < i + 1) y[i] += 1;
                            if (item.averageYear == 10) y[10] += 1;
                        }
                    }
                }
                value.Clear();
                for (int i = 0; i < y.Length; i++)
                {
                    value.Add(y[i]);
                }

            });
           
            frmchart.SetCartesianChart();
        }

        public async void GeneralChartOfAveragePointOfClass(String classID, String Semester)
        {
            frmchart.SetProgressBar(true, "On creating the chart...");
            await Task.Run(() =>
            {
                int[] y = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                if (Semester == "Học kì 1")
                {
                    foreach (var item in ogrinalStudentPoint)
                    {
                        if (item.classID == classID)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (i <= item.averageSE01 && item.averageSE01 < i + 1) y[i] += 1;
                                if (item.averageSE01 == 10) y[10] += 1;
                            }
                        }
                    }
                }
                else
                {
                    foreach (var item in ogrinalStudentPoint)
                    {
                        if (item.classID == classID)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (i <= item.averageSE02 && item.averageSE02 < i + 1) y[i] += 1;
                                if (item.averageSE02 == 10) y[10] += 1;
                            }
                        }
                    }
                }
                value.Clear();
                for (int i = 0; i < y.Length; i++)
                {
                    value.Add(y[i]);
                }

            });

           
            frmchart.SetCartesianChart();
        }

        public async void GeneralChartOfAveragePointOfGrade(String grade)
        {
            frmchart.SetProgressBar(true, "On loading ui");
            
            await Task.Run(() =>
            {
                double[] y = new double[cbbClassItem.Count];
                for (int i = 0; i < y.Length; i++)
                {
                    y[i] = 0;
                }
                for (int i = 0; i < cbbClassItem.Count; i++)
                {
                    int count = 0;
                    double sum = 0;
                    for (int j = 0; j < ogrinalStudentPoint.Count; j++)
                    {
                        if (cbbClassItem[i] == ogrinalStudentPoint[j].classID)
                        {
                            count += 1;
                            sum += ogrinalStudentPoint[j].averageYear;
                        }
                    }
                    y[i] = Math.Round((sum / count), 2);
                }

                List<String> classItem = new List<String>(cbbClassItem);
                InsertionSort(y, classItem);
                value.Clear();
                for (int i = 0; i < y.Length; i++)
                {
                    value.Add(y[i]);
                }
            });
            
            frmchart.SetCartesianChart();

        }
        private void InsertionSort(double[] arr, List<String> arr2)
        {
            int j;
            double temp;
            String temp2;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                temp2 = arr2[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    arr2[j + 1] = arr2[j];
                    j--;
                }
                arr[j + 1] = temp;
                arr2[j + 1] = temp2;
            }
        }
    
        public async void GeneralChartOfSubjectByClass(String cbbClass,  String cbbSubject,  String cbbSemester)
        {
           bool avalible = true;
           var t =  Task.Run(() =>
            {
                List<StudentSubjectScore> studentSubjectScores = new List<StudentSubjectScore>();
                foreach(var item in orinalStudentSubjectScore)
                {
                    String semester = $"Học kì {item.semester}";
                    if(item.classID == cbbClass && item.subjectName == cbbSubject && semester == cbbSemester)
                    {
                        studentSubjectScores.Add(item);

                    }
                }
                int[] y = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < 10 && avalible; i++)
                {
                    for(int j = 0; j < studentSubjectScores.Count && avalible; j++)
                    {
                        if(studentSubjectScores[j].subjectAverage <= i)
                        {
                            if(studentSubjectScores[j].subjectAverage < 0)
                            {
                                avalible = false;
                            }
                            y[i] += 1;
                            studentSubjectScores.Remove(studentSubjectScores[j]);
                            j -= 1;
                        }
                    }
                }
                value.Clear();
                if(avalible)
                for (int i = 0; i < y.Length; i++)
                {
                    value.Add(y[i]);
                }

            });
            t.Wait();
            if(avalible)
            {
                frmchart.SetCartesianChart();
            }
            else
            {
                MessageBox.Show("Dữ liêu chưa đủ để lập biểu đồ");
            }
        }

    }
}
