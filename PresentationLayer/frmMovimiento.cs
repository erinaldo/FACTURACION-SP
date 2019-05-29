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
using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Interfaces;
using PresentationLayer;

namespace PresentationLayer
{
    public partial class frmMovimiento : Form
    {
        private int tipoMovimiento;
        bool isBuscar = false;//Bandera para cuando se ejecute el evento buscar no se ejecute el del monto
        int bandera = 1; //Bandera para las acciones del menu 

        BMovimiento BmoviIns = new BMovimiento();//Instancia para  guardar el movimiento
        BTipoMovimiento BtipoMovimientoIns = new BTipoMovimiento();//Instancia para llenar el combo
       
        private tbIngredientes ingrediGlobal = new tbIngredientes();//Variable global ingredientes
        private tbMovimientos moviGloval = new tbMovimientos();//Variable global 

        private static List<tbDetalleMovimiento> listaDetalleIngre = new List<tbDetalleMovimiento>();// LISTA para refrescar DataGrid y guardar
        private static List<DataGridViewRow> listaDataGridValues = new List<DataGridViewRow>();//Lista para DataGridView

        public int TipoMovimiento
        {
            get
            {
                return tipoMovimiento;
            }

            set
            {
                tipoMovimiento = value;
                
            }
        }

        public frmMovimiento()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                Utility.EnableDisableForm(ref gbxMovimiento, false);

                //CARGAR COMBO TIPO MOVIMIENTO

                cbxTipoMov.DataSource = BtipoMovimientoIns.getListTipoMovimiento((int)Enums.EstadoBusqueda.Todos);

                cbxTipoMov.DisplayMember = "nombre";
                cbxTipoMov.ValueMember = "idTipo";
                cbxTipoMov.SelectedValue = tipoMovimiento;

            }
            catch (ListEntityException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //Segun sea  evento que se maneje al guardar  ese sera el que se ejecutara ya sea (guardar-modificar o eliminar)
        private bool guardar(int trans)
        {
            bool isok = false;
            switch (trans)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    isok = guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    isok = modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    isok = eliminar();
                    break;

            }
            return isok;
        }

        //Metodo para manejar las acciones del menu, segun sea  a la uno de click
        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":
                    if (validarForm())
                    {
                        if (guardar(bandera) == true)
                        {
                            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                            Utility.EnableDisableForm(ref gbxMovimiento, false);
                            Utility.ResetForm(ref gbxMovimiento);
                            Utility.ResetForm(ref gbxDetalleMovimiento);

                        }
                    }
                    break;

                case "Nuevo":

