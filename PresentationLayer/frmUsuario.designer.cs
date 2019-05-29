namespace PresentationLayer
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstvRequerimientos = new System.Windows.Forms.ListView();
            this.colPermiso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreReq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboIdRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.mskId = new System.Windows.Forms.MaskedTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTipId = new System.Windows.Forms.Label();
            this.lblApel1 = new System.Windows.Forms.Label();
            this.lblApel2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorr = new System.Windows.Forms.Label();
            this.dtpFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblTelef = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mskTelef = new System.Windows.Forms.MaskedTextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.lblNomUsu = new System.Windows.Forms.Label();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.txtConfirmContra = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblConfirmContra = new System.Windows.Forms.Label();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.gbxNombreUser = new System.Windows.Forms.GroupBox();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.tlsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.cboTipId = new System.Windows.Forms.ComboBox();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtOtrasSenas = new System.Windows.Forms.TextBox();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxNombreUser.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.gbxUsuario.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstvRequerimientos);
            this.groupBox1.Controls.Add(this.cboIdRol);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Location = new System.Drawing.Point(455, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(388, 400);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // lstvRequerimientos
            // 
            this.lstvRequerimientos.CheckBoxes = true;
            this.lstvRequerimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPermiso,
            this.colIdReq,
            this.colNombreReq});
            this.lstvRequerimientos.Enabled = false;
            this.lstvRequerimientos.GridLines = true;
            this.lstvRequerimientos.Location = new System.Drawing.Point(32, 60);
            this.lstvRequerimientos.Margin = new System.Windows.Forms.Padding(4);
            this.lstvRequerimientos.Name = "lstvRequerimientos";
            this.lstvRequerimientos.Size = new System.Drawing.Size(347, 333);
            this.lstvRequerimientos.TabIndex = 49;
            this.lstvRequerimientos.UseCompatibleStateImageBehavior = false;
            this.lstvRequerimientos.View = System.Windows.Forms.View.Details;
            // 
            // colPermiso
            // 
            this.colPermiso.Text = "";
            this.colPermiso.Width = 31;
            // 
            // colIdReq
            // 
            this.colIdReq.Text = "ID";
            this.colIdReq.Width = 30;
            // 
            // colNombreReq
            // 
            this.colNombreReq.Text = "Permiso";
            this.colNombreReq.Width = 153;
            // 
            // cboIdRol
            // 
            this.cboIdRol.FormattingEnabled = true;
            this.cboIdRol.Location = new System.Drawing.Point(64, 23);
            this.cboIdRol.Margin = new System.Windows.Forms.Padding(4);
            this.cboIdRol.Name = "cboIdRol";
            this.cboIdRol.Size = new System.Drawing.Size(255, 24);
            this.cboIdRol.TabIndex = 14;
            this.cboIdRol.SelectedIndexChanged += new System.EventHandler(this.cboIdRol_SelectedIndexChanged);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(28, 27);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(33, 17);
            this.lblRol.TabIndex = 33;
            this.lblRol.Text = "Rol:";
            // 
            // mskId
            // 
            this.mskId.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskId.Location = new System.Drawing.Point(167, 61);
            this.mskId.Margin = new System.Windows.Forms.Padding(4);
            this.mskId.Mask = "0-0000-0000";
            this.mskId.Name = "mskId";
            this.mskId.Size = new System.Drawing.Size(209, 22);
            this.mskId.TabIndex = 1;
            this.mskId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(133, 65);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(167, 61);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 30;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(209, 22);
            this.txtId.TabIndex = 25;
            this.txtId.Visible = false;
            // 
            // lblTipId
            // 
            this.lblTipId.AutoSize = true;
            this.lblTipId.Location = new System.Drawing.Point(81, 34);
            this.lblTipId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipId.Name = "lblTipId";
            this.lblTipId.Size = new System.Drawing.Size(75, 17);
            this.lblTipId.TabIndex = 29;
            this.lblTipId.Text = "Tipo de Id:";
            // 
            // lblApel1
            // 
            this.lblApel1.AutoSize = true;
            this.lblApel1.Location = new System.Drawing.Point(55, 130);
            this.lblApel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApel1.Name = "lblApel1";
            this.lblApel1.Size = new System.Drawing.Size(106, 17);
            this.lblApel1.TabIndex = 35;
            this.lblApel1.Text = "Primer apellido:";
            // 
            // lblApel2
            // 
            this.lblApel2.AutoSize = true;
            this.lblApel2.Location = new System.Drawing.Point(36, 162);
            this.lblApel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApel2.Name = "lblApel2";
            this.lblApel2.Size = new System.Drawing.Size(122, 17);
            this.lblApel2.TabIndex = 36;
            this.lblApel2.Text = "Segundo apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(96, 98);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCorr
            // 
            this.lblCorr.AutoSize = true;
            this.lblCorr.Location = new System.Drawing.Point(104, 258);
            this.lblCorr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(55, 17);
            this.lblCorr.TabIndex = 37;
            this.lblCorr.Text = "Correo:";
            // 
            // dtpFechNac
            // 
            this.dtpFechNac.Location = new System.Drawing.Point(167, 190);
            this.dtpFechNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechNac.Name = "dtpFechNac";
            this.dtpFechNac.Size = new System.Drawing.Size(259, 22);
            this.dtpFechNac.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(167, 254);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 22);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(167, 158);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido2.MaxLength = 30;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(259, 22);
            this.txtApellido2.TabIndex = 4;
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Location = new System.Drawing.Point(89, 226);
            this.lblTelef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(68, 17);
            this.lblTelef.TabIndex = 40;
            this.lblTelef.Text = "Telefono:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(167, 126);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido1.MaxLength = 30;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(259, 22);
            this.txtApellido1.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 94);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // mskTelef
            // 
            this.mskTelef.Location = new System.Drawing.Point(167, 222);
            this.mskTelef.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelef.Mask = "0000-0000";
            this.mskTelef.Name = "mskTelef";
            this.mskTelef.Size = new System.Drawing.Size(259, 22);
            this.mskTelef.TabIndex = 6;
            this.mskTelef.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(76, 59);
            this.lblContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(85, 17);
            this.lblContra.TabIndex = 31;
            this.lblContra.Text = "Contraseña:";
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Checked = true;
            this.rbtMasc.Location = new System.Drawing.Point(83, 11);
            this.rbtMasc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(92, 21);
            this.rbtMasc.TabIndex = 8;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // lblNomUsu
            // 
            this.lblNomUsu.AutoSize = true;
            this.lblNomUsu.Location = new System.Drawing.Point(29, 27);
            this.lblNomUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsu.Name = "lblNomUsu";
            this.lblNomUsu.Size = new System.Drawing.Size(133, 17);
            this.lblNomUsu.TabIndex = 30;
            this.lblNomUsu.Text = "Nombre de usuario:";
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(248, 11);
            this.rbtFem.Margin = new System.Windows.Forms.Padding(4);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(91, 21);
            this.rbtFem.TabIndex = 9;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "Femenino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.Location = new System.Drawing.Point(169, 23);
            this.txtNomUsu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomUsu.MaxLength = 30;
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(211, 22);
            this.txtNomUsu.TabIndex = 11;
            // 
            // txtConfirmContra
            // 
            this.txtConfirmContra.Location = new System.Drawing.Point(169, 87);
            this.txtConfirmContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmContra.MaxLength = 30;
            this.txtConfirmContra.Name = "txtConfirmContra";
            this.txtConfirmContra.PasswordChar = '*';
            this.txtConfirmContra.Size = new System.Drawing.Size(211, 22);
            this.txtConfirmContra.TabIndex = 13;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(169, 55);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.MaxLength = 30;
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(211, 22);
            this.txtContra.TabIndex = 12;
            // 
            // lblConfirmContra
            // 
            this.lblConfirmContra.AutoSize = true;
            this.lblConfirmContra.Location = new System.Drawing.Point(15, 91);
            this.lblConfirmContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmContra.Name = "lblConfirmContra";
            this.lblConfirmContra.Size = new System.Drawing.Size(148, 17);
            this.lblConfirmContra.TabIndex = 47;
            this.lblConfirmContra.Text = "Confirmar contraseña:";
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.Location = new System.Drawing.Point(13, 198);
            this.lblFechNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(143, 17);
            this.lblFechNac.TabIndex = 38;
            this.lblFechNac.Text = "Fecha de nacimiento:";
            // 
            // gbxNombreUser
            // 
            this.gbxNombreUser.Controls.Add(this.txtNomUsu);
            this.gbxNombreUser.Controls.Add(this.lblContra);
            this.gbxNombreUser.Controls.Add(this.lblNomUsu);
            this.gbxNombreUser.Controls.Add(this.txtConfirmContra);
            this.gbxNombreUser.Controls.Add(this.txtContra);
            this.gbxNombreUser.Controls.Add(this.lblConfirmContra);
            this.gbxNombreUser.Location = new System.Drawing.Point(16, 533);
            this.gbxNombreUser.Margin = new System.Windows.Forms.Padding(4);
            this.gbxNombreUser.Name = "gbxNombreUser";
            this.gbxNombreUser.Padding = new System.Windows.Forms.Padding(4);
            this.gbxNombreUser.Size = new System.Drawing.Size(389, 125);
            this.gbxNombreUser.TabIndex = 50;
            this.gbxNombreUser.TabStop = false;
            this.gbxNombreUser.Text = "Usuario";
            // 
            // tlsMenu
            // 
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsBtnGuardar,
            this.toolStripSeparator1,
            this.tlsBtnNuevo,
            this.toolStripSeparator2,
            this.tlsBtnModificar,
            this.toolStripSeparator3,
            this.tlsBtnEliminar,
            this.toolStripSeparator4,
            this.tlsBtnBuscar,
            this.toolStripSeparator5,
            this.tlsBtnCancelar,
            this.toolStripSeparator6,
            this.tlsBtnSalir});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(915, 39);
            this.tlsMenu.TabIndex = 51;
            this.tlsMenu.Text = "toolStrip1";
            this.tlsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsMenu_ItemClicked);
            // 
            // tlsBtnGuardar
            // 
            this.tlsBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnGuardar.Image")));
            this.tlsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnGuardar.MergeIndex = 1;
            this.tlsBtnGuardar.Name = "tlsBtnGuardar";
            this.tlsBtnGuardar.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnGuardar.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsBtnNuevo
            // 
            this.tlsBtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnNuevo.Image")));
            this.tlsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnNuevo.MergeIndex = 2;
            this.tlsBtnNuevo.Name = "tlsBtnNuevo";
            this.tlsBtnNuevo.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnNuevo.Text = "Nuevo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsBtnModificar
            // 
            this.tlsBtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnModificar.Image")));
            this.tlsBtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnModificar.MergeIndex = 3;
            this.tlsBtnModificar.Name = "tlsBtnModificar";
            this.tlsBtnModificar.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnModificar.Text = "Modificar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsBtnEliminar
            // 
            this.tlsBtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnEliminar.Image")));
            this.tlsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnEliminar.MergeIndex = 4;
            this.tlsBtnEliminar.Name = "tlsBtnEliminar";
            this.tlsBtnEliminar.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsBtnBuscar
            // 
            this.tlsBtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnBuscar.Image")));
            this.tlsBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnBuscar.MergeIndex = 5;
            this.tlsBtnBuscar.Name = "tlsBtnBuscar";
            this.tlsBtnBuscar.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnBuscar.Text = "Buscar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsBtnCancelar
            // 
            this.tlsBtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnCancelar.Image")));
            this.tlsBtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnCancelar.MergeIndex = 6;
            this.tlsBtnCancelar.Name = "tlsBtnCancelar";
            this.tlsBtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnCancelar.Text = "Cancelar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsBtnSalir
            // 
            this.tlsBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnSalir.Image")));
            this.tlsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnSalir.MergeIndex = 7;
            this.tlsBtnSalir.Name = "tlsBtnSalir";
            this.tlsBtnSalir.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnSalir.Text = "Salir";
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.cboBarrios);
            this.gbxUsuario.Controls.Add(this.label7);
            this.gbxUsuario.Controls.Add(this.label6);
            this.gbxUsuario.Controls.Add(this.label5);
            this.gbxUsuario.Controls.Add(this.label4);
            this.gbxUsuario.Controls.Add(this.cboProvincia);
            this.gbxUsuario.Controls.Add(this.cboCanton);
            this.gbxUsuario.Controls.Add(this.cboDistrito);
            this.gbxUsuario.Controls.Add(this.txtOtrasSenas);
            this.gbxUsuario.Controls.Add(this.lblobservaciones);
            this.gbxUsuario.Controls.Add(this.btnBuscarCliente);
            this.gbxUsuario.Controls.Add(this.gbxSexo);
            this.gbxUsuario.Controls.Add(this.cboTipId);
            this.gbxUsuario.Controls.Add(this.gbxNombreUser);
            this.gbxUsuario.Controls.Add(this.mskId);
            this.gbxUsuario.Controls.Add(this.lblId);
            this.gbxUsuario.Controls.Add(this.groupBox1);
            this.gbxUsuario.Controls.Add(this.txtId);
            this.gbxUsuario.Controls.Add(this.lblApel1);
            this.gbxUsuario.Controls.Add(this.lblApel2);
            this.gbxUsuario.Controls.Add(this.lblNombre);
            this.gbxUsuario.Controls.Add(this.lblFechNac);
            this.gbxUsuario.Controls.Add(this.lblCorr);
            this.gbxUsuario.Controls.Add(this.lblTipId);
            this.gbxUsuario.Controls.Add(this.dtpFechNac);
            this.gbxUsuario.Controls.Add(this.txtCorreo);
            this.gbxUsuario.Controls.Add(this.mskTelef);
            this.gbxUsuario.Controls.Add(this.txtApellido2);
            this.gbxUsuario.Controls.Add(this.txtNombre);
            this.gbxUsuario.Controls.Add(this.lblTelef);
            this.gbxUsuario.Controls.Add(this.txtApellido1);
            this.gbxUsuario.Location = new System.Drawing.Point(16, 52);
            this.gbxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.gbxUsuario.Size = new System.Drawing.Size(881, 671);
            this.gbxUsuario.TabIndex = 52;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Creacion de usuario";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(390, 56);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(36, 34);
            this.btnBuscarCliente.TabIndex = 72;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtFem);
            this.gbxSexo.Controls.Add(this.rbtMasc);
            this.gbxSexo.Location = new System.Drawing.Point(76, 283);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(350, 43);
            this.gbxSexo.TabIndex = 52;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // cboTipId
            // 
            this.cboTipId.Enabled = false;
            this.cboTipId.FormattingEnabled = true;
            this.cboTipId.Location = new System.Drawing.Point(167, 31);
            this.cboTipId.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipId.Name = "cboTipId";
            this.cboTipId.Size = new System.Drawing.Size(259, 24);
            this.cboTipId.TabIndex = 51;
            this.cboTipId.Text = "Seleccione Opción";
            this.cboTipId.SelectedIndexChanged += new System.EventHandler(this.cboTipId_SelectedIndexChanged_1);
            // 
            // cboBarrios
            // 
            this.cboBarrios.Enabled = false;
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(167, 439);
            this.cboBarrios.Margin = new System.Windows.Forms.Padding(4);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(257, 24);
            this.cboBarrios.TabIndex = 77;
            this.cboBarrios.Text = "Seleccione Opcion ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Provincia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Cantón";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 407);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Distrito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 441);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "Otras señas:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.Enabled = false;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(167, 346);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(257, 24);
            this.cboProvincia.TabIndex = 74;
            this.cboProvincia.Text = "Seleccione Opcion ";
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboCanton
            // 
            this.cboCanton.Enabled = false;
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(167, 378);
            this.cboCanton.Margin = new System.Windows.Forms.Padding(4);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(257, 24);
            this.cboCanton.TabIndex = 75;
            this.cboCanton.Text = "Seleccione Opcion ";
            this.cboCanton.SelectedIndexChanged += new System.EventHandler(this.cboCanton_SelectedIndexChanged);
            // 
            // cboDistrito
            // 
            this.cboDistrito.Enabled = false;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(167, 407);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(257, 24);
            this.cboDistrito.TabIndex = 76;
            this.cboDistrito.Text = "Seleccione Opcion ";
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_SelectedIndexChanged);
            // 
            // txtOtrasSenas
            // 
            this.txtOtrasSenas.Enabled = false;
            this.txtOtrasSenas.Location = new System.Drawing.Point(167, 471);
            this.txtOtrasSenas.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtrasSenas.MaxLength = 160;
            this.txtOtrasSenas.Multiline = true;
            this.txtOtrasSenas.Name = "txtOtrasSenas";
            this.txtOtrasSenas.Size = new System.Drawing.Size(667, 54);
            this.txtOtrasSenas.TabIndex = 78;
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.Location = new System.Drawing.Point(33, 439);
            this.lblobservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(50, 17);
            this.lblobservaciones.TabIndex = 73;
            this.lblobservaciones.Text = "Barrio:";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 736);
            this.Controls.Add(this.gbxUsuario);
            this.Controls.Add(this.tlsMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxNombreUser.ResumeLayout(false);
            this.gbxNombreUser.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskId;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblTipId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cboIdRol;
        private System.Windows.Forms.ListView lstvRequerimientos;
        private System.Windows.Forms.ColumnHeader colPermiso;
        private System.Windows.Forms.ColumnHeader colIdReq;
        private System.Windows.Forms.Label lblApel1;
        private System.Windows.Forms.Label lblApel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.DateTimePicker dtpFechNac;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mskTelef;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.Label lblNomUsu;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.TextBox txtConfirmContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblConfirmContra;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.GroupBox gbxNombreUser;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripButton tlsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsBtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsBtnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlsBtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlsBtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tlsBtnSalir;
        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.ColumnHeader colNombreReq;
        private System.Windows.Forms.ComboBox cboTipId;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.TextBox txtOtrasSenas;
        private System.Windows.Forms.Label lblobservaciones;
    }
}