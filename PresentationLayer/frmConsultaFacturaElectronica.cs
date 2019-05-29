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
    public partial class frmConsultaFacturaElectronica : Form
    {
        BFacturacion facturacion = new BFacturacion();
        public frmConsultaFacturaElectronica()
        {
            InitializeComponent();
        }

        private void frmConsultaFacturaElectronica_Load(object sender, EventArgs e)
        {
            cboTipoDoc.DataSource = Enum.GetValues(typeof(Enums.TipoDocumento));

            cboTipoBusqueda.DataSource = Enum.GetValues(typeof(Enums.ConsultarHacienda));
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
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
                            if ((int)cboTipoBusqueda.SelectedValue == (int)Enums.ConsultarHacienda.Clave)
                            {
                                txtXMLSinFirma.Text = facturacion.consultarFacturaElectronicaPorClave(txtClave.Text.Trim());
                            }
                            else if ((int)cboTipoBusqueda.SelectedValue == (int)Enums.ConsultarHacienda.Consecutivo)

                            {
                                txtXMLSinFirma.Text = facturacion.consultarFacturaElectronicaPorConsecutivo(txtClave.Text.Trim());


                            }
                            else

                            {
                                try
                                {
                                    if (cboTipoDoc.SelectedValue != null || (int)cboTipoDoc.SelectedValue != 0)
                                    {
                                        txtXMLSinFirma.Text = facturacion.consultarFacturaElectronicaPorIdFact(int.Parse(txtClave.Text.Trim()), (int)cboTipoDoc.SelectedValue);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe indicar un tipo de documento para poder consultar por ID de Documento");
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
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
            catch (Exception)
            {

                MessageBox.Show("Error al consultar los datos a haceinda, verifique y vuelva a intentarlo", "Error en la consulta.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
     

        }

        private void cboTipoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtXMLSinFirma.Text = string.Empty;
            if ((int)cboTipoBusqueda.SelectedValue == (int)Enums.ConsultarHacienda.IDDocumento)
            {
                cboTipoDoc.SelectedIndex = 1;
                cboTipoDoc.SelectedIndex = 0;
                cboTipoDoc.Enabled = true;


            }
            else
            {
                cboTipoDoc.Text = string.Empty;
                cboTipoDoc.SelectedIndex = 0;
                cboTipoDoc.Enabled = false;
            }
        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtXMLSinFirma.Text = string.Empty;
        }
    }
}
