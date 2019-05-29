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
    public partial class frmProductos2 : Form
    {
        List<tbDetalleProducto> listaDetalleProduc = new List<tbDetalleProducto>();

        tbProducto productoGlo = new tbProducto();
        tbDetalleProducto detalleProducto = new tbDetalleProducto();


        // Creamos una nueva instancia de tipo tbDetalleProducto que enviaremos a eliminar.
        List<tbDetalleProducto> eliminarDetalle = new List<tbDetalleProducto>();

        BProducto productoIns = new BProducto();
        BCategoriaProducto CatProductosIns = new BCategoriaProducto();
        BImpuestos ImpIns = new BImpuestos();
        bTipoMedidas medidaIns = new bTipoMedidas();
        tbProveedores proveedor = null;

        int bandera = 1;


        public frmProductos2()
        {
            InitializeComponent();
        }

        private void frmProductos2_Load(object sender, EventArgs e)
        {

            //deshabilitamos el formulario al iniciar la carga.
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gboDatosProducto, false);

            txtCosto.Enabled = false;


            cargarCombos();
            cboImpuesto.SelectedIndex = 0;
            cboCategoriaProducto.SelectedIndex = 0;
            cboMedida.SelectedIndex = 0;

        }

        private void cargarCombos()
        {

           

            cboCategoriaProducto.ValueMember = "id";
            cboCategoriaProducto.DisplayMember = "nombre";
            cboCategoriaProducto.DataSource = CatProductosIns.getCategorias((int)Enums.EstadoBusqueda.Activo);


            cboImpuesto.ValueMember = "id";
            cboImpuesto.DisplayMember = "valor";
            cboImpuesto.DataSource = ImpIns.getImpuestos((int)Enums.EstadoBusqueda.Activo);

            cboMedida.ValueMember = "idTipoMedida";
            cboMedida.DisplayMember = "nombre";
            cboMedida.DataSource = medidaIns.getlistatipomedida();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buscarProveedor()
        {
            try
            {

                frmBuscarProveedores buscarProve = new frmBuscarProveedores();
                buscarProve.pasarDatosEvent += dataBuscar;

                buscarProve.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataBuscar(tbProveedores prove) {
            if (prove != null)
            {
                proveedor = prove;
                 txtIdProveedor.Text = prove.id;
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExento.Checked)
            {
                cboImpuesto.SelectedIndex = 1;
                cboImpuesto.Enabled = false;

            }
            else {
                cboImpuesto.Enabled = true;
                cboImpuesto.SelectedIndex = 0;

            }
            calcularMontos();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            completarUtilidad();
            calcularMontos();
        }
        private void completarUtilidad() {

            float utilidadBase = Global.Usuario.tbEmpresa.tbParametrosEmpresa.ElementAt(0).utilidadBase;
            if (txtUtilidad1.Text == string.Empty || txtUtilidad1.Text == "0")
            {
                txtUtilidad1.Text = utilidadBase.ToString();

            }
            if (txtUtilidad2.Text == string.Empty || txtUtilidad2.Text=="0")
            {
                txtUtilidad2.Text = utilidadBase.ToString();

            }
            if (txtUtilidad3.Text == string.Empty || txtUtilidad3.Text == "0")
            {
                txtUtilidad3.Text = utilidadBase.ToString();

            }
        }
        private void calcularMontos()
        {

     
            decimal precio1 = 0, precio2 = 0, precio3 = 0, impuesto=0, costo=0;

            if (txtCosto.Text == string.Empty) {
                txtCosto.Text = "0";

            }
            costo = decimal.Parse(txtCosto.Text);
            if (txtUtilidad1.Text==string.Empty) {
                txtUtilidad1.Text = "0";
            }
            if (txtUtilidad2.Text == string.Empty)
            {
                txtUtilidad2.Text = "0";
            }
            if (txtUtilidad3.Text == string.Empty)
            {
                txtUtilidad3.Text = "0";
            }
            precio1 = (costo + (costo * (decimal.Parse(txtUtilidad1.Text)/100)));
            precio2 = (costo + (costo * (decimal.Parse(txtUtilidad2.Text) / 100)));
            precio3 = (costo + (costo * (decimal.Parse(txtUtilidad3.Text) / 100)));

            //precio1 = Utility.redondearNumero(precio1);
            //precio2 = Utility.redondearNumero(precio2);
            //precio3 = Utility.redondearNumero(precio3);

            if (cboImpuesto.SelectedIndex != -1)
            {

                impuesto = (decimal.Parse(cboImpuesto.Text))/100;


            }


            txtPrecio1.Text = precio1.ToString();
            txtPrecio2.Text = precio2.ToString();
            txtPrecio3.Text = precio3.ToString();

            precio1 += (precio1 * impuesto);
            precio2 += (precio2 * impuesto);
            precio3 += (precio3 * impuesto);

            //precio1 = Utility.redondearNumero(precio1);
            //precio2 = Utility.redondearNumero(precio2);
            //precio3 = Utility.redondearNumero(precio3);

            txtPrecioVenta1.Text = precio1.ToString();
            txtPrecioVenta2.Text = precio2.ToString();
            txtPrecioVenta3.Text = precio3.ToString();



        }

        private void txtUtilidad1_TextChanged(object sender, EventArgs e)
        {
            calcularMontos();
        }

        private void txtUtilidad2_TextChanged(object sender, EventArgs e)
        {
            calcularMontos();
        }

        private void txtUtilidad3_TextChanged(object sender, EventArgs e)
        {
            calcularMontos();
        }

        private void cboImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularMontos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarProveedor();
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuento.Checked)
            {
                txtDescuentoMax.Text = "0";
                txtDescuentoMax.Enabled = true;

            }
            else {
                txtDescuentoMax.Text = "0";
                txtDescuentoMax.Enabled = false;
            }
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            accionMenu(e.ClickedItem.Text);
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

        /// <summary>
        /// Validamos los campos en el formulario de producto.
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {
            bool isOK = true;

            if (txtCodigoProducto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el codigo del producto", "Error");
                txtCodigoProducto.Focus();
                isOK = false;

            }else if (txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre del producto", "Error");
                txtNombreProducto.Focus();
                isOK = false;

            }
            else if (txtCosto.Text == string.Empty || txtCosto.Text=="0")
            {

                MessageBox.Show("Debe ingresar el precio de costo del producto", "Error");
                txtCosto.Focus();
                isOK = false;
            }
            else if (cboCategoriaProducto.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una categoria del producto.", "Error");
                isOK = false;
            }
            else if (cboMedida.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una medida del producto.", "Error");
                isOK = false;
            }
            else if (!chkExento.Checked && (cboImpuesto.Text == string.Empty || cboImpuesto.Text=="0"))
            {
                MessageBox.Show("Debe ingresar los impuestos correspondientes del producto.", "Error");
                isOK = false;
            }
            else if ((txtUtilidad1.Text == string.Empty )&& (txtUtilidad2.Text == string.Empty ) && (txtUtilidad3.Text == string.Empty ))
            {

                MessageBox.Show("Debe ingresar utilidad al producto.", "Error");
                isOK = false;
            }
            else if (chkDescuento.Checked && (txtDescuentoMax.Text == string.Empty || txtDescuentoMax.Text == "0"))
            {
                MessageBox.Show("Debe ingresar el descuento máximo del producto.", "Error");
                isOK = false;
            }

            return isOK;

        }

        private bool guardarProducto()
        {

            bool isOK = false;
            if (validarCampos())
            {

                tbProducto productoNuevo = new tbProducto();
               

                try
                {
                    //Instanciamos las entidades que ocupamos para almacenar un producto nuevo.

                    productoNuevo.idProducto = txtCodigoProducto.Text;

                    //Almacenamos el nuevo producto
                    productoNuevo.nombre = txtNombreProducto.Text.ToUpper().Trim();
                    productoNuevo.id_categoria = (int)cboCategoriaProducto.SelectedValue;
                    productoNuevo.idMedida = (int)cboMedida.SelectedValue;

                    //proveedor
                    if (txtIdProveedor.Text != string.Empty) {

                        productoNuevo.idProveedor = proveedor.id;
                        proveedor.tipoId = proveedor.tipoId;

                    }
                    //costo
                    productoNuevo.precio_real = decimal.Parse(txtCosto.Text);
                    productoNuevo.precioVariable = chkPrecioVariable.Checked;
                    //precio + utlilidad
                    productoNuevo.utilidad1Porc = decimal.Parse(txtUtilidad1.Text);
                    productoNuevo.utilidad2Porc = decimal.Parse(txtUtilidad2.Text);
                    productoNuevo.utilidad3Porc = decimal.Parse(txtUtilidad3.Text);

                    productoNuevo.precioUtilidad1 = decimal.Parse(txtPrecio1.Text);
                    productoNuevo.precioUtilidad2 = decimal.Parse(txtPrecio2.Text);
                    productoNuevo.precioUtilidad3 = decimal.Parse(txtPrecio3.Text);

                    //precio utilidad+ impuestos**precio venta
                    productoNuevo.esExento = chkExento.Checked;                  
                    productoNuevo.idTipoImpuesto = (int)cboImpuesto.SelectedValue;

                    productoNuevo.precioVenta1 = decimal.Parse(txtPrecioVenta1.Text);
                    productoNuevo.precioVenta2 = decimal.Parse(txtPrecioVenta2.Text);
                    productoNuevo.precioVenta2 = decimal.Parse(txtPrecioVenta3.Text);
                  
                    
                    //descuento
                    productoNuevo.aplicaDescuento = chkDescuento.Checked;
                    productoNuevo.descuento_max = chkDescuento.Checked ? int.Parse(txtDescuentoMax.Text) : 0; 

                   
                    

                    //Atributos de Auditoria
                    productoNuevo.estado = true;
                    productoNuevo.fecha_crea = Utility.getDate();
                    productoNuevo.fecha_ult_mod = Utility.getDate();
                    productoNuevo.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
                    productoNuevo.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

                    //string destinoImage = "";

                    //string destino = "C:\\temp\\productos\\";

                    //if (nombreImage != "")
                    //{

                    //    //Recuperamos el nombre de la imagen nueva.
                    //    string nombreImg = Path.GetFileName(nombreImage);


                    //    //Unimos le nombre de la image con la ruta.
                    //    destinoImage = Path.Combine(destino, nombreImg);
                    //}


                    //inventario

                    tbInventario inventario = new tbInventario();

                    inventario.idProducto = productoNuevo.idProducto;
                    inventario.cantidad = txtCantidadActual.Text == string.Empty ? 0: decimal.Parse(txtCantidadActual.Text);
                    inventario.cant_max = txtCantMax.Text == string.Empty ? 0 : decimal.Parse(txtCantMax.Text);
                    inventario.cant_min = txtCantMin.Text == string.Empty ? 0 : decimal.Parse(txtCantMin.Text);

                    inventario.estado = true;
                    inventario.fecha_crea = Utility.getDate();
                    inventario.fecha_ult_mod = Utility.getDate();
                    inventario.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
                    inventario.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

                    productoNuevo.tbInventario = inventario;




                    //productoNuevo.foto = destinoImage;

                    productoNuevo = productoIns.guardarProducto(productoNuevo);


                    MessageBox.Show("Los datos han sido almacenada en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    isOK = true;


                }
                catch (SaveEntityException ex)
                {

                    MessageBox.Show(ex.Message);
                    isOK = false;

                }
                catch (EntityExistException ex)
                {

                    if (MessageBox.Show("Datos ya existe en la base datos, ¿Desea actualizarlos?", "Datos Existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        productoGlo = productoIns.GetEntity(productoNuevo);

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
        /// Actualizamos la informacion del producto en la base de datos.
        /// </summary>
        /// <returns></returns>
        private bool actualizarProducto()
        {
            bool isOK = false;
            try
            {


                //Almacenamos el nuevo producto
                productoGlo.nombre = txtNombreProducto.Text.ToUpper().Trim();
                productoGlo.id_categoria = (int)cboCategoriaProducto.SelectedValue;
                productoGlo.idMedida = (int)cboMedida.SelectedValue;

                //proveedor
                if (txtIdProveedor.Text != string.Empty)
                {

                    productoGlo.idProveedor = proveedor.id;
                    productoGlo.idTipoIdProveedor = proveedor.tipoId;

                }
                else
                {

                    productoGlo.idProveedor = "";
                    productoGlo.idTipoIdProveedor = null;
                    productoGlo.tbProveedores = null;
                }
                //costo
                productoGlo.precio_real = decimal.Parse(txtCosto.Text);
                productoGlo.precioVariable = chkPrecioVariable.Checked;
                productoGlo.utilidad1Porc = decimal.Parse(txtUtilidad1.Text);
                productoGlo.utilidad2Porc = decimal.Parse(txtUtilidad2.Text);
                productoGlo.utilidad3Porc = decimal.Parse(txtUtilidad3.Text);

                productoGlo.precioUtilidad1 = decimal.Parse(txtPrecio1.Text);
                productoGlo.precioUtilidad2 = decimal.Parse(txtPrecio2.Text);
                productoGlo.precioUtilidad3 = decimal.Parse(txtPrecio3.Text);

                //impuestos
                productoGlo.esExento = chkExento.Checked;
                productoGlo.precioVenta1 = decimal.Parse(txtPrecioVenta1.Text);
                productoGlo.precioVenta2 = decimal.Parse(txtPrecioVenta2.Text);
                productoGlo.precioVenta3 = decimal.Parse(txtPrecioVenta3.Text);

                productoGlo.idTipoImpuesto = (int)cboImpuesto.SelectedValue;
                //descuento
                productoGlo.aplicaDescuento = chkDescuento.Checked;
                productoGlo.descuento_max = chkDescuento.Checked ? decimal.Parse(txtDescuentoMax.Text) : 0;


                productoGlo.estado = true;
                productoGlo.fecha_ult_mod = Utility.getDate();
                productoGlo.usuario_ult_mod = Global.Usuario.nombreUsuario;
                //inventario
                productoGlo.tbInventario.cantidad = decimal.Parse(txtCantidadActual.Text);
                productoGlo.tbInventario.cant_max = decimal.Parse(txtCantMax.Text);
                productoGlo.tbInventario.cant_min = decimal.Parse(txtCantMin.Text);

                productoGlo.tbInventario.estado = true;
                productoGlo.tbInventario.fecha_ult_mod = Utility.getDate();
                productoGlo.tbInventario.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper(); ;  // Global.Usuario.nombreUsuario;




                productoGlo = productoIns.actualizarProducto(productoGlo);
                MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isOK = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOK = false;

            }

            return isOK;
        }

        private bool eliminarProducto()
        {

            bool isOK = false;

            try
            {
                productoGlo.estado = false;

                //Auditoria.
                productoGlo.usuario_ult_mod = Global.Usuario.nombreUsuario;
                productoGlo.fecha_ult_mod = Utility.getDate();

                productoGlo = productoIns.actualizarProducto(productoGlo);


                MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isOK = false;

            }

            catch (DeletedRowInaccessibleException ex)
            {
                MessageBox.Show("Se ha generado el siguiente error: " + ex.Message, "Producto desactivado.");
                isOK = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isOK;
        }
        private void recuperarEntidad(tbProducto entidad)
        {
            //Cargamos los valores a la entidad.
            productoGlo = entidad;


            if (productoGlo != null)
            {

                //Ingresamos los datos del producto en el formulario.
                txtCodigoProducto.Text = productoGlo.idProducto.ToString();
                txtNombreProducto.Text = productoGlo.nombre.ToUpper();

                cboMedida.SelectedValue = productoGlo.idMedida;
                cboCategoriaProducto.SelectedValue = productoGlo.id_categoria;
                cboImpuesto.SelectedValue = productoGlo.idTipoImpuesto;

                //proveedor
                proveedor = productoGlo.tbProveedores;
                if (proveedor != null)
                {
                    txtIdProveedor.Text = proveedor.id;

                }

                chkPrecioVariable.Checked = (bool)productoGlo.precioVariable;
                txtCosto.Text = productoGlo.precio_real.ToString();

                txtUtilidad1.Text = productoGlo.utilidad1Porc.ToString();
                txtUtilidad2.Text = productoGlo.utilidad2Porc.ToString();
                txtUtilidad3.Text = productoGlo.utilidad3Porc.ToString();
                txtPrecio1.Text = productoGlo.precioUtilidad1.ToString();
                txtPrecio2.Text = productoGlo.precioUtilidad2.ToString();
                txtPrecio3.Text = productoGlo.precioUtilidad3.ToString();

                //impuesto
                chkExento.Checked = productoGlo.esExento;
                cboImpuesto.SelectedValue = productoGlo.idTipoImpuesto;

                txtPrecioVenta1.Text = productoGlo.precioVenta1.ToString();
                txtPrecioVenta2.Text = productoGlo.precioVenta2.ToString();
                txtPrecioVenta3.Text = productoGlo.precioVenta3.ToString();
                //descuento
                chkDescuento.Checked = (bool)productoGlo.aplicaDescuento;
                txtDescuentoMax.Text = productoGlo.descuento_max.ToString();


                //inventario
                txtCantidadActual.Text = productoGlo.tbInventario.cantidad.ToString();
                txtCantMax.Text = productoGlo.tbInventario.cant_max.ToString();
                txtCantMin.Text = productoGlo.tbInventario.cant_min.ToString();

            }

        }

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

        private void reset()
        {
            Utility.ResetForm(ref gboDatosProducto);
            Utility.ResetForm(ref gbxDesc);
            Utility.ResetForm(ref gbxImpuestos);
            Utility.ResetForm(ref gbxInv);
            Utility.ResetForm(ref gbxUtilidades);
            cboCategoriaProducto.SelectedIndex = 0;
            cboImpuesto.SelectedIndex = 0;
            cboMedida.SelectedIndex = 0;
            txtCantidadActual.Text = "0";
            txtCantMax.Text = "0";
            txtCantMin.Text = "0";
            txtDescuentoMax.Text = "0";
            chkDescuento.Checked = true;
            chkExento.Checked = false;
            chkPrecioVariable.Checked = false;
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
                        reset();

                    }
                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatosProducto, true);


                    reset();
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatosProducto, true);
                    txtCodigoProducto.Enabled = false;
        
                    break;
                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;

                case "Buscar":


                    if (buscarProducto())
                    {

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gboDatosProducto, false);

                    }
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gboDatosProducto, false);
                    reset();


                    break;

                case "Salir":
                    this.Dispose();
                    break;
            }

        }



    }
}
