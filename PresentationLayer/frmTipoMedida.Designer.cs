namespace PresentationLayer
{
    partial class frmTipoMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoMedida));
            this.gbxTipoMedida = new System.Windows.Forms.GroupBox();
            this.txtDescripcionTipoMedida = new System.Windows.Forms.TextBox();
            this.txtNomenclaturaTipoMedida = new System.Windows.Forms.TextBox();
            this.txtNombreTipoMedida = new System.Windows.Forms.TextBox();
            this.txtIdTipoMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tlsMenu = new System.Windows.Forms.ToolStrip();
            this.btnGuardar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnNuevo1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnModificar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnEliminar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnBuscar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnCancelar1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnSalir1 = new System.Windows.Forms.ToolStripButton();
            this.gbxTipoMedida.SuspendLayout();
            this.tlsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTipoMedida
            // 
            this.gbxTipoMedida.Controls.Add(this.txtDescripcionTipoMedida);
            this.gbxTipoMedida.Controls.Add(this.txtNomenclaturaTipoMedida);
            this.gbxTipoMedida.Controls.Add(this.txtNombreTipoMedida);
            this.gbxTipoMedida.Controls.Add(this.txtIdTipoMedida);
            this.gbxTipoMedida.Controls.Add(this.label4);
            this.gbxTipoMedida.Controls.Add(this.label3);
            this.gbxTipoMedida.Controls.Add(this.label2);
            this.gbxTipoMedida.Controls.Add(this.label1);
            this.gbxTipoMedida.Location = new System.Drawing.Point(16, 52);
            this.gbxTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTipoMedida.Name = "gbxTipoMedida";
            this.gbxTipoMedida.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTipoMedida.Size = new System.Drawing.Size(445, 273);
            this.gbxTipoMedida.TabIndex = 0;
            this.gbxTipoMedida.TabStop = false;
            this.gbxTipoMedida.Text = "Datos de Tipos de Medidas";
            // 
            // txtDescripcionTipoMedida
            // 
            this.txtDescripcionTipoMedida.Enabled = false;
            this.txtDescripcionTipoMedida.Location = new System.Drawing.Point(139, 148);
            this.txtDescripcionTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionTipoMedida.MaxLength = 500;
            this.txtDescripcionTipoMedida.Multiline = true;
            this.txtDescripcionTipoMedida.Name = "txtDescripcionTipoMedida";
            this.txtDescripcionTipoMedida.Size = new System.Drawing.Size(252, 90);
            this.txtDescripcionTipoMedida.TabIndex = 8;
            // 
            // txtNomenclaturaTipoMedida
            // 
            this.txtNomenclaturaTipoMedida.Enabled = false;
            this.txtNomenclaturaTipoMedida.Location = new System.Drawing.Point(139, 116);
            this.txtNomenclaturaTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomenclaturaTipoMedida.MaxLength = 5;
            this.txtNomenclaturaTipoMedida.Name = "txtNomenclaturaTipoMedida";
            this.txtNomenclaturaTipoMedida.Size = new System.Drawing.Size(252, 22);
            this.txtNomenclaturaTipoMedida.TabIndex = 7;
            // 
            // txtNombreTipoMedida
            // 
            this.txtNombreTipoMedida.Enabled = false;
            this.txtNombreTipoMedida.Location = new System.Drawing.Point(139, 82);
            this.txtNombreTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreTipoMedida.MaxLength = 30;
            this.txtNombreTipoMedida.Name = "txtNombreTipoMedida";
            this.txtNombreTipoMedida.Size = new System.Drawing.Size(252, 22);
            this.txtNombreTipoMedida.TabIndex = 6;
            // 
            // txtIdTipoMedida
            // 
            this.txtIdTipoMedida.Enabled = false;
            this.txtIdTipoMedida.Location = new System.Drawing.Point(139, 52);
            this.txtIdTipoMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdTipoMedida.Name = "txtIdTipoMedida";
            this.txtIdTipoMedida.ReadOnly = true;
            this.txtIdTipoMedida.Size = new System.Drawing.Size(81, 22);
            this.txtIdTipoMedida.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nomenclatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // tlsMenu
            // 
            this.tlsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar1,
            this.toolStripSeparator7,
            this.tlsbtnNuevo1,
            this.toolStripSeparator8,
            this.tlsbtnModificar1,
            this.toolStripSeparator9,
            this.tlsbtnEliminar1,
            this.toolStripSeparator10,
            this.tlsbtnBuscar1,
            this.toolStripSeparator11,
            this.tlsbtnCancelar1,
            this.toolStripSeparator12,
            this.tlsbtnSalir1});
            this.tlsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsMenu.Name = "tlsMenu";
            this.tlsMenu.Size = new System.Drawing.Size(484, 39);
            this.tlsMenu.TabIndex = 5;
            this.tlsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlsMenu_ItemClicked_1);
            // 
            // btnGuardar1
            // 
            this.btnGuardar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar1.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar1.Image")));
            this.btnGuardar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar1.MergeIndex = 1;
            this.btnGuardar1.Name = "btnGuardar1";
            this.btnGuardar1.Size = new System.Drawing.Size(36, 36);
            this.btnGuardar1.Text = "Guardar";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsbtnNuevo1
            // 
            this.tlsbtnNuevo1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnNuevo1.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnNuevo1.Image")));
            this.tlsbtnNuevo1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnNuevo1.MergeIndex = 2;
            this.tlsbtnNuevo1.Name = "tlsbtnNuevo1";
            this.tlsbtnNuevo1.Size = new System.Drawing.Size(36, 36);
            this.tlsbtnNuevo1.Text = "Nuevo";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsbtnModificar1
            // 
            this.tlsbtnModificar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnModificar1.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnModificar1.Image")));
            this.tlsbtnModificar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnModificar1.MergeIndex = 3;
            this.tlsbtnModificar1.Name = "tlsbtnModificar1";
            this.tlsbtnModificar1.Size = new System.Drawing.Size(36, 36);
            this.tlsbtnModificar1.Text = "Modificar";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsbtnEliminar1
            // 
            this.tlsbtnEliminar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnEliminar1.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnEliminar1.Image")));
            this.tlsbtnEliminar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnEliminar1.MergeIndex = 4;
            this.tlsbtnEliminar1.Name = "tlsbtnEliminar1";
            this.tlsbtnEliminar1.Size = new System.Drawing.Size(36, 36);
            this.tlsbtnEliminar1.Text = "Eliminar";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsbtnBuscar1
            // 
            this.tlsbtnBuscar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnBuscar1.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnBuscar1.Image")));
            this.tlsbtnBuscar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnBuscar1.MergeIndex = 5;
            this.tlsbtnBuscar1.Name = "tlsbtnBuscar1";
            this.tlsbtnBuscar1.Size = new System.Drawing.Size(36, 36);
            this.tlsbtnBuscar1.Text = "Buscar";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsbtnCancelar1
            // 
            this.tlsbtnCancelar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnCancelar1.Image")));
            this.tlsbtnCancelar1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnCancelar1.MergeIndex = 6;
            this.tlsbtnCancelar1.Name = "tlsbtnCancelar1";
            this.tlsbtnCancelar1.Size = new System.Drawing.Size(36, 36);
            this.tlsbtnCancelar1.Text = "Cancelar";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 39);
            // 
            // tlsbtnSalir1
            // 
            this.tlsbtnSalir1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbtnSalir1.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnSalir1.Image")));
            this.tlsbtnSalir1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnSalir1.MergeIndex = 7;
            this.tlsbtnSalir1.Name = "tlsbtnSalir1";
            this.tlsbtnSalir1.Size = new System.Drawing.Size(36, 36);
            this.tlsbtnSalir1.Text = "Salir";
            // 
            // frmTipoMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 339);
            this.Controls.Add(this.tlsMenu);
            this.Controls.Add(this.gbxTipoMedida);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTipoMedida";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento: Tipos de Medidas";
            this.Load += new System.EventHandler(this.frmTipoMedida_Load);
            this.gbxTipoMedida.ResumeLayout(false);
            this.gbxTipoMedida.PerformLayout();
            this.tlsMenu.ResumeLayout(false);
            this.tlsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTipoMedida;
        private System.Windows.Forms.TextBox txtDescripcionTipoMedida;
        private System.Windows.Forms.TextBox txtNomenclaturaTipoMedida;
        private System.Windows.Forms.TextBox txtNombreTipoMedida;
        private System.Windows.Forms.TextBox txtIdTipoMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStrip tlsMenu;
        private System.Windows.Forms.ToolStripButton btnGuardar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tlsbtnNuevo1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tlsbtnModificar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tlsbtnEliminar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tlsbtnBuscar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton tlsbtnCancelar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tlsbtnSalir1;
    }
}