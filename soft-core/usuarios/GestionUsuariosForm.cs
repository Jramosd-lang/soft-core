using System;
using System.Windows.Forms;
using soft_core.UI;

namespace soft_core.usuarios
{
    public partial class GestionUsuariosForm : Form
    {
        public GestionUsuariosForm()
        {
            InitializeComponent();
            Theme.ApplyForm(this);
            Theme.ApplyDataGridView(dgvUsuarios);
            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;
            CargarEjemplo();
        }

        private void CargarEjemplo()
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Rows.Add("001", "Juan Pérez González", "jperez.admin", "ADMINISTRADOR", "Activo", "⋯");
            dgvUsuarios.Rows.Add("002", "María Elena García", "mgarcia.sup", "SUPERVISOR", "Activo", "⋯");
            dgvUsuarios.Rows.Add("003", "Carlos Roberto Ruiz", "cruiz.op", "OPERADOR", "Inactivo", "⋯");
            for (int i = 4; i <= 24; i++)
            {
                var rol = i % 3 == 0 ? "OPERADOR" : i % 3 == 1 ? "ADMINISTRADOR" : "SUPERVISOR";
                var estado = i % 5 == 0 ? "Inactivo" : "Activo";
                dgvUsuarios.Rows.Add(i.ToString("D3"), $"Usuario {i}", $"user{i}", rol, estado, "⋯");
            }
            lblCantidadUsuarios.Text = $"Mostrando {dgvUsuarios.Rows.Count} usuarios registrados";
        }
    }
}
