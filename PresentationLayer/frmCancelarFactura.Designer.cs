namespace PresentationLayer
{
    partial class frmCancelarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarFactura));
            this.lstvCancelarFac = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstadoFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvCancelarFac
            // 
            this.lstvCancelarFac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colCliente,
            this.colTipoPago,
            this.colTotal,
            this.colEstadoFactura});
            this.lstvCancelarFac.FullRowSelect = true;
            this.lstvCancelarFac.Location = new System.Drawing.Point(12, 85);
            this.lstvCancelarFac.Name = "lstvCancelarFac";
            this.lstvCancelarFac.Size = new System.Drawing.Size(459, 286);
            this.lstvCancelarFac.TabIndex = 0;
            this.lstvCancelarFac.UseCompatibleStateImageBehavior = false;
            this.lstvCancelarFac.View = System.Windows.Forms.View.Details;
            this.lstvCancelarFac.SelectedIndexChanged += new System.EventHandler(this.lstvCancelarFac_SelectedIndexChanged);
            this.lstvCancelarFac.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvCancelarFac_MouseDoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 37;
            // 
            // colCliente
            // 
            this.colCliente.Text = "Cliente";
            this.colCliente.Width = 171;
            // 
            // colTipoPago
            // 
            this.colTipoPago.Text = "Tipo Pago";
            this.colTipoPago.Width = 98;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.Width = 86;
            // 
            // colEstadoFactura
            // 
            this.colEstadoFactura.Text = "Estado";
            this.colEstadoFactura.Width = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(339, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(16, 13);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "...";
            // 
            // bntEliminar
            // 
            this.bntEliminar.FlatAppearance.BorderSize = 0;
            this.bntEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bntEliminar.Image")));
            this.bntEliminar.Location = new System.Drawing.Point(12, 12);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(53, 55);
            this.bntEliminar.TabIndex = 3;
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.FlatAppearance.BorderSize = 0;
            this.btnImprimirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirFactura.Image")));
            this.btnImprimirFactura.Location = new System.Drawing.Point(71, 12);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(59, 55);
            this.btnImprimirFactura.TabIndex = 4;
            this.btnImprimirFactura.UseVisualStyleBackColor = true;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // frmCancelarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 383);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvCancelarFac);
            this.Name = "frmCancelarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar factura";
            this.Load += new System.EventHandler(this.frmCancelarFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvCancelarFac;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colCliente;
        private System.Windows.Forms.ColumnHeader colTipoPago;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colEstadoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button bntEliminar;
        private System.Windows.Forms.Button btnImprimirFactura;
    }
}