using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<String> cbbClassItem;
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

             });
            t.Wait();
            frmchart.SetProgressBar(false);

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
            frmchart.SetProgressBar(false);
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

            frmchart.SetProgressBar(false);
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
            frmchart.SetProgressBar(false);
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
    }
}
