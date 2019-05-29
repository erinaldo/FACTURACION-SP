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
    public partial class frmParametrosEmpresa : Form
    {

        BEmpresa empresaIns = new BEmpresa();
        tbParametrosEmpresa parametrosGlobal = new tbParametrosEmpresa();
        public frmParametrosEmpresa()
        {
            InitializeComponent();
        }

        private void frmParametrosEmpresa_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
            Utility.EnableDisableForm(ref gbxDatos, false);
            tlsBtnBuscar.Enabled = false;
            tlsBtnCancelar.Enabled = false;
            tlsBtnEliminar.Enabled = false;
            tlsBtnSalir.Enabled = true;
            cargarDatos();
            //listainve = inveIns.GetListEntities(3);
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void cargarDatos()
        {

            try
            {
                parametrosGlobal.idEmpresa = Global.Usuario.tbEmpresa.id.Trim();
                parametrosGlobal.idTipoEmpresa = Global.Usuario.tbEmpresa.tipoId;
                parametrosGlobal = empresaIns.getEntityParametros(parametrosGlobal);
                cargarForm(parametrosGlobal);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarForm(tbParametrosEmpresa parametros)
        {

            try
            {
                txtUtilidadBase.Text = parametros.utilidadBase.ToString();
                txtDescBase.Text = parametros.descuentoBase.ToString();
                txtCambioDolar.Text = parametros.cambioDolar.ToString();
                txtPlazoCredMax.Text = parametros.plazoMaximoCredito.ToString();
                txtPlazoMaxProf.Text = parametros.plazoMaximoProforma.ToString();
                chkAprobDes.Checked = (bool)parametros.aprobacionDescuento;
                chkManejaInventario.Checked = (bool)parametros.manejaInventario;
                txtPrecioBase.Text = parametros.precioBase.ToString();
                chkFacturacionElectronica.Checked = (bool)parametros.facturacionElectronica;
                chkObligaClienteFacturacion.Checked = (bool)parametros.clienteObligatorioFact;
           

            }
            catch (Exception)
            {

                throw;
            }
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
            DialogResult resp = MessageBox.Show("Esta seguro que desea modificar los datos?", "Guardar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (resp == DialogResult.Yes)
                {

                    if (validarDatos())
                    {
                        //bool isNuevo = false;
                        //if (empresaGlobal.tbParametrosEmpresa == null)
                        //{
                        //    empresaGlobal.tbParametrosEmpresa = new tbParametrosEmpresa();
                        //    isNuevo = true;
                        //}
                        tbParametrosEmpresa parametros = new tbParametrosEmpresa();
                        parametros.id = parametrosGlobal.id;
                        parametros.utilidadBase = float.Parse(txtUtilidadBase.Text.Trim());
                        parametros.descuentoBase = decimal.Parse(txtDescBase.Text.Trim());
                        parametros.cambioDolar = decimal.Parse(txtCambioDolar.Text.Trim());

                        parametros.plazoMaximoCredito = int.Parse(txtPlazoCredMax.Text.Trim());
                        parametros.plazoMaximoProforma = int.Parse(txtPlazoMaxProf.Text.Trim());
                        parametros.precioBase = int.Parse(txtPrecioBase.Text.Trim());

                        parametros.aprobacionDescuento = chkAprobDes.Checked;
                        parametros.manejaInventario = chkManejaInventario.Checked;
                        parametros.facturacionElectronica = chkFacturacionElectronica.Checked;
                        parametros.clienteObligatorioFact = chkObligaClienteFacturacion.Checked;

                        parametros.idEmpresa = parametrosGlobal.idEmpresa;
                        parametros.idTipoEmpresa = parametrosGlobal.idTipoEmpresa;


                        try
                        {
                            //if (isNuevo)
                            //{
                            //    empresaGlobal = empresaIns.guardar(empresaGlobal);
                            //}
                            //else
                            //{
                            empresaIns.modificarParamtros(parametros);

                            //}

                           
                            MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("No se pudieron guardar los datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                cargarDatos();
            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool validarDatos()
        {

             if (txtPrecioBase.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Precio Base", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioBase.Focus();
                return false;
            }
            else if (!Utility.isNumerInt(txtPrecioBase.Text.Trim()))
            {

                MessageBox.Show("No es un valor válido, Precio Base", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioBase.Focus();
                return false;
            }
            else if (txtUtilidadBase.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo Utilidad Base", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUtilidadBase.Focus();
                return false;
            }
            else if (txtDescBase.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Descuento Base", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescBase.Focus();
                return false;
            }
            else if (!Utility.isNumeroDecimal(txtDescBase.Text.Trim()))
            {

                MessageBox.Show("No es un valor válido, Utilidad Base", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescBase.Focus();
                return false;
            }
            else if (txtCambioDolar.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Cambio Dólar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCambioDolar.Focus();
                return false;
            }
            else if (!Utility.isNumeroDecimal(txtCambioDolar.Text.Trim()))
            {

                MessageBox.Show("No es un valor válido, Cambio Dólar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCambioDolar.Focus();
                return false;
            }
            else if (txtPlazoCredMax.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Plazo Máximo de Crédito", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlazoCredMax.Focus();
                return false;
            }
            else if (!Utility.isNumerInt(txtPlazoCredMax.Text.Trim()))
            {

                MessageBox.Show("No es un valor válido, Plazo Crédito Máximo", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlazoCredMax.Focus();
                return false;
            }
            else if (txtPlazoMaxProf.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Plazo Máximo de Proforma", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlazoMaxProf.Focus();
                return false;
            }
            else if (!Utility.isNumerInt(txtPlazoMaxProf.Text.Trim()))
            {

                MessageBox.Show("No es un valor válido, Plazo Máximo Proformas", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlazoMaxProf.Focus();
                return false;
            }
           

            return true;


        }
    }
}
