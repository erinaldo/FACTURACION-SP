namespace PresentationLayer
{
    partial class frmCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrar));
            this.lblRefPago = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnContado = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtCodTarjeta = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn2000 = new System.Windows.Forms.Button();
            this.btn5000 = new System.Windows.Forms.Button();
            this.btn10000 = new System.Windows.Forms.Button();
            this.btn15000 = new System.Windows.Forms.Button();
            this.btn20000 = new System.Windows.Forms.Button();
            this.btn50000 = new System.Windows.Forms.Button();
            this.btnCompleto = new System.Windows.Forms.Button();
            this.gbxBillete = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxBillete.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRefPago
            // 
            this.lblRefPago.AutoSize = true;
            this.lblRefPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefPago.Location = new System.Drawing.Point(-5, 374);
            this.lblRefPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefPago.Name = "lblRefPago";
            this.lblRefPago.Size = new System.Drawing.Size(218, 29);
            this.lblRefPago.TabIndex = 47;
            this.lblRefPago.Text = "Referencia Tarjeta:";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Enabled = false;
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(221, 474);
            this.txtVuelto.Margin = new System.Windows.Forms.Padding(4);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(337, 46);
            this.txtVuelto.TabIndex = 45;
            this.txtVuelto.Text = "0";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(221, 420);
            this.txtPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(337, 46);
            this.txtPago.TabIndex = 1;
            this.txtPago.Text = "0";
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.DoubleClick += new System.EventHandler(this.txtPago_DoubleClick);
            this.txtPago.Enter += new System.EventHandler(this.txtPago_Enter);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeniedNonNumeric);
            this.txtPago.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Backspace);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 43;
            this.label5.Text = "Vuelto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 427);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 42;
            this.label4.Text = "Pago:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(19, 369);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(225, 87);
            this.btnBorrar.TabIndex = 58;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            this.btnBorrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Backspacebtn);
            // 
            // btnNum8
            // 
            this.btnNum8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(135, 31);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(107, 78);
            this.btnNum8.TabIndex = 50;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(19, 202);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(108, 78);
            this.btnNum1.TabIndex = 55;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(249, 32);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(108, 78);
            this.btnNum9.TabIndex = 51;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(19, 31);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(108, 78);
            this.btnNum7.TabIndex = 49;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(135, 116);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(107, 78);
            this.btnNum5.TabIndex = 53;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(135, 202);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(107, 78);
            this.btnNum2.TabIndex = 56;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum
            // 
            this.btnNum.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNum.FlatAppearance.BorderSize = 2;
            this.btnNum.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum.Location = new System.Drawing.Point(135, 286);
            this.btnNum.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(107, 76);
            this.btnNum.TabIndex = 62;
            this.btnNum.Text = ".";
            this.btnNum.UseVisualStyleBackColor = false;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(19, 116);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(108, 78);
            this.btnNum4.TabIndex = 52;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(249, 117);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(108, 78);
            this.btnNum6.TabIndex = 54;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNum0.Enabled = false;
            this.btnNum0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNum0.FlatAppearance.BorderSize = 2;
            this.btnNum0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(19, 286);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(108, 76);
            this.btnNum0.TabIndex = 61;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.BackColor = System.Drawing.Color.DarkGray;
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(249, 202);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(4);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(109, 78);
            this.btnNum3.TabIndex = 57;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(249, 286);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 171);
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnContado
            // 
            this.btnContado.BackColor = System.Drawing.Color.White;
            this.btnContado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContado.BackgroundImage")));
            this.btnContado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContado.Location = new System.Drawing.Point(20, 23);
            this.btnContado.Margin = new System.Windows.Forms.Padding(4);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(116, 92);
            this.btnContado.TabIndex = 3;
            this.btnContado.UseVisualStyleBackColor = false;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.BackColor = System.Drawing.Color.White;
            this.btnCredito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCredito.BackgroundImage")));
            this.btnCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredito.Location = new System.Drawing.Point(272, 23);
            this.btnCredito.Margin = new System.Windows.Forms.Padding(4);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(119, 92);
            this.btnCredito.TabIndex = 2;
            this.btnCredito.UseVisualStyleBackColor = false;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.BackColor = System.Drawing.Color.White;
            this.btnTarjeta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTarjeta.BackgroundImage")));
            this.btnTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.Location = new System.Drawing.Point(144, 23);
            this.btnTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(120, 92);
            this.btnTarjeta.TabIndex = 4;
            this.btnTarjeta.UseVisualStyleBackColor = false;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkImprimir);
            this.groupBox1.Controls.Add(this.btnNum9);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnNum3);
            this.groupBox1.Controls.Add(this.btnNum8);
            this.groupBox1.Controls.Add(this.btnNum0);
            this.groupBox1.Controls.Add(this.btnNum1);
            this.groupBox1.Controls.Add(this.btnNum6);
            this.groupBox1.Controls.Add(this.btnNum4);
            this.groupBox1.Controls.Add(this.btnNum7);
            this.groupBox1.Controls.Add(this.btnNum);
            this.groupBox1.Controls.Add(this.btnNum5);
            this.groupBox1.Controls.Add(this.btnNum2);
            this.groupBox1.Location = new System.Drawing.Point(597, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(379, 529);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // chkImprimir
            // 
            this.chkImprimir.AutoSize = true;
            this.chkImprimir.Checked = true;
            this.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImprimir.Location = new System.Drawing.Point(19, 474);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(217, 24);
            this.chkImprimir.TabIndex = 63;
            this.chkImprimir.Text = "Imprimir Comprobante";
            this.chkImprimir.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Red;
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.Location = new System.Drawing.Point(937, 2);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 27);
            this.button13.TabIndex = 0;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPlazo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTipoPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMontoTotal);
            this.groupBox2.Controls.Add(this.txtCodTarjeta);
            this.groupBox2.Controls.Add(this.lblMonto);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtVuelto);
            this.groupBox2.Controls.Add(this.lblRefPago);
            this.groupBox2.Location = new System.Drawing.Point(13, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(577, 529);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 29);
            this.label8.TabIndex = 77;
            this.label8.Text = "días.";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Enabled = false;
            this.txtPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlazo.Location = new System.Drawing.Point(221, 202);
            this.txtPlazo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(219, 46);
            this.txtPlazo.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "Plazo Crédito:";
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Enabled = false;
            this.txtTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPago.Location = new System.Drawing.Point(221, 257);
            this.txtTipoPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(337, 46);
            this.txtTipoPago.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tipo de pago:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotal.Location = new System.Drawing.Point(221, 312);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(337, 46);
            this.txtMontoTotal.TabIndex = 72;
            // 
            // txtCodTarjeta
            // 
            this.txtCodTarjeta.Enabled = false;
            this.txtCodTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTarjeta.Location = new System.Drawing.Point(221, 366);
            this.txtCodTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodTarjeta.Name = "txtCodTarjeta";
            this.txtCodTarjeta.Size = new System.Drawing.Size(337, 46);
            this.txtCodTarjeta.TabIndex = 71;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(40, 321);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(173, 29);
            this.lblMonto.TabIndex = 69;
            this.lblMonto.Text = "Monto a pagar:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCredito);
            this.groupBox3.Controls.Add(this.btnContado);
            this.groupBox3.Controls.Add(this.btnTarjeta);
            this.groupBox3.Location = new System.Drawing.Point(27, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(413, 154);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formas de pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Efectivo";
            // 
            // btn1000
            // 
            this.btn1000.BackColor = System.Drawing.Color.White;
            this.btn1000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1000.BackgroundImage")));
            this.btn1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1000.Location = new System.Drawing.Point(157, 14);
            this.btn1000.Margin = new System.Windows.Forms.Padding(4);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(107, 76);
            this.btn1000.TabIndex = 68;
            this.btn1000.Text = "1.000";
            this.btn1000.UseVisualStyleBackColor = false;
            this.btn1000.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2000
            // 
            this.btn2000.BackColor = System.Drawing.Color.White;
            this.btn2000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2000.BackgroundImage")));
            this.btn2000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2000.Location = new System.Drawing.Point(272, 14);
            this.btn2000.Margin = new System.Windows.Forms.Padding(4);
            this.btn2000.Name = "btn2000";
            this.btn2000.Size = new System.Drawing.Size(107, 76);
            this.btn2000.TabIndex = 69;
            this.btn2000.Text = "2.000";
            this.btn2000.UseVisualStyleBackColor = false;
            this.btn2000.Click += new System.EventHandler(this.btn2000_Click);
            // 
            // btn5000
            // 
            this.btn5000.BackColor = System.Drawing.Color.White;
            this.btn5000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5000.BackgroundImage")));
            this.btn5000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5000.Location = new System.Drawing.Point(387, 14);
            this.btn5000.Margin = new System.Windows.Forms.Padding(4);
            this.btn5000.Name = "btn5000";
            this.btn5000.Size = new System.Drawing.Size(107, 76);
            this.btn5000.TabIndex = 70;
            this.btn5000.Text = "5.000";
            this.btn5000.UseVisualStyleBackColor = false;
            this.btn5000.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn10000
            // 
            this.btn10000.BackColor = System.Drawing.Color.White;
            this.btn10000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn10000.BackgroundImage")));
            this.btn10000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn10000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn10000.Location = new System.Drawing.Point(502, 14);
            this.btn10000.Margin = new System.Windows.Forms.Padding(4);
            this.btn10000.Name = "btn10000";
            this.btn10000.Size = new System.Drawing.Size(107, 76);
            this.btn10000.TabIndex = 71;
            this.btn10000.Text = "10.000";
            this.btn10000.UseVisualStyleBackColor = false;
            this.btn10000.Click += new System.EventHandler(this.btn10000_Click);
            // 
            // btn15000
            // 
            this.btn15000.BackColor = System.Drawing.Color.White;
            this.btn15000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn15000.BackgroundImage")));
            this.btn15000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn15000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn15000.Location = new System.Drawing.Point(617, 14);
            this.btn15000.Margin = new System.Windows.Forms.Padding(4);
            this.btn15000.Name = "btn15000";
            this.btn15000.Size = new System.Drawing.Size(107, 76);
            this.btn15000.TabIndex = 72;
            this.btn15000.Text = "15.000";
            this.btn15000.UseVisualStyleBackColor = false;
            this.btn15000.Click += new System.EventHandler(this.btn15000_Click);
            // 
            // btn20000
            // 
            this.btn20000.BackColor = System.Drawing.Color.White;
            this.btn20000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn20000.BackgroundImage")));
            this.btn20000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn20000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn20000.Location = new System.Drawing.Point(732, 14);
            this.btn20000.Margin = new System.Windows.Forms.Padding(4);
            this.btn20000.Name = "btn20000";
            this.btn20000.Size = new System.Drawing.Size(107, 76);
            this.btn20000.TabIndex = 73;
            this.btn20000.Text = "20.000";
            this.btn20000.UseVisualStyleBackColor = false;
            this.btn20000.Click += new System.EventHandler(this.btn20000_Click);
            // 
            // btn50000
            // 
            this.btn50000.BackColor = System.Drawing.Color.White;
            this.btn50000.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn50000.BackgroundImage")));
            this.btn50000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn50000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50000.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn50000.Location = new System.Drawing.Point(850, 14);
            this.btn50000.Margin = new System.Windows.Forms.Padding(4);
            this.btn50000.Name = "btn50000";
            this.btn50000.Size = new System.Drawing.Size(107, 76);
            this.btn50000.TabIndex = 74;
            this.btn50000.Text = "50.000";
            this.btn50000.UseVisualStyleBackColor = false;
            this.btn50000.Click += new System.EventHandler(this.btn50000_Click);
            // 
            // btnCompleto
            // 
            this.btnCompleto.BackColor = System.Drawing.Color.White;
            this.btnCompleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompleto.BackgroundImage")));
            this.btnCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCompleto.Location = new System.Drawing.Point(15, 14);
            this.btnCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompleto.Name = "btnCompleto";
            this.btnCompleto.Size = new System.Drawing.Size(107, 76);
            this.btnCompleto.TabIndex = 75;
            this.btnCompleto.Text = "Completo";
            this.btnCompleto.UseVisualStyleBackColor = false;
            this.btnCompleto.Click += new System.EventHandler(this.btnCompleto_Click);
            // 
            // gbxBillete
            // 
            this.gbxBillete.Controls.Add(this.btnCompleto);
            this.gbxBillete.Controls.Add(this.btn50000);
            this.gbxBillete.Controls.Add(this.btn20000);
            this.gbxBillete.Controls.Add(this.btn15000);
            this.gbxBillete.Controls.Add(this.btn10000);
            this.gbxBillete.Controls.Add(this.btn5000);
            this.gbxBillete.Controls.Add(this.btn2000);
            this.gbxBillete.Controls.Add(this.btn1000);
            this.gbxBillete.Location = new System.Drawing.Point(11, 565);
            this.gbxBillete.Name = "gbxBillete";
            this.gbxBillete.Size = new System.Drawing.Size(966, 98);
            this.gbxBillete.TabIndex = 76;
            this.gbxBillete.TabStop = false;
            // 
            // frmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(989, 680);
            this.Controls.Add(this.gbxBillete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCobrar";
            this.Load += new System.EventHandler(this.frmCobrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxBillete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRefPago;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnContado;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtCodTarjeta;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn2000;
        private System.Windows.Forms.Button btn5000;
        private System.Windows.Forms.Button btn10000;
        private System.Windows.Forms.Button btn15000;
        private System.Windows.Forms.Button btn20000;
        private System.Windows.Forms.Button btn50000;
        private System.Windows.Forms.Button btnCompleto;
        private System.Windows.Forms.GroupBox gbxBillete;
    }
}