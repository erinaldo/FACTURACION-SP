using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
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
    public partial class frmEmpresa : Form
    {
        BEmpresa empresaIns = new BEmpresa();
        tbEmpresa empresaGlobal = new tbEmpresa();
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
            Utility.EnableDisableForm(ref gbxDatos, false);
        
            tlsBtnBuscar.Enabled = false;
            tlsBtnCancelar.Enabled = false;
            tlsBtnEliminar.Enabled = false;
            tlsBtnSalir.Enabled = true;
            cargarDatos();

        }

        private void cargarDatos()
        {

            try
            {
                empresaGlobal.id = Global.Usuario.tbEmpresa.id.Trim();
                empresaGlobal.tipoId = Global.Usuario.tbEmpresa.tipoId;
                empresaGlobal = empresaIns.getEntity(empresaGlobal);
                cargarForm(empresaGlobal);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarForm(tbEmpresa empresa)
        {

            try
            {

                txtIdEmpresa.Text = empresa.id.Trim();
                if (empresa.tipoId == (int)Enums.TipoId.Fisica)
                {
                    txtNombreEmpresa.Text = empresa.tbPersona.nombre.Trim().ToUpper() + " " + empresa.tbPersona.apellido1.Trim().ToUpper() + " " + empresa.tbPersona.apellido2.Trim().ToUpper();

                }
                else
                {
                    txtNombreEmpresa.Text = empresa.tbPersona.nombre.Trim().ToUpper();

                }
                txtNombreComercial.Text = empresa.nombreComercial.Trim();

                //datos hacienda
                chkAmbienteDesa.Checked = (bool)!empresa.ambientePruebas;
                txtUsuarioHacienda.Text = empresa.usuarioApiHacienda.Trim();
                txtConstrasenaHacienda.Text = empresa.claveApiHacienda.Trim();

                txtCertificado.Text = empresa.certificadoInstalado.Trim();
                txtPinCertificado.Text = empresa.pin.ToString().Trim();

                txtRutaXML.Text = empresa.rutaCertificado.Trim();
                txtXMLCompras.Text = empresa.rutaXMLCompras.Trim();

                txtResolucion.Text = empresa.numeroResolucion.Trim();
                txtFechaResolucion.Text = empresa.fechaResolucio.ToString().Trim();

                //correo 
                txtCorreoEmpresa.Text = empresa.correoElectronicoEmpresa.Trim();
                txtContraseCorreo.Text = empresa.contrasenaCorreo.Trim();
                txtAsuntoCorreo.Text = empresa.subjectCorreo.Trim();
                txtCuerpoCorreo.Text = empresa.cuerpoCorreo.Trim();
                chkImprimeDoc.Checked = (bool)empresa.imprimeDoc;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                CargaCertificado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargaCertificado()
        {
            try
            {
                frmCertificado iCertificados = new frmCertificado();
                iCertificados.ShowDialog();
                txtCertificado.Text = iCertificados.thumbprint;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnRutaXML_Click(object sender, EventArgs e)
        {
            try
            {
                txtRutaXML.Text = BuscaCertificado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string BuscaCertificado()
        {
            try
            {
                OpenFileDialog iFile = new OpenFileDialog();
                iFile.ShowDialog();
                return iFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void btnRutaComprasXML_Click(object sender, EventArgs e)
        {
            try
            {
                txtXMLCompras.Text = BuscaCertificado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    modificar();
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxDatos, false);
                    tlsBtnBuscar.Enabled = false;
                    tlsBtnCancelar.Enabled = false;
                    tlsBtnEliminar.Enabled = false;
                    tlsBtnSalir.Enabled = true;
               
                    break;

                case "Nuevo":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxDatos, true);

                    Utility.ResetForm(ref gbxDatos);
                    break;

                case "Modificar":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxDatos, true);
                    tlsBtnSalir.Enabled = true;
                    //tlsBtnCancelar.Enabled = false;
                    txtIdEmpresa.Enabled = false;
                    txtNombreEmpresa.Enabled = false;
               


                    break;
                case "Eliminar":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;
                case "Buscar":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxDatos, true);

                    break;
                case "Cancelar":
               
                    Utility.ResetForm(ref gbxDatos);
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxDatos, false);
                    tlsBtnBuscar.Enabled = false;
                    tlsBtnCancelar.Enabled = false;
                    tlsBtnEliminar.Enabled = false;
                    tlsBtnSalir.Enabled = true;
                    cargarDatos();

                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }


        public void modificar()
        {
            DialogResult resp= MessageBox.Show("Esta seguro que desea modificar los datos?","Guardar datos",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            try
            {
                if (resp== DialogResult.Yes)
                {

                    if (validarDatos())
                    {
                        bool isNuevo = false;
                        if (empresaGlobal == null)
                        {
                            empresaGlobal = new tbEmpresa();
                            isNuevo = true;
                        }

                        empresaGlobal.nombreComercial = txtNombreComercial.Text;
                        empresaGlobal.ambientePruebas=!chkAmbienteDesa.Checked ;
                        empresaGlobal.usuarioApiHacienda= txtUsuarioHacienda.Text;
                        empresaGlobal.claveApiHacienda= txtConstrasenaHacienda.Text;

                        empresaGlobal.certificadoInstalado = txtCertificado.Text;
                        empresaGlobal.pin = int.Parse(txtPinCertificado.Text);

                        empresaGlobal.rutaCertificado = txtRutaXML.Text;
                        empresaGlobal.rutaXMLCompras = txtXMLCompras.Text;

                        empresaGlobal.numeroResolucion = txtResolucion.Text;
                        empresaGlobal.fechaResolucio = DateTime.Parse( txtFechaResolucion.Text);

                        //correo 
                        empresaGlobal.correoElectronicoEmpresa = txtCorreoEmpresa.Text;
                        empresaGlobal.contrasenaCorreo = txtContraseCorreo.Text;
                        empresaGlobal.subjectCorreo = txtAsuntoCorreo.Text;
                        empresaGlobal.cuerpoCorreo = txtCuerpoCorreo.Text;


                        empresaGlobal.imprimeDoc = chkImprimeDoc.Checked;
                        try
                        {
                            if (isNuevo)
                            {
                                empresaGlobal = empresaIns.guardar(empresaGlobal);
                            }
                            else
                            {
                                empresaGlobal = empresaIns.modificar(empresaGlobal);

                            }
                           
                            cargarDatos();
                            MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Global.Usuario.tbEmpresa = empresaGlobal;
                        }


                        catch (Exception)
                        {

                            MessageBox.Show("No se pudieron guardar los datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }               
            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool validarDatos()
        {


            if (txtUsuarioHacienda.Text.Trim()==string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Usuario Hacienda","Faltan datos", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuarioHacienda.Focus();
                return false;
            }
            else if (txtConstrasenaHacienda.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Contraseña Hacienda", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConstrasenaHacienda.Focus();
                return false;
            }
            else if (txtCertificado.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Certificado", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCertificado.Focus();
                return false;
            }
            else if (txtPinCertificado.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de PIN Certificado", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPinCertificado.Focus();
                return false;
            }
            else if (txtRutaXML.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar donde se guardarán los XML emitidos por el sistema", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRutaXML.Focus();
                return false;
            }
            else if (txtXMLCompras.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar donde se guardarán los XML de Compras", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXMLCompras.Focus();
                return false;
            }
            else if (txtResolucion.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar la resolución Hacienda", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResolucion.Focus();
                return false;
            }
            else if (txtFechaResolucion.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar la fecha de resolución Hacienda", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFechaResolucion.Focus();
                return false;
            }
            else if (txtCorreoEmpresa.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar el correo institucional", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreoEmpresa.Focus();
                return false;
            }
            else if (!Utility.isValidEmail(txtCorreoEmpresa.Text))
            {

                MessageBox.Show("El correo indicado no tiene formato correcto.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreoEmpresa.Focus();
                return false;
            }
            else if (txtContraseCorreo.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar una contraseña para el correo institucional", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseCorreo.Focus();
                return false;
            }
            else if (txtAsuntoCorreo.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar un asunto para el envio de correos.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAsuntoCorreo.Focus();
                return false;
            }
            else if (txtCuerpoCorreo.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar mensaje para el cuerpo de los correos institucionales.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuerpoCorreo.Focus();
                return false;
            }

            return true;


        }

        private void gbxHacienda_Enter(object sender, EventArgs e)
        {

        }
    }
}
