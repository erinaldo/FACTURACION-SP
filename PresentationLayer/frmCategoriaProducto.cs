using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

using EntityLayer;
using BusinessLayer;
using CommonLayer;

using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using System.Drawing.Imaging;

namespace PresentationLayer
{
    public partial class frmCategoriaProducto : Form
    {

        //Creamos las Variables globles de nuestro formulario.
        tbCategoriaProducto categoriaProducGlo  = new tbCategoriaProducto();
        BCategoriaProducto CatProductoIns = new BCategoriaProducto();
        int bandera = 1;
        bool banderaImagen = false;

        string path = "";
        string nameImageGlo = "";

        private void recuperarEntidadBuscada(tbCategoriaProducto entity)
        {

            categoriaProducGlo = entity;

            if (categoriaProducGlo != null)
            {
                txtCodigoCategoria.Text = categoriaProducGlo.id.ToString().Trim();
                txtDescripcion.Text = categoriaProducGlo.descripcion.Trim();
                txtNombreCategoria.Text = categoriaProducGlo.nombre.Trim();

                

                
              

            }
        }


        /// <summary>
        /// Buscamos una categoria de la base de datos.
        /// </summary>
        private void buscarProducto()
        {

            frmBuscarCategoriaProducto buscarCategoria = new frmBuscarCategoriaProducto();
            buscarCategoria.recuperamosEntidad += recuperarEntidadBuscada;

            buscarCategoria.ShowDialog();
         
        }


        /// <summary>
        /// Validamos los campos del formulario.
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {

            if (txtNombreCategoria.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre de la categoria.", "Datos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtNombreCategoria.Focus();
                return false;
            }


            return true;
        
        }

        /// <summary>
        /// Actuañlizamos la informacion de la categoria.
        /// </summary>
        private bool actualizarCategoria()
        {
            bool isOK = false;
            try
            {
                if (validarCampos())
                {
                    //Actualizamos la informacion de la entidad y enviamos a la base de datos.
                    categoriaProducGlo.descripcion = txtDescripcion.Text.Trim().ToUpper();
                    categoriaProducGlo.nombre = txtNombreCategoria.Text.Trim().ToUpper();
                    categoriaProducGlo.estado = true;


                    categoriaProducGlo.fecha_ult_mod = Utility.getDate();
                    categoriaProducGlo.usuario_ult_mod = Global.Usuario.nombreUsuario;

               
                    categoriaProducGlo = CatProductoIns.actualizarCategoria(categoriaProducGlo);


                    MessageBox.Show("La categoria ha sido actualizada en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isOK = true;

                }
                

            }
 
           catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isOK = false;

            }

            return isOK;

        }


        /// <summary>
        /// Guardamos una nueva categoria.
        /// </summary>
        /// <returns></returns>
        private bool guardarCategoria()
        {
            bool isOK = false;

            if (validarCampos())
            {
                tbCategoriaProducto categoriaNueva = new tbCategoriaProducto();

                try
                {
                    //Creamos la nueva instancia del objeto tbCategoriaProducto

                    categoriaNueva.nombre = txtNombreCategoria.Text.Trim().ToUpper();
                    categoriaNueva.descripcion = txtDescripcion.Text.Trim().ToUpper();

                 
                    //LLenamos los campos de auditoria.
                    categoriaNueva.estado = true;
                    categoriaNueva.fecha_crea = Utility.getDate();
                    categoriaNueva.fecha_ult_mod = Utility.getDate();
                    categoriaNueva.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    categoriaNueva.usuario_crea = Global.Usuario.nombreUsuario;

                    categoriaNueva = CatProductoIns.guardarCategoria(categoriaNueva);


                    MessageBox.Show("La categoria ha sido almacenada en la base de datos.", "Categoria guardada.",MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isOK = true;
                }

                catch (EntityExistException ex)
                {
                    if (MessageBox.Show("La categoria ya existe, ¿Desea actualizarla?", "Existe categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        categoriaProducGlo = CatProductoIns.Getentity(categoriaNueva);

                        actualizarCategoria();

                        isOK = true;


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
            else
            {
                isOK = false;
            }


            return isOK;
        }




        /// <summary>
        /// Seleccionamos que haremos segun el estado de la bandera.
        /// </summary>
        /// <param name="trans"></param>
        private bool accionGuardar(int trans)
        {

            bool action = false;

            switch (trans)
            {

                case 1:
                    action = guardarCategoria();

                    break;

                case 2:
                    action = actualizarCategoria();

                    break;


                case 3:
                    action = eliminarCategoria();
                    break;
            }

            return action;


        }

        private bool eliminarCategoria()
        {
            bool isOK = false;
            try
            {
                //Actualizamos la informacion de la entidad y enviamos a la base de datos.
                categoriaProducGlo.estado = false;

                categoriaProducGlo.fecha_ult_mod = Utility.getDate();
                categoriaProducGlo.usuario_ult_mod = Global.Usuario.nombreUsuario;


                categoriaProducGlo =  CatProductoIns.actualizarCategoria(categoriaProducGlo);


                if (categoriaProducGlo != null)
                {
                    MessageBox.Show("La categoria ha sido elimnada del sistema.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isOK = true;
                    
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOK = false;
            }

            return isOK;
        }

        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    if(accionGuardar(bandera))
                    {

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gboDatosCategoria, false);
                        Utility.ResetForm(ref gboDatosCategoria);
                    }
                    break;

                case "Nuevo":
                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatosCategoria, true);
                    txtCodigoCategoria.Enabled = false;
                    Utility.ResetForm(ref gboDatosCategoria);
                    break;

                case "Modificar":
                    bandera = 2;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatosCategoria, true);
                    txtCodigoCategoria.Enabled = false;
                    break;
                case "Eliminar":
                    bandera = 3;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;
                case "Buscar":

                    buscarProducto();

                    if (categoriaProducGlo.descripcion != null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gboDatosCategoria, false);
                    }

                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gboDatosCategoria, false);
                    Utility.ResetForm(ref gboDatosCategoria);

                    categoriaProducGlo = null;




                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }



        public frmCategoriaProducto()
        {
            InitializeComponent();
        }

        private void frmCategoriaProducto_Load(object sender, EventArgs e)
        {
            //deshabilitamos el formulario al iniciar la carga.
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gboDatosCategoria, false);

        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void chkbEstado_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void frmCategoriaProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MessageBox.Show("Has presionado la tecla F5", "Mensaje");
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
