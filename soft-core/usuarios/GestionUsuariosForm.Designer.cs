namespace soft_core.usuarios
{
    partial class GestionUsuariosForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblVersion = new Label();
            panelTabs = new Panel();
            btnUsuarios = new Button();
            btnRoles = new Button();
            btnAuditoria = new Button();
            txtBuscar = new TextBox();
            lblUsuarioInfo = new Label();
            panelMain = new Panel();
            btnNuevoRegistro = new Button();
            btnActualizar = new Button();
            lblCantidadUsuarios = new Label();
            dgvUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombreCompleto = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colRolSistema = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colAcciones = new DataGridViewButtonColumn();
            panelSidebar = new Panel();
            lblEditarTitulo = new Label();
            txtNombreCompleto = new TextBox();
            lblNombreCompleto = new Label();
            txtUsuario = new TextBox();
            lblUsuarioEdit = new Label();
            cmbRol = new ComboBox();
            lblRol = new Label();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            groupPermisos = new GroupBox();
            chkInventario = new CheckBox();
            chkVentas = new CheckBox();
            chkReportesFinancieros = new CheckBox();
            chkConfiguracion = new CheckBox();
            chkAuditoria = new CheckBox();
            btnGuardarCambios = new Button();
            btnCancelarEdit = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panelTabs.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelSidebar.SuspendLayout();
            groupPermisos.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 360F));
            tableLayoutPanel1.Controls.Add(panelHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(panelMain, 0, 1);
            tableLayoutPanel1.Controls.Add(panelSidebar, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1200, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(28, 67, 95);
            panelHeader.Controls.Add(lblUsuarioInfo);
            panelHeader.Controls.Add(txtBuscar);
            panelHeader.Controls.Add(panelTabs);
            panelHeader.Controls.Add(lblVersion);
            panelHeader.Controls.Add(lblTitulo);
            tableLayoutPanel1.SetColumnSpan(panelHeader, 2);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1194, 64);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE ACCESOS";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.ForeColor = Color.FromArgb(180, 200, 220);
            lblVersion.Location = new Point(255, 23);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(36, 20);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "V2.4";
            // 
            // panelTabs
            // 
            panelTabs.Controls.Add(btnUsuarios);
            panelTabs.Controls.Add(btnRoles);
            panelTabs.Controls.Add(btnAuditoria);
            panelTabs.Location = new Point(320, 12);
            panelTabs.Name = "panelTabs";
            panelTabs.Size = new Size(320, 45);
            panelTabs.TabIndex = 2;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(70, 120, 160);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.Location = new Point(0, 0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(100, 42);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnRoles
            // 
            btnRoles.BackColor = Color.Transparent;
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 86, 111);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnRoles.ForeColor = Color.FromArgb(187, 199, 207);
            btnRoles.Location = new Point(106, 0);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(100, 42);
            btnRoles.TabIndex = 1;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = false;
            // 
            // btnAuditoria
            // 
            btnAuditoria.BackColor = Color.Transparent;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 86, 111);
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnAuditoria.ForeColor = Color.FromArgb(187, 199, 207);
            btnAuditoria.Location = new Point(212, 0);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(100, 42);
            btnAuditoria.TabIndex = 2;
            btnAuditoria.Text = "Auditoría";
            btnAuditoria.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.ForeColor = Color.Gray;
            txtBuscar.Location = new Point(680, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(220, 29);
            txtBuscar.TabIndex = 3;
            // 
            // lblUsuarioInfo
            // 
            lblUsuarioInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuarioInfo.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblUsuarioInfo.ForeColor = Color.White;
            lblUsuarioInfo.Location = new Point(920, 18);
            lblUsuarioInfo.Name = "lblUsuarioInfo";
            lblUsuarioInfo.Size = new Size(250, 28);
            lblUsuarioInfo.TabIndex = 4;
            lblUsuarioInfo.Text = "Admin Local  ADMINISTRADOR";
            lblUsuarioInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(dgvUsuarios);
            panelMain.Controls.Add(lblCantidadUsuarios);
            panelMain.Controls.Add(btnActualizar);
            panelMain.Controls.Add(btnNuevoRegistro);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(3, 73);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(24);
            panelMain.Size = new Size(831, 539);
            panelMain.TabIndex = 1;
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = Color.FromArgb(28, 67, 95);
            btnNuevoRegistro.FlatAppearance.BorderSize = 0;
            btnNuevoRegistro.FlatStyle = FlatStyle.Flat;
            btnNuevoRegistro.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnNuevoRegistro.ForeColor = Color.White;
            btnNuevoRegistro.Location = new Point(24, 16);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(180, 38);
            btnNuevoRegistro.TabIndex = 0;
            btnNuevoRegistro.Text = "+ NUEVO REGISTRO";
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(245, 246, 247);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.FromArgb(51, 51, 51);
            btnActualizar.Location = new Point(210, 16);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 38);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lblCantidadUsuarios
            // 
            lblCantidadUsuarios.AutoSize = true;
            lblCantidadUsuarios.ForeColor = Color.FromArgb(100, 100, 100);
            lblCantidadUsuarios.Location = new Point(24, 62);
            lblCantidadUsuarios.Name = "lblCantidadUsuarios";
            lblCantidadUsuarios.Size = new Size(260, 20);
            lblCantidadUsuarios.TabIndex = 2;
            lblCantidadUsuarios.Text = "Mostrando 24 usuarios registrados";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(59, 59, 59);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 245, 246);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(59, 59, 59);
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 36;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colNombreCompleto, colUsuario, colRolSistema, colEstado, colAcciones });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(243, 244, 246);
            dgvUsuarios.Location = new Point(24, 92);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(51, 51, 51);
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowTemplate.Height = 36;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(783, 423);
            dgvUsuarios.TabIndex = 3;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 50;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 55;
            // 
            // colNombreCompleto
            // 
            colNombreCompleto.HeaderText = "NOMBRE COMPLETO";
            colNombreCompleto.MinimumWidth = 150;
            colNombreCompleto.Name = "colNombreCompleto";
            colNombreCompleto.ReadOnly = true;
            colNombreCompleto.Width = 200;
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "USUARIO";
            colUsuario.MinimumWidth = 100;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 130;
            // 
            // colRolSistema
            // 
            colRolSistema.HeaderText = "ROL DE SISTEMA";
            colRolSistema.MinimumWidth = 100;
            colRolSistema.Name = "colRolSistema";
            colRolSistema.ReadOnly = true;
            colRolSistema.Width = 140;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "ESTADO";
            colEstado.MinimumWidth = 80;
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 100;
            // 
            // colAcciones
            // 
            colAcciones.HeaderText = "ACCIONES";
            colAcciones.MinimumWidth = 70;
            colAcciones.Name = "colAcciones";
            colAcciones.ReadOnly = true;
            colAcciones.Text = "⋯";
            colAcciones.UseColumnTextForButtonValue = true;
            colAcciones.Width = 90;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(250, 250, 251);
            panelSidebar.BorderStyle = BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(btnCancelarEdit);
            panelSidebar.Controls.Add(btnGuardarCambios);
            panelSidebar.Controls.Add(groupPermisos);
            panelSidebar.Controls.Add(txtContrasena);
            panelSidebar.Controls.Add(lblContrasena);
            panelSidebar.Controls.Add(cmbRol);
            panelSidebar.Controls.Add(lblRol);
            panelSidebar.Controls.Add(txtUsuario);
            panelSidebar.Controls.Add(lblUsuarioEdit);
            panelSidebar.Controls.Add(txtNombreCompleto);
            panelSidebar.Controls.Add(lblNombreCompleto);
            panelSidebar.Controls.Add(lblEditarTitulo);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(840, 73);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(20);
            panelSidebar.Size = new Size(357, 539);
            panelSidebar.TabIndex = 2;
            // 
            // lblEditarTitulo
            // 
            lblEditarTitulo.AutoSize = true;
            lblEditarTitulo.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblEditarTitulo.ForeColor = Color.FromArgb(28, 67, 95);
            lblEditarTitulo.Location = new Point(23, 20);
            lblEditarTitulo.Name = "lblEditarTitulo";
            lblEditarTitulo.Size = new Size(140, 25);
            lblEditarTitulo.TabIndex = 0;
            lblEditarTitulo.Text = "EDITAR USUARIO";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 9.5F);
            txtNombreCompleto.Location = new Point(23, 95);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.PlaceholderText = "Nombre completo";
            txtNombreCompleto.Size = new Size(305, 29);
            txtNombreCompleto.TabIndex = 1;
            txtNombreCompleto.Text = "Juan Pérez González";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNombreCompleto.ForeColor = Color.FromArgb(59, 59, 59);
            lblNombreCompleto.Location = new Point(23, 72);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(137, 20);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "NOMBRE COMPLETO";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9.5F);
            txtUsuario.Location = new Point(23, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(305, 29);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "jperez.admin";
            // 
            // lblUsuarioEdit
            // 
            lblUsuarioEdit.AutoSize = true;
            lblUsuarioEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblUsuarioEdit.ForeColor = Color.FromArgb(59, 59, 59);
            lblUsuarioEdit.Location = new Point(23, 137);
            lblUsuarioEdit.Name = "lblUsuarioEdit";
            lblUsuarioEdit.Size = new Size(70, 20);
            lblUsuarioEdit.TabIndex = 4;
            lblUsuarioEdit.Text = "USUARIO";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 9.5F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Supervisor", "Operador" });
            cmbRol.Location = new Point(23, 225);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(230, 29);
            cmbRol.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRol.ForeColor = Color.FromArgb(59, 59, 59);
            lblRol.Location = new Point(23, 202);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(35, 20);
            lblRol.TabIndex = 6;
            lblRol.Text = "ROL";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 9.5F);
            txtContrasena.Location = new Point(23, 290);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '•';
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(280, 29);
            txtContrasena.TabIndex = 7;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblContrasena.ForeColor = Color.FromArgb(59, 59, 59);
            lblContrasena.Location = new Point(23, 267);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(103, 20);
            lblContrasena.TabIndex = 8;
            lblContrasena.Text = "CONTRASEÑA";
            // 
            // groupPermisos
            // 
            groupPermisos.Controls.Add(chkInventario);
            groupPermisos.Controls.Add(chkVentas);
            groupPermisos.Controls.Add(chkReportesFinancieros);
            groupPermisos.Controls.Add(chkConfiguracion);
            groupPermisos.Controls.Add(chkAuditoria);
            groupPermisos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            groupPermisos.ForeColor = Color.FromArgb(28, 67, 95);
            groupPermisos.Location = new Point(23, 335);
            groupPermisos.Name = "groupPermisos";
            groupPermisos.Size = new Size(305, 180);
            groupPermisos.TabIndex = 9;
            groupPermisos.TabStop = false;
            groupPermisos.Text = "PERMISOS POR MÓDULO";
            // 
            // chkInventario
            // 
            chkInventario.AutoSize = true;
            chkInventario.Checked = true;
            chkInventario.CheckState = CheckState.Checked;
            chkInventario.Font = new Font("Segoe UI", 9F);
            chkInventario.ForeColor = Color.FromArgb(59, 59, 59);
            chkInventario.Location = new Point(16, 35);
            chkInventario.Name = "chkInventario";
            chkInventario.Size = new Size(189, 24);
            chkInventario.TabIndex = 0;
            chkInventario.Text = "Módulo de Inventario";
            chkInventario.UseVisualStyleBackColor = true;
            // 
            // chkVentas
            // 
            chkVentas.AutoSize = true;
            chkVentas.Checked = true;
            chkVentas.CheckState = CheckState.Checked;
            chkVentas.Font = new Font("Segoe UI", 9F);
            chkVentas.ForeColor = Color.FromArgb(59, 59, 59);
            chkVentas.Location = new Point(16, 65);
            chkVentas.Name = "chkVentas";
            chkVentas.Size = new Size(161, 24);
            chkVentas.TabIndex = 1;
            chkVentas.Text = "Módulo de Ventas";
            chkVentas.UseVisualStyleBackColor = true;
            // 
            // chkReportesFinancieros
            // 
            chkReportesFinancieros.AutoSize = true;
            chkReportesFinancieros.Font = new Font("Segoe UI", 9F);
            chkReportesFinancieros.ForeColor = Color.FromArgb(59, 59, 59);
            chkReportesFinancieros.Location = new Point(16, 95);
            chkReportesFinancieros.Name = "chkReportesFinancieros";
            chkReportesFinancieros.Size = new Size(164, 24);
            chkReportesFinancieros.TabIndex = 2;
            chkReportesFinancieros.Text = "Reportes Financieros";
            chkReportesFinancieros.UseVisualStyleBackColor = true;
            // 
            // chkConfiguracion
            // 
            chkConfiguracion.AutoSize = true;
            chkConfiguracion.Checked = true;
            chkConfiguracion.CheckState = CheckState.Checked;
            chkConfiguracion.Font = new Font("Segoe UI", 9F);
            chkConfiguracion.ForeColor = Color.FromArgb(59, 59, 59);
            chkConfiguracion.Location = new Point(16, 125);
            chkConfiguracion.Name = "chkConfiguracion";
            chkConfiguracion.Size = new Size(195, 24);
            chkConfiguracion.TabIndex = 3;
            chkConfiguracion.Text = "Configuración de Sistema";
            chkConfiguracion.UseVisualStyleBackColor = true;
            // 
            // chkAuditoria
            // 
            chkAuditoria.AutoSize = true;
            chkAuditoria.Font = new Font("Segoe UI", 9F);
            chkAuditoria.ForeColor = Color.FromArgb(59, 59, 59);
            chkAuditoria.Location = new Point(16, 155);
            chkAuditoria.Name = "chkAuditoria";
            chkAuditoria.Size = new Size(240, 24);
            chkAuditoria.TabIndex = 4;
            chkAuditoria.Text = "Auditoría Avanzada (Restringido)";
            chkAuditoria.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardarCambios.BackColor = Color.FromArgb(28, 67, 95);
            btnGuardarCambios.FlatAppearance.BorderSize = 0;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnGuardarCambios.ForeColor = Color.White;
            btnGuardarCambios.Location = new Point(23, 525);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(180, 36);
            btnGuardarCambios.TabIndex = 10;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // btnCancelarEdit
            // 
            btnCancelarEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelarEdit.BackColor = Color.White;
            btnCancelarEdit.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancelarEdit.FlatStyle = FlatStyle.Flat;
            btnCancelarEdit.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnCancelarEdit.ForeColor = Color.FromArgb(51, 51, 51);
            btnCancelarEdit.Location = new Point(213, 525);
            btnCancelarEdit.Name = "btnCancelarEdit";
            btnCancelarEdit.Size = new Size(115, 36);
            btnCancelarEdit.TabIndex = 11;
            btnCancelarEdit.Text = "Cancelar";
            btnCancelarEdit.UseVisualStyleBackColor = false;
            // 
            // GestionUsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 251);
            ClientSize = new Size(1200, 650);
            Controls.Add(tableLayoutPanel1);
            Name = "GestionUsuariosForm";
            Text = "Gestión de Accesos";
            tableLayoutPanel1.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTabs.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            groupPermisos.ResumeLayout(false);
            groupPermisos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblVersion;
        private Panel panelTabs;
        private Button btnUsuarios;
        private Button btnRoles;
        private Button btnAuditoria;
        private TextBox txtBuscar;
        private Label lblUsuarioInfo;
        private Panel panelMain;
        private Button btnNuevoRegistro;
        private Button btnActualizar;
        private Label lblCantidadUsuarios;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombreCompleto;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colRolSistema;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewButtonColumn colAcciones;
        private Panel panelSidebar;
        private Label lblEditarTitulo;
        private TextBox txtNombreCompleto;
        private Label lblNombreCompleto;
        private TextBox txtUsuario;
        private Label lblUsuarioEdit;
        private ComboBox cmbRol;
        private Label lblRol;
        private TextBox txtContrasena;
        private Label lblContrasena;
        private GroupBox groupPermisos;
        private CheckBox chkInventario;
        private CheckBox chkVentas;
        private CheckBox chkReportesFinancieros;
        private CheckBox chkConfiguracion;
        private CheckBox chkAuditoria;
        private Button btnGuardarCambios;
        private Button btnCancelarEdit;
    }
}
