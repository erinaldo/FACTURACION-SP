using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using CommonLayer;
using BusinessLayer;
using CommonLayer.Exceptions.BussinessExceptions;

namespace PresentationLayer
{
    public partial class frmCobrar : Form
    {

        
        //public float totalPagar = 0.0f;
       public tbDocumento facturaGlobal = new tbDocumento();
        BFacturacion facturacionIns = new BFacturacion();
        Bcliente clienteB = new Bcliente();
        public delegate void pasarDatos(tbDocumento documento);
        public event pasarDatos recuperarTotal;

        int bandera;

        public frmCobrar()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

        //Menu forma de pago
        #region Botones Forma de pago

     

      

        #endregion

        //Teclado Numerico
        #region Botones numericos.

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if(txtPago.Text == "0")
            {
               
            }
            else
            {
                txtPago.Text += "0";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (txtPago.Text == "0")
            {
                txtPago.Text = "1";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "1";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (txtPago.Text == "0")
            {
                txtPago.Text = "2";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "2";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (txtPago.Text == "0")
            {
                txtPago.Text = "3";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "3";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (txtPago.Text == "0")
            {
                txtPago.Text = "4";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "4";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            
            if (txtPago.Text == "0")
            {
                txtPago.Text = "5";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "5";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            
            if (txtPago.Text == "0")
            {
                txtPago.Text = "6";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "6";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            
            if (txtPago.Text == "0")
            {
                txtPago.Text = "7";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "7";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            
            if (txtPago.Text == "0")
            {
                txtPago.Text = "8";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "8";
            }
            btnBorrar.Enabled = true;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            
            if (txtPago.Text == "0")
            {
                txtPago.Text = "9";
                btnNum0.Enabled = true;
            }
            else
            {
                txtPago.Text += "9";
            }
            btnBorrar.Enabled = true;

        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            
            txtPago.Text += ",";
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(txtPago.Text != "")
            {
                txtPago.Text = txtPago.Text.Substring(0, txtPago.Text.Count() - 1);
                if (txtPago.Text == "")
                {
                    btnBorrar.Enabled = false;
                }
            }
            
            else if(txtPago.Text == "")
            {
                btnBorrar.Enabled = false;
            }
            
            btnNum0.Enabled = true;
        }

        #endregion


        private void frmCobrar_Load(object sender, EventArgs e)
        {

          
            chkImprimir.Checked = (bool)Global.Usuario.tbEmpresa.imprimeDoc;
            chkImprimir.Visible = (bool)Global.Usuario.tbEmpresa.imprimeDoc;


            botonesTipoPagoEstado((int)Enums.TipoPago.Efectivo);
            calcularTotal();
            txtPago.Focus();
            txtPago.SelectAll() ;
       

        }

        private void calcularTotal()
        {
            decimal total = 0;
            foreach (tbDetalleDocumento detalle in facturaGlobal.tbDetalleDocumento)
            {         
                total += detalle.totalLinea;               

            }
            txtMontoTotal.Text = total.ToString("#.##");

        }

        private void botonesTipoPagoEstado(int tipoPago)
        {
            
            if (tipoPago == (int)Enums.TipoPago.Efectivo)
            {
                bandera = 1;
                gbxBillete.Enabled = true;
                btnContado.Enabled = false;
                btnTarjeta.Enabled = true;
                btnCredito.Enabled = true;
                txtCodTarjeta.Enabled = false;
                txtCodTarjeta.Text = string.Empty;
                txtPago.Text = "0";
                txtVuelto.Text = "0";
                txtPago.Enabled = true;
                txtPlazo.Text = string.Empty;
                txtPlazo.Enabled = false;

                btnContado.BackColor = Color.DarkGray;
                btnTarjeta.BackColor = Color.White;
                btnCredito.BackColor = Color.White;

                facturaGlobal.tipoVenta = (int)Enums.tipoVenta.Contado;
                facturaGlobal.tipoPago = (int)Enums.TipoPago.Efectivo;
                facturaGlobal.estadoFactura = (int)Enums.EstadoFactura.Cancelada;
                txtTipoPago.Text = "Contado";
                txtPago.Focus();

            }
            else if (tipoPago == (int)Enums.TipoPago.Tarjeta)
            {
                bandera = 2;
                gbxBillete.Enabled = false;
                btnTarjeta.Enabled = false;
                btnContado.Enabled = true;
                btnCredito.Enabled = true;
                txtCodTarjeta.Enabled = true;
                txtPago.Enabled = false;
                txtPago.Text = "0";
                txtVuelto.Text = "0";
                txtCodTarjeta.Focus();
                txtPlazo.Text = string.Empty;
                txtPlazo.Enabled = false;


                btnContado.BackColor = Color.White;
                btnTarjeta.BackColor = Color.DarkGray;
                btnCredito.BackColor = Color.White;
                facturaGlobal.tipoVenta = (int)Enums.tipoVenta.Contado;
                facturaGlobal.tipoPago = (int)Enums.TipoPago.Tarjeta;
                facturaGlobal.estadoFactura = (int)Enums.EstadoFactura.Cancelada;

                txtTipoPago.Text = "Tarjeta";
            }
            else if (tipoPago == (int)Enums.TipoPago.Otros)
            {
                bandera = 3;
                gbxBillete.Enabled = false;
                btnCredito.Enabled = false;
                btnTarjeta.Enabled = true;
                btnContado.Enabled = true;
                txtCodTarjeta.Enabled = false;
                txtCodTarjeta.Text = string.Empty;
                txtPago.Text = "0";
                txtVuelto.Text = "0";
                txtPago.Enabled = false;
     
                int plazoEmpresa = (int)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().plazoMaximoCredito;
                int plazoCliente = 0;
                if (facturaGlobal.idCliente!=null)                {

          
                    plazoCliente = facturaGlobal.tbClientes.plazoCreditoMax;
                }

                txtPlazo.Text = plazoCliente > plazoEmpresa ? plazoEmpresa.ToString() : plazoCliente.ToString();      

                txtPlazo.Enabled = true;


                btnContado.BackColor = Color.White;
                btnTarjeta.BackColor = Color.White;
                btnCredito.BackColor = Color.DarkGray;

                facturaGlobal.tipoVenta= (int)Enums.tipoVenta.Credito;
                facturaGlobal.tipoPago = (int)Enums.TipoPago.Efectivo;
                facturaGlobal.estadoFactura = (int)Enums.EstadoFactura.Pendiente;

                txtTipoPago.Text = "Crédito";
            }

        }

        

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            
         if (txtPago.Text != "")
        {
            if (decimal.Parse(txtPago.Text) != decimal.Parse("0"))
            {
            //calcular vuelto
            decimal MontoPago = decimal.Parse(txtPago.Text.Trim());
            txtVuelto.Text = (MontoPago - decimal.Parse(txtMontoTotal.Text)).ToString();
            }
         }

            else if (txtPago.Text == "")
            {
               btnNum0.Enabled = true;
            }
        }

        private bool ValidarCampos()
        {
            if(!btnContado.Enabled) 
            {
                if (txtPago.Text == string.Empty || txtPago.Text == "0")
                {
                    
                    MessageBox.Show("Digite el monto con que paga", "Monto de Pago necesario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPago.Focus();
                    return false;
                }

                if (!Utility.isNumeroDecimal(txtPago.Text))
                {

                    MessageBox.Show("Dato incorrecto", "Monto de Pago necesario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPago.Focus();
                    return false;
                }
                if (decimal.Parse(txtVuelto.Text) < 0)
                {
                    MessageBox.Show("Monto incorrecto", "Error al procesar solicitud",  MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPago.Focus();
                    return false;
                }

            }

            else if(!btnTarjeta.Enabled )
            {
                if (txtPago.Text == string.Empty || txtPago.Text == "0")
               

                if (txtCodTarjeta.Text == string.Empty)
                {
                    MessageBox.Show("Codigo de tarjeta no digitado o erroneo","Error al procesar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCodTarjeta.Focus();
                    return false;
                }
            }
            else if (!btnCredito.Enabled)
            {
                if (facturaGlobal.idCliente ==null)
                {
                    MessageBox.Show("Al ser una factura al crédito debe indicar un cliente, favor corrija los datos.", "Error al procesar solicitud", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;

                }
                if (txtPlazo.Text ==string.Empty || !Utility.isNumerInt(txtPlazo.Text))
                {
                    MessageBox.Show("Debe indicar un plazo para del crédito.", "Plazo crédito", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;

                }

                if (facturaGlobal.tbClientes.plazoCreditoMax==0)
                {
                    MessageBox.Show("El cliente no se le puede aplicar crédito.", "Cliente sin crédito", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;

                }

                if (decimal.Parse(txtMontoTotal.Text)>facturaGlobal.tbClientes.creditoMax )
                {
                    MessageBox.Show($"El crédito excede el monto máximo indicado al cliente. Máximo crédito permitido: {facturaGlobal.tbClientes.creditoMax}", "Cliente sin crédito", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;

                }



            }

            return true;
        }

        /// <summary>
        /// Valida campos antes de guardar datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea generar la facturación, ¿Desea continuar?", "Facturación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cobrar();
            }
           
           
        }
        public void cobrar() {
            try
            {

                if (ValidarCampos())
                {

                    if (!btnTarjeta.Enabled)
                    {
                        facturaGlobal.refPago = txtCodTarjeta.Text;
                    }
                    else if (!btnCredito.Enabled)
                    {
                        facturaGlobal.plazo = int.Parse(txtPlazo.Text);
                    }
                    facturaGlobal.tbClientes = null;
                    facturaGlobal = facturacionIns.guadar(facturaGlobal);
                    facturaGlobal = facturacionIns.getEntity(facturaGlobal);
                    if (chkImprimir.Checked)
                    {
                        try
                        {
                            //DialogResult dialogResult = MessageBox.Show("Desea imprimir el documento?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            //if (dialogResult == DialogResult.Yes)
                            //{

                            decimal pago = txtPago.Text == string.Empty ? 0 : decimal.Parse(txtPago.Text);
                            decimal vuelto = txtVuelto.Text == string.Empty ? 0 : decimal.Parse(txtVuelto.Text);


                            clsImpresionFactura imprimir = new clsImpresionFactura(facturaGlobal, Global.Usuario.tbEmpresa, pago, vuelto);
                            imprimir.print();
                            //}

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("No se pudo imprimir el documento", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                   
                    recuperarTotal(facturaGlobal);
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                recuperarTotal(null);
            }





        }

        /// <summary>
        /// niega el ingreso de valores no numericos al textbox de pago
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeniedNonNumeric(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                cobrar();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar.ToString()==".")
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
           
        }

        /// <summary>
        /// al presionar la tecla retroceso/backspace este llama a la funcion del boton borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspace(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                btnBorrar.PerformClick();
            }
        }

        /// <summary>
        ///  al presionar la tecla retroceso/backspace este llama a la funcion del boton borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspacebtn(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                btnBorrar.PerformClick();
            }
        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            botonesTipoPagoEstado((int)Enums.TipoPago.Efectivo);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            botonesTipoPagoEstado((int)Enums.TipoPago.Tarjeta);
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            botonesTipoPagoEstado((int)Enums.TipoPago.Otros);
        }

        private void txtPago_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPago.Text = "1000";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPago.Text = "5000";
        }

        private void btnCompleto_Click(object sender, EventArgs e)
        {
            txtPago.Text = txtMontoTotal.Text;
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            txtPago.Text = "2000";
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            txtPago.Text = "10000";
        }

        private void btn15000_Click(object sender, EventArgs e)
        {
            txtPago.Text = "15000";
        }

        private void btn20000_Click(object sender, EventArgs e)
        {
            txtPago.Text = "20000";
        }

        private void btn50000_Click(object sender, EventArgs e)
        {
            txtPago.Text = "50000";
        }

        private void txtPago_DoubleClick(object sender, EventArgs e)
        {
            txtPago.Text = "";
            txtPago.Focus();
        }
    }
}
