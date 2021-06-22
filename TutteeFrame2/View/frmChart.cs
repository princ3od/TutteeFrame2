using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TutteeFrame2.Reports.ReportControll;
using LiveCharts;
using LiveCharts.Wpf;

namespace TutteeFrame2.View
{
    public partial class frmChart : Form
    {
        private frmChartController controller;
        public frmChart()
        {
            InitializeComponent();
            controller = new frmChartController(this);
            controller.FetchData();
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {


            cartesianChart.Series.Clear();

            //LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            //int[] y = { 10, 20, 30, 40, 50 };
            //var objChart = new ColumnSeries
            //{
            //    Title = "Số học sinh",
            //    Values = new ChartValues<int>(y),
            //    DataLabels = true,
            //    LabelsPosition = BarLabelPosition.Top,
            //    FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
            //    FontSize = 11,
            //};
            //series.Add(objChart);
            //cartesianChart.Series = series;
            controller.GeneralChartOfAveragePointOfClass("10A2");

            cartesianChart.AxisX = controller.AxesX;
            cartesianChart.AxisY = controller.AxesY;
            cartesianChart.Series = controller.series;

        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Điểm trung bình",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" },
                Separator = new Separator { Step = 1 }
            });

            cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số học sinh",
                LabelFormatter = value => value.ToString()

            });
            cartesianChart.LegendLocation = LiveCharts.LegendLocation.Right;
        }
    }
}
