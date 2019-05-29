using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
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
    public partial class frmRoles : Form
    {
        private tbRoles RollGlobal = new tbRoles();//variable global tipo rol

        BRoles BrolesInst = new BRoles();//instancia a B roles

        BRequerimientos requeB = new BRequerimientos();//instacia a B requerimientos

        List<tbRequerimientos> listaReq = new List<tbRequerimientos>();//variable tipo lista para almacenar los requerimientos que han sido chekeados

  //   List<ListViewItem> listaReqGuardar = new List<ListViewItem>();

        int bandera = 1;

        public frmRoles()
        {
            InitializeComponent();
        }


        private void formRoles_Load(object sender, EventArgs e)
        {

            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxRoles, false);
           

            //CARGO MI LISTA CON LOS REQUERIMIENTOS GUARDADOS EN LA BASE DE DATOS

            listaReq = requeB.GetListEntities((int)Enums.EstadoBusqueda.Activo);

            cargarRequerimiento(listaReq);



        }
        //Lleno mi listView con los requimientos que cargue en mi lista
        private void cargarRequerimiento(List<tbRequerimientos> listaReq)
        {


            foreach (tbRequerimientos p in listaReq)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.idReq.ToString().Trim();
                item.SubItems.Add(p.nombre.ToString().Trim());
                lstvRequerimientos.Items.Add(item);
            }
        }

       //METODO GUARDAR

        private bool guardarRoll()
        {
            tbRoles Roles = new tbRoles();
            bool processOk = false;
            try
            {
                if (validarCampos() == true)
                {
                   
                    Roles.nombre = txtNombre.Text.ToUpper().Trim();
                    Roles.descripcion = txtDescripcion.Text.ToUpper().Trim();


                    ReqChekeados();// Recorro el list...para verificar cuales requerimientos estan chekeados
                    Roles.tbRequerimientos = listaReq;  //le asigno la lista de los requiriientos chekeados   


                    Roles.estado = true;

                    Roles.fecha_crea = Utility.getDate();
                    Roles.fecha_ult_mod = Utility.getDate();

                    Roles.usuario_crea = "LEANDRO";
                    //Global.Usuario.nombreUsuario;
                    Roles.usuario_ult_mod = "LEANDRO";
                        //Global.Usuario.nombreUsuario;

                    //Envio a guardar
                    Roles = BrolesInst.Guardar(Roles);
                    processOk = true;
                    MessageBox.Show("Los datos del nuevo Roll han sido agregados correctamente");
                }
            }
            catch (EntityDisableStateException ex)
            {

                DialogResult result = MessageBox.Show(ex.Message, "El Roll Ya existe pero esta Inactivo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    chkEstado.Checked = true;
                    RollGlobal = Roles;
                    ModificarRoll();
                    processOk = ModificarRoll();
                }
            }
            catch (EntityExistException ex)
            {
                MessageBox.Show(ex.Message);
                processOk = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                processOk = false;
            }

            return processOk;
        }

        //RECORRER LISTVIEW  Y  GUARDAR EN UNA LISTA CHECK SELECCIONADOS DE  MI LISTVIEW EN UNA VARIABLE TIPO  LIST
        private void ReqChekeados()
        {

            List<tbRequerimientos> reqCheck = new List<tbRequerimientos>();

            if (lstvRequerimientos.Items != null || lstvRequerimientos.Items == null)
            {
                foreach (ListViewItem item in lstvRequerimientos.Items)
                {
                    if (item.Checked)
                     {
                        foreach (tbRequerimientos req in listaReq)
                         {
                           if (req.idReq == int.Parse(item.SubItems[0].Text)) 
                              {
                               
                               reqCheck.Add(req);
                                break;
                              }
                         }
                       
                     }
                 }
            }
            listaReq = null;
            listaReq = reqCheck;

        }

        //VALIDAR FORMULARIO ROLES
        private bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.Focus();
                MessageBox.Show("Debe de ingresar el Nombre del Roll ");
                return false;
            }
            return true;
        }

       //ELIMINAR LOGICAMENTE EL LA ENTIDAD

        private bool Eliminar()
        {

            bool processOk = false;
            try
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea  este ROl?", "Eliminar", MessageBoxButtons.YesNo);
                {
                    if (result == DialogResult.Yes)
                    {

                        RollGlobal.estado = false;

                        RollGlobal.fecha_ult_mod = Utility.getDate();
                        RollGlobal.usuario_ult_mod = "LEANDRO";
                            //Global.Usuario.nombreUsuario;
                      
                        RollGlobal = BrolesInst.Eliminar(RollGlobal);
                        MessageBox.Show("Los datos han sido eliminados correctamente");

                        processOk = true;
                    }
                }
            }
            catch (UpdateEntityException ex)
            {
                processOk = false;
                MessageBox.Show(ex.Message);


            }

            return processOk;

        }


       //METODO PARA MODIFICAR EL ROL
        private bool ModificarRoll()
        {
            bool processOk = false;
            try
            {
                if (validarCampos() == true)
                {
                    
                    RollGlobal.nombre = txtNombre.Text.ToString().Trim();
                    RollGlobal.descripcion = txtDescripcion.Text.ToString().Trim();

                    ReqChekeados();
                    RollGlobal.tbRequerimientos = listaReq;

                    RollGlobal.usuario_ult_mod = "LEANDRO";
                        //Global.Usuario.nombreUsuario;
                        

                    RollGlobal.fecha_ult_mod = Utility.getDate();

                    RollGlobal.estado = bool.Parse(chkEstado.Checked.ToString());

                    //Envio a modificar
                    RollGlobal = BrolesInst.Modificar(RollGlobal);

                    processOk = true;
                }
            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show(ex.Message);
                processOk = false;

            }
           
            MessageBox.Show("los Datos se modificaron correctamente");
            return processOk;
        }


      
       //METODO PARA ACCEDER  AL FORM DE BUSQUEDA  Y VER LOS ROLES GUARDADOS
        private void BuscarROL()
        {
            frmBuscarRoles buscarRol = new frmBuscarRoles();//CREO UNA ENTIDAD FORM 

            buscarRol.pasarDatosEvent += CargarROL; //Al delegado le asigno el metodo que deseo ejecutar...en este caso 
                                                    //solamente a un METODO pero se le pueden asignar MAS METODOS
            buscarRol.ShowDialog();
        }

        //CARGO MI FORMULARIO CON LA ENTIDAD QUE SELECCIONE DE MI FORM DE BUSQUEDA
        private void CargarROL(tbRoles rol)
        {
            try
            {
                RollGlobal = rol;

                if (RollGlobal != null)
                {
                    if (RollGlobal.idRol != 0)
                    {
                        txtID.Text = RollGlobal.idRol.ToString().Trim();
                        txtNombre.Text = RollGlobal.nombre;
                        txtDescripcion.Text = RollGlobal.descripcion;
                        chkEstado.Checked = RollGlobal.estado;

                        cargarRequerimi(RollGlobal.tbRequerimientos);//LO QUE MANDO ES UNA COLECCION DE REQUERIMIENTOS

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //NOTA:
        //LISTA(array)=Es una lista establecida con una cantidad de espacios que no puede cambiar.

        //COLECCION=Es parecida a un array o lista PERO SUS ESPACIOS SE TRABAJAN DINAMENTE NO ESTA
        //ESTABLECIDA QUE CANTIDAD DE PUEDA TENER..

        //POR DICHA RAZON UTILIZAMOS UNA COLECCION EN ESTE CASO YA QUE  NO SABEMOS CUAL ES LA CATIDAD DE ESPACIOS 
         //LLENOS(con datos) QUE VAMOS A RESIVIR Y  TRABAJAR 

        //En este metodo lo que resivo es una coleccion y no una lista(array);La razon es
        

        //CARGO LOS REQUERIMIENTOS ESTABLECIDOS PARA DICHO ROL
        private void cargarRequerimi(ICollection<tbRequerimientos>  requeriChekeados)
        {
          //  listaReq.Clear();

            
            foreach (tbRequerimientos P in requeriChekeados)
            {
                foreach (ListViewItem item in lstvRequerimientos.Items)
                {
                    if (P.idReq == int.Parse(item.SubItems[0].Text))
                    {
                        item.Checked = true;

                    }
                }
            }       

        }
        //RESETEO EL LISTVIEW  Y LIMPIO LOS ITEMS CHEKEADOS
        private void ResetForm()
        {
            foreach (ListViewItem item in lstvRequerimientos.Items)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }

        }

        //ACCIONES DE MENU
        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }
       
      
        private void accionMenu(string accion)
        {
            switch (accion)
            {

                case "Guardar":
                    if (validarCampos())
                    {
                        if (Guardar(bandera) == true)

                        {
                            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                            Utility.EnableDisableForm(ref gbxRoles, false);
                            Utility.ResetForm(ref gbxRoles);
                            ResetForm();
                        }
                    }
                        break;
                    

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxRoles, true);
                  
                    txtID.Enabled = false;
                    
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxRoles, true);
                    txtID.Enabled = false;
                   
                    break;

                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    txtID.Enabled = false;

                    break;

                case "Buscar":

                    ResetForm();
                    BuscarROL();
                      
                    if (RollGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxRoles, false);
                        Utility.ResetForm(ref gbxRoles);
                       

                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxRoles, false);
                    }

                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxRoles, false);
                    Utility.ResetForm(ref gbxRoles);
                    ResetForm();

                    break;

                case "Salir":
                    this.Close();
                    break;
            }

        }
        //Segun se  la opcion a guardar se ejecutara el metodo que le corresponda
        private bool Guardar(int trans)
        {
            bool processOk = false;
            switch (trans)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    processOk = guardarRoll();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    processOk = ModificarRoll();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    processOk = Eliminar();
                    break;
            }

            return processOk;
        }


    }
}
