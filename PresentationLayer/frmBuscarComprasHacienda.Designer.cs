namespace PresentationLayer
{
    partial class frmBuscarComprasHacienda
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lstvReportes = new System.Windows.Forms.ListView();
            this.Clave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaEmision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(1137, 277);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 28);
            this.btnSeleccionar.TabIndex = 4;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lstvReportes
            // 
            this.lstvReportes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clave,
            this.fechaEmision,
            this.Id,
            this.colNombre,
            this.colImp,
            this.colFact});
            this.lstvReportes.FullRowSelect = true;
            this.lstvReportes.GridLines = true;
            this.lstvReportes.Location = new System.Drawing.Point(13, 62);
            this.lstvReportes.Margin = new System.Windows.Forms.Padding(4);
            this.lstvReportes.Name = "lstvReportes";
            this.lstvReportes.Size = new System.Drawing.Size(1224, 208);
            this.lstvReportes.TabIndex = 3;
            this.lstvReportes.UseCompatibleStateImageBehavior = false;
            this.lstvReportes.View = System.Windows.Forms.View.Details;
            this.lstvReportes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvReportes_MouseDoubleClick);
            // 
            // Clave
            // 
            this.Clave.Text = "Clave";
            this.Clave.Width = 209;
            // 
            // fechaEmision
            // 
            this.fechaEmision.Text = "Fecha Emisión";
            this.fechaEmision.Width = 106;
            // 
            // Id
            // 
            this.Id.Text = "Identificación";
            this.Id.Width = 99;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Empresa Emisor";
            this.colNombre.Width = 282;
            // 
            // colImp
            // 
            this.colImp.Text = "Impuestos";
            this.colImp.Width = 112;
            // 
            // colFact
            // 
            this.colFact.Text = "Total Facturado";
            this.colFact.Width = 122;
            // 
            // frmBuscarComprasHacienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 318);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lstvReportes);
            this.Name = "frmBuscarComprasHacienda";
            this.Text = "frmBuscarComprasHacienda";
            this.Load += new System.EventHandler(this.frmBuscarComprasHacienda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ListView lstvReportes;
        private System.Windows.Forms.ColumnHeader Clave;
        private System.Windows.Forms.ColumnHeader fechaEmision;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colImp;
        private System.Windows.Forms.ColumnHeader colFact;
    }
}