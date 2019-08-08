using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BackToBasic
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
            
        }

        Chart pieChart;

        private void InitializeChart()
        {

            
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend()
            { BackColor = Color.Green, ForeColor = Color.Black, Title = "Aux Reasons" };
            
            pieChart = new Chart();
            

            ((ISupportInitialize)(pieChart)).BeginInit();

            SuspendLayout();

            //===Pie chart
            chartArea1.Name = "PieChartArea";
            pieChart.ChartAreas.Add(chartArea1);
            pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            pieChart.Legends.Add(legend1);
            pieChart.Location = new System.Drawing.Point(0, 50);
            pieChart.ChartAreas["PieChartArea"].AxisX.LabelStyle.Format = "HH:mm:ss";

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.Load += new EventHandler(frmChart_Load);
            //((ISupportInitialize)(this.pieChart)).EndInit();
            //this.ResumeLayout(false);

        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            InitializeChart();
            LoadPieChart();
          

            #region comment
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Car", typeof(string));
            //dt.Columns.Add("Price", typeof(int));

            //int x = 3;
            //while(x != 0)
            //{ 
            //    DataRow dr = dt.NewRow();
            //    dr[0] = string.Format("Car {0}",x);
            //    dr[1] = 100 * x;
            //    dt.Rows.Add(dr);
            //    x--;
            //}
            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);


            //Chart chart = new Chart();
            //chart.Series.Clear();
            //chart.Width = this.panel1.Width;
            //chart.Height = this.panel1.Height;

            //chart.Legends.Add(new Legend() { Name = "Legend" });
            //chart.Legends[0].Docking = Docking.Right;

            //ChartArea chartArea = new ChartArea() { Name = "ChartArea" };
            //chartArea.AxisX.MajorGrid.LineWidth = 0;
            //chartArea.AxisY.MajorGrid.LineWidth = 0;
            //chartArea.BackColor = Color.White;
            //chart.ChartAreas.Add(chartArea);
            //chart.Palette = ChartColorPalette.BrightPastel;

            //string[] seriesArray = ds.Tables[0].AsEnumerable().Select(xx => xx[0].ToString()).ToArray();
            //int[] pointsArray = ds.Tables[0].AsEnumerable().Select(xx => xx[1].ToString()).ToArray().Select(int.Parse).ToArray();

            //// Set title
            //chart.Titles.Add("Total Production Count");

            //// Add series.
            //for (int i = 0; i < seriesArray.Length; i++)
            //{
            //    Series series = chart.Series.Add(seriesArray[i]);
            //    series.ChartType = SeriesChartType.Pie;
            //    series.IsValueShownAsLabel = true;

            //    series["PointWidth"] = "2";
            //    series["DrawingStyle"] = "Cylinder";
            //    series.Points.Add(pointsArray[i]);
            //}

            //panel1.Controls.Clear();
            //panel1.Controls.Add(chart);
            #endregion

        }

        void LoadPieChart()
        {

            TimeSpan x = new TimeSpan();
            x = TimeSpan.Parse("00:01:05");
            double j = x.TotalSeconds;


            pieChart.Series.Clear();
            pieChart.Palette = ChartColorPalette.Fire;
            pieChart.BackColor = Color.White;
            pieChart.Titles.Add("Employee");
            pieChart.ChartAreas[0].BackColor = Color.Transparent;
            
            Series series1 = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.AliceBlue,
                ChartType = SeriesChartType.Pie
            };

            pieChart.Series.Add(series1);
            series1.Points.Add(70000);
            series1.Points.Add(30000);

            var p1 = series1.Points[0];
            p1.AxisLabel = "70000";
            p1.LegendText = "Hiren Khirsaria";

            var p2 = series1.Points[1];
            p2.AxisLabel = "30000";
            p2.LegendText = "ABC XYZ";

            pieChart.Invalidate();
            pnlPie.Controls.Add(pieChart);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        }
    }
}
