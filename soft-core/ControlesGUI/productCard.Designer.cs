using soft_core.UI;

namespace soft_core.ControlesGUI
{
    partial class productCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            imagenProducto = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            stockProducto = new Label();
            nombreProducto = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenProducto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Theme.Background;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 291);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Theme.Card;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(imagenProducto, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5899277F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.4100723F));
            tableLayoutPanel1.Size = new Size(230, 291);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // imagenProducto
            // 
            imagenProducto.BackColor = Theme.Background;
            imagenProducto.Dock = DockStyle.Fill;
            imagenProducto.Location = new Point(3, 3);
            imagenProducto.Name = "imagenProducto";
            imagenProducto.Size = new Size(224, 176);
            imagenProducto.TabIndex = 0;
            imagenProducto.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Theme.Card;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(stockProducto);
            panel2.Controls.Add(nombreProducto);
            panel2.Location = new Point(3, 185);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 103);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 67, 95);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(17, 60);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 2;
            button1.Text = "agregar al carrito";
            button1.UseVisualStyleBackColor = false;
            // 
            // stockProducto
            // 
            stockProducto.AutoSize = true;
            stockProducto.Location = new Point(17, 32);
            stockProducto.Name = "stockProducto";
            stockProducto.Size = new Size(50, 20);
            stockProducto.TabIndex = 1;
            stockProducto.Text = "label2";
            // 
            // nombreProducto
            // 
            nombreProducto.AutoSize = true;
            nombreProducto.Location = new Point(17, 10);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.Size = new Size(50, 20);
            nombreProducto.TabIndex = 0;
            nombreProducto.Text = "label1";
            // 
            // productCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(7);
            Name = "productCard";
            Size = new Size(240, 300);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagenProducto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        public PictureBox imagenProducto;
        private Panel panel2;
        public Button button1;
        public Label nombreProducto;
        public Label stockProducto;
    }
}
