using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITAcademyManager
{
    public static class ChartStyler
    {
        public static void StyleSuccessChart(Chart chart)
        {
            if (chart.Titles.Count > 0)
            {
                chart.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
            chart.Palette = ChartColorPalette.BrightPastel;
            chart.BackColor = Color.FromArgb(240, 240, 240);
            chart.ChartAreas[0].BackColor = Color.Transparent;
            chart.Series["Series1"].Color = Color.FromArgb(8, 118, 122);
            chart.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10);
            chart.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10);
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisY.Interval = 10;
            chart.ChartAreas[0].ShadowOffset = 3;
            chart.Series["Series1"].ShadowOffset = 2;
        }

        public static void StyleGroupCapacityChart(Chart chart)
        {
            if (chart.Titles.Count > 0)
            {
                chart.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
            chart.Palette = ChartColorPalette.EarthTones;
            chart.BackColor = Color.FromArgb(240, 240, 240);
            chart.ChartAreas[0].BackColor = Color.Transparent;
            chart.Series["Series1"].Color = Color.FromArgb(128, 0, 128);
            chart.Series["Series1"].BackGradientStyle = GradientStyle.DiagonalRight;
            chart.Series["Series1"].BackSecondaryColor = Color.FromArgb(192, 0, 192);
            chart.ChartAreas[0].AxisX.TitleFont = new Font("Segoe UI", 10);
            chart.ChartAreas[0].AxisY.TitleFont = new Font("Segoe UI", 10);
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisY.Interval = 1;
        }
    }
}