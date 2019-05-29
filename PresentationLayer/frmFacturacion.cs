using BusinessLayer;
using CommonLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class frmFacturacion : Form
    {
        BUsuario usuBins = new BUsuario();
        tbUsuarios usua = new tbUsuarios();
        BCategoriaProducto categoriaIns = new BCategoriaProducto();
        BProducto productoIns = new BProducto();
        BFacturacion facturaIns = new BFacturacion();
        BInventario invetnarioIns = new BInventario();
        tbCategoriaProducto categoriaProducGlo = new tbCategoriaProducto();


        //bool banderaPendiente;


        //globales
        List<tbCategoriaProducto> listaCategorias;
        List<tbProducto> listaProductos = new List<tbProducto>();
        ICollection<tbDetalleDocumento> listDetalleFactura = new List<tbDetalleDocumento>();

        //Lista alterna para solucion tipo McGyver
        //ICollection<tbDetalleDocumento> listaDetalleFacturaPendiente = new List<tbDetalleDocumento>();
        List<FacturasPendientes> listaFacturaPendientes = new List<FacturasPendientes>();




        tbDocumento facturaGlobal;

        public delegate void FacturaGuardar(tbDocumento entity);
        public event FacturaGuardar detalleFacturacion;

        public frmFacturacion()
        {
            InitializeComponent();
        }
        public void cargarListaPendientes() {

        List<tbDocumento> listaFacturaPendientes = facturaIns.getListFactPendiente();
        foreach (tbDocumento fact in listaFacturaPendientes)
        {

            cargarListViewPendientes(fact);
        }
        }
        //Se crean los metodos necesarios para cargar el usuario y sus requerimientos segun el permiso que posea.
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            //cargarLogeo();
            cargarListaPendientes();
            tbUsuarios usua = new tbUsuarios();
            usua.nombreUsuario = "walpizar";
            usua.contraseña = "123";

            Global.Usuario = usua;
            Global.NumeroCaja = 1;

            //cargarPermisos(usua);
        }

        //El metodo siguiente permite el acceso a un usuario previamente ingresado al sistema.
        private  void cargarLogeo()
        {
            frmLogin login = new frmLogin();
            login.cerrarFact += cerrarForm;
           
            login.permisosEvent += cargarPermisos;
            login.ShowDialog();


           
          


            cargarDatos();
            cargarDatosLogin();
            if (string.IsNullOrWhiteSpace(Global.Usuario.foto_url))
            {
                ptbImaUsu.Image = null;
            }
    
        }
        
        // Se registra que los datos ingresados por el usuario correspondan a datos de un usuario existente.
        private void cargarDatosLogin()
        {

            try
            {

                lblNombreUsu.Text = Global.Usuario.tbPersona.nombre;
                lblNumCaja.Text = Global.NumeroCaja.ToString();
                if ( Global.Usuario.foto_url != null)
                {

                    Image imagen = new Bitmap(Global.Usuario.foto_url);
                    ptbImaUsu.Image = imagen;
                }

                
                
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo cargar la información del usuario");
            }


        }

        private void cargarDatos()
        {
           
            listaCategorias = categoriaIns.getCategorias(1);
            cargaCategorias(listaCategorias);
            cargarProductos(listaCategorias);


        }

        //Con este metodo deshabilitamos el formulario(botones)
        private void BloquearForm() {

            btnPagosProveedor.Enabled = false;
            btnEntradas.Enabled = false;
            btnSalidas.Enabled = false;
            btnInventario.Enabled = false;
            btnCreditos.Enabled = false;
            btnPagoSalario.Enabled = false;
            btnInicioYCierreDeCaja.Enabled = false;

            btnCliente.Enabled = false;
            btnEmpleado.Enabled = false;
            btnProveedor.Enabled = false;
            btnProducto.Enabled = false;
            btnIngredientes.Enabled = false;
            btnUsuarios.Enabled = false;
            btnTipoCategorias.Enabled = false;
            btnPuestos.Enabled = false;
            btnCajas.Enabled = false;
            btnRoles.Enabled = false;
            btnRequerimientos.Enabled = false;

            btnTipoMov.Enabled = false;
            btnTipoCliente.Enabled = false;
            btnTipoIngrediente.Enabled = false;
            btnTipoMedidas.Enabled = false;

            btnBuscarCliente.Enabled = false;

            btnCancelarFactura.Enabled = false;

            btnCancelarDetalle.Enabled = false;

        }

        //Este metodo permite cargar el rol y sus respectivos requerimientos segun lo permita el usuario.
        private void cargarPermisos(tbUsuarios us)
        {
            BloquearForm();
          //Con este ciclo se cargaran los permisos (requerimientos) que correspondan al usuario logueado
            foreach (tbRequerimientos re in us.tbRoles.tbRequerimientos)
                {
                if (re.idReq == (byte)Enums.requerimientos.Transacion)
                    {
                        btnPagosProveedor.Enabled = true;
                        btnEntradas.Enabled = true;
                        btnSalidas.Enabled = true;
                        btnInventario.Enabled = true;
                        btnCreditos.Enabled = true;
                        btnPagoSalario.Enabled = true;
                        btnInicioYCierreDeCaja.Enabled = true;

                    }
                    if (re.idReq == (byte)Enums.requerimientos.Mantenimiento)
                    {

                        btnCliente.Enabled = true;
                        btnEmpleado.Enabled = true;
                        btnProveedor.Enabled = true;
                        btnProducto.Enabled = true;
                        btnIngredientes.Enabled = true;
                        btnUsuarios.Enabled = true;
                        btnTipoCategorias.Enabled = true;
                        btnPuestos.Enabled = true;
                        btnCajas.Enabled = true;
                        btnRoles.Enabled = true;
                        btnRequerimientos.Enabled = true;

                    }
                    if (re.idReq == (byte)Enums.requerimientos.Tipos)
                    {
                        btnTipoMov.Enabled = true;
                        btnTipoCliente.Enabled = true;
                        btnTipoIngrediente.Enabled = true;
                        btnTipoMedidas.Enabled = true;
                    }


                    if (re.idReq == (byte)Enums.requerimientos.Buscar_Cliente)
                    {
                        btnBuscarCliente.Enabled = true;
                    }

                    if (re.idReq == (byte)Enums.requerimientos.Cancelar_Factura)
                    {
                        btnCancelarFactura.Enabled = true;
                    }
                    if (re.idReq == (byte)Enums.requerimientos.Cancelar_Detalle)
                    {
                        btnCancelarDetalle.Enabled = true;
                    }
                }
            //}
            //else if (usua.idRol == (byte)Enums.roles.Cajero_Adm)
            //{
            //    //Este ciclo se encargara de recorrer la lista de requerimientos.
            //    foreach (tbRequerimientos re in reque)
            //    {
            //        if (re.idReq == (byte)Enums.requerimientos.Transacion)
            //        {
            //            btnPagosProveedor.Enabled = false;
            //            btnEntradas.Enabled = false;
            //            btnSalidas.Enabled = false;
            //            btnInventario.Enabled = false;
            //            btnCreditos.Enabled = false;
            //            btnPagoSalario.Enabled = false;
            //            btnInicioYCierreDeCaja.Enabled = true;
            //        }

            //            if (re.idReq == (byte)Enums.requerimientos.Mantenimiento)
            //            {

            //                btnCliente.Enabled = true;
            //                btnEmpleado.Enabled = true;
            //                btnProveedor.Enabled = true;
            //                btnProducto.Enabled = true;
            //                btnIngredientes.Enabled = true;
            //                btnUsuarios.Enabled = true;
            //                btnTipoCategorias.Enabled = true;
            //                btnPuestos.Enabled = true;
            //                btnCajas.Enabled = true;
            //                btnRoles.Enabled = true;
            //                btnRequerimientos.Enabled = true;

            //            }
            //            if (re.idReq == (byte)Enums.requerimientos.Tipos)
            //            {
            //                btnTipoMov.Enabled = true;
            //                btnTipoCliente.Enabled = true;
            //                btnTipoIngrediente.Enabled = true;
            //                btnTipoMedidas.Enabled = true;
            //            }


            //            if (re.idReq == (byte)Enums.requerimientos.Buscar_Cliente)
            //            {
            //                btnBuscarCliente.Enabled = true;
            //            }
            //            if (re.idReq == (byte)Enums.requerimientos.Cancelar_Factura)
            //            {
            //                btnCancelarFactura.Enabled = true;
            //            }
            //            if (re.idReq == (byte)Enums.requerimientos.Cancelar_Detalle)
            //            {
            //                btnCancelarDetalle.Enabled = true;
            //            }
            //        }
            //    }

            //else if (usua.idRol == (byte)Enums.roles.Cajero)
            //{
            //    //Este ciclo se encargara de recorrer la lista de requerimientos.
            //    foreach (tbRequerimientos re in reque)
            //    {
            //        if (re.idReq == (byte)Enums.requerimientos.Transacion)
            //        {
            //            btnPagosProveedor.Enabled = false;
            //            btnEntradas.Enabled = false;
            //            btnSalidas.Enabled = false;
            //            btnInventario.Enabled = false;
            //            btnCreditos.Enabled = false;
            //            btnPagoSalario.Enabled = false;
            //            btnInicioYCierreDeCaja.Enabled = true;
            //        }

            //        if (re.idReq == (byte)Enums.requerimientos.Mantenimiento)
            //        {

            //            btnCliente.Enabled = false;
            //            btnEmpleado.Enabled = false;
            //            btnProveedor.Enabled = false;
            //            btnProducto.Enabled = false;
            //            btnIngredientes.Enabled = false;
            //            btnUsuarios.Enabled = false;
            //            btnTipoCategorias.Enabled = false;
            //            btnPuestos.Enabled = false;
            //            btnCajas.Enabled = false;
            //            btnRoles.Enabled = false;
            //            btnRequerimientos.Enabled = false;

            //        }
            //        if (re.idReq == (byte)Enums.requerimientos.Tipos)
            //        {
            //            btnTipoMov.Enabled = true;
            //            btnTipoCliente.Enabled = true;
            //            btnTipoIngrediente.Enabled = true;
            //            btnTipoMedidas.Enabled = true;
            //        }


            //        if (re.idReq == (byte)Enums.requerimientos.Buscar_Cliente)
            //        {
            //            btnBuscarCliente.Enabled = true;
            //        }
            //        if (re.idReq == (byte)Enums.requerimientos.Cancelar_Factura)
            //        {
            //            btnCancelarFactura.Enabled = false;
            //        }
            //        if (re.idReq == (byte)Enums.requerimientos.Cancelar_Detalle)
            //        {
            //            btnCancelarDetalle.Enabled = true;
            //        }
            //    }
            //}
        }

        private void cerrarForm()
        {
            this.Close();


        }


        private void cargarProductos(List<tbCategoriaProducto> listaCategorias)
        {
            if (listaProductos != null) {

                listaProductos.Clear();
            }


                        
            foreach (tbCategoriaProducto categoria in listaCategorias)
            {

                foreach (tbProducto pro in categoria.tbProducto)
                {

                    listaProductos.Add(pro);

                }
            }

        }

        private void cargaCategorias(List<tbCategoriaProducto> listaCategorias)
        {
            Button btn;
            int y = 0;
            int x = 0;
                        
            foreach(tbCategoriaProducto categoria in listaCategorias)
            {
             

                btn = new Button();
                btn.Name = "cat"+categoria.id.ToString();
                btn.Text = categoria.nombre.Trim();
                btn.Location = new System.Drawing.Point(100 * x, 100 * y);
                btn.Size = new System.Drawing.Size(100, 100);
                btn.BackColor = Color.Gray;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.BottomCenter;
                if (File.Exists(categoria.fotocategoria))
                {

                    Image imagen = new Bitmap(categoria.fotocategoria.Trim());
                    Image final = new Bitmap(imagen, 90, 70);

                    btn.Image = final;
                    btn.ImageAlign = ContentAlignment.TopCenter;

                }
                btn.Click += new System.EventHandler(agregarProductoFacturacion);

                gbxCategorias.Controls.Add(btn);
                x++;

                if(x == 3)
                {
                    x = 0;
                    y++;

                }

            }

        }

        private void agregarProductoFacturacion(object sender, EventArgs e)
        {
            string isCat = ((Button)sender).Name.Substring(0, 3);


            if(isCat == "cat")
            {

                string categoria = ((Button)sender).Name.Replace("cat", "");


                gbxProductos.Controls.Clear();
                int idCategoria = int.Parse(categoria);
              //  listaProductos = productoIns.getListProductoByCategoria(idCategoria);

                Button btn;
                int y = 0;
                int x = 0;

                foreach (tbProducto pro in listaProductos)
                {


                    if (pro.id_categoria == idCategoria)
                    {



                        btn = new Button();
                        btn.Name = "pro" + pro.idProducto.ToString();
                        btn.Text = pro.nombre.Trim();
                        btn.Location = new System.Drawing.Point(100 * x, 100 * y);
                        btn.Size = new System.Drawing.Size(100, 100);
                        btn.BackColor = Color.MediumPurple;
                        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.ForeColor = Color.White;
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        if (File.Exists(pro.foto))
                        {


                            Image imagen = new Bitmap(pro.foto);
                            Image final = new Bitmap(imagen,90 , 70);

                            btn.Image = final;
                            btn.ImageAlign = ContentAlignment.TopCenter;

                        }

                        btn.Click += new System.EventHandler(agregarProductoFacturacion);

                        gbxProductos.Controls.Add(btn);
                        x++;

                        if (x == 13)
                        {
                            x = 0;
                            y++;

                        }

                        
                    }


                }
                

            }
            else
            {

                //en caso que fuera un producto lo mando agregar al detalle de la factura
                string producto = ((Button)sender).Name.Replace("pro", "");
                foreach (tbProducto pro in listaProductos)
                {

                    if (pro.idProducto == producto)
                    {
                                        
                        cargarDetalleFactura(pro, 1, 0);

                        break;

                    }
                    


                }
                

            }

        }

        private void cargarDetalleFactura(tbProducto pro, int tipoAumento , int cantidad)
        {
            bool bandera = false;

            if (facturaGlobal == null) {

                facturaGlobal = new tbDocumento();
            }



            foreach (tbDetalleDocumento detalle in facturaGlobal.tbDetalleDocumento)
                { //validar si es null o no para 
                    if (detalle.idProducto == pro.idProducto)
                    {
                        bandera = true;
                        if(tipoAumento == 1)
                        {

                            detalle.cantidad = detalle.cantidad + 1;

                        }
                        else
                        {

                            detalle.cantidad = cantidad;

                        }
                    
                        detalle.totalLinea = detalle.cantidad * detalle.precio;
                        break;
                    }

                }

                if (!bandera)
                {
                    tbDetalleDocumento detalle = new tbDetalleDocumento();
                    detalle.idDoc = facturaGlobal.id;
                    detalle.idTipoDoc = facturaGlobal.tipoDocumento;
                    detalle.idProducto = pro.idProducto;
                    detalle.precio = (decimal)pro.precioVenta1;
                    detalle.cantidad = 1;
                    detalle.totalLinea = (decimal)pro.precioVenta1*1;
                    detalle.tbProducto = pro;
                    facturaGlobal.tbDetalleDocumento.Add(detalle);
                    
                    //  listDetalleFactura.Add(detalle);
                    //pro.tbCategoriaProducto = null;
                

                }





            //si1 existe en la lista para no agregar un linea nueva
           
        cargarGridDetalleFactura(facturaGlobal.tbDetalleDocumento);
        calculaMontos(facturaGlobal.tbDetalleDocumento);


        }

        /// <summary>
        /// Calculamos los montos de la factura.
        /// </summary>
        /// <param name="listaDetalle"></param>
        private void calculaMontos(ICollection<tbDetalleDocumento> listaDetalle)
        {
            double totalLinea = 0;
            double descuento = 0;
   


            try
            {
                foreach (tbDetalleDocumento detalle in listaDetalle)
                {
                    totalLinea = totalLinea + (double)detalle.totalLinea;


                }

                double porc = 0;
                if (txtPorcetaje.Text != string.Empty)
                {

                    porc = double.Parse(txtPorcetaje.Text) / 100;


                }
                //obtener 3 decimales

                descuento = totalLinea * porc;


                txtDescuento.Text = descuento.ToString();
                txtSubtotal.Text = totalLinea.ToString();


                txtTotal.Text = (totalLinea - descuento).ToString();
            }
            catch (Exception)
            {


                MessageBox.Show("Se produjo un error al ingresar el producto, corrija los datos", "Calcular montos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cargamos los productos seleccionados en el GridView de Detalle Factura
        /// </summary>
        /// <param name="listaDetalle"></param>
        private void cargarGridDetalleFactura(ICollection<tbDetalleDocumento> listaDetalle)
        {
            dtgvDetalleFactura.Rows.Clear();
            foreach (tbDetalleDocumento detalle in listaDetalle)
            {
                DataGridViewRow row = (DataGridViewRow)dtgvDetalleFactura.Rows[0].Clone();

                row.Cells[0].Value = detalle.tbProducto.nombre;
                row.Cells[1].Value = detalle.precio.ToString();
                row.Cells[2].Value = detalle.cantidad.ToString();
                row.Cells[3].Value = detalle.totalLinea.ToString();
                row.Cells[4].Value = detalle.idProducto.ToString();
                dtgvDetalleFactura.Rows.Add(row);
            }
        }

        private void resetForm()
        {

            dtgvDetalleFactura.Rows.Clear();
            
            listDetalleFactura.Clear();

            txtCliente.Text = "";
            facturaGlobal = null;
                
            //facturaGlobal = new tbFactura();
            txtSubtotal.Text = "0";
            txtIva.Text = "0";
            txtDescuento.Text = "0";
            txtPorcetaje.Text = "0";
            txtTotal.Text = "0";
            txtDescuento.Text = "0";
            lstvPendiente.Items.Clear();
            cargarListaPendientes();

        }

        private void abrirFormulario(object sender, EventArgs e)
        {
            abrirFormulario(((Button)sender).Name);
        }

        /// <summary>
        /// Abrimos los distintos formularios de la aplicacion
        /// </summary>
        /// <param name="formulario"></param>
        private void abrirFormulario(string formulario)
        {

            if (formulario == "btnTipoMov")
            {
                frmTiposMovimiento form = new frmTiposMovimiento();
                form.ShowDialog();

            }
            else if(formulario == "btnPagoSalario")
            {
                frmPagosSalario form = new frmPagosSalario();
                form.ShowDialog();
            }
            else if(formulario == "btnCajas")
            {
                frmCajas form = new frmCajas();
                form.ShowDialog();
            }
            else if(formulario == "btnPagoSalario")
            {
                frmPagosSalario form = new frmPagosSalario();
                form.ShowDialog();
            }
            else if (formulario == "btnTipoCliente")
            {
                frmTipoCliente form = new frmTipoCliente();
                form.ShowDialog();

            }
            else if (formulario == "btnTipoIngrediente")
            {
                frmTipoIngrediente form = new frmTipoIngrediente();
                form.ShowDialog();
            }
            else if (formulario == "btnTipoMedidas")
            {
                frmTipoMedida form = new frmTipoMedida();
                form.ShowDialog();
            }
            else if (formulario == "btnCliente")
            {
                frmClientes form = new frmClientes();
                form.ShowDialog();

            }
            else if (formulario == "btnProveedor")
            {
                frmProveedores form = new frmProveedores();
                form.ShowDialog();

            }
            else if (formulario == "btnEmpleado")
            {
                frmEmpleado form = new frmEmpleado();
                form.ShowDialog();
            }
            else if (formulario == "btnProducto")
            {
                frmProductos form = new frmProductos();
                form.ShowDialog();

                cargarDatos();
            }
            else if (formulario == "btnIngredientes")
            {
                frmIngredientes form = new frmIngredientes();
                form.ShowDialog();


            }
            else if (formulario == "btnUsuarios")
            {
                frmUsuario form = new frmUsuario();
                form.ShowDialog();
            }
            else if (formulario == "btnTipoCategorias")
            {
                frmCategoriaProducto form = new frmCategoriaProducto();
                form.ShowDialog();

                cargarDatos();

            }
            else if (formulario == "btnPuestos")
            {
                frmPuestos form = new frmPuestos();
                form.ShowDialog();
            }
            else if (formulario == "btnPagosProveedor")
            {
                frmMovimiento form = new frmMovimiento();
                form.TipoMovimiento = (int) Enums.tipoMovimiento.PagoProveedor;

                form.ShowDialog();
            }
            else if (formulario == "btnEntradas")
            {
                frmMovimiento form = new frmMovimiento();
                form.TipoMovimiento = (int)Enums.tipoMovimiento.EntradaDinero;
                form.ShowDialog();
            }      
            else if (formulario == "btnSalidas")
            {
                frmMovimiento form = new frmMovimiento();
                form.TipoMovimiento = (int)Enums.tipoMovimiento.SalidaDinero;
                form.ShowDialog();
            }

            else if (formulario == "btnInventario")
            {
                frmInventario form = new frmInventario();
                form.ShowDialog();
            }
            else if (formulario == "btnCreditos")
            {
                frmAbonoCredito form = new frmAbonoCredito();
                form.ShowDialog();
            }
            else if (formulario == "btnCobrar")
            {
                if (txtTotal.Text!="0") {

                    //facturaGlobal.total = float.Parse(txtTotal.Text.Trim());
                    frmCobrar form = new frmCobrar();

                        form.facturaGlobal = facturaGlobal;

                        //form.recuperarTotal += crearFactura;

                        form.ShowDialog();





                }
               

     
            }
            else if (formulario == "btnPendiente")
            {

            }
            else if (formulario == "btnCancelar")
            {

            }
            else if (formulario == "btnTipoMoneda")
            {
                frmMoneda2 form = new frmMoneda2();
                form.ShowDialog();
            }
            else if (formulario == "btnRequerimientos")
            {
                frmRequerimientos form = new frmRequerimientos();
                form.ShowDialog();
            }
            else if(formulario == "btnRoles")
            {
                frmRoles form = new frmRoles();
                form.ShowDialog();
            }
          



        }

        private void guardarFactura(tbDocumento entidad) {

            guardarFactura(entidad, (int)Enums.EstadoFactura.Cancelada);

        }
        
        /// <summary>
        /// Guardamos la factura en el sistema.
        /// </summary>
        /// <param name="entidad"></param>
        private void guardarFactura(tbDocumento entidad,int estado)
        {
            try
            {
                //facturaGlobal.iva = float.Parse(txtIva.Text.Trim());
                //facturaGlobal.descuento = float.Parse(txtDescuento.Text.Trim());
                //facturaGlobal.total = float.Parse(txtTotal.Text.Trim());
                facturaGlobal.fecha = Utility.getDate();

                //LIMPIO LA ENTIDAD PRODFUTO DEL DETALLE PARA QUE NO ME LA GUARDE Y DUPLIQUE
                foreach (tbDetalleDocumento detalle in entidad.tbDetalleDocumento)
                {
                    detalle.tbProducto = null;

                }


                //facturaGlobal.tbDetalleDocumento = listDetalleFactura;
                
                //Auditoria 
                facturaGlobal.estado = true;
                facturaGlobal.fecha_crea = Utility.getDate();
                facturaGlobal.fecha_ult_mod = Utility.getDate();
                facturaGlobal.usuario_crea = Global.Usuario.nombreUsuario;
                facturaGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                facturaGlobal.estadoFactura = estado;



                facturaGlobal = facturaIns.guadar(facturaGlobal);
                if (facturaGlobal.estadoFactura == (int)Enums.EstadoFactura.Cancelada)
                {

                       // clsImpresionFactura imprimir = new clsImpresionFactura();
                        //imprimir.obtenerEntidades += cargarImpresion;

                        //imprimir.print();

                        //Enviamos a actualizar el inventario.
                       // invetnarioIns.ActualizarInventario(facturaGlobal, listaProductos, 0);

                }
                //Aqui llamamos a la impresion.
                //Creamos una instancia de la clase de impresion.
               



                resetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al almacenar la entidad", "Error al guardar");
            }


        }

        /// <summary>
        /// Cargaremo los datos requeridos para realizar la impresion de la factura.
        /// </summary>
        private void cargarImpresion(ref tbDocumento factura,ref  List<tbProducto> Productos)
        {

            factura = facturaGlobal;
            Productos = listaProductos; 

        }

        private bool eliminaFactura(tbDocumento fact)
        {
            try {

                    fact.estadoFactura = (int)Enums.EstadoFactura.Eliminada;

                    fact.fecha_ult_mod = Utility.getDate();
                    fact.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    fact = facturaIns.modificar(fact);
                    return true;

            }catch( Exception ex){


                return false;
            }

        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                DialogResult = MessageBox.Show("No hay datos que eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            DialogResult = MessageBox.Show("Esta Seguro que desea eliminar la orden ", "Eliminar Orden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                txtDescuento.Text = "0";
                listDetalleFactura.Clear();
                if (eliminaFactura(facturaGlobal)) {
                    facturaGlobal = null;

                }

                resetForm();
            }

                
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscar frmBuscarCliente = new FrmBuscar();
            frmBuscarCliente.pasarDatosEvent += agregarCliente;
            frmBuscarCliente.ShowDialog();
        }

        private void agregarCliente(tbClientes cliente) {
            if(cliente != null){

                facturaGlobal.idCliente = cliente.id;
                facturaGlobal.tipoIdCliente = cliente.tipoCliente;
                facturaGlobal.tbClientes = cliente;
                txtCliente.Text = cliente.tbPersona.nombre.Trim() + " " + cliente.tbPersona.apellido1.Trim() + " " + cliente.tbPersona.apellido2.Trim();
            }
            

        }

        private void dtgvDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalLinea = 0;
            int cantidad = 0;
            try
            {
                if (dtgvDetalleFactura.Columns[e.ColumnIndex].Name == "colCant")
                {
                    if (dtgvDetalleFactura.Rows[e.RowIndex].Cells[4].Value != null)
                    {

                        if (dtgvDetalleFactura.Rows[e.RowIndex].Cells[2].Value != null)
                        {

                            cantidad = int.Parse(dtgvDetalleFactura.Rows[e.RowIndex].Cells[2].Value.ToString());
                            //totalLinea = double.Parse(dtgvDetalleFactura.Rows[e.RowIndex].Cells[1].Value.ToString()) * cantidad;
                            //dtgvDetalleFactura.Rows[e.RowIndex].Cells[3].Value = totalLinea.ToString();

                            foreach (tbProducto pro in listaProductos)
                            {

                                if (pro.idProducto == dtgvDetalleFactura.Rows[e.RowIndex].Cells[4].Value.ToString())
                                {
                                    cargarDetalleFactura(pro, 2, cantidad);
                                    break;

                                }

                            }


                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error al ingresar el producto, corrija los datos","Ingreso de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtPorcetaje_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPorcetaje.Text != string.Empty)
                {

                    calculaMontos(listDetalleFactura);
                }
                else
                {

                    txtDescuento.Text = "0";
                }
            }
            catch (Exception)
            {


                MessageBox.Show("Se produjo un error al ingresar el producto, corrija los datos", "Calcular descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnCancelarDetalle_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowSelected = dtgvDetalleFactura.SelectedRows;

            if (rowSelected.Count > 0)
            {
                if (rowSelected[0].Cells[3].Value != null)
                {
                    DialogResult = MessageBox.Show("Esta Seguro que desea eliminar el producto: " + rowSelected[0].Cells[0].Value.ToString(), "Eliminar producto de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(DialogResult == DialogResult.Yes)
                    {
                        
                         eliminarDetalle(facturaGlobal.tbDetalleDocumento.First().idProducto);

                    }


                }
                else
                {

                    MessageBox.Show("Debe de seleccionar una producto de la lista", "Eliminar producto Lista", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }

        }

        /// <summary>
        /// Elimnamos un producto de la factura.
        /// </summary>
        /// <param name="idProducto"></param>
        private void eliminarDetalle(string idProducto)
        {

            foreach (tbDetalleDocumento detalle in facturaGlobal.tbDetalleDocumento)
            {
               if( detalle.idProducto == idProducto)
                {
                    facturaGlobal.tbDetalleDocumento.Remove(detalle);
                    break;

                }

            }

            cargarGridDetalleFactura(facturaGlobal.tbDetalleDocumento);
            calculaMontos(facturaGlobal.tbDetalleDocumento);

        }

        private void dtgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbxProductos_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefrescaar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            crearFactura();
        }
        private string buscarAlias(int id) {
 
            foreach (FacturasPendientes factPend in listaFacturaPendientes) {

                if (factPend.FacturaPendiente.id == id) {


                    return factPend.Alias;


                }

            }

            return null;
        }
        private void crearFactura() {

            crearFactura((int)Enums.EstadoFactura.Pendiente);
        }

        private void crearFactura(tbDocumento entity)
        {

            facturaGlobal = entity;
            crearFactura((int)Enums.EstadoFactura.Cancelada);

        }

        private void crearFactura(int estadoFact) {

           // tbFactura factura = new tbFactura();

            //Validamos que la lista de detalle factura no este vacia.
            if (facturaGlobal != null)
            {
                //Cambiamos a la pestaña de facturacion a pendientes, 

                facturaGlobal.estadoFactura = estadoFact;


                string Alias = "";
                if (facturaGlobal.estadoFactura == (int)Enums.EstadoFactura.Pendiente)
                {
                    tabFacturacion.SelectedIndex = 1;
                  
                    DialogResult resultado;

                    //if (facturaGlobal.alias == null)
                    //{
                    //  resultado = ShowInputDialog(out Alias);

                    //}
                    //else {

                    //    Alias = facturaGlobal.alias;
                    //}

                }
                


         
                foreach (tbDetalleDocumento detalle in facturaGlobal.tbDetalleDocumento)
                {
                    detalle.tbProducto = null;

                }


                if (facturaGlobal.id==0)
                {
                    
                    //Problema se encuentra en factura, este sobreescribe  en dicha entidad
                    facturaGlobal.fecha = Utility.getDate();
                    facturaGlobal.estadoFactura = estadoFact;
                    //facturaGlobal.descuento = float.Parse(txtDescuento.Text);
                    //facturaGlobal.total = float.Parse(txtTotal.Text);
                    //facturaGlobal.iva = float.Parse(txtIva.Text);
                    //facturaGlobal.tbClientes = facturaGlobal.tbClientes;


                    //facturaGlobal.idCaja = int.Parse(Global.NumeroCaja.ToString());
                    ////instanciamos una variable que almacene el alias, la factura, y el detalle factura
                    //facturaGlobal.alias = Alias;

                 //   lstvPendiente.Items.Clear();
                    guardarFactura(facturaGlobal, estadoFact);

                    //Almacenar la factura pendiente.



                }
                else//actualizar factura
                {
                    facturaGlobal.fecha_ult_mod = Utility.getDate();
                    facturaGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                    facturaGlobal.estadoFactura = estadoFact;
                       
                    facturaGlobal= facturaIns.modificar(facturaGlobal);

                }

            //cargarListViewPendientes(facturaGlobal);



            resetForm();
            
            tabFacturacion.SelectedIndex = 0;
            }

            else
            {
                MessageBox.Show("Falta informacion", "Error");
                tabFacturacion.SelectedIndex = 0;
            }

        
        }

        /// <summary>
        /// Carga datos de factura al listview de pendientes
        /// </summary>
        /// <param name="listaFacturaPendientes"></param>
        private void cargarListViewPendientes(tbDocumento fact)
        {
            
                ListViewItem item = new ListViewItem();
                item.Text = fact.id.ToString();
                //item.SubItems.Add(fact.alias);  
                //item.SubItems.Add(fact.fecha.ToString());     
                //item.SubItems.Add(fact.descuento.ToString());
                //item.SubItems.Add(fact.iva.ToString());
                //item.SubItems.Add(fact.total.ToString());

                lstvPendiente.Items.Add(item);
            
        }

        /// <summary>
        /// Elimina la factura pediente seleccionada del listview
        /// </summary>
        /// <param name="listaFacturaPendientes"></param>
        private void eliminarListViewPendientes(List<FacturasPendientes> listaFacturaPendientes)
        {
            foreach (FacturasPendientes factura in listaFacturaPendientes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "";
                item.SubItems.Clear();
                item.SubItems.Clear();
                item.SubItems.Clear();
                item.SubItems.Clear();

                lstvPendiente.Items.Remove(item);
            }
        }
        
        /// <summary>
        /// Mostramos un cuadro de dialogo para agregar el pendiente.
        /// </summary>
        /// <returns></returns>
        private DialogResult ShowInputDialog(out string Pendient)
        {
            string valor = "";
            DialogResult result;

            System.Drawing.Size size = new System.Drawing.Size(250, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Digite un alias";
            inputBox.StartPosition = FormStartPosition.CenterScreen;
             

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            
            textBox.Text = "";
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&Aceptar";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancelar";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;
            inputBox.StartPosition = FormStartPosition.CenterScreen;

             result = inputBox.ShowDialog();
            if (result == DialogResult.OK) 
            {

                if (textBox.Text == String.Empty)
                {
                    MessageBox.Show("Error, ingrese un alias para agregar a la lista de pendientes.", "Error al ingresar datos.");
                    
                }
                else
                {
                    valor = textBox.Text.Trim();
                }
   
            }
            Pendient = valor;
            return result;

        }

        public List<tbDocumento> obtnerFacturaPendiente() {




            return facturaIns.getListFactPendiente();



        }
        
        private void lstvPendiente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabFacturacion.SelectedIndex = 0;

            if (lstvPendiente.SelectedItems.Count > 0)
            {

                //Recuperamos el Alias de la factura seleccionada.
                int id = int.Parse(lstvPendiente.SelectedItems[0].Text);

                List<tbDocumento> listaFacturas = obtnerFacturaPendiente();

                foreach (tbDocumento factura in listaFacturas)
                {
                    if (factura.id == id)
                    {

                        //banderaPendiente = true;
                        //Aqui recuperamos la entidad en cuestion, con toda su informacion pendiente.
                        facturaGlobal = factura;
                        //txtCliente.Text = facturaGlobal.alias;
                        cargarPendientes(facturaGlobal.tbDetalleDocumento);
                        break;
                    }
                    
                }
                //eliminar seleccion de la lista Pendientes
                for (int i = lstvPendiente.SelectedItems.Count - 1; i >= 0; i += -1)
                {
                    lstvPendiente.SelectedItems[i].Remove();
                    
                }
            }
            

        }

        void cargarGridDetalleFacturaPendiente(tbDocumento entidad)
        {
            cargarPendientes(entidad.tbDetalleDocumento);
        }
        
        /// <summary>
        /// Recuperamos la entidad Factura.
        /// </summary>
        /// <param name="factura"></param>
        private void cargarPendientes(ICollection<tbDetalleDocumento> facturaPendiente)
        {

            foreach(tbDetalleDocumento detalleFactura in facturaPendiente)
            {
                //Aqui recuperamos los distintos productos de la factura pendiente.
                DataGridViewRow row = (DataGridViewRow)dtgvDetalleFactura.Rows[0].Clone();

                row.Cells[0].Value = detalleFactura.tbProducto.nombre.Trim();
                row.Cells[1].Value = detalleFactura.precio.ToString();
                row.Cells[2].Value = detalleFactura.cantidad.ToString();
                row.Cells[3].Value = detalleFactura.totalLinea.ToString();

                dtgvDetalleFactura.Rows.Add(row);
            }
            calculaMontos(facturaPendiente);
        }

        private void btnCambioUsu_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Desea cambiar de Usuario?", "Cambio de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resul == DialogResult.Yes)
            {
                cargarLogeo();
                //Vuelvo a utilizar este metodo para cargar los requerimientos segun el permiso que posea, cada vez que un usuario se loguea.
                //cargarPermisos(usua);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            frmCancelarFactura factura = new frmCancelarFactura();
            factura.recuperarProductosLista += pasarProdcutos;

            factura.ShowDialog();
        }

        private void pasarProdcutos(List<tbProducto> productos)
        {
            productos = listaProductos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (lstvPendiente.Items.Count == 0)
            {
                DialogResult resul = MessageBox.Show("¿Seguro que desea salir del Sistema?", "Cierre del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult resul = MessageBox.Show("Hay facturas pendientes. ¿Desea salir del Sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resul == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }            

        private void btnInicioYCierreDeCaja_Click(object sender, EventArgs e)
        {
            frmInicioCierreCaja inicioCierre = new frmInicioCierreCaja();
            inicioCierre.ShowDialog();
        }

        private void btnTipoMoneda_Click(object sender, EventArgs e)
        {
            abrirFormulario(((Button)sender).Name);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            abrirFormulario(((Button)sender).Name);
        }

        private void btnRequerimientos_Click(object sender, EventArgs e)
        {
            abrirFormulario(((Button)sender).Name);
        }

        private void btnCantidadInventario_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del reporte Cantidad en Inventario.
            //Reportes.frmReporteInventario reporte = new Reportes.frmReporteInventario();
            //reporte.ShowDialog();
        }

        private void btnCantidadMinima_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del reporte Cantidad Minima.
            //Reportes.frmReporteCantidadMinima reporte = new Reportes.frmReporteCantidadMinima();
            //reporte.ShowDialog();
        }

        private void btnPlanillaEmpleados_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del reporte Planilla de empleados.
            ////Reportes.frmReportePlanilla reporte = new Reportes.frmReportePlanilla();
            ////reporte.ShowDialog();
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea limpiar el formulario", "Limpiar formulario", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {

                resetForm();
            }
            
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void gbxCategorias_Enter(object sender, EventArgs e)
        {


        }

        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        DialogResult result = MessageBox.Show("Desea limpiar el formulario", "Limpiar formulario", MessageBoxButtons.YesNo);
        //        if (result == DialogResult.Yes)
        //        {

        //            resetForm();
        //        }


        //        // prevent child controls from handling this event as well
        //        e.SuppressKeyPress = true;
        //    }
        //}


    }
}
