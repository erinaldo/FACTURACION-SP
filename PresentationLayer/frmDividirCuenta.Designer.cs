namespace PresentationLayer
{
    partial class frmDividirCuenta
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
            this.lstViewTotal = new System.Windows.Forms.ListView();
            this.colChk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdServ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvListaParcial = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstViewTotal
            // 
            this.lstViewTotal.CheckBoxes = true;
            this.lstViewTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colChk,
            this.colCodigoProducto,
            this.colProdServ,
            this.colPrecio});
            this.lstViewTotal.FullRowSelect = true;
            this.lstViewTotal.GridLines = true;
            this.lstViewTotal.Location = new System.Drawing.Point(22, 32);
            this.lstViewTotal.Name = "lstViewTotal";
            this.lstViewTotal.Size = new System.Drawing.Size(705, 258);
            this.lstViewTotal.TabIndex = 0;
            this.lstViewTotal.UseCompatibleStateImageBehavior = false;
            this.lstViewTotal.View = System.Windows.Forms.View.Details;
            this.lstViewTotal.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstViewTotal_ItemChecked);
            // 
            // colChk
            // 
            this.colChk.Text = "";
            this.colChk.Width = 43;
            // 
            // colProdServ
            // 
            this.colProdServ.Text = "Producto";
            this.colProdServ.Width = 200;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "Precio";
            this.colPrecio.Width = 100;
            // 
            // colCodigoProducto
            // 
            this.colCodigoProducto.Text = "Código";
            this.colCodigoProducto.Width = 150;
            // 
            // lstvListaParcial
            // 
            this.lstvListaParcial.CheckBoxes = true;
            this.lstvListaParcial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvListaParcial.FullRowSelect = true;
            this.lstvListaParcial.GridLines = true;
            this.lstvListaParcial.Location = new System.Drawing.Point(22, 296);
            this.lstvListaParcial.Name = "lstvListaParcial";
            this.lstvListaParcial.Size = new System.Drawing.Size(705, 243);
            this.lstvListaParcial.TabIndex = 1;
            this.lstvListaParcial.UseCompatibleStateImageBehavior = false;
            this.lstvListaParcial.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Producto";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 100;
            // 
            // frmDividirCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 573);
            this.Controls.Add(this.lstvListaParcial);
            this.Controls.Add(this.lstViewTotal);
            this.Name = "frmDividirCuenta";
            this.Text = "Cobrar: Dividir cuenta";
            this.Load += new System.EventHandler(this.frmDividirCuenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstViewTotal;
        private System.Windows.Forms.ColumnHeader colChk;
        private System.Windows.Forms.ColumnHeader colProdServ;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ColumnHeader colCodigoProducto;
        private System.Windows.Forms.ListView lstvListaParcial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}