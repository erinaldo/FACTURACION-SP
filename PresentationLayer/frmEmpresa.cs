using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
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
    public partial class frmEmpresa : Form
    {
        BActividadesEconomicas actIns = new BActividadesEconomicas();
        BEmpresa empresaIns = new BEmpresa();
        tbEmpresa empresaGlobal = new tbEmpresa();
        List<tbEmpresaActividades> listaActividades = new List<tbEmpresaActividades>();
        tbEmpresaActividades empresaAct= new tbEmpresaActividades();
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {

            //MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
            //Utility.EnableDisableForm(ref gbxDatos, false);

            cboTipoFactRegimenSimplificado.Enabled = false;
            tlsBtnBuscar.Enabled = false;
            tlsBtnCancelar.Enabled = false;
            tlsBtnEliminar.Enabled = false;
            tlsBtnSalir.Enabled = true;
            cargarDatos();

        }

        private void cargarDatos()
        {
            cboTipoFactRegimenSimplificado.DataSource = Enum.GetValues(typeof(Enums.TipoFacturacionElectRegimenSimplificado));
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
               
               

                //datos hacienda
                chkAmbienteDesa.Checked = (bool)!empresa.ambientePruebas;
                txtUsuarioHacienda.Text = empresa.usuarioApiHacienda.Trim();
                txtConstrasenaHacienda.Text = empresa.claveApiHacienda.Trim();

                chkRegimenSimplificado.Checked = empresa.regimenSimplificado;
                if (chkRegimenSimplificado.Checked)
                {
                    cboTipoFactRegimenSimplificado.Text = Enum.GetName(typeof(Enums.TipoFacturacionElectRegimenSimplificado), empresa.tipoFacturacionRegimen); 

                }
                else
                {
                    cboTipoFactRegimenSimplificado.ResetText();
                }

                txtCertificado.Text = empresa.certificadoInstalado.Trim();
                txtPinCertificado.Text = empresa.pin.ToString().Trim();

                txtRutaXML.Text = empresa.rutaCertificado.Trim();
                txtXMLCompras.Text = empresa.rutaXMLCompras.Trim();

                txtResolucion.Text = empresa.numeroResolucion.Trim();
                txtFechaResolucion.Text = empresa.fechaResolucio.ToString().Trim();

      
               
                chkImprimeDoc.Checked = (bool)empresa.imprimeDoc;
                if (chkImprimeDoc.Checked)
                {
                    txtNombreImpresora.Text = empresa.nombreImpresora.Trim();
                }           

                foreach (var item in empresa.tbEmpresaActividades)
                {
                    listaActividades.Add(item);
                }
                cargarListaActividad(listaActividades);

            }
            catch (Exception ex)
            {

                throw;
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

                        //empresaGlobal.nombreComercial = txtNombreComercial.Text;
                        empresaGlobal.ambientePruebas=!chkAmbienteDesa.Checked ;
                        empresaGlobal.usuarioApiHacienda= txtUsuarioHacienda.Text;
                        empresaGlobal.claveApiHacienda= txtConstrasenaHacienda.Text;
                        //empresaGlobal.codigoActComercial = txtActEconomica.Text;
                        empresaGlobal.certificadoInstalado = txtCertificado.Text;
                        empresaGlobal.pin = int.Parse(txtPinCertificado.Text);


                        empresaGlobal.regimenSimplificado = chkRegimenSimplificado.Checked;
                        if (empresaGlobal.regimenSimplificado)
                        {
                            empresaGlobal.tipoFacturacionRegimen = (int)cboTipoFactRegimenSimplificado.SelectedValue;

                        }
                        else
                        {
                            empresaGlobal.tipoFacturacionRegimen = null;
                        }

                        empresaGlobal.rutaCertificado = txtRutaXML.Text;
                        empresaGlobal.rutaXMLCompras = txtXMLCompras.Text;

                        empresaGlobal.numeroResolucion = txtResolucion.Text;
                        empresaGlobal.fechaResolucio = DateTime.Parse( txtFechaResolucion.Text);

                        ////correo 
                        //empresaGlobal.correoElectronicoEmpresa = txtCorreoEmpresa.Text;
                        //empresaGlobal.contrasenaCorreo = txtContraseCorreo.Text;
                        //empresaGlobal.subjectCorreo = txtAsuntoCorreo.Text;
                        //empresaGlobal.cuerpoCorreo = txtCuerpoCorreo.Text;


                        empresaGlobal.imprimeDoc = chkImprimeDoc.Checked;
                        empresaGlobal.nombreImpresora = txtNombreImpresora.Text;



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

             if (txtActEconomica.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar el código de la actividad económica de la empresa", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActEconomica.Focus();
                return false;
            }

            else if (chkRegimenSimplificado.Checked)
            {
                if (cboTipoFactRegimenSimplificado.Text==String.Empty)
                {
                    MessageBox.Show("Debe indicar Tipo Facturación electrónica para el régimen simplificado", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboTipoFactRegimenSimplificado.Focus();
                    return false;
                }
           
            }
            else if (txtUsuarioHacienda.Text.Trim()==string.Empty)
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
             
            else if (chkImprimeDoc.Checked && txtNombreImpresora.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar el nombre de la impresora.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreImpresora.Focus();
                return false;
            }


            return true;


        }
        
        private void btnCertificado_Click_1(object sender, EventArgs e)
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

        private void chkRegimenSimplificado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegimenSimplificado.Checked)
            {
                cboTipoFactRegimenSimplificado.Enabled = true;
            }
            else
            {
                cboTipoFactRegimenSimplificado.Enabled = false;
            }
        }

        private void btnRutaCompras_Click(object sender, EventArgs e)
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

        private void btnRuta_Click(object sender, EventArgs e)
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

        private void btnActividadEconomica_Click(object sender, EventArgs e)
        {
            buscarAct buscar = new buscarAct();


            buscar.pasarDatosEvent += pasarDatos;

            buscar.ShowDialog();

        }

        private void pasarDatos(tbActividades entity)
        {

            cargarDatosActividadEconica(entity);
        }

        private void cargarDatosActividadEconica(tbActividades act  )
        {
            txtActEconomica.Text = act.codigoAct;
            txtNombreAct.Text = act.nombreAct.Trim().ToUpper();


        }

        private void txtActEconomica_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                string codigo = txtActEconomica.Text.Trim().ToUpper();
                if (codigo != string.Empty)
                {
                    buscarAct();

                }
                else
                {
                    txtActEconomica.ResetText();
                    txtNombreAct.ResetText();

                }
               
            }
        }

        private void buscarAct()
        {
            try
            {
                tbActividades act = new tbActividades();
                act.codigoAct = txtActEconomica.Text.Trim().ToUpper();
                act = actIns.getById(act);
                if (act != null)
                {
                    txtActEconomica.Text = act.codigoAct;
                    txtNombreAct.Text = act.nombreAct.Trim().ToUpper();
                }
                else
                {
                    txtActEconomica.ResetText();
                    txtNombreAct.ResetText();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAgregarAct_Click(object sender, EventArgs e)
        {
            if (validarDatosActividadEco())
            {
                tbEmpresaActividades act = new tbEmpresaActividades();
                act.CodActividad = txtActEconomica.Text;
                act.contrasenaCorreo = txtContraseCorreo.Text;
                act.correoElectronicoEmpresa = txtCorreoEmpresa.Text;
                act.cuerpoCorreo = txtCuerpoCorreo.Text;
                act.nombreComercial = txtNombreComercial.Text;
                act.subjectCorreo = txtAsuntoCorreo.Text;
                listaActividades.Add(act);
                cargarListaActividad(listaActividades);
                resetFormActividadComercial();
            }
        }

        private void cargarListaActividad(List<tbEmpresaActividades> listaActividades)
        {
            lstvActividades.Items.Clear();
            foreach (var act in listaActividades)
            {
                ListViewItem item = new ListViewItem();
                item.Text = act.CodActividad;
                txtActEconomica.Text = act.CodActividad; buscarAct();
                item.SubItems.Add(txtNombreAct.Text.Trim().ToUpper());
                lstvActividades.Items.Add(item);
            }
            txtActEconomica.ResetText();
            txtNombreAct.ResetText();
        }

        private void resetFormActividadComercial()
        {
            txtNombreAct.ResetText();
            txtActEconomica.Text=string.Empty;
            txtContraseCorreo.Text = string.Empty;
            txtCorreoEmpresa.Text = string.Empty;
            txtCuerpoCorreo.Text = string.Empty;
            txtNombreComercial.Text = string.Empty;
            txtAsuntoCorreo.Text = string.Empty;
            empresaAct = null;
        }

        private bool validarDatosActividadEco()
        {

            if (txtActEconomica.Text.Trim() == string.Empty || txtNombreAct.Text==string.Empty)
            {

                MessageBox.Show("Debe indicar la actividad Económica", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActEconomica.Focus();
                return false;
            }
            else if (listaActividades.Where(x=>x.CodActividad.Trim().ToUpper()==txtActEconomica.Text.Trim().ToUpper()).SingleOrDefault()!=null)
            {
                MessageBox.Show("Ya existe esa actividad económica asiganada", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtActEconomica.Focus();
                txtNombreAct.ResetText();
                txtActEconomica.ResetText();
                return false;

            }
           
            else if (txtNombreComercial.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar el nombre comercial", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreComercial.Focus();
                return false;
            }

            else if (txtCorreoEmpresa.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe indicar el correo de la empresa", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lstvActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvActividades.SelectedItems.Count > 0)
            {

                empresaAct= listaActividades.Where(x => x.CodActividad.Trim().ToUpper() == lstvActividades.SelectedItems[0].Text.Trim().ToUpper()).SingleOrDefault();

             
                txtActEconomica.Text = empresaAct.CodActividad.Trim();
                buscarAct();
                txtContraseCorreo.Text = empresaAct.contrasenaCorreo.Trim(); 
                txtCorreoEmpresa.Text = empresaAct.correoElectronicoEmpresa.Trim();
                txtCuerpoCorreo.Text = empresaAct.cuerpoCorreo.Trim();
                txtNombreComercial.Text = empresaAct.nombreComercial.Trim() ;
                txtAsuntoCorreo.Text = empresaAct.subjectCorreo.Trim();

            }
        }

        private void btnEliminarAct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar la actividad económoica?", "Actividad Económica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                listaActividades.Remove(listaActividades.Where(x => x.CodActividad == lstvActividades.SelectedItems[0].Text).SingleOrDefault());
                cargarListaActividad(listaActividades);
                resetFormActividadComercial();

            }

        }

        private void txtActEconomica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
