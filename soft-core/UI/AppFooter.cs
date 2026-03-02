using System.ComponentModel;
using System.Windows.Forms;

namespace soft_core.UI
{
    public partial class AppFooter : UserControl
    {
        public AppFooter()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Sucursal { get; set; } = "Central";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Rol { get; set; } = "Administrador";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Entorno { get; set; } = "Producción";

        public void ActualizarTexto()
        {
            lblInfo.Text = $"Sucursal: {Sucursal} | Rol: {Rol} | Entorno: {Entorno}";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ActualizarTexto();
        }
    }
}
