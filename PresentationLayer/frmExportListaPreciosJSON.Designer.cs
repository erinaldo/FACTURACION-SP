namespace PresentationLayer
{
    partial class frmExportListaPreciosJSON
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
            this.btnRutaXML = new System.Windows.Forms.Button();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRutaXML
            // 
            this.btnRutaXML.Location = new System.Drawing.Point(572, 21);
            this.btnRutaXML.Name = "btnRutaXML";
            this.btnRutaXML.Size = new System.Drawing.Size(41, 23);
            this.btnRutaXML.TabIndex = 37;
            this.btnRutaXML.Text = "...";
            this.btnRutaXML.UseVisualStyleBackColor = true;
            this.btnRutaXML.Click += new System.EventHandler(this.btnRutaXML_Click);
            // 
            // txtRutaXML
            // 
            this.txtRutaXML.Location = new System.Drawing.Point(123, 21);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.ReadOnly = true;
            this.txtRutaXML.Size = new System.Drawing.Size(443, 22);
            this.txtRutaXML.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Carpeta Destino:";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(465, 50);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(148, 36);
            this.btnExportar.TabIndex = 38;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmExportListaPreciosJSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 90);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnRutaXML);
            this.Controls.Add(this.txtRutaXML);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExportListaPreciosJSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Datos";
            this.Load += new System.EventHandler(this.frmExportListaPreciosJSON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRutaXML;
        private System.Windows.Forms.TextBox txtRutaXML;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExportar;
    }
}