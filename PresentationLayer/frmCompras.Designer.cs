namespace PresentationLayer
{
    partial class frmCompras
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
            this.lstvDocs = new System.Windows.Forms.ListView();
            this.colLinea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalBruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coltotalNeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxExoneracion = new System.Windows.Forms.GroupBox();
            this.txtDocExo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpFechaEmisionExo = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.txtInstitucionExo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cboExoneracion = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.chkAplicaExo = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskCodigoActividad = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentificacion = new System.Windows.Forms.MaskedTextBox();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtOtrasSenas = new System.Windows.Forms.TextBox();
            this.lblobservaciones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskidentificacion = new System.Windows.Forms.MaskedTextBox();
            this.lblidentificacion = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.cbotipoId = new System.Windows.Forms.ComboBox();
            this.lbltipoId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.mskPlazoCredito = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.cboTipoVenta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.cboMedida = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.mskCantidadProd = new System.Windows.Forms.MaskedTextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.cboImpuesto = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.gbxMontos = new System.Windows.Forms.GroupBox();
            this.txtExoneracion = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbxExoneracion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxMontos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvDocs
            // 
            this.lstvDocs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLinea,
            this.colCodigoProducto,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colMedida,
            this.colTotalBruto,
            this.colDes,
            this.colImp,
            this.colExo,
            this.coltotalNeto});
            this.lstvDocs.FullRowSelect = true;
            this.lstvDocs.GridLines = true;
            this.lstvDocs.HoverSelection = true;
            this.lstvDocs.Location = new System.Drawing.Point(31, 599);
            this.lstvDocs.Margin = new System.Windows.Forms.Padding(4);
            this.lstvDocs.Name = "lstvDocs";
            this.lstvDocs.Size = new System.Drawing.Size(1406, 187);
            this.lstvDocs.TabIndex = 81;
            this.lstvDocs.UseCompatibleStateImageBehavior = false;
            this.lstvDocs.View = System.Windows.Forms.View.Details;
            this.lstvDocs.SelectedIndexChanged += new System.EventHandler(this.lsvFacturas_SelectedIndexChanged);
            // 
            // colLinea
            // 
            this.colLinea.Text = "#Linea";
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.Text = "Código";
            // 
            // colProducto
            // 
            this.colProducto.Text = "Producto";
            this.colProducto.Width = 199;
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            this.colCantidad.Width = 86;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "Precio";
            this.colPrecio.Width = 91;
            // 
            // colMedida
            // 
            this.colMedida.Text = "Medida";
            // 
            // colTotalBruto
            // 
            this.colTotalBruto.Text = "Subtotal";
            this.colTotalBruto.Width = 97;
            // 
            // colDes
            // 
            this.colDes.Text = "Descuento";
            this.colDes.Width = 84;
            // 
            // colImp
            // 
            this.colImp.Text = "Impuesto";
            this.colImp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colImp.Width = 87;
            // 
            // colExo
            // 
            this.colExo.Text = "Exoneración";
            this.colExo.Width = 101;
            // 
            // coltotalNeto
            // 
            this.coltotalNeto.Text = "Total Línea";
            this.coltotalNeto.Width = 124;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbxExoneracion);
            this.groupBox2.Controls.Add(this.chkAplicaExo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.mskCodigoActividad);
            this.groupBox2.Controls.Add(this.txtIdentificacion);
            this.groupBox2.Controls.Add(this.cboBarrios);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboProvincia);
            this.groupBox2.Controls.Add(this.cboCanton);
            this.groupBox2.Controls.Add(this.cboDistrito);
            this.groupBox2.Controls.Add(this.txtOtrasSenas);
            this.groupBox2.Controls.Add(this.lblobservaciones);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mskidentificacion);
            this.groupBox2.Controls.Add(this.lblidentificacion);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.cbotipoId);
            this.groupBox2.Controls.Add(this.lbltipoId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(31, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(984, 374);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emisor";
            // 
            // gbxExoneracion
            // 
            this.gbxExoneracion.Controls.Add(this.txtDocExo);
            this.gbxExoneracion.Controls.Add(this.label23);
            this.gbxExoneracion.Controls.Add(this.dtpFechaEmisionExo);
            this.gbxExoneracion.Controls.Add(this.label24);
            this.gbxExoneracion.Controls.Add(this.txtInstitucionExo);
            this.gbxExoneracion.Controls.Add(this.label25);
            this.gbxExoneracion.Controls.Add(this.cboExoneracion);
            this.gbxExoneracion.Controls.Add(this.label26);
            this.gbxExoneracion.Location = new System.Drawing.Point(142, 235);
            this.gbxExoneracion.Name = "gbxExoneracion";
            this.gbxExoneracion.Size = new System.Drawing.Size(814, 114);
            this.gbxExoneracion.TabIndex = 95;
            this.gbxExoneracion.TabStop = false;
            // 
            // txtDocExo
            // 
            this.txtDocExo.Location = new System.Drawing.Point(598, 22);
            this.txtDocExo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocExo.MaxLength = 21;
            this.txtDocExo.Name = "txtDocExo";
            this.txtDocExo.Size = new System.Drawing.Size(199, 22);
            this.txtDocExo.TabIndex = 73;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(436, 22);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(166, 17);
            this.label23.TabIndex = 81;
            this.label23.Text = "Documento Exoneración:";
            // 
            // dtpFechaEmisionExo
            // 
            this.dtpFechaEmisionExo.CustomFormat = "dd/MM/yyyy HH:mm:ss ";
            this.dtpFechaEmisionExo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmisionExo.Location = new System.Drawing.Point(208, 79);
            this.dtpFechaEmisionExo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmisionExo.Name = "dtpFechaEmisionExo";
            this.dtpFechaEmisionExo.Size = new System.Drawing.Size(218, 22);
            this.dtpFechaEmisionExo.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 79);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(186, 17);
            this.label24.TabIndex = 80;
            this.label24.Text = "Fecha Emisión Exoneración:";
            // 
            // txtInstitucionExo
            // 
            this.txtInstitucionExo.Location = new System.Drawing.Point(207, 50);
            this.txtInstitucionExo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstitucionExo.MaxLength = 160;
            this.txtInstitucionExo.Name = "txtInstitucionExo";
            this.txtInstitucionExo.Size = new System.Drawing.Size(590, 22);
            this.txtInstitucionExo.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 50);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(185, 17);
            this.label25.TabIndex = 77;
            this.label25.Text = "Nombre Institución Exoneró:";
            // 
            // cboExoneracion
            // 
            this.cboExoneracion.FormattingEnabled = true;
            this.cboExoneracion.Location = new System.Drawing.Point(207, 18);
            this.cboExoneracion.Margin = new System.Windows.Forms.Padding(4);
            this.cboExoneracion.Name = "cboExoneracion";
            this.cboExoneracion.Size = new System.Drawing.Size(219, 24);
            this.cboExoneracion.TabIndex = 20;
            this.cboExoneracion.Text = "Seleccione Opcion ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(71, 21);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(122, 17);
            this.label26.TabIndex = 76;
            this.label26.Text = "Tipo Exoneración:";
            // 
            // chkAplicaExo
            // 
            this.chkAplicaExo.AutoSize = true;
            this.chkAplicaExo.Location = new System.Drawing.Point(144, 217);
            this.chkAplicaExo.Name = "chkAplicaExo";
            this.chkAplicaExo.Size = new System.Drawing.Size(150, 21);
            this.chkAplicaExo.TabIndex = 19;
            this.chkAplicaExo.Text = "Aplica Exoneración";
            this.chkAplicaExo.UseVisualStyleBackColor = true;
            this.chkAplicaExo.CheckedChanged += new System.EventHandler(this.chkAplicaExo_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 17);
            this.label15.TabIndex = 93;
            this.label15.Text = "Código Actividad:";
            // 
            // mskCodigoActividad
            // 
            this.mskCodigoActividad.Location = new System.Drawing.Point(645, 47);
            this.mskCodigoActividad.Mask = "######";
            this.mskCodigoActividad.Name = "mskCodigoActividad";
            this.mskCodigoActividad.Size = new System.Drawing.Size(94, 22);
            this.mskCodigoActividad.TabIndex = 12;
            this.mskCodigoActividad.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Enabled = false;
            this.txtIdentificacion.Location = new System.Drawing.Point(645, 15);
            this.txtIdentificacion.Mask = "##########";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(205, 22);
            this.txtIdentificacion.TabIndex = 9;
            this.txtIdentificacion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cboBarrios
            // 
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(645, 118);
            this.cboBarrios.Margin = new System.Windows.Forms.Padding(4);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(293, 24);
            this.cboBarrios.TabIndex = 17;
            this.cboBarrios.Text = "Seleccione Opcion ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Provincia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 89;
            this.label11.Text = "Cantón";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(581, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 88;
            this.label12.Text = "Distrito:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 87;
            this.label13.Text = "Otras señas:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(145, 96);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(257, 24);
            this.cboProvincia.TabIndex = 14;
            this.cboProvincia.Text = "Seleccione Opcion ";
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboCanton
            // 
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(145, 124);
            this.cboCanton.Margin = new System.Windows.Forms.Padding(4);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(257, 24);
            this.cboCanton.TabIndex = 15;
            this.cboCanton.Text = "Seleccione Opcion ";
            this.cboCanton.SelectedIndexChanged += new System.EventHandler(this.cboCanton_SelectedIndexChanged);
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(645, 89);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(293, 24);
            this.cboDistrito.TabIndex = 16;
            this.cboDistrito.Text = "Seleccione Opcion ";
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_SelectedIndexChanged);
            // 
            // txtOtrasSenas
            // 
            this.txtOtrasSenas.Location = new System.Drawing.Point(144, 156);
            this.txtOtrasSenas.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtrasSenas.MaxLength = 160;
            this.txtOtrasSenas.Multiline = true;
            this.txtOtrasSenas.Name = "txtOtrasSenas";
            this.txtOtrasSenas.Size = new System.Drawing.Size(793, 54);
            this.txtOtrasSenas.TabIndex = 18;
            // 
            // lblobservaciones
            // 
            this.lblobservaciones.AutoSize = true;
            this.lblobservaciones.Location = new System.Drawing.Point(587, 121);
            this.lblobservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblobservaciones.Name = "lblobservaciones";
            this.lblobservaciones.Size = new System.Drawing.Size(50, 17);
            this.lblobservaciones.TabIndex = 81;
            this.lblobservaciones.Text = "Barrio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Nombre Completo:";
            // 
            // mskidentificacion
            // 
            this.mskidentificacion.Location = new System.Drawing.Point(645, 14);
            this.mskidentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.mskidentificacion.Mask = "#-####-####";
            this.mskidentificacion.Name = "mskidentificacion";
            this.mskidentificacion.Size = new System.Drawing.Size(213, 22);
            this.mskidentificacion.TabIndex = 10;
            this.mskidentificacion.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblidentificacion
            // 
            this.lblidentificacion.AutoSize = true;
            this.lblidentificacion.Location = new System.Drawing.Point(544, 17);
            this.lblidentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidentificacion.Name = "lblidentificacion";
            this.lblidentificacion.Size = new System.Drawing.Size(94, 17);
            this.lblidentificacion.TabIndex = 78;
            this.lblidentificacion.Text = "Identificación:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Enabled = false;
            this.lblid.Location = new System.Drawing.Point(166, 28);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 77;
            // 
            // cbotipoId
            // 
            this.cbotipoId.FormattingEnabled = true;
            this.cbotipoId.Location = new System.Drawing.Point(145, 14);
            this.cbotipoId.Margin = new System.Windows.Forms.Padding(4);
            this.cbotipoId.Name = "cbotipoId";
            this.cbotipoId.Size = new System.Drawing.Size(253, 24);
            this.cbotipoId.TabIndex = 8;
            this.cbotipoId.Text = "Seleccione Opción";
            this.cbotipoId.SelectedIndexChanged += new System.EventHandler(this.cbotipoId_SelectedIndexChanged);
            // 
            // lbltipoId
            // 
            this.lbltipoId.AutoSize = true;
            this.lbltipoId.Location = new System.Drawing.Point(60, 18);
            this.lbltipoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipoId.Name = "lbltipoId";
            this.lbltipoId.Size = new System.Drawing.Size(77, 17);
            this.lbltipoId.TabIndex = 75;
            this.lbltipoId.Text = "Tipo de ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Correo Electrónico:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(145, 70);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(359, 22);
            this.txtCorreo.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaEmision);
            this.groupBox1.Controls.Add(this.mskPlazoCredito);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboTipoPago);
            this.groupBox1.Controls.Add(this.cboTipoVenta);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdFactura);
            this.groupBox1.Location = new System.Drawing.Point(31, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(984, 152);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Factura";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CustomFormat = "dd/MM/yyyy HH:mm:ss ";
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmision.Location = new System.Drawing.Point(645, 24);
            this.dtpFechaEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(218, 22);
            this.dtpFechaEmision.TabIndex = 2;
            // 
            // mskPlazoCredito
            // 
            this.mskPlazoCredito.Location = new System.Drawing.Point(645, 81);
            this.mskPlazoCredito.Mask = "###";
            this.mskPlazoCredito.Name = "mskPlazoCredito";
            this.mskPlazoCredito.Size = new System.Drawing.Size(57, 22);
            this.mskPlazoCredito.TabIndex = 6;
            this.mskPlazoCredito.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(708, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 86;
            this.label14.Text = "días.";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox2.Enabled = false;
            this.maskedTextBox2.Location = new System.Drawing.Point(645, 52);
            this.maskedTextBox2.Mask = "####################";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(294, 22);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 54);
            this.maskedTextBox1.Mask = "##################################################";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(365, 22);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Plazo Crédito:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(144, 112);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(258, 24);
            this.cboTipoPago.TabIndex = 7;
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(144, 82);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(256, 24);
            this.cboTipoVenta.TabIndex = 5;
            this.cboTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cboTipoVenta_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 78;
            this.label10.Text = "Tipo Venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "Tipo Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Fecha Emisión:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Consecutivo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Factura #:";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(144, 26);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(258, 22);
            this.txtIdFactura.TabIndex = 1;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(31, 569);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(120, 22);
            this.txtCodigoProducto.TabIndex = 24;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(159, 569);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(310, 22);
            this.txtNombreProducto.TabIndex = 25;
            // 
            // cboMedida
            // 
            this.cboMedida.FormattingEnabled = true;
            this.cboMedida.Location = new System.Drawing.Point(725, 569);
            this.cboMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cboMedida.Name = "cboMedida";
            this.cboMedida.Size = new System.Drawing.Size(207, 24);
            this.cboMedida.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 548);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 17);
            this.label16.TabIndex = 95;
            this.label16.Text = "Código Producto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 548);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 17);
            this.label17.TabIndex = 96;
            this.label17.Text = "Nombre Producto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(483, 549);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 17);
            this.label18.TabIndex = 97;
            this.label18.Text = "Cant.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(542, 548);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 98;
            this.label19.Text = "Precio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(726, 548);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 99;
            this.label20.Text = "Medida";
            // 
            // mskCantidadProd
            // 
            this.mskCantidadProd.Location = new System.Drawing.Point(479, 569);
            this.mskCantidadProd.Mask = "###";
            this.mskCantidadProd.Name = "mskCantidadProd";
            this.mskCantidadProd.Size = new System.Drawing.Size(54, 22);
            this.mskCantidadProd.TabIndex = 26;
            this.mskCantidadProd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(540, 569);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(177, 22);
            this.txtPrecioProducto.TabIndex = 27;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(940, 569);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(126, 22);
            this.txtDescuento.TabIndex = 29;
            // 
            // cboImpuesto
            // 
            this.cboImpuesto.FormattingEnabled = true;
            this.cboImpuesto.Location = new System.Drawing.Point(1077, 567);
            this.cboImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cboImpuesto.Name = "cboImpuesto";
            this.cboImpuesto.Size = new System.Drawing.Size(137, 24);
            this.cboImpuesto.TabIndex = 30;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(939, 548);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 17);
            this.label21.TabIndex = 104;
            this.label21.Text = "Descuento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1077, 546);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 105;
            this.label22.Text = "Impuesto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(1222, 567);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(70, 25);
            this.btnAgregarProducto.TabIndex = 31;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // gbxMontos
            // 
            this.gbxMontos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxMontos.Controls.Add(this.txtExoneracion);
            this.gbxMontos.Controls.Add(this.label27);
            this.gbxMontos.Controls.Add(this.lblSubtotal);
            this.gbxMontos.Controls.Add(this.txtSubtotal);
            this.gbxMontos.Controls.Add(this.txtTotal);
            this.gbxMontos.Controls.Add(this.lblIva);
            this.gbxMontos.Controls.Add(this.txtDescuentoTotal);
            this.gbxMontos.Controls.Add(this.lblDescuento);
            this.gbxMontos.Controls.Add(this.txtIva);
            this.gbxMontos.Controls.Add(this.lblTotal);
            this.gbxMontos.Location = new System.Drawing.Point(1022, 24);
            this.gbxMontos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Name = "gbxMontos";
            this.gbxMontos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Size = new System.Drawing.Size(380, 294);
            this.gbxMontos.TabIndex = 107;
            this.gbxMontos.TabStop = false;
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExoneracion.Location = new System.Drawing.Point(151, 168);
            this.txtExoneracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.ReadOnly = true;
            this.txtExoneracion.Size = new System.Drawing.Size(221, 41);
            this.txtExoneracion.TabIndex = 66;
            this.txtExoneracion.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(5, 175);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(127, 25);
            this.label27.TabIndex = 65;
            this.label27.Text = "Exoneración:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(39, 31);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 25);
            this.lblSubtotal.TabIndex = 36;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(151, 22);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(221, 41);
            this.txtSubtotal.TabIndex = 35;
            this.txtSubtotal.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(151, 215);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(221, 41);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.Text = "0";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(83, 79);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(51, 25);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "IVA:";
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoTotal.Location = new System.Drawing.Point(151, 121);
            this.txtDescuentoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.ReadOnly = true;
            this.txtDescuentoTotal.Size = new System.Drawing.Size(119, 41);
            this.txtDescuentoTotal.TabIndex = 33;
            this.txtDescuentoTotal.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(21, 129);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(112, 25);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(151, 71);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(221, 41);
            this.txtIva.TabIndex = 0;
            this.txtIva.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(72, 222);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(1032, 355);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(82, 63);
            this.btnProcesar.TabIndex = 108;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 795);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.gbxMontos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cboImpuesto);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.mskCantidadProd);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cboMedida);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.lstvDocs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxExoneracion.ResumeLayout(false);
            this.gbxExoneracion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxMontos.ResumeLayout(false);
            this.gbxMontos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDocs;
        private System.Windows.Forms.ColumnHeader colProducto;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colTotalBruto;
        private System.Windows.Forms.ColumnHeader colDes;
        private System.Windows.Forms.ColumnHeader colImp;
        private System.Windows.Forms.ColumnHeader colExo;
        private System.Windows.Forms.ColumnHeader coltotalNeto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.ComboBox cboTipoVenta;
        private System.Windows.Forms.MaskedTextBox mskidentificacion;
        private System.Windows.Forms.Label lblidentificacion;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ComboBox cbotipoId;
        private System.Windows.Forms.Label lbltipoId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.TextBox txtOtrasSenas;
        private System.Windows.Forms.Label lblobservaciones;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox txtIdentificacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mskCodigoActividad;
        private System.Windows.Forms.ColumnHeader colLinea;
        private System.Windows.Forms.ColumnHeader colCodigoProducto;
        private System.Windows.Forms.ColumnHeader colMedida;
        private System.Windows.Forms.MaskedTextBox mskPlazoCredito;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.ComboBox cboMedida;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mskCantidadProd;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.ComboBox cboImpuesto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox gbxExoneracion;
        private System.Windows.Forms.TextBox txtDocExo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpFechaEmisionExo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtInstitucionExo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cboExoneracion;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chkAplicaExo;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.GroupBox gbxMontos;
        private System.Windows.Forms.TextBox txtExoneracion;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProcesar;
    }
}