using BusinessLayer;
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

namespace PresentationLayer
{
    public partial class frmClienteReporte : Form
    {
        tbClientes clienteGlo;
        Bcliente BCliente = new Bcliente();
        public delegate void pasaDatos(tbClientes entity);
        public event pasaDatos pasarDatosEvent;

        public frmClienteReporte()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

            FrmBuscar buscar = new FrmBuscar();
            buscar.pasarDatosEvent += dataBuscar;
            buscar.ShowDialog();
        }
        private void dataBuscar(tbClientes cliente)
        {           
            if (cliente != null)
            {

                clienteGlo = cliente;
                txtIdCliente.Text = cliente.id.Trim();
                if (cliente.tipoId == 1)
                {
                    txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper() + " " + cliente.tbPersona.apellido1.Trim().ToUpper() + " " + cliente.tbPersona.apellido2.Trim().ToUpper();

                }
                else
                {
                    txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper();

                }                
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtIdCliente.Text != string.Empty)
                {
                    try
                    {
                        clienteGlo = BCliente.GetClienteById(txtIdCliente.Text.Trim());
                        if (clienteGlo != null)
                        {
                            dataBuscar(clienteGlo);
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró el Cliente con el ID: {txtIdCliente.Text.Trim()}", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            clienteGlo = null;
                            txtIdCliente.Text = string.Empty;
                            txtCliente.Text = string.Empty;
                        

                        }
                    }
                    catch (Exception)
                    {
                        txtCliente.Text = string.Empty;
                        MessageBox.Show("No se pudo obtener el Cliente, verifique los datos", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (clienteGlo !=null)
            {
                pasarDatosEvent(clienteGlo);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteGlo = null;
            pasarDatosEvent(null);
            this.Close();
        }

        private void frmClienteReporte_Load(object sender, EventArgs e)
        {
            txtCliente.Focus();
        }
    }
}
