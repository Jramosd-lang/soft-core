using soft_core.productos;

namespace soft_core
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Apply theme
            UI.Theme.ApplyForm(this);

            // Open default view
            OpenFormInPanel(new productos.crearPedido(), panel1);
            this.WindowState = FormWindowState.Maximized;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
