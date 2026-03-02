namespace soft_core.productos
{
    partial class crearPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            panel8 = new Panel();
            tablaPedido = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Menos = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Mas = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            btnCotizar = new Button();
            btnFinalizarPedido = new Button();
            btnCancelar = new Button();
            lblIdPedido = new Label();
            lblSubtotal = new Label();
            lblIva = new Label();
            lblTotal = new Label();
            txtSubtotal = new Label();
            txtIva = new Label();
            txtTotal = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btnNuevo = new Button();
            btnEditar = new Button();
            textBox1 = new TextBox();
            contenedorProductos = new ControlesGUI.SmoothFlowLayoutPanel();
            label1 = new Label();
            panelHeader = new Panel();
            lblHeaderTitulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPedido).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.875F));
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(1078, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblHeaderTitulo);
            tableLayoutPanel1.SetColumnSpan(panelHeader, 2);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1072, 54);
            panelHeader.TabIndex = 2;
            // 
            // lblHeaderTitulo
            // 
            lblHeaderTitulo.AutoSize = true;
            lblHeaderTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblHeaderTitulo.ForeColor = Color.White;
            lblHeaderTitulo.Location = new Point(24, 12);
            lblHeaderTitulo.Name = "lblHeaderTitulo";
            lblHeaderTitulo.Size = new Size(237, 32);
            lblHeaderTitulo.TabIndex = 0;
            lblHeaderTitulo.Text = "REGISTRO DE PEDIDOS";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(715, 63);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(12, 0, 12, 0);
            panel5.Size = new Size(360, 444);
            panel5.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(tablaPedido);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(12, 125);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(20, 0, 20, 0);
            panel8.Size = new Size(336, 194);
            panel8.TabIndex = 7;
            // 
            // tablaPedido
            // 
            tablaPedido.AllowUserToAddRows = false;
            tablaPedido.AllowUserToResizeColumns = false;
            tablaPedido.AllowUserToResizeRows = false;
            tablaPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaPedido.BackgroundColor = Color.White;
            tablaPedido.BorderStyle = BorderStyle.None;
            tablaPedido.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            tablaPedido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(59, 59, 59);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tablaPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tablaPedido.ColumnHeadersHeight = 29;
            tablaPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, Menos, dataGridViewTextBoxColumn8, Mas, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            tablaPedido.Dock = DockStyle.Fill;
            tablaPedido.EnableHeadersVisualStyles = false;
            tablaPedido.GridColor = Color.FromArgb(243, 244, 246);
            tablaPedido.Location = new Point(20, 0);
            tablaPedido.MultiSelect = false;
            tablaPedido.Name = "tablaPedido";
            tablaPedido.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tablaPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tablaPedido.RowHeadersVisible = false;
            tablaPedido.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            tablaPedido.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tablaPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaPedido.Size = new Size(296, 194);
            tablaPedido.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.FillWeight = 265.726929F;
            dataGridViewTextBoxColumn7.HeaderText = "Producto";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.False;
            // 
            // Menos
            // 
            Menos.FillWeight = 68.5233459F;
            Menos.HeaderText = "-";
            Menos.MinimumWidth = 6;
            Menos.Name = "Menos";
            Menos.ReadOnly = true;
            Menos.Text = "-";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.FillWeight = 38.39068F;
            dataGridViewTextBoxColumn8.HeaderText = "#";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.False;
            // 
            // Mas
            // 
            Mas.FillWeight = 69.96196F;
            Mas.HeaderText = "+";
            Mas.MinimumWidth = 6;
            Mas.Name = "Mas";
            Mas.ReadOnly = true;
            Mas.Text = "+";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.FillWeight = 121.880905F;
            dataGridViewTextBoxColumn9.HeaderText = "Precio";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.FillWeight = 76.2094955F;
            dataGridViewTextBoxColumn10.HeaderText = "Total";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Resizable = DataGridViewTriState.False;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblIdPedido);
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(12, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(336, 125);
            panel7.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(368, 71);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(28, 67, 95);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "RESUMEN DEL PEDIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 71);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha de orden";
            // 
            // btnCotizar
            // 
            btnCotizar.BackColor = Color.FromArgb(28, 67, 95);
            btnCotizar.FlatAppearance.BorderSize = 0;
            btnCotizar.FlatStyle = FlatStyle.Flat;
            btnCotizar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCotizar.ForeColor = Color.White;
            btnCotizar.Location = new Point(20, 95);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(296, 32);
            btnCotizar.TabIndex = 0;
            btnCotizar.Text = "COTIZAR";
            btnCotizar.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.BackColor = Color.FromArgb(28, 67, 95);
            btnFinalizarPedido.FlatAppearance.BorderSize = 0;
            btnFinalizarPedido.FlatStyle = FlatStyle.Flat;
            btnFinalizarPedido.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnFinalizarPedido.ForeColor = Color.White;
            btnFinalizarPedido.Location = new Point(20, 133);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(296, 32);
            btnFinalizarPedido.TabIndex = 1;
            btnFinalizarPedido.Text = "FINALIZAR PEDIDO";
            btnFinalizarPedido.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(245, 246, 247);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(51, 51, 51);
            btnCancelar.Location = new Point(20, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(296, 28);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.ForeColor = Color.FromArgb(80, 80, 80);
            lblSubtotal.Location = new Point(20, 8);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(115, 20);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "Subtotal Gravado";
            // 
            // lblIva
            // 
            lblIva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblIva.AutoSize = true;
            lblIva.ForeColor = Color.FromArgb(80, 80, 80);
            lblIva.Location = new Point(20, 28);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(65, 20);
            lblIva.TabIndex = 4;
            lblIva.Text = "IVA (13%)";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(28, 67, 95);
            lblTotal.Location = new Point(20, 51);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "TOTAL A PAGAR";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSubtotal.ForeColor = Color.FromArgb(80, 80, 80);
            txtSubtotal.Location = new Point(216, 8);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(100, 20);
            txtSubtotal.TabIndex = 6;
            txtSubtotal.Text = "$53.10";
            txtSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtIva
            // 
            txtIva.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtIva.ForeColor = Color.FromArgb(80, 80, 80);
            txtIva.Location = new Point(216, 28);
            txtIva.Name = "txtIva";
            txtIva.Size = new Size(100, 20);
            txtIva.TabIndex = 7;
            txtIva.Text = "$6.90";
            txtIva.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            txtTotal.ForeColor = Color.FromArgb(28, 67, 95);
            txtTotal.Location = new Point(216, 51);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 25);
            txtTotal.TabIndex = 8;
            txtTotal.Text = "$60.00";
            txtTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIdPedido
            // 
            lblIdPedido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIdPedido.ForeColor = Color.FromArgb(120, 120, 120);
            lblIdPedido.Location = new Point(180, 21);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(140, 20);
            lblIdPedido.TabIndex = 4;
            lblIdPedido.Text = "ID: #49221";
            lblIdPedido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCotizar);
            panel6.Controls.Add(btnFinalizarPedido);
            panel6.Controls.Add(btnCancelar);
            panel6.Controls.Add(lblSubtotal);
            panel6.Controls.Add(lblIva);
            panel6.Controls.Add(lblTotal);
            panel6.Controls.Add(txtSubtotal);
            panel6.Controls.Add(txtIva);
            panel6.Controls.Add(txtTotal);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(12, 294);
            panel6.MinimumSize = new Size(0, 210);
            panel6.Name = "panel6";
            panel6.Size = new Size(336, 210);
            panel6.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevo);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(contenedorProductos);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 444);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(28, 67, 95);
            button1.FlatAppearance.BorderColor = Color.FromArgb(28, 67, 95);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.search__1_;
            button1.Location = new Point(639, 52);
            button1.Name = "button1";
            button1.Size = new Size(37, 29);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(138, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(495, 27);
            textBox1.TabIndex = 2;
            textBox1.PlaceholderText = "Buscar por Nombre, SKU o Código de Barras...";
            // 
            // contenedorProductos
            // 
            contenedorProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contenedorProductos.AutoScroll = true;
            contenedorProductos.Location = new Point(33, 94);
            contenedorProductos.Name = "contenedorProductos";
            contenedorProductos.Padding = new Padding(8);
            contenedorProductos.Size = new Size(643, 324);
            contenedorProductos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 67, 95);
            label1.Location = new Point(33, 52);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "CATÁLOGO DE PRODUCTOS";
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(28, 67, 95);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(495, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(95, 30);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(245, 246, 247);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(51, 51, 51);
            btnEditar.Location = new Point(596, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 30);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // crearPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "crearPedido";
            Text = "CrearPedido";
            tableLayoutPanel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaPedido).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel5;
        private Panel panel8;
        private DataGridView tablaPedido;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewButtonColumn Menos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewButtonColumn Mas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Panel panel7;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Panel panel6;
        private Panel panel1;
        private Label label1;
        private ControlesGUI.SmoothFlowLayoutPanel contenedorProductos;
        private TextBox textBox1;
        private Button button1;
        private Button btnCotizar;
        private Button btnFinalizarPedido;
        private Button btnCancelar;
        private Label lblIdPedido;
        private Label lblSubtotal;
        private Label lblIva;
        private Label lblTotal;
        private Label txtSubtotal;
        private Label txtIva;
        private Label txtTotal;
        private Button btnNuevo;
        private Button btnEditar;
        private Panel panelHeader;
        private Label lblHeaderTitulo;
    }
}