namespace PresentationLayer
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.lstvDetalleProducto = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.gboDatosProducto = new System.Windows.Forms.GroupBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cboCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.btnQuitarIngrediente = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.chkEsActivaPromo = new System.Windows.Forms.CheckBox();
            this.ptbImageProducto = new System.Windows.Forms.PictureBox();
            this.txtPrecioPromo = new System.Windows.Forms.TextBox();
            this.lblPrecioPromo = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
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
            this.gboDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageProducto)).BeginInit();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvDetalleProducto
            // 
            this.lstvDetalleProducto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colCantidad});
            this.lstvDetalleProducto.FullRowSelect = true;
            this.lstvDetalleProducto.Location = new System.Drawing.Point(10, 175);
            this.lstvDetalleProducto.Margin = new System.Windows.Forms.Padding(2);
            this.lstvDetalleProducto.Name = "lstvDetalleProducto";
            this.lstvDetalleProducto.Size = new System.Drawing.Size(354, 180);
            this.lstvDetalleProducto.TabIndex = 2;
            this.lstvDetalleProducto.UseCompatibleStateImageBehavior = false;
            this.lstvDetalleProducto.View = System.Windows.Forms.View.Details;
            this.lstvDetalleProducto.SelectedIndexChanged += new System.EventHandler(this.lstvDetalleProducto_SelectedIndexChanged_1);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 118;
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            this.colCantidad.Width = 83;
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(10, 133);
            this.btnAgregarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(156, 38);
            this.btnAgregarIngrediente.TabIndex = 3;
            this.btnAgregarIngrediente.Text = "Agregar ingrediente...";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.button1_Click);
            // 
            // gboDatosProducto
            // 
            this.gboDatosProducto.Controls.Add(this.txtCosto);
            this.gboDatosProducto.Controls.Add(this.lblCosto);
            this.gboDatosProducto.Controls.Add(this.cboCategoriaProducto);
            this.gboDatosProducto.Controls.Add(this.btnQuitarIngrediente);
            this.gboDatosProducto.Controls.Add(this.lblCategoria);
            this.gboDatosProducto.Controls.Add(this.btnAgregarImagen);
            this.gboDatosProducto.Controls.Add(this.chkEsActivaPromo);
            this.gboDatosProducto.Controls.Add(this.ptbImageProducto);
            this.gboDatosProducto.Controls.Add(this.txtPrecioPromo);
            this.gboDatosProducto.Controls.Add(this.lblPrecioPromo);
            this.gboDatosProducto.Controls.Add(this.btnAgregarIngrediente);
            this.gboDatosProducto.Controls.Add(this.txtPrecioProducto);
            this.gboDatosProducto.Controls.Add(this.lstvDetalleProducto);
            this.gboDatosProducto.Controls.Add(this.lblPrecioProducto);
            this.gboDatosProducto.Controls.Add(this.txtNombreProducto);
            this.gboDatosProducto.Controls.Add(this.lblNombreProducto);
            this.gboDatosProducto.Controls.Add(this.txtCodigoProducto);
            this.gboDatosProducto.Controls.Add(this.lblCodigoProducto);
            this.gboDatosProducto.Location = new System.Drawing.Point(9, 52);
            this.gboDatosProducto.Margin = new System.Windows.Forms.Padding(2);
            this.gboDatosProducto.Name = "gboDatosProducto";
            this.gboDatosProducto.Padding = new System.Windows.Forms.Padding(2);
            this.gboDatosProducto.Size = new System.Drawing.Size(564, 359);
            this.gboDatosProducto.TabIndex = 4;
            this.gboDatosProducto.TabStop = false;
            this.gboDatosProducto.Text = "Datos del producto";
            this.gboDatosProducto.Enter += new System.EventHandler(this.gboDatosProducto_Enter);
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(344, 35);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.MaxLength = 30;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(187, 23);
            this.txtCosto.TabIndex = 11;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(292, 41);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(48, 17);
            this.lblCosto.TabIndex = 12;
            this.lblCosto.Text = "Costo:";
            // 
            // cboCategoriaProducto
            // 
            this.cboCategoriaProducto.FormattingEnabled = true;
            this.cboCategoriaProducto.Location = new System.Drawing.Point(88, 89);
            this.cboCategoriaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoriaProducto.Name = "cboCategoriaProducto";
            this.cboCategoriaProducto.Size = new System.Drawing.Size(187, 25);
            this.cboCategoriaProducto.TabIndex = 2;
            this.cboCategoriaProducto.Text = " ";
            // 
            // btnQuitarIngrediente
            // 
            this.btnQuitarIngrediente.Location = new System.Drawing.Point(254, 133);
            this.btnQuitarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarIngrediente.Name = "btnQuitarIngrediente";
            this.btnQuitarIngrediente.Size = new System.Drawing.Size(56, 38);
            this.btnQuitarIngrediente.TabIndex = 10;
            this.btnQuitarIngrediente.Text = "Quitar";
            this.btnQuitarIngrediente.UseVisualStyleBackColor = true;
            this.btnQuitarIngrediente.Click += new System.EventHandler(this.btnQuitarIngrediente_Click_1);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(11, 95);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(368, 132);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(135, 39);
            this.btnAgregarImagen.TabIndex = 6;
            this.btnAgregarImagen.Text = "Agregar imagen...";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // chkEsActivaPromo
            // 
            this.chkEsActivaPromo.AutoSize = true;
            this.chkEsActivaPromo.Location = new System.Drawing.Point(416, 91);
            this.chkEsActivaPromo.Margin = new System.Windows.Forms.Padding(2);
            this.chkEsActivaPromo.Name = "chkEsActivaPromo";
            this.chkEsActivaPromo.Size = new System.Drawing.Size(67, 21);
            this.chkEsActivaPromo.TabIndex = 8;
            this.chkEsActivaPromo.Text = "activa";
            this.chkEsActivaPromo.UseVisualStyleBackColor = true;
            this.chkEsActivaPromo.CheckedChanged += new System.EventHandler(this.ckbEsActivaPromo_CheckedChanged);
            // 
            // ptbImageProducto
            // 
            this.ptbImageProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbImageProducto.BackgroundImage")));
            this.ptbImageProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbImageProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImageProducto.Location = new System.Drawing.Point(368, 175);
            this.ptbImageProducto.Margin = new System.Windows.Forms.Padding(2);
            this.ptbImageProducto.Name = "ptbImageProducto";
            this.ptbImageProducto.Size = new System.Drawing.Size(188, 180);
            this.ptbImageProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImageProducto.TabIndex = 5;
            this.ptbImageProducto.TabStop = false;
            // 
            // txtPrecioPromo
            // 
            this.txtPrecioPromo.Location = new System.Drawing.Point(344, 88);
            this.txtPrecioPromo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioPromo.MaxLength = 30;
            this.txtPrecioPromo.Name = "txtPrecioPromo";
            this.txtPrecioPromo.Size = new System.Drawing.Size(68, 23);
            this.txtPrecioPromo.TabIndex = 4;
            // 
            // lblPrecioPromo
            // 
            this.lblPrecioPromo.AutoSize = true;
            this.lblPrecioPromo.Location = new System.Drawing.Point(288, 91);
            this.lblPrecioPromo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioPromo.Name = "lblPrecioPromo";
            this.lblPrecioPromo.Size = new System.Drawing.Size(53, 17);
            this.lblPrecioPromo.TabIndex = 6;
            this.lblPrecioPromo.Text = "Promo:";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(344, 61);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioProducto.MaxLength = 30;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(187, 23);
            this.txtPrecioProducto.TabIndex = 3;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(292, 67);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioProducto.TabIndex = 4;
            this.lblPrecioProducto.Text = "Precio:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(88, 62);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.MaxLength = 30;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(187, 23);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(22, 65);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(62, 17);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(88, 35);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProducto.MaxLength = 30;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(187, 23);
            this.txtCodigoProducto.TabIndex = 1;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(28, 38);
            this.lblCodigoProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoProducto.TabIndex = 0;
            this.lblCodigoProducto.Text = "Codigo:";
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
            this.tlsMenu.Size = new System.Drawing.Size(584, 39);
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 418);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.gboDatosProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProductos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gboDatosProducto.ResumeLayout(false);
            this.gboDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageProducto)).EndInit();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvDetalleProducto;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.GroupBox gboDatosProducto;
        private System.Windows.Forms.PictureBox ptbImageProducto;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.TextBox txtPrecioPromo;
        private System.Windows.Forms.Label lblPrecioPromo;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.CheckBox chkEsActivaPromo;
        private System.Windows.Forms.ComboBox cboCategoriaProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnQuitarIngrediente;
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
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
    }
}

