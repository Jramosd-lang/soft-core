using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace soft_core.productos
{
    public partial class gestionarPedidos : Form
    {
        public gestionarPedidos()
        {
            InitializeComponent();
            CargarEjemplo();



            tablaPedido.Rows.Clear();



            tablaPedido.Rows.Add("Teclado","-", 2,"+", 50000, 100000);
            tablaPedido.Rows.Add("Mouse","-", 1,"+", 30000, 30000);
            tablaPedido.Rows.Add("Monitor", "-", 1, "+", 450000, 450000);
            tablaPedido.Rows.Add("Audifonos", "-", 3, "+", 25000, 75000);
            tablaPedido.Rows.Add("Memoria USB", "-", 4, "+", 20000, 80000);
            tablaPedido.Rows.Add("Disco SSD", "-", 1, "+", 280000, 280000);
            tablaPedido.Rows.Add("Webcam", "-", 2, "+", 90000, 180000);
            tablaPedido.Rows.Add("Mousepad", "-", 5, "+", 10000, 50000);
            tablaPedido.Rows.Add("Laptop Stand", "-", 1, "+", 70000, 70000);
            tablaPedido.Rows.Add("Hub USB", "-", 2, "+", 40000, 80000);




        }

        // Ejemplo simple para llenar la tabla con datos de prueba

        private void CargarEjemplo()
        {
            tablaProductos.Rows.Clear();

            for (int i = 1; i <= 20; i++)
            {
                tablaProductos.Rows.Add(
                    "COD" + i,
                    "Producto " + i,
                    i * 5,
                    1000 + (i * 200),
                    "Ver"
                );
            }
        }


        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tablaPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle increment/decrement clicks in the order table
            if (e.RowIndex < 0) return;
            var col = tablaPedido.Columns[e.ColumnIndex].Name;
            if (col == "Menos")
            {
                // decrease quantity (column dataGridViewTextBoxColumn8)
                var qtyCell = tablaPedido.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"];
                if (int.TryParse(qtyCell.Value?.ToString() ?? "0", out int qty))
                {
                    qty = Math.Max(0, qty - 1);
                    qtyCell.Value = qty;
                    UpdateRowTotal(e.RowIndex);
                    if (qty == 0)
                        tablaPedido.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (col == "Mas")
            {
                var qtyCell = tablaPedido.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn8"];
                if (int.TryParse(qtyCell.Value?.ToString() ?? "0", out int qty))
                {
                    qty += 1;
                    qtyCell.Value = qty;
                    UpdateRowTotal(e.RowIndex);
                }
            }
        }

        private void UpdateRowTotal(int rowIndex)
        {
            var row = tablaPedido.Rows[rowIndex];
            var qtyCell = row.Cells["dataGridViewTextBoxColumn8"];
            var priceCell = row.Cells["dataGridViewTextBoxColumn9"];
            var totalCell = row.Cells["dataGridViewTextBoxColumn10"];
            if (int.TryParse(qtyCell.Value?.ToString() ?? "0", out int qty) &&
                decimal.TryParse(priceCell.Value?.ToString() ?? "0", out decimal price))
            {
                totalCell.Value = (qty * price);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Simple filter by Codigo or Nombre
            var text = textBox1.Text?.ToLower().Trim();
            if (string.IsNullOrEmpty(text))
            {
                foreach (DataGridViewRow r in tablaProductos.Rows) r.Visible = true;
                return;
            }
            foreach (DataGridViewRow r in tablaProductos.Rows)
            {
                var codigo = (r.Cells["Codigo"].Value ?? "").ToString().ToLower();
                var nombre = (r.Cells["Nombre"].Value ?? "").ToString().ToLower();
                r.Visible = codigo.Contains(text) || nombre.Contains(text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create / finalize pedido: sum totals and clear
            decimal sum = 0;
            foreach (DataGridViewRow r in tablaPedido.Rows)
            {
                if (r.IsNewRow) continue;
                if (decimal.TryParse(r.Cells["dataGridViewTextBoxColumn10"].Value?.ToString() ?? "0", out decimal t))
                    sum += t;
            }
            MessageBox.Show($"Pedido creado. Total: {sum:C}", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tablaPedido.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open CrearProducto form to add new product (simple modal)
            using var f = new CrearProductoForm();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
            // For now not adding to list; form can be extended to return created product
        }

        private void gestionarPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
