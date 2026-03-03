using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using soft_core.UI;

namespace soft_core.dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            Theme.ApplyForm(this);
            CargarDatosGraficas();
        }

        private void CargarDatosGraficas()
        {
            ConfigurarGraficaVentasDiarias();
            ConfigurarGraficaCategorias();
            ConfigurarGraficaCajaVsReal();
        }

        private void ConfigurarGraficaVentasDiarias()
        {
            chartGananciaDiaria.Series.Clear();

            var serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Line;
            serie.XValueType = ChartValueType.String;
            serie.IsXValueIndexed = true; // 🔥 CLAVE
            serie.BorderWidth = 3;
            serie.IsValueShownAsLabel = true;

            serie.Points.AddXY("Lun", 1250);
            serie.Points.AddXY("Mar", 1420);
            serie.Points.AddXY("Mié", 1380);
            serie.Points.AddXY("Jue", 1650);
            serie.Points.AddXY("Vie", 2100);
            serie.Points.AddXY("Sáb", 1850);
            serie.Points.AddXY("Dom", 1200);

            chartGananciaDiaria.Series.Add(serie);

            var area = chartGananciaDiaria.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.LabelStyle.Format = "C0";
        }

        private void ConfigurarGraficaCajaVsReal()
        {
            chartCajaVsReal.Series.Clear();
            chartCajaVsReal.ChartAreas.Clear();
            ChartArea area = new ChartArea();
            chartCajaVsReal.ChartAreas.Add(area);

            Series serie = new Series("Caja");
            serie.ChartType = SeriesChartType.Area;
            serie.XValueType = ChartValueType.String;
            serie.IsXValueIndexed = true;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "C0";
            serie["PieLabelStyle"] = "Outside";
            serie["PieLineColor"] = "Black";

            serie.Points.AddXY("Lun", 1250);
            serie.Points.AddXY("Mar", 1420);
            serie.Points.AddXY("Mié", 1380);
            serie.Points.AddXY("Jue", 1650);
            serie.Points.AddXY("Vie", 2100);

            Series serie2 = new Series("Real");
            serie2.ChartType = SeriesChartType.Area;
            serie2.XValueType = ChartValueType.String;
            serie2.IsXValueIndexed = true;
            serie.IsValueShownAsLabel = true;
            serie2.LabelFormat = "C0";
            serie2["PieLabelStyle"] = "Outside";
            serie2["PieLineColor"] = "Black";

            serie2.Points.AddXY("Lun", 1150);
            serie2.Points.AddXY("Mar", 1500);
            serie2.Points.AddXY("Mié", 1300);
            serie2.Points.AddXY("Jue", 1600);
            serie2.Points.AddXY("Vie", 2200);

            chartCajaVsReal.Series.Add(serie);
            chartCajaVsReal.Series.Add(serie2);

        }

        private void ConfigurarGraficaCategorias()
        {
            chartProductosMasVendidos.Series.Clear();
            chartProductosMasVendidos.ChartAreas.Clear();

            ChartArea area = new ChartArea();
            chartProductosMasVendidos.ChartAreas.Add(area);

            Series serie = new Series("Categorías");
            serie.ChartType = SeriesChartType.Doughnut;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "P0";
            serie["PieLabelStyle"] = "Outside";
            serie["PieLineColor"] = "Black";

            serie.Points.AddXY("Electrónica", 35);
            serie.Points.AddXY("Oficina", 28);
            serie.Points.AddXY("Hogar", 22);
            serie.Points.AddXY("Otros", 15);

            chartProductosMasVendidos.Series.Add(serie);

            chartProductosMasVendidos.Legends.Clear();
            Legend legend = new Legend();
            legend.Docking = Docking.Bottom;
            chartProductosMasVendidos.Legends.Add(legend);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartGananciaDiaria_Click(object sender, EventArgs e)
        {

        }
    }
}