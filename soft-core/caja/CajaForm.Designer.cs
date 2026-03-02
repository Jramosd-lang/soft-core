namespace soft_core.caja
{
    partial class CajaForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelHeader = new Panel();
            btnCerrarCajaAccion = new Button();
            btnVerInforme = new Button();
            lblTitulo = new Label();
            splitMain = new SplitContainer();
            panelInforme = new Panel();
            dgvVentasDiarias = new DataGridView();
            colHora = new DataGridViewTextBoxColumn();
            colOperacion = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            panelTabsHeader = new Panel();
            datePicker = new DateTimePicker();
            lblFecha = new Label();
            panelResumen = new Panel();
            txtTransacciones = new Label();
            lblTransacciones = new Label();
            txtVentasTotales = new Label();
            lblVentasTotales = new Label();
            panelCierre = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnImprimirArqueo = new Button();
            btnCerrarCaja = new Button();
            groupCierre = new GroupBox();
            label1 = new Label();
            lblTotalCierre = new Label();
            txtMontoTarjeta = new TextBox();
            lblMontoTarjeta = new Label();
            txtMontoEfectivo = new TextBox();
            lblMontoEfectivo = new Label();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panelInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasDiarias).BeginInit();
            panelTabsHeader.SuspendLayout();
            panelResumen.SuspendLayout();
            panelCierre.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupCierre.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(splitMain, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 840);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(btnCerrarCajaAccion);
            panelHeader.Controls.Add(btnVerInforme);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1256, 59);
            panelHeader.TabIndex = 0;
            // 
            // btnCerrarCajaAccion
            // 
            btnCerrarCajaAccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarCajaAccion.BackColor = Color.FromArgb(70, 120, 160);
            btnCerrarCajaAccion.FlatAppearance.BorderSize = 0;
            btnCerrarCajaAccion.FlatStyle = FlatStyle.Flat;
            btnCerrarCajaAccion.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCerrarCajaAccion.ForeColor = Color.White;
            btnCerrarCajaAccion.Location = new Point(1132, 12);
            btnCerrarCajaAccion.Name = "btnCerrarCajaAccion";
            btnCerrarCajaAccion.Size = new Size(100, 38);
            btnCerrarCajaAccion.TabIndex = 2;
            btnCerrarCajaAccion.Text = "Cerrar caja";
            btnCerrarCajaAccion.UseVisualStyleBackColor = false;
            // 
            // btnVerInforme
            // 
            btnVerInforme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerInforme.BackColor = Color.FromArgb(70, 120, 160);
            btnVerInforme.FlatAppearance.BorderSize = 0;
            btnVerInforme.FlatStyle = FlatStyle.Flat;
            btnVerInforme.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnVerInforme.ForeColor = Color.White;
            btnVerInforme.Location = new Point(1002, 12);
            btnVerInforme.Name = "btnVerInforme";
            btnVerInforme.Size = new Size(120, 38);
            btnVerInforme.TabIndex = 1;
            btnVerInforme.Text = "Ver informe";
            btnVerInforme.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(71, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CAJA";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(3, 68);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.BackColor = Color.FromArgb(250, 250, 251);
            splitMain.Panel1.Controls.Add(panelInforme);
            splitMain.Panel1.Controls.Add(panelTabsHeader);
            splitMain.Panel1.Controls.Add(panelResumen);
            splitMain.Panel1.Padding = new Padding(20);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.BackColor = Color.FromArgb(250, 250, 251);
            splitMain.Panel2.Controls.Add(panelCierre);
            splitMain.Panel2.Padding = new Padding(20);
            splitMain.Size = new Size(1256, 769);
            splitMain.SplitterDistance = 732;
            splitMain.TabIndex = 1;
            // 
            // panelInforme
            // 
            panelInforme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInforme.BackColor = Color.White;
            panelInforme.BorderStyle = BorderStyle.FixedSingle;
            panelInforme.Controls.Add(dgvVentasDiarias);
            panelInforme.Location = new Point(20, 205);
            panelInforme.Name = "panelInforme";
            panelInforme.Padding = new Padding(12);
            panelInforme.Size = new Size(692, 544);
            panelInforme.TabIndex = 0;
            // 
            // dgvVentasDiarias
            // 
            dgvVentasDiarias.AllowUserToAddRows = false;
            dgvVentasDiarias.AllowUserToDeleteRows = false;
            dgvVentasDiarias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasDiarias.BackgroundColor = Color.White;
            dgvVentasDiarias.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(59, 59, 59);
            dgvVentasDiarias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvVentasDiarias.ColumnHeadersHeight = 32;
            dgvVentasDiarias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVentasDiarias.Columns.AddRange(new DataGridViewColumn[] { colHora, colOperacion, colMonto, colTipo });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvVentasDiarias.DefaultCellStyle = dataGridViewCellStyle6;
            dgvVentasDiarias.Dock = DockStyle.Fill;
            dgvVentasDiarias.EnableHeadersVisualStyles = false;
            dgvVentasDiarias.GridColor = Color.FromArgb(243, 244, 246);
            dgvVentasDiarias.Location = new Point(12, 12);
            dgvVentasDiarias.Name = "dgvVentasDiarias";
            dgvVentasDiarias.ReadOnly = true;
            dgvVentasDiarias.RowHeadersVisible = false;
            dgvVentasDiarias.RowHeadersWidth = 51;
            dgvVentasDiarias.RowTemplate.Height = 28;
            dgvVentasDiarias.Size = new Size(666, 518);
            dgvVentasDiarias.TabIndex = 0;
            // 
            // colHora
            // 
            colHora.HeaderText = "HORA";
            colHora.MinimumWidth = 80;
            colHora.Name = "colHora";
            colHora.ReadOnly = true;
            // 
            // colOperacion
            // 
            colOperacion.HeaderText = "OPERACIÓN";
            colOperacion.MinimumWidth = 150;
            colOperacion.Name = "colOperacion";
            colOperacion.ReadOnly = true;
            // 
            // colMonto
            // 
            colMonto.HeaderText = "MONTO";
            colMonto.MinimumWidth = 90;
            colMonto.Name = "colMonto";
            colMonto.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "TIPO";
            colTipo.MinimumWidth = 80;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // panelTabsHeader
            // 
            panelTabsHeader.Controls.Add(datePicker);
            panelTabsHeader.Controls.Add(lblFecha);
            panelTabsHeader.Dock = DockStyle.Top;
            panelTabsHeader.Location = new Point(20, 131);
            panelTabsHeader.Name = "panelTabsHeader";
            panelTabsHeader.Size = new Size(692, 70);
            panelTabsHeader.TabIndex = 2;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            datePicker.Font = new Font("Segoe UI", 9.5F);
            datePicker.Location = new Point(352, 18);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(324, 29);
            datePicker.TabIndex = 1;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFecha.ForeColor = Color.FromArgb(28, 67, 95);
            lblFecha.Location = new Point(0, 18);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(148, 23);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha del informe";
            // 
            // panelResumen
            // 
            panelResumen.BackColor = Color.White;
            panelResumen.BorderStyle = BorderStyle.FixedSingle;
            panelResumen.Controls.Add(txtTransacciones);
            panelResumen.Controls.Add(lblTransacciones);
            panelResumen.Controls.Add(txtVentasTotales);
            panelResumen.Controls.Add(lblVentasTotales);
            panelResumen.Dock = DockStyle.Top;
            panelResumen.Location = new Point(20, 20);
            panelResumen.Name = "panelResumen";
            panelResumen.Padding = new Padding(20);
            panelResumen.Size = new Size(692, 111);
            panelResumen.TabIndex = 1;
            panelResumen.Paint += panelResumen_Paint;
            // 
            // txtTransacciones
            // 
            txtTransacciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTransacciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTransacciones.ForeColor = Color.FromArgb(28, 67, 95);
            txtTransacciones.Location = new Point(610, 66);
            txtTransacciones.Name = "txtTransacciones";
            txtTransacciones.Size = new Size(57, 28);
            txtTransacciones.TabIndex = 3;
            txtTransacciones.Text = "24";
            txtTransacciones.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTransacciones
            // 
            lblTransacciones.AutoSize = true;
            lblTransacciones.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTransacciones.ForeColor = Color.FromArgb(59, 59, 59);
            lblTransacciones.Location = new Point(23, 70);
            lblTransacciones.Name = "lblTransacciones";
            lblTransacciones.Size = new Size(205, 23);
            lblTransacciones.TabIndex = 2;
            lblTransacciones.Text = "Número de transacciones";
            // 
            // txtVentasTotales
            // 
            txtVentasTotales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtVentasTotales.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtVentasTotales.ForeColor = Color.FromArgb(28, 67, 95);
            txtVentasTotales.Location = new Point(525, 20);
            txtVentasTotales.Name = "txtVentasTotales";
            txtVentasTotales.Size = new Size(142, 32);
            txtVentasTotales.TabIndex = 1;
            txtVentasTotales.Text = "$1,250.00";
            txtVentasTotales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasTotales
            // 
            lblVentasTotales.AutoSize = true;
            lblVentasTotales.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblVentasTotales.ForeColor = Color.FromArgb(59, 59, 59);
            lblVentasTotales.Location = new Point(23, 24);
            lblVentasTotales.Name = "lblVentasTotales";
            lblVentasTotales.Size = new Size(151, 23);
            lblVentasTotales.TabIndex = 0;
            lblVentasTotales.Text = "Ventas totales hoy";
            // 
            // panelCierre
            // 
            panelCierre.Controls.Add(panel2);
            panelCierre.Controls.Add(panel3);
            panelCierre.Controls.Add(panel1);
            panelCierre.Dock = DockStyle.Fill;
            panelCierre.Location = new Point(20, 20);
            panelCierre.Name = "panelCierre";
            panelCierre.Size = new Size(480, 729);
            panelCierre.TabIndex = 0;
            panelCierre.Paint += panelCierre_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 354);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(59, 59, 59);
            label4.Location = new Point(21, 141);
            label4.Name = "label4";
            label4.Size = new Size(179, 20);
            label4.TabIndex = 7;
            label4.Text = "AGREGAR OBSERVACION";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(21, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(438, 64);
            listBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(28, 67, 95);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 273);
            button1.Name = "button1";
            button1.Size = new Size(438, 42);
            button1.TabIndex = 5;
            button1.Text = "ANOTAR OBSERVACION";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox2.Location = new Point(296, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(59, 59, 59);
            label2.Location = new Point(21, 243);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Monto ($):";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(21, 176);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(438, 58);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(59, 59, 59);
            label3.Location = new Point(21, 23);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 1;
            label3.Text = "OBSERVACIONES DE CAJA";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnImprimirArqueo);
            panel1.Controls.Add(btnCerrarCaja);
            panel1.Controls.Add(groupCierre);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(480, 302);
            panel1.TabIndex = 3;
            // 
            // btnImprimirArqueo
            // 
            btnImprimirArqueo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimirArqueo.BackColor = Color.FromArgb(245, 246, 247);
            btnImprimirArqueo.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnImprimirArqueo.FlatStyle = FlatStyle.Flat;
            btnImprimirArqueo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnImprimirArqueo.ForeColor = Color.FromArgb(28, 67, 95);
            btnImprimirArqueo.Location = new Point(280, 245);
            btnImprimirArqueo.Name = "btnImprimirArqueo";
            btnImprimirArqueo.Size = new Size(180, 42);
            btnImprimirArqueo.TabIndex = 5;
            btnImprimirArqueo.Text = "Imprimir";
            btnImprimirArqueo.UseVisualStyleBackColor = false;
            // 
            // btnCerrarCaja
            // 
            btnCerrarCaja.BackColor = Color.FromArgb(28, 67, 95);
            btnCerrarCaja.FlatAppearance.BorderSize = 0;
            btnCerrarCaja.FlatStyle = FlatStyle.Flat;
            btnCerrarCaja.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnCerrarCaja.ForeColor = Color.White;
            btnCerrarCaja.Location = new Point(20, 245);
            btnCerrarCaja.Name = "btnCerrarCaja";
            btnCerrarCaja.Size = new Size(200, 42);
            btnCerrarCaja.TabIndex = 4;
            btnCerrarCaja.Text = "Cerrar caja";
            btnCerrarCaja.UseVisualStyleBackColor = false;
            // 
            // groupCierre
            // 
            groupCierre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupCierre.Controls.Add(label1);
            groupCierre.Controls.Add(lblTotalCierre);
            groupCierre.Controls.Add(txtMontoTarjeta);
            groupCierre.Controls.Add(lblMontoTarjeta);
            groupCierre.Controls.Add(txtMontoEfectivo);
            groupCierre.Controls.Add(lblMontoEfectivo);
            groupCierre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupCierre.ForeColor = Color.FromArgb(28, 67, 95);
            groupCierre.Location = new Point(20, 9);
            groupCierre.Name = "groupCierre";
            groupCierre.Size = new Size(440, 220);
            groupCierre.TabIndex = 3;
            groupCierre.TabStop = false;
            groupCierre.Text = "Arqueo de caja";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(367, 159);
            label1.Name = "label1";
            label1.Size = new Size(41, 23);
            label1.TabIndex = 6;
            label1.Text = "$0.0";
            // 
            // lblTotalCierre
            // 
            lblTotalCierre.AutoSize = true;
            lblTotalCierre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalCierre.ForeColor = Color.FromArgb(28, 67, 95);
            lblTotalCierre.Location = new Point(20, 155);
            lblTotalCierre.Name = "lblTotalCierre";
            lblTotalCierre.Size = new Size(132, 25);
            lblTotalCierre.TabIndex = 4;
            lblTotalCierre.Text = "TOTAL CIERRE";
            // 
            // txtMontoTarjeta
            // 
            txtMontoTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMontoTarjeta.Font = new Font("Segoe UI", 10F);
            txtMontoTarjeta.Location = new Point(200, 92);
            txtMontoTarjeta.Name = "txtMontoTarjeta";
            txtMontoTarjeta.PlaceholderText = "0.00";
            txtMontoTarjeta.Size = new Size(220, 30);
            txtMontoTarjeta.TabIndex = 3;
            // 
            // lblMontoTarjeta
            // 
            lblMontoTarjeta.AutoSize = true;
            lblMontoTarjeta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMontoTarjeta.ForeColor = Color.FromArgb(59, 59, 59);
            lblMontoTarjeta.Location = new Point(20, 95);
            lblMontoTarjeta.Name = "lblMontoTarjeta";
            lblMontoTarjeta.Size = new Size(152, 20);
            lblMontoTarjeta.TabIndex = 2;
            lblMontoTarjeta.Text = "Monto tarjeta/digital";
            // 
            // txtMontoEfectivo
            // 
            txtMontoEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMontoEfectivo.Font = new Font("Segoe UI", 10F);
            txtMontoEfectivo.Location = new Point(200, 42);
            txtMontoEfectivo.Name = "txtMontoEfectivo";
            txtMontoEfectivo.PlaceholderText = "0.00";
            txtMontoEfectivo.Size = new Size(220, 30);
            txtMontoEfectivo.TabIndex = 1;
            // 
            // lblMontoEfectivo
            // 
            lblMontoEfectivo.AutoSize = true;
            lblMontoEfectivo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMontoEfectivo.ForeColor = Color.FromArgb(59, 59, 59);
            lblMontoEfectivo.Location = new Point(20, 45);
            lblMontoEfectivo.Name = "lblMontoEfectivo";
            lblMontoEfectivo.Size = new Size(156, 20);
            lblMontoEfectivo.TabIndex = 0;
            lblMontoEfectivo.Text = "Monto en efectivo ($)";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 302);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 44);
            panel3.TabIndex = 5;
            // 
            // CajaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1262, 840);
            Controls.Add(tableLayoutPanel1);
            Name = "CajaForm";
            Text = "Caja";
            tableLayoutPanel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panelInforme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentasDiarias).EndInit();
            panelTabsHeader.ResumeLayout(false);
            panelTabsHeader.PerformLayout();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            panelCierre.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            groupCierre.ResumeLayout(false);
            groupCierre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelHeader;
        private Label lblTitulo;
        private SplitContainer splitMain;
        private Button btnVerInforme;
        private Button btnCerrarCajaAccion;
        private Panel panelInforme;
        private DataGridView dgvVentasDiarias;
        private DataGridViewTextBoxColumn colHora;
        private DataGridViewTextBoxColumn colOperacion;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colTipo;
        private Panel panelResumen;
        private Label lblVentasTotales;
        private Label txtVentasTotales;
        private Label lblTransacciones;
        private Label txtTransacciones;
        private Panel panelTabsHeader;
        private Label lblFecha;
        private DateTimePicker datePicker;
        private Panel panelCierre;
        private Panel panel1;
        private Button btnImprimirArqueo;
        private Button btnCerrarCaja;
        private GroupBox groupCierre;
        private Label lblTotalCierre;
        private TextBox txtMontoTarjeta;
        private Label lblMontoTarjeta;
        private TextBox txtMontoEfectivo;
        private Label lblMontoEfectivo;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label4;
        private ListBox listBox1;
        private Panel panel3;
    }
}
