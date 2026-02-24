namespace soft_core.productos
{
    partial class gestionarPedidos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionarPedidos));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel4 = new Panel();
            tablaProductos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
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
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProductos).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaPedido).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1482, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 444);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 242, 245);
            panel4.Controls.Add(tablaProductos);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(1016, 349);
            panel4.TabIndex = 6;
            // 
            // tablaProductos
            // 
            tablaProductos.AllowUserToResizeColumns = false;
            tablaProductos.AllowUserToResizeRows = false;
            tablaProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaProductos.BackgroundColor = Color.White;
            tablaProductos.BorderStyle = BorderStyle.None;
            tablaProductos.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            tablaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(59, 59, 59);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tablaProductos.ColumnHeadersHeight = 29;
            tablaProductos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Stock, Precio, Accion });
            tablaProductos.EnableHeadersVisualStyles = false;
            tablaProductos.GridColor = Color.FromArgb(243, 244, 246);
            tablaProductos.Location = new Point(19, 21);
            tablaProductos.MultiSelect = false;
            tablaProductos.Name = "tablaProductos";
            tablaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tablaProductos.RowHeadersVisible = false;
            tablaProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            tablaProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            tablaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaProductos.Size = new Size(976, 303);
            tablaProductos.TabIndex = 0;
            tablaProductos.CellContentClick += tablaProductos_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.FillWeight = 59.3068F;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.FillWeight = 233.178375F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            Stock.FillWeight = 33.6882553F;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // Precio
            // 
            Precio.FillWeight = 106.951874F;
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Accion
            // 
            Accion.FillWeight = 66.87471F;
            Accion.HeaderText = "Accion";
            Accion.MinimumWidth = 6;
            Accion.Name = "Accion";
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1016, 95);
            panel3.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(245, 246, 247);
            button3.FlatAppearance.BorderColor = Color.FromArgb(173, 181, 189);
            button3.FlatAppearance.BorderSize = 2;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(51, 51, 51);
            button3.Location = new Point(693, 51);
            button3.Name = "button3";
            button3.Size = new Size(95, 30);
            button3.TabIndex = 3;
            button3.Text = "Filtrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 51);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Filtrar por nombre, codigo o categoria";
            textBox1.Size = new Size(668, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 67, 95);
            label1.Location = new Point(32, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestion de pedidos";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(245, 246, 247);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(51, 51, 51);
            button1.Location = new Point(593, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 1;
            button1.Text = "agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(245, 246, 247);
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(51, 51, 51);
            button2.Location = new Point(693, 14);
            button2.Name = "button2";
            button2.Size = new Size(95, 30);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(1025, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 444);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(454, 444);
            panel5.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(tablaPedido);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 125);
            panel8.Name = "panel8";
            panel8.Size = new Size(454, 194);
            panel8.TabIndex = 7;
            // 
            // tablaPedido
            // 
            tablaPedido.AllowUserToResizeColumns = false;
            tablaPedido.AllowUserToResizeRows = false;
            tablaPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaPedido.BackgroundColor = Color.White;
            tablaPedido.BorderStyle = BorderStyle.None;
            tablaPedido.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            tablaPedido.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(59, 59, 59);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tablaPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tablaPedido.ColumnHeadersHeight = 29;
            tablaPedido.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, Menos, dataGridViewTextBoxColumn8, Mas, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            tablaPedido.Dock = DockStyle.Fill;
            tablaPedido.EnableHeadersVisualStyles = false;
            tablaPedido.GridColor = Color.FromArgb(243, 244, 246);
            tablaPedido.Location = new Point(0, 0);
            tablaPedido.MultiSelect = false;
            tablaPedido.Name = "tablaPedido";
            tablaPedido.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tablaPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            tablaPedido.RowHeadersVisible = false;
            tablaPedido.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(51, 51, 51);
            tablaPedido.RowsDefaultCellStyle = dataGridViewCellStyle6;
            tablaPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaPedido.Size = new Size(454, 194);
            tablaPedido.TabIndex = 4;
            tablaPedido.CellContentClick += tablaPedido_CellContentClick;
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
            panel7.Controls.Add(dateTimePicker1);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(454, 125);
            panel7.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.Location = new Point(232, 71);
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
            label2.Size = new Size(175, 25);
            label2.TabIndex = 1;
            label2.Text = "Gestion de pedidos";
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
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 319);
            panel6.Name = "panel6";
            panel6.Size = new Size(454, 125);
            panel6.TabIndex = 5;
            // 
            // gestionarPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 450);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "gestionarPedidos";
            Text = ".";
            Load += gestionarPedidos_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaProductos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaPedido).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Button button3;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DataGridView tablaProductos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Accion;
        private DataGridView tablaPedido;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewButtonColumn Menos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewButtonColumn Mas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}