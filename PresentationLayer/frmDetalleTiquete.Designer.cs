namespace PresentationLayer
{
    partial class frmDetalleTiquete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleTiquete));
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.ptcLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblLogoEmpresa = new System.Windows.Forms.Label();
            this.txtMensajeDespidad = new System.Windows.Forms.TextBox();
            this.txtTributacion = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpresa = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblDireccionEmpresa = new System.Windows.Forms.Label();
            this.lblMensajeDespedida = new System.Windows.Forms.Label();
            this.lblTributacion = new System.Windows.Forms.Label();
            this.lblTelefonoEmpresa = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
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
            this.gboDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogoEmpresa)).BeginInit();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboDatos
            // 
            this.gboDatos.Controls.Add(this.ptcLogoEmpresa);
            this.gboDatos.Controls.Add(this.btnAgregarImagen);
            this.gboDatos.Controls.Add(this.lblLogoEmpresa);
            this.gboDatos.Controls.Add(this.txtMensajeDespidad);
            this.gboDatos.Controls.Add(this.txtTributacion);
            this.gboDatos.Controls.Add(this.txtTelefonoEmpresa);
            this.gboDatos.Controls.Add(this.txtDireccionEmpresa);
            this.gboDatos.Controls.Add(this.txtNombreEmpresa);
            this.gboDatos.Controls.Add(this.lblDireccionEmpresa);
            this.gboDatos.Controls.Add(this.lblMensajeDespedida);
            this.gboDatos.Controls.Add(this.lblTributacion);
            this.gboDatos.Controls.Add(this.lblTelefonoEmpresa);
            this.gboDatos.Controls.Add(this.lblNombreEmpresa);
            this.gboDatos.Location = new System.Drawing.Point(12, 42);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Size = new System.Drawing.Size(299, 317);
            this.gboDatos.TabIndex = 16;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos de la empresa";
            // 
            // ptcLogoEmpresa
            // 
            this.ptcLogoEmpresa.Location = new System.Drawing.Point(103, 179);
            this.ptcLogoEmpresa.Name = "ptcLogoEmpresa";
            this.ptcLogoEmpresa.Size = new System.Drawing.Size(111, 90);
            this.ptcLogoEmpresa.TabIndex = 12;
            this.ptcLogoEmpresa.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(103, 275);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(111, 36);
            this.btnAgregarImagen.TabIndex = 11;
            this.btnAgregarImagen.Text = "Agregar imagen...";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblLogoEmpresa
            // 
            this.lblLogoEmpresa.AutoSize = true;
            this.lblLogoEmpresa.Location = new System.Drawing.Point(107, 163);
            this.lblLogoEmpresa.Name = "lblLogoEmpresa";
            this.lblLogoEmpresa.Size = new System.Drawing.Size(103, 13);
            this.lblLogoEmpresa.TabIndex = 10;
            this.lblLogoEmpresa.Text = "Logo de la empresa:";
            // 
            // txtMensajeDespidad
            // 
            this.txtMensajeDespidad.Location = new System.Drawing.Point(94, 127);
            this.txtMensajeDespidad.Name = "txtMensajeDespidad";
            this.txtMensajeDespidad.Size = new System.Drawing.Size(162, 20);
            this.txtMensajeDespidad.TabIndex = 9;
            // 
            // txtTributacion
            // 
            this.txtTributacion.Location = new System.Drawing.Point(94, 101);
            this.txtTributacion.Name = "txtTributacion";
            this.txtTributacion.Size = new System.Drawing.Size(162, 20);
            this.txtTributacion.TabIndex = 8;
            // 
            // txtTelefonoEmpresa
            // 
            this.txtTelefonoEmpresa.Location = new System.Drawing.Point(94, 75);
            this.txtTelefonoEmpresa.Name = "txtTelefonoEmpresa";
            this.txtTelefonoEmpresa.Size = new System.Drawing.Size(162, 20);
            this.txtTelefonoEmpresa.TabIndex = 7;
            // 
            // txtDireccionEmpresa
            // 
            this.txtDireccionEmpresa.Location = new System.Drawing.Point(94, 49);
            this.txtDireccionEmpresa.Name = "txtDireccionEmpresa";
            this.txtDireccionEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionEmpresa.TabIndex = 6;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(94, 23);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(162, 20);
            this.txtNombreEmpresa.TabIndex = 5;
            // 
            // lblDireccionEmpresa
            // 
            this.lblDireccionEmpresa.AutoSize = true;
            this.lblDireccionEmpresa.Location = new System.Drawing.Point(33, 52);
            this.lblDireccionEmpresa.Name = "lblDireccionEmpresa";
            this.lblDireccionEmpresa.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionEmpresa.TabIndex = 4;
            this.lblDireccionEmpresa.Text = "Dirección:";
            // 
            // lblMensajeDespedida
            // 
            this.lblMensajeDespedida.AutoSize = true;
            this.lblMensajeDespedida.Location = new System.Drawing.Point(38, 130);
            this.lblMensajeDespedida.Name = "lblMensajeDespedida";
            this.lblMensajeDespedida.Size = new System.Drawing.Size(50, 13);
            this.lblMensajeDespedida.TabIndex = 3;
            this.lblMensajeDespedida.Text = "Mensaje:";
            // 
            // lblTributacion
            // 
            this.lblTributacion.AutoSize = true;
            this.lblTributacion.Location = new System.Drawing.Point(25, 104);
            this.lblTributacion.Name = "lblTributacion";
            this.lblTributacion.Size = new System.Drawing.Size(63, 13);
            this.lblTributacion.TabIndex = 2;
            this.lblTributacion.Text = "Tributación;";
            // 
            // lblTelefonoEmpresa
            // 
            this.lblTelefonoEmpresa.AutoSize = true;
            this.lblTelefonoEmpresa.Location = new System.Drawing.Point(36, 78);
            this.lblTelefonoEmpresa.Name = "lblTelefonoEmpresa";
            this.lblTelefonoEmpresa.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoEmpresa.TabIndex = 1;
            this.lblTelefonoEmpresa.Text = "Teléfono:";
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(41, 26);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEmpresa.TabIndex = 0;
            this.lblNombreEmpresa.Text = "Nombre:";
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
            this.tlsMenu.Size = new System.Drawing.Size(323, 39);
            this.tlsMenu.TabIndex = 17;
            this.tlsMenu.Text = "toolStrip1";
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
            // frmDetalleTiquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 371);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.gboDatos);
            this.Name = "frmDetalleTiquete";
            this.Text = "Configuración de tiquete";
            this.Load += new System.EventHandler(this.frmDetalleTiquete_Load);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcLogoEmpresa)).EndInit();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.PictureBox ptcLogoEmpresa;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblLogoEmpresa;
        private System.Windows.Forms.TextBox txtMensajeDespidad;
        private System.Windows.Forms.TextBox txtTributacion;
        private System.Windows.Forms.TextBox txtTelefonoEmpresa;
        private System.Windows.Forms.TextBox txtDireccionEmpresa;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblDireccionEmpresa;
        private System.Windows.Forms.Label lblMensajeDespedida;
        private System.Windows.Forms.Label lblTributacion;
        private System.Windows.Forms.Label lblTelefonoEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
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
    }
}