using System;
using System.Windows.Forms;
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
            if (chartVentas.Series.Count > 0)
            {
                chartVentas.Series[0].Points.Clear();
                chartVentas.Series[0].Points.AddXY("Lun", 1250);
                chartVentas.Series[0].Points.AddXY("Mar", 1420);
                chartVentas.Series[0].Points.AddXY("Mié", 1380);
                chartVentas.Series[0].Points.AddXY("Jue", 1650);
                chartVentas.Series[0].Points.AddXY("Vie", 2100);
                chartVentas.Series[0].Points.AddXY("Sáb", 1850);
                chartVentas.Series[0].Points.AddXY("Dom", 1200);
            }
            if (chartProductos.Series.Count > 0)
            {
                chartProductos.Series[0].Points.Clear();
                chartProductos.Series[0].Points.AddXY("Electrónica", 35);
                chartProductos.Series[0].Points.AddXY("Oficina", 28);
                chartProductos.Series[0].Points.AddXY("Hogar", 22);
                chartProductos.Series[0].Points.AddXY("Otros", 15);
            }
        }
    }
}
