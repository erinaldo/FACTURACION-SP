namespace PresentationLayer
{
    partial class frmBuscarTipoCliente
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
            this.lstvTipoCliente = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvTipoCliente
            // 
            this.lstvTipoCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colEstado});
            this.lstvTipoCliente.FullRowSelect = true;
            this.lstvTipoCliente.GridLines = true;
            this.lstvTipoCliente.Location = new System.Drawing.Point(5, 38);
            this.lstvTipoCliente.MultiSelect = false;
            this.lstvTipoCliente.Name = "lstvTipoCliente";
            this.lstvTipoCliente.Size = new System.Drawing.Size(255, 150);
            this.lstvTipoCliente.TabIndex = 4;
            this.lstvTipoCliente.UseCompatibleStateImageBehavior = false;
            this.lstvTipoCliente.View = System.Windows.Forms.View.Details;
            this.lstvTipoCliente.SelectedIndexChanged += new System.EventHandler(this.lstvTipoCliente_SelectedIndexChanged);
            this.lstvTipoCliente.DoubleClick += new System.EventHandler(this.lstvTipoCliente_SelectedIndexChanged);
            this.lstvTipoCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvTipoCliente_DoubleClickMouse);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 39;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 138;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 69;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(5, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(172, 222);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 7;
            this.btnEjecutar.Text = "Seleccionar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmBuscarTipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 252);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstvTipoCliente);
            this.Name = "frmBuscarTipoCliente";
            this.Text = "BuscarTipoCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarform);
            this.Load += new System.EventHandler(this.BuscarTipoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvTipoCliente;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEjecutar;
    }
}