using System;
using System.Windows.Forms;
using soft_core.UI;

namespace soft_core.productos
{
    public partial class InventarioForm : Form
    {
        public InventarioForm()
        {
            InitializeComponent();
            Theme.ApplyForm(this);
            Theme.ApplyDataGridView(dgvInventario);
            CargarEjemplo();
        }

        private void CargarEjemplo()
        {
            dgvInventario.Rows.Clear();
            cmbProducto.Items.Clear();
            for (int i = 1; i <= 15; i++)
            {
                dgvInventario.Rows.Add(i.ToString("D3"), $"COD-{i:0000}", $"Producto ejemplo {i}", $"SKU-{1000 + i}", i * 10, $"{1500 + i * 100:C}", "General", "Ver");
                cmbProducto.Items.Add($"Producto ejemplo {i} (COD-{i:0000})");
            }
            if (cmbProducto.Items.Count > 0) cmbProducto.SelectedIndex = 0;
            lblCantidad.Text = $"Mostrando {dgvInventario.Rows.Count} productos registrados";
        }
    }
}
