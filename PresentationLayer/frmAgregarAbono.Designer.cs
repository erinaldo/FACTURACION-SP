namespace PresentationLayer
{
    partial class frmAgregarAbono
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldoNeto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMontoAbonado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaCredito = new System.Windows.Forms.DateTimePicker();
            this.gbxMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMovimiento
            // 
            this.gbxMovimiento.Controls.Add(this.lblSaldo);
            this.gbxMovimiento.Controls.Add(this.label6);
            this.gbxMovimiento.Controls.Add(this.lblSaldoNeto);
            this.gbxMovimiento.Controls.Add(this.label1);
            this.gbxMovimiento.Controls.Add(this.button1);
            this.gbxMovimiento.Controls.Add(this.txtMontoAbonado);
            this.gbxMovimiento.Controls.Add(this.label2);
            this.gbxMovimiento.Controls.Add(this.label3);
            this.gbxMovimiento.Controls.Add(this.dtpFechaCredito);
            this.gbxMovimiento.Location = new System.Drawing.Point(27, 23);
            this.gbxMovimiento.Name = "gbxMovimiento";
            this.gbxMovimiento.Size = new System.Drawing.Size(369, 352);
            this.gbxMovimiento.TabIndex = 28;
            this.gbxMovimiento.TabStop = false;
            this.gbxMovimiento.Text = "Datos de Abono";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(169, 51);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(35, 16);
            this.lblSaldo.TabIndex = 22;
            this.lblSaldo.Text = "XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor del Credito:";
            // 
            // lblSaldoNeto
            // 
            this.lblSaldoNeto.AutoSize = true;
            this.lblSaldoNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoNeto.Location = new System.Drawing.Point(110, 280);
            this.lblSaldoNeto.Name = "lblSaldoNeto";
            this.lblSaldoNeto.Size = new System.Drawing.Size(41, 18);
            this.lblSaldoNeto.TabIndex = 20;
            this.lblSaldoNeto.Text = "XXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Saldo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMontoAbonado
            // 
            this.txtMontoAbonado.Location = new System.Drawing.Point(129, 159);
            this.txtMontoAbonado.Name = "txtMontoAbonado";
            this.txtMontoAbonado.Size = new System.Drawing.Size(203, 20);
            this.txtMontoAbonado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Monto a Abonar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha: ";
            // 
            // dtpFechaCredito
            // 
            this.dtpFechaCredito.Location = new System.Drawing.Point(129, 111);
            this.dtpFechaCredito.Name = "dtpFechaCredito";
            this.dtpFechaCredito.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaCredito.TabIndex = 1;
            // 
            // frmAgregarAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 411);
            this.Controls.Add(this.gbxMovimiento);
            this.Name = "frmAgregarAbono";
            this.Text = "Mantenimiento Abonos";
            this.Load += new System.EventHandler(this.frmAgregarAbono_Load);
            this.gbxMovimiento.ResumeLayout(false);
            this.gbxMovimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMovimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMontoAbonado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldoNeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCredito;
    }
}