                    bandera = (int)Enums.accionGuardar.Nuevo;

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMovimiento, true);
                    txtID.Enabled = false;
                    Utility.ResetForm(ref gbxMovimiento);
                    Utility.ResetForm(ref gbxDetalleMovimiento);
                    cbxTipoMov.Enabled = false;
                    dtpFechaMovi.Enabled = false;


                    if (TipoMovimiento == (int)Enums.tipoMovimiento.PagoProveedor)
                    {

                        gbxDetalleMovimiento.Enabled = true;

                    }
                    else {

                        gbxDetalleMovimiento.Enabled = false;

                    }
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    cbxTipoMov.Enabled = false;

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMovimiento, true);
                    txtID.Enabled = false;
                    dtpFechaMovi.Enabled = false;
                    if (TipoMovimiento == (int)Enums.tipoMovimiento.PagoProveedor)
                    {

                        gbxDetalleMovimiento.Enabled = true;

                    }
                    else
                    {

                        gbxDetalleMovimiento.Enabled = false;

                    }
                    break;

                case "Eliminar":

                    bandera = (int)Enums.accionGuardar.Eliminar;
                    if (validarForm())

                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    }
                    break;

                case "Buscar":

                    isBuscar = true;
                    buscar();


                    if (moviGloval == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxMovimiento, false);
                        Utility.ResetForm(ref gbxMovimiento);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxMovimiento, false);
                    }
                    if (TipoMovimiento == (int)Enums.tipoMovimiento.PagoProveedor)
                    {

                        gbxDetalleMovimiento.Enabled = true;

                    }
                    else
                    {

                        gbxDetalleMovimiento.Enabled = false;

                    }
                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxMovimiento, false);



                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }

        //Menu  que toma como referencia   el metodo ACCION MENU
        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        //Guardar Formulario
        public bool guardar()
        {
            bool isok = false;

            tbMovimientos movimiento = new tbMovimientos();

            if (validarForm())
            {
                try
                {
                      tbDetalleMovimiento detalle = new tbDetalleMovimiento();

                    movimiento.idTipoMov = tipoMovimiento;
                    movimiento.motivo = txtMotivo.Text;
                    movimiento.total = Convert.ToDecimal(txtMontoTotal.Text);
                    movimiento.fecha = Utility.getDate();
                    //AUDITORIA
                    movimiento.fecha_crea = Utility.getDate();
                    movimiento.fecha_ult_mod = Utility.getDate();
                    movimiento.usuario_crea = Global.Usuario.nombreUsuario;
                    movimiento.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    movimiento.estado = true;

                    refrescarListaDetalle();

                    movimiento.tbDetalleMovimiento = listaDetalleIngre;

                     tbMovimientos mov = BmoviIns.Guardar(movimiento);
                    isok = true;
                    
                    txtID.Text = mov.idMovimiento.ToString();

                    MessageBox.Show("Los datos se guardaron correctamente");

                } //TRY

                catch (EntityExistException ex)
                {
                    MessageBox.Show(ex.Message);
                    isok = false;
                }

                catch (EntityDisableStateException ex)

                {
                    DialogResult result = MessageBox.Show(ex.Message, "Existe el movimiento", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        chkEstado.Checked = true;
                        moviGloval = movimiento;
                        isok = modificar();
                    }
                    else
                    {
                        isok = false;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    isok = false;
                }
            }// IF VALIDAR
            else
            {
                isok = false;
            }

            return isok;

        }

        //Conforme a las acciones haga guardar se puede dividir en 
        //agregar uno nuevo o modificar o eliminar 


        //Validar formulario
        private bool validarForm()
        {

            try
            {
                if (cbxTipoMov.Text == string.Empty)
                {
                    MessageBox.Show("Seleccione el tipo de movimiento");
                    cbxTipoMov.Focus();
                    return false;
                }

                //   Motivo = permite nulos
                if (TipoMovimiento == (int)Enums.tipoMovimiento.PagoProveedor)
                {



                    if (grvDetalleIngrediente.Rows.Count - 1 == 0)
                    {
                        MessageBox.Show("Error:No hay ningun detalle de ingrediente");
                        return false;
                    }

                    //    grvDetalleIngrediente.RefreshEdit();
                    for (int i = 0; i < grvDetalleIngrediente.Rows.Count - 1; i++)

                    {


                        if (grvDetalleIngrediente.Rows[i].Cells[3].Value == null)
                        {
                            MessageBox.Show("Digite la cantidad del detalle");
                            grvDetalleIngrediente.Focus();
                            return false;

                        }

                        if (grvDetalleIngrediente.Rows[i].Cells[4].Value == null)
                        {
                            MessageBox.Show("Digite el monto del detalle");
                            grvDetalleIngrediente.Focus();
                            return false;
                        }
                    }
                }
               

                if (txtMontoTotal.Text == string.Empty)

                {
                    MessageBox.Show("Cual es el monto total de los ingredientes");
                    txtMontoTotal.Focus();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  en el proceso de validación");

            }
            return true;
        }

        //LIMPIAR FORM
        private void limpiarForm()
        {
            try
            {
                txtID.Text = string.Empty;
             
                txtMotivo.Text = string.Empty;
                grvDetalleIngrediente.Rows.Clear();
                txtMontoTotal.Text = string.Empty;
                dtpFechaMovi.Value = Utility.getDate();
                listaDetalleIngre.Clear();
                listaDataGridValues.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo limpiar correctamente el formulario");
            }
        }


        //Metodo Eliminar
        private bool eliminar()
        {
            bool isOk = false;
            if (validarForm())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea eliminar el Movimiento?", "Eliminar", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)

                    {
                        moviGloval.estado = false;
                        moviGloval.fecha_ult_mod = Utility.getDate();
                        moviGloval.usuario_ult_mod =Global.Usuario.nombreUsuario;

                        BmoviIns.Modificar(moviGloval);
                        isOk = true;
                        MessageBox.Show("Se eliminado  correctamente.. si deseas recuperarlo puedes dar click en modificar");

                    }
                }
                catch (UpdateEntityException ex)
                {
                    MessageBox.Show(ex.Message);
                    return isOk = false;
                }
            }
            else
            {
                return isOk = false;
            }
            return isOk;
        }

        //Modificar  formulario
        private bool modificar()
        {
            bool isok = false;
            if (validarForm())
            {
                try
                {

                    moviGloval.motivo = txtMotivo.Text.ToUpper().Trim();
                    moviGloval.fecha = Utility.getDate();
                    moviGloval.fecha_ult_mod = Utility.getDate();
                    moviGloval.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    moviGloval.estado = chkEstado.Checked;

                    tbMovimientos movi = BmoviIns.Modificar(moviGloval);
                    isok = true;
                    MessageBox.Show("Los datos han sido modificados correctamente");


                }
                catch (UpdateEntityException ex)

                {

                    MessageBox.Show(ex.Message);
                    return isok = false;
                }
            }
            else
            {
                return isok = false;
            }
            return isok;
        }



        //Boton salir del formulario
        private void tlsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Boton NUEVO limpia y activa el formulario
        private void tlsBtnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }


        //Boton borrar fila del listview del form padre
        private void btnBorrarFila_Click(object sender, EventArgs e)
        {

            int fila = grvDetalleIngrediente.CurrentRow.Index;
            grvDetalleIngrediente.Rows.RemoveAt(fila);
        }

        //Boton  para acceder al detalle de ingrediente EN EL FORM HIJO
        //1- Fase capturo los datos    
        private void btnIngDetalleMov_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarDetalleIngrediente buscar = new frmBuscarDetalleIngrediente();

                buscar.pasarIngreEven += consultaAgregarDetalle;

                buscar.ShowDialog();

        //   ingrediGlobal = frmBuscarDetalleIngrediente.ingredienteGlo;//NO lo ocupare ya que utilizo un Evento/Delegado

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error durante el proceso al cargar la entidad");
            }
        }

        //1-Lo que resivo como parametro en este caso un ingrediente( por medio del EVENTO) se lo asigno ami variable global
        //2-Pregunto si existe...en mi datagrid(si existe le envio un aviso) sino lo envio a
        //-otro metodo que se encargara de convertir de este ingrediente un detalle,
        //3-Posteriomente cargare en mi DATAGRIDVIEW los datos que deseo mostrar


        private void consultaAgregarDetalle(tbIngredientes ingrediente)
        {
       
            try
            {
               ingrediGlobal = ingrediente; 
               bool exist = false;

                if (ingrediGlobal != null) {
                    if (ingrediGlobal.idIngrediente != 0)
                    {
                        foreach (DataGridViewRow row in grvDetalleIngrediente.Rows)//BUSCO QUE TENGO EN MI DataGrid
                        {
                            if (row.Cells[0].Value != null)
                            {
                                if (row.Cells[0].Value.ToString() == ingrediGlobal.idIngrediente.ToString())
                                {
                                    exist = true;
                                    break;
                                }
                            }
                            else
                            {

                                exist = false;
                            }
                        }
                        if (exist)
                        {
                            MessageBox.Show("Ya existe el elemento");
                        }
                        else
                        {
                            setDetalleIngredienteList(ingrediGlobal);
                        }
                    }

                }
                cargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cargarDataGrid()
        {
            try
            {
                grvDetalleIngrediente.Rows.Clear();
                foreach (DataGridViewRow row in listaDataGridValues)
                {

                    grvDetalleIngrediente.Rows.Add(row);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        //2-Cargo la lista con los detalle de ingrediente 
        private void setDetalleIngredienteList(tbIngredientes ingrediente)
        {

            try
            {

                tbDetalleMovimiento detalle = new tbDetalleMovimiento();
                detalle.idIngrediente = ingrediente.idIngrediente;//convierto el ingrediente como un detalle
                detalle.tbIngredientes = ingrediente;
                listaDetalleIngre.Add(detalle);
                cargarDataGridDetalle(detalle);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //CARGAR EL  DataGrid...CON LO QUE DESEO MOSTRAR EN ESTE CASO (ID-NOMBRE INGREDIENTE-TIPO MEDIDA)

        private void cargarDataGridDetalle(tbDetalleMovimiento detalle)
        {

            try
            {
                grvDetalleIngrediente.AllowUserToAddRows = true;
                DataGridViewRow row = (DataGridViewRow)grvDetalleIngrediente.Rows[0].Clone();

                row.Cells[0].Value = detalle.idIngrediente.ToString();
                row.Cells[1].Value = detalle.tbIngredientes.nombre.ToString();
                //row.Cells[2].Value = detalle.tbIngredientes.tbTipoMedidas.nomenclatura.ToString();

                listaDataGridValues.Add(row);
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro capturar el detalle");
            }

        }
        //Calcular el monto total de los ingredientes

        private void calcularMonto()
        {
            try
            {
                decimal montoTotal = 0;
                foreach (DataGridViewRow row in grvDetalleIngrediente.Rows)
                {
                    if (grvDetalleIngrediente.Rows[0].Cells[4].Value != null)
                    {
                        montoTotal += Convert.ToDecimal(row.Cells[4].Value);
                    }

                }
                txtMontoTotal.Text = Convert.ToString(montoTotal);

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo obtener el monto");
            }
        }




        //Metodo Refrescar lista para mandar a guardar

        private void refrescarListaDetalle()
        {
            try
            {
                grvDetalleIngrediente.AllowUserToAddRows = false;

                for (int i = 0; i < grvDetalleIngrediente.Rows.Count; i++)
                {
                    if (grvDetalleIngrediente.Rows[i].Cells[0] != null)
                    {
                        foreach (tbDetalleMovimiento detalle in listaDetalleIngre)
                        {
                            detalle.tbIngredientes = null;
                            if (grvDetalleIngrediente.Rows[i].Cells[0].Value.ToString() == detalle.idIngrediente.ToString())
                            {
                                detalle.cantidad = int.Parse(grvDetalleIngrediente.Rows[i].Cells[3].Value.ToString());
                                detalle.monto = Convert.ToDecimal(grvDetalleIngrediente.Rows[i].Cells[4].Value.ToString());

                                //    foreach (tbInventario inventario in detalle.tbIngredientes.tbInventario)
                                //    {
                                //        inventario.usuario_ult_mod = Global.Usuario.nombreUsuario;
                                //        inventario.fecha_ult_mod = Utility.getDate();
                                //        inventario.cantidad = inventario.cantidad + detalle.cantidad;

                                //    }
                                //    continue;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error no se pudo actualizar la lista de detalle");
            }

        }

        //Me limpia el  DataGridView(rows:Filas )

        private void cargarlistaIngrediente()
        {
            grvDetalleIngrediente.Rows.Clear();

        }

        //Aqui resivo y le asigno los datos a mi variable goblal  sino biene vacia, luego le  
        //asigno los valores a los campos del formulario como corresponda(Usando Evento-Delegado) en este caso
        private void datosBuscar(tbMovimientos movimiento)

        {
            try
            {
                moviGloval = movimiento;
                if (moviGloval != null)
                {
                    if (moviGloval.idMovimiento != 0)
                    {
                        txtID.Text = moviGloval.idMovimiento.ToString().Trim();
                        cbxTipoMov.SelectedValue = tipoMovimiento;
                        txtMotivo.Text = moviGloval.motivo.ToString().Trim();
                        dtpFechaMovi.Value = moviGloval.fecha.Date;
                        chkEstado.Checked = moviGloval.estado;
                        txtMontoTotal.Text = moviGloval.total.ToString().Trim();

                        //Luego lo que son detalles de movimiento los cargo a mi form en un datagrid....

                        // llamando al metodo cargar lista y  enviandoles por parametro los valores que va a cargar
                        cargarlistaIngrediente(moviGloval.tbDetalleMovimiento);

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //Metodo para cargar mi  DataGridView  con los detalles que anteriormente han sido guardados

        //Estoy repiteindo codigo para cargar de nuevo el Datagridview tengo que corregirlo (reutilizar codigo)

        private void cargarlistaIngrediente(ICollection<tbDetalleMovimiento> detalles)
        {
            try
            {
                grvDetalleIngrediente.AllowUserToAddRows = true;
                grvDetalleIngrediente.Rows.Clear();

               

                foreach (tbDetalleMovimiento detalle in detalles)
                {
                  
                    DataGridViewRow row = (DataGridViewRow)grvDetalleIngrediente.Rows[0].Clone();

                   
                    row.Cells[0].Value = detalle.idIngrediente.ToString();
                    row.Cells[1].Value = detalle.tbIngredientes.nombre;
                    //row.Cells[2].Value = detalle.tbIngredientes.tbTipoMedidas.nomenclatura;
                    row.Cells[3].Value = detalle.cantidad;
                    row.Cells[4].Value = detalle.monto;

                    grvDetalleIngrediente.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //Metodo buscar  formulario de Movimiento Guardado

        private void buscar()
        {

            try
            {
                frmBuscarMovimiento buscar = new frmBuscarMovimiento();
                buscar.pasarDatosEvent += datosBuscar;//le asigno al delegado el puesto que deseo 

                buscar.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error no se pudo capturar los datos");
            }

        }

        private void grvDetalleIngrediente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (isBuscar == false)
                {
                    calcularMonto();
                }
                isBuscar = false;
            }
        }

        private void grvDetalleIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}




        



   
  

