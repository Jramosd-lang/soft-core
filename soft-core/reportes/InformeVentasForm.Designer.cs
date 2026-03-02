using System.Windows.Forms.DataVisualization.Charting;

namespace soft_core.reportes
{
    partial class InformeVentasForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            rbSemanal = new RadioButton();
            rbMensual = new RadioButton();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            lblHasta = new Label();
            btnGenerar = new Button();
            btnExportar = new Button();
            cmbSucursal = new ComboBox();
            lblSucursal = new Label();
            panelContenido = new Panel();
            splitMain = new SplitContainer();
            dgvVentas = new DataGridView();
            colPeriodo = new DataGridViewTextBoxColumn();
            colRango = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colTransacciones = new DataGridViewTextBoxColumn();
            panelResumen = new Panel();
            chartVentas = new Chart();
            lblTotalVentas = new Label();
            txtTotalVentas = new Label();
            lblTotalTransacciones = new Label();
            txtTotalTransacciones = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContenido.SuspendLayout();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            panelResumen.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(panelContenido, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1100, 580);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblSucursal);
            panelHeader.Controls.Add(cmbSucursal);
            panelHeader.Controls.Add(btnExportar);
            panelHeader.Controls.Add(btnGenerar);
            panelHeader.Controls.Add(lblHasta);
            panelHeader.Controls.Add(dtpHasta);
            panelHeader.Controls.Add(lblDesde);
            panelHeader.Controls.Add(dtpDesde);
            panelHeader.Controls.Add(rbMensual);
            panelHeader.Controls.Add(rbSemanal);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(24);
            panelHeader.Size = new Size(1094, 114);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(27, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INFORME DE VENTAS MENSUALES / SEMANALES";
            // 
            // rbSemanal
            // 
            rbSemanal.AutoSize = true;
            rbSemanal.Checked = true;
            rbSemanal.Font = new Font("Segoe UI", 9.5F);
            rbSemanal.ForeColor = Color.FromArgb(220, 230, 245);
            rbSemanal.Location = new Point(27, 58);
            rbSemanal.Name = "rbSemanal";
            rbSemanal.Size = new Size(98, 27);
            rbSemanal.TabIndex = 1;
            rbSemanal.TabStop = true;
            rbSemanal.Text = "Semanal";
            rbSemanal.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            rbMensual.AutoSize = true;
            rbMensual.Font = new Font("Segoe UI", 9.5F);
            rbMensual.ForeColor = Color.FromArgb(220, 230, 245);
            rbMensual.Location = new Point(135, 58);
            rbMensual.Name = "rbMensual";
            rbMensual.Size = new Size(92, 27);
            rbMensual.TabIndex = 2;
            rbMensual.Text = "Mensual";
            rbMensual.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 9.5F);
            dtpDesde.Location = new Point(340, 54);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 29);
            dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 9.5F);
            dtpHasta.Location = new Point(600, 54);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 29);
            dtpHasta.TabIndex = 4;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDesde.ForeColor = Color.FromArgb(220, 230, 245);
            lblDesde.Location = new Point(270, 58);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(55, 20);
            lblDesde.TabIndex = 5;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblHasta.ForeColor = Color.FromArgb(220, 230, 245);
            lblHasta.Location = new Point(550, 58);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(49, 20);
            lblHasta.TabIndex = 6;
            lblHasta.Text = "Hasta";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(28, 67, 95);
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(820, 52);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(120, 34);
            btnGenerar.TabIndex = 7;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(245, 246, 247);
            btnExportar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnExportar.ForeColor = Color.FromArgb(51, 51, 51);
            btnExportar.Location = new Point(950, 52);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 34);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // cmbSucursal
            // 
            cmbSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursal.Font = new Font("Segoe UI", 9.5F);
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Items.AddRange(new object[] { "Todas las sucursales", "Sucursal Central", "Sucursal Norte", "Sucursal Sur" });
            cmbSucursal.Location = new Point(27, 92);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(220, 29);
            cmbSucursal.TabIndex = 9;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSucursal.ForeColor = Color.FromArgb(59, 59, 59);
            lblSucursal.Location = new Point(27, 72);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(156, 20);
            lblSucursal.TabIndex = 10;
            lblSucursal.Text = "Filtrar por sucursal";
            lblSucursal.Visible = false;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(250, 250, 251);
            panelContenido.Controls.Add(splitMain);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(3, 123);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(24);
            panelContenido.Size = new Size(1094, 454);
            panelContenido.TabIndex = 1;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(59, 59, 59);
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeight = 36;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colPeriodo, colRango, colMonto, colTransacciones });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.GridColor = Color.FromArgb(243, 244, 246);
            dgvVentas.Location = new Point(12, 12);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowTemplate.Height = 36;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(400, 380);
            dgvVentas.TabIndex = 0;
            // 
            // colPeriodo
            // 
            colPeriodo.HeaderText = "PERÍODO";
            colPeriodo.MinimumWidth = 100;
            colPeriodo.Name = "colPeriodo";
            colPeriodo.ReadOnly = true;
            colPeriodo.Width = 120;
            // 
            // colRango
            // 
            colRango.HeaderText = "RANGO DE FECHAS";
            colRango.MinimumWidth = 180;
            colRango.Name = "colRango";
            colRango.ReadOnly = true;
            colRango.Width = 250;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "MONTO TOTAL";
            colMonto.MinimumWidth = 120;
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            colMonto.Width = 150;
            // 
            // colTransacciones
            // 
            colTransacciones.HeaderText = "TRANSACCIONES";
            colTransacciones.MinimumWidth = 100;
            colTransacciones.Name = "colTransacciones";
            colTransacciones.ReadOnly = true;
            colTransacciones.Width = 130;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(27, 27);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1 - tabla + resumen
            // 
            splitMain.Panel1.Controls.Add(dgvVentas);
            splitMain.Panel1.Controls.Add(panelResumen);
            splitMain.Panel1.Padding = new Padding(12);
            // 
            // splitMain.Panel2 - gráfica
            // 
            splitMain.Panel2.Controls.Add(chartVentas);
            splitMain.Panel2.Padding = new Padding(12);
            splitMain.Size = new Size(1040, 400);
            splitMain.SplitterDistance = 480;
            splitMain.TabIndex = 2;
            // 
            // panelResumen
            // 
            panelResumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelResumen.BackColor = Color.White;
            panelResumen.Controls.Add(txtTotalTransacciones);
            panelResumen.Controls.Add(lblTotalTransacciones);
            panelResumen.Controls.Add(txtTotalVentas);
            panelResumen.Controls.Add(lblTotalVentas);
            panelResumen.Location = new Point(12, 270);
            panelResumen.Name = "panelResumen";
            panelResumen.Padding = new Padding(20);
            panelResumen.Size = new Size(456, 120);
            // 
            // chartVentas
            // 
            chartVentas.Dock = DockStyle.Fill;
            chartVentas.Location = new Point(12, 12);
            chartVentas.Name = "chartVentas";
            chartVentas.Palette = ChartColorPalette.BrightPastel;
            chartVentas.Size = new Size(536, 376);
            chartVentas.TabIndex = 0;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalVentas.ForeColor = Color.FromArgb(28, 67, 95);
            lblTotalVentas.Location = new Point(23, 24);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(197, 25);
            lblTotalVentas.TabIndex = 0;
            lblTotalVentas.Text = "Total ventas del período";
            // 
            // txtTotalVentas
            // 
            txtTotalVentas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalVentas.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtTotalVentas.ForeColor = Color.FromArgb(28, 67, 95);
            txtTotalVentas.Location = new Point(200, 18);
            txtTotalVentas.Name = "txtTotalVentas";
            txtTotalVentas.Size = new Size(151, 37);
            txtTotalVentas.TabIndex = 1;
            txtTotalVentas.Text = "$55,601.50";
            txtTotalVentas.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTransacciones
            // 
            lblTotalTransacciones.AutoSize = true;
            lblTotalTransacciones.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalTransacciones.ForeColor = Color.FromArgb(59, 59, 59);
            lblTotalTransacciones.Location = new Point(23, 80);
            lblTotalTransacciones.Name = "lblTotalTransacciones";
            lblTotalTransacciones.Size = new Size(250, 25);
            lblTotalTransacciones.TabIndex = 2;
            lblTotalTransacciones.Text = "Total de transacciones";
            // 
            // txtTotalTransacciones
            // 
            txtTotalTransacciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalTransacciones.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtTotalTransacciones.ForeColor = Color.FromArgb(28, 67, 95);
            txtTotalTransacciones.Location = new Point(280, 74);
            txtTotalTransacciones.Name = "txtTotalTransacciones";
            txtTotalTransacciones.Size = new Size(71, 32);
            txtTotalTransacciones.TabIndex = 3;
            txtTotalTransacciones.Text = "360";
            txtTotalTransacciones.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InformeVentasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1100, 580);
            Controls.Add(tableLayoutPanel1);
            Name = "InformeVentasForm";
            Text = "Informe de Ventas";
            tableLayoutPanel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelHeader;
        private Label lblTitulo;
        private RadioButton rbSemanal;
        private RadioButton rbMensual;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label lblDesde;
        private Label lblHasta;
        private Button btnGenerar;
        private Button btnExportar;
        private ComboBox cmbSucursal;
        private Label lblSucursal;
        private Panel panelContenido;
        private SplitContainer splitMain;
        private Chart chartVentas;
        private DataGridView dgvVentas;
        private DataGridViewTextBoxColumn colPeriodo;
        private DataGridViewTextBoxColumn colRango;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colTransacciones;
        private Panel panelResumen;
        private Label lblTotalVentas;
        private Label txtTotalVentas;
        private Label lblTotalTransacciones;
        private Label txtTotalTransacciones;
    }
}
