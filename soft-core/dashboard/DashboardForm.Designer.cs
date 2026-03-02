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
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            ChartArea chartArea4 = new ChartArea();
            Legend legend4 = new Legend();
            Series series4 = new Series();
            panelHeader = new Panel();
            lblTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblTotalCierre = new Label();
            panel4 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            pictureBox4 = new PictureBox();
            panel12 = new Panel();
            panel11 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel10 = new Panel();
            panel9 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            chartProductosMasVendidos = new Chart();
            panel2 = new Panel();
            chartGananciaDiaria = new Chart();
            label9 = new Label();
            label10 = new Label();
            panelHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductosMasVendidos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGananciaDiaria).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1477, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(159, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DASHBOARD";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1483, 673);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTotalCierre);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 605);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(28, 67, 95);
            label2.Location = new Point(1124, 30);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 7;
            label2.Text = "Productos mas comprados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 67, 95);
            label1.Location = new Point(752, 30);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 6;
            label1.Text = "Productos mas comprados";
            // 
            // lblTotalCierre
            // 
            lblTotalCierre.AutoSize = true;
            lblTotalCierre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalCierre.ForeColor = Color.FromArgb(28, 67, 95);
            lblTotalCierre.Location = new Point(24, 30);
            lblTotalCierre.Name = "lblTotalCierre";
            lblTotalCierre.Size = new Size(193, 25);
            lblTotalCierre.TabIndex = 5;
            lblTotalCierre.Text = "Ganancias semanales";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(1124, 68);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(12);
            panel4.Size = new Size(344, 468);
            panel4.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel14);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(12, 359);
            panel13.Name = "panel13";
            panel13.Size = new Size(318, 93);
            panel13.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Controls.Add(label9);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(pictureBox4);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(318, 93);
            panel14.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.calendar_1__1_;
            pictureBox4.Location = new Point(15, 19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 57);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel12
            // 
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(12, 336);
            panel12.Name = "panel12";
            panel12.Size = new Size(318, 23);
            panel12.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.Controls.Add(label7);
            panel11.Controls.Add(label8);
            panel11.Controls.Add(pictureBox3);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(12, 243);
            panel11.Name = "panel11";
            panel11.Size = new Size(318, 93);
            panel11.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(99, 52);
            label7.Name = "label7";
            label7.Size = new Size(203, 20);
            label7.TabIndex = 6;
            label7.Text = "Bordados en gorras, stock: 12";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(245, 158, 11);
            label8.Location = new Point(132, 29);
            label8.Name = "label8";
            label8.Size = new Size(170, 23);
            label8.TabIndex = 5;
            label8.Text = "Disponibilidad media";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.circle_alert__1_;
            pictureBox3.Location = new Point(15, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(12, 222);
            panel10.Name = "panel10";
            panel10.Size = new Size(318, 21);
            panel10.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(pictureBox2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(12, 129);
            panel9.Name = "panel9";
            panel9.Size = new Size(318, 93);
            panel9.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(97, 44);
            label5.Name = "label5";
            label5.Size = new Size(205, 20);
            label5.TabIndex = 4;
            label5.Text = "Bordados en camisas, stock: 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(223, 54, 54);
            label6.Location = new Point(149, 21);
            label6.Name = "label6";
            label6.Size = new Size(153, 23);
            label6.TabIndex = 3;
            label6.Text = "Baja disponibilidad";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.triangle_alert__1_;
            pictureBox2.Location = new Point(15, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(12, 105);
            panel7.Name = "panel7";
            panel7.Size = new Size(318, 24);
            panel7.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(318, 93);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel8);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(318, 93);
            panel6.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(pictureBox1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(318, 93);
            panel8.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(107, 40);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 2;
            label4.Text = "Bordados en gorras, stock: 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(223, 54, 54);
            label3.Location = new Point(149, 17);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 1;
            label3.Text = "Baja disponibilidad";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.triangle_alert__1_;
            pictureBox1.Location = new Point(15, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(chartProductosMasVendidos);
            panel3.Location = new Point(752, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 264);
            panel3.TabIndex = 2;
            // 
            // chartProductosMasVendidos
            // 
            chartProductosMasVendidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea3.Name = "ChartArea1";
            chartProductosMasVendidos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartProductosMasVendidos.Legends.Add(legend3);
            chartProductosMasVendidos.Location = new Point(14, 18);
            chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            chartProductosMasVendidos.Palette = ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartProductosMasVendidos.Series.Add(series3);
            chartProductosMasVendidos.Size = new Size(307, 225);
            chartProductosMasVendidos.TabIndex = 0;
            chartProductosMasVendidos.Text = "chart1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(chartGananciaDiaria);
            panel2.Location = new Point(24, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 264);
            panel2.TabIndex = 1;
            // 
            // chartGananciaDiaria
            // 
            chartGananciaDiaria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea4.Name = "ChartArea1";
            chartGananciaDiaria.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartGananciaDiaria.Legends.Add(legend4);
            chartGananciaDiaria.Location = new Point(17, 18);
            chartGananciaDiaria.Name = "chartGananciaDiaria";
            chartGananciaDiaria.Palette = ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 6;
            chartGananciaDiaria.Series.Add(series4);
            chartGananciaDiaria.Size = new Size(666, 225);
            chartGananciaDiaria.TabIndex = 0;
            chartGananciaDiaria.Text = "chart1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(99, 45);
            label9.Name = "label9";
            label9.Size = new Size(203, 20);
            label9.TabIndex = 8;
            label9.Text = "Bordados en gorras, stock: 12";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(39, 100, 235);
            label10.Location = new Point(132, 22);
            label10.Name = "label10";
            label10.Size = new Size(170, 23);
            label10.TabIndex = 7;
            label10.Text = "Disponibilidad media";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1483, 673);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardForm";
            Text = "Dashboard";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartProductosMasVendidos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGananciaDiaria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Chart chartGananciaDiaria;
        private Panel panel3;
        private Chart chartProductosMasVendidos;
        private Panel panel4;
        private Label label1;
        private Label lblTotalCierre;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel13;
        private Panel panel14;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
