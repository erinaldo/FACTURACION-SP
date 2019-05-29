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
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using BusinessLayer;
using CommonLayer;




namespace PresentationLayer
{
    public partial class frmProveedores : Form
    {
        int tipoIdGlobal = 1;
        private tbProveedores proveedorGlobal = new tbProveedores();
        private tbPersona personaGlobal = new tbPersona();
        int bandera = 1;
        
        public BProveedores proveedorIns = new BProveedores();
       
       
       
        public frmProveedores()
        {
            InitializeComponent();
        }



        //***********************************//
        //habilita el combo del tipo de proveedor al darle click al botón nuevo//
        private void habilitarCombo(bool Activo)
        {
            cboTipoCedFoJ.Enabled = Activo;

        }


        //*******************************************************************//
        //Habilita los campos que son compartidos en cédula física y jurídica//
        private void habilitarCamposGenerales(bool Activo)
        {
            txtNombre.Enabled      = Activo;
            cboTipoPago.Enabled    = Activo;
            mskTel.Enabled         = Activo;
            mskTel2.Enabled        = Activo;
            txtCorreo.Enabled      = Activo;
            txtCuentaBanco.Enabled = Activo;
        }


        //***********************************//
        //habilita los campos de la cédula Física//
        private void habilitarCamposFisica(bool Activo)
        {
            txtApell1.Enabled  = Activo;
            txtApell2.Enabled  = Activo;
            cboTipoCed.Enabled = Activo;
            mskCedula.Enabled  = Activo;
            txtID.Enabled      = Activo;

        }



        //***********************************//
        //habilita los campos de la cédula Jurídica//
        private void habilitarCamposJuridico(bool isActivo)
        {
            txtRepresentante.Enabled = isActivo;
            txtIdEmpresa.Enabled     = isActivo;
        }




        //**************//
        //LIMPIAR CAMPOS//
        private void limpiarForm()
        {
            cboTipoCedFoJ.Text    = "Seleccione el tipo de Proveedor";
            cboTipoPago.Text      = string.Empty;
            cboTipoCed.Text       = string.Empty;
            txtID.Text            = string.Empty;
            mskCedula.Text        = string.Empty;
            txtNombre.Text        = string.Empty;
            txtApell1.Text        = string.Empty;
            txtApell2.Text        = string.Empty;
            txtIdEmpresa.Text     = string.Empty;
            txtCuentaBanco.Text   = string.Empty;
            txtRepresentante.Text = string.Empty;
            txtCorreo.Text        = string.Empty;


            //limpiar los checkbox de pedidos        
            chkPedLunes.Checked     = false;
            chkPedMartes.Checked    = false;
            chkPedMiercoles.Checked = false;
            chkPedJueves.Checked    = false;
            chkPedViernes.Checked   = false;
            chkPedSabado.Checked    = false;
            chkPedDomingo.Checked   = false;

            //limpiar los checkbox de entrega  
            chkEntregaL.Checked   = false;
            chkEntregaK.Checked   = false;
            chkEntregaM.Checked   = false;
            chkEntregaJ.Checked   = false;
            chkEntregaV.Checked   = false;
            chkEntregaS.Checked   = false;
            chkPedDomingo.Checked = false;



            mskTel.Text  = string.Empty;
            mskTel2.Text = string.Empty;

            txtRepresentante.Text = string.Empty;

        }





        //************//
        //VALIDACIONES//
        private bool validarCampos()
        {
            if (cboTipoCedFoJ.Text == "Debe Seleccionar el tipo de Proveedor")
            {
                MessageBox.Show("Debe Seleccionar el tipo de proveedor");
                cboTipoCedFoJ.Focus();
                
                return false;
            }


            //***********************************//
            //validaciones de la cédula físico//
            if (cboTipoCedFoJ.Text == "1-Físico")
            {


                if (cboTipoCed.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar el tipo de Cédula de Identidad");
                    cboTipoCed.Focus();
                    return false;
                }


                if (mskCedula.Enabled == true && mskCedula.Text == string.Empty)
                {
                    MessageBox.Show("Debe indicar un número de cédula de Identidad");
                    mskCedula.Focus();
                    return false;
                }
                if (txtID.Enabled == true && txtID.Text == string.Empty)
                {
                    MessageBox.Show("Debe indicar un número de cédula de Identidad");
                    txtID.Focus();
                    return false;
                }

                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe indicar el nombre del proveedor");
                    txtNombre.Focus();
                    return false;
                }


                if (mskTel.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el número de teléfono del proveedor ");
                    mskTel.Focus();
                    return false;
                }

                if (cboTipoPago.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar el tipo de pago");
                    cboTipoPago.Focus();
                    return false;
                }

                if (cboTipoPago.Text == "4-Transaccional" && txtCuentaBanco.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el número de Cuenta");
                    txtCuentaBanco.Focus();
                    return false;

                }

                return true;
            }





