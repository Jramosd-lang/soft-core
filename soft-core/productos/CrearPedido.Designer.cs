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
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            contenedorProductos = new FlowLayoutPanel();
            label1 = new Label();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1078, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(715, 3);
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
            label2.Text = "Crear pedido";
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
            panel6.Controls.Add(button2);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(12, 319);
            panel6.Name = "panel6";
            panel6.Size = new Size(336, 125);
            panel6.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(contenedorProductos);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
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
            textBox1.Text = "  Buscar productos por nombre";
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
            label1.Text = "Productos";
            // 
            // button2
            // 
            button2.Location = new Point(20, 19);
            button2.Name = "button2";
            button2.Size = new Size(296, 29);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
        private FlowLayoutPanel contenedorProductos;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}