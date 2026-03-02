using System.Windows.Forms.DataVisualization.Charting;

namespace soft_core.dashboard
{
    partial class DashboardForm
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelCards = new Panel();
            cardVentas = new Panel();
            lblVentas = new Label();
            txtVentas = new Label();
            cardPedidos = new Panel();
            lblPedidos = new Label();
            txtPedidos = new Label();
            cardProductos = new Panel();
            lblProductos = new Label();
            txtProductos = new Label();
            splitCharts = new SplitContainer();
            chartVentas = new Chart();
            chartProductos = new Chart();
            tableLayoutPanel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            cardVentas.SuspendLayout();
            cardPedidos.SuspendLayout();
            cardProductos.SuspendLayout();
            splitCharts.Panel1.SuspendLayout();
            splitCharts.Panel2.SuspendLayout();
            splitCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProductos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(panelCards, 0, 1);
            tableLayoutPanel1.Controls.Add(splitCharts, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1100, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1094, 59);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DASHBOARD";
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.FromArgb(250, 250, 251);
            panelCards.Controls.Add(cardVentas);
            panelCards.Controls.Add(cardPedidos);
            panelCards.Controls.Add(cardProductos);
            panelCards.Dock = DockStyle.Fill;
            panelCards.Location = new Point(3, 68);
            panelCards.Name = "panelCards";
            panelCards.Padding = new Padding(24, 12, 24, 12);
            panelCards.Size = new Size(1094, 94);
            panelCards.TabIndex = 1;
            // 
            // cardVentas
            // 
            cardVentas.BackColor = Color.White;
            cardVentas.Controls.Add(txtVentas);
            cardVentas.Controls.Add(lblVentas);
            cardVentas.Location = new Point(27, 15);
            cardVentas.Name = "cardVentas";
            cardVentas.Padding = new Padding(16);
            cardVentas.Size = new Size(220, 64);
            cardVentas.TabIndex = 0;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblVentas.ForeColor = Color.FromArgb(100, 100, 100);
            lblVentas.Location = new Point(16, 12);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(134, 20);
            lblVentas.TabIndex = 0;
            lblVentas.Text = "Ventas hoy";
            // 
            // txtVentas
            // 
            txtVentas.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtVentas.ForeColor = Color.FromArgb(28, 67, 95);
            txtVentas.Location = new Point(16, 35);
            txtVentas.Name = "txtVentas";
            txtVentas.Size = new Size(188, 30);
            txtVentas.TabIndex = 1;
            txtVentas.Text = "$10,850.00";
            // 
            // cardPedidos
            // 
            cardPedidos.BackColor = Color.White;
            cardPedidos.Controls.Add(txtPedidos);
            cardPedidos.Controls.Add(lblPedidos);
            cardPedidos.Location = new Point(263, 15);
            cardPedidos.Name = "cardPedidos";
            cardPedidos.Padding = new Padding(16);
            cardPedidos.Size = new Size(220, 64);
            cardPedidos.TabIndex = 1;
            // 
            // lblPedidos
            // 
            lblPedidos.AutoSize = true;
            lblPedidos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPedidos.ForeColor = Color.FromArgb(100, 100, 100);
            lblPedidos.Location = new Point(16, 12);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(153, 20);
            lblPedidos.TabIndex = 0;
            lblPedidos.Text = "Pedidos pendientes";
            // 
            // txtPedidos
            // 
            txtPedidos.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtPedidos.ForeColor = Color.FromArgb(28, 67, 95);
            txtPedidos.Location = new Point(16, 35);
            txtPedidos.Name = "txtPedidos";
            txtPedidos.Size = new Size(188, 30);
            txtPedidos.TabIndex = 1;
            txtPedidos.Text = "12";
            // 
            // cardProductos
            // 
            cardProductos.BackColor = Color.White;
            cardProductos.Controls.Add(txtProductos);
            cardProductos.Controls.Add(lblProductos);
            cardProductos.Location = new Point(499, 15);
            cardProductos.Name = "cardProductos";
            cardProductos.Padding = new Padding(16);
            cardProductos.Size = new Size(220, 64);
            cardProductos.TabIndex = 2;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProductos.ForeColor = Color.FromArgb(100, 100, 100);
            lblProductos.Location = new Point(16, 12);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(182, 20);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "Productos en inventario";
            // 
            // txtProductos
            // 
            txtProductos.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtProductos.ForeColor = Color.FromArgb(28, 67, 95);
            txtProductos.Location = new Point(16, 35);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(188, 30);
            txtProductos.TabIndex = 1;
            txtProductos.Text = "156";
            // 
            // splitCharts
            // 
            splitCharts.Dock = DockStyle.Fill;
            splitCharts.Location = new Point(3, 168);
            splitCharts.Name = "splitCharts";
            // 
            // splitCharts.Panel1
            // 
            splitCharts.Panel1.BackColor = Color.FromArgb(250, 250, 251);
            splitCharts.Panel1.Controls.Add(chartVentas);
            splitCharts.Panel1.Padding = new Padding(20);
            // 
            // splitCharts.Panel2
            // 
            splitCharts.Panel2.BackColor = Color.FromArgb(250, 250, 251);
            splitCharts.Panel2.Controls.Add(chartProductos);
            splitCharts.Panel2.Padding = new Padding(20);
            splitCharts.Size = new Size(1094, 429);
            splitCharts.SplitterDistance = 550;
            splitCharts.TabIndex = 2;
            // 
            // chartVentas
            // 
            chartArea1.Name = "ChartArea1";
            chartVentas.ChartAreas.Add(chartArea1);
            chartVentas.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartVentas.Legends.Add(legend1);
            chartVentas.Location = new Point(20, 20);
            chartVentas.Name = "chartVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            chartVentas.Series.Add(series1);
            chartVentas.Size = new Size(510, 389);
            chartVentas.TabIndex = 0;
            chartVentas.Text = "chart1";
            chartVentas.Palette = ChartColorPalette.BrightPastel;
            // 
            // chartProductos
            // 
            chartArea2.Name = "ChartArea1";
            chartProductos.ChartAreas.Add(chartArea2);
            chartProductos.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartProductos.Legends.Add(legend2);
            chartProductos.Location = new Point(20, 20);
            chartProductos.Name = "chartProductos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Categorías";
            chartProductos.Series.Add(series2);
            chartProductos.Size = new Size(504, 389);
            chartProductos.TabIndex = 0;
            chartProductos.Text = "chart2";
            chartProductos.Palette = ChartColorPalette.BrightPastel;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1100, 600);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardForm";
            Text = "Dashboard";
            tableLayoutPanel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCards.ResumeLayout(false);
            cardVentas.ResumeLayout(false);
            cardVentas.PerformLayout();
            cardPedidos.ResumeLayout(false);
            cardPedidos.PerformLayout();
            cardProductos.ResumeLayout(false);
            cardProductos.PerformLayout();
            splitCharts.Panel1.ResumeLayout(false);
            splitCharts.Panel2.ResumeLayout(false);
            splitCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Panel panelCards;
        private Panel cardVentas;
        private Label lblVentas;
        private Label txtVentas;
        private Panel cardPedidos;
        private Label lblPedidos;
        private Label txtPedidos;
        private Panel cardProductos;
        private Label lblProductos;
        private Label txtProductos;
        private SplitContainer splitCharts;
        private Chart chartVentas;
        private Chart chartProductos;
    }
}
