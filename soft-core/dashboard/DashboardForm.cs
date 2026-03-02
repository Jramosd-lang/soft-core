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
    }
}