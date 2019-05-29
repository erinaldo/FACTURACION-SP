using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class frmTipoIngrediente : Form
    {
        private tbTipoIngrediente tipoInGlobal = new tbTipoIngrediente();
        int bandera = 1;
        BTipoIngrediente tipoBIns = new BTipoIngrediente();//aquí creo mi instancia para llegar a mi capa businnes.


        public frmTipoIngrediente()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Guardamos el tipo de ingrediente.
        /// </summary>
        /// <returns></returns>
        private bool guardar()
        {
            bool isOk = false;
            tbTipoIngrediente tipoIngrediente = new tbTipoIngrediente();

            if (validar())
            {

                try
                {

                    tipoIngrediente.nombre = txtNombre.Text.ToUpper();
                    tipoIngrediente.descripcion = txtDes.Text.ToUpper();

                    tipoIngrediente.estado = true;
                    tipoIngrediente.fecha_crea = Utility.getDate();
                    tipoIngrediente.fecha_ult_mod = Utility.getDate();
                    tipoIngrediente.usuario_crea = Global.Usuario.nombreUsuario.ToUpper().Trim();
                    tipoIngrediente.usuario_ult_mod = Global.Usuario.nombreUsuario.ToUpper().Trim();


                    tipoIngrediente = tipoBIns.guardar(tipoIngrediente);

                    txtId.Text = tipoIngrediente.id.ToString();
                    isOk = true;
                    MessageBox.Show("El tipo de ingrediente se guardó correctamente");
                   
                }

                catch (EntityExistException ex)
                {
                    MessageBox.Show(ex.Message);
                    isOk = false;
                }

                catch (EntityDisableStateException ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "  existe el tipo de ingrediente", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        chkEstado.Checked = true;
                        tipoInGlobal = tipoBIns.getEntity(tipoIngrediente);
                        //isOk = modificar();
                        modificar();
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                isOk = false;
            }
            

            return isOk;
        }

        //validamos que se ingresen datos
        private bool validar()
        {
           
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("debe indicar el tipo de ingrediente");
                txtNombre.Focus();
                return false;
            }
            return true;
        }



        /// <summary>
        /// Actualizamos la informacion del tipo de Ingrediente seleccionado.
        /// </summary>
        /// <returns></returns>
        private bool modificar()
        {
            bool isOk = false;

            try
            {
                tipoInGlobal.nombre = txtNombre.Text.ToUpper();
                tipoInGlobal.descripcion = txtDes.Text.ToUpper();
                tipoInGlobal.estado = chkEstado.Checked;
                tipoInGlobal.fecha_ult_mod = Utility.getDate();
                tipoInGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario.ToUpper().Trim();

               tipoInGlobal = tipoBIns.modificar(tipoInGlobal);

                MessageBox.Show("El tipo de ingrediente ha sido actualizado.", "Información.");

            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show(ex.Message);
            }
            return isOk;
        }

        /// <summary>
        /// Eliminamos logicamente el Tipo de Ingrediente.
        /// </summary>
        /// <returns></returns>
        private bool eliminar()
        {
            bool isOk = false;
            try
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el tipo de ingrediente?", "Eliminar", MessageBoxButtons.YesNo);//consultar duda
                if (result == DialogResult.Yes)
                {
                    //falta validar los compos obligatorios antes de guardar
                    tipoInGlobal.estado = false;
                    tipoInGlobal.fecha_ult_mod = Utility.getDate();
                    tipoInGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario.ToUpper().Trim();
                    tbTipoIngrediente tipoIngre = tipoBIns.eliminar(tipoInGlobal);
                    isOk = true;

                    MessageBox.Show("Se ha eliminado el tipo de ingrediente.", "Información");

                }
            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show(ex.Message);
                isOk = false;
            }
            return isOk;
        }



        private bool guardar(int trans)
        {
            bool isOk = false;
            switch (trans)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    isOk= guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    isOk = modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    isOk = eliminar();
                    break;


            }

            return isOk;
        }

        /// <summary>
        /// Recuperamos la información del tipo de ingrediente buscado.
        /// </summary>
        /// <param name="tipo"></param>
        private void dataBuscar(tbTipoIngrediente tipo)
        {

            try
            {
                tipoInGlobal = tipo;
                if (tipoInGlobal != null)
                {

                    if (tipoInGlobal.id != 0)
                    {
                        txtId.Text = tipoInGlobal.id.ToString().Trim();
                        txtNombre.Text = tipoInGlobal.nombre.Trim();
                        txtDes.Text = tipoInGlobal.descripcion.Trim();
                        chkEstado.Checked = tipoInGlobal.estado;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Buscamos los distintos Tipos de Ingredientes.
        /// </summary>
        private void buscar()
        {
                
            try
            {
                frmBuscarTipoIngrediente buscar = new frmBuscarTipoIngrediente();
                buscar.pasarDatosEvent += dataBuscar;

                buscar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private bool accionMenu(string accion)
        {
            
                switch (accion)
                {

                    case "Guardar":
                    if (validar()) {
                       if(guardar(bandera)) { 

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoIngre, false);
                        Utility.ResetForm(ref gbxTipoIngre);
                        }
                    }
                        break;
                

                    case "Nuevo":
                        bandera = (int)Enums.accionGuardar.Nuevo;
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                        Utility.EnableDisableForm(ref gbxTipoIngre, true);
                        txtId.Enabled = false;
                        Utility.ResetForm(ref gbxTipoIngre);
                        break;

                    case "Modificar":
                        bandera = (int)Enums.accionGuardar.Modificar;
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                        Utility.EnableDisableForm(ref gbxTipoIngre, true);
                        txtId.Enabled = false;
                        break;
                    case "Eliminar":
                        bandera = (int)Enums.accionGuardar.Eliminar;
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                        break;
                    case "Buscar":
                        buscar();
                    if (tipoInGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoIngre, false);
                        Utility.ResetForm(ref gbxTipoIngre);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxTipoIngre, false);
                    }
                        


                        break;
                    case "Cancelar":
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoIngre, false);
                        Utility.ResetForm(ref gbxTipoIngre);

                        break;
                    case "Salir":
                        this.Close();
                        break;
                }
            return true;
            

        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void frmTipoIngrediente_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxTipoIngre, false);
        }

    }
}
