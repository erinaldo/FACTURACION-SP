namespace PresentationLayer
{
    partial class frmFacturacion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblCantidadLineas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.gbxMontos = new System.Windows.Forms.GroupBox();
            this.txtExoneracion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPorcetaje = new System.Windows.Forms.TextBox();
            this.btnProforma = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxAcciones = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnReImprimir = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnBuscarProforma = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.chkEnviar = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleFactura)).BeginInit();
            this.gbxMontos.SuspendLayout();
            this.gbxAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.lblCantidadLineas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.dtgvDetalleFactura);
            this.groupBox1.Location = new System.Drawing.Point(9, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(571, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 34);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(7, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(6, 439);
            this.txtObservaciones.MaxLength = 270;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(990, 50);
            this.txtObservaciones.TabIndex = 50;
            // 
            // lblCantidadLineas
            // 
            this.lblCantidadLineas.AutoSize = true;
            this.lblCantidadLineas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadLineas.Location = new System.Drawing.Point(979, 19);
            this.lblCantidadLineas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadLineas.Name = "lblCantidadLineas";
            this.lblCantidadLineas.Size = new System.Drawing.Size(17, 17);
            this.lblCantidadLineas.TabIndex = 49;
            this.lblCantidadLineas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(825, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cantidad de Lineas:";
            // 
            // lblTotalProducto
            // 
            this.lblTotalProducto.AutoSize = true;
            this.lblTotalProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProducto.Location = new System.Drawing.Point(800, 18);
            this.lblTotalProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalProducto.Name = "lblTotalProducto";
            this.lblTotalProducto.Size = new System.Drawing.Size(17, 17);
            this.lblTotalProducto.TabIndex = 47;
            this.lblTotalProducto.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Total de productos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(87, 14);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(477, 27);
            this.txtCodigo.TabIndex = 39;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress_1);
            // 
            // dtgvDetalleFactura
            // 
            this.dtgvDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colPrec,
            this.colCant,
            this.colDes,
            this.colSubTot,
            this.colId,
            this.colEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDetalleFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDetalleFactura.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvDetalleFactura.Location = new System.Drawing.Point(7, 47);
            this.dtgvDetalleFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDetalleFactura.MultiSelect = false;
            this.dtgvDetalleFactura.Name = "dtgvDetalleFactura";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDetalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDetalleFactura.Size = new System.Drawing.Size(989, 365);
            this.dtgvDetalleFactura.TabIndex = 22;
            this.dtgvDetalleFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetalleFactura_CellContentClick);
            this.dtgvDetalleFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetalleFactura_CellValueChanged);
            // 
            // colNom
            // 
            this.colNom.FillWeight = 369.5432F;
            this.colNom.Frozen = true;
            this.colNom.HeaderText = "Producto";
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            this.colNom.Width = 350;
            // 
            // colPrec
            // 
            this.colPrec.FillWeight = 10.15228F;
            this.colPrec.Frozen = true;
            this.colPrec.HeaderText = "Precio";
            this.colPrec.Name = "colPrec";
            // 
            // colCant
            // 
            this.colCant.FillWeight = 10.15228F;
            this.colCant.Frozen = true;
            this.colCant.HeaderText = "Cantidad";
            this.colCant.Name = "colCant";
            this.colCant.Width = 60;
            // 
            // colDes
            // 
            this.colDes.Frozen = true;
            this.colDes.HeaderText = "Desc.Max";
            this.colDes.Name = "colDes";
            this.colDes.ReadOnly = true;
            this.colDes.Width = 65;
            // 
            // colSubTot
            // 
            this.colSubTot.FillWeight = 10.15228F;
            this.colSubTot.Frozen = true;
            this.colSubTot.HeaderText = "Subtotal";
            this.colSubTot.Name = "colSubTot";
            this.colSubTot.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colEliminar
            // 
            this.colEliminar.Frozen = true;
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "Eliminar";
            this.colEliminar.ToolTipText = "Eliminar linea";
            this.colEliminar.UseColumnTextForLinkValue = true;
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpiarForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarForm.Image")));
            this.btnLimpiarForm.Location = new System.Drawing.Point(7, 46);
            this.btnLimpiarForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiarForm.TabIndex = 33;
            this.btnLimpiarForm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLimpiarForm.UseVisualStyleBackColor = true;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFactura.Image")));
            this.btnBuscarFactura.Location = new System.Drawing.Point(279, 46);
            this.btnBuscarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(70, 70);
            this.btnBuscarFactura.TabIndex = 45;
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // gbxMontos
            // 
            this.gbxMontos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxMontos.Controls.Add(this.txtExoneracion);
            this.gbxMontos.Controls.Add(this.label9);
            this.gbxMontos.Controls.Add(this.label8);
            this.gbxMontos.Controls.Add(this.txtPorcetaje);
            this.gbxMontos.Controls.Add(this.btnProforma);
            this.gbxMontos.Controls.Add(this.btnCobrar);
            this.gbxMontos.Controls.Add(this.lblSubtotal);
            this.gbxMontos.Controls.Add(this.txtSubtotal);
            this.gbxMontos.Controls.Add(this.txtTotal);
            this.gbxMontos.Controls.Add(this.lblIva);
            this.gbxMontos.Controls.Add(this.txtDescuento);
            this.gbxMontos.Controls.Add(this.lblDescuento);
            this.gbxMontos.Controls.Add(this.txtIva);
            this.gbxMontos.Controls.Add(this.lblTotal);
            this.gbxMontos.Location = new System.Drawing.Point(1023, 183);
            this.gbxMontos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Name = "gbxMontos";
            this.gbxMontos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxMontos.Size = new System.Drawing.Size(329, 498);
            this.gbxMontos.TabIndex = 31;
            this.gbxMontos.TabStop = false;
            // 
            // txtExoneracion
            // 
            this.txtExoneracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExoneracion.Location = new System.Drawing.Point(163, 167);
            this.txtExoneracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtExoneracion.Name = "txtExoneracion";
            this.txtExoneracion.ReadOnly = true;
            this.txtExoneracion.Size = new System.Drawing.Size(154, 41);
            this.txtExoneracion.TabIndex = 66;
            this.txtExoneracion.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 29);
            this.label9.TabIndex = 65;
            this.label9.Text = "Exoneración:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "%";
            // 
            // txtPorcetaje
            // 
            this.txtPorcetaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcetaje.Location = new System.Drawing.Point(163, 121);
            this.txtPorcetaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcetaje.Name = "txtPorcetaje";
            this.txtPorcetaje.Size = new System.Drawing.Size(54, 41);
            this.txtPorcetaje.TabIndex = 63;
            this.txtPorcetaje.Text = "0";
            this.txtPorcetaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcetaje_KeyPress);
            // 
            // btnProforma
            // 
            this.btnProforma.BackColor = System.Drawing.Color.GhostWhite;
            this.btnProforma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProforma.FlatAppearance.BorderSize = 2;
            this.btnProforma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProforma.Image = ((System.Drawing.Image)(resources.GetObject("btnProforma.Image")));
            this.btnProforma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProforma.Location = new System.Drawing.Point(15, 399);
            this.btnProforma.Margin = new System.Windows.Forms.Padding(4);
            this.btnProforma.Name = "btnProforma";
            this.btnProforma.Size = new System.Drawing.Size(302, 91);
            this.btnProforma.TabIndex = 61;
            this.btnProforma.Text = "Proforma";
            this.btnProforma.UseVisualStyleBackColor = false;
            this.btnProforma.Click += new System.EventHandler(this.btnProforma_Click);
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
            this.btnCobrar.Location = new System.Drawing.Point(16, 280);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(302, 95);
            this.btnCobrar.TabIndex = 60;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(51, 28);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(107, 29);
            this.lblSubtotal.TabIndex = 36;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(163, 21);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(154, 41);
            this.txtSubtotal.TabIndex = 35;
            this.txtSubtotal.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(163, 214);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(154, 41);
            this.txtTotal.TabIndex = 34;
            this.txtTotal.Text = "0";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(103, 77);
            this.lblIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(55, 29);
            this.lblIva.TabIndex = 28;
            this.lblIva.Text = "IVA:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(244, 121);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(73, 41);
            this.txtDescuento.TabIndex = 33;
            this.txtDescuento.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(24, 128);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(134, 29);
            this.lblDescuento.TabIndex = 29;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(163, 70);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(154, 41);
            this.txtIva.TabIndex = 0;
            this.txtIva.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(82, 220);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 29);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Total:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(667, 7);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(70, 70);
            this.btnBuscarCliente.TabIndex = 36;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCliente.Location = new System.Drawing.Point(25, 10);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 20);
            this.lblCliente.TabIndex = 35;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(262, 7);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(397, 27);
            this.txtCliente.TabIndex = 34;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(99, 7);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(155, 27);
            this.txtIdCliente.TabIndex = 38;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCliente_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(99, 128);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 500;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(560, 47);
            this.txtDireccion.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(5, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Dirección:";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(99, 37);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(238, 27);
            this.txtTel.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(99, 67);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(560, 27);
            this.txtCorreo.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Correo 1:";
            // 
            // gbxAcciones
            // 
            this.gbxAcciones.Controls.Add(this.label22);
            this.gbxAcciones.Controls.Add(this.btnReImprimir);
            this.gbxAcciones.Controls.Add(this.label20);
            this.gbxAcciones.Controls.Add(this.label21);
            this.gbxAcciones.Controls.Add(this.btnBuscarProforma);
            this.gbxAcciones.Controls.Add(this.label18);
            this.gbxAcciones.Controls.Add(this.label17);
            this.gbxAcciones.Controls.Add(this.label16);
            this.gbxAcciones.Controls.Add(this.label15);
            this.gbxAcciones.Controls.Add(this.label14);
            this.gbxAcciones.Controls.Add(this.btnValidacion);
            this.gbxAcciones.Controls.Add(this.label13);
            this.gbxAcciones.Controls.Add(this.label12);
            this.gbxAcciones.Controls.Add(this.label11);
            this.gbxAcciones.Controls.Add(this.label10);
            this.gbxAcciones.Controls.Add(this.btnProductos);
            this.gbxAcciones.Controls.Add(this.btnClientes);
            this.gbxAcciones.Controls.Add(this.btnBuscarFactura);
            this.gbxAcciones.Controls.Add(this.btnLimpiarForm);
            this.gbxAcciones.Location = new System.Drawing.Point(744, 7);
            this.gbxAcciones.Name = "gbxAcciones";
            this.gbxAcciones.Size = new System.Drawing.Size(598, 155);
            this.gbxAcciones.TabIndex = 50;
            this.gbxAcciones.TabStop = false;
            this.gbxAcciones.Text = "Acciones";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Gray;
            this.label22.Location = new System.Drawing.Point(82, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 17);
            this.label22.TabIndex = 62;
            this.label22.Text = "Re-imprimir";
            // 
            // btnReImprimir
            // 
            this.btnReImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReImprimir.ForeColor = System.Drawing.Color.Transparent;
            this.btnReImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnReImprimir.Image")));
            this.btnReImprimir.Location = new System.Drawing.Point(85, 45);
            this.btnReImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnReImprimir.Name = "btnReImprimir";
            this.btnReImprimir.Size = new System.Drawing.Size(70, 70);
            this.btnReImprimir.TabIndex = 61;
            this.btnReImprimir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReImprimir.UseVisualStyleBackColor = true;
            this.btnReImprimir.Click += new System.EventHandler(this.btnReImprimir_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(229, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 17);
            this.label20.TabIndex = 60;
            this.label20.Text = "F2";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(207, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 15);
            this.label21.TabIndex = 59;
            this.label21.Text = "Proformas";
            // 
            // btnBuscarProforma
            // 
            this.btnBuscarProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProforma.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProforma.Image")));
            this.btnBuscarProforma.Location = new System.Drawing.Point(204, 46);
            this.btnBuscarProforma.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProforma.Name = "btnBuscarProforma";
            this.btnBuscarProforma.Size = new System.Drawing.Size(70, 70);
            this.btnBuscarProforma.TabIndex = 58;
            this.btnBuscarProforma.UseVisualStyleBackColor = true;
            this.btnBuscarProforma.Click += new System.EventHandler(this.btnBuscarProforma_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(304, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 17);
            this.label18.TabIndex = 57;
            this.label18.Text = "F3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(529, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 56;
            this.label17.Text = "F7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(379, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 17);
            this.label16.TabIndex = 55;
            this.label16.Text = "F4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(453, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 54;
            this.label15.Text = "F5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(505, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "Hacienda";
            // 
            // btnValidacion
            // 
            this.btnValidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacion.Image = ((System.Drawing.Image)(resources.GetObject("btnValidacion.Image")));
            this.btnValidacion.Location = new System.Drawing.Point(504, 45);
            this.btnValidacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(70, 70);
            this.btnValidacion.TabIndex = 52;
            this.btnValidacion.UseVisualStyleBackColor = true;
            this.btnValidacion.Click += new System.EventHandler(this.btnValidacion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(353, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 51;
            this.label13.Text = "Productos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(435, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 50;
            this.label12.Text = "Clientes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(274, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 15);
            this.label11.TabIndex = 49;
            this.label11.Text = "Documentos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(14, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Limpiar";
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(354, 46);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(70, 70);
            this.btnProductos.TabIndex = 47;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(429, 46);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(70, 70);
            this.btnClientes.TabIndex = 46;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo2.Location = new System.Drawing.Point(99, 97);
            this.txtCorreo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo2.MaxLength = 50;
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(560, 27);
            this.txtCorreo2.TabIndex = 51;
            // 
            // chkEnviar
            // 
            this.chkEnviar.AutoSize = true;
            this.chkEnviar.Checked = true;
            this.chkEnviar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviar.Location = new System.Drawing.Point(345, 39);
            this.chkEnviar.Name = "chkEnviar";
            this.chkEnviar.Size = new System.Drawing.Size(262, 28);
            this.chkEnviar.TabIndex = 52;
            this.chkEnviar.Text = "Notificar Correo Electrónico";
            this.chkEnviar.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(12, 97);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 20);
            this.label19.TabIndex = 53;
            this.label19.Text = "Correo 2:";
            // 
            // frmFacturacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1397, 702);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.chkEnviar);
            this.Controls.Add(this.txtCorreo2);
            this.Controls.Add(this.gbxAcciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.gbxMontos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFacturacion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proceso: Facturación";
            this.Load += new System.EventHandler(this.frmFacturacion1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleFactura)).EndInit();
            this.gbxMontos.ResumeLayout(false);
            this.gbxMontos.PerformLayout();
            this.gbxAcciones.ResumeLayout(false);
            this.gbxAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.GroupBox gbxMontos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPorcetaje;
        private System.Windows.Forms.Button btnProforma;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dtgvDetalleFactura;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.Label lblTotalProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidadLineas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxAcciones;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.CheckBox chkEnviar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtExoneracion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnValidacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnBuscarProforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewLinkColumn colEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnReImprimir;
    }
}