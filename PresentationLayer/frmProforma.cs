using BusinessLayer;
using CommonLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmProforma : Form
    {

        public tbDocumento facturaGlobal = new tbDocumento();
        BFacturacion facturacionIns = new BFacturacion();
        public delegate void pasarDatos(tbDocumento documento);
        public event pasarDatos recuperarTotal;
        Bcliente clienteB = new Bcliente();


        public frmProforma()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProforma_Load(object sender, EventArgs e)
        {
            chkImprimir.Checked = (bool)Global.Usuario.tbEmpresa.imprimeDoc;
            chkImprimir.Visible = (bool)Global.Usuario.tbEmpresa.imprimeDoc;
            txtDias.Focus();
            cargarDatos();
        }

        private void cargarDatos()
        {
            tbClientes cliente = clienteB.GetClienteById(facturaGlobal.idCliente);


            if (facturaGlobal.tipoIdCliente == 1)
            {
                txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper() + " " + cliente.tbPersona.apellido1.Trim().ToUpper() + " " + cliente.tbPersona.apellido2.Trim().ToUpper();

            }
            else
            {
                txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper();

            }


            txtMonto.Text = facturaGlobal.tbDetalleDocumento.Sum(x=>x.totalLinea).ToString();

            txtDias.Text= Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().plazoMaximoProforma.ToString();


        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult resp = MessageBox.Show($"Esta seguro que desea realizar la PROFORMA por el MONTO: {txtMonto.Text} al CLIENTE: { txtCliente.Text}", "Generar Proforma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {

                    if (ValidarCampos())
                    {

                        facturaGlobal.plazo = int.Parse(txtDias.Text);

                        facturaGlobal = facturacionIns.guadar(facturaGlobal);
                        if (chkImprimir.Checked)
                        {
                            clsImpresionFactura imprimir = new clsImpresionFactura(facturaGlobal, Global.Usuario.tbEmpresa);
                            imprimir.print();
                        }

                        recuperarTotal(facturaGlobal);
                        this.Close();

                    }

                }

            }
            catch (Exception)
            {

                recuperarTotal(null);
            }
           

        }

        private bool ValidarCampos()
        {

            if (txtDias.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe indica la cantidad de días de valides de la proforma", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;


            }
            if (!Utility.isNumerInt(txtDias.Text)){

                MessageBox.Show("Datos incorrecto", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;


            }
            
            int dias =(int) Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().plazoMaximoProforma;


            if (int.Parse(txtDias.Text) > dias){

                MessageBox.Show($"La cantidad de días máximo de plazo para las proformas es de: {dias}, corrija los datos.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;


            }



            return true;
        }
    }
}
