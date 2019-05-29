namespace SisSodINA
{
    partial class frmBuscarTipoMedida
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
            this.lstvTipoMedida = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscarTipoMedida = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvTipoMedida
            // 
            this.lstvTipoMedida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNombre,
            this.colEstado});
            this.lstvTipoMedida.FullRowSelect = true;
            this.lstvTipoMedida.GridLines = true;
            this.lstvTipoMedida.Location = new System.Drawing.Point(12, 40);
            this.lstvTipoMedida.Name = "lstvTipoMedida";
            this.lstvTipoMedida.Size = new System.Drawing.Size(278, 154);
            this.lstvTipoMedida.TabIndex = 5;
            this.lstvTipoMedida.UseCompatibleStateImageBehavior = false;
            this.lstvTipoMedida.View = System.Windows.Forms.View.Details;
            this.lstvTipoMedida.SelectedIndexChanged += new System.EventHandler(this.lstvTipoMedida_SelectedIndexChanged);
            this.lstvTipoMedida.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstvTipoMedida_DobleClick);
            // 
            // colId
            // 
            this.colId.Text = "ID";
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
            // txtBuscarTipoMedida
            // 
            this.txtBuscarTipoMedida.Location = new System.Drawing.Point(12, 14);
            this.txtBuscarTipoMedida.Name = "txtBuscarTipoMedida";
            this.txtBuscarTipoMedida.Size = new System.Drawing.Size(278, 20);
            this.txtBuscarTipoMedida.TabIndex = 6;
            this.txtBuscarTipoMedida.TextChanged += new System.EventHandler(this.txtBuscarTipoMedida_TextChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(185, 200);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 30);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarTipoMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 248);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtBuscarTipoMedida);
            this.Controls.Add(this.lstvTipoMedida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBuscarTipoMedida";
            this.Text = "frmBuscarTipoMedida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarForm);
            this.Load += new System.EventHandler(this.frmBuscarTipoMedida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvTipoMedida;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.TextBox txtBuscarTipoMedida;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ColumnHeader colEstado;
    }
}