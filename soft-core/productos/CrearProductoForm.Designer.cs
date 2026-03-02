namespace soft_core.productos
{
    partial class CrearProductoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTitulo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtSKU = new TextBox();
            lblSKU = new Label();
            txtCodigoBarras = new TextBox();
            lblCodigoBarras = new Label();
            numPrecio = new NumericUpDown();
            lblPrecio = new Label();
            numStock = new NumericUpDown();
            lblStock = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            panelImagen = new Panel();
            picProducto = new PictureBox();
            lblImagen = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(panelImagen);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(lblDescripcion);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(numStock);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(numPrecio);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(txtCodigoBarras);
            panel1.Controls.Add(lblCodigoBarras);
            panel1.Controls.Add(txtSKU);
            panel1.Controls.Add(lblSKU);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Padding = new Padding(24);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 465);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(28, 67, 95);
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Visible = false;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(142, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CREAR PRODUCTO";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(24, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del producto";
            txtNombre.Size = new Size(280, 29);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(59, 59, 59);
            lblNombre.Location = new Point(24, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "NOMBRE";
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Segoe UI", 9.5F);
            txtSKU.Location = new Point(320, 90);
            txtSKU.Name = "txtSKU";
            txtSKU.PlaceholderText = "SKU-XXXX";
            txtSKU.Size = new Size(180, 29);
            txtSKU.TabIndex = 3;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSKU.ForeColor = Color.FromArgb(59, 59, 59);
            lblSKU.Location = new Point(320, 67);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(36, 20);
            lblSKU.TabIndex = 4;
            lblSKU.Text = "SKU";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Font = new Font("Segoe UI", 9.5F);
            txtCodigoBarras.Location = new Point(24, 155);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.PlaceholderText = "Código de barras";
            txtCodigoBarras.Size = new Size(280, 29);
            txtCodigoBarras.TabIndex = 5;
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCodigoBarras.ForeColor = Color.FromArgb(59, 59, 59);
            lblCodigoBarras.Location = new Point(24, 132);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(122, 20);
            lblCodigoBarras.TabIndex = 6;
            lblCodigoBarras.Text = "CÓDIGO BARRAS";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Font = new Font("Segoe UI", 9.5F);
            numPrecio.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numPrecio.Location = new Point(320, 155);
            numPrecio.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(180, 29);
            numPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(59, 59, 59);
            lblPrecio.Location = new Point(320, 132);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(61, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "PRECIO";
            // 
            // numStock
            // 
            numStock.Font = new Font("Segoe UI", 9.5F);
            numStock.Location = new Point(24, 220);
            numStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 29);
            numStock.TabIndex = 9;
            numStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStock.ForeColor = Color.FromArgb(59, 59, 59);
            lblStock.Location = new Point(24, 197);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 20);
            lblStock.TabIndex = 10;
            lblStock.Text = "STOCK";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 9.5F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "General", "Electrónica", "Oficina", "Hogar", "Otros" });
            cmbCategoria.Location = new Point(160, 220);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(180, 29);
            cmbCategoria.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(59, 59, 59);
            lblCategoria.Location = new Point(160, 197);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(85, 20);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "CATEGORÍA";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.5F);
            txtDescripcion.Location = new Point(24, 285);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción del producto...";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(476, 80);
            txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(59, 59, 59);
            lblDescripcion.Location = new Point(24, 262);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(102, 20);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // panelImagen
            // 
            panelImagen.BackColor = Color.FromArgb(250, 250, 251);
            panelImagen.BorderStyle = BorderStyle.FixedSingle;
            panelImagen.Controls.Add(lblImagen);
            panelImagen.Controls.Add(picProducto);
            panelImagen.Location = new Point(24, 380);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(140, 120);
            panelImagen.TabIndex = 15;
            // 
            // picProducto
            // 
            picProducto.BackColor = Color.White;
            picProducto.Dock = DockStyle.Fill;
            picProducto.Location = new Point(0, 0);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(138, 118);
            picProducto.TabIndex = 0;
            picProducto.TabStop = false;
            // 
            // lblImagen
            // 
            lblImagen.Anchor = AnchorStyles.None;
            lblImagen.ForeColor = Color.FromArgb(150, 150, 150);
            lblImagen.Location = new Point(0, 0);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(138, 118);
            lblImagen.TabIndex = 1;
            lblImagen.Text = "Imagen del producto";
            lblImagen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(28, 67, 95);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(340, 465);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 38);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(245, 246, 247);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(51, 51, 51);
            btnCancelar.Location = new Point(174, 465);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 38);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // CrearProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(600, 520);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearProductoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtSKU;
        private Label lblSKU;
        private TextBox txtCodigoBarras;
        private Label lblCodigoBarras;
        private NumericUpDown numPrecio;
        private Label lblPrecio;
        private NumericUpDown numStock;
        private Label lblStock;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Panel panelImagen;
        private PictureBox picProducto;
        private Label lblImagen;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
