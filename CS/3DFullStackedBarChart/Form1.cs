using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace _DFullStackedBarChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl fullStackedBar3DChart = new ChartControl();

            // Create two series of the FullStackedBar3D view type.
            Series series1 = new Series("Series 1", ViewType.FullStackedBar3D);
            Series series2 = new Series("Series 2", ViewType.FullStackedBar3D);

            // Populate both series with points.
            series1.Points.Add(new SeriesPoint("A", 80));
            series1.Points.Add(new SeriesPoint("B", 20));
            series1.Points.Add(new SeriesPoint("C", 50));
            series1.Points.Add(new SeriesPoint("D", 30));
            series2.Points.Add(new SeriesPoint("A", 40));
            series2.Points.Add(new SeriesPoint("B", 60));
            series2.Points.Add(new SeriesPoint("C", 20));
            series2.Points.Add(new SeriesPoint("D", 80));

            // Add the series to the chart.
            fullStackedBar3DChart.Series.AddRange(new Series[] {
                series1,
                series2});

            // Adjust the view-type-specific options of the second series.
            FullStackedBar3DSeriesView myView = (FullStackedBar3DSeriesView)series2.View;
            myView.Transparency = 20;
            myView.Model = Bar3DModel.Cylinder;
            myView.ShowFacet = false;

            // Access the diagram's options.
            ((XYDiagram3D)fullStackedBar3DChart.Diagram).ZoomPercent = 110;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Full Stacked Bar Chart";
            fullStackedBar3DChart.Titles.Add(chartTitle1);
            fullStackedBar3DChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add the chart to the form.
            fullStackedBar3DChart.Dock = DockStyle.Fill;
            this.Controls.Add(fullStackedBar3DChart);
        }

    }
}