            else
            {
                //***********************************//
                //validaciones de la cédula jurídica//
                if (txtIdEmpresa.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar un número de identificación de la empresa");
                    txtIdEmpresa.Focus();
                    return false;
                }


                if (txtNombre.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre de la empresa");
                    txtNombre.Focus();
                    return false;
                }



                if (txtRepresentante.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el nombre del representante");
                    txtRepresentante.Focus();
                    return false;
                }

                if (mskTel.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el número de teléfono del proveedor ");
                    mskTel.Focus();
                    return false;

                }


                if (cboTipoPago.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionar el tipo de pago");
                    cboTipoPago.Focus();
                    return false;
                }


                if (cboTipoPago.Text == "4-Transaccional" && txtCuentaBanco.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar el número de Cuenta");
                    txtCuentaBanco.Focus();
                    return false;

                }
                return true;
            }

        }


        //************************************//
        //Cambio de TIPO DE PROVEEDOR físico o jurídico//
        private void cboTipoCed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToByte(cboTipoCedFoJ.Text.Substring(0, 1)) == Convert.ToByte(Enums.TipoId.Fisica))
            {
                mskCedula.Enabled     = false;
                habilitarCamposFisica(true);
                habilitarCamposGenerales(true);
                habilitarCamposJuridico(false);
                txtIdEmpresa.Text     = string.Empty;
                txtRepresentante.Text = string.Empty;
                tipoIdGlobal = 1;
            }

            //(Convert.ToByte(cboTipoCedFoJ.Text.Substring(0, 1)) == Convert.ToByte(Enums.TipoId.Juridica)) 
            else
            {

                habilitarCamposJuridico(true);
                habilitarCamposGenerales(true);
                habilitarCamposFisica(false);
                cboTipoCed.Text = string.Empty;
                txtID.Text      = string.Empty;
                mskCedula.Text  = string.Empty;
                tipoIdGlobal    = 3;
                

            }

            gbxProveedores.Enabled = true;
        }




        /// <summary>
        /// Manda a la  capa de Bussines a modificar
        /// </summary>
        /// <returns></returns>
        private bool modificar()
        {
            bool isOK = false;
            tbPersona persona = new tbPersona();
            tipoIdGlobal = proveedorGlobal.tipoId;

        
            proveedorGlobal.tbPersona.nombre    = txtNombre.Text.ToUpper().Trim();
            proveedorGlobal.tbPersona.apellido1 = txtApell1.Text.ToUpper().Trim();
            proveedorGlobal.tbPersona.apellido2 = txtApell2.Text.ToUpper().Trim();
            //proveedorGlobal.representante       = txtRepresentante.Text.ToUpper().Trim();
            //proveedorGlobal.telefono1           = mskTel.Text;
            //proveedorGlobal.telefono2           = mskTel2.Text;
            //proveedorGlobal.cuenta              = txtCuentaBanco.Text.Trim();            
            //proveedorGlobal.tbPersona.correoElectronico    = txtCorreo.Text.Trim();
            //proveedorGlobal.tipoPago            = int.Parse(cboTipoPago.Text.Substring(0,1));

            ////estos if son para modificar el tipo de pago si no es transaccional limpia en la base de datos el campo cuenta 
            //if (cboTipoPago.Text.Substring(0,1)== "1")
            //{
            //    proveedorGlobal.cuenta = string.Empty;
            //    txtCuentaBanco.Text = string.Empty;
            //}

            //if (cboTipoPago.Text.Substring(0, 1) == "2")
            //{
            //    proveedorGlobal.cuenta = string.Empty;
            //    txtCuentaBanco.Text = string.Empty;
            //}

            //if (cboTipoPago.Text.Substring(0, 1) == "3")
            //{
            //    proveedorGlobal.cuenta = string.Empty;
            //    txtCuentaBanco.Text = string.Empty;
            //}

            //////////auditoría/////
            proveedorGlobal.fecha_ult_mod = Utility.getDate();
            proveedorGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;

            if (chkEstado.Checked)
            {
                proveedorGlobal.estado = true;
            }
            else
            {
                proveedorGlobal.estado = false;
            }
            //horarios pedido
            tbHorarioProveedor itemH = new tbHorarioProveedor();
           foreach(tbHorarioProveedor item in proveedorGlobal.tbHorarioProveedor)
            {
                if (item.idTipoHorario == 1)
                {
                    item.lunes     = chkPedLunes.Checked ;
                    item.martes    = chkPedMartes.Checked ;
                    item.miercoles = chkPedMiercoles.Checked;
                    item.jueves    = chkPedJueves.Checked ;
                    item.viernes   = chkPedViernes.Checked;
                    item.sabado    = chkPedSabado.Checked ;
                    item.domingo   = chkPedDomingo.Checked ;

                }
                //Se cargan los dias de entrega
                else if (item.idTipoHorario == 2)
                {

                    item.lunes     = chkEntregaL.Checked  ;
                    item.martes    = chkEntregaK.Checked ;
                    item.miercoles = chkEntregaM.Checked ;
                    item.jueves    = chkEntregaJ.Checked ;
                    item.viernes   = chkEntregaV.Checked ;
                    item.sabado    = chkEntregaS.Checked;
                    item.domingo   = chkEntregaD.Checked;

                }



            }



          
            tbProveedores isProcess = proveedorIns.Modificar(proveedorGlobal);
            if(isProcess == null)
            {
                MessageBox.Show("Los datos no fueron modificados");
            }
            else
            {
                isOK = true;
                MessageBox.Show("¡Los datos fueron modificados correctamente!","Éxito al modificar el proveedor",MessageBoxButtons.OK);
            }

           
           
            return isOK;

        }



        //************************************//
        //Cambio de tipo de pago si es transaccional  aparece el txt del numero de cuenta//
        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPago.Text == "4-Transaccional")
            {
                txtCuentaBanco.Visible = true;
                lblCuentaBanco.Visible = true;
            }
            else
            {
                txtCuentaBanco.Visible = false;
                lblCuentaBanco.Visible = false;
                txtCuentaBanco.Text    = string.Empty;
            }

        }




        //************************************//
        //Cabio de cédula física o residencial//
        private void cboTipoCed_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cboTipoCed.Text.Substring(0, 1) == "1")
            {
                mskCedula.Enabled = false;
                mskCedula.Visible = true;
                txtID.Visible     = false;
                txtID.Enabled     = false;
                mskCedula.Enabled = true;




                if (mskCedula.Visible)
                {
                    txtID.Text = string.Empty;
                }

                tipoIdGlobal = 1;

            }

            else if (cboTipoCed.Text.Substring(0, 1) == "2")
            {

                txtID.Visible     = true;
                mskCedula.Visible = false;
                mskCedula.Enabled = false;
                txtID.Enabled     = true;




                if (txtID.Visible)
                {
                    mskCedula.Text = string.Empty;
                }

                tipoIdGlobal = 2;

            }
           
        }






        /// <summary>
        /// Manda a la capa Bussines a eliminar
        /// </summary>
        /// <returns></returns>
        private bool eliminar()
        {
            bool isOK = false;
            
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el proveedor?", "Eliminar", MessageBoxButtons.YesNo);
            try
            {

                if (result == DialogResult.Yes)
                {
                    proveedorGlobal.estado          = false;
                    proveedorGlobal.fecha_ult_mod   = Utility.getDate();
                    proveedorGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
         


                    tbProveedores elimino = proveedorIns.eliminar(proveedorGlobal);


                    MessageBox.Show("¡El proveedor se eliminó correctamente!","Éxito al eliminar el proveeedor",MessageBoxButtons.OK);
                    isOK = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                isOK = false;
            }
            return isOK;
        }





        private void dataBuscar(tbProveedores proveedor)
        {
            try
            {

                proveedorGlobal = proveedor;


                if (proveedorGlobal != null)
                {


                    tipoIdGlobal = proveedorGlobal.tipoId;

                    if (tipoIdGlobal == 1)
                        {
                           
                            mskCedula.Visible    = true;
                            txtID.Visible        = false;
                            txtIdEmpresa.Enabled = false;
                            mskCedula.Text       = proveedorGlobal.id;
                           cboTipoCed.Text       = proveedorGlobal.tipoId.ToString() + "-Nacional";

                    }

                        else if (tipoIdGlobal == 2)
                        {

                           // cboTipoCed.SelectedIndex = 1;
                            txtID.Visible        = true;
                            mskCedula.Visible    = false;
                            txtIdEmpresa.Enabled = false;
                            txtID.Text           = proveedorGlobal.id;
                        cboTipoCed.Text          = proveedorGlobal.tipoId.ToString() + "-Residencial";

                        }

                        else
                        {

                            cboTipoCedFoJ.SelectedItem = 1;
                            txtID.Enabled              = true;
                            mskCedula.Enabled          = true;
                            txtIdEmpresa.Enabled       = true;
                            txtIdEmpresa.Text          = proveedorGlobal.id;
                            cboTipoCed.Text            = string.Empty;

                        }


                        txtNombre.Text        = proveedorGlobal.tbPersona.nombre.ToString();
                    //    txtRepresentante.Text = proveedorGlobal.representante;
                    //    mskTel.Text           = proveedorGlobal.tbPersona.telefono;
                    //    mskTel2.Text          = proveedorGlobal.telefono2;
                    //    txtCuentaBanco.Text   = proveedorGlobal.cuenta;
                    //    txtCorreo.Text        = proveedorGlobal.tbPersona.correoElectronico;
                    //    txtApell1.Text        = proveedorGlobal.tbPersona.apellido1.ToString();
                    //    txtApell2.Text        = proveedorGlobal.tbPersona.apellido2.ToString();
                    //    chkEstado.Checked     = proveedorGlobal.estado;
                    //    txtMostrarID.Text     = proveedorGlobal.tipoId.ToString();
                    //    cboTipoPago.Text      = proveedorGlobal.tipoPago.ToString();

                    //if (cboTipoPago.Text == "1")
                    //{
                    //    txtCuentaBanco.Visible = false;
                    //    cboTipoPago.Text = proveedorGlobal.tipoPago.ToString() + "-Efectivo";
                    //}

                    //if (cboTipoPago.Text == "2")
                    //{
                    //    txtCuentaBanco.Visible = false;
                    //    cboTipoPago.Text = proveedorGlobal.tipoPago.ToString() + "-Cheque";
                    //}

                    //if (cboTipoPago.Text == "3")
                    //{
                    //    txtCuentaBanco.Visible = false;
                    //    cboTipoPago.Text = proveedorGlobal.tipoPago.ToString() + "-Tarjeta de Débito o Crédito";
                    //}

                    //if (cboTipoPago.Text == "4")
                    //{
                    //    txtCuentaBanco.Visible = true;
                    //    cboTipoPago.Text = proveedorGlobal.tipoPago.ToString() + "-Trasanccional";
                    //}



                    foreach (tbHorarioProveedor item in proveedorGlobal.tbHorarioProveedor)
                        {
                            //Se cargan los dias de pedido
                            if (item.idTipoHorario == 1)
                            {
                                chkPedLunes.Checked     = (bool)item.lunes;
                                chkPedMartes.Checked    = (bool)item.martes;
                                chkPedMiercoles.Checked = (bool)item.miercoles;
                                chkPedJueves.Checked    = (bool)item.jueves;
                                chkPedViernes.Checked   = (bool)item.viernes;
                                chkPedSabado.Checked    = (bool)item.sabado;
                                chkPedDomingo.Checked   = (bool)item.domingo;

                            }
                            //Se cargan los dias de entrega
                            else if (item.idTipoHorario == 2)
                            {

                                chkEntregaL.Checked = (bool)item.lunes;
                                chkEntregaK.Checked = (bool)item.martes;
                                chkEntregaM.Checked = (bool)item.miercoles;
                                chkEntregaJ.Checked = (bool)item.jueves;
                                chkEntregaV.Checked = (bool)item.viernes;
                                chkEntregaS.Checked = (bool)item.sabado;
                                chkEntregaD.Checked = (bool)item.domingo;

                            }


                        }

                    }
            

                else
                {
                MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                Utility.ResetForm(ref gbxCedulas);
                Utility.ResetForm(ref gbxDiasPedEntr);
                Utility.EnableDisableForm(ref gbxProveedores, false);
                Utility.EnableDisableForm(ref gbxCedulas, false);
                Utility.EnableDisableForm(ref gbxDiasPedEntr, false);
                cboTipoCedFoJ.Text = "Debe Seleccionar el tipo de Proveedor";
                habilitarCombo(false);
               
            }
        }

            
            catch (Exception ex)
            {

                throw ex;
            }
        
    }




        //***************//
        //BUSCAR+++++++++//
        private void buscar()
        {
            try
            {

                frmBuscarProveedores buscarProve = new frmBuscarProveedores();
                buscarProve.pasarDatosEvent += dataBuscar;

                buscarProve.ShowDialog();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Manda a guardar a la capa Bussines
        /// </summary>
        /// <returns></returns>
        private bool guardar()
        {
            bool isOK = false;

            
            if (validarCampos())
            {
                tbPersona persona = new tbPersona();

                tbHorarioProveedor horarioPedido = new tbHorarioProveedor();
                tbHorarioProveedor horarioEntreg = new tbHorarioProveedor();

                tbProveedores proveedor = new tbProveedores();
                persona.tipoId = tipoIdGlobal;               
                              
                try
                {                
                    if (tipoIdGlobal == 1)
                    {

                        persona.identificacion = mskCedula.Text;


                    }


                    else if (tipoIdGlobal ==2)
                    {

                        persona.identificacion = txtID.Text;
                    }
                    else
                    {

                        persona.identificacion = txtIdEmpresa.Text;

                    }


                    persona.apellido1 = txtApell1.Text.ToUpper().Trim();
                    persona.apellido2 = txtApell2.Text.ToUpper().Trim();
                    persona.correoElectronico    = txtCorreo.Text.ToUpper().Trim();
                    persona.nombre    = txtNombre.Text.ToUpper().Trim();
                    persona.telefono  = int.Parse(mskTel.Text);






                    proveedor.id      = persona.identificacion;
                    proveedor.tipoId  = persona.tipoId;

                    ////ToUpper() guarda todo en la base de datos en mayúscula
                    //proveedor.representante = txtRepresentante.Text.ToUpper().Trim();
                    //proveedor.telefono1     = mskTel.Text;
                    //proveedor.telefono2     = mskTel2.Text;

                    //proveedor.cuenta        = txtCuentaBanco.Text.Trim();
                    //proveedor.tipoPago      = int.Parse(cboTipoPago.Text.Substring(0, 1));
                    //proveedor.estado        = true;




                    proveedor.fecha_crea      = Utility.getDate();
                    proveedor.fecha_ult_mod   = Utility.getDate();
                    proveedor.usuario_crea    = Global.Usuario.nombreUsuario;
                    proveedor.usuario_ult_mod = Global.Usuario.nombreUsuario;


                    //horarios pedido
                    horarioPedido.idTipo      = proveedor.tipoId;
                    horarioPedido.idProveedor = proveedor.id;

                    horarioPedido.idTipoHorario = 1;
                    horarioPedido.lunes         = chkPedLunes.Checked;
                    horarioPedido.martes        = chkPedMartes.Checked;
                    horarioPedido.miercoles     = chkPedMiercoles.Checked;
                    horarioPedido.jueves        = chkPedJueves.Checked;
                    horarioPedido.viernes       = chkPedViernes.Checked;
                    horarioPedido.sabado        = chkPedSabado.Checked;
                    horarioPedido.domingo       = chkPedDomingo.Checked;

                    //horarios entrega

                    horarioEntreg.idTipo        = proveedor.tipoId;
                    horarioEntreg.idProveedor   = proveedor.id;
                    horarioEntreg.idTipoHorario = 2;
                    horarioEntreg.lunes         = chkEntregaL.Checked;
                    horarioEntreg.martes        = chkEntregaK.Checked;
                    horarioEntreg.miercoles     = chkEntregaM.Checked;
                    horarioEntreg.jueves        = chkEntregaJ.Checked;
                    horarioEntreg.viernes       = chkEntregaV.Checked;
                    horarioEntreg.sabado        = chkEntregaS.Checked;
                    horarioEntreg.domingo       = chkEntregaD.Checked;

                    List<tbHorarioProveedor> listaHorario = new List<tbHorarioProveedor>();

                    listaHorario.Add(horarioPedido);
                    listaHorario.Add(horarioEntreg);

                    proveedor.tbPersona          = persona;
                    proveedor.tbHorarioProveedor = listaHorario;
                    tbProveedores guardo         = proveedorIns.guardar(proveedor);
                    isOK = true;


                   
                    MessageBox.Show("Los datos se guardaron correctamente","Éxito al guardar el proveedor",MessageBoxButtons.OK);


                }
                catch (EntityExistException ex)
                
                {
                    DialogResult result = MessageBox.Show("El proveedor ya existe.Desea activarlo?",ex.Message, MessageBoxButtons.YesNo);
                    //revisar///////////////


                    if (result == DialogResult.Yes)
                    {

                        chkEstado.Checked = true;
                        proveedorGlobal = proveedor;
                        isOK = modificar();

                    }
                    else
                    {
                        isOK = false;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    isOK = false;
                }

            }

            else
            {
                isOK = false;
            }

             
            return isOK;
              
        }

        private bool guardar(int trans)
        {
            bool isOK = false;

            switch (trans)
            {
                case (int)Enums.accionGuardar.Nuevo:
                    isOK = guardar();
                    
                    break;



                case (int)Enums.accionGuardar.Modificar:
                    isOK = modificar();
                    
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                  isOK=  eliminar();
                   
                    break;
            }

            
            return isOK;
        }


    
        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    if (guardar(bandera))

                    { 
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.ResetForm(ref gbxCedulas);
                        Utility.ResetForm(ref gbxDiasPedEntr);
                        Utility.ResetForm(ref gbxEntrega);
                        Utility.ResetForm(ref gbxPedido);
                        Utility.ResetForm(ref gbxProveedores);
                        Utility.EnableDisableForm(ref gbxProveedores, false);
                        Utility.EnableDisableForm(ref gbxCedulas, false);
                        Utility.EnableDisableForm(ref gbxDiasPedEntr, false);
                        cboTipoCedFoJ.Text = "Debe Seleccionar el tipo de Proveedor";
                        habilitarCombo(false);  

                        //hace que no aparezca el txt de la cuenta bancaria cunado no se necesita                  
                        if (cboTipoPago.Text == string.Empty)
                        {
                            txtCuentaBanco.Visible = false;
                            lblCuentaBanco.Visible = false;
                        }
                    }
                    break;


                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);                   
                    Utility.EnableDisableForm(ref gbxProveedores, true);
                    Utility.EnableDisableForm(ref gbxDiasPedEntr, true);
                    

                    ////al darle nuevo no va ser visible la cuenta bancaria 
                    if (cboTipoPago.Text == string.Empty || cboTipoPago.Text.Substring(0, 1) == "S")
                    {
                        txtCuentaBanco.Visible = false;
                        lblCuentaBanco.Visible = false;
                    }
                    //deshabilita el combo del tipo de pago
                    cboTipoCedFoJ.Enabled = true;
                   
                    
                    
                    
                    

                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxProveedores, true);
                    Utility.EnableDisableForm(ref gbxCedulas, true);
                    Utility.EnableDisableForm(ref gbxDiasPedEntr, true);


                    //que al buscar para modificar dependiendo del ID que cargue ese txt muestra el tipo de id 
                    //y los campos correspondientes que tenga que habilitar o deshabilitar  según el tipo de id
                    if (txtMostrarID.Text == "1" || txtMostrarID.Text == "2")
                    {
                        habilitarCamposFisica(true);
                        habilitarCamposJuridico(false);
                    }
                    else if(txtMostrarID.Text == "3" || cboTipoCed.Text == string.Empty)
                    {
                        habilitarCamposJuridico(true);
                        habilitarCamposFisica(false);
                    }


                   
                    txtID.Enabled        = false;
                    mskCedula.Enabled    = false;
                    cboTipoCed.Enabled   = false;
                    txtIdEmpresa.Enabled = false;
                    txtMostrarID.Enabled = false;

                    break;


                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;



                case "Buscar":
                    buscar();
                    if (proveedorGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxProveedores, false);

                        cboTipoCedFoJ.Text = "Debe Seleccionar el tipo de Proveedor";
                        
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxProveedores, false);
                    }
                    
                    break;



                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.ResetForm(ref gbxCedulas);
                    Utility.EnableDisableForm(ref gbxCedulas, false);
                    Utility.EnableDisableForm(ref gbxDiasPedEntr, false);
                    Utility.EnableDisableForm(ref gbxProveedores, false);

                    if (cboTipoPago.Text == string.Empty || cboTipoPago.Text.Substring(0, 1) == "S")
                    {
                        txtCuentaBanco.Visible = false;
                        lblCuentaBanco.Visible = false;
                    }
                    habilitarCombo(false);
                    
                    cboTipoCedFoJ.Text = "Debe Seleccionar el tipo de Proveedor";
                   
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}




