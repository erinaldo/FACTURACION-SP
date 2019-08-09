namespace PresentationLayer
{
    partial class frmBuscarCategoriaProducto
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
            this.txtCategoriaProducto = new System.Windows.Forms.TextBox();
            this.lstvCategoriaProductos = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.Location = new System.Drawing.Point(9, 10);
            this.txtCategoriaProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(152, 20);
            this.txtCategoriaProducto.TabIndex = 0;
            this.txtCategoriaProducto.TextChanged += new System.EventHandler(this.txtCategoriaProducto_TextChanged);
            // 
            // lstvCategoriaProductos
            // 
            this.lstvCategoriaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNombre,
            this.colEstado});
            this.lstvCategoriaProductos.FullRowSelect = true;
            this.lstvCategoriaProductos.Location = new System.Drawing.Point(9, 33);
            this.lstvCategoriaProductos.Margin = new System.Windows.Forms.Padding(2);
            this.lstvCategoriaProductos.Name = "lstvCategoriaProductos";
            this.lstvCategoriaProductos.Size = new System.Drawing.Size(386, 213);
            this.lstvCategoriaProductos.TabIndex = 1;
            this.lstvCategoriaProductos.UseCompatibleStateImageBehavior = false;
            this.lstvCategoriaProductos.View = System.Windows.Forms.View.Details;
            this.lstvCategoriaProductos.SelectedIndexChanged += new System.EventHandler(this.lstvCategoriaProductos_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 42;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 193;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 91;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(270, 250);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(83, 32);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 250);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBuscarCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 301);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.lstvCategoriaProductos);
            this.Controls.Add(this.txtCategoriaProducto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscarCategoriaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuscarCategoriaProducto_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBuscarCategoriaProducto_FormClosed);
            this.Load += new System.EventHandler(this.frmBuscarCategoriaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoriaProducto;
        private System.Windows.Forms.ListView lstvCategoriaProductos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colEstado;
    }
}