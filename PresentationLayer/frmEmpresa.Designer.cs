namespace PresentationLayer
{
    partial class frmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresa));
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
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.chkImprimeDoc = new System.Windows.Forms.CheckBox();
            this.gbxHacienda = new System.Windows.Forms.GroupBox();
            this.btnRutaComprasXML = new System.Windows.Forms.Button();
            this.btnRutaXML = new System.Windows.Forms.Button();
            this.btnCertificado = new System.Windows.Forms.Button();
            this.chkAmbienteDesa = new System.Windows.Forms.CheckBox();
            this.txtFechaResolucion = new System.Windows.Forms.TextBox();
            this.txtResolucion = new System.Windows.Forms.TextBox();
            this.txtXMLCompras = new System.Windows.Forms.TextBox();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.txtPinCertificado = new System.Windows.Forms.TextBox();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.txtConstrasenaHacienda = new System.Windows.Forms.TextBox();
            this.txtUsuarioHacienda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxCorreo = new System.Windows.Forms.GroupBox();
            this.txtCuerpoCorreo = new System.Windows.Forms.TextBox();
            this.txtAsuntoCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseCorreo = new System.Windows.Forms.TextBox();
            this.txtCorreoEmpresa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sp_FacturaElectronicaTableAdapter1 = new PresentationLayer.Reportes.dtReporteHaciendaTableAdapters.sp_FacturaElectronicaTableAdapter();
            this.txtActEconomica = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tlsMenu.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxHacienda.SuspendLayout();
            this.gbxCorreo.SuspendLayout();
            this.SuspendLayout();
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
            this.tlsMenu.Size = new System.Drawing.Size(663, 39);
            this.tlsMenu.TabIndex = 13;
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
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtActEconomica);
            this.gbxDatos.Controls.Add(this.label14);
            this.gbxDatos.Controls.Add(this.chkImprimeDoc);
            this.gbxDatos.Controls.Add(this.gbxHacienda);
            this.gbxDatos.Controls.Add(this.gbxCorreo);
            this.gbxDatos.Controls.Add(this.txtNombreComercial);
            this.gbxDatos.Controls.Add(this.txtNombreEmpresa);
            this.gbxDatos.Controls.Add(this.txtIdEmpresa);
            this.gbxDatos.Controls.Add(this.label13);
            this.gbxDatos.Controls.Add(this.label9);
            this.gbxDatos.Controls.Add(this.label11);
            this.gbxDatos.Location = new System.Drawing.Point(14, 42);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(628, 723);
            this.gbxDatos.TabIndex = 15;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de Empresa";
            // 
            // chkImprimeDoc
            // 
            this.chkImprimeDoc.AutoSize = true;
            this.chkImprimeDoc.Location = new System.Drawing.Point(187, 696);
            this.chkImprimeDoc.Name = "chkImprimeDoc";
            this.chkImprimeDoc.Size = new System.Drawing.Size(160, 21);
            this.chkImprimeDoc.TabIndex = 36;
            this.chkImprimeDoc.Text = "Imprime documentos";
            this.chkImprimeDoc.UseVisualStyleBackColor = true;
            // 
            // gbxHacienda
            // 
            this.gbxHacienda.Controls.Add(this.btnRutaComprasXML);
            this.gbxHacienda.Controls.Add(this.btnRutaXML);
            this.gbxHacienda.Controls.Add(this.btnCertificado);
            this.gbxHacienda.Controls.Add(this.chkAmbienteDesa);
            this.gbxHacienda.Controls.Add(this.txtFechaResolucion);
            this.gbxHacienda.Controls.Add(this.txtResolucion);
            this.gbxHacienda.Controls.Add(this.txtXMLCompras);
            this.gbxHacienda.Controls.Add(this.txtRutaXML);
            this.gbxHacienda.Controls.Add(this.txtPinCertificado);
            this.gbxHacienda.Controls.Add(this.txtCertificado);
            this.gbxHacienda.Controls.Add(this.txtConstrasenaHacienda);
            this.gbxHacienda.Controls.Add(this.txtUsuarioHacienda);
            this.gbxHacienda.Controls.Add(this.label5);
            this.gbxHacienda.Controls.Add(this.label6);
            this.gbxHacienda.Controls.Add(this.label1);
            this.gbxHacienda.Controls.Add(this.label7);
            this.gbxHacienda.Controls.Add(this.label8);
            this.gbxHacienda.Controls.Add(this.label15);
            this.gbxHacienda.Controls.Add(this.label3);
            this.gbxHacienda.Controls.Add(this.label16);
            this.gbxHacienda.Controls.Add(this.label4);
            this.gbxHacienda.Location = new System.Drawing.Point(18, 136);
            this.gbxHacienda.Name = "gbxHacienda";
            this.gbxHacienda.Size = new System.Drawing.Size(604, 291);
            this.gbxHacienda.TabIndex = 23;
            this.gbxHacienda.TabStop = false;
            this.gbxHacienda.Text = "Datos de Hacienda";
            this.gbxHacienda.Enter += new System.EventHandler(this.gbxHacienda_Enter);
            // 
            // btnRutaComprasXML
            // 
            this.btnRutaComprasXML.Location = new System.Drawing.Point(556, 203);
            this.btnRutaComprasXML.Name = "btnRutaComprasXML";
            this.btnRutaComprasXML.Size = new System.Drawing.Size(41, 23);
            this.btnRutaComprasXML.TabIndex = 35;
            this.btnRutaComprasXML.Text = "...";
            this.btnRutaComprasXML.UseVisualStyleBackColor = true;
            this.btnRutaComprasXML.Click += new System.EventHandler(this.btnRutaComprasXML_Click);
            // 
            // btnRutaXML
            // 
            this.btnRutaXML.Location = new System.Drawing.Point(556, 174);
            this.btnRutaXML.Name = "btnRutaXML";
            this.btnRutaXML.Size = new System.Drawing.Size(41, 23);
            this.btnRutaXML.TabIndex = 34;
            this.btnRutaXML.Text = "...";
            this.btnRutaXML.UseVisualStyleBackColor = true;
            this.btnRutaXML.Click += new System.EventHandler(this.btnRutaXML_Click);
            // 
            // btnCertificado
            // 
            this.btnCertificado.Location = new System.Drawing.Point(556, 121);
            this.btnCertificado.Name = "btnCertificado";
            this.btnCertificado.Size = new System.Drawing.Size(41, 23);
            this.btnCertificado.TabIndex = 33;
            this.btnCertificado.Text = "...";
            this.btnCertificado.UseVisualStyleBackColor = true;
            this.btnCertificado.Click += new System.EventHandler(this.btnCertificado_Click);
            // 
            // chkAmbienteDesa
            // 
            this.chkAmbienteDesa.AutoSize = true;
            this.chkAmbienteDesa.Location = new System.Drawing.Point(174, 20);
            this.chkAmbienteDesa.Name = "chkAmbienteDesa";
            this.chkAmbienteDesa.Size = new System.Drawing.Size(184, 21);
            this.chkAmbienteDesa.TabIndex = 32;
            this.chkAmbienteDesa.Text = "Ambiente de Producción";
            this.chkAmbienteDesa.UseVisualStyleBackColor = true;
            // 
            // txtFechaResolucion
            // 
            this.txtFechaResolucion.Location = new System.Drawing.Point(174, 257);
            this.txtFechaResolucion.Name = "txtFechaResolucion";
            this.txtFechaResolucion.Size = new System.Drawing.Size(376, 22);
            this.txtFechaResolucion.TabIndex = 31;
            // 
            // txtResolucion
            // 
            this.txtResolucion.Location = new System.Drawing.Point(174, 230);
            this.txtResolucion.Name = "txtResolucion";
            this.txtResolucion.Size = new System.Drawing.Size(376, 22);
            this.txtResolucion.TabIndex = 30;
            // 
            // txtXMLCompras
            // 
            this.txtXMLCompras.Location = new System.Drawing.Point(174, 203);
            this.txtXMLCompras.Name = "txtXMLCompras";
            this.txtXMLCompras.Size = new System.Drawing.Size(376, 22);
            this.txtXMLCompras.TabIndex = 29;
            // 
            // txtRutaXML
            // 
            this.txtRutaXML.Location = new System.Drawing.Point(174, 175);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.Size = new System.Drawing.Size(376, 22);
            this.txtRutaXML.TabIndex = 28;
            // 
            // txtPinCertificado
            // 
            this.txtPinCertificado.Location = new System.Drawing.Point(174, 148);
            this.txtPinCertificado.Name = "txtPinCertificado";
            this.txtPinCertificado.PasswordChar = '*';
            this.txtPinCertificado.Size = new System.Drawing.Size(376, 22);
            this.txtPinCertificado.TabIndex = 27;
            // 
            // txtCertificado
            // 
            this.txtCertificado.Location = new System.Drawing.Point(174, 121);
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(376, 22);
            this.txtCertificado.TabIndex = 26;
            // 
            // txtConstrasenaHacienda
            // 
            this.txtConstrasenaHacienda.Location = new System.Drawing.Point(174, 74);
            this.txtConstrasenaHacienda.Name = "txtConstrasenaHacienda";
            this.txtConstrasenaHacienda.Size = new System.Drawing.Size(376, 22);
            this.txtConstrasenaHacienda.TabIndex = 25;
            // 
            // txtUsuarioHacienda
            // 
            this.txtUsuarioHacienda.Location = new System.Drawing.Point(174, 47);
            this.txtUsuarioHacienda.Name = "txtUsuarioHacienda";
            this.txtUsuarioHacienda.Size = new System.Drawing.Size(376, 22);
            this.txtUsuarioHacienda.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña Hacienda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuario Hacienda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Certificado Instalado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "PIN Certificado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ruta de Archivos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Ruta XML Compras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Resolución:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 15;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Resolución:";
            // 
            // gbxCorreo
            // 
            this.gbxCorreo.Controls.Add(this.txtCuerpoCorreo);
            this.gbxCorreo.Controls.Add(this.txtAsuntoCorreo);
            this.gbxCorreo.Controls.Add(this.txtContraseCorreo);
            this.gbxCorreo.Controls.Add(this.txtCorreoEmpresa);
            this.gbxCorreo.Controls.Add(this.label12);
            this.gbxCorreo.Controls.Add(this.label10);
            this.gbxCorreo.Controls.Add(this.label2);
            this.gbxCorreo.Controls.Add(this.label17);
            this.gbxCorreo.Location = new System.Drawing.Point(13, 440);
            this.gbxCorreo.Name = "gbxCorreo";
            this.gbxCorreo.Size = new System.Drawing.Size(569, 251);
            this.gbxCorreo.TabIndex = 22;
            this.gbxCorreo.TabStop = false;
            this.gbxCorreo.Text = "Datos de Correo Empresarial";
            // 
            // txtCuerpoCorreo
            // 
            this.txtCuerpoCorreo.Location = new System.Drawing.Point(174, 108);
            this.txtCuerpoCorreo.MaxLength = 500;
            this.txtCuerpoCorreo.Multiline = true;
            this.txtCuerpoCorreo.Name = "txtCuerpoCorreo";
            this.txtCuerpoCorreo.Size = new System.Drawing.Size(381, 126);
            this.txtCuerpoCorreo.TabIndex = 35;
            // 
            // txtAsuntoCorreo
            // 
            this.txtAsuntoCorreo.Location = new System.Drawing.Point(174, 80);
            this.txtAsuntoCorreo.MaxLength = 50;
            this.txtAsuntoCorreo.Name = "txtAsuntoCorreo";
            this.txtAsuntoCorreo.Size = new System.Drawing.Size(381, 22);
            this.txtAsuntoCorreo.TabIndex = 34;
            // 
            // txtContraseCorreo
            // 
            this.txtContraseCorreo.Location = new System.Drawing.Point(174, 52);
            this.txtContraseCorreo.Name = "txtContraseCorreo";
            this.txtContraseCorreo.PasswordChar = '*';
            this.txtContraseCorreo.Size = new System.Drawing.Size(381, 22);
            this.txtContraseCorreo.TabIndex = 33;
            // 
            // txtCorreoEmpresa
            // 
            this.txtCorreoEmpresa.Location = new System.Drawing.Point(174, 24);
            this.txtCorreoEmpresa.Name = "txtCorreoEmpresa";
            this.txtCorreoEmpresa.Size = new System.Drawing.Size(381, 22);
            this.txtCorreoEmpresa.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Contraseña Empresa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Asunto Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo Empresa:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 17);
            this.label17.TabIndex = 16;
            this.label17.Text = "Mensaje Cuerpo Correo:";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(192, 76);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(376, 22);
            this.txtNombreComercial.TabIndex = 21;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Enabled = false;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(192, 48);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(376, 22);
            this.txtNombreEmpresa.TabIndex = 20;
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Enabled = false;
            this.txtIdEmpresa.Location = new System.Drawing.Point(192, 20);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(376, 22);
            this.txtIdEmpresa.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(161, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre Empresa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nombre Comercial:";
            // 
            // sp_FacturaElectronicaTableAdapter1
            // 
            this.sp_FacturaElectronicaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtActEconomica
            // 
            this.txtActEconomica.Location = new System.Drawing.Point(192, 104);
            this.txtActEconomica.MaxLength = 6;
            this.txtActEconomica.Name = "txtActEconomica";
            this.txtActEconomica.Size = new System.Drawing.Size(376, 22);
            this.txtActEconomica.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Código Act. Económica:";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 777);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.tlsMenu);
            this.Name = "frmEmpresa";
            this.Text = "Mantenimiento: Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxHacienda.ResumeLayout(false);
            this.gbxHacienda.PerformLayout();
            this.gbxCorreo.ResumeLayout(false);
            this.gbxCorreo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.GroupBox gbxHacienda;
        private System.Windows.Forms.CheckBox chkAmbienteDesa;
        private System.Windows.Forms.TextBox txtFechaResolucion;
        private System.Windows.Forms.TextBox txtResolucion;
        private System.Windows.Forms.TextBox txtXMLCompras;
        private System.Windows.Forms.TextBox txtRutaXML;
        private System.Windows.Forms.TextBox txtPinCertificado;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.TextBox txtConstrasenaHacienda;
        private System.Windows.Forms.TextBox txtUsuarioHacienda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxCorreo;
        private System.Windows.Forms.TextBox txtCuerpoCorreo;
        private System.Windows.Forms.TextBox txtAsuntoCorreo;
        private System.Windows.Forms.TextBox txtContraseCorreo;
        private System.Windows.Forms.TextBox txtCorreoEmpresa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCertificado;
        private Reportes.dtReporteHaciendaTableAdapters.sp_FacturaElectronicaTableAdapter sp_FacturaElectronicaTableAdapter1;
        private System.Windows.Forms.Button btnRutaComprasXML;
        private System.Windows.Forms.Button btnRutaXML;
        private System.Windows.Forms.CheckBox chkImprimeDoc;
        private System.Windows.Forms.TextBox txtActEconomica;
        private System.Windows.Forms.Label label14;
    }
}