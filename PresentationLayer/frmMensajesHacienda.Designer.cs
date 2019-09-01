namespace PresentationLayer
{
    partial class frmMensajesHacienda
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensajesHacienda));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lsvDoc = new System.Windows.Forms.ListView();
            this.colClave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdEmisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFechaEmision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColImp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(13, 16);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 17);
            label7.TabIndex = 10;
            label7.Text = "Impuestos:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(13, 16);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(200, 17);
            label10.TabIndex = 10;
            label10.Text = "Últimos Mensajes procesados:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargar.Location = new System.Drawing.Point(21, 9);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(133, 67);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Archivos";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lsvDoc
            // 
            this.lsvDoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colClave,
            this.colIdEmisor,
            this.colEmisor,
            this.ColFechaEmision,
            this.ColImp,
            this.ColTotal,
            this.colEstado});
            this.lsvDoc.FullRowSelect = true;
            this.lsvDoc.GridLines = true;
            this.lsvDoc.HoverSelection = true;
            this.lsvDoc.Location = new System.Drawing.Point(13, 98);
            this.lsvDoc.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDoc.MultiSelect = false;
            this.lsvDoc.Name = "lsvDoc";
            this.lsvDoc.Size = new System.Drawing.Size(1514, 236);
            this.lsvDoc.TabIndex = 2;
            this.lsvDoc.UseCompatibleStateImageBehavior = false;
            this.lsvDoc.View = System.Windows.Forms.View.Details;
            this.lsvDoc.SelectedIndexChanged += new System.EventHandler(this.lsvDoc_SelectedIndexChanged);
            this.lsvDoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvDoc_MouseClick);
            // 
            // colClave
            // 
            this.colClave.Text = "Clave";
            this.colClave.Width = 310;
            // 
            // colIdEmisor
            // 
            this.colIdEmisor.Text = "Id Emisor";
            this.colIdEmisor.Width = 120;
            // 
            // colEmisor
            // 
            this.colEmisor.Text = "Emisor";
            this.colEmisor.Width = 250;
            // 
            // ColFechaEmision
            // 
            this.ColFechaEmision.Text = "Fecha Emisión";
            this.ColFechaEmision.Width = 130;
            // 
            // ColImp
            // 
            this.ColImp.Text = "Impuestos";
            this.ColImp.Width = 90;
            // 
            // ColTotal
            // 
            this.ColTotal.Text = "Total";
            this.ColTotal.Width = 90;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 150;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(75, 425);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(313, 24);
            this.cboEstado.TabIndex = 3;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(75, 484);
            this.txtRazon.MaxLength = 160;
            this.txtRazon.Multiline = true;
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(827, 65);
            this.txtRazon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Razón:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Emisor:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(529, 353);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(373, 22);
            this.txtID.TabIndex = 11;
            // 
            // txtEmisor
            // 
            this.txtEmisor.Location = new System.Drawing.Point(528, 376);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.ReadOnly = true;
            this.txtEmisor.Size = new System.Drawing.Size(373, 22);
            this.txtEmisor.TabIndex = 12;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(75, 353);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(373, 22);
            this.txtClave.TabIndex = 13;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(75, 381);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(373, 22);
            this.txtFecha.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtImp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Location = new System.Drawing.Point(529, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 69);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(95, 41);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(212, 22);
            this.txtTotal.TabIndex = 15;
            // 
            // txtImp
            // 
            this.txtImp.Location = new System.Drawing.Point(95, 13);
            this.txtImp.Name = "txtImp";
            this.txtImp.ReadOnly = true;
            this.txtImp.Size = new System.Drawing.Size(212, 22);
            this.txtImp.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.Location = new System.Drawing.Point(75, 558);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 70);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar lista";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcesar.Location = new System.Drawing.Point(1422, 553);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(105, 75);
            this.btnProcesar.TabIndex = 17;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMensaje);
            this.groupBox2.Controls.Add(label10);
            this.groupBox2.Location = new System.Drawing.Point(935, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 150);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(6, 36);
            this.txtMensaje.MaxLength = 160;
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(580, 108);
            this.txtMensaje.TabIndex = 19;
            // 
            // frmMensajesHacienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1545, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazon);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lsvDoc);
            this.Controls.Add(this.btnCargar);
            this.Name = "frmMensajesHacienda";
            this.Text = "Reporte de compras a Hacienda";
            this.Load += new System.EventHandler(this.frmMensajesHacienda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListView lsvDoc;
        private System.Windows.Forms.ColumnHeader colClave;
        private System.Windows.Forms.ColumnHeader colIdEmisor;
        private System.Windows.Forms.ColumnHeader colEmisor;
        private System.Windows.Forms.ColumnHeader ColFechaEmision;
        private System.Windows.Forms.ColumnHeader ColImp;
        private System.Windows.Forms.ColumnHeader ColTotal;
        private System.Windows.Forms.ColumnHeader colEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmisor;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtImp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}