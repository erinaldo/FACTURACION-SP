namespace PresentationLayer
{
    partial class frmConsultasMensajesHacienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasMensajesHacienda));
            this.txtXMLSinFirma = new System.Windows.Forms.TextBox();
            this.cboTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXMLSinFirma
            // 
            this.txtXMLSinFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLSinFirma.Location = new System.Drawing.Point(13, 65);
            this.txtXMLSinFirma.Margin = new System.Windows.Forms.Padding(4);
            this.txtXMLSinFirma.Multiline = true;
            this.txtXMLSinFirma.Name = "txtXMLSinFirma";
            this.txtXMLSinFirma.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLSinFirma.Size = new System.Drawing.Size(1154, 457);
            this.txtXMLSinFirma.TabIndex = 2;
            // 
            // cboTipoBusqueda
            // 
            this.cboTipoBusqueda.Location = new System.Drawing.Point(12, 29);
            this.cboTipoBusqueda.Name = "cboTipoBusqueda";
            this.cboTipoBusqueda.Size = new System.Drawing.Size(242, 24);
            this.cboTipoBusqueda.TabIndex = 34;
            this.cboTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboTipoBusqueda_SelectedIndexChanged);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(261, 31);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(449, 22);
            this.txtClave.TabIndex = 33;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(720, 11);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(61, 46);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultasMensajesHacienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 561);
            this.Controls.Add(this.cboTipoBusqueda);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtXMLSinFirma);
            this.Name = "frmConsultasMensajesHacienda";
            this.Text = "Consulta:  Mensajes de compras Hacienda";
            this.Load += new System.EventHandler(this.frmConsultasMensajesHacienda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtXMLSinFirma;
        private System.Windows.Forms.ComboBox cboTipoBusqueda;
        internal System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnConsultar;
    }
}