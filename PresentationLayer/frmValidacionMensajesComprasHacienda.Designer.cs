namespace PresentationLayer
{
    partial class frmValidacionMensajesComprasHacienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmValidacionMensajesComprasHacienda));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dtgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnValidarTodos = new System.Windows.Forms.Button();
            this.gbxFechas = new System.Windows.Forms.GroupBox();
            this.chkFechas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdRecept = new System.Windows.Forms.TextBox();
            this.txtClaveRecept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConseRecept = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClaveEmisor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreEmisor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdEmisor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkInconsistentes = new System.Windows.Forms.CheckBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colIdTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRespHacienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCorreo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colValidar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleFactura)).BeginInit();
            this.gbxFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "al";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(355, 26);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(191, 22);
            this.dtpFechaFin.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(129, 26);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(191, 22);
            this.dtpFechaInicio.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.dtgvDetalleFactura);
            this.groupBox1.Location = new System.Drawing.Point(13, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1644, 567);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensajes";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(594, 220);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 40);
            this.progressBar1.TabIndex = 43;
            // 
            // dtgvDetalleFactura
            // 
            this.dtgvDetalleFactura.AllowUserToOrderColumns = true;
            this.dtgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdTipoDoc,
            this.colFecha,
            this.colClave,
            this.colFechaEmision,
            this.colCliente,
            this.colEnvio,
            this.colRespHacienda,
            this.colDetalle,
            this.colCorreo,
            this.colValidar});
            this.dtgvDetalleFactura.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgvDetalleFactura.Location = new System.Drawing.Point(15, 23);
            this.dtgvDetalleFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDetalleFactura.MultiSelect = false;
            this.dtgvDetalleFactura.Name = "dtgvDetalleFactura";
            this.dtgvDetalleFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDetalleFactura.Size = new System.Drawing.Size(1616, 526);
            this.dtgvDetalleFactura.TabIndex = 22;
            this.dtgvDetalleFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDetalleFactura_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(824, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 38;
            this.label3.Text = "Compras";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(1301, 100);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(64, 63);
            this.btnRefrescar.TabIndex = 36;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(1229, 99);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 63);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnValidarTodos
            // 
            this.btnValidarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarTodos.Image")));
            this.btnValidarTodos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidarTodos.Location = new System.Drawing.Point(1373, 96);
            this.btnValidarTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidarTodos.Name = "btnValidarTodos";
            this.btnValidarTodos.Size = new System.Drawing.Size(109, 72);
            this.btnValidarTodos.TabIndex = 42;
            this.btnValidarTodos.Text = "Validar Todo";
            this.btnValidarTodos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnValidarTodos.UseVisualStyleBackColor = true;
            this.btnValidarTodos.Click += new System.EventHandler(this.btnValidarTodos_Click);
            // 
            // gbxFechas
            // 
            this.gbxFechas.Controls.Add(this.label1);
            this.gbxFechas.Controls.Add(this.dtpFechaInicio);
            this.gbxFechas.Controls.Add(this.dtpFechaFin);
            this.gbxFechas.Controls.Add(this.label2);
            this.gbxFechas.Location = new System.Drawing.Point(28, 27);
            this.gbxFechas.Name = "gbxFechas";
            this.gbxFechas.Size = new System.Drawing.Size(572, 62);
            this.gbxFechas.TabIndex = 43;
            this.gbxFechas.TabStop = false;
            // 
            // chkFechas
            // 
            this.chkFechas.AutoSize = true;
            this.chkFechas.Checked = true;
            this.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFechas.Location = new System.Drawing.Point(28, 12);
            this.chkFechas.Name = "chkFechas";
            this.chkFechas.Size = new System.Drawing.Size(76, 21);
            this.chkFechas.TabIndex = 44;
            this.chkFechas.Text = "Fechas";
            this.chkFechas.UseVisualStyleBackColor = true;
            this.chkFechas.CheckedChanged += new System.EventHandler(this.chkFechas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "ID Doc Receptor:";
            // 
            // txtIdRecept
            // 
            this.txtIdRecept.Location = new System.Drawing.Point(181, 96);
            this.txtIdRecept.Name = "txtIdRecept";
            this.txtIdRecept.Size = new System.Drawing.Size(361, 22);
            this.txtIdRecept.TabIndex = 46;
            // 
            // txtClaveRecept
            // 
            this.txtClaveRecept.Location = new System.Drawing.Point(181, 124);
            this.txtClaveRecept.Name = "txtClaveRecept";
            this.txtClaveRecept.Size = new System.Drawing.Size(361, 22);
            this.txtClaveRecept.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Clave Receptor:";
            // 
            // txtConseRecept
            // 
            this.txtConseRecept.Location = new System.Drawing.Point(181, 152);
            this.txtConseRecept.Name = "txtConseRecept";
            this.txtConseRecept.Size = new System.Drawing.Size(361, 22);
            this.txtConseRecept.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Consecutivo Receptor:";
            // 
            // txtClaveEmisor
            // 
            this.txtClaveEmisor.Location = new System.Drawing.Point(682, 152);
            this.txtClaveEmisor.Name = "txtClaveEmisor";
            this.txtClaveEmisor.Size = new System.Drawing.Size(361, 22);
            this.txtClaveEmisor.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Clave Emisor:";
            // 
            // txtNombreEmisor
            // 
            this.txtNombreEmisor.Location = new System.Drawing.Point(682, 124);
            this.txtNombreEmisor.Name = "txtNombreEmisor";
            this.txtNombreEmisor.Size = new System.Drawing.Size(361, 22);
            this.txtNombreEmisor.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(567, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nombre Emisor:";
            // 
            // txtIdEmisor
            // 
            this.txtIdEmisor.Location = new System.Drawing.Point(682, 96);
            this.txtIdEmisor.Name = "txtIdEmisor";
            this.txtIdEmisor.Size = new System.Drawing.Size(361, 22);
            this.txtIdEmisor.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "ID Emisor:";
            // 
            // chkInconsistentes
            // 
            this.chkInconsistentes.AutoSize = true;
            this.chkInconsistentes.Checked = true;
            this.chkInconsistentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInconsistentes.Location = new System.Drawing.Point(1067, 95);
            this.chkInconsistentes.Name = "chkInconsistentes";
            this.chkInconsistentes.Size = new System.Drawing.Size(120, 21);
            this.chkInconsistentes.TabIndex = 59;
            this.chkInconsistentes.Text = "Inconsistentes";
            this.chkInconsistentes.UseVisualStyleBackColor = true;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(682, 180);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(361, 22);
            this.txtArchivo.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 62;
            this.label7.Text = "Nombre Archivo:";
            // 
            // colIdTipoDoc
            // 
            this.colIdTipoDoc.HeaderText = "ID Receptor";
            this.colIdTipoDoc.Name = "colIdTipoDoc";
            this.colIdTipoDoc.ReadOnly = true;
            this.colIdTipoDoc.Width = 50;
            // 
            // colFecha
            // 
            this.colFecha.FillWeight = 115F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 115;
            // 
            // colClave
            // 
            this.colClave.FillWeight = 130F;
            this.colClave.HeaderText = "Consecutivo Receptor";
            this.colClave.Name = "colClave";
            this.colClave.ReadOnly = true;
            this.colClave.Width = 130;
            // 
            // colFechaEmision
            // 
            this.colFechaEmision.FillWeight = 115F;
            this.colFechaEmision.HeaderText = "Fecha Emisión";
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.Width = 115;
            // 
            // colCliente
            // 
            this.colCliente.FillWeight = 275F;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 275;
            // 
            // colEnvio
            // 
            this.colEnvio.FillWeight = 115F;
            this.colEnvio.HeaderText = "Estado Envio";
            this.colEnvio.Name = "colEnvio";
            this.colEnvio.ReadOnly = true;
            this.colEnvio.Width = 115;
            // 
            // colRespHacienda
            // 
            this.colRespHacienda.FillWeight = 115F;
            this.colRespHacienda.HeaderText = "Estado Hacienda";
            this.colRespHacienda.Name = "colRespHacienda";
            this.colRespHacienda.ReadOnly = true;
            this.colRespHacienda.Width = 115;
            // 
            // colDetalle
            // 
            this.colDetalle.FillWeight = 75F;
            this.colDetalle.HeaderText = "";
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Width = 75;
            // 
            // colCorreo
            // 
            this.colCorreo.FillWeight = 75F;
            this.colCorreo.HeaderText = "";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.ReadOnly = true;
            this.colCorreo.Width = 75;
            // 
            // colValidar
            // 
            this.colValidar.HeaderText = "";
            this.colValidar.Name = "colValidar";
            this.colValidar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colValidar.Text = "Validar";
            this.colValidar.ToolTipText = "Validar";
            this.colValidar.UseColumnTextForButtonValue = true;
            // 
            // frmValidacionMensajesComprasHacienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 779);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.chkInconsistentes);
            this.Controls.Add(this.txtClaveEmisor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNombreEmisor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIdEmisor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtConseRecept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClaveRecept);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdRecept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFechas);
            this.Controls.Add(this.gbxFechas);
            this.Controls.Add(this.btnValidarTodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmValidacionMensajesComprasHacienda";
            this.Text = "Consulta: Estado de mensajes de compras Hacienda";
            this.Load += new System.EventHandler(this.frmValidacionMensajesComprasHacienda_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalleFactura)).EndInit();
            this.gbxFechas.ResumeLayout(false);
            this.gbxFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDetalleFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnValidarTodos;
        private System.Windows.Forms.GroupBox gbxFechas;
        private System.Windows.Forms.CheckBox chkFechas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdRecept;
        private System.Windows.Forms.TextBox txtClaveRecept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConseRecept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClaveEmisor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreEmisor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdEmisor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkInconsistentes;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRespHacienda;
        private System.Windows.Forms.DataGridViewLinkColumn colDetalle;
        private System.Windows.Forms.DataGridViewLinkColumn colCorreo;
        private System.Windows.Forms.DataGridViewButtonColumn colValidar;
    }
}