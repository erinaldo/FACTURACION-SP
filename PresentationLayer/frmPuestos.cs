

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;
using CommonLayer;
using CommonLayer.Exceptions;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;


namespace PresentationLayer
{
    public partial class frmPuestos : Form
    {
        int bandera = 1;
        public tbTipoPuesto puestoGlobal = new tbTipoPuesto();
        public BPuesto PuestoIns = new BPuesto();
        public frmPuestos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// manda a guardar los datos
        /// </summary>
        /// <returns></returns>
        private bool guardarPuesto()
        {
            bool isok = false;


            try
            {
                if (validarCampo())
                {

                    tbTipoPuesto puesto = new tbTipoPuesto();
                    puesto.nombre = txtNombre.Text.ToUpper();
                    puesto.descripcion = txtDescripcion.Text.ToUpper();
                    puesto.precio_hora = float.Parse(txtPrecioHora.Text);
                    puesto.precio_ext = float.Parse(txtPrecioHoraExtra.Text);
                    puesto.estado = true;
                    puesto.fecha_crea = Utility.getDate();
                    puesto.fecha_ult_mod = Utility.getDate();
                    puesto.usuario_crea = Global.Usuario.nombreUsuario;
                    puesto.usuario_ult_mod = Global.Usuario.nombreUsuario;

                    puesto = PuestoIns.guardar(puesto);

                    MessageBox.Show("Los datos han sido almacenada en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isok = true;
                }
            }
            catch (EntityExistException ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isok = false;
            }
            catch (EntityDisableStateException ex)
            {
                DialogResult result = MessageBox.Show("Datos ya existe en la base datos, ¿Desea actualizarlos?", "Datos Existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
             
                    //puestoGlobal = puesto;
                    isok = modificar();
                }
                else
                {
                    isok = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isok = false;
            }
        
           
            
            return isok;
           }


    
        public bool validarCampo()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("debe de indicar un nombre para el puesto de trabajo");
                txtNombre.Focus();
                return false;
            }
            if (txtPrecioHora.Text == string.Empty)
            {
                MessageBox.Show("debe de indicar el monto a pagar por hora");
                txtPrecioHora.Focus();
                return false;
            }
            if (txtPrecioHoraExtra.Text == string.Empty)
            {
                MessageBox.Show("debe indicar el monto a pagar por hora extra");
                txtPrecioHoraExtra.Focus();
                return false;
            }
            return true;
        }

        
        /// <summary>
        /// manda a eliminar los datos
        /// </summary>
        /// <returns></returns>
        private bool eliminar()
        {
            bool isok = false;

            try
            {
                DialogResult result = MessageBox.Show("¿Se encuentra seguro de eliminar los datos?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //pasa el puesto a estado :inactivo
                    puestoGlobal.estado = false;
                    puestoGlobal.fecha_ult_mod = Utility.getDate();
                    puestoGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    tbTipoPuesto puesto = PuestoIns.eliminar(puestoGlobal);

                    MessageBox.Show("Los datos han sido eliminados de la base datos.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isok = true;
                }
            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isok = false;
            }
            return isok;
        }
        /// <summary>
        /// manda a modificar los datos
        /// </summary>
        /// <returns></returns>
        private bool modificar()
        { bool isok = false;
            try
            {

                if (validarCampo())
                {

                    puestoGlobal.nombre = txtNombre.Text.ToUpper();
                    puestoGlobal.descripcion = txtDescripcion.Text.ToUpper();
                    puestoGlobal.precio_hora = float.Parse(txtPrecioHora.Text);
                    puestoGlobal.precio_ext = float.Parse(txtPrecioHoraExtra.Text);
                    puestoGlobal.fecha_ult_mod = Utility.getDate();
                    puestoGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
            

                    PuestoIns.modificar(puestoGlobal);
                    isok = true;
                    MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isok = false;
            }
      
            
            return isok;
        }



        private bool guardar(int trans) {
            bool isOk = false;
            switch (trans) {

                case (int)Enums.accionGuardar.Nuevo:
                    isOk= guardarPuesto();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    isOk= modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    isOk= eliminar();
                    break;

            }

            return isOk;

        }

     
        private void accionMenu(string accion)
        {
           
            switch (accion)
            {
                case "Guardar":

                    if (guardar(bandera))
                    {

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxPuestos, false);
                        Utility.ResetForm(ref gbxPuestos);


                    }
                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxPuestos, true);
                    txtId.Enabled = false;
                    Utility.ResetForm(ref gbxPuestos);
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxPuestos, true);
                    txtId.Enabled = false;
                    break;
                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;
                case "Buscar":
                    buscar();
                    if (puestoGlobal != null) { 
                    
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxPuestos, false);
                    }
                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxPuestos, false);
                    Utility.ResetForm(ref gbxPuestos);

                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }

        private void buscar()
        {

            frmBuscarPuestoTrabajo buscar = new frmBuscarPuestoTrabajo();
            buscar.pasarDatosEvent += datosBuscar;
            buscar.ShowDialog();
        }

               
        private void datosBuscar(tbTipoPuesto entity)
        {
            puestoGlobal = entity;
            try
            {
                if(puestoGlobal != null) { 

                if (puestoGlobal.idTipoPuesto != 0)
                {
                    txtId.Text = puestoGlobal.idTipoPuesto.ToString().Trim();
                    txtNombre.Text = puestoGlobal.nombre.Trim();
                    txtDescripcion.Text = puestoGlobal.descripcion.Trim();
                    txtPrecioHora.Text = puestoGlobal.precio_hora.ToString();
                    txtPrecioHoraExtra.Text = puestoGlobal.precio_ext.ToString();
  

                }
                }
                else
                {
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxPuestos, false);
                    Utility.ResetForm(ref gbxPuestos);

                }
            }
            

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
  

        private void frmTipoPuestos_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxPuestos, false);
           
        }

        private void tlsMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

       
    }
}
