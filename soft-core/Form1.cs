using soft_core.productos;
using soft_core.caja;
using soft_core.usuarios;
using soft_core.reportes;
using soft_core.dashboard;

namespace soft_core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UI.Theme.ApplyForm(this);
            OpenFormInPanel(new DashboardForm(), panel1);
            WindowState = FormWindowState.Maximized;

            button1.Click += (s, e) => OpenFormInPanel(new DashboardForm(), panel1);
            button2.Click += (s, e) => OpenFormInPanel(new productos.InventarioForm(), panel1);
            button3.Click += (s, e) => OpenFormInPanel(new productos.crearPedido(), panel1);
            button4.Click += (s, e) => OpenFormInPanel(new productos.gestionarPedidos(), panel1);
            button5.Click += (s, e) => OpenFormInPanel(new CajaForm(), panel1);
            button8.Click += (s, e) => OpenFormInPanel(new InformeVentasForm(), panel1);
            button9.Click += (s, e) => OpenFormInPanel(new GestionUsuariosForm(), panel1);
            button10.Click += (s, e) =>
            {
                using var f = new productos.CrearProductoForm();
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            };
        }

        private void OpenFormInPanel(Form f, Panel container)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }
    }
}
