namespace PresentationLayer
{
    partial class frmEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.gbxEmpleados = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblCorr = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFecha_Salida = new System.Windows.Forms.Label();
            this.chkContradoFin = new System.Windows.Forms.CheckBox();
            this.dtpFecha_Salida = new System.Windows.Forms.DateTimePicker();
            this.gboSexo = new System.Windows.Forms.GroupBox();
            this.rbtmasc = new System.Windows.Forms.RadioButton();
            this.rbtfem = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.cbxPustTrab = new System.Windows.Forms.ComboBox();
            this.lblPuestTrab = new System.Windows.Forms.Label();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblfecha_Ingreso = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotipoId = new System.Windows.Forms.ComboBox();
            this.lblTipoID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.imgListMenu = new System.Windows.Forms.ImageList(this.components);
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.mskId = new System.Windows.Forms.MaskedTextBox();
            this.gbxEmpleados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboSexo.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEmpleados
            // 
            this.gbxEmpleados.Controls.Add(this.mskId);
            this.gbxEmpleados.Controls.Add(this.dtpFechaNac);
            this.gbxEmpleados.Controls.Add(this.txtApellido1);
            this.gbxEmpleados.Controls.Add(this.txtApellido2);
            this.gbxEmpleados.Controls.Add(this.label5);
            this.gbxEmpleados.Controls.Add(this.txtDireccion);
            this.gbxEmpleados.Controls.Add(this.lblCorr);
            this.gbxEmpleados.Controls.Add(this.txtCorreo);
            this.gbxEmpleados.Controls.Add(this.groupBox1);
            this.gbxEmpleados.Controls.Add(this.gboSexo);
            this.gbxEmpleados.Controls.Add(this.label1);
            this.gbxEmpleados.Controls.Add(this.dtpFecha_Ingreso);
            this.gbxEmpleados.Controls.Add(this.cbxPustTrab);
            this.gbxEmpleados.Controls.Add(this.lblPuestTrab);
            this.gbxEmpleados.Controls.Add(this.lblFechaNaci);
            this.gbxEmpleados.Controls.Add(this.mskTelefono);
            this.gbxEmpleados.Controls.Add(this.lblfecha_Ingreso);
            this.gbxEmpleados.Controls.Add(this.lblApellido1);
            this.gbxEmpleados.Controls.Add(this.label4);
            this.gbxEmpleados.Controls.Add(this.label2);
            this.gbxEmpleados.Controls.Add(this.cbotipoId);
            this.gbxEmpleados.Controls.Add(this.lblTipoID);
            this.gbxEmpleados.Controls.Add(this.label3);
            this.gbxEmpleados.Controls.Add(this.txtNombre);
            this.gbxEmpleados.Controls.Add(this.lblId);
            this.gbxEmpleados.Controls.Add(this.lblNombre);
            this.gbxEmpleados.Location = new System.Drawing.Point(16, 53);
            this.gbxEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEmpleados.Name = "gbxEmpleados";
            this.gbxEmpleados.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEmpleados.Size = new System.Drawing.Size(746, 388);
            this.gbxEmpleados.TabIndex = 1;
            this.gbxEmpleados.TabStop = false;
            this.gbxEmpleados.Text = "Datos  de Empleados";
            this.gbxEmpleados.Enter += new System.EventHandler(this.gbxEmpleados_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(136, 267);
            this.txtDireccion.MaxLength = 500;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(562, 96);
            this.txtDireccion.TabIndex = 48;
            // 
            // lblCorr
            // 
            this.lblCorr.AutoSize = true;
            this.lblCorr.Location = new System.Drawing.Point(358, 98);
            this.lblCorr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(129, 17);
            this.lblCorr.TabIndex = 47;
            this.lblCorr.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(495, 95);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 30;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(204, 22);
            this.txtCorreo.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFecha_Salida);
            this.groupBox1.Controls.Add(this.chkContradoFin);
            this.groupBox1.Controls.Add(this.dtpFecha_Salida);
            this.groupBox1.Location = new System.Drawing.Point(365, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 53);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblFecha_Salida
            // 
            this.lblFecha_Salida.AutoSize = true;
            this.lblFecha_Salida.Location = new System.Drawing.Point(10, 23);
            this.lblFecha_Salida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha_Salida.Name = "lblFecha_Salida";
            this.lblFecha_Salida.Size = new System.Drawing.Size(114, 17);
            this.lblFecha_Salida.TabIndex = 24;
            this.lblFecha_Salida.Text = "Fecha de Salida:";
            // 
            // chkContradoFin
            // 
            this.chkContradoFin.AutoSize = true;
            this.chkContradoFin.Location = new System.Drawing.Point(0, 0);
            this.chkContradoFin.Name = "chkContradoFin";
            this.chkContradoFin.Size = new System.Drawing.Size(149, 21);
            this.chkContradoFin.TabIndex = 43;
            this.chkContradoFin.Text = "Contrato indefinido";
            this.chkContradoFin.UseVisualStyleBackColor = true;
            this.chkContradoFin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtpFecha_Salida
            // 
            this.dtpFecha_Salida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Salida.Location = new System.Drawing.Point(132, 22);
            this.dtpFecha_Salida.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_Salida.Name = "dtpFecha_Salida";
            this.dtpFecha_Salida.Size = new System.Drawing.Size(180, 22);
            this.dtpFecha_Salida.TabIndex = 11;
            // 
            // gboSexo
            // 
            this.gboSexo.Controls.Add(this.rbtmasc);
            this.gboSexo.Controls.Add(this.rbtfem);
            this.gboSexo.Location = new System.Drawing.Point(501, 10);
            this.gboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.gboSexo.Name = "gboSexo";
            this.gboSexo.Padding = new System.Windows.Forms.Padding(4);
            this.gboSexo.Size = new System.Drawing.Size(206, 37);
            this.gboSexo.TabIndex = 41;
            this.gboSexo.TabStop = false;
            // 
            // rbtmasc
            // 
            this.rbtmasc.AutoSize = true;
            this.rbtmasc.Checked = true;
            this.rbtmasc.Location = new System.Drawing.Point(8, 9);
            this.rbtmasc.Margin = new System.Windows.Forms.Padding(4);
            this.rbtmasc.Name = "rbtmasc";
            this.rbtmasc.Size = new System.Drawing.Size(92, 21);
            this.rbtmasc.TabIndex = 0;
            this.rbtmasc.TabStop = true;
            this.rbtmasc.Text = "Masculino";
            this.rbtmasc.UseVisualStyleBackColor = true;
            // 
            // rbtfem
            // 
            this.rbtfem.AutoSize = true;
            this.rbtfem.Location = new System.Drawing.Point(108, 9);
            this.rbtfem.Margin = new System.Windows.Forms.Padding(4);
            this.rbtfem.Name = "rbtfem";
            this.rbtfem.Size = new System.Drawing.Size(91, 21);
            this.rbtfem.TabIndex = 1;
            this.rbtfem.TabStop = true;
            this.rbtfem.Text = "Femenino";
            this.rbtfem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sexo:";
            // 
            // dtpFecha_Ingreso
            // 
            this.dtpFecha_Ingreso.Location = new System.Drawing.Point(495, 161);
            this.dtpFecha_Ingreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha_Ingreso.Name = "dtpFecha_Ingreso";
            this.dtpFecha_Ingreso.Size = new System.Drawing.Size(203, 22);
            this.dtpFecha_Ingreso.TabIndex = 10;
            // 
            // cbxPustTrab
            // 
            this.cbxPustTrab.FormattingEnabled = true;
            this.cbxPustTrab.ItemHeight = 16;
            this.cbxPustTrab.Location = new System.Drawing.Point(495, 126);
            this.cbxPustTrab.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPustTrab.MaxLength = 30;
            this.cbxPustTrab.Name = "cbxPustTrab";
            this.cbxPustTrab.Size = new System.Drawing.Size(203, 24);
            this.cbxPustTrab.TabIndex = 9;
            this.cbxPustTrab.SelectedIndexChanged += new System.EventHandler(this.cbxPustTrab_SelectedIndexChanged);
            // 
            // lblPuestTrab
            // 
            this.lblPuestTrab.AutoSize = true;
            this.lblPuestTrab.Location = new System.Drawing.Point(363, 130);
            this.lblPuestTrab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuestTrab.Name = "lblPuestTrab";
            this.lblPuestTrab.Size = new System.Drawing.Size(124, 17);
            this.lblPuestTrab.TabIndex = 27;
            this.lblPuestTrab.Text = "Puesto de trabajo:";
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Location = new System.Drawing.Point(3, 197);
            this.lblFechaNaci.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(125, 17);
            this.lblFechaNaci.TabIndex = 22;
            this.lblFechaNaci.Text = "Fecha Nacimiento:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskTelefono.Location = new System.Drawing.Point(496, 59);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefono.Mask = "0000-00-00";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(203, 22);
            this.mskTelefono.TabIndex = 8;
            this.mskTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblfecha_Ingreso
            // 
            this.lblfecha_Ingreso.AutoSize = true;
            this.lblfecha_Ingreso.Location = new System.Drawing.Point(365, 165);
            this.lblfecha_Ingreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha_Ingreso.Name = "lblfecha_Ingreso";
            this.lblfecha_Ingreso.Size = new System.Drawing.Size(122, 17);
            this.lblfecha_Ingreso.TabIndex = 19;
            this.lblfecha_Ingreso.Text = "Fecha de Ingreso:";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(21, 129);
            this.lblApellido1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(107, 17);
            this.lblApellido1.TabIndex = 15;
            this.lblApellido1.Text = "Primer Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Segundo Apellido:";
            // 
            // cbotipoId
            // 
            this.cbotipoId.FormattingEnabled = true;
            this.cbotipoId.Location = new System.Drawing.Point(139, 22);
            this.cbotipoId.Margin = new System.Windows.Forms.Padding(4);
            this.cbotipoId.MaxLength = 30;
            this.cbotipoId.Name = "cbotipoId";
            this.cbotipoId.Size = new System.Drawing.Size(203, 24);
            this.cbotipoId.TabIndex = 2;
            this.cbotipoId.SelectedIndexChanged += new System.EventHandler(this.cboTipoId_SelectedIndexChanged);
            // 
            // lblTipoID
            // 
            this.lblTipoID.AutoSize = true;
            this.lblTipoID.Location = new System.Drawing.Point(8, 26);
            this.lblTipoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoID.Name = "lblTipoID";
            this.lblTipoID.Size = new System.Drawing.Size(126, 17);
            this.lblTipoID.TabIndex = 7;
            this.lblTipoID.Text = "Tipo Identificacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 95);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(34, 59);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(94, 17);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Identificación:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 95);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // imgListMenu
            // 
            this.imgListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListMenu.ImageStream")));
            this.imgListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListMenu.Images.SetKeyName(0, "guardar.png");
            this.imgListMenu.Images.SetKeyName(1, "nuevo.png");
            this.imgListMenu.Images.SetKeyName(2, "modificar.png");
            this.imgListMenu.Images.SetKeyName(3, "eliminar.png");
            this.imgListMenu.Images.SetKeyName(4, "buscar.png");
            this.imgListMenu.Images.SetKeyName(5, "cancelar.png");
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
            this.tlsMenu.Size = new System.Drawing.Size(775, 39);
            this.tlsMenu.TabIndex = 12;
            this.tlsMenu.Text = "toolStrip1";
            this.tlsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsMenu_ItemClicked_1);
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
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(137, 163);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido2.MaxLength = 30;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(205, 22);
            this.txtApellido2.TabIndex = 50;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(136, 128);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido1.MaxLength = 30;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(205, 22);
            this.txtApellido1.TabIndex = 51;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(136, 197);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(203, 22);
            this.dtpFechaNac.TabIndex = 52;
            // 
            // mskId
            // 
            this.mskId.Location = new System.Drawing.Point(139, 59);
            this.mskId.Margin = new System.Windows.Forms.Padding(4);
            this.mskId.Mask = "#-####-####";
            this.mskId.Name = "mskId";
            this.mskId.Size = new System.Drawing.Size(203, 22);
            this.mskId.TabIndex = 53;
            this.mskId.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 454);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.gbxEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento: Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.gbxEmpleados.ResumeLayout(false);
            this.gbxEmpleados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboSexo.ResumeLayout(false);
            this.gboSexo.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxEmpleados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cbotipoId;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblfecha_Ingreso;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblFecha_Salida;
        private System.Windows.Forms.Label lblPuestTrab;
        private System.Windows.Forms.ComboBox cbxPustTrab;
        private System.Windows.Forms.DateTimePicker dtpFecha_Salida;
        private System.Windows.Forms.DateTimePicker dtpFecha_Ingreso;
        private System.Windows.Forms.ImageList imgListMenu;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gboSexo;
        private System.Windows.Forms.RadioButton rbtmasc;
        private System.Windows.Forms.RadioButton rbtfem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkContradoFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.MaskedTextBox mskId;
    }
}