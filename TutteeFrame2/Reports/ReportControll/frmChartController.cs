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
        public LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
        public AxesCollection AxesX = new AxesCollection();
        public AxesCollection AxesY = new AxesCollection();
        private List<StudentPointResouce> ogrinalStudentPoint = new List<StudentPointResouce>();
        public frmChartController(frmChart frmChart)
        {
            this.frmchart = frmChart;
        }

        public void FetchData()
        {
            bool isFetching = true;
            Task.Run(() =>
            {
                ogrinalStudentPoint = frmChartDA.istance.GetStudentPointResouce();
                isFetching = false;
            }
            );
        }

        public void OnGeneralClicked(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }
        }

        public void GeneralChartOfAveragePointOfClass(String classID)
        {
            series.Clear();
            var objChart = new ColumnSeries { };
            objChart.Title = "Số học sinh";
            String[] x = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            AxesX.Clear();
            AxesX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Điểm trung bình",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" },
                Separator = new Separator { Step = 2 }
            });

            AxesY.Clear();
            AxesY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số học sinh",
                LabelFormatter = value => value.ToString()

            });

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
            objChart.Values = new ChartValues<int>(y);
            objChart.DataLabels = true;
            objChart.LabelsPosition = BarLabelPosition.Top;
            objChart.FontFamily = new System.Windows.Media.FontFamily("Segoe UI");
            objChart.FontSize = 11;
            series.Add(objChart);
        }


    }
}
