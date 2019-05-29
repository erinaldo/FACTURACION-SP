using BusinessLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer;

namespace PresentationLayer
{
    public partial class frmAgregarAbono : Form
    {
        public static tbAbonos abonoGlobal = new tbAbonos();
        public static tbCreditos creditoGlobal = new tbCreditos();
        public static List<tbTipoMovimiento> tipoMovimientoGlobal = new List<tbTipoMovimiento>();
        public static List<tbCreditos> creditoGlobalNuevo = new List<tbCreditos>();
        public decimal saldo;
        public BMovimiento MovimientoB = new BMovimiento();
        public BCredito creditoB = new BCredito();
        public tbCreditos credito = new tbCreditos();
        public delegate void pasaAbono(tbCreditos entity);
        public event pasaAbono pasarAbonoEvent;

        public frmAgregarAbono()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            dtpFechaCredito.Value = DateTime.Now;
            txtMontoAbonado.Text = string.Empty;
        }
        private void frmAgregarAbono_Load(object sender, EventArgs e)
        {
            limpiar();
            frmAbonoCredito creditoIns = new frmAbonoCredito();
            // creditoIns.pasarCreditoAbonoEvent += obtieneCredito;
            lblSaldo.Text = creditoGlobal.saldoCredito.ToString();
            if (int.Parse(lblSaldo.Text) == 0)
            {
                MessageBox.Show("el credito ya ha sido cancelado");
                this.Dispose();
            }

        }

        public void obtieneCredito(ref tbCreditos entity)
        {
            creditoGlobal = entity;
        }
        public bool guardar()
        {
            try
            {
                tbAbonos abono = new tbAbonos();
                BAbonos abonoB = new BAbonos();

     
                abono.monto = int.Parse(txtMontoAbonado.Text);
                abono.estado = true;

                abono.fecha_crea = DateTime.Now;
                abono.fecha_ult_mod = DateTime.Now;
                abono.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                abono.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                abonoB.Guardar(abono);
                abonoGlobal = abono;
                //frmAbonoCredito.listaAbono.Add(abonoGlobal);
                //foreach (tbCreditos un in frmAbonoCredito.listaCredito)
                //{
                //    if (un.idCredito == frmAbonoCredito.creditoGlobal.idCredito)
                //    {
                //        saldo = un.saldoCredito;
                

                //    }

                //}

                return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }


        }



        private bool validar()
        {
            

            if (txtMontoAbonado.Text == string.Empty)
            {
                MessageBox.Show("Debes ingresar el monto a abonar");
                txtMontoAbonado.Focus();
                return false;
            }
            if (int.Parse(txtMontoAbonado.Text) > int.Parse(lblSaldo.Text))
            {
                MessageBox.Show("Debes ingresar un monto a abonar inferior al saldo");
                txtMontoAbonado.Focus();
                return false;
            }

            
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                guardar();
                //   pasarAbonoEvent(creditoGlobal);//abonoGloal null error
                this.Dispose();

            }
        }
    }
}
