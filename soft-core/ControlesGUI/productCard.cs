using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace soft_core.ControlesGUI
{
    public partial class productCard : UserControl
    {
        [Browsable(true)]
        [Category("Data")]
        [Description("Nombre del producto mostrado en la tarjeta.")]
        [Localizable(true)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public string Nombre
        {
            get => nombreProducto?.Text ?? string.Empty;
            set
            {
                if (nombreProducto != null) nombreProducto.Text = value;
            }
        }

        // Legacy lowercase property used by some designer-generated code.
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string nombre
        {
            get => Nombre;
            set => Nombre = value;
        }

        [Browsable(true)]
        [Category("Data")]
        [Description("Stock del producto mostrado en la tarjeta.")]
        [Localizable(true)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public string Stock
        {
            get => stockProducto?.Text ?? string.Empty;
            set
            {
                if (stockProducto != null) stockProducto.Text = value;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Imagen del producto mostrada en la tarjeta.")]
        [Localizable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Image Imagen
        {
            get => imagenProducto?.Image;
            set
            {
                if (imagenProducto != null) imagenProducto.Image = value;
            }
        }

        public productCard()
        {
            InitializeComponent();
        }
    }
}
