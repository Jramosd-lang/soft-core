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
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            panelHeader = new Panel();
            lblTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            panel15 = new Panel();
            label11 = new Label();
            chartCajaVsReal = new Chart();
            label1 = new Label();
            lblTotalCierre = new Label();
            panel3 = new Panel();
            chartProductosMasVendidos = new Chart();
            panel2 = new Panel();
            chartGananciaDiaria = new Chart();
            panel4 = new Panel();
            panel9 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel7 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            panel12 = new Panel();
            panel11 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel10 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panelHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartCajaVsReal).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductosMasVendidos).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGananciaDiaria).BeginInit();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            tableLayoutPanel1.Size = new Size(1483, 1041);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1477, 973);
            panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel15);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(lblTotalCierre);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1477, 973);
            splitContainer1.SplitterDistance = 1099;
            splitContainer1.TabIndex = 0;
            // 
            // panel15
            // 
            panel15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel15.BackColor = Color.White;
            panel15.BorderStyle = BorderStyle.FixedSingle;
            panel15.Controls.Add(label11);
            panel15.Controls.Add(chartCajaVsReal);
            panel15.Location = new Point(36, 349);
            panel15.Name = "panel15";
            panel15.Size = new Size(1038, 471);
            panel15.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(28, 67, 95);
            label11.Location = new Point(60, 21);
            label11.Name = "label11";
            label11.Size = new Size(314, 25);
            label11.TabIndex = 6;
            label11.Text = "Ganancias semanales ( caja vs real )";
            // 
            // chartCajaVsReal
            // 
            chartArea1.Name = "ChartArea1";
            chartCajaVsReal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCajaVsReal.Legends.Add(legend1);
            chartCajaVsReal.Location = new Point(15, 61);
            chartCajaVsReal.Name = "chartCajaVsReal";
            chartCajaVsReal.Palette = ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCajaVsReal.Series.Add(series1);
            chartCajaVsReal.Size = new Size(931, 393);
            chartCajaVsReal.TabIndex = 0;
            chartCajaVsReal.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 67, 95);
            label1.Location = new Point(642, 25);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 13;
            label1.Text = "Productos mas comprados";
            // 
            // lblTotalCierre
            // 
            lblTotalCierre.AutoSize = true;
            lblTotalCierre.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTotalCierre.ForeColor = Color.FromArgb(28, 67, 95);
            lblTotalCierre.Location = new Point(36, 25);
            lblTotalCierre.Name = "lblTotalCierre";
            lblTotalCierre.Size = new Size(193, 25);
            lblTotalCierre.TabIndex = 12;
            lblTotalCierre.Text = "Ganancias semanales";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(chartProductosMasVendidos);
            panel3.Location = new Point(642, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(433, 264);
            panel3.TabIndex = 10;
            // 
            // chartProductosMasVendidos
            // 
            chartArea2.Name = "ChartArea1";
            chartProductosMasVendidos.ChartAreas.Add(chartArea2);
            chartProductosMasVendidos.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartProductosMasVendidos.Legends.Add(legend2);
            chartProductosMasVendidos.Location = new Point(0, 0);
            chartProductosMasVendidos.Name = "chartProductosMasVendidos";
            chartProductosMasVendidos.Palette = ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartProductosMasVendidos.Series.Add(series2);
            chartProductosMasVendidos.Size = new Size(431, 262);
            chartProductosMasVendidos.TabIndex = 0;
            chartProductosMasVendidos.Text = "chart1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(chartGananciaDiaria);
            panel2.Location = new Point(36, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 263);
            panel2.TabIndex = 9;
            // 
            // chartGananciaDiaria
            // 
            chartArea3.Name = "ChartArea1";
            chartGananciaDiaria.ChartAreas.Add(chartArea3);
            chartGananciaDiaria.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartGananciaDiaria.Legends.Add(legend3);
            chartGananciaDiaria.Location = new Point(0, 0);
            chartGananciaDiaria.Name = "chartGananciaDiaria";
            chartGananciaDiaria.Palette = ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 6;
            chartGananciaDiaria.Series.Add(series3);
            chartGananciaDiaria.Size = new Size(579, 261);
            chartGananciaDiaria.TabIndex = 0;
            chartGananciaDiaria.Text = "chart1";
            chartGananciaDiaria.Click += chartGananciaDiaria_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(18, 64);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(12);
            panel4.Size = new Size(329, 468);
            panel4.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label5);
            panel9.Controls.Add(label6);
            panel9.Controls.Add(pictureBox2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(12, 359);
            panel9.Name = "panel9";
            panel9.Size = new Size(305, 93);
            panel9.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(81, 47);
            label5.Name = "label5";
            label5.Size = new Size(205, 20);
            label5.TabIndex = 4;
            label5.Text = "Bordados en camisas, stock: 2";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(223, 54, 54);
            label6.Location = new Point(133, 24);
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
            panel7.Location = new Point(12, 335);
            panel7.Name = "panel7";
            panel7.Size = new Size(305, 24);
            panel7.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel14);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(12, 242);
            panel13.Name = "panel13";
            panel13.Size = new Size(305, 93);
            panel13.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(label9);
            panel14.Controls.Add(label10);
            panel14.Controls.Add(pictureBox4);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(305, 93);
            panel14.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(83, 42);
            label9.Name = "label9";
            label9.Size = new Size(203, 20);
            label9.TabIndex = 8;
            label9.Text = "Bordados en gorras, stock: 12";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(39, 100, 235);
            label10.Location = new Point(116, 19);
            label10.Name = "label10";
            label10.Size = new Size(170, 23);
            label10.TabIndex = 7;
            label10.Text = "Disponibilidad media";
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
            panel12.Location = new Point(12, 219);
            panel12.Name = "panel12";
            panel12.Size = new Size(305, 23);
            panel12.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(label7);
            panel11.Controls.Add(label8);
            panel11.Controls.Add(pictureBox3);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(12, 126);
            panel11.Name = "panel11";
            panel11.Size = new Size(305, 93);
            panel11.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(81, 42);
            label7.Name = "label7";
            label7.Size = new Size(203, 20);
            label7.TabIndex = 6;
            label7.Text = "Bordados en gorras, stock: 12";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(245, 158, 11);
            label8.Location = new Point(114, 19);
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
            panel10.Location = new Point(12, 105);
            panel10.Name = "panel10";
            panel10.Size = new Size(305, 21);
            panel10.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 93);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel8);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 93);
            panel6.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(pictureBox1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(305, 93);
            panel8.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(91, 40);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 2;
            label4.Text = "Bordados en gorras, stock: 2";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(223, 54, 54);
            label3.Location = new Point(133, 17);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(28, 67, 95);
            label2.Location = new Point(18, 26);
            label2.Name = "label2";
            label2.Size = new Size(238, 25);
            label2.TabIndex = 14;
            label2.Text = "Productos mas comprados";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1483, 1041);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardForm";
            Text = "Dashboard";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartCajaVsReal).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartProductosMasVendidos).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGananciaDiaria).EndInit();
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label lblTotalCierre;
        private Panel panel4;
        private Panel panel9;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Panel panel13;
        private Panel panel14;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox4;
        private Panel panel12;
        private Panel panel11;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox3;
        private Panel panel10;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel15;
        private Label label11;
        private Chart chartCajaVsReal;
        private Label label1;
        private Panel panel3;
        private Chart chartProductosMasVendidos;
        private Panel panel2;
        private Chart chartGananciaDiaria;
    }
}
