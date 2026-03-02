namespace soft_core.productos
{
    partial class InventarioForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnNuevo = new Button();
            btnActualizar = new Button();
            panelContenido = new Panel();
            dgvInventario = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colSKU = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            lblCantidad = new Label();
            panelStock = new Panel();
            groupStock = new GroupBox();
            lblProductoStock = new Label();
            cmbProducto = new ComboBox();
            lblCantidadStock = new Label();
            numCantidadStock = new NumericUpDown();
            btnAumentarStock = new Button();
            lblStockActual = new Label();
            txtStockActual = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelStock.SuspendLayout();
            groupStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadStock).BeginInit();
            panelHeader.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(panelContenido, 0, 1);
            tableLayoutPanel1.Controls.Add(panelStock, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1100, 550);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblCantidad);
            panelHeader.Controls.Add(btnActualizar);
            panelHeader.Controls.Add(btnNuevo);
            panelHeader.Controls.Add(btnBuscar);
            panelHeader.Controls.Add(txtBuscar);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            tableLayoutPanel1.SetColumnSpan(panelHeader, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 12, 20, 12);
            panelHeader.Size = new Size(1094, 89);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(23, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INVENTARIO";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.BackColor = Color.White;
            txtBuscar.Location = new Point(23, 52);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre, SKU o código...";
            txtBuscar.Size = new Size(320, 29);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(70, 120, 160);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(349, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(70, 120, 160);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(875, 18);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(180, 36);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "+ NUEVO PRODUCTO";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = Color.FromArgb(70, 120, 160);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(965, 55);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 28);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // panelStock
            // 
            panelStock.BackColor = Color.White;
            panelStock.Controls.Add(groupStock);
            panelStock.Dock = DockStyle.Fill;
            panelStock.Location = new Point(813, 98);
            panelStock.Name = "panelStock";
            panelStock.Padding = new Padding(16);
            panelStock.Size = new Size(284, 449);
            panelStock.TabIndex = 2;
            // 
            // groupStock
            // 
            groupStock.Controls.Add(txtStockActual);
            groupStock.Controls.Add(lblStockActual);
            groupStock.Controls.Add(btnAumentarStock);
            groupStock.Controls.Add(numCantidadStock);
            groupStock.Controls.Add(lblCantidadStock);
            groupStock.Controls.Add(cmbProducto);
            groupStock.Controls.Add(lblProductoStock);
            groupStock.Dock = DockStyle.Fill;
            groupStock.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            groupStock.ForeColor = Color.FromArgb(28, 67, 95);
            groupStock.Location = new Point(16, 16);
            groupStock.Name = "groupStock";
            groupStock.Size = new Size(252, 417);
            groupStock.TabIndex = 0;
            groupStock.TabStop = false;
            groupStock.Text = "AUMENTAR STOCK";
            // 
            // lblProductoStock
            // 
            lblProductoStock.AutoSize = true;
            lblProductoStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProductoStock.ForeColor = Color.FromArgb(59, 59, 59);
            lblProductoStock.Location = new Point(16, 45);
            lblProductoStock.Name = "lblProductoStock";
            lblProductoStock.Size = new Size(78, 20);
            lblProductoStock.TabIndex = 0;
            lblProductoStock.Text = "Producto";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.Font = new Font("Segoe UI", 9.5F);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(16, 68);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(220, 29);
            cmbProducto.TabIndex = 1;
            // 
            // lblCantidadStock
            // 
            lblCantidadStock.AutoSize = true;
            lblCantidadStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCantidadStock.ForeColor = Color.FromArgb(59, 59, 59);
            lblCantidadStock.Location = new Point(16, 115);
            lblCantidadStock.Name = "lblCantidadStock";
            lblCantidadStock.Size = new Size(80, 20);
            lblCantidadStock.TabIndex = 2;
            lblCantidadStock.Text = "Cantidad";
            // 
            // numCantidadStock
            // 
            numCantidadStock.Font = new Font("Segoe UI", 10F);
            numCantidadStock.Location = new Point(16, 138);
            numCantidadStock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidadStock.Name = "numCantidadStock";
            numCantidadStock.Size = new Size(120, 30);
            numCantidadStock.TabIndex = 3;
            numCantidadStock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAumentarStock
            // 
            btnAumentarStock.BackColor = Color.FromArgb(28, 67, 95);
            btnAumentarStock.FlatAppearance.BorderSize = 0;
            btnAumentarStock.FlatStyle = FlatStyle.Flat;
            btnAumentarStock.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAumentarStock.ForeColor = Color.White;
            btnAumentarStock.Location = new Point(16, 185);
            btnAumentarStock.Name = "btnAumentarStock";
            btnAumentarStock.Size = new Size(220, 40);
            btnAumentarStock.TabIndex = 4;
            btnAumentarStock.Text = "AUMENTAR STOCK";
            btnAumentarStock.UseVisualStyleBackColor = false;
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStockActual.ForeColor = Color.FromArgb(59, 59, 59);
            lblStockActual.Location = new Point(16, 245);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(98, 20);
            lblStockActual.TabIndex = 5;
            lblStockActual.Text = "Stock actual";
            // 
            // txtStockActual
            // 
            txtStockActual.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtStockActual.ForeColor = Color.FromArgb(28, 67, 95);
            txtStockActual.Location = new Point(16, 268);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(120, 28);
            txtStockActual.TabIndex = 6;
            txtStockActual.Text = "0";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = Color.FromArgb(200, 220, 240);
            lblCantidad.Location = new Point(455, 57);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(230, 20);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Mostrando 0 productos registrados";
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(250, 250, 251);
            panelContenido.Controls.Add(dgvInventario);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(3, 98);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(20);
            panelContenido.Size = new Size(1094, 449);
            panelContenido.TabIndex = 1;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(59, 59, 59);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(59, 59, 59);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventario.ColumnHeadersHeight = 36;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { colId, colCodigo, colNombre, colSKU, colStock, colPrecio, colCategoria, colAcciones });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.Dock = DockStyle.Fill;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.GridColor = Color.FromArgb(243, 244, 246);
            dgvInventario.Location = new Point(20, 20);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvInventario.RowTemplate.Height = 36;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(1054, 409);
            dgvInventario.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 50;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "CÓDIGO";
            colCodigo.MinimumWidth = 80;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 100;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "NOMBRE";
            colNombre.MinimumWidth = 150;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 250;
            // 
            // colSKU
            // 
            colSKU.HeaderText = "SKU";
            colSKU.MinimumWidth = 90;
            colSKU.Name = "colSKU";
            colSKU.ReadOnly = true;
            colSKU.Width = 120;
            // 
            // colStock
            // 
            colStock.HeaderText = "STOCK";
            colStock.MinimumWidth = 70;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 80;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "PRECIO";
            colPrecio.MinimumWidth = 90;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 100;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "CATEGORÍA";
            colCategoria.MinimumWidth = 100;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 120;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "ACCIONES";
            colAcciones.MinimumWidth = 80;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "Ver";
            colAcciones.UseColumnTextForButtonValue = true;
            colAcciones.Width = 90;
            // 
            // InventarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1100, 550);
            Controls.Add(tableLayoutPanel1);
            Name = "InventarioForm";
            Text = "Inventario";
            tableLayoutPanel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStock.ResumeLayout(false);
            groupStock.ResumeLayout(false);
            groupStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadStock).EndInit();
            panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelHeader;
        private Label lblTitulo;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnActualizar;
        private Label lblCantidad;
        private Panel panelContenido;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colSKU;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewButtonColumn colAcciones;
        private Panel panelStock;
        private GroupBox groupStock;
        private Label lblProductoStock;
        private ComboBox cmbProducto;
        private Label lblCantidadStock;
        private NumericUpDown numCantidadStock;
        private Button btnAumentarStock;
        private Label lblStockActual;
        private Label txtStockActual;
    }
}
