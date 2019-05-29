using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using EntityLayer;
using CommonLayer;
using BusinessLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;

namespace PresentationLayer
{
    public partial class frmRequerimientos : Form
    {
        BRequerimientos requeriInsB = new BRequerimientos();
        
        tbRequerimientos requeriGlobal = new tbRequerimientos();
        int bandera = 1;

        public frmRequerimientos()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Manda a la capa de Bussines a guardar el nuevo requerimiento
        /// </summary>
        /// <returns></returns>
        private bool Guardar()
        {
           tbRequerimientos requeri = new tbRequerimientos();
            bool processOk = false;
            try
            {
                if (ValidarCampos())
                {

                    requeri.nombre      = txtNombre.Text.ToUpper().Trim();
                    requeri.descripcion = txtDescripcion.Text.ToUpper().Trim();
                    requeri.estado      = true;


                    ////////////////Auditoría///////////
                    requeri.usuario_crea    = Global.Usuario.nombreUsuario;
                    requeri.fecha_crea      = Utility.getDate();
                    requeri.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    requeri.fecha_ult_mod   = Utility.getDate();

                    requeri = requeriInsB.guardar(requeri);

                    processOk = true;
                    MessageBox.Show("¡Los datos se guardaron correctamente!", "Éxito al guardar el requerimiento", MessageBoxButtons.OK);


                }
            }
            catch (SaveEntityException ex)
            {
                
                throw;
            }
          

            return processOk;
        }


        //******validaciones*********//
        private bool ValidarCampos()
        {
           

            if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el requerimiento");
                txtNombre.Focus();
                return false;
            }           
            return true;
        }



        /// <summary>
        ///  Manda a la capa de  Bussines a Modificar el requerimiento ya guardado en la base de datos
        /// </summary>
        /// <returns></returns>
        private bool Modificar()
        {
            bool isOK = false;

            try
            {
                if (ValidarCampos())
                {
                    requeriGlobal.nombre          = txtNombre.Text.ToUpper().Trim();
                    requeriGlobal.descripcion     = txtDescripcion.Text.ToUpper().Trim();


                    requeriGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    requeriGlobal.fecha_ult_mod   = Global.Usuario.fecha_ult_mod;

                    if (chkEstado.Checked)
                    {
                        requeriGlobal.estado = true;
                    }
                    else
                    {
                        requeriGlobal.estado = false;
                    }

                    tbRequerimientos isProcess = requeriInsB.Actualizar(requeriGlobal);
                    if (isProcess == null)
                    {
                        MessageBox.Show("Los datos no fueron modificados");
                    }
                    else
                    {
                        isOK = true;
                        MessageBox.Show("¡Los datos fueron modificados correctamente!", "Éxito al modificar el requerimiento", MessageBoxButtons.OK);
                    }
                }

            }
            catch (UpdateEntityException ex)
            {

                throw new UpdateEntityException() ;
            }

            return isOK;
        }
        

        /// <summary>
        /// Manda a la capa de  Bussines a Eliminar el requerimiento logicamente en la base de datos
        /// </summary>
        /// <returns></returns>
        private bool Eliminar()
        {

            bool isOK = true;
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el requerimiento?", "Eliminar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    requeriGlobal.estado          = false;
                    requeriGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    requeriGlobal.fecha_ult_mod   = Utility.getDate();
                    tbRequerimientos elimino      = requeriInsB.eliminar(requeriGlobal);

                    MessageBox.Show("El requerimiento se eliminó correctamente","Éxito al eliminar el requerimiento",MessageBoxButtons.OK);

                }
            }
            catch (UpdateEntityException ex)
            {

                throw;
            }
            return isOK;
        }

        private bool Guardar(int trans)
        {
            bool processOk = false;
            switch (trans)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    processOk = Guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    processOk = Modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    processOk = Eliminar();
                    break;
            }

            return processOk;
        }


        //********************Buscar********************//
        private void buscarDatos(tbRequerimientos requeri)
        {
            requeriGlobal = requeri;
            try
            {
                if (requeriGlobal != null)
                {

                    txtID.Text          = requeriGlobal.idReq.ToString().Trim();
                    txtNombre.Text      = requeriGlobal.nombre.Trim();
                    txtDescripcion.Text = requeriGlobal.descripcion.Trim();
                    chkEstado.Checked   = requeriGlobal.estado;
                }

                else
                {
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxRequerimientos, false);
                    Utility.ResetForm(ref gbxRequerimientos);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        //***************Constructor buscar**********//
        private void buscar()
        {
            frmBuscarRequerimientos BuscarReque = new frmBuscarRequerimientos();
            BuscarReque.pasarDatosEvent += buscarDatos;
            BuscarReque.ShowDialog();
        }

        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    if (Guardar(bandera))

                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.ResetForm(ref gbxRequerimientos);
                        Utility.EnableDisableForm(ref gbxRequerimientos, false);                       
                    }
                    break;


                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxRequerimientos, true);
                    txtID.Enabled = false;
                    chkEstado.Checked = true;
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxRequerimientos, true);                   
                    txtID.Enabled = false;

                    break;


                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    txtID.Enabled = false;
                    break;



                case "Buscar":
                    buscar();
                    if (requeriGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxRequerimientos, false);
                    
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxRequerimientos, false);
                    }

                    break;



                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.ResetForm(ref gbxRequerimientos);
                    Utility.EnableDisableForm(ref gbxRequerimientos, false);

                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void frmRequerimientos_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxRequerimientos, false);
        }
    }
}
