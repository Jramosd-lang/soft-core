namespace soft_core.caja
{
    partial class CierreCajaForm
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
            panelHeader = new Panel();
            lblHeaderTitulo = new Label();
            panel1 = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblHeaderTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(500, 55);
            panelHeader.TabIndex = 0;
            // 
            // lblHeaderTitulo
            // 
            lblHeaderTitulo.AutoSize = true;
            lblHeaderTitulo.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblHeaderTitulo.ForeColor = Color.White;
            lblHeaderTitulo.Location = new Point(24, 14);
            lblHeaderTitulo.Name = "lblHeaderTitulo";
            lblHeaderTitulo.Size = new Size(164, 32);
            lblHeaderTitulo.TabIndex = 0;
            lblHeaderTitulo.Text = "CIERRE DE CAJA";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 55);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24);
            panel1.Size = new Size(500, 345);
            panel1.TabIndex = 1;
            // 
            // CierreCajaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(500, 400);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Name = "CierreCajaForm";
            Text = "Cierre de Caja";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblHeaderTitulo;
        private Panel panel1;
    }
}
