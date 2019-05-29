using System;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using SisSodINA;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer;

namespace PresentationLayer
{
    public partial class frmTipoMedida : Form
    {
        bTipoMedidas TipoMedidaIns = new bTipoMedidas();

        public static tbTipoMedidas globalTipoMedida = new tbTipoMedidas();

        int bandera = 1;

        /// <summary>
        /// Elimnamos logicamente el Tipo de Medida.
        /// </summary>
        /// <returns></returns>
        private bool Eliminar()
        {
            bool isOk = false;
            try {
                globalTipoMedida.estado = false;
                globalTipoMedida.fecha_ult_mod = DateTime.Now;
                globalTipoMedida.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                isOk = true;
                 
                bool Isprocess = TipoMedidaIns.eliminar(globalTipoMedida);

                MessageBox.Show("Los datos han sido eliminados de la base datos.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isOk = true;
            }
            catch(Exception ex )
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOk = false;

            }
            return isOk;
        }

        /// <summary>
        /// Recuperamos la información del Tipo de Medida.
        /// </summary>
        /// <param name="TMedida"></param>
        private void dataBuscar(tbTipoMedidas TMedida)
        {
            globalTipoMedida = TMedida;
            if (globalTipoMedida != null)
            {
                if (globalTipoMedida.idTipoMedida != 0)
                {
                   
                    txtIdTipoMedida.Text = globalTipoMedida.idTipoMedida.ToString().Trim();
                    txtNombreTipoMedida.Text = globalTipoMedida.nombre.ToString().Trim();
                    txtNomenclaturaTipoMedida.Text = globalTipoMedida.nomenclatura.ToString().Trim();
                    txtDescripcionTipoMedida.Text = globalTipoMedida.descripcion.ToString().Trim();
                }
            }
           
        }

        private void buscar()
        {
                frmBuscarTipoMedida buscarTipoMedida = new frmBuscarTipoMedida();
                buscarTipoMedida.pasarDatosEvent += dataBuscar;
                buscarTipoMedida.ShowDialog();
        }

        /// <summary>
        /// Almacenamos el Tipo de Medida.
        /// </summary>
        /// <returns></returns>
        private bool Guardar()
        {
            bool IsOK = false;
            tbTipoMedidas gTipoMedida = new tbTipoMedidas();

            if (ValidarCampos())
            {
                try
                {
                    gTipoMedida.nombre = txtNombreTipoMedida.Text.ToUpper();
                    gTipoMedida.nomenclatura = txtNomenclaturaTipoMedida.Text.Trim();
                    gTipoMedida.descripcion = txtDescripcionTipoMedida.Text;

                    //   auditoria   //
                    gTipoMedida.estado = true;
                    gTipoMedida.fecha_ult_mod = DateTime.Now;
                    gTipoMedida.fecha_crea = DateTime.Now;
                    gTipoMedida.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                    gTipoMedida.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();

                    txtIdTipoMedida.Text = gTipoMedida.idTipoMedida.ToString();
                    IsOK = true;

                    bool guardo = TipoMedidaIns.guardar(gTipoMedida);

                    MessageBox.Show("Los datos han sido almacenada en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsOK = true;
                        
                }
                catch (EntityDisableStateException ex)
                {
                    DialogResult result = MessageBox.Show("Datos ya existe en la base datos, ¿Desea actualizarlos?", "Datos Existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                
                        globalTipoMedida = TipoMedidaIns.GetEnity(gTipoMedida);
                        IsOK = modificar();
                    }
                    else
                    {
                        IsOK = false;
                    }
                }
                catch (EntityExistException exe)
                {
                    DialogResult result = MessageBox.Show(exe.Message, "La medida ya existe, ¿Desea actualizar?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                      
                        globalTipoMedida = TipoMedidaIns.GetEnity(gTipoMedida);
                        IsOK = modificar();
                    }
                    else
                    {
                        IsOK = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    IsOK = false;
                }
            }
            else
            {
                IsOK = false;
            }
            return IsOK;
        }

        /// <summary>
        /// Validamos los campos requeridos.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
        
            if (txtNombreTipoMedida.Text == string.Empty)
            {
                MessageBox.Show("Se debe ingresar un nombre.", "Fallo La Operación");
                txtNombreTipoMedida.Focus();
                return false;
            }
            if (txtNomenclaturaTipoMedida.Text == string.Empty)
            {
                MessageBox.Show("Se debe ingresar una nomenclatura", "Fallo la Operación");
                txtNomenclaturaTipoMedida.Focus();
                return false;
            }
            return true;

        }
        public frmTipoMedida()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Actualizamos la información del Tipo de Medida.
        /// </summary>
        /// <returns></returns>
        private bool modificar()
        {
            bool isOk = false;
            try
            {
                globalTipoMedida.nombre = txtNombreTipoMedida.Text.ToUpper();
                globalTipoMedida.nomenclatura = txtNomenclaturaTipoMedida.Text;
                globalTipoMedida.descripcion = txtDescripcionTipoMedida.Text;

                /*   auditoria   */
                globalTipoMedida.estado = true;
                globalTipoMedida.fecha_ult_mod = DateTime.Now;
                globalTipoMedida.fecha_crea = DateTime.Now;
                globalTipoMedida.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                globalTipoMedida.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();


                //isOk = true;
                bool isProcess = TipoMedidaIns.modificar(globalTipoMedida);
                MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isOk = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOk = false;
            }
            return isOk;// <--- tiene la misma funcion de una bandera
        }
        private void frmTipoMedida_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
        }
        private bool accionGuardar(int trans)
        {
            bool IsOk = false;
            switch (trans)
            {
                case (int)Enums.accionGuardar.Nuevo:
                    IsOk = Guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                   IsOk = modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    IsOk = Eliminar();
                    break;
            }
            return IsOk;
        }

        private void accionMenu(string estado)
        {
            //la bandera funciona para indicar la accion realizada 
            switch (estado)
            {
                case "Guardar":
                    
                        accionGuardar(bandera);
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoMedida, false);
                        Utility.ResetForm(ref gbxTipoMedida);
                    
                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxTipoMedida, true);
                    Utility.ResetForm(ref gbxTipoMedida);
                    txtIdTipoMedida.Enabled = false;
                    break;

                case "Modificar":
                        bandera = (int)Enums.accionGuardar.Modificar;
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                        Utility.EnableDisableForm(ref gbxTipoMedida, true);
                        txtIdTipoMedida.Enabled = false;
                    break;

                case "Eliminar":

                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;

                case "Buscar":
                    buscar();
                     if(globalTipoMedida == null)
                    {    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxTipoMedida, false);
                        Utility.ResetForm(ref gbxTipoMedida);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxTipoMedida, false);
                    }
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxTipoMedida, false);
                    Utility.ResetForm(ref gbxTipoMedida);
                    break;

                case "Salir":
                  
                        this.Close();
                   
                    break;
            }
        }
        private void tlsMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }
    }
}
