﻿using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BussinessExceptions;
using EntityLayer;
using PresentationLayer.Reportes;
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
        List<tbCategoriaProducto> listaCategorias;  
        BCategoriaProducto categoriaIns = new BCategoriaProducto();
        bTipoMedidas medidaIns = new bTipoMedidas();
        tbTipoMedidas medida = new tbTipoMedidas();

        bool isAlias = false;

        List<FacturasPendientes> facturasPendientes = new List<FacturasPendientes>();

        BProducto productoIns = new BProducto();
        BFacturacion facturaIns = new BFacturacion();
        BInventario invetnarioIns = new BInventario();
        tbCategoriaProducto categoriaProducGlo = new tbCategoriaProducto();
        CorreoElectronico correoIns;
        BProducto BProducto = new BProducto();
        Bcliente BCliente = new Bcliente();
        BUsuario usuarioIns = new BUsuario();
        List<tbProducto> listaProductos= new List<tbProducto>();
        List<tbDetalleDocumento> listaDetalleDocumento = new List<tbDetalleDocumento>();
        tbClientes clienteGlo = null; 
        tbDocumento documentoGlo = null;
        bool exoneracionClie = false;
        bool respuestaAprobaDesc = false;
        decimal porcDesc = 0;
        int tipoDoc = 1;
        decimal peso = decimal.MinValue;
        string alias = string.Empty;
        bool existeRespuesta = false;

        const float sizeText = 6;
        const int sizeCuadro = 75;


        public delegate void FacturaGuardar(tbDocumento entity);
        public event FacturaGuardar detalleFacturacion;

        public frmFacturacion()
        {
            InitializeComponent();
        }       

        private void formatoGrid()
        {
            dtgvDetalleFactura.BorderStyle = BorderStyle.None;
            dtgvDetalleFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvDetalleFactura.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvDetalleFactura.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            dtgvDetalleFactura.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvDetalleFactura.BackgroundColor = Color.White;

            dtgvDetalleFactura.EnableHeadersVisualStyles = false;
            dtgvDetalleFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvDetalleFactura.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgvDetalleFactura.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        //Se crean los metodos necesarios para cargar el usuario y sus requerimientos segun el permiso que posea.
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            btnReImprimir.Enabled = (bool)Global.Usuario.tbEmpresa.imprimeDoc;
            formatoGrid();         
            cargarDatos();
            txtCodigo.Focus();
            if (!Utility.AccesoInternet())
            {
                MessageBox.Show("No hay acceso a internet", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lblPendientes.Text = facturasPendientes.Count.ToString();
            //cargarListaPendientes();

        }       

        private void cargarDatos()
        {
           
            listaCategorias = categoriaIns.getCategorias(1);
            cargaCategorias(listaCategorias);
            cargarProductos(listaCategorias);


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
                btn.Location = new System.Drawing.Point(sizeCuadro * x, sizeCuadro * y);
                btn.Size = new System.Drawing.Size(sizeCuadro, sizeCuadro);
                btn.BackColor = Color.DarkBlue;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", sizeText, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.MiddleCenter;
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

                if(x == 5)
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
                        btn.Location = new System.Drawing.Point(sizeCuadro * x, sizeCuadro * y);
                        btn.Size = new System.Drawing.Size(sizeCuadro, sizeCuadro);
                        btn.BackColor = Color.SeaGreen;
                        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", sizeText, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.ForeColor = Color.White;
                        btn.TextAlign = ContentAlignment.MiddleCenter;
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

                        if (x == 10)
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

                        agregarProductoDetalleFactura(pro);

                        break;

                    }
                }
            }
        }        

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.Text == string.Empty)
            {
                txtIdCliente.Text = string.Empty;
                txtCliente.Text = string.Empty;            
                txtTel.Text = string.Empty;
                txtCorreo.Text = string.Empty;
                exoneracionClie = false;

                calcularMontosT();

            }
        }

        private void calcularMontosT()
        {
            asignarLineasNumero();
            calcularDescuentos();
            calcularImpuestos();
            calcularTotales();
        }

        private void asignarLineasNumero()
        {
            int linea = 0;
            foreach (tbDetalleDocumento det in listaDetalleDocumento)
            {
                linea++;
                det.numLinea = linea;
            }

        }

        private void calcularTotales()
        {
            decimal total = 0, desc = 0, iva = 0, subtotal = 0, exo = 0;

            foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
            {
                detalle.totalLinea = (detalle.montoTotal - detalle.montoTotalDesc) + detalle.montoTotalImp-detalle.montoTotalExo;
                total += detalle.totalLinea;
                desc += detalle.montoTotalDesc;
                iva += detalle.montoTotalImp;
                exo += detalle.montoTotalExo;
                subtotal += detalle.montoTotal;

            }
            txtSubtotal.Text = subtotal.ToString("#.##");
            txtDescuento.Text = desc.ToString("#.##");
            txtIva.Text = iva.ToString("#.##");
            txtTotal.Text = total.ToString("#.##");
            txtExoneracion.Text = exo.ToString("#.##");

            if (txtSubtotal.Text == string.Empty)
            {
                txtSubtotal.Text = "0";

            }
            if (txtTotal.Text == string.Empty)
            {
                txtTotal.Text = "0";

            }

            if (txtPorcetaje.Text == string.Empty)
            {
                txtPorcetaje.Text = "0";

            }
            if (txtDescuento.Text == string.Empty)
            {
                txtDescuento.Text = "0";

            }
            if (txtIva.Text == string.Empty)
            {
                txtIva.Text = "0";

            }
            if (txtExoneracion.Text == string.Empty)
            {
                txtExoneracion.Text = "0";

            }
        }

        private void calcularImpuestos()
        {

            foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
            {
                //sino es excento el producto
                if (!detalle.tbProducto.esExento)
                {
                    detalle.montoTotalExo = 0;
                    //aplica exoneracion al cliente
                    if (exoneracionClie)
                    {
                        detalle.montoTotalExo = (detalle.montoTotal - detalle.montoTotalDesc) * (((decimal)detalle.tbProducto.tbImpuestos.valor) / 100);
                      
                    }
                    
                    detalle.montoTotalImp = (detalle.montoTotal - detalle.montoTotalDesc) * (((decimal)detalle.tbProducto.tbImpuestos.valor) / 100);
                }
                else
                {//no aplica impuesto ya que el producto es excento.
                    detalle.montoTotalImp = 0;
                    detalle.montoTotalExo = 0;

                }

            }

        }

        private void calcularDescuentos()
        {

            decimal descMaxEmp = ((decimal)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().descuentoBase) / 100;
            bool aprobDescEmp = (bool)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().aprobacionDescuento;
            bool validaDesc = true;
            decimal porc = 0;

            if (txtPorcetaje.Text != string.Empty)
            {

                porc = decimal.Parse(txtPorcetaje.Text) / 100;

            }
            else
            {

                txtDescuento.Text = "0";
            }
            //verifica si el descuento es mayoral porcentaje permitido en la empresa, de lo contrario que aplique
            if (porc > descMaxEmp)
            {//se debe de solicitar aprobacion en caso que la empresa lo requiera, segun el parametro de la empresa
                if (aprobDescEmp)
                {
                    if (!respuestaAprobaDesc && porcDesc != decimal.Parse(txtPorcetaje.Text.Trim()))
                    {

                        //form para aprobacion de un administrador true aprueba, false no aprueba
                        frmAprobacion aprobacionForm = new frmAprobacion();
                        aprobacionForm.pasarDatosEvent += respuestaAprobacion;
                        aprobacionForm.ShowDialog();
                        validaDesc = respuestaAprobaDesc;
                    }
                    else
                    {
                        validaDesc = true;
                    }
                }
                else
                {

                    validaDesc = true;

                }
            }
            if (validaDesc)
            {

                foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
                {

                    if ((bool)detalle.tbProducto.aplicaDescuento)
                    {
                        if (porc > ((detalle.tbProducto.descuento_max) / 100))
                        {
                            detalle.descuento = (decimal)detalle.tbProducto.descuento_max;
                            detalle.montoTotalDesc = detalle.montoTotal * ((decimal)detalle.tbProducto.descuento_max / 100);
                        }
                        else
                        {
                            detalle.descuento = (decimal)porc * 100;
                            detalle.montoTotalDesc = detalle.montoTotal * porc;
                        }
                    }
                    else
                    {
                        detalle.descuento = 0;
                        detalle.montoTotalDesc = 0;

                    }
                }

            }
            else
            {
                porcDesc = 0;
                txtPorcetaje.Text = porcDesc.ToString();
                calcularMontosT();
            }
            respuestaAprobaDesc = false;

        }

        private void respuestaAprobacion(bool aprob)
        {
            respuestaAprobaDesc = aprob;
            porcDesc = decimal.Parse(txtPorcetaje.Text.Trim());
        }      

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            FrmBuscar buscar = new FrmBuscar();
            buscar.pasarDatosEvent += dataBuscar;
            buscar.ShowDialog();
        }

        private void dataBuscar(tbClientes cliente)
        {
            exoneracionClie = false;
            if (cliente != null)
            {
                clienteGlo = cliente;
                if (cliente.idExonercion != null)
                {
                    DialogResult result = MessageBox.Show("El cliente seleccionado aplica para exoneración de impuesto, ¿Desea aplicar la exoneración de impuestos?", "Exoneración de Impuestos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        exoneracionClie = true;

                    }
                    else
                    {
                        exoneracionClie = false;
                    }

                }
                txtIdCliente.Text = cliente.id.Trim();
                if (cliente.tipoId == 1)
                {
                    txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper() + " " + cliente.tbPersona.apellido1.Trim().ToUpper() + " " + cliente.tbPersona.apellido2.Trim().ToUpper();

                }
                else
                {
                    txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper();

                }         
                txtTel.Text = cliente.tbPersona.telefono.ToString().Trim().ToUpper();
                txtCorreo.Text = cliente.tbPersona.correoElectronico.Trim();

                calcularMontosT();

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarProducto();
        }

        private void buscarProducto()
        {

            //bool isOK = false;

            frmBuscarProducto buscarProduct = new frmBuscarProducto();

       
            buscarProduct.recuperarEntidad += recuperarEntidad;

            buscarProduct.ShowDialog();

            

        }

        private void recuperarEntidad(tbProducto entidad)
        {

            //Cargamos los valores a la entidad.

            if (entidad != null)
            {

                agregarProductoDetalleFactura(entidad);

            }

        }

        private void agregarProductoDetalleFactura(tbProducto pro)
        {

            agregarProductoDetalleFactura(pro, 1, 1, true);
        }

        private void agregarProductoDetalleFactura(tbProducto pro, int tipo, decimal cantidad, bool acumular)
        {

            bool banderaExitProd = false;
            medida.idTipoMedida = pro.idMedida;
            medida = medidaIns.GetEnityById(medida);
            if (medida.nomenclatura.Trim().ToUpper() == Enum.GetName(typeof(Enums.TipoMedida), Enums.TipoMedida.kg).Trim().ToUpper())
            {
                frmCantidad cantidadfrm = new frmCantidad();
                cantidadfrm.pasarDatosEvent += cantidadPasarDatos;
                cantidadfrm.ShowDialog();
                if (peso==decimal.MinValue)
                {
                    return;
                }
                cantidad = peso;
            }
            

            if (tipo == 1)
            {

                bool banderaInventario = verificarInventario(pro, cantidad, acumular);
                if (banderaInventario)
                {
                    foreach (tbDetalleDocumento det in listaDetalleDocumento)
                    {

                        if (det.idProducto == pro.idProducto)
                        {
                            if (acumular)
                            {
                                det.cantidad += cantidad;
                                //det.precio = buscarPrecioProducto(pro);
                            }
                            else
                            {
                                det.cantidad = cantidad;

                            }

                            det.montoTotal = det.precio * det.cantidad;
                            det.descuento = 0;

                            banderaExitProd = true;
                            break;
                        }
                    }
                    //prodcuto nuevo
                    if (!banderaExitProd)
                    {

                        tbDetalleDocumento detalle = new tbDetalleDocumento();
                        detalle.cantidad = cantidad;
                        detalle.idProducto = pro.idProducto;
                        detalle.precio = buscarPrecioProducto(pro);
                        detalle.montoTotal = detalle.precio*detalle.cantidad;
                        detalle.montoTotalDesc = 0;
                        detalle.montoTotalExo = 0;
                        detalle.montoTotalImp = 0;
                        detalle.tbProducto = pro;
                        listaDetalleDocumento.Add(detalle);
                    }
                }
                else
                {
                    MessageBox.Show("El producto ingresado ya no cuenta con existencia en inventario. Cantidad existencia (" + pro.tbInventario.cantidad + ")", "Inexistencia Inventario", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                foreach (tbDetalleDocumento det in listaDetalleDocumento)
                {
                    if (det.idProducto == pro.idProducto)
                    {


                        det.precio = cantidad;
                        det.montoTotal = det.precio * det.cantidad;
                        det.descuento = 0;

                        break;
                    }
                }

            }

            calcularMontosT();
            agregarProductoGrid();

        }

        private void cantidadPasarDatos(decimal peso)
        {
           this.peso = peso;
        }

        private void agregarProductoGrid()
        {
            decimal cantidadProd = 0;
            dtgvDetalleFactura.Rows.Clear();
            foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
            {
                cantidadProd += detalle.cantidad;
                DataGridViewRow row = (DataGridViewRow)dtgvDetalleFactura.Rows[0].Clone();

                row.Cells[0].Value = detalle.tbProducto.nombre.Trim();
                if (detalle.precio == 0)
                {
                    row.Cells[1].Value = "0.00";
                }
                else
                {
                    row.Cells[1].Value = detalle.precio.ToString("#.##").Trim();
                }


                row.Cells[2].Value = detalle.cantidad.ToString("#.##").Trim();
                row.Cells[3].Value = (decimal)detalle.tbProducto.descuento_max;
                row.Cells[4].Value = detalle.montoTotal.ToString("#.##").Trim();
                row.Cells[5].Value = detalle.idProducto.ToString().Trim();

                dtgvDetalleFactura.Rows.Add(row);
                // dtgvDetalleFactura.Rows[listaDetalleDocumento.Count-1].Selected=true;
            }
            lblTotalProducto.Text = cantidadProd.ToString("#.#");
            lblCantidadLineas.Text = listaDetalleDocumento.Count.ToString();
            if (listaDetalleDocumento.Count != 0)
            {
                dtgvDetalleFactura.Rows[listaDetalleDocumento.Count - 1].Selected = true;
            }


        }

        private decimal buscarPrecioProducto(tbProducto pro)
        {
            decimal precioPro = 0;

            //Global.Usuario = usuarioIns.getLoginUsuario(Global.Usuario);
            int preciobase = (int)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().precioBase;


            if (clienteGlo != null)
            {
                precioPro = clienteGlo.precioAplicar;

            }

            if (preciobase == 1)
            {
                precioPro = (decimal)pro.precioUtilidad1;
            }
            else if (preciobase == 2)
            {
                precioPro = (decimal)pro.precioUtilidad2;
            }
            else
            {
                precioPro = (decimal)pro.precioUtilidad3;
            }


            return precioPro;
        }

        private bool verificarInventario(tbProducto pro, decimal cantidadSolic, bool acumular)
        {
            bool verificar = true;
            decimal cantidad = 0;

            bool verificaInventario = (bool)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().manejaInventario;
            decimal cantidadInventario = (decimal)pro.tbInventario.cantidad;
            if (verificaInventario)
            {
                foreach (tbDetalleDocumento det in listaDetalleDocumento)
                {

                    if (det.idProducto == pro.idProducto)
                    {
                        cantidad = det.cantidad;
                        break;
                    }
                }
                if (acumular)
                {
                    cantidad += cantidadSolic;
                }
                else
                {
                    cantidad = cantidadSolic;
                }


                if (pro.tbInventario.cantidad >= cantidad)
                {
                    verificar = true;
                }
                else
                {
                    verificar = false;
                }

            }


            return verificar;

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbProducto prod = null;
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                string codigo = txtCodigo.Text;
                if (codigo != string.Empty)
                {
                    prod = buscarProducto(codigo);
                    if (prod != null)
                    {
                        agregarProductoDetalleFactura(prod);
                    }

                }
                txtCodigo.Text = string.Empty;
                txtCodigo.Focus();
            }
        }

        private tbProducto buscarProducto(string idProd)
        {
            tbProducto producto = new tbProducto();
            if (idProd != string.Empty)
            {
                producto.idProducto = idProd;

                Global.Usuario = usuarioIns.getLoginUsuario(Global.Usuario);
                producto = BProducto.GetEntity(producto);

                if (producto == null)
                {

                    producto = null;
                    MessageBox.Show("El producto digitado no se encuentra en la base datos.", "Producto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
            }
            else
            {
                producto = null;


            }
            return producto;

        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtIdCliente.Text != string.Empty)
                {
                    try
                    {
                        clienteGlo = BCliente.GetClienteById(txtIdCliente.Text.Trim());
                        if (clienteGlo != null)
                        {
                            dataBuscar(clienteGlo);
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró el Cliente con el ID: {txtIdCliente.Text.Trim()}", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            clienteGlo = null;
                            txtIdCliente.Text = string.Empty;
                            txtCliente.Text = string.Empty;
             
                            txtTel.Text = string.Empty;
                            txtCorreo.Text = string.Empty;
                            txtCorreo2.Text = string.Empty;

                        }
                    }
                    catch (Exception)
                    {
                        txtCliente.Text = string.Empty;
                        MessageBox.Show("No se pudo obtener el Cliente, verifique los datos", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }

        private void dtgvDetalleFactura_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string codigoProducto = dtgvDetalleFactura.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (codigoProducto != string.Empty)
                {

                    DialogResult result = MessageBox.Show("¿Desea eliminar el producto " + dtgvDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() + " de la factura?", "Eliminar linea", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        eliminarProducto(codigoProducto);

                    }
                }
            }
        }

        private void eliminarProducto(string codigoProducto)
        {


            foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
            {
                if (detalle.idProducto == codigoProducto)
                {
                    listaDetalleDocumento.Remove(detalle);
                    break;
                }

            }


            calcularMontosT();
            agregarProductoGrid();
        }

        private void dtgvDetalleFactura_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)        {
            
            decimal cantidad = 0;
            string codigoProducto = string.Empty;
            decimal precioProd = 0;

            try
            {
                //cuando cambia la cantidad
                if (dtgvDetalleFactura.Columns[e.ColumnIndex].Name == "colCant")
                {
                    if (dtgvDetalleFactura.Rows[e.RowIndex].Cells[5].Value != null)
                    {
                        tbProducto prod;
                        codigoProducto = dtgvDetalleFactura.Rows[e.RowIndex].Cells[5].Value.ToString();

                        if (dtgvDetalleFactura.Rows[e.RowIndex].Cells[2].Value != null)
                        {

                            cantidad = decimal.Parse(dtgvDetalleFactura.Rows[e.RowIndex].Cells[2].Value.ToString());

                            prod = buscarProducto(codigoProducto);
                            if (prod != null)
                            {
                                agregarProductoDetalleFactura(prod, 1, cantidad, false);
                            }
                        }

                    }
                }
                //cuando cambia el precio
                if (dtgvDetalleFactura.Columns[e.ColumnIndex].Name == "colPrec")
                {
                    if (dtgvDetalleFactura.Rows[e.RowIndex].Cells[5].Value != null)
                    {
                        tbProducto prod;
                        codigoProducto = dtgvDetalleFactura.Rows[e.RowIndex].Cells[5].Value.ToString();

                        if (dtgvDetalleFactura.Rows[e.RowIndex].Cells[1].Value != null)
                        {

                            precioProd = decimal.Parse(dtgvDetalleFactura.Rows[e.RowIndex].Cells[1].Value.ToString());

                            prod = buscarProducto(codigoProducto);
                            if (prod != null)
                            {
                                if ((bool)prod.precioVariable)
                                {//el valor de 2 es para actualizar el precio y 1 para cantidad

                                    agregarProductoDetalleFactura(prod, 2, precioProd, false);
                                }
                                else
                                {
                                    agregarProductoGrid();
                                    MessageBox.Show("El precio de este producto no puede ser actualizado", "Precio Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }
                        }

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un error al cambiar los datos del producto, corrija los datos", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            tipoDoc = (int)Enums.TipoDocumento.FacturaElectronica;
            dtgvDetalleFactura.EndEdit();
            calcularMontosT();
            agregarProductoGrid();
            if (listaDetalleDocumento.Count != 0 && txtTotal.Text != "0")
            {
                if (validarCampos())
                {

                    tbDocumento documento = crearDocumento();
                    frmCobrar form = new frmCobrar();
                    form.recuperarTotal += respuesta;
                    form.facturaGlobal = documento;
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay productos o el TOTAL a cobrar es 0.", "Cobrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCampos()
        {
            bool validaCliente = (bool)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().clienteObligatorioFact;

            if (validaCliente || tipoDoc == (int)Enums.TipoDocumento.Proforma)
            {
                if (clienteGlo == null)
                {
                    MessageBox.Show("Debe indicar un cliente", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnBuscarCliente.Focus();
                    return false;
                }

            }
            if (chkEnviar.Checked)
            {
                if (txtCorreo.Text == string.Empty)
                {
                    MessageBox.Show("Debe Ingresar un correo electrónico", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return false;

                }
                if (!Utility.isValidEmail(txtCorreo.Text))
                {
                    MessageBox.Show("El formato del correo es incorrecto", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCorreo.Focus();
                    return false;
                }
                if (txtCorreo2.Text != string.Empty)
                {
                    if (!Utility.isValidEmail(txtCorreo2.Text))
                    {
                        MessageBox.Show("El formato del correo es incorrecto", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCorreo2.Focus();
                        return false;
                    }

                }
            }
            return true;
        }

        private tbDocumento crearDocumento()
        {
            tbDocumento documento = new tbDocumento();

            documento.tipoDocumento = (int)Enums.TipoDocumento.FacturaElectronica;
            documento.fecha = Utility.getDate();
            documento.tipoMoneda = (int)Enums.TipoMoneda.CRC;
            documento.tipoCambio = 0;
            documento.reporteElectronic = (bool)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().facturacionElectronica;
            documento.tipoVenta = (int)Enums.tipoVenta.Contado;
            documento.plazo = 0;
            documento.tipoPago = (int)Enums.TipoPago.Efectivo;
            documento.refPago = string.Empty;
            documento.estadoFactura = (int)Enums.EstadoFactura.Cancelada;
            documento.reporteAceptaHacienda = false;
            documento.notificarCorreo = chkEnviar.Checked;
            documento.observaciones = txtObservaciones.Text.ToUpper().Trim();
            documento.idEmpresa = Global.Usuario.tbEmpresa.id;
            documento.tipoIdEmpresa = Global.Usuario.tbEmpresa.tipoId;
            //en caso que no tenga cliente asignado, sera no contribuyente

            //si no marco el check de enviar correo, deja los campos de correo electronico a notificar null
            if ((bool)documento.notificarCorreo)
            {
                documento.correo1 = txtCorreo.Text == string.Empty ? null : txtCorreo.Text.Trim();
                documento.correo2 = txtCorreo2.Text == string.Empty ? null : txtCorreo2.Text.Trim();

            }
            //cliente
            if (clienteGlo != null)
            {
                documento.idCliente = clienteGlo.id;
                documento.tipoIdCliente = clienteGlo.tipoId;
                //asigna el valor que tenga el cliente si es contribuyente o no

                documento.tbClientes = clienteGlo;
            }
            else
            {
                documento.reporteElectronic = false;
            }

            documento.estado = true;

            //foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
            //{
            //    detalle.tbProducto = null;
            //}

            documento.tbDetalleDocumento = listaDetalleDocumento;

            //Atributos de Auditoria

            documento.fecha_crea = Utility.getDate();
            documento.fecha_ult_mod = Utility.getDate();
            documento.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
            documento.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

            return documento;
        }

        private void respuesta(tbDocumento doc)
        {
            try
            {

                if (doc != null)
                {
                    existeRespuesta = true;
                    if (isAlias)
                    {
                        var pend = facturasPendientes.Where(x => x.alias == lblAlias.Text.Trim()).SingleOrDefault();
                        facturasPendientes.Remove(pend);
                        cargarPendientes();
                    }
                    if (doc.reporteElectronic == true)
                    {

                        if (Utility.AccesoInternet())
                        {

                            BackgroundWorker tarea = new BackgroundWorker();
                            documentoGlo = doc;
                            tarea.DoWork += reportarFacturacionElectronica;
                            tarea.RunWorkerAsync();

                            if (doc.id != 0)
                            {
                                MessageBox.Show("El documento ha sido emitido correctamente, el reporte de hacienda se generará en segundo plano", "Documento creado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }

                        }
                        else
                        {
                            MessageBox.Show("No hay acceso a internet", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }

                    }
                    else
                    {
                        if (doc.id != 0)
                        {
                            MessageBox.Show("El documento ha sido emitido correctamente", "Documento creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bool enviado = false;
                            //se solicita respuesta, y se confecciona el correo a enviar
                            if ((bool)doc.notificarCorreo)
                            {

                                List<string> correos = new List<string>();
                                if (doc.correo1 != null)
                                {
                                    correos.Add(doc.correo1.Trim());

                                }
                                if (doc.correo2 != null)
                                {
                                    correos.Add(doc.correo2.Trim());

                                }
                                CorreoElectronico correo = new CorreoElectronico(doc, correos, true);
                                enviado = correo.enviarCorreo();
                            }

                        }

                    }
                    limpiarFactura();
                }
                else
                {
                    MessageBox.Show("El documento no se ha guardado, intente nuevamente, de lo contrario contacte con el administrador.", "Error al crear Documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error en el sistema, contacte al administrador", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void reportarFacturacionElectronica(object o, DoWorkEventArgs e)
        {
            tbDocumento doc = documentoGlo;
            try
            {
                //envio la factura a hacienda
                doc = facturaIns.FacturarElectronicamente(doc);

                System.Threading.Thread.Sleep(3000);
                //consulto a hacienda el estado de la factura
                try
                {
                    string mensaje = facturaIns.consultarFacturaElectronicaPorClave(doc.clave);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al consultar el estado del documento en Hacienda, valida el estado del documento", "Error al consultar el estado del documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                bool enviado = false;
                //se solicita respuesta, y se confecciona el correo a enviar
                if ((bool)doc.notificarCorreo)
                {
                    List<string> correos = new List<string>();
                    if (doc.correo1 != null)
                    {
                        correos.Add(doc.correo1.Trim());

                    }
                    if (doc.correo2 != null)
                    {
                        correos.Add(doc.correo2.Trim());

                    }
                    CorreoElectronico correo = new CorreoElectronico(doc, correos, true);
                    enviado = correo.enviarCorreo();

                }
            }
            catch (FacturacionElectronicaException ex)
            {
                MessageBox.Show("Error al realizar la facturación electronica", "Factura Electrónica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (EnvioCorreoException ex)
            {
                MessageBox.Show("Error al enviar la facturación por correo electrónico", "Correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TokenException ex)
            {
                MessageBox.Show("Error al obtener el Token en Hacienda", "Facturación electrónica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ConsultaHaciendaExcpetion ex)
            {
                MessageBox.Show("Error al consultar hacienda la factura electrónica", "Facturación electrónica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (generarXMLException ex)
            {
                MessageBox.Show("Error al generar el XML de la factura", "Facturación electrónica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception EX)
            {
                MessageBox.Show("Error general de facturación electrónica", "Facturación electrónica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarFactura()
        {
            dtgvDetalleFactura.Rows.Clear();
            listaDetalleDocumento.Clear();
            txtCodigo.Text = string.Empty;
            clienteGlo = null;
            exoneracionClie = false;
            existeRespuesta = false;

            chkEnviar.Checked = false;
            txtCorreo2.Text = string.Empty;

            txtIdCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;           
            txtTel.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCorreo2.Text = string.Empty;

            txtSubtotal.Text = "0";
            txtIva.Text = "0";
            txtPorcetaje.Text = "0";
            txtDescuento.Text = "0";
            txtTotal.Text = "0";
            lblTotalProducto.Text = "0";
            txtExoneracion.Text = "0";
            lblCantidadLineas.Text = "0";

            txtObservaciones.Text = string.Empty;

            respuestaAprobaDesc = false;
            porcDesc = 0;
            peso = decimal.MinValue;
            alias = string.Empty;
            isAlias = false;
            lblAlias.Text = string.Empty;

            lblPendientes.Text = facturasPendientes.Count.ToString();
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea limpiar por completo lo facturado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                limpiarFactura();
            }
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (documentoGlo != null)
                {

                    DialogResult dialogResult = MessageBox.Show("Desea imprimir el documento?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        clsImpresionFactura imprimir = new clsImpresionFactura(documentoGlo, Global.Usuario.tbEmpresa);
                        imprimir.print();

                    }
                }
                else
                {
                    MessageBox.Show("No hay documentos que imprimir", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al imprimir el último documento.", "Re-Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            frmBuscarDocumentos form = new frmBuscarDocumentos();
            form.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos2 form = new frmProductos2();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.ShowDialog();
        }

        private void btnValidacion_Click(object sender, EventArgs e)
        {
            frmValidacionDocumentosHacienda form = new frmValidacionDocumentosHacienda();
            form.ShowDialog();
        }

        private void txtPorcetaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                try
                {
                    if (txtPorcetaje.Text == string.Empty)
                    {


                        txtDescuento.Text = "0";
                    }

                    calcularMontosT();
                }
                catch (Exception)
                {


                    MessageBox.Show("Se produjo un error al ingresar el producto, corrija los datos", "Calcular descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            agregarPendiente();
            limpiarFactura();
            cargarPendientes();




        }

        private void agregarPendiente()
        {
            if (listaDetalleDocumento.Count != 0 && txtTotal.Text != "0")
            {
                FacturasPendientes pendiente;
                //verifica si exite ya ese alias, para agregar los cambios al detalle
                if (isAlias && lblAlias.Text != string.Empty)
                {
                    //lo busca
                    pendiente = facturasPendientes.Where(x => x.alias == lblAlias.Text.Trim()).SingleOrDefault();
                    facturasPendientes.Remove(pendiente);
                    pendiente.detalleFacturaPendiente.Clear();
                    alias = pendiente.alias;

                }
                else
                {
                    pendiente = new FacturasPendientes();
                    bool exist = false;
                    do
                    {
                        frmAliasMesa aliasForm = new frmAliasMesa();
                        aliasForm.pasarDatosEvent += aliasPasarDatos;
                        aliasForm.ShowDialog();
                        exist = facturasPendientes.Where(x => x.alias == alias).SingleOrDefault() != null;
                        if (exist)
                        {
                            MessageBox.Show("Ya existe ese ALIAS/MESA, ingreso uno diferente", "ALIAS/MESA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    } while (exist);
                    lblAlias.Text = alias;
                    isAlias = true;

                }

                if (alias != string.Empty)
                {

                    //sgrega los detalles
                    foreach (var detalle in listaDetalleDocumento)
                    {
                        DetalleFacturaPendiente detalleP = new DetalleFacturaPendiente();
                        detalleP.idTipoDoc = detalle.idTipoDoc;
                        detalleP.idProducto = detalle.idProducto;
                        detalleP.cantidad = detalle.cantidad;
                        detalleP.idDoc = detalle.idDoc;
                        detalleP.descuento = detalle.descuento;
                        detalleP.montoTotal = detalle.montoTotal;
                        detalleP.montoTotalDesc = detalle.montoTotalDesc;
                        detalleP.montoTotalExo = detalle.montoTotalExo;
                        detalleP.montoTotalImp = detalle.montoTotalImp;
                        detalleP.numLinea = detalle.numLinea;
                        detalleP.precio = detalle.precio;
                        detalleP.tbProducto = detalle.tbProducto;
                        detalleP.totalLinea = detalle.totalLinea;

                        pendiente.detalleFacturaPendiente.Add(detalleP);
                    }
                    pendiente.alias = alias;

                    facturasPendientes.Add(pendiente);
                   
                    MessageBox.Show("Pendiente actualizado", "Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                MessageBox.Show("No hay productos o el TOTAL a cobrar es 0.", "Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarPendientes()
        {
            Button btn;
            int y = 0;
            int x = 0;
            gbxPendientes.Controls.Clear();
            foreach (var pend in facturasPendientes)
            {
                btn = new Button();
                btn.Name = pend.alias;
                btn.Text = pend.alias;
                btn.Location = new System.Drawing.Point(100 * x, 100 * y);
                btn.Size = new System.Drawing.Size(100, 100);
                btn.BackColor = Color.DarkOrange;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.MiddleCenter;
               
                btn.Click += new System.EventHandler(cargarAliasMesa);

                gbxPendientes.Controls.Add(btn);
                x++;

                if (x == 10)
                {
                    x = 0;
                    y++;

                }  

             }
        }

        private void cargarAliasMesa(object sender, EventArgs e)
        {
            limpiarFactura();
            string alias = ((Button)sender).Name.Trim().ToUpper();
            FacturasPendientes pendiente= facturasPendientes.Where(x=>x.alias==alias).SingleOrDefault();
            lblAlias.Text = pendiente.alias;
          
            if (pendiente!=null)
            {

                foreach (var detalle in pendiente.detalleFacturaPendiente)
                {
                    tbDetalleDocumento detalleP = new tbDetalleDocumento();
                    detalleP.idTipoDoc = detalle.idTipoDoc;
                    detalleP.idProducto = detalle.idProducto;
                    detalleP.cantidad = detalle.cantidad;
                    detalleP.idDoc = detalle.idDoc;
                    detalleP.descuento = detalle.descuento;
                    detalleP.montoTotal = detalle.montoTotal;
                    detalleP.montoTotalDesc = detalle.montoTotalDesc;
                    detalleP.montoTotalExo = detalle.montoTotalExo;
                    detalleP.montoTotalImp = detalle.montoTotalImp;
                    detalleP.numLinea = detalle.numLinea;
                    detalleP.precio = detalle.precio;
                    detalleP.tbProducto = detalle.tbProducto;
                    detalleP.totalLinea = detalle.totalLinea;

                    listaDetalleDocumento.Add(detalleP);                  
                  
                }
                calcularMontosT();
                agregarProductoGrid();
                tabFact.Show();tabFact.Focus();
                isAlias = true;
            }



        }

        private void aliasPasarDatos(string alias)
        {
            if (alias!=null)
            {
                this.alias = alias;
            }
            else
            {
                alias = string.Empty;
            }         
        }

        private void frmFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro de cerrar el formulario? se PERDERÁN los documentos PENDIENTES!","Cerrar formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (listaDetalleDocumento.Count != 0 && txtTotal.Text != "0")
            {

                frmDividirCuenta form = new frmDividirCuenta();
                form.pasarDatosPendientes += pasarDatosPendientes;
                form.documentoTotal = crearDocumento();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay productos o el TOTAL a cobrar es 0.", "Pendiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pasarDatosPendientes(tbDocumento documento)
        {
            if (documento ==null)
            {
                if (lblAlias.Text!=string.Empty && isAlias)
                {
                    var fact = facturasPendientes.Where(x => x.alias == lblAlias.Text.Trim()).SingleOrDefault();
                    facturasPendientes.Remove(fact);
                    cargarPendientes();
                }
                limpiarFactura();
                MessageBox.Show("Se realizó el cobro total de la factura", "Cobro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listaDetalleDocumento = (List<tbDetalleDocumento>)documento.tbDetalleDocumento;
                //actualizar si esta pendiente
                agregarPendiente();
                cargarPendientes();

                calcularMontosT();
                agregarProductoGrid();

            }
        }

        private void btnProforma_Click(object sender, EventArgs e)
        {
            tipoDoc = (int)Enums.TipoDocumento.Proforma;
            dtgvDetalleFactura.EndEdit();
            calcularMontosT();
            agregarProductoGrid();
            if (listaDetalleDocumento.Count != 0 && txtTotal.Text != "0")
            {
                if (validarCampos())
                {

                    tbDocumento documento = crearDocumento();
                    documento.tipoDocumento = tipoDoc;
                    documento.reporteElectronic = false;
                    if (txtCorreo.Text != string.Empty)
                    {
                        documento.correo1 = txtCorreo.Text.Trim();
                    }

                    if (txtCorreo2.Text != string.Empty)
                    {
                        documento.correo2 = txtCorreo2.Text.Trim();
                    }
                    documento.notificarCorreo = chkEnviar.Checked;
                    frmProforma form = new frmProforma();
                    form.recuperarTotal += respuesta;
                    form.facturaGlobal = documento;
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No hay productos o el TOTAL a cobrar es 0.", "Cobrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProforma_Click(object sender, EventArgs e)
        {
            frmBusquedaProforma form = new frmBusquedaProforma();
            form.pasarDatosEvent += datosProforma;
            form.ShowDialog();
        }
        private void datosProforma(tbDocumento entity)
        {
            if (listaDetalleDocumento == null)
            {
                listaDetalleDocumento = new List<tbDetalleDocumento>();
            }
            listaDetalleDocumento.Clear();
            foreach (var item in entity.tbDetalleDocumento)
            {

                item.tbDocumento = null;


                listaDetalleDocumento.Add(item);
            }
            if (entity.tbClientes != null)
            {
                dataBuscar(entity.tbClientes);
            }

            calcularMontosT();
            agregarProductoGrid();
        }

        private void tabFact_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }


}
