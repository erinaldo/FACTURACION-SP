namespace PresentationLayer
{
    partial class frmBuscarDetalleIngrediente
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
            this.txtBuscarIngrediente = new System.Windows.Forms.TextBox();
            this.lstvDetalleIngrediente = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIngrediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(256, 360);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(90, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Aceptar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtBuscarIngrediente
            // 
            this.txtBuscarIngrediente.Location = new System.Drawing.Point(12, 33);
            this.txtBuscarIngrediente.Name = "txtBuscarIngrediente";
            this.txtBuscarIngrediente.Size = new System.Drawing.Size(334, 20);
            this.txtBuscarIngrediente.TabIndex = 4;
            this.txtBuscarIngrediente.TextChanged += new System.EventHandler(this.txtBuscarIngrediente_TextChanged);
            // 
            // lstvDetalleIngrediente
            // 
            this.lstvDetalleIngrediente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colIngrediente,
            this.colEstado});
            this.lstvDetalleIngrediente.FullRowSelect = true;
            this.lstvDetalleIngrediente.GridLines = true;
            this.lstvDetalleIngrediente.Location = new System.Drawing.Point(12, 76);
            this.lstvDetalleIngrediente.Name = "lstvDetalleIngrediente";
            this.lstvDetalleIngrediente.Size = new System.Drawing.Size(334, 278);
            this.lstvDetalleIngrediente.TabIndex = 3;
            this.lstvDetalleIngrediente.UseCompatibleStateImageBehavior = false;
            this.lstvDetalleIngrediente.View = System.Windows.Forms.View.Details;
            this.lstvDetalleIngrediente.SelectedIndexChanged += new System.EventHandler(this.lstvDetalleIngrediente_SelectedIndexChanged);
            this.lstvDetalleIngrediente.DoubleClick += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 42;
            // 
            // colIngrediente
            // 
            this.colIngrediente.Text = "Ingrediente";
            this.colIngrediente.Width = 191;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 102;
            // 
            // frmBuscarDetalleIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 401);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtBuscarIngrediente);
            this.Controls.Add(this.lstvDetalleIngrediente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarDetalleIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBuscarDetalleIngrediente_FormClosed);
            this.Load += new System.EventHandler(this.frmBuscarDetalleIngrediente_Load);
            this.DoubleClick += new System.EventHandler(this.frmBuscarDetalleIngrediente_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtBuscarIngrediente;
        private System.Windows.Forms.ListView lstvDetalleIngrediente;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colIngrediente;
        private System.Windows.Forms.ColumnHeader colEstado;
    }
}