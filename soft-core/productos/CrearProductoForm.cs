using System;
using System.Windows.Forms;
using soft_core.UI;

namespace soft_core.productos
{
    public partial class CrearProductoForm : Form
    {
        public CrearProductoForm()
        {
            InitializeComponent();
            Theme.ApplyForm(this);
            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;
        }
    }
}
