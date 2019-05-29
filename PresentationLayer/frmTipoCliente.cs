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
using BusinessLayer;
using EntityLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace PresentationLayer
{
    public partial class frmTipoCliente : Form
    {
        BTipoCliente TipoInt = new BTipoCliente();
        public static tbTipoClientes tipoClienteGloba = new tbTipoClientes();
        List<tbTipoClientes> listaTipoClinte = new List<tbTipoClientes>();

        int bandera = 1;
        public frmTipoCliente() {
            InitializeComponent();
        }

        
        
        
        private void frmTipoCliente_Load(object sender, EventArgs e)
            //cargar el formulario
        {
             MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                Utility.EnableDisableForm(ref gbxTipoCliente, false);

        }
        public void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                   
                    if (guardar(bandera)==true)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoCliente, false);
                        Utility.ResetForm(ref gbxTipoCliente);
                    }

                    
                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxTipoCliente, true);
                    txtId.Enabled = false;
                    Utility.ResetForm(ref gbxTipoCliente);
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxTipoCliente, true);
                    txtId.Enabled = false;
                    break;

                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;

                case "Buscar":
                    buscar();
                    if (tipoClienteGloba == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoCliente, false);
                        Utility.ResetForm(ref gbxTipoCliente);
                    }
                    else {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxTipoCliente, false);
                    }
                   
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxTipoCliente, false);
                    Utility.ResetForm(ref gbxTipoCliente);
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

        private bool guardar(int bandera)
        {
            bool isOK = false;
            switch (bandera)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    isOK = guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    isOK = modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    isOK = eliminar();
                    break;


            }
            return isOK;
        }
        private bool guardar()
        {
            bool isOK = false;
            tbTipoClientes tipoclientes = new tbTipoClientes();
            if (validar())
            {
                try
                {


                    tipoclientes.nombre = txtNombre.Text.ToUpper();
                    tipoclientes.descripcion = txtDescripcion.Text.ToUpper();
                    tipoclientes.estado = true;
                    tipoclientes.fecha_crea = DateTime.Now;
                    tipoclientes.fecha_ult_mod = DateTime.Now;
                    tipoclientes.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                    tipoclientes.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                    isOK = true;
                    tbTipoClientes tipo = TipoInt.guardar(tipoclientes);
                    MessageBox.Show("Los datos han sido almacenada en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isOK = true;
                }
                catch (EntityExistException ex)
                {
                    MessageBox.Show(ex.Message);
                    isOK = false;
                }

                catch (EntityDisableStateException ex)
                {


                    DialogResult result = MessageBox.Show("Datos ya existe en la base datos, ¿Desea actualizarlos?", "Datos Existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        
                        tipoClienteGloba = TipoInt.GetEntity(tipoclientes);
                        isOK = modificar();

                    }
                    else
                    {
                        isOK = false;
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isOK = false;
                }
               


                
                
            }
            return isOK;
        }
       
        private bool validar()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre del tipo de cliente", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private bool modificar()
        {
            bool isOK = false;
            try
            {
                tipoClienteGloba.nombre = txtNombre.Text.ToUpper();
                tipoClienteGloba.descripcion = txtDescripcion.Text.ToUpper();
                tipoClienteGloba.fecha_ult_mod = DateTime.Now;
                tipoClienteGloba.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();

                isOK = true;

                tbTipoClientes isProcess = TipoInt.modificar(tipoClienteGloba);
                MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            catch (Exception  ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOK = false;
            }

            return isOK;
        }
      
        private bool eliminar()
        {
            bool isOK = false;
            try
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el puesto de trabajo?", "Eliminar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //falta validar los compos obligatorios antes de guardar
                    tipoClienteGloba.estado = false;
                    tipoClienteGloba.fecha_ult_mod = DateTime.Now;
                    tipoClienteGloba.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                    tbTipoClientes isProcess = TipoInt.eliminar(tipoClienteGloba);
                    isOK = true;

                    MessageBox.Show("Los datos han sido eliminados correctamente");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOK = false;
            }
            return isOK;
            
        }
        private void buscar()
            
        {
           
        frmBuscarTipoCliente buscar = new frmBuscarTipoCliente();
            buscar.buscarDatosEvent += buscarDatos;
            buscar.ShowDialog();

            
               
         
        }
       



        private void buscarDatos(tbTipoClientes tipoCliente)
        {

            try
            {
                tipoClienteGloba = tipoCliente;
                if(tipoClienteGloba!= null)
                {
                    if (tipoClienteGloba.id != 0)
                    {
                        txtId.Text = tipoClienteGloba.id.ToString().Trim();
                        txtNombre.Text = tipoClienteGloba.nombre.Trim();
                        txtDescripcion.Text = tipoClienteGloba.descripcion.Trim();
                        

                    }
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void tlsBtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tlsBtnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void tlsBtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void gbxTipoCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}

    
    