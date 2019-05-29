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

using EntityLayer;
using BusinessLayer;
using CommonLayer;

using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace PresentationLayer
{
    public partial class frmProductos : Form
    {
        List<tbDetalleProducto> listaDetalleProduc = new List<tbDetalleProducto>();

        tbProducto productoGlo = new tbProducto();
        tbDetalleProducto detalleProducto = new tbDetalleProducto();
        tbDetalleProducto quitarIngrediente = new tbDetalleProducto();

        // Creamos una nueva instancia de tipo tbDetalleProducto que enviaremos a eliminar.
        List<tbDetalleProducto> eliminarDetalle = new List<tbDetalleProducto>();

        List<tbIngredientes> listaIngrediente = new List<tbIngredientes>();

        BProducto ProductoIns = new BProducto();
        BCategoriaProducto CatProductosIns = new BCategoriaProducto();
        BIngredientes IngredientesIns = new BIngredientes();

        string path = "";
        string nombreImage = "";

        //Este el precio real del producto.
        double precioReal = 0.0f;


        //Creamos una bandera para determinar si es nuevo o debe actualizar.
        //1: Nuevo | 2: Actualizar
        int bandera = 1;

        //Creamos una bandera para saber si la imagen  ha sido cambiada.
        bool banderaImagen = false;


        /// <summary>
        /// Recueramos la entidad mediante el uso del Delegado.
        /// </summary>
        /// <param name="?"></param>
        private void recuperarEntidad(tbProducto entidad)
        {
            //Cargamos los valores a la entidad.
            productoGlo = entidad;


            if (productoGlo != null)
            {

                int temp = 0;


                //Ingresamos los datos del producto en el formulario.
                txtCodigoProducto.Text = productoGlo.idProducto.ToString();
                txtNombreProducto.Text = productoGlo.nombre;

                temp = (int)productoGlo.precioVenta1;

                txtPrecioProducto.Text = temp.ToString();

                //temp = (int)productoGlo.precio_promo;

                txtPrecioPromo.Text = temp.ToString();

                cboCategoriaProducto.SelectedValue = productoGlo.id_categoria;

                //Faltaria cargar la lista.

                listaDetalleProduc = ProductoIns.getDetalleProducto(productoGlo.idProducto);

                foreach (tbDetalleProducto p in listaDetalleProduc)
                {

                    //Creamos un nuevo ListViewItem.
                    ListViewItem item = new ListViewItem();

                    item.Text = p.idIngrediente.ToString();

                    item.SubItems.Add(p.tbIngredientes.nombre);

                    item.SubItems.Add(p.cantidad.ToString());


                    //Cargamos al ListView
                    lstvDetalleProducto.Items.Add(item);


                }

                //falta recuperar la imagen de la base de datos.

                if (productoGlo.foto.Trim() != "")
                {
                    path = productoGlo.foto.Trim();
                    ptbImageProducto.Image = new Bitmap(path);
                    banderaImagen = false;
                }

            }

        }


        /// <summary>
        /// Buscamos un producto existente en la base de datos.
        /// </summary>
        private bool buscarProducto()
        {

            bool isOK = false;

            frmBuscarProducto buscarProduct = new frmBuscarProducto();

            //Asignamos el metodo a la lista en el evento.
            buscarProduct.recuperarEntidad += recuperarEntidad;

            buscarProduct.ShowDialog();

            if (productoGlo.idProducto == string.Empty)
            {
                isOK = false;
            }
            else
            {
                isOK = true;
            }

            return isOK;

        }


        /// <summary>
        /// Eliminamos un producto logicamente cambiando el estado a falso.
        /// </summary>
        private bool eliminarProducto()
        {

            bool isOK = false;

            try
            {
                productoGlo.estado = false;

                //Auditoria.
                productoGlo.usuario_ult_mod = Global.Usuario.nombreUsuario;
                productoGlo.fecha_ult_mod = Utility.getDate();

                productoGlo = ProductoIns.actualizarProducto(productoGlo);

                if (productoGlo.estado == false)
                {
                    MessageBox.Show("El producto se ha retirado del sistema.", "Consulta exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isOK = true;
                }
            }

            catch (DeletedRowInaccessibleException ex)
            {
                MessageBox.Show("Se ha generado el siguiente error: " + ex.Message, "Producto desactivado.");
                isOK = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isOK;
        }


        /// <summary>
        /// Actualizamos la informacion del producto en la base de datos.
        /// </summary>
        /// <returns></returns>
        private bool actualizarProducto()
        {
            bool isOK = false;
            try
            {
                productoGlo.id_categoria = (int)cboCategoriaProducto.SelectedValue;
                productoGlo.nombre = txtNombreProducto.Text.Trim();
                //productoGlo.precio_promo = Convert.ToInt16(txtPrecioPromo.Text.Trim());
                productoGlo.precioVenta1 = Convert.ToInt16(txtPrecioProducto.Text.Trim());

                if (banderaImagen)
                {
                    //Recuperamos el nombre de la imagen subida.
                    string imagen = Path.GetFileName(nombreImage);

                    //Creamos una nueva direccion fisica para esa nueva imagen que se subira.
                    string destinoImage = Path.Combine("C:\\temp\\productos", imagen);

                    //Cargamos la nueva direccion:
                    path = destinoImage;

                    if (productoGlo != null)
                    {
                        File.Copy(nombreImage, path);
                    }


                }


                productoGlo.foto = path;

                //productoGlo.

                productoGlo.estado = true;
                productoGlo.fecha_ult_mod = Utility.getDate();
                // productoGlo.usuario_ult_mod = Global.Usuario.nombreUsuario;

              //  productoGlo.tbDetalleDocumento = listaDetalleProduc;



                productoGlo = ProductoIns.actualizarProducto(productoGlo);
                MessageBox.Show("El producto ha sido actualizado", "Producto actualizado");



                isOK = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                isOK = false;

            }

            return isOK;
        }



        /// <summary>
        /// Almacenamos el producto nuevo en la base de datos.
        /// </summary>
        /// <returns></returns>
        private bool guardarProducto()
        {

            bool isOK = false;
            if (validarCampos())
            {

                tbProducto productoNuevo = new tbProducto();
                tbCategoriaProducto catProducto = new tbCategoriaProducto();

                try
                {
                    //Instanciamos las entidades que ocupamos para almacenar un producto nuevo.


                    //Almacenamos el nuevo producto
                    productoNuevo.nombre = txtNombreProducto.Text.Trim();
                    productoNuevo.id_categoria = (int)cboCategoriaProducto.SelectedValue;
                    productoNuevo.precioVenta1 = Convert.ToDecimal(txtPrecioProducto.Text.Trim());


                    //if (txtPrecioPromo.Text.Trim() == String.Empty)
                    //{
                    //    productoNuevo.precio_promo = 0;
                    //}
                    //else
                    //{
                    //    productoNuevo.precio_promo = Convert.ToDecimal(txtPrecioPromo.Text.Trim());

                    //}

                    productoNuevo.precio_real = Convert.ToDecimal(precioReal);

                    //if (chkEsActivaPromo.Checked)
                    //{
                    //    productoNuevo.esPromo = true;
                    //}
                    //else
                    //{
                    //    productoNuevo.esPromo = false;
                    //}

                    //Atributos de Auditoria
                    productoNuevo.estado = true;
                    productoNuevo.fecha_crea = Utility.getDate();
                    productoNuevo.fecha_ult_mod = Utility.getDate();
                    productoNuevo.usuario_crea = "JOse";  // Global.Usuario.nombreUsuario;
                    productoNuevo.usuario_ult_mod = "JOse";  // Global.Usuario.nombreUsuario;
                   // productoNuevo.tbDetalleProducto = listaDetalleProduc;

                    string destinoImage = "";

                    string destino = "C:\\temp\\productos\\";

                    if (nombreImage != "")
                    {

                        //Recuperamos el nombre de la imagen nueva.
                        string nombreImg = Path.GetFileName(nombreImage);


                        //Unimos le nombre de la image con la ruta.
                        destinoImage = Path.Combine(destino, nombreImg);
                    }



                    productoNuevo.foto = destinoImage;

                    productoNuevo = ProductoIns.guardarProducto(productoNuevo);

                    if (productoNuevo.idProducto != string.Empty)
                    {
                        if (nombreImage != "")
                        {
                            //Verificamos primero si el directorio existe, si no, se crea.
                            if (Directory.Exists(destino))
                            {

                                //Copiamos la imagen a su destino final.
                                File.Copy(nombreImage, destinoImage);

                                MessageBox.Show("El producto ha sido almacenado correctamente en el sistema.", "Exito");


                            }
                            else
                            {
                                //Creamos las carpetas y subcarpetas 
                                Directory.CreateDirectory(destino);

                                //Copiamos la imagen a su destino final.
                                File.Copy(nombreImage, destinoImage);

                                MessageBox.Show("El producto ha sido almacenado correctamente en el sistema.", "Exito");

                            }
                        }

                    }

                    MessageBox.Show("El producto ha sido almacenado en el sistema.", "Exito.");

                    isOK = true;


                }
                catch (SaveEntityException ex)
                {

                    MessageBox.Show(ex.Message);
                    isOK = false;

                }
                catch (EntityExistException ex)
                {

                    if (MessageBox.Show("¿Desae actualizar el producto existente ?", "Existe", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        productoGlo = ProductoIns.GetEntity(productoNuevo);

                        actualizarProducto();
                        isOK = true;

                    }


                }
                catch (EntityDisableStateException ex)
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


        /// <summary>
        /// Validamos los campos en el formulario de producto.
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {
            bool isOK = true;

            if (txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre del producto", "Error");
                txtPrecioProducto.Focus();
                isOK = false;

            }
            else if (txtPrecioProducto.Text == string.Empty)
            {

                MessageBox.Show("Debe ingresar el precio del producto.", "Error");
                txtPrecioProducto.Focus();
                isOK = false;
            }
            else if (listaDetalleProduc.Count == 0)
            {
                MessageBox.Show("Debe ingresar un ingrediente.", "Error");
                isOK = false;
            }

            return isOK;

        }


        private bool accionGuardar(int trans)
        {
            bool isOK = false;
            switch (trans)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    isOK = guardarProducto();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    isOK = actualizarProducto();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                    isOK = eliminarProducto();
                    break;

            }

            return isOK;

        }



        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    if (accionGuardar(bandera))
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gboDatosProducto, false);
                        Utility.ResetForm(ref gboDatosProducto);
                    }
                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatosProducto, true);
                    txtCodigoProducto.Enabled = false;
                    txtCosto.Enabled = false;
                    txtPrecioPromo.Enabled = false;
                    Utility.ResetForm(ref gboDatosProducto);
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatosProducto, true);
                    txtCodigoProducto.Enabled = false;
                    txtCosto.Enabled = false;
                    break;
                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;

                case "Buscar":

                    lstvDetalleProducto.Items.Clear();

                    if (buscarProducto())
                    {

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gboDatosProducto, false);

                    }
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gboDatosProducto, false);
                    Utility.ResetForm(ref gboDatosProducto);

                    listaDetalleProduc.Clear();
                    break;

                case "Salir":
                    this.Dispose();
                    break;
            }

        }


        /// <summary>
        /// Recuperamos los diferentes tipos de categorias en la base de datos.
        /// </summary>
        private void cargarCategoriaProductos()
        {

            cboCategoriaProducto.ValueMember = "id";
            cboCategoriaProducto.DisplayMember = "nombre";
            cboCategoriaProducto.DataSource = CatProductosIns.getCategorias(1);

        }

        public frmProductos()
        {
            InitializeComponent();
        }


        void cargarDetalleProducto(tbDetalleProducto entidad)
        {
            if (bandera == 2)
            {
                entidad.idProducto = txtCodigoProducto.Text.Trim();

            }


            tbDetalleProducto entidadAux = ProductoIns.getDetalleProdByIngreProd(entidad.idIngrediente, entidad.idProducto);
            //Asignamos la nueva entidad a la coleccion.
            if (entidadAux != null)
            {
                if (entidadAux.id != null) {

                    entidadAux.cantidad = entidad.cantidad;
                    listaDetalleProduc.Add(entidadAux);
                } else {

                    listaDetalleProduc.Add(entidad);

                }



            }else
            {
                listaDetalleProduc.Add(entidad);

            }


            //Limpiamos los items en la lista.
            lstvDetalleProducto.Items.Clear();

            precioReal = 0.0F;

            foreach (tbDetalleProducto p in listaDetalleProduc)
            {

                ListViewItem itemNuevo = new ListViewItem();

                itemNuevo.Text = p.idIngrediente.ToString();

                //realizamos consulta para recuperar el nombre del ingrediente segun su ID
                tbIngredientes nombreIngrediente = ProductoIns.getNombrePorID(p.idIngrediente);

                itemNuevo.SubItems.Add(nombreIngrediente.nombre.Trim());

                itemNuevo.SubItems.Add(p.cantidad.ToString());

                lstvDetalleProducto.Items.Add(itemNuevo);


                //Llamamos el metodo para calcular el precio Real.
                calcularPrecioReal(p.idIngrediente, p.cantidad);



            }
        }


        /// <summary>
        /// Recuperamos los ingredientes del formulario agregar ingrediente
        /// </summary>
        /// <param name="detalle"></param>
        private void recuperarDetalleProducto(tbDetalleProducto detalle)
        {

            detalleProducto = detalle;

            if (detalleProducto != null)
            {
                cargarDetalleProducto(detalleProducto);


            }

        }


        /// <summary>
        /// Calculamos el precio real del producto.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Cantidad"></param>
        private void calcularPrecioReal(int ID, float Cantidad)
        {

            //Creamos dos variables para mantener la informacion viva.
            double precioCompra = 0.0f;
            double subtotal = 0.0f;

            //Creamos una instancia de ingrediente para recuperar su ID.
            tbIngredientes ingrediente = new tbIngredientes();

            try
            {

                //Recuperamos el precio de compra del ingrediente segun su ID.
                ingrediente.idIngrediente = ID;

                ingrediente = IngredientesIns.GetEntityById(ingrediente);

                precioCompra = Convert.ToDouble(ingrediente.precioCompra);

                //Realizamos los calculas para obtener el precio real del producto.
                subtotal = (precioCompra * Cantidad) / 1;

                //Sumamos el precio real actual con el del ingrediente nuevo.
                precioReal += subtotal;



                //Mostramos el precio real en pantalla.
                txtCosto.Text = precioReal.ToString("0.00").Trim();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmAgregarIngredieteProducto frmIngredienteNuevo = new frmAgregarIngredieteProducto();
            //Asignamos el id del producto.

            frmIngredienteNuevo.recuperarDetalleProducto += recuperarDetalleProducto;

            frmIngredienteNuevo.ShowDialog();

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

            //deshabilitamos el formulario al iniciar la carga.
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gboDatosProducto, false);

            txtCosto.Enabled = false;



            //Cargamos las categorias de productos
            cargarCategoriaProductos();
        }


        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Recuperamos la direccion fisica de la imagen.
                nombreImage = openFile.FileName;
                Image imagen = new Bitmap(nombreImage);
                ptbImageProducto.Image = imagen;

                banderaImagen = true;

            }
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void gboDatosProducto_Enter(object sender, EventArgs e)
        {

        }

        private void ckbEsActivaPromo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEsActivaPromo.Checked)
            {
                txtPrecioPromo.Enabled = chkEsActivaPromo.Checked;
            }
            else
            {
                txtPrecioPromo.Enabled = false;
            }
        }


        private void lstvDetalleProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDetalleProducto.SelectedItems.Count > 0)
            {
                int select = Convert.ToInt16(lstvDetalleProducto.SelectedItems[0].Text.Trim());
                foreach (tbDetalleProducto ingrediente in listaDetalleProduc)
                {
                    if (ingrediente.idIngrediente == select)
                    {
                        quitarIngrediente = ingrediente;
                    }
                }
            }
        }

        private void lstvDetalleProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        private void btnQuitarIngrediente_Click_1(object sender, EventArgs e)
        {

            // Procedemos a eliminar el producto del ListView.
            if (quitarIngrediente != null)
            {
                // Recorremos la lista para eliminar el ingrediente que corresponda.
                foreach (tbDetalleProducto p in listaDetalleProduc)
                {
                    if (p.idIngrediente == quitarIngrediente.idIngrediente)
                    {
                        listaDetalleProduc.Remove(p);
                        break;

                    }

                }

                lstvDetalleProducto.Items.Clear();

                foreach (tbDetalleProducto p in listaDetalleProduc)
                {

                    ListViewItem itemNuevo = new ListViewItem();

                    itemNuevo.Text = p.idIngrediente.ToString();

                    //realizamos consulta para recuperar el nombre del ingrediente segun su ID
                    tbIngredientes nombreIngrediente = ProductoIns.getNombrePorID(p.idIngrediente);

                    itemNuevo.SubItems.Add(nombreIngrediente.nombre.Trim());

                    itemNuevo.SubItems.Add(p.cantidad.ToString());

                    lstvDetalleProducto.Items.Add(itemNuevo);


                    //Llamamos el metodo para calcular el precio Real.
                    calcularPrecioReal(p.idIngrediente, p.cantidad);



                }



            }



        }

        private void lstvDetalleProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            // Al seleccionar un ingrediente, este pasa a ser almacenado en una variable global.
            if (lstvDetalleProducto.SelectedItems.Count > 0)
            {
                int temp = Convert.ToInt16( lstvDetalleProducto.SelectedItems[0].Text.Trim() );

                // Recorremos la lista de Detalle Producto
                foreach (tbDetalleProducto item in listaDetalleProduc)
                {
                    // Comparamos cada uno de los items, si lo encuentro lo inngresa en la variables para proceder a eliminar.
                    if (item.idIngrediente == temp)
                    {
                        // Cargamos el item seleccionado en la variable para eliminar.
                        quitarIngrediente = item;
                    }
                }
            }


        }
    }
}
