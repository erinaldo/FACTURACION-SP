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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.lstvDocs = new System.Windows.Forms.ListView();
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
            this.gbxCompra = new System.Windows.Forms.GroupBox();
            this.chkIncluyeInventario = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.chkRegimenSimplificado = new System.Windows.Forms.CheckBox();
            this.btnBuscarReporteHacienda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstadoFactura = new System.Windows.Forms.ComboBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.mskPlazoCredito = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mskConsecutivo = new System.Windows.Forms.MaskedTextBox();
            this.mskClave = new System.Windows.Forms.MaskedTextBox();
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
            this.gbxDetalleCompra = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxCompra.SuspendLayout();
            this.gbxMontos.SuspendLayout();
            this.gbxDetalleCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvDocs
            // 
            this.lstvDocs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.lstvDocs.Location = new System.Drawing.Point(7, 136);
            this.lstvDocs.Margin = new System.Windows.Forms.Padding(4);
            this.lstvDocs.Name = "lstvDocs";
            this.lstvDocs.Size = new System.Drawing.Size(1336, 219);
            this.lstvDocs.TabIndex = 81;
            this.lstvDocs.UseCompatibleStateImageBehavior = false;
            this.lstvDocs.View = System.Windows.Forms.View.Details;
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
            // gbxCompra
            // 
            this.gbxCompra.Controls.Add(this.chkIncluyeInventario);
            this.gbxCompra.Controls.Add(this.label5);
            this.gbxCompra.Controls.Add(this.txtObservaciones);
            this.gbxCompra.Controls.Add(this.chkRegimenSimplificado);
            this.gbxCompra.Controls.Add(this.btnBuscarReporteHacienda);
            this.gbxCompra.Controls.Add(this.label7);
            this.gbxCompra.Controls.Add(this.btnBuscarProveedor);
            this.gbxCompra.Controls.Add(this.txtProveedor);
            this.gbxCompra.Controls.Add(this.label6);
            this.gbxCompra.Controls.Add(this.cboEstadoFactura);
            this.gbxCompra.Controls.Add(this.dtpFechaCompra);
            this.gbxCompra.Controls.Add(this.mskPlazoCredito);
            this.gbxCompra.Controls.Add(this.label14);
            this.gbxCompra.Controls.Add(this.mskConsecutivo);
            this.gbxCompra.Controls.Add(this.mskClave);
            this.gbxCompra.Controls.Add(this.label8);
            this.gbxCompra.Controls.Add(this.cboTipoPago);
            this.gbxCompra.Controls.Add(this.cboTipoVenta);
            this.gbxCompra.Controls.Add(this.label10);
            this.gbxCompra.Controls.Add(this.label9);
            this.gbxCompra.Controls.Add(this.label4);
            this.gbxCompra.Controls.Add(this.label3);
            this.gbxCompra.Controls.Add(this.label2);
            this.gbxCompra.Controls.Add(this.label1);
            this.gbxCompra.Controls.Add(this.txtIdFactura);
            this.gbxCompra.Location = new System.Drawing.Point(31, 14);
            this.gbxCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCompra.Name = "gbxCompra";
            this.gbxCompra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCompra.Size = new System.Drawing.Size(1045, 238);
            this.gbxCompra.TabIndex = 82;
            this.gbxCompra.TabStop = false;
            this.gbxCompra.Text = "Datos de Factura";
            this.gbxCompra.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkIncluyeInventario
            // 
            this.chkIncluyeInventario.AutoSize = true;
            this.chkIncluyeInventario.Location = new System.Drawing.Point(363, 191);
            this.chkIncluyeInventario.Name = "chkIncluyeInventario";
            this.chkIncluyeInventario.Size = new System.Drawing.Size(145, 21);
            this.chkIncluyeInventario.TabIndex = 115;
            this.chkIncluyeInventario.Text = "Incluir a Inventario";
            this.chkIncluyeInventario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(599, 163);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(439, 69);
            this.txtObservaciones.TabIndex = 113;
            // 
            // chkRegimenSimplificado
            // 
            this.chkRegimenSimplificado.AutoSize = true;
            this.chkRegimenSimplificado.Location = new System.Drawing.Point(143, 191);
            this.chkRegimenSimplificado.Name = "chkRegimenSimplificado";
            this.chkRegimenSimplificado.Size = new System.Drawing.Size(165, 21);
            this.chkRegimenSimplificado.TabIndex = 112;
            this.chkRegimenSimplificado.Text = "Régimen Simplificado";
            this.chkRegimenSimplificado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReporteHacienda
            // 
            this.btnBuscarReporteHacienda.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarReporteHacienda.Image")));
            this.btnBuscarReporteHacienda.Location = new System.Drawing.Point(441, 15);
            this.btnBuscarReporteHacienda.Name = "btnBuscarReporteHacienda";
            this.btnBuscarReporteHacienda.Size = new System.Drawing.Size(50, 40);
            this.btnBuscarReporteHacienda.TabIndex = 111;
            this.btnBuscarReporteHacienda.UseVisualStyleBackColor = true;
            this.btnBuscarReporteHacienda.Click += new System.EventHandler(this.btnBuscarReporteHacienda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 110;
            this.label7.Text = "Proveedor:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProveedor.Image")));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(441, 56);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(50, 40);
            this.btnBuscarProveedor.TabIndex = 109;
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(143, 62);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(291, 22);
            this.txtProveedor.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Estado Factura:";
            // 
            // cboEstadoFactura
            // 
            this.cboEstadoFactura.FormattingEnabled = true;
            this.cboEstadoFactura.Location = new System.Drawing.Point(143, 154);
            this.cboEstadoFactura.Name = "cboEstadoFactura";
            this.cboEstadoFactura.Size = new System.Drawing.Size(258, 24);
            this.cboEstadoFactura.TabIndex = 89;
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "dd/MM/yyyy HH:mm:ss ";
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompra.Location = new System.Drawing.Point(599, 129);
            this.dtpFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(218, 22);
            this.dtpFechaCompra.TabIndex = 2;
            // 
            // mskPlazoCredito
            // 
            this.mskPlazoCredito.Location = new System.Drawing.Point(599, 96);
            this.mskPlazoCredito.Mask = "###";
            this.mskPlazoCredito.Name = "mskPlazoCredito";
            this.mskPlazoCredito.Size = new System.Drawing.Size(57, 22);
            this.mskPlazoCredito.TabIndex = 6;
            this.mskPlazoCredito.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(662, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 86;
            this.label14.Text = "días.";
            // 
            // mskConsecutivo
            // 
            this.mskConsecutivo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskConsecutivo.Enabled = false;
            this.mskConsecutivo.Location = new System.Drawing.Point(599, 63);
            this.mskConsecutivo.Mask = "####################";
            this.mskConsecutivo.Name = "mskConsecutivo";
            this.mskConsecutivo.Size = new System.Drawing.Size(294, 22);
            this.mskConsecutivo.TabIndex = 4;
            // 
            // mskClave
            // 
            this.mskClave.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskClave.Enabled = false;
            this.mskClave.Location = new System.Drawing.Point(599, 28);
            this.mskClave.Mask = "##################################################";
            this.mskClave.Name = "mskClave";
            this.mskClave.Size = new System.Drawing.Size(365, 22);
            this.mskClave.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Plazo Crédito:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(143, 123);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(258, 24);
            this.cboTipoPago.TabIndex = 7;
            // 
            // cboTipoVenta
            // 
            this.cboTipoVenta.FormattingEnabled = true;
            this.cboTipoVenta.Location = new System.Drawing.Point(143, 93);
            this.cboTipoVenta.Name = "cboTipoVenta";
            this.cboTipoVenta.Size = new System.Drawing.Size(256, 24);
            this.cboTipoVenta.TabIndex = 5;
            this.cboTipoVenta.SelectedIndexChanged += new System.EventHandler(this.cboTipoVenta_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 78;
            this.label10.Text = "Tipo Venta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "Tipo Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Fecha Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Consecutivo:";
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
            this.txtIdFactura.Size = new System.Drawing.Size(290, 22);
            this.txtIdFactura.TabIndex = 1;
            this.txtIdFactura.TextChanged += new System.EventHandler(this.txtIdFactura_TextChanged);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(140, 22);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProducto.MaxLength = 50;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(383, 22);
            this.txtCodigoProducto.TabIndex = 24;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(19, 93);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(291, 22);
            this.txtNombreProducto.TabIndex = 26;
            // 
            // cboMedida
            // 
            this.cboMedida.FormattingEnabled = true;
            this.cboMedida.Location = new System.Drawing.Point(316, 92);
            this.cboMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cboMedida.Name = "cboMedida";
            this.cboMedida.Size = new System.Drawing.Size(207, 24);
            this.cboMedida.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 17);
            this.label16.TabIndex = 95;
            this.label16.Text = "Código Producto:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(107, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 17);
            this.label17.TabIndex = 96;
            this.label17.Text = "Nombre Producto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(717, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 17);
            this.label18.TabIndex = 97;
            this.label18.Text = "Cant.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(596, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 98;
            this.label19.Text = "Precio";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(391, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 99;
            this.label20.Text = "Medida";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(531, 93);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(177, 22);
            this.txtPrecioProducto.TabIndex = 28;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(776, 94);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(126, 22);
            this.txtDescuento.TabIndex = 30;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // cboImpuesto
            // 
            this.cboImpuesto.FormattingEnabled = true;
            this.cboImpuesto.Location = new System.Drawing.Point(913, 92);
            this.cboImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cboImpuesto.Name = "cboImpuesto";
            this.cboImpuesto.Size = new System.Drawing.Size(137, 24);
            this.cboImpuesto.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(800, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 17);
            this.label21.TabIndex = 104;
            this.label21.Text = "Descuento";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(948, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 105;
            this.label22.Text = "Impuesto";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.Location = new System.Drawing.Point(1057, 74);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(58, 55);
            this.btnAgregarProducto.TabIndex = 32;
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
            this.gbxMontos.Location = new System.Drawing.Point(1083, 23);
            this.gbxMontos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Name = "gbxMontos";
            this.gbxMontos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Size = new System.Drawing.Size(319, 235);
            this.gbxMontos.TabIndex = 107;
            this.gbxMontos.TabStop = false;
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExoneracion.Location = new System.Drawing.Point(140, 136);
            this.txtExoneracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.ReadOnly = true;
            this.txtExoneracion.Size = new System.Drawing.Size(169, 41);
            this.txtExoneracion.TabIndex = 66;
            this.txtExoneracion.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(5, 143);
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
            this.lblSubtotal.Location = new System.Drawing.Point(42, 13);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 25);
            this.lblSubtotal.TabIndex = 36;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(140, 5);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(169, 41);
            this.txtSubtotal.TabIndex = 35;
            this.txtSubtotal.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(140, 182);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(169, 41);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.Text = "0";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(81, 54);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(51, 25);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "IVA:";
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoTotal.Location = new System.Drawing.Point(140, 92);
            this.txtDescuentoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.ReadOnly = true;
            this.txtDescuentoTotal.Size = new System.Drawing.Size(169, 41);
            this.txtDescuentoTotal.TabIndex = 33;
            this.txtDescuentoTotal.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(20, 101);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(112, 25);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(140, 48);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(169, 41);
            this.txtIva.TabIndex = 0;
            this.txtIva.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(64, 184);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // gbxDetalleCompra
            // 
            this.gbxDetalleCompra.Controls.Add(this.btnEliminar);
            this.gbxDetalleCompra.Controls.Add(this.txtCantidad);
            this.gbxDetalleCompra.Controls.Add(this.btnBuscarProducto);
            this.gbxDetalleCompra.Controls.Add(this.btnAgregarProducto);
            this.gbxDetalleCompra.Controls.Add(this.label22);
            this.gbxDetalleCompra.Controls.Add(this.label21);
            this.gbxDetalleCompra.Controls.Add(this.cboImpuesto);
            this.gbxDetalleCompra.Controls.Add(this.txtDescuento);
            this.gbxDetalleCompra.Controls.Add(this.txtPrecioProducto);
            this.gbxDetalleCompra.Controls.Add(this.label20);
            this.gbxDetalleCompra.Controls.Add(this.label19);
            this.gbxDetalleCompra.Controls.Add(this.label18);
            this.gbxDetalleCompra.Controls.Add(this.label17);
            this.gbxDetalleCompra.Controls.Add(this.label16);
            this.gbxDetalleCompra.Controls.Add(this.cboMedida);
            this.gbxDetalleCompra.Controls.Add(this.txtNombreProducto);
            this.gbxDetalleCompra.Controls.Add(this.txtCodigoProducto);
            this.gbxDetalleCompra.Controls.Add(this.lstvDocs);
            this.gbxDetalleCompra.Location = new System.Drawing.Point(31, 257);
            this.gbxDetalleCompra.Name = "gbxDetalleCompra";
            this.gbxDetalleCompra.Size = new System.Drawing.Size(1371, 362);
            this.gbxDetalleCompra.TabIndex = 111;
            this.gbxDetalleCompra.TabStop = false;
            this.gbxDetalleCompra.Text = "Detalle Compra";
            this.gbxDetalleCompra.Enter += new System.EventHandler(this.gbxDetalleCompra_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(1121, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(58, 55);
            this.btnEliminar.TabIndex = 33;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(716, 94);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 22);
            this.txtCantidad.TabIndex = 29;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(531, 14);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(50, 40);
            this.btnBuscarProducto.TabIndex = 25;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarForm.Image")));
            this.btnLimpiarForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarForm.Location = new System.Drawing.Point(1191, 625);
            this.btnLimpiarForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(99, 75);
            this.btnLimpiarForm.TabIndex = 35;
            this.btnLimpiarForm.Text = "Limpiar";
            this.btnLimpiarForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1297, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 75);
            this.button1.TabIndex = 34;
            this.button1.Text = "Procesar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.gbxDetalleCompra);
            this.Controls.Add(this.gbxMontos);
            this.Controls.Add(this.gbxCompra);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.gbxCompra.ResumeLayout(false);
            this.gbxCompra.PerformLayout();
            this.gbxMontos.ResumeLayout(false);
            this.gbxMontos.PerformLayout();
            this.gbxDetalleCompra.ResumeLayout(false);
            this.gbxDetalleCompra.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox gbxCompra;
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
        private System.Windows.Forms.MaskedTextBox mskConsecutivo;
        private System.Windows.Forms.MaskedTextBox mskClave;
        private System.Windows.Forms.Label label14;
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
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.ComboBox cboImpuesto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
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
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstadoFactura;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.GroupBox gbxDetalleCompra;
        private System.Windows.Forms.Button btnBuscarReporteHacienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkRegimenSimplificado;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.CheckBox chkIncluyeInventario;
    }
}