using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntityLayer;
using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
//using menu;
using System.IO;

namespace PresentationLayer
{

    public partial class frmUsuario : Form
    {
        BRoles rolesIns = new BRoles();
        BUsuario usuarioIns                 = new BUsuario();        
        BRequerimientos reqIns              = new BRequerimientos();
        private tbUsuarios usuarioGlobal    = new tbUsuarios();
        private tbPersona personaGlobal     = new tbPersona();

        BProvincias provinciasIns = new BProvincias();
        List<tbProvincia> provinciasGlo = null;
        List<tbCanton> cantonesGlo = null;
        List<tbDistrito> distritosGlo = null;

        BTipoId tipoIdIns = new BTipoId();
        Bcliente clienteInst = new Bcliente();

     
        //bool BanderaValid;
        int bandera = 1;

 
        List<tbRoles> rolRequerimientos     = new List<tbRoles>();
       

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void datosBuscar(tbUsuarios usuario)
        {
            try
            {
                usuarioGlobal = usuario;
                if (usuarioGlobal != null)
                {
                    //revisar  esta parte
                    cboTipId.SelectedValue = usuarioGlobal.tbPersona.tipoId;
                    mskId.Text               = usuarioGlobal.tbPersona.identificacion.ToString().Trim();
                    txtId.Text               = usuarioGlobal.tbPersona.identificacion.ToString();
                    

                    txtNombre.Text           = usuarioGlobal.tbPersona.nombre.ToString().Trim();
                    txtApellido1.Text        = usuarioGlobal.tbPersona.apellido1.ToString().Trim();
                    txtApellido2.Text        = usuarioGlobal.tbPersona.apellido2.ToString().Trim();
                    dtpFechNac.Text          = usuarioGlobal.tbPersona.fechaNac.ToString();
                    mskTelef.Text            = usuarioGlobal.tbPersona.telefono.ToString();
                    txtCorreo.Text           = usuarioGlobal.tbPersona.correoElectronico.ToString().Trim();
                    cboProvincia.SelectedValue = usuarioGlobal.tbPersona.provincia==null?"0": usuarioGlobal.tbPersona.provincia;
                    cboCanton.SelectedValue = usuarioGlobal.tbPersona.canton == null ? "0" : usuarioGlobal.tbPersona.canton;
                    cboDistrito.SelectedValue = usuarioGlobal.tbPersona.distrito == null ? "0" : usuarioGlobal.tbPersona.distrito;
                    cboBarrios.SelectedValue = usuarioGlobal.tbPersona.barrio == null ? "0" : usuarioGlobal.tbPersona.barrio;
                    txtOtrasSenas.Text = usuarioGlobal.tbPersona.otrasSenas==null?string.Empty : usuarioGlobal.tbPersona.otrasSenas.Trim();

                   

                    //preguntar que sexo es el que se ha seleccionado en la base de datsos, segun eso,ud selecciona el radiobutton.
                    if (usuarioGlobal.tbPersona.sexo == (int)Enums.Sexo.Femenino)
                    {
                        rbtFem.Checked = true;

                    }
                    else
                    {
                        rbtMasc.Checked = true;
                    }


                    txtNomUsu.Text               = usuarioGlobal.nombreUsuario;
                    cboIdRol.SelectedValue       = usuarioGlobal.idRol;
                    txtContra.Text               = usuarioGlobal.contraseña.ToString().Trim();
                    txtConfirmContra.Text        = usuarioGlobal.contraseña.ToString().Trim();              
                   
                }
                else
                {
                    MessageBox.Show("No se selecciono ningun dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxUsuario, false);
                    Utility.ResetForm(ref gbxNombreUser);
                    Utility.ResetForm(ref gbxUsuario);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
}

        
        private void buscar()
        {

            try
            {
                frmBuscarUsuario buscar = new frmBuscarUsuario();
                buscar.pasarDatosEvent += datosBuscar; //apunta al metodo datosBuscar
                buscar.ShowDialog();
                //usuarioGlobal = frmBuscarUsuario.usuarioGlo;

                if (usuarioGlobal != null)
                {
                    //revisar  esta parte
                    cboTipId.SelectedValue = usuarioGlobal.tbPersona.tipoId;
                    mskId.Text                  = usuarioGlobal.tbPersona.identificacion.ToString().Trim();
                    txtId.Text                  = usuarioGlobal.tbPersona.identificacion.ToString();
                    //

                    txtNombre.Text              = usuarioGlobal.tbPersona.nombre.ToString();
                    txtApellido1.Text           = usuarioGlobal.tbPersona.apellido1.ToString();
                    txtApellido2.Text           = usuarioGlobal.tbPersona.apellido2.ToString();
                    dtpFechNac.Text             = usuarioGlobal.tbPersona.fechaNac.ToString();
                    mskTelef.Text               = usuarioGlobal.tbPersona.telefono.ToString();
                    txtCorreo.Text              = usuarioGlobal.tbPersona.correoElectronico.ToString();
         
                    //preguntar que sexo es el que se ha seleccionado en la base de datsos, segun eso,ud selecciona el radiobutton.
                    if (usuarioGlobal.tbPersona.sexo == (int)Enums.Sexo.Femenino)
                    {
                        rbtFem.Checked = true;

                    }
                    else
                    {
                        rbtMasc.Checked = true;
                    }
                    
                    txtNomUsu.Text          = usuarioGlobal.nombreUsuario;
                    cboIdRol.SelectedValue  = usuarioGlobal.idRol;
                    txtContra.Text          = usuarioGlobal.contraseña.ToString().Trim();
                    txtConfirmContra.Text   = usuarioGlobal.contraseña.ToString().Trim();
                    
                    
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        //Carga el listview de los roles.
        private void cargarRolesPermiso()
        {
            cboIdRol.DisplayMember      = "nombre";
            cboIdRol.ValueMember        = "idRol";
            cboIdRol.DataSource         = usuarioIns.getRoles();

            List<tbRequerimientos> requerimientosList = reqIns.GetListEntities((int)Enums.EstadoBusqueda.Activo);

            if (requerimientosList.Count > 0)
            {

                foreach (tbRequerimientos req in requerimientosList)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = "";
                    item.SubItems.Add(req.idReq.ToString());
                    item.SubItems.Add(req.nombre);
                    lstvRequerimientos.Items.Add(item);
                }
            }
        }
        private void cambiarTiposId()
        {
            if (cboTipId.SelectedValue != null)
            {
                if ((int)cboTipId.SelectedValue == 2)
                {

                    txtApellido1.Enabled = false;
                    txtApellido2.Enabled = false;
                    dtpFechNac.Enabled = false;
                    gbxSexo.Enabled = false;
                    mskId.Visible = false;
                    txtId.Visible = true;
                    txtId.Enabled = true;


                }
                else
                {
                    mskId.Enabled = true;
                    mskId.Visible = true;
                    txtId.Visible = false;
                    txtApellido1.Enabled = true;
                    txtApellido2.Enabled = true;
                    dtpFechNac.Enabled = true;
                    gbxSexo.Enabled = true;
                }

            }
        }
        /// <summary>
        /// Obtenemos la extension de la imagen enviada.
        /// </summary>
        /// <param name="imgExt"></param>
        /// <returns></returns>
        private ImageFormat recuperarExtesionImagen(Image imgExt)
        {
            //Convertimos el path en imagen para poder trabajar las propiedades de la imagen como tal.
            //Creamos un objeto de tipo Graphics para tratar la imagen.
            Graphics gInputImage = Graphics.FromImage(imgExt);

            //recuperamos la extension.
            ImageFormat format = imgExt.RawFormat;

            return format;

        }

        //Metodo guardar datos
        private bool guardar()
        {
            bool isOk = false;
            if (validarCampos())
            {
                tbPersona persona = new tbPersona();
                tbUsuarios usuario = new tbUsuarios();
                
                try
                {
                    usuario.tipoId =(int)cboTipId.SelectedValue;
                    if (usuario.tipoId == (int)Enums.TipoId.Fisica)
                    {
                        usuario.id = mskId.Text;
                    }
                    else
                    {
                        usuario.id = txtId.Text;
                    }
                    
                    usuario.nombreUsuario    = txtNomUsu.Text.Trim().ToUpper();
                    usuario.contraseña       = txtContra.Text.Trim().ToUpper();
                    usuario.idRol            = (int)cboIdRol.SelectedValue;
                    usuario.idTipoIdEmpresa = Global.Usuario.idTipoIdEmpresa;
                    usuario.idEmpresa = Global.Usuario.idEmpresa;

                    persona.tipoId           = usuario.tipoId;
                    persona.identificacion   = usuario.id;
                    persona.nombre           = txtNombre.Text.Trim().ToUpper();
                    persona.apellido1        = txtApellido1.Text.Trim().ToUpper();
                    persona.apellido2        = txtApellido2.Text.Trim().ToUpper();
                    persona.fechaNac         = dtpFechNac.Value;
                    persona.telefono         = int.Parse(mskTelef.Text);
                    persona.correoElectronico           = txtCorreo.Text.Trim().ToUpper();
                    persona.codigoPaisTel = "506";

                    persona.provincia = cboProvincia.SelectedValue.ToString();
                    persona.canton = cboCanton.SelectedValue.ToString();
                    persona.distrito = cboDistrito.SelectedValue.ToString();
                    persona.barrio = cboBarrios.SelectedValue.ToString();

                    persona.otrasSenas = txtOtrasSenas.Text;
                    if (rbtMasc.Checked)
                    {
                        persona.sexo = (int)Enums.Sexo.Masculino;
                    }
                    else if (rbtFem.Checked)
                    {
                        persona.sexo = (int)Enums.Sexo.Femenino;
                    }
                    //auditoría

                    usuario.estado          = true;
                    usuario.fecha_crea      = Utility.getDate();
                    usuario.fecha_ult_mod   = Utility.getDate();
                    usuario.usuario_crea    = Global.Usuario.nombreUsuario.Trim();
                    usuario.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim();
                    usuario.tbPersona       = persona;

                    //Agrega imagen

                    //string destino = "C:\\Temp\\Usuario\\";
                    //string foto = "";
                    ////path = "";
                    //if (path != "")
                    //{
                    //    string nombre = Path.GetFileName(path);

                    //    foto = Path.Combine(destino, nombre);
                    //    usuario.foto_url = foto;
                    //}



                    ////Recuperamos la extension del archivo
                    //string ext =Path.GetExtension(path);

                    ////Unimos el numero de ID con la extension
                    //string nombreImagen = usuario.id.Trim() + ext;

                    ////Creamos el destino de la imagen.
                    //string destino = Path.Combine("C:\\temp\\Usuario\\",nombreImagen );


                    usuario = usuarioIns.guardar(usuario);

                    //if (usuario != null)
                    //{

                    //    if (path != "")
                    //    {
                    //        if (Directory.Exists(destino))
                    //        {

                    //            File.Copy(path, foto);

                               
                    //        }
                    //        else
                    //        {



                    //            Directory.CreateDirectory(destino);

                    //            File.Copy(path, foto);

                    //        }

                    //    }
                    //}

                    //Copiamos la imagen con el nombre nuevo, en su destino establecido.

                    
                    txtId.Text = usuario.id.ToString();
                    isOk = true;

                    MessageBox.Show("¡Datos guardados correctamente!", "Exito al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                                        
                }
                catch (EntityExistException ex)
                {
                    MessageBox.Show(ex.Message, "El usuario ya existe");
                    isOk = false;
                }
                catch(EntityDisableStateException ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "El usuario ya existe", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                      
                        usuarioGlobal = usuario;
                        isOk = modificar(); 
                    }
                    else
                    {
                        isOk = false;
                    }
                }
                catch(Exception ex)
                {
                    throw; 
                }
            }
            else
            {
                isOk = false;
            }
            return isOk;

        }




        private bool accionGuardar(int trans)
        {
            bool IsOk = false;
            switch (trans)
            {
                case (int)Enums.accionGuardar.Nuevo:
                    IsOk = guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    IsOk = modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    IsOk = eliminar();
                    break;
            }
            return IsOk;
        }



        /// <summary>
        /// Controla la activacion de botones segun la accion realizada
        /// </summary>
        /// <param name="accion"></param>
        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    
                    if (accionGuardar (bandera))
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxUsuario, false);
                        Utility.ResetForm(ref gbxNombreUser);
                        Utility.ResetForm(ref gbxUsuario);
                        
                    }

                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxUsuario, true);
                    txtId.Enabled = false;
                    Utility.ResetForm(ref gbxUsuario);
                    cboTipId.Enabled = false;
                    mskId.Enabled = true;
                    //cboTipId.SelectedValue = 0;
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxUsuario, true);
                    txtId.Enabled = false;
                    //BanderaValid = true;
                    cboTipId.Enabled = false;
                    mskId.Enabled = false;
                    //cboTipId.SelectedValue = 0;
                    break;
                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    cboTipId.Enabled = false;
                    //cboTipId.SelectedValue = 0;
                    mskId.Enabled = false;
                    break;
                case "Buscar":
                    buscar();
                    if (usuarioGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxUsuario, false);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxUsuario, false);
                    }

                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxUsuario, false);
                    Utility.ResetForm(ref gbxNombreUser);
                    Utility.ResetForm(ref gbxUsuario);

                    break;
                case "Salir":
                    this.Close();
                    break;
            }
        }




        private bool validarCampos()
        {
            //Dicho mensaje valida, pero manda un aviso cuando no encuentre una imagen del usuario.
            //if (pcbUsuarioImg.Image == null)
            //{
            //    MessageBox.Show("No se ingresó la imagen del usuario","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            //}

            if (cboTipId.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione el tipo correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipId.Focus();
                return false;
            }
            
            else if ((int)cboTipId.SelectedValue == (int)Enums.TipoId.Fisica)
            {
                if (mskId.Text == string.Empty)
                {
                    MessageBox.Show("¡Debe digitar una identificación nacional!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskId.Focus();
                    return false;
                }
            }

            else if ((int)cboTipId.SelectedValue!= (int)Enums.TipoId.Fisica)
            {
                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show("¡Debe digitar una identificación residencial!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtId.Focus();
                    return false;
                }
            }
            
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("¡Digite el nombre correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            else if (txtApellido1.Text == string.Empty)
            {
                MessageBox.Show("¡Digite el primer apellido correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido1.Focus();
                return false;
            }

            else if (txtApellido2.Text == string.Empty)
            {
                MessageBox.Show("¡Digite el segundo apellido correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido2.Focus();
                return false;
            }


           

          
            else if (txtCorreo.Text == string.Empty)
            {
                MessageBox.Show("¡Digite el correo correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
                return false;
            }

            else if (mskTelef.Text == string.Empty)
            {
                MessageBox.Show("¡Digite el numero telefónico correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskTelef.Focus();
                return false;
            }
            else if (cboProvincia.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione una provincia!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProvincia.Focus();
                return false;
            }
            else if (cboCanton.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione un cantón!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboCanton.Focus();
                return false;
            }
            else if (cboDistrito.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione un distrito!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboDistrito.Focus();
                return false;
            }
            else if (cboBarrios.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione un barrio!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboBarrios.Focus();
                return false;
            }

            else if (cboIdRol.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione el id de rol correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIdRol.Focus();
                return false;
            }

            else if (txtNomUsu.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione el nombre de usuario correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomUsu.Focus();
                return false;
            }

            else if (txtContra.Text == string.Empty)
            {
                MessageBox.Show("¡Seleccione una contrasena correspondiente!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContra.Focus();
                return false;
            }

            else if (txtConfirmContra.Text != txtContra.Text)
            {
                MessageBox.Show("¡La contraseña digitada debe ser igual a la anterior!", "Dato obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmContra.Focus();
                return false;
            }


            return true;
        }

     
        //metodo eliminar datos
        private bool eliminar()
        {
            bool isOk = false;
            DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el usuario seleccionado?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //falta validar los compos obligatorios antes de guardar
                usuarioGlobal.estado = false;
                usuarioGlobal.fecha_ult_mod = Utility.getDate();
                usuarioGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;

                isOk = true;
                tbUsuarios usuario = usuarioIns.eliminar(usuarioGlobal);
                MessageBox.Show("¡Los datos fueron eliminados satisfactoriamente!", "Exito al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isOk = false;
            }
            return isOk;
        }






        private bool modificar()
        {

            bool isOk = false;
            try
            {

                if (validarCampos())
                {


                    usuarioGlobal.nombreUsuario = txtNomUsu.Text.Trim().ToUpper();
                    usuarioGlobal.contraseña = txtContra.Text.Trim().ToUpper();
                    usuarioGlobal.idRol = (int)cboIdRol.SelectedValue;

                    usuarioGlobal.tbPersona.nombre = txtNombre.Text.Trim().ToUpper();
                    usuarioGlobal.tbPersona.apellido1 = txtApellido1.Text.Trim().ToUpper();
                    usuarioGlobal.tbPersona.apellido2 = txtApellido2.Text.Trim().ToUpper();

                    usuarioGlobal.tbPersona.correoElectronico = txtCorreo.Text.Trim().ToUpper();
                    if (rbtMasc.Checked)
                    {
                        usuarioGlobal.tbPersona.sexo = (int)Enums.Sexo.Masculino;
                    }
                    else if (rbtFem.Checked)
                    {
                        usuarioGlobal.tbPersona.sexo = (int)Enums.Sexo.Femenino;
                    }

                    usuarioGlobal.tbPersona.provincia = cboProvincia.SelectedValue.ToString();
                    usuarioGlobal.tbPersona.canton = cboCanton.SelectedValue.ToString();
                    usuarioGlobal.tbPersona.distrito = cboDistrito.SelectedValue.ToString();
                    usuarioGlobal.tbPersona.barrio = cboBarrios.SelectedValue.ToString();

                    usuarioGlobal.tbPersona.otrasSenas = txtOtrasSenas.Text;
                    usuarioGlobal.tbPersona.telefono = int.Parse(mskTelef.Text.Trim());

                    //if (pcbUsuarioImg.Image != null)
                    //{
                    //    string destino = "C:\\temp\\Usuario\\";
                    //    string foto = "";
                    //    if (path != null)
                    //    {

                    //        usuarioGlobal.foto_url = destino;

                    //        string nombre = Path.GetFileName(path);

                    //        foto = Path.Combine(destino, nombre);
                    //        usuarioGlobal.foto_url = foto;


                    //        if (Directory.Exists(destino))
                    //        {
                    //            if(usuarioGlobal.foto_url == foto)
                    //            {

                    //            }
                    //            else
                    //            {
                    //                File.Copy(path, foto);
                    //            }


                    //        }
                    //        else
                    //        {
                    //            Directory.CreateDirectory(destino);
                    //            File.Copy(path, foto);
                    //        }
                    //    }
                    //}

                    //auditoría


                    usuarioGlobal.fecha_ult_mod = Utility.getDate();
                    usuarioGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;



                    tbUsuarios usuario = usuarioIns.modificar(usuarioGlobal);
                    isOk = true;




                    MessageBox.Show("¡Los datos fueron modificados correctamente!", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
               

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                isOk = false;
            }
            return isOk;
        }


        /// <summary>
        /// activa y desactiva el txtID(textbox Id residencial) y el mskId(maskedTextbox Nacional) segun lo que selecione en el cboTipoId(combo tipo de ID)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTipId_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (Convert.ToByte(cboTipId.Text.Substring(0, 1)) == (byte)Enums.TipoId.Fisica)
            {
                txtId.Visible   = false;
                mskId.Visible   = true;
                mskId.Enabled   = true;
                if (mskId.Visible)
                {
                    txtId.Text = string.Empty;
                }
            }

            else if (Convert.ToByte(cboTipId.Text.Substring(0, 1)) == (byte)Enums.TipoId.Dimex)
            {
                txtId.Visible   = true;
                mskId.Visible   = false;
                txtId.Enabled   = true;
                if (txtId.Visible)
                {
                    mskId.Text = string.Empty;
                }
            }
        }

       

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cargarRolesPermiso();
            cargarCombos();
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxUsuario, false);
        }

        private void cargarCombos()
        {
            cboTipId.ValueMember = "id";
            cboTipId.DisplayMember = "nombre";
            cboTipId.DataSource = tipoIdIns.getListaTipoId();

            provinciasGlo = provinciasIns.getListTipoing((int)Enums.EstadoBusqueda.Activo);

            cboProvincia.ValueMember = "Cod";
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.DataSource = provinciasGlo;
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        //private void btnImgPresentacion_Click(object sender, EventArgs e)
        //{

        //    OpenFileDialog openFile = new OpenFileDialog();

        //    openFile.InitialDirectory = "c:\\";
        //    openFile.Filter = "All files (*.*)|*.*";
        //    openFile.FilterIndex = 2;
        //    openFile.RestoreDirectory = true;

        //    if (openFile.ShowDialog() == DialogResult.OK)
        //    {
        //        //Recuperamos la direccion fisica de la imagen.
        //        path = openFile.FileName;
        //        Image imagen = new Bitmap(path);
        //        pcbUsuarioImg.Image = imagen;
        //    }
            

        //}



        private void cboIdRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //manda a obtner los permisos de base de datos,,, consultar base datos roles segun el  idRol

            if (lstvRequerimientos.Items.Count > 0)
            {
                tbRoles rol      = new tbRoles();
                rol.idRol        = (int)cboIdRol.SelectedValue;


                //borar los check de la lista
                foreach (ListViewItem item in lstvRequerimientos.Items)
                {
                    item.Checked = false;
                }

                rol = rolesIns.GetEntity(rol);
                if (rol != null)
                {

                    foreach (tbRequerimientos r in rol.tbRequerimientos)
                    {
                        bool bandera = false;

                        //comparar los requerimiento que ya estn en la lista con los requerimientos del rol seleccionado, para colocarle el check
                        foreach (ListViewItem item in lstvRequerimientos.Items)
                        {

                            if (r.idReq == int.Parse(item.SubItems[1].Text))
                            {
                                item.Checked = true;
                                bandera      = true;
                            }

                            if (bandera)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            //una vez obtenida la lista buscar en el lisvie los roles que tiene permiso y colocar el check true
        }

        private void cboTipId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cambiarTiposId();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if ((int)cboTipId.SelectedValue == (int)Enums.TipoId.Fisica)
            {
                tbPersonasTribunalS cliente = clienteInst.GetClienteByIdTribunal(mskId.Text);
                if (cliente != null)
                {
                    txtApellido1.Text = cliente.APELLIDO1.Trim();
                    txtApellido2.Text = cliente.APELLIDO2.Trim();
                    txtNombre.Text = cliente.NOMBRE.Trim();
                    if (int.Parse(cliente.SEXO.Trim()) == 1)
                    {
                        rbtMasc.Checked = true;
                    }
                    else
                    {
                        rbtFem.Checked = true;
                    }

                  


                }
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarCantones();
        }
        private void cargarCantones()
        {
            if (cboProvincia.SelectedValue != null)
            {

                List<tbCanton> cantones = new List<tbCanton>();

                foreach (tbProvincia pro in provinciasGlo)
                {
                    if (pro.Cod == cboProvincia.SelectedValue.ToString())
                    {

                        foreach (tbCanton can in pro.tbCanton)
                        {
                            cantones.Add(can);
                        }

                        cantonesGlo = cantones;
                        cboCanton.DataSource = cantones;
                        cboCanton.ValueMember = "Canton";
                        cboCanton.DisplayMember = "Nombre";

                    }
                }

            }
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCanton.SelectedValue != null)
            {

                List<tbDistrito> distritos = new List<tbDistrito>();

                foreach (tbCanton can in cantonesGlo)
                {
                    if (can.Canton == cboCanton.SelectedValue.ToString())
                    {
                        foreach (tbDistrito dis in can.tbDistrito)
                        {
                            distritos.Add(dis);
                        }

                        distritosGlo = distritos;
                        cboDistrito.DataSource = distritos;
                        cboDistrito.ValueMember = "Distrito";
                        cboDistrito.DisplayMember = "Nombre";

                    }
                }

            }
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrito.SelectedValue != null)
            {

                List<tbBarrios> barrios = new List<tbBarrios>();

                foreach (tbDistrito dis in distritosGlo)
                {
                    if (dis.Distrito == cboDistrito.SelectedValue.ToString())
                    {
                        if (dis.tbBarrios.Count != 0)
                        {
                            foreach (tbBarrios barrio in dis.tbBarrios)
                            {
                                barrios.Add(barrio);
                            }


                            cboBarrios.DataSource = barrios;
                            cboBarrios.ValueMember = "barrio";
                            cboBarrios.DisplayMember = "nombre";
                        }


                    }
                }

            }
        }
    }
}
