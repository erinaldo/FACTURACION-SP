namespace PresentationLayer
{
    partial class frmAgregarIngredieteProducto
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
            this.lstvIngrediente = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomrenclatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCatProducto = new System.Windows.Forms.Label();
            this.cboCatIngrediente = new System.Windows.Forms.ComboBox();
            this.lblCantidadIngrediente = new System.Windows.Forms.Label();
            this.btnSeleccionarIngrediente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdIngrediente = new System.Windows.Forms.Label();
            this.lblnumeroID = new System.Windows.Forms.Label();
            this.lblProductoName = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtCantidadIngrediente = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvIngrediente
            // 
            this.lstvIngrediente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colNomrenclatura});
            this.lstvIngrediente.FullRowSelect = true;
            this.lstvIngrediente.Location = new System.Drawing.Point(12, 41);
            this.lstvIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.lstvIngrediente.MultiSelect = false;
            this.lstvIngrediente.Name = "lstvIngrediente";
            this.lstvIngrediente.Size = new System.Drawing.Size(303, 148);
            this.lstvIngrediente.TabIndex = 0;
            this.lstvIngrediente.UseCompatibleStateImageBehavior = false;
            this.lstvIngrediente.View = System.Windows.Forms.View.Details;
            this.lstvIngrediente.SelectedIndexChanged += new System.EventHandler(this.lstvIngrediente_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 39;
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 88;
            // 
            // colNomrenclatura
            // 
            this.colNomrenclatura.Text = "Medida";
            this.colNomrenclatura.Width = 107;
            // 
            // lblCatProducto
            // 
            this.lblCatProducto.AutoSize = true;
            this.lblCatProducto.Location = new System.Drawing.Point(9, 15);
            this.lblCatProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatProducto.Name = "lblCatProducto";
            this.lblCatProducto.Size = new System.Drawing.Size(73, 17);
            this.lblCatProducto.TabIndex = 1;
            this.lblCatProducto.Text = "Categoria:";
            // 
            // cboCatIngrediente
            // 
            this.cboCatIngrediente.FormattingEnabled = true;
            this.cboCatIngrediente.Location = new System.Drawing.Point(86, 11);
            this.cboCatIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.cboCatIngrediente.Name = "cboCatIngrediente";
            this.cboCatIngrediente.Size = new System.Drawing.Size(229, 25);
            this.cboCatIngrediente.TabIndex = 2;
            this.cboCatIngrediente.SelectedIndexChanged += new System.EventHandler(this.cboCatIngrediente_SelectedIndexChanged);
            // 
            // lblCantidadIngrediente
            // 
            this.lblCantidadIngrediente.AutoSize = true;
            this.lblCantidadIngrediente.Location = new System.Drawing.Point(32, 251);
            this.lblCantidadIngrediente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadIngrediente.Name = "lblCantidadIngrediente";
            this.lblCantidadIngrediente.Size = new System.Drawing.Size(68, 17);
            this.lblCantidadIngrediente.TabIndex = 3;
            this.lblCantidadIngrediente.Text = "Cantidad:";
            // 
            // btnSeleccionarIngrediente
            // 
            this.btnSeleccionarIngrediente.Location = new System.Drawing.Point(48, 330);
            this.btnSeleccionarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarIngrediente.Name = "btnSeleccionarIngrediente";
            this.btnSeleccionarIngrediente.Size = new System.Drawing.Size(85, 32);
            this.btnSeleccionarIngrediente.TabIndex = 5;
            this.btnSeleccionarIngrediente.Text = "Agregar";
            this.btnSeleccionarIngrediente.UseVisualStyleBackColor = true;
            this.btnSeleccionarIngrediente.Click += new System.EventHandler(this.btnSeleccionarIngrediente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(153, 330);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdIngrediente
            // 
            this.lblIdIngrediente.AutoSize = true;
            this.lblIdIngrediente.Location = new System.Drawing.Point(73, 205);
            this.lblIdIngrediente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdIngrediente.Name = "lblIdIngrediente";
            this.lblIdIngrediente.Size = new System.Drawing.Size(23, 17);
            this.lblIdIngrediente.TabIndex = 7;
            this.lblIdIngrediente.Text = "Id:";
            // 
            // lblnumeroID
            // 
            this.lblnumeroID.AutoSize = true;
            this.lblnumeroID.Location = new System.Drawing.Point(102, 206);
            this.lblnumeroID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumeroID.Name = "lblnumeroID";
            this.lblnumeroID.Size = new System.Drawing.Size(16, 17);
            this.lblnumeroID.TabIndex = 8;
            this.lblnumeroID.Text = "1";
            // 
            // lblProductoName
            // 
            this.lblProductoName.AutoSize = true;
            this.lblProductoName.Location = new System.Drawing.Point(102, 226);
            this.lblProductoName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductoName.Name = "lblProductoName";
            this.lblProductoName.Size = new System.Drawing.Size(16, 17);
            this.lblProductoName.TabIndex = 10;
            this.lblProductoName.Text = "d";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(36, 226);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(62, 17);
            this.lblNombreProducto.TabIndex = 9;
            this.lblNombreProducto.Text = "Nombre:";
            // 
            // txtCantidadIngrediente
            // 
            this.txtCantidadIngrediente.Location = new System.Drawing.Point(105, 251);
            this.txtCantidadIngrediente.Name = "txtCantidadIngrediente";
            this.txtCantidadIngrediente.Size = new System.Drawing.Size(146, 23);
            this.txtCantidadIngrediente.TabIndex = 11;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(12, 302);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(239, 17);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "Los decimales ponerlos como: 0,300";
            // 
            // frmAgregarIngredieteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 408);
            this.ControlBox = false;
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtCantidadIngrediente);
            this.Controls.Add(this.lblProductoName);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblnumeroID);
            this.Controls.Add(this.lblIdIngrediente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarIngrediente);
            this.Controls.Add(this.lblCantidadIngrediente);
            this.Controls.Add(this.cboCatIngrediente);
            this.Controls.Add(this.lblCatProducto);
            this.Controls.Add(this.lstvIngrediente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAgregarIngredieteProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar ingrediente ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAgregarIngredieteProducto_FormClosed);
            this.Load += new System.EventHandler(this.frmAgregarIngredieteProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvIngrediente;
        private System.Windows.Forms.Label lblCatProducto;
        private System.Windows.Forms.ComboBox cboCatIngrediente;
        private System.Windows.Forms.Label lblCantidadIngrediente;
        private System.Windows.Forms.Button btnSeleccionarIngrediente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Label lblIdIngrediente;
        private System.Windows.Forms.Label lblnumeroID;
        private System.Windows.Forms.Label lblProductoName;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.ColumnHeader colNomrenclatura;
        private System.Windows.Forms.TextBox txtCantidadIngrediente;
        private System.Windows.Forms.Label lblAviso;
    }
}