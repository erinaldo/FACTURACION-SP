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
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.gboBuscar.Location = new System.Drawing.Point(16, 15);
            this.gboBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBuscar.Name = "gboBuscar";
            this.gboBuscar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboBuscar.Size = new System.Drawing.Size(536, 349);
            this.gboBuscar.TabIndex = 0;
            this.gboBuscar.TabStop = false;
            this.gboBuscar.Text = "Buscar";
            // 
            // lstvProveedores
            // 
            this.lstvProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre});
            this.lstvProveedores.FullRowSelect = true;
            this.lstvProveedores.GridLines = true;
            this.lstvProveedores.Location = new System.Drawing.Point(8, 74);
            this.lstvProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstvProveedores.Name = "lstvProveedores";
            this.lstvProveedores.Size = new System.Drawing.Size(511, 255);
            this.lstvProveedores.TabIndex = 8;
            this.lstvProveedores.UseCompatibleStateImageBehavior = false;
            this.lstvProveedores.View = System.Windows.Forms.View.Details;
            this.lstvProveedores.SelectedIndexChanged += new System.EventHandler(this.lstvProveedores_SelectedIndexChanged);
            this.lstvProveedores.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvProveedores_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = " ID";
            this.colId.Width = 100;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 350;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(8, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(503, 22);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(456, 372);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(96, 39);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 422);
            this.Controls.Add(this.gboBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader colId;
    }
}