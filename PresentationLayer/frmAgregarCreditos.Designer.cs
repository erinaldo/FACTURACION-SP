namespace PresentationLayer
{
    partial class frmAgregarCreditos
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
            this.gbxMovimiento = new System.Windows.Forms.GroupBox();
            this.txtAbonoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFechaCredito = new System.Windows.Forms.DateTimePicker();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.gbxMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMovimiento
            // 
            this.gbxMovimiento.Controls.Add(this.txtAbonoInicial);
            this.gbxMovimiento.Controls.Add(this.label1);
            this.gbxMovimiento.Controls.Add(this.button1);
            this.gbxMovimiento.Controls.Add(this.chkEstado);
            this.gbxMovimiento.Controls.Add(this.txtMonto);
            this.gbxMovimiento.Controls.Add(this.label2);
            this.gbxMovimiento.Controls.Add(this.label3);
            this.gbxMovimiento.Controls.Add(this.label13);
            this.gbxMovimiento.Controls.Add(this.dtpFechaCredito);
            this.gbxMovimiento.Controls.Add(this.txtMotivo);
            this.gbxMovimiento.Location = new System.Drawing.Point(31, 35);
            this.gbxMovimiento.Name = "gbxMovimiento";
            this.gbxMovimiento.Size = new System.Drawing.Size(438, 465);
            this.gbxMovimiento.TabIndex = 27;
            this.gbxMovimiento.TabStop = false;
            this.gbxMovimiento.Text = "Datos Movimiento";
            // 
            // txtAbonoInicial
            // 
            this.txtAbonoInicial.Location = new System.Drawing.Point(97, 148);
            this.txtAbonoInicial.Name = "txtAbonoInicial";
            this.txtAbonoInicial.Size = new System.Drawing.Size(203, 20);
            this.txtAbonoInicial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Abono Inicial:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(97, 317);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 5;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(97, 102);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(203, 20);
            this.txtMonto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Motivo:";
            // 
            // dtpFechaCredito
            // 
            this.dtpFechaCredito.Location = new System.Drawing.Point(97, 48);
            this.dtpFechaCredito.Name = "dtpFechaCredito";
            this.dtpFechaCredito.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaCredito.TabIndex = 1;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(97, 192);
            this.txtMotivo.MaxLength = 500;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(203, 53);
            this.txtMotivo.TabIndex = 4;
            // 
            // frmAgregarCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 512);
            this.Controls.Add(this.gbxMovimiento);
            this.Name = "frmAgregarCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Credito";
            this.Load += new System.EventHandler(this.frmAgregarCreditos_Load);
            this.gbxMovimiento.ResumeLayout(false);
            this.gbxMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMovimiento;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFechaCredito;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAbonoInicial;
        private System.Windows.Forms.Label label1;
    }
}