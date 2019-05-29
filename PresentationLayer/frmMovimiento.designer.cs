namespace PresentationLayer
{
    partial class frmMovimiento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimiento));
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
            this.gbxMovimiento = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.gbxDetalleMovimiento = new System.Windows.Forms.GroupBox();
            this.grvDetalleIngrediente = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBorrar = new System.Windows.Forms.Label();
            this.btnBorrarFila = new System.Windows.Forms.Button();
            this.lblIngredienteDetalle = new System.Windows.Forms.Label();
            this.btnIngDetalleMov = new System.Windows.Forms.Button();
            this.cbxTipoMov = new System.Windows.Forms.ComboBox();
            this.dtpFechaMovi = new System.Windows.Forms.DateTimePicker();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.lblFechaMoviento = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.imgLista = new System.Windows.Forms.ImageList(this.components);
            this.tlsMenu.SuspendLayout();
            this.gbxMovimiento.SuspendLayout();
            this.gbxDetalleMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalleIngrediente)).BeginInit();
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
            this.tlsMenu.Size = new System.Drawing.Size(591, 39);
            this.tlsMenu.TabIndex = 9;
            this.tlsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsMenu_ItemClicked);
            // 
            // tlsBtnGuardar
            // 
            this.tlsBtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnGuardar.Image")));
            this.tlsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
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
            this.tlsBtnNuevo.Name = "tlsBtnNuevo";
            this.tlsBtnNuevo.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnNuevo.Text = "Nuevo";
            this.tlsBtnNuevo.Click += new System.EventHandler(this.tlsBtnNuevo_Click);
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
            this.tlsBtnSalir.Name = "tlsBtnSalir";
            this.tlsBtnSalir.Size = new System.Drawing.Size(36, 36);
            this.tlsBtnSalir.Text = "Salir";
            this.tlsBtnSalir.Click += new System.EventHandler(this.tlsBtnSalir_Click);
            // 
            // gbxMovimiento
            // 
            this.gbxMovimiento.Controls.Add(this.label1);
            this.gbxMovimiento.Controls.Add(this.chkEstado);
            this.gbxMovimiento.Controls.Add(this.gbxDetalleMovimiento);
            this.gbxMovimiento.Controls.Add(this.cbxTipoMov);
            this.gbxMovimiento.Controls.Add(this.dtpFechaMovi);
            this.gbxMovimiento.Controls.Add(this.txtMontoTotal);
            this.gbxMovimiento.Controls.Add(this.txtMotivo);
            this.gbxMovimiento.Controls.Add(this.txtID);
            this.gbxMovimiento.Controls.Add(this.lblID);
            this.gbxMovimiento.Controls.Add(this.lblTipoMovimiento);
            this.gbxMovimiento.Controls.Add(this.lblFechaMoviento);
            this.gbxMovimiento.Controls.Add(this.lblMotivo);
            this.gbxMovimiento.Location = new System.Drawing.Point(12, 42);
            this.gbxMovimiento.Name = "gbxMovimiento";
            this.gbxMovimiento.Size = new System.Drawing.Size(568, 394);
            this.gbxMovimiento.TabIndex = 7;
            this.gbxMovimiento.TabStop = false;
            this.gbxMovimiento.Text = "Movimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monto Total=";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(18, 372);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 8;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // gbxDetalleMovimiento
            // 
            this.gbxDetalleMovimiento.Controls.Add(this.grvDetalleIngrediente);
            this.gbxDetalleMovimiento.Controls.Add(this.lblBorrar);
            this.gbxDetalleMovimiento.Controls.Add(this.btnBorrarFila);
            this.gbxDetalleMovimiento.Controls.Add(this.lblIngredienteDetalle);
            this.gbxDetalleMovimiento.Controls.Add(this.btnIngDetalleMov);
            this.gbxDetalleMovimiento.Location = new System.Drawing.Point(9, 164);
            this.gbxDetalleMovimiento.Name = "gbxDetalleMovimiento";
            this.gbxDetalleMovimiento.Size = new System.Drawing.Size(551, 193);
            this.gbxDetalleMovimiento.TabIndex = 9;
            this.gbxDetalleMovimiento.TabStop = false;
            this.gbxDetalleMovimiento.Text = "Detalle Movimiento";
            // 
            // grvDetalleIngrediente
            // 
            this.grvDetalleIngrediente.AllowDrop = true;
            this.grvDetalleIngrediente.AllowUserToDeleteRows = false;
            this.grvDetalleIngrediente.AllowUserToResizeRows = false;
            this.grvDetalleIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDetalleIngrediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIngrediente,
            this.colMedida,
            this.colCantidad,
            this.colMonto});
            this.grvDetalleIngrediente.Location = new System.Drawing.Point(9, 51);
            this.grvDetalleIngrediente.Name = "grvDetalleIngrediente";
            this.grvDetalleIngrediente.Size = new System.Drawing.Size(536, 134);
            this.grvDetalleIngrediente.TabIndex = 6;
            this.grvDetalleIngrediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDetalleIngrediente_CellContentClick);
            this.grvDetalleIngrediente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDetalleIngrediente_CellEnter);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colIngrediente
            // 
            this.colIngrediente.HeaderText = "Ingrediente";
            this.colIngrediente.Name = "colIngrediente";
            this.colIngrediente.ReadOnly = true;
            // 
            // colMedida
            // 
            this.colMedida.HeaderText = "Medida";
            this.colMedida.Name = "colMedida";
            this.colMedida.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.Location = new System.Drawing.Point(209, 21);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(0, 13);
            this.lblBorrar.TabIndex = 7;
            // 
            // btnBorrarFila
            // 
            this.btnBorrarFila.Location = new System.Drawing.Point(308, 16);
            this.btnBorrarFila.Name = "btnBorrarFila";
            this.btnBorrarFila.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarFila.TabIndex = 5;
            this.btnBorrarFila.Text = "Borrar Fila";
            this.btnBorrarFila.UseVisualStyleBackColor = true;
            this.btnBorrarFila.Click += new System.EventHandler(this.btnBorrarFila_Click);
            // 
            // lblIngredienteDetalle
            // 
            this.lblIngredienteDetalle.AutoSize = true;
            this.lblIngredienteDetalle.Location = new System.Drawing.Point(6, 21);
            this.lblIngredienteDetalle.Name = "lblIngredienteDetalle";
            this.lblIngredienteDetalle.Size = new System.Drawing.Size(63, 13);
            this.lblIngredienteDetalle.TabIndex = 2;
            this.lblIngredienteDetalle.Text = "Ingrediente:";
            // 
            // btnIngDetalleMov
            // 
            this.btnIngDetalleMov.Location = new System.Drawing.Point(75, 16);
            this.btnIngDetalleMov.Name = "btnIngDetalleMov";
            this.btnIngDetalleMov.Size = new System.Drawing.Size(37, 23);
            this.btnIngDetalleMov.TabIndex = 4;
            this.btnIngDetalleMov.Text = "?";
            this.btnIngDetalleMov.UseVisualStyleBackColor = true;
            this.btnIngDetalleMov.Click += new System.EventHandler(this.btnIngDetalleMov_Click);
            // 
            // cbxTipoMov
            // 
            this.cbxTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMov.FormattingEnabled = true;
            this.cbxTipoMov.Location = new System.Drawing.Point(317, 47);
            this.cbxTipoMov.MaxLength = 150;
            this.cbxTipoMov.Name = "cbxTipoMov";
            this.cbxTipoMov.Size = new System.Drawing.Size(237, 21);
            this.cbxTipoMov.TabIndex = 1;
            // 
            // dtpFechaMovi
            // 
            this.dtpFechaMovi.Location = new System.Drawing.Point(317, 99);
            this.dtpFechaMovi.Name = "dtpFechaMovi";
            this.dtpFechaMovi.Size = new System.Drawing.Size(237, 20);
            this.dtpFechaMovi.TabIndex = 3;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(390, 369);
            this.txtMontoTotal.MaxLength = 15;
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(164, 20);
            this.txtMontoTotal.TabIndex = 7;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(18, 99);
            this.txtMotivo.MaxLength = 500;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(230, 48);
            this.txtMotivo.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(18, 47);
            this.txtID.MaxLength = 15;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(230, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 31);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(78, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Movimiento:";
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(314, 31);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(106, 13);
            this.lblTipoMovimiento.TabIndex = 1;
            this.lblTipoMovimiento.Text = "Tipo de  Movimiento:";
            // 
            // lblFechaMoviento
            // 
            this.lblFechaMoviento.AutoSize = true;
            this.lblFechaMoviento.Location = new System.Drawing.Point(314, 83);
            this.lblFechaMoviento.Name = "lblFechaMoviento";
            this.lblFechaMoviento.Size = new System.Drawing.Size(117, 13);
            this.lblFechaMoviento.TabIndex = 3;
            this.lblFechaMoviento.Text = "Fecha del  Movimiento:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(15, 83);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo:";
            // 
            // imgLista
            // 
            this.imgLista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLista.ImageStream")));
            this.imgLista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLista.Images.SetKeyName(0, "Guardar.png");
            this.imgLista.Images.SetKeyName(1, "Nuevo.png");
            this.imgLista.Images.SetKeyName(2, "Modificar.png");
            this.imgLista.Images.SetKeyName(3, "Eliminar.png");
            this.imgLista.Images.SetKeyName(4, "Buscar.png");
            this.imgLista.Images.SetKeyName(5, "Cancelar.png");
            this.imgLista.Images.SetKeyName(6, "Salir.png");
            this.imgLista.Images.SetKeyName(7, "database.png");
            // 
            // frmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 441);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.gbxMovimiento);
            this.Name = "frmMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.gbxMovimiento.ResumeLayout(false);
            this.gbxMovimiento.PerformLayout();
            this.gbxDetalleMovimiento.ResumeLayout(false);
            this.gbxDetalleMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalleIngrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsMenu;
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
        private System.Windows.Forms.GroupBox gbxMovimiento;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.GroupBox gbxDetalleMovimiento;
        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.Button btnBorrarFila;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblIngredienteDetalle;
        private System.Windows.Forms.Button btnIngDetalleMov;
        private System.Windows.Forms.ComboBox cbxTipoMov;
        private System.Windows.Forms.DateTimePicker dtpFechaMovi;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Label lblFechaMoviento;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.ToolStripButton tlsBtnGuardar;
        private System.Windows.Forms.ImageList imgLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridView grvDetalleIngrediente;
        private System.Windows.Forms.Label label1;
    }
}

