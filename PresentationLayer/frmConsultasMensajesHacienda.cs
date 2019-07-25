using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BussinessExceptions;
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
    public partial class frmConsultasMensajesHacienda : Form
    {




        BFacturacion facturacion = new BFacturacion();
        public frmConsultasMensajesHacienda()
        {
            InitializeComponent();
        }

        private void cboTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtXMLSinFirma.Text = string.Empty;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {


            consultar();
        }

        private void consultar()
        {
            if (Utility.AccesoInternet())
            {
                try
                {
                    if (txtClave.Text == string.Empty)
                    {
                        MessageBox.Show("Debe indicar una valor a buscar");

                    }
                    else
                    {
                        tbReporteHacienda mensaje;
                        if ((int)cboTipoBusqueda.SelectedValue == (int)Enums.ConsultarHacienda.Clave)
                        {
                            mensaje = facturacion.consultarMensajePorClave(txtClave.Text.Trim());
                        }
                        else if ((int)cboTipoBusqueda.SelectedValue == (int)Enums.ConsultarHacienda.Consecutivo)

                        {

                            mensaje = facturacion.consultarMensajePorConsecutivo(txtClave.Text.Trim());

                        }
                        else

                        {

                            mensaje = facturacion.consultarMensajePorId(int.Parse(txtClave.Text.Trim()));

                        }

                        if (mensaje is null)
                        {
                            txtXMLSinFirma.Text = "No se encontro el mensaje con los datos suministrados, favor verifique los datos.";

                        }
                        else
                        {

                            txtXMLSinFirma.Text = facturacion.consultarMensaje(mensaje);
                        }




                    }
                }
                catch (TokenException ex)
                {

                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se produjo un error al consultar a Hacienda.");
                }
            }
            else
            {
                MessageBox.Show("No hay acceso a internet", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmConsultasMensajesHacienda_Load(object sender, EventArgs e)
        {
            cboTipoBusqueda.DataSource = Enum.GetValues(typeof(Enums.ConsultarHacienda));
          
        }
    }
}
