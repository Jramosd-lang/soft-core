using System;
using System.Windows.Forms;
using soft_core.UI;

namespace soft_core.reportes
{
    public partial class InformeVentasForm : Form
    {
        public InformeVentasForm()
        {
            InitializeComponent();
            Theme.ApplyForm(this);
            Theme.ApplyDataGridView(dgvVentas);
            if (cmbSucursal.Items.Count > 0) cmbSucursal.SelectedIndex = 0;
            CargarEjemplo();
        }

        private void CargarEjemplo()
        {
            dgvVentas.Rows.Clear();
            var semanas = new[] { "Sem 1", "Sem 2", "Sem 3", "Sem 4", "Mensual" };
            var montos = new[] { 12500.50m, 14200.75m, 13800.25m, 15100.00m, 55601.50m };
            for (int i = 0; i < semanas.Length; i++)
            {
                dgvVentas.Rows.Add(semanas[i], $"01/01 - 07/01 (ejemplo)", montos[i].ToString("C"), (i * 45 + 120).ToString());
            }
            CargarGrafica();
        }

        private void CargarGrafica()
        {
            if (chartVentas.Series.Count == 0)
            {
                chartVentas.Series.Add("Ventas");
                chartVentas.ChartAreas.Add("ChartArea1");
                chartVentas.Series[0].ChartArea = "ChartArea1";
            }
            chartVentas.Series[0].Points.Clear();
            chartVentas.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartVentas.Series[0].Points.AddXY("Sem 1", 12500);
            chartVentas.Series[0].Points.AddXY("Sem 2", 14200);
            chartVentas.Series[0].Points.AddXY("Sem 3", 13800);
            chartVentas.Series[0].Points.AddXY("Sem 4", 15100);
            chartVentas.Series[0].Points.AddXY("Mensual", 55601);
        }
    }
}
