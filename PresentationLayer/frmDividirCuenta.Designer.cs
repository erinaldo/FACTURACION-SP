namespace PresentationLayer
{
    partial class frmDividirCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDividirCuenta));
            this.lstvListaParcial = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvTotal = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxMontos = new System.Windows.Forms.GroupBox();
            this.txtExoneracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPorcetaje = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEnviar = new System.Windows.Forms.CheckBox();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxMontos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvListaParcial
            // 
            this.lstvListaParcial.CheckBoxes = true;
            this.lstvListaParcial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.Cant,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstvListaParcial.FullRowSelect = true;
            this.lstvListaParcial.GridLines = true;
            this.lstvListaParcial.Location = new System.Drawing.Point(22, 402);
            this.lstvListaParcial.Name = "lstvListaParcial";
            this.lstvListaParcial.Size = new System.Drawing.Size(1210, 243);
            this.lstvListaParcial.TabIndex = 1;
            this.lstvListaParcial.UseCompatibleStateImageBehavior = false;
            this.lstvListaParcial.View = System.Windows.Forms.View.Details;
            this.lstvListaParcial.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvListaParcial_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto";
            this.columnHeader3.Width = 200;
            // 
            // Cant
            // 
            this.Cant.Text = "Cant.";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 100;
            // 
            // lstvTotal
            // 
            this.lstvTotal.CheckBoxes = true;
            this.lstvTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstvTotal.FullRowSelect = true;
            this.lstvTotal.GridLines = true;
            this.lstvTotal.Location = new System.Drawing.Point(23, 120);
            this.lstvTotal.Name = "lstvTotal";
            this.lstvTotal.Size = new System.Drawing.Size(744, 257);
            this.lstvTotal.TabIndex = 2;
            this.lstvTotal.UseCompatibleStateImageBehavior = false;
            this.lstvTotal.View = System.Windows.Forms.View.Details;
            this.lstvTotal.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstvTotal_ItemChecked);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 43;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Código";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Producto";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio";
            this.columnHeader8.Width = 100;
            // 
            // gbxMontos
            // 
            this.gbxMontos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxMontos.Controls.Add(this.button1);
            this.gbxMontos.Controls.Add(this.txtExoneracion);
            this.gbxMontos.Controls.Add(this.label1);
            this.gbxMontos.Controls.Add(this.label8);
            this.gbxMontos.Controls.Add(this.txtPorcetaje);
            this.gbxMontos.Controls.Add(this.btnCobrar);
            this.gbxMontos.Controls.Add(this.lblSubtotal);
            this.gbxMontos.Controls.Add(this.txtSubtotal);
            this.gbxMontos.Controls.Add(this.txtTotal);
            this.gbxMontos.Controls.Add(this.lblIva);
            this.gbxMontos.Controls.Add(this.txtDescuento);
            this.gbxMontos.Controls.Add(this.lblDescuento);
            this.gbxMontos.Controls.Add(this.txtIva);
            this.gbxMontos.Controls.Add(this.lblTotal);
            this.gbxMontos.Location = new System.Drawing.Point(852, 6);
            this.gbxMontos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Name = "gbxMontos";
            this.gbxMontos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Size = new System.Drawing.Size(366, 371);
            this.gbxMontos.TabIndex = 70;
            this.gbxMontos.TabStop = false;
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExoneracion.Location = new System.Drawing.Point(155, 125);
            this.txtExoneracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.ReadOnly = true;
            this.txtExoneracion.Size = new System.Drawing.Size(174, 34);
            this.txtExoneracion.TabIndex = 66;
            this.txtExoneracion.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Exoneración:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(202, 99);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "%";
            // 
            // txtPorcetaje
            // 
            this.txtPorcetaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcetaje.Location = new System.Drawing.Point(155, 89);
            this.txtPorcetaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcetaje.Name = "txtPorcetaje";
            this.txtPorcetaje.Size = new System.Drawing.Size(47, 34);
            this.txtPorcetaje.TabIndex = 63;
            this.txtPorcetaje.Text = "0";
            this.txtPorcetaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcetaje_KeyPress);
            // 
            // btnCobrar
            // 
            this.btnCobrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCobrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCobrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCobrar.FlatAppearance.BorderSize = 2;
            this.btnCobrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(70, 222);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(260, 69);
            this.btnCobrar.TabIndex = 60;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(37, 25);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(99, 25);
            this.lblSubtotal.TabIndex = 36;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(155, 16);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(174, 34);
            this.txtSubtotal.TabIndex = 35;
            this.txtSubtotal.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(155, 161);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(174, 34);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.Text = "0";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(81, 55);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(55, 25);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "IVA:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(234, 89);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(95, 34);
            this.txtDescuento.TabIndex = 33;
            this.txtDescuento.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(14, 94);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(122, 25);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(155, 53);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(174, 34);
            this.txtIva.TabIndex = 0;
            this.txtIva.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(68, 167);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 25);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // chkEnviar
            // 
            this.chkEnviar.AutoSize = true;
            this.chkEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviar.Location = new System.Drawing.Point(387, 35);
            this.chkEnviar.Name = "chkEnviar";
            this.chkEnviar.Size = new System.Drawing.Size(262, 28);
            this.chkEnviar.TabIndex = 80;
            this.chkEnviar.Text = "Notificar Correo Electrónico";
            this.chkEnviar.UseVisualStyleBackColor = true;
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo2.Location = new System.Drawing.Point(493, 63);
            this.txtCorreo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo2.MaxLength = 50;
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(274, 27);
            this.txtCorreo2.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(50, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Correos:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(141, 63);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(350, 27);
            this.txtCorreo.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(46, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Teléfono:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(141, 33);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(238, 27);
            this.txtTel.TabIndex = 75;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(141, 3);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(155, 27);
            this.txtIdCliente.TabIndex = 74;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(775, 3);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(49, 52);
            this.btnBuscarCliente.TabIndex = 73;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCliente.Location = new System.Drawing.Point(58, 6);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 20);
            this.lblCliente.TabIndex = 72;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(304, 3);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(463, 27);
            this.txtCliente.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(70, 299);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 69);
            this.button1.TabIndex = 67;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "A Facturar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "Factura Total Pendiente:";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Importe";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Desc";
            this.columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "IVA";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Monto Total";
            this.columnHeader12.Width = 100;
            // 
            // frmDividirCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkEnviar);
            this.Controls.Add(this.txtCorreo2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.gbxMontos);
            this.Controls.Add(this.lstvTotal);
            this.Controls.Add(this.lstvListaParcial);
            this.Name = "frmDividirCuenta";
            this.Text = "Cobrar: Dividir cuenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDividirCuenta_FormClosing);
            this.Load += new System.EventHandler(this.frmDividirCuenta_Load);
            this.gbxMontos.ResumeLayout(false);
            this.gbxMontos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstvListaParcial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lstvTotal;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox gbxMontos;
        private System.Windows.Forms.TextBox txtExoneracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPorcetaje;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader Cant;
        private System.Windows.Forms.CheckBox chkEnviar;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}