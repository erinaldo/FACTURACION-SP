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
    public partial class frmAgregarCreditos : Form
    {

        public static List<tbTipoMovimiento> tipoMovimientoGlobal = new List<tbTipoMovimiento>();
        public int idGlobal = 0;
        public tbCreditos creditoGlobal = new tbCreditos();
        public tbClientes puestoGlobal = new tbClientes();
        public BCredito creditoB = new BCredito();
        public delegate void pasaCredito(tbCreditos entity);
        public event pasaCredito pasarCreditoEvent;



        public frmAgregarCreditos()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtAbonoInicial.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtMotivo.Text = string.Empty;
            dtpFechaCredito.Value = DateTime.Now;
        }

        private void frmAgregarCreditos_Load(object sender, EventArgs e)
        {
            limpiar();
        }

        public void asignarPuestoGlobal(ref tbClientes entity)
        {
            puestoGlobal = entity;
        }
        public void guardar()
        {
            try
            {
                tbCreditos credito = new tbCreditos();
                List<tbAbonos> listaMov = new List<tbAbonos>();
                tbMovimientos movimiento = new tbMovimientos();
                tbAbonos abono = new tbAbonos();

                movimiento.fecha = dtpFechaCredito.Value;
                movimiento.estado = chkEstado.Checked;
                movimiento.motivo = txtMotivo.Text;
                movimiento.total = decimal.Parse(txtMonto.Text);
                movimiento.idTipoMov = (int)Enums.tipoMovimiento.Credito;
                movimiento.fecha_ult_mod = DateTime.Now;
                movimiento.fecha_crea = DateTime.Now;
                movimiento.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                movimiento.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();



                credito.idCliente = puestoGlobal.id.Trim();
                credito.tipoCliente = puestoGlobal.tipoId;
                credito.idMov = movimiento.idMovimiento;// no lo esta agarrand
                credito.idEstado = chkEstado.Checked;
                credito.estadoCredito = chkEstado.Checked;
                credito.fecha_ult_mod = DateTime.Now;
                credito.fecha_crea = DateTime.Now;
                credito.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                credito.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                credito.montoCredito = decimal.Parse(txtMonto.Text);
                if (txtAbonoInicial.Text != string.Empty)
                {
                    credito.saldoCredito = decimal.Parse(txtMonto.Text) - decimal.Parse(txtAbonoInicial.Text);
                }
                else
                {
                    credito.saldoCredito = decimal.Parse(txtMonto.Text);
                }

                //abono.idCredito = credito.idCredito;
                //abono.motivo = txtMotivo.Text;
                abono.fecha_crea = DateTime.Now;
                abono.fecha_ult_mod = DateTime.Now;
                abono.monto = decimal.Parse(txtAbonoInicial.Text);
                abono.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                abono.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                abono.estado = true;
                listaMov.Add(abono);
                //listaMov.Add(movimiento);
                credito.tbMovimientos = movimiento;
                //credito.tbAbonos = listaMov;

                //BCredito nuevo = new BCredito();
                ////nuevo.Guardar(credito);// va a guardar, se debe de mandar a listaCreditos mejor
                //frmAbonoCredito.listaCredito.Add(credito);
                //frmAbonoCredito.listaAbono = listaMov;
                creditoGlobal = credito;


            }//fin try
            catch (EntityExistException ex)
            {

                MessageBox.Show(ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private bool validar()
        {
            if (txtMonto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el monto del credito");
                txtMonto.Focus();
                return false;
            }
            if (txtAbonoInicial.Text != string.Empty && int.Parse(txtAbonoInicial.Text) > int.Parse(txtMonto.Text))
            {
                MessageBox.Show("Debe ingresar el abono inferior al monto del credito");
                txtAbonoInicial.Focus();
                return false;
            }
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                guardar();
                //  pasarCreditoEvent(creditoGlobal);
                this.Dispose();
            }




        }
    }
}