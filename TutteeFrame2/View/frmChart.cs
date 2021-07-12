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
        public void SetProgressBar(bool visible, String textinfo = "")
        {
            mainProgressbar.Visible = visible;
            lbInformation.Text = textinfo;
            lbInformation.Visible = visible;
        }

        private void   btnGenarate_ClickAsync(object sender, EventArgs e)
        {
            SetProgressBar(true, "Đang tạo biểu đồ ...");

            cartesianChart.DataTooltip = new LiveCharts.Wpf.DefaultTooltip();
            if (cbbType.Text == "TBHK Lớp")
            {
                if (cbbSemester.SelectedIndex == 2 || cbbSemester.SelectedIndex==-1)
                {
                    controller.GeneralChartOfAveragePointOfClass(cbbClass.Text);
                }
                else
                {
                    controller.GeneralChartOfAveragePointOfClass(cbbClass.Text, cbbSemester.Text);
                }
            }
            else if (cbbType.Text == "TBHK Khối")
            {
                controller.GeneralChartOfAveragePointOfGrade(cbbGrade.Text);
            }
            else if (cbbType.Text == "TBHK Môn-Lớp")
            {

                controller.GeneralChartOfSubjectByClass(cbbClass.Text,cbbSubject.Text,cbbSemester.Text);
            }

        }

        public void SetCartesianChart()
        {
            var AxesX = new AxesCollection();
            var AxesY = new AxesCollection();
            
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            series.Clear();

            if (cbbType.Text == "TBHK Khối")
            {

                AxesX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Điểm trung bình",
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator { Step = 1 },
                    MinValue = 0

                }); ;
                AxesY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Lớp",
                    Labels = controller.cbbClassItem,
                    Separator = new Separator { Step = 1 },
                    MinValue = 0

                }); ;

                var objChart = new RowSeries { };
                objChart.Values = new ChartValues<double>(controller.value);
                objChart.Title = "Điểm trung bình";
                objChart.DataLabels = true;
                objChart.LabelPoint = point => point.X +"";
                objChart.LabelsPosition = BarLabelPosition.Top;
                objChart.FontFamily = new System.Windows.Media.FontFamily("Segoe UI");
                objChart.FontSize = 11;
                series.Add(objChart);

            }
            else if (cbbType.Text == "TBHK Lớp")
            {

                AxesX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Điểm trung bình",
                    Labels = new[] { "<=1", "<=2", "<=3", "<=4", "<=5", "<=6", "<=7", "<=8", "<=9", "<=10" },
                    Separator = new Separator { Step = 1 },
                    LabelsRotation = -90,
                    
                });
                AxesY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Số học sinh",
                    LabelFormatter = value => value.ToString(),
                    MinValue = 0,
                    Separator = new Separator { Step = 1 },

                }); ;

                var objChart = new ColumnSeries { };
                objChart.Title = "Số học sinh";
                objChart.Values = new ChartValues<double>(controller.value);
                objChart.DataLabels = true;
                objChart.LabelsPosition = BarLabelPosition.Top;
                objChart.FontFamily = new System.Windows.Media.FontFamily("Segoe UI");
                objChart.FontSize = 11;
                series.Add(objChart);
                

            }
            else if(cbbType.Text == "TBHK Môn-Lớp")
            {
                AxesX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = $"Điểm trung bình môn {cbbSubject.Text}",
                    Labels = new[] { "<=1", "<=2", "<=3", "<=4", "<=5", "<=6", "<=7", "<=8", "<=9", "<=10" },
                    Separator = new Separator { Step = 1 },
                    MinValue = 0,
                    LabelsRotation = -90,

                });
                AxesY.Add(new LiveCharts.Wpf.Axis
                {
                    Separator = new Separator { Step = 1 },
                    Title = "Số học sinh",
                    LabelFormatter = value => value.ToString()

                });

                var objChart = new ColumnSeries { };
                objChart.Title = "Số học sinh";
                objChart.Values = new ChartValues<double>(controller.value);
                objChart.DataLabels = true;
                objChart.LabelsPosition = BarLabelPosition.Top;
                objChart.FontFamily = new System.Windows.Media.FontFamily("Segoe UI");
                objChart.FontSize = 11;
                series.Add(objChart);
            }
            cartesianChart.Series = series;
            cartesianChart.AxisX = AxesX;
            cartesianChart.AxisY = AxesY;
            SetProgressBar(false);
            cartesianChart.Refresh();
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

        private void cbbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.FilterClassByGrade(cbbGrade.Text);
            FetchClassItem();
        }
        public void FetchClassItem()
        {
            if (!cbbClass.Enabled) return;
            cbbClass.Items.Clear();
            foreach (var item in controller.cbbClassItem)
            {
                cbbClass.Items.Add(item);
            }
        }
        public void FetchSubjectItems()
        {
            cbbSubject.Items.Clear();
            foreach(var item in controller.cbbSubjectItems)
            {
                cbbSubject.Items.Add(item);
            }
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbType.SelectedIndex == 0)
            {
                cbbGrade.Enabled = true;
                cbbClass.Enabled = true;
                cbbSemester.Enabled = true;
                cbbSubject.Enabled = false;
                cbbSemester.SelectedIndex = -1;
                cbbGrade.SelectedIndex = -1;
                cbbClass.SelectedIndex = -1;


            }
            else if (cbbType.SelectedIndex == 1)
            {
                cbbGrade.Enabled = true;
                cbbClass.Enabled = false;
                cbbSemester.Enabled = false;
                cbbSubject.Enabled = false;

                cbbClass.SelectedIndex = -1;
                cbbSemester.SelectedIndex = -1;
                cbbSubject.SelectedIndex = -1;
            }
            else if (cbbType.SelectedIndex == 2)
            {
                cbbGrade.Enabled = true;
                cbbClass.Enabled = true;
                cbbSemester.Enabled = true;
                cbbSubject.Enabled = true;
            }
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
