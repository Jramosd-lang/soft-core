using System;
using System.Windows.Forms;
using soft_core.UI;

namespace soft_core.caja
{
    public partial class CajaForm : Form
    {
        public CajaForm()
        {
            InitializeComponent();
            Theme.ApplyForm(this);
            Theme.ApplyDataGridView(dgvVentasDiarias);
            CargarEjemploVentas();
        }

        private void CargarEjemploVentas()
        {
            dgvVentasDiarias.Rows.Clear();
            var horas = new[] { "08:15", "08:45", "09:30", "10:00", "11:20", "12:05", "13:40", "14:10", "15:25", "16:00" };
            var montos = new[] { 45.50m, 120.00m, 85.25m, 32.00m, 256.50m, 89.00m, 145.75m, 67.25m, 198.00m, 111.75m };
            for (int i = 0; i < horas.Length; i++)
            {
                dgvVentasDiarias.Rows.Add(horas[i], $"Venta #{1000 + i}", montos[i].ToString("C"), i % 2 == 0 ? "Efectivo" : "Tarjeta");
            }
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelResumen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCierre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
