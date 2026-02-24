using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using soft_core.ControlesGUI;

namespace soft_core.productos
{
    public partial class crearPedido : Form
    {
        public class Producto
        {
            public string Nombre { get; set; }
            public int Stock { get; set; }

            public Producto(string nombre, int stock)
            {
                Nombre = nombre;
                Stock = stock;
            }
        }
        public crearPedido()
        {
            InitializeComponent();

            UI.Theme.ApplyForm(this);
            UI.Theme.ApplyAccentLabel(label1);
            UI.Theme.ApplyDataGridView(tablaPedido);

            List<Producto> productos = new List<Producto>()
            {
                new Producto("Laptop Lenovo", 8),
                new Producto("Mouse Gamer", 25),
                new Producto("Teclado Mecánico", 15),
                new Producto("Monitor 24 pulgadas", 10),
                new Producto("Disco SSD 1TB", 12),
                new Producto("Memoria RAM 16GB", 20),
                new Producto("Audífonos Bluetooth", 18),
                new Producto("Webcam HD", 9),
                new Producto("Impresora Multifuncional", 5),
                new Producto("Silla Ergonómica", 6)
            };

            int asis = 1;

            foreach (Producto p in productos)
            {
                productCard productCard_ = new productCard();
                // Use the public properties exposed by the UserControl
                productCard_.Nombre = p.Nombre;
                productCard_.Stock = $"Stock: {p.Stock}";
                // Find the folder 'imagenes_productos' by walking up from the app base directory
                string imagesFolder = null;
                try
                {
                    var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                    while (dir != null)
                    {
                        var candidate = Path.Combine(dir.FullName, "imagenes_productos");
                        if (Directory.Exists(candidate))
                        {
                            imagesFolder = candidate;
                            break;
                        }
                        dir = dir.Parent;
                    }
                }
                catch
                {
                    imagesFolder = null;
                }

                // Build the image path and load into memory to avoid file locking. Handle missing files.
                if (!string.IsNullOrEmpty(imagesFolder))
                {
                    string imgPath = Path.Combine(imagesFolder, $"producto_ejemplo_{asis}.webp");
                    if (File.Exists(imgPath))
                    {
                        try
                        {
                            using var fs = File.OpenRead(imgPath);
                            using var ms = new MemoryStream();
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            using var tmp = Image.FromStream(ms);
                            // Clone into a new Bitmap so the stream can be closed safely
                            productCard_.Imagen = new Bitmap(tmp);
                        }
                        catch
                        {
                            // Failed to decode image (possible unsupported WebP). Use placeholder image.
                            productCard_.Imagen = CreatePlaceholderImage(p.Nombre);
                        }
                    }
                    else
                    {
                        productCard_.Imagen = CreatePlaceholderImage(p.Nombre);
                    }
                }
                else
                {
                    // images folder not found; do not throw - leave image null
                    productCard_.Imagen = null;
                }

                contenedorProductos.Controls.Add(productCard_);
                asis++; // advance to next example image
            }

        }

        private static Image CreatePlaceholderImage(string text)
        {
            int w = 224, h = 176;
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(252, 252, 253));
                using var pen = new Pen(Color.FromArgb(220, 220, 220));
                g.DrawRectangle(pen, 0, 0, w - 1, h - 1);
                using var sf = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                using var brush = new SolidBrush(Color.FromArgb(120, 120, 120));
                g.DrawString(text, new Font("Segoe UI", 10, FontStyle.Regular), brush, new RectangleF(4, 4, w - 8, h - 8), sf);
            }
            return bmp;

            
        }
    }
}
