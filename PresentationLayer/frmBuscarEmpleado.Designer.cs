namespace PresentationLayer
{
    partial class frmBuscarEmpleado
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
            this.lstvEmpleados = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvEmpleados
            // 
            this.lstvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Estado});
            this.lstvEmpleados.FullRowSelect = true;
            this.lstvEmpleados.GridLines = true;
            this.lstvEmpleados.Location = new System.Drawing.Point(16, 47);
            this.lstvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.lstvEmpleados.Name = "lstvEmpleados";
            this.lstvEmpleados.Size = new System.Drawing.Size(480, 208);
            this.lstvEmpleados.TabIndex = 0;
            this.lstvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lstvEmpleados.View = System.Windows.Forms.View.Details;
            this.lstvEmpleados.SelectedIndexChanged += new System.EventHandler(this.lstvEmpleados_SelectedIndexChanged);
            this.lstvEmpleados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvEmpleados_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 92;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 230;
            // 
            // Estado
            // 
            this.Estado.Text = "Estado";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(16, 15);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(480, 22);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(16, 263);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 28);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 306);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lstvEmpleados);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarEmpleado";
            this.Text = "FrmBuscarCliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarForm);
            this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvEmpleados;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ColumnHeader Estado;
    }
}