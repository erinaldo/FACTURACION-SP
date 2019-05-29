namespace PresentationLayer
{
    partial class frmBuscarProveedores
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
            this.gboBuscar = new System.Windows.Forms.GroupBox();
            this.lstvProveedores = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboBuscar
            // 
            this.gboBuscar.Controls.Add(this.lstvProveedores);
            this.gboBuscar.Controls.Add(this.txtBuscar);
            this.gboBuscar.Controls.Add(this.btnSeleccionar);
            this.gboBuscar.Location = new System.Drawing.Point(12, 12);
            this.gboBuscar.Name = "gboBuscar";
            this.gboBuscar.Size = new System.Drawing.Size(390, 337);
            this.gboBuscar.TabIndex = 0;
            this.gboBuscar.TabStop = false;
            this.gboBuscar.Text = "Buscar";
            // 
            // lstvProveedores
            // 
            this.lstvProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTipoId,
            this.colNombre,
            this.colEstado});
            this.lstvProveedores.FullRowSelect = true;
            this.lstvProveedores.GridLines = true;
            this.lstvProveedores.Location = new System.Drawing.Point(6, 60);
            this.lstvProveedores.Name = "lstvProveedores";
            this.lstvProveedores.Size = new System.Drawing.Size(384, 208);
            this.lstvProveedores.TabIndex = 8;
            this.lstvProveedores.UseCompatibleStateImageBehavior = false;
            this.lstvProveedores.View = System.Windows.Forms.View.Details;
            this.lstvProveedores.SelectedIndexChanged += new System.EventHandler(this.lstvProveedores_SelectedIndexChanged);
            this.lstvProveedores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvProveedores_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = " ID";
            this.colId.Width = 130;
            // 
            // colTipoId
            // 
            this.colTipoId.Text = "Tipo ID";
            this.colTipoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTipoId.Width = 49;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 127;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(378, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(312, 274);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(72, 57);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.gboBuscar);
            this.Name = "frmBuscarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscarProveedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerraFormBuscar);
            this.Load += new System.EventHandler(this.frmBuscarProveedores_Load);
            this.gboBuscar.ResumeLayout(false);
            this.gboBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboBuscar;
        private System.Windows.Forms.ListView lstvProveedores;
        private System.Windows.Forms.ColumnHeader colTipoId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colEstado;
    }
}