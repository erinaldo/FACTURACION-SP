namespace PresentationLayer
{
    partial class frmConsultaFacturaElectronica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFacturaElectronica));
            this.txtXMLSinFirma = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cboTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXMLSinFirma
            // 
            this.txtXMLSinFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLSinFirma.Location = new System.Drawing.Point(17, 82);
            this.txtXMLSinFirma.Margin = new System.Windows.Forms.Padding(4);
            this.txtXMLSinFirma.Multiline = true;
            this.txtXMLSinFirma.Name = "txtXMLSinFirma";
            this.txtXMLSinFirma.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXMLSinFirma.Size = new System.Drawing.Size(1074, 431);
            this.txtXMLSinFirma.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(266, 48);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(449, 22);
            this.txtClave.TabIndex = 29;
            // 
            // cboTipoBusqueda
            // 
            this.cboTipoBusqueda.Location = new System.Drawing.Point(17, 16);
            this.cboTipoBusqueda.Name = "cboTipoBusqueda";
            this.cboTipoBusqueda.Size = new System.Drawing.Size(242, 24);
            this.cboTipoBusqueda.TabIndex = 30;
            this.cboTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboTipoBusqueda_SelectedIndexChanged);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.Location = new System.Drawing.Point(17, 46);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(242, 24);
            this.cboTipoDoc.TabIndex = 31;
            this.cboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cboTipoDoc_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(725, 28);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(61, 46);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmConsultaFacturaElectronica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 537);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.cboTipoBusqueda);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtXMLSinFirma);
            this.Controls.Add(this.btnConsultar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultaFacturaElectronica";
            this.Text = "Consulta: Factura Electrónica en Hacienda";
            this.Load += new System.EventHandler(this.frmConsultaFacturaElectronica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.TextBox txtXMLSinFirma;
        internal System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cboTipoBusqueda;
        private System.Windows.Forms.ComboBox cboTipoDoc;
    }
}