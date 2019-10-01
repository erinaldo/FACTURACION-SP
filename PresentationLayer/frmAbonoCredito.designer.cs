namespace PresentationLayer
{
    partial class frmAbonoCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbonoCredito));
            this.gbxCredito = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacturado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdeudado = new System.Windows.Forms.TextBox();
            this.lsvFacturas = new System.Windows.Forms.ListView();
            this.colChk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConsecutivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMontoTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdeudado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaVencimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.gbxCredito.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCredito
            // 
            this.gbxCredito.Controls.Add(this.label9);
            this.gbxCredito.Controls.Add(this.txtPendiente);
            this.gbxCredito.Controls.Add(this.chkImprimir);
            this.gbxCredito.Controls.Add(this.label8);
            this.gbxCredito.Controls.Add(this.btnProcesar);
            this.gbxCredito.Controls.Add(this.chkTodos);
            this.gbxCredito.Controls.Add(this.label7);
            this.gbxCredito.Controls.Add(this.txtFacturado);
            this.gbxCredito.Controls.Add(this.label6);
            this.gbxCredito.Controls.Add(this.txtAbono);
            this.gbxCredito.Controls.Add(this.label4);
            this.gbxCredito.Controls.Add(this.txtAdeudado);
            this.gbxCredito.Controls.Add(this.lsvFacturas);
            this.gbxCredito.Location = new System.Drawing.Point(12, 199);
            this.gbxCredito.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCredito.Name = "gbxCredito";
            this.gbxCredito.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCredito.Size = new System.Drawing.Size(1013, 528);
            this.gbxCredito.TabIndex = 1;
            this.gbxCredito.TabStop = false;
            this.gbxCredito.Text = "Créditos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(571, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 89;
            this.label9.Text = "Pendiente:";
            // 
            // txtPendiente
            // 
            this.txtPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendiente.Location = new System.Drawing.Point(697, 387);
            this.txtPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.ReadOnly = true;
            this.txtPendiente.Size = new System.Drawing.Size(288, 28);
            this.txtPendiente.TabIndex = 88;
            // 
            // chkImprimir
            // 
            this.chkImprimir.AutoSize = true;
            this.chkImprimir.Checked = true;
            this.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImprimir.Location = new System.Drawing.Point(642, 477);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(217, 24);
            this.chkImprimir.TabIndex = 87;
            this.chkImprimir.Text = "Imprimir Comprobante";
            this.chkImprimir.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(737, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 17);
            this.label8.TabIndex = 84;
            this.label8.Text = "En color rojo los documentos Vencidos";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.Location = new System.Drawing.Point(891, 440);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(99, 80);
            this.btnProcesar.TabIndex = 83;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(31, 23);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(70, 21);
            this.chkTodos.TabIndex = 86;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "Total Facturado:";
            // 
            // txtFacturado
            // 
            this.txtFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturado.Location = new System.Drawing.Point(198, 313);
            this.txtFacturado.Margin = new System.Windows.Forms.Padding(4);
            this.txtFacturado.Name = "txtFacturado";
            this.txtFacturado.ReadOnly = true;
            this.txtFacturado.Size = new System.Drawing.Size(288, 28);
            this.txtFacturado.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(604, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 76;
            this.label6.Text = "Abono:";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(697, 351);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(288, 28);
            this.txtAbono.TabIndex = 75;
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Monto Adeudado:";
            // 
            // txtAdeudado
            // 
            this.txtAdeudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdeudado.Location = new System.Drawing.Point(697, 315);
            this.txtAdeudado.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdeudado.Name = "txtAdeudado";
            this.txtAdeudado.ReadOnly = true;
            this.txtAdeudado.Size = new System.Drawing.Size(288, 28);
            this.txtAdeudado.TabIndex = 73;
            // 
            // lsvFacturas
            // 
            this.lsvFacturas.CheckBoxes = true;
            this.lsvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colChk,
            this.colIdFactura,
            this.colFecha,
            this.colConsecutivo,
            this.colMontoTotal,
            this.colAdeudado,
            this.colFechaVencimiento});
            this.lsvFacturas.FullRowSelect = true;
            this.lsvFacturas.GridLines = true;
            this.lsvFacturas.HoverSelection = true;
            this.lsvFacturas.Location = new System.Drawing.Point(21, 52);
            this.lsvFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.lsvFacturas.Name = "lsvFacturas";
            this.lsvFacturas.Size = new System.Drawing.Size(969, 253);
            this.lsvFacturas.TabIndex = 2;
            this.lsvFacturas.UseCompatibleStateImageBehavior = false;
            this.lsvFacturas.View = System.Windows.Forms.View.Details;
            this.lsvFacturas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lsvFacturas_ItemCheck);
            this.lsvFacturas.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsvFacturas_ItemChecked);
            // 
            // colChk
            // 
            this.colChk.Text = "";
            this.colChk.Width = 30;
            // 
            // colIdFactura
            // 
            this.colIdFactura.Text = "Factura #";
            this.colIdFactura.Width = 70;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 120;
            // 
            // colConsecutivo
            // 
            this.colConsecutivo.Text = "Consecutivo";
            this.colConsecutivo.Width = 137;
            // 
            // colMontoTotal
            // 
            this.colMontoTotal.Text = "TotalFacturado";
            this.colMontoTotal.Width = 100;
            // 
            // colAdeudado
            // 
            this.colAdeudado.Text = "Adeudado";
            this.colAdeudado.Width = 100;
            // 
            // colFechaVencimiento
            // 
            this.colFechaVencimiento.Text = "Fecha Vencimiento";
            this.colFechaVencimiento.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtIdCliente);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1014, 180);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(775, 21);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 70);
            this.btnLimpiar.TabIndex = 83;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(107, 105);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.MaxLength = 500;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(571, 58);
            this.txtDireccion.TabIndex = 74;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(697, 21);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(70, 70);
            this.btnBuscarCliente.TabIndex = 82;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Cliente:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(107, 77);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(359, 22);
            this.txtCorreo.TabIndex = 60;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(107, 49);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(209, 22);
            this.txtTel.TabIndex = 58;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(107, 21);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(209, 22);
            this.txtIdCliente.TabIndex = 55;
            this.txtIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdCliente_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(325, 21);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(353, 22);
            this.txtCliente.TabIndex = 53;
            // 
            // frmAbonoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 740);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxCredito);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAbonoCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso: Cuentas por Cobras(Abonos)";
            this.Load += new System.EventHandler(this.frmCredito_Load);
            this.gbxCredito.ResumeLayout(false);
            this.gbxCredito.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxCredito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ListView lsvFacturas;
        private System.Windows.Forms.ColumnHeader colIdFactura;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colConsecutivo;
        private System.Windows.Forms.ColumnHeader colMontoTotal;
        private System.Windows.Forms.ColumnHeader colAdeudado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdeudado;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFacturado;
        private System.Windows.Forms.ColumnHeader colFechaVencimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.ColumnHeader colChk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPendiente;
    }
}