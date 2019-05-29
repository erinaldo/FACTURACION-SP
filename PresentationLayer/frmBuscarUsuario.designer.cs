namespace PresentationLayer
{
    partial class frmBuscarUsuario
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
            this.lstvBuscar = new System.Windows.Forms.ListView();
            this.cId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cNomUsu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvBuscar
            // 
            this.lstvBuscar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cId,
            this.cNomUsu,
            this.idRol,
            this.cEstado});
            this.lstvBuscar.FullRowSelect = true;
            this.lstvBuscar.GridLines = true;
            this.lstvBuscar.Location = new System.Drawing.Point(12, 38);
            this.lstvBuscar.Name = "lstvBuscar";
            this.lstvBuscar.Size = new System.Drawing.Size(282, 188);
            this.lstvBuscar.TabIndex = 0;
            this.lstvBuscar.UseCompatibleStateImageBehavior = false;
            this.lstvBuscar.View = System.Windows.Forms.View.Details;
            this.lstvBuscar.SelectedIndexChanged += new System.EventHandler(this.ltvBuscar_SelectedIndexChanged);
            this.lstvBuscar.DoubleClick += new System.EventHandler(this.ltvBuscar_SelectedIndexChanged);
            this.lstvBuscar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvBuscar_MouseDoubleClick);
            // 
            // cId
            // 
            this.cId.Text = "Id";
            this.cId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cId.Width = 70;
            // 
            // cNomUsu
            // 
            this.cNomUsu.Text = "Nombre de Usuario";
            this.cNomUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cNomUsu.Width = 109;
            // 
            // idRol
            // 
            this.idRol.Text = "Rol";
            this.idRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idRol.Width = 39;
            // 
            // cEstado
            // 
            this.cEstado.Text = "Estado";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(199, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(198, 232);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(96, 50);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 294);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lstvBuscar);
            this.Name = "frmBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cerrarFormBuscar);
            this.Load += new System.EventHandler(this.frmBuscarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvBuscar;
        private System.Windows.Forms.ColumnHeader cNomUsu;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader cId;
        private System.Windows.Forms.ColumnHeader idRol;
        private System.Windows.Forms.ColumnHeader cEstado;
    }
}