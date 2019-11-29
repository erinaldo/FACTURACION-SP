namespace PresentationLayer
{
    partial class buscarAct
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lsvbuscar = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipocliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 13);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(526, 22);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lsvbuscar
            // 
            this.lsvbuscar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTipocliente});
            this.lsvbuscar.FullRowSelect = true;
            this.lsvbuscar.GridLines = true;
            this.lsvbuscar.HideSelection = false;
            this.lsvbuscar.HoverSelection = true;
            this.lsvbuscar.Location = new System.Drawing.Point(13, 45);
            this.lsvbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.lsvbuscar.MultiSelect = false;
            this.lsvbuscar.Name = "lsvbuscar";
            this.lsvbuscar.Size = new System.Drawing.Size(731, 243);
            this.lsvbuscar.TabIndex = 3;
            this.lsvbuscar.UseCompatibleStateImageBehavior = false;
            this.lsvbuscar.View = System.Windows.Forms.View.Details;
            this.lsvbuscar.SelectedIndexChanged += new System.EventHandler(this.lsvbuscar_SelectedIndexChanged);
            this.lsvbuscar.DoubleClick += new System.EventHandler(this.lsvbuscar_DoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "Código Act";
            this.colId.Width = 86;
            // 
            // colTipocliente
            // 
            this.colTipocliente.Text = "Nombre";
            this.colTipocliente.Width = 650;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(644, 291);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(100, 28);
            this.btnseleccionar.TabIndex = 5;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // frmBuscarActividadEconomica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 332);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lsvbuscar);
            this.Name = "frmBuscarActividadEconomica";
            this.Text = "Buscar: Actividad Económica";
            this.Load += new System.EventHandler(this.frmBuscarActividadEconomica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListView lsvbuscar;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTipocliente;
        private System.Windows.Forms.Button btnseleccionar;
    }
}