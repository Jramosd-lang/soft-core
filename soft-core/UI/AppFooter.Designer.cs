namespace soft_core.UI
{
    partial class AppFooter
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblInfo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 55, 75);
            panel1.Controls.Add(lblInfo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 35);
            panel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.ForeColor = Color.FromArgb(180, 195, 210);
            lblInfo.Location = new Point(0, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(20, 0, 20, 0);
            lblInfo.Size = new Size(800, 35);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Sucursal: Central | Rol: Administrador | Entorno: Producción";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblInfo.AutoEllipsis = true;
            // 
            // AppFooter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            MinimumSize = new Size(0, 35);
            Name = "AppFooter";
            Size = new Size(800, 35);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblInfo;
    }
}
