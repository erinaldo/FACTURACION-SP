namespace PresentationLayer
{
    partial class frmBuscarTipoIngrediente
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
            this.lstvTipoIngred = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstvTipoIngred
            // 
            this.lstvTipoIngred.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colEstado});
            this.lstvTipoIngred.FullRowSelect = true;
            this.lstvTipoIngred.GridLines = true;
            this.lstvTipoIngred.Location = new System.Drawing.Point(25, 50);
            this.lstvTipoIngred.MultiSelect = false;
            this.lstvTipoIngred.Name = "lstvTipoIngred";
            this.lstvTipoIngred.Size = new System.Drawing.Size(255, 150);
            this.lstvTipoIngred.TabIndex = 16;
            this.lstvTipoIngred.UseCompatibleStateImageBehavior = false;
            this.lstvTipoIngred.View = System.Windows.Forms.View.Details;
            this.lstvTipoIngred.SelectedIndexChanged += new System.EventHandler(this.lstvTipoIngred_SelectedIndexChanged);
            this.lstvTipoIngred.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvTipoIngred_DoubleClick);
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
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(205, 218);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 15;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(25, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // frmBuscarTipoIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 265);
            this.Controls.Add(this.lstvTipoIngred);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmBuscarTipoIngrediente";
            this.Text = "frmBuscarTipoIngrediente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarForm);
            this.Load += new System.EventHandler(this.frmBuscarTipoIngrediente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstvTipoIngred;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}