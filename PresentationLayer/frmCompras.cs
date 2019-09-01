using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BussinessExceptions;
using EntityLayer;
using PresentationLayer.Reportes;
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
    public partial class frmCompras : Form
    {
        Bcliente clienteInst = new Bcliente();
        BImpuestos ImpIns = new BImpuestos();
        BProveedores proveedoresIns = new BProveedores();
        BProducto productoIns = new BProducto();
        bTipoMedidas medidaIns = new bTipoMedidas();
        BExoneraciones exoneraIns = new BExoneraciones();

        tbCompras compraGlobal;
        List<tbDetalleCompras> detalleDoc = new List<tbDetalleCompras>();
        tbProducto productoGlobal;
        tbReporteHacienda reporteGlobal;
        tbProveedores proveedorGlobal;

        BCompras comprasIns = new BCompras();
        BFacturacion facturacionIns = new BFacturacion();
        public frmCompras()
        {
            InitializeComponent();
        }
       

        private void CargarCombos()
        {     


            //tipopago
            cboTipoPago.DataSource = Enum.GetValues(typeof(Enums.TipoPago));
            //tipoveta
            cboTipoVenta.DataSource = Enum.GetValues(typeof(Enums.tipoVenta));
            //estadoFactura
            cboEstadoFactura.DataSource = Enum.GetValues(typeof(Enums.EstadoFactura));

            cboImpuesto.ValueMember = "id";
            cboImpuesto.DisplayMember = "valor";
            cboImpuesto.DataSource = ImpIns.getImpuestos((int)Enums.EstadoBusqueda.Activo);

            cboMedida.ValueMember = "idTipoMedida";
            cboMedida.DisplayMember = "nomenclatura";
            cboMedida.DataSource = medidaIns.getlistatipomedida();

        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            CargarCombos();
            limpiarForm();


        }

        private void cboTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboTipoVenta.SelectedValue==(int)Enums.tipoVenta.Credito)
            {
                mskPlazoCredito.Enabled = true;

            }
            else
            {
                mskPlazoCredito.Enabled = false;
                mskPlazoCredito.Text = string.Empty;
            }
        }


            

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {

                    tbDetalleCompras detalle = new tbDetalleCompras();
     
                    detalle.idProducto = txtCodigoProducto.Text.Trim();
                    detalle.nombreProducto = txtNombreProducto.Text.Trim().ToUpper();
                    detalle.idMedida = (int)cboMedida.SelectedValue;
                    detalle.precio = decimal.Parse(txtPrecioProducto.Text);
                    detalle.cantidad = decimal.Parse(txtCantidad.Text);
                    detalle.montoTotal = detalle.precio * detalle.cantidad;
                    

                    detalle.montoTotaDesc = decimal.Parse(txtDescuento.Text);
                    detalle.montoTotalImp = (((detalle.montoTotal - detalle.montoTotaDesc) * (1 + decimal.Parse(cboImpuesto.Text) / 100))) - (detalle.montoTotal - detalle.montoTotaDesc);
                  
                    detalle.montoTotalLinea = (detalle.montoTotal - detalle.montoTotaDesc) + detalle.montoTotalImp - detalle.montoTotalExo;

                    detalleDoc.Add(detalle);
                    actualizarListView();
                    resetProducto();
                    cargarTotales();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un error al agregar el producto","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cargarTotales()
        {

            decimal total = 0, desc = 0, iva = 0, subtotal = 0, exo = 0;

            foreach (tbDetalleCompras detalle in detalleDoc)
            {
                detalle.montoTotalLinea = (detalle.montoTotal - detalle.montoTotaDesc) + detalle.montoTotalImp;
                total += (decimal)detalle.montoTotalLinea;
                desc += (decimal)detalle.montoTotaDesc;
                iva += (decimal)detalle.montoTotalImp;     
                subtotal += (decimal)detalle.montoTotal;

            }
            txtSubtotal.Text=subtotal ==0?"0": subtotal.ToString("#.##");
            txtDescuentoTotal.Text = desc == 0 ? "0" : desc.ToString("#.##");
            txtIva.Text = iva == 0 ? "0" : iva.ToString("#.##");
            txtTotal.Text = total == 0 ? "0" : total.ToString("#.##");
            //txtExoneracion.Text = exo == 0 ? "0" : exo.ToString("#.##");
            
        }

        private void resetProducto()
        {
            txtCodigoProducto.ResetText();
            txtNombreProducto.ResetText();
            cboMedida.SelectedIndex = 0;
            txtPrecioProducto.ResetText();
            txtCantidad.ResetText();
            txtDescuento.ResetText();
            txtObservaciones.ResetText();

            cboImpuesto.SelectedIndex = 0;
        }

        private void actualizarListView()
        {
            lstvDocs.Items.Clear();
            foreach (tbDetalleCompras item in detalleDoc)
            {

                //Creamos un objeto de tipo ListviewItem
                ListViewItem linea = new ListViewItem();

                linea.Text= item.idProducto.Trim();
                linea.SubItems.Add(item.nombreProducto);
                linea.SubItems.Add(item.cantidad.ToString().Trim());
                linea.SubItems.Add(item.precio.ToString().Trim());
                linea.SubItems.Add(cboMedida.Text);
                linea.SubItems.Add(item.montoTotal.ToString().Trim());
                linea.SubItems.Add(item.montoTotaDesc.ToString().Trim());
                linea.SubItems.Add(item.montoTotalImp.ToString().Trim());
                linea.SubItems.Add(item.montoTotalExo.ToString().Trim());
                linea.SubItems.Add(item.montoTotalLinea.ToString().Trim());
                //Agregamos el item a la lista.
                lstvDocs.Items.Add(linea);
            }

        }

        private bool validarCampos()
        {
            if (txtCodigoProducto.Text == string.Empty)
            {
                txtCodigoProducto.Focus();
                MessageBox.Show("Debe indicar el código del producto", "Error de datos");
                return false;
            }

            if (detalleDoc.Where(x=>x.idProducto== txtCodigoProducto.Text).SingleOrDefault()!=null)
            {
                txtCodigoProducto.Focus();
                MessageBox.Show("El producto ya se encuentra en la lista.", "Error de datos");
                return false;
            }


            if (txtNombreProducto.Text == string.Empty)
            {
                txtNombreProducto.Focus();
                MessageBox.Show("Debe indicar el nombre del producto", "Error de datos");
                return false;
            }
            if (cboMedida.Text == string.Empty)
            {
                cboMedida.Focus();
                MessageBox.Show("No se indicó una medida del producto", "Error de datos");
                return false;
            }

            if (txtPrecioProducto.Text == string.Empty)
            {
                txtPrecioProducto.Focus();
                MessageBox.Show("Debe indicar el precio del producto", "Error de datos");
                return false;
            }
            if (txtCantidad.Text == string.Empty)
            {
                txtCantidad.Focus();
                MessageBox.Show("Debe indicar la cantidad del producto", "Error de datos");
                return false;
            }

            if (!Utility.isNumeroDecimal(txtPrecioProducto.Text))
            {
                txtPrecioProducto.Focus();
                MessageBox.Show("El precio indicado tiene formato incorrecto, no es númerico", "Error de datos");
                return false;
            }           

            if (txtDescuento.Text == string.Empty)
            {
                txtDescuento.Focus();
                MessageBox.Show("Debe indicar el descuento del producto", "Error de datos");
                return false;
            }
            if (cboImpuesto.Text == string.Empty)
            {
                cboImpuesto.Focus();
                MessageBox.Show("Debe indicar el impuesto del producto", "Error de datos");
                return false;
            }

            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        

        private bool validarCamposDoc()
        {
            if (txtIdFactura.Text == string.Empty)
            {
                txtIdFactura.Focus();
                MessageBox.Show("Debe indicar el #Factura", "Error de datos");
                return false;
            }

            if (proveedorGlobal== null)
            {
                txtProveedor.Focus();
                MessageBox.Show("Debe indicar el proveedor", "Error de datos");
                return false;
            }

            if (dtpFechaCompra.Value == null)
            {
                dtpFechaCompra.Focus();
                MessageBox.Show("Debe indicar la fecha de compra", "Error de datos");
                return false;
            }
            //if (dtpFechaReporte.Value == null)
            //{
            //    dtpFechaReporte.Focus();
            //    MessageBox.Show("Debe indicar la fecha de reporte", "Error de datos");
            //    return false;
            //}

            if (cboTipoVenta.Text == string.Empty)
            {
                cboTipoVenta.Focus();
                MessageBox.Show("Debe indicar el tipo de venta", "Error de datos");
                return false;
            }

            if ((int)cboTipoVenta.SelectedValue == (int)Enums.tipoVenta.Credito && mskPlazoCredito.Text==string.Empty)
            {
                mskPlazoCredito.Focus();
                MessageBox.Show("Debe indicar el plazo del crédito", "Error de datos");
                return false;
            }

            if (cboTipoPago.Text == string.Empty)
            {
                cboTipoPago.Focus();
                MessageBox.Show("Debe indicar el tipo de pago", "Error de datos");
                return false;
            }


            return true;
        }
        private tbCompras crearDocumento()
        {
            tbCompras documento = new tbCompras();

            documento.reportaInventario = chkIncluyeInventario.Checked;
            documento.reporteElectronico = chkRegimenSimplificado.Checked;
            documento.tipoDoc = (int)Enums.TipoDocumento.ComprasSimplificada;
            if (reporteGlobal!=null)
            {
                documento.idReporteHacienda = reporteGlobal.id;
                documento.reporteElectronico = false;
                documento.tipoDoc = (int)Enums.TipoDocumento.Compras;
            }
            documento.fecha= Utility.getDate();
            documento.numFactura = int.Parse(txtIdFactura.Text);
            documento.fechaCompra =dtpFechaCompra.Value.Date;
            documento.fechaReporte = Utility.getDate();
            documento.estadoCompra = (int)cboEstadoFactura.SelectedValue;
            documento.tipoPago = (int)cboTipoPago.SelectedValue;
            documento.tipoCompra = (int)cboTipoVenta.SelectedValue;     
            documento.tipoIdProveedor = proveedorGlobal.tipoId;
            documento.idProveedor = proveedorGlobal.id;
            
            documento.plazo = (int)documento.tipoCompra == (int)Enums.tipoVenta.Credito ? int.Parse(mskPlazoCredito.Text) : 0;

            documento.idEmpresa = Global.Usuario.tbEmpresa.id;
            documento.tipoIdEmpresa= Global.Usuario.tbEmpresa.tipoId;

            documento.observaciones = txtObservaciones.Text;
            documento.tipoMoneda = (int)Enums.TipoMoneda.CRC;       


            documento.tbDetalleCompras = detalleDoc;
            documento.estado = true;

            //Atributos de Auditoria

            documento.fecha_crea = Utility.getDate();
            documento.fecha_ult_mod = Utility.getDate();
            documento.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
            documento.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

            return documento;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBuscarProveedores buscarProve = new frmBuscarProveedores();
            buscarProve.pasarDatosEvent += datosProveedor;

            buscarProve.ShowDialog();
        }

        private void datosProveedor(tbProveedores proveedor)
        {
            if (proveedor != null)
            {
                proveedorGlobal = proveedor;
                if (proveedor.tipoId == (int)Enums.TipoId.Fisica)
                {
                    txtProveedor.Text = proveedor.id.Trim() + "-" + proveedor.tbPersona.nombre.Trim() + " "+ proveedor.tbPersona.apellido1.Trim() + " " + proveedor.tbPersona.apellido2.Trim();
                }
                else
                {
                    txtProveedor.Text = proveedor.id.Trim() + "-" + proveedor.tbPersona.nombre.Trim();
                }

            }
            else
            {
                MessageBox.Show("El proveedor del documento no se encuentra registrado en el sistema, Debe incluir el proveedor", "Error de datos");
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto buscarProduct = new frmBuscarProducto();
            buscarProduct.recuperarEntidad += datosProducto;

            buscarProduct.ShowDialog();
        }

        private void datosProducto(tbProducto producto)
        {
            if (producto != null)
            {
                productoGlobal = producto;
                txtCodigoProducto.Text = producto.idProducto;
                txtNombreProducto.Text = producto.nombre.Trim().ToUpper();
                cboMedida.SelectedValue = producto.idMedida;
               
            }
            else
            {
                txtCodigoProducto.Text = string.Empty;
                txtNombreProducto.Text = string.Empty;
                cboMedida.SelectedIndex = 0;
            }
        }

        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtCodigoProducto.Text != string.Empty)
                {
                    tbProducto pro = new tbProducto();
                    pro.idProducto = txtCodigoProducto.Text;
                    pro = productoIns.GetEntity(pro);
                    datosProducto(pro);
                }
            }
               
        }

        private void gbxDetalleCompra_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarReporteHacienda_Click(object sender, EventArgs e)
        {
            frmBuscarComprasHacienda form = new frmBuscarComprasHacienda();
            form.pasarDatosEvent += datosCompra;
            form.ShowDialog();
        }

        private void datosCompra(tbReporteHacienda compra)
        {
            if (compra!=null)
            {
                reporteGlobal = compra;
                chkRegimenSimplificado.Checked = false;
                chkRegimenSimplificado.Enabled = false;

                string consecutivo = compra.claveDocEmisor.Substring(21,20);
                string numFact = consecutivo.Substring(10, 10);
                txtIdFactura.Text = numFact.Trim();
                
                proveedorGlobal = proveedoresIns.getProveedorById(compra.idEmisor.Trim());
                datosProveedor(proveedorGlobal);

                dtpFechaCompra.Value = compra.fechaEmision;

                mskConsecutivo.Text = compra.consecutivoReceptor;
                mskClave.Text = compra.claveReceptor;

            }
        }

        private void txtIdFactura_TextChanged(object sender, EventArgs e)
        {
            if (txtIdFactura.Text==string.Empty)
            {
                limpiarForm();

            }
            if (reporteGlobal==null)
            {
                chkRegimenSimplificado.Enabled = true;
                chkRegimenSimplificado.Checked = true;
            }
        }
        public void limpiarForm()
        {
            txtIdFactura.ResetText();
            chkRegimenSimplificado.Enabled = true;
            chkRegimenSimplificado.Checked = true;
            reporteGlobal = null;
            proveedorGlobal = null;
            lstvDocs.Items.Clear();
            detalleDoc.Clear();

            cboEstadoFactura.SelectedItem = 0;
            cboTipoPago.SelectedIndex = 0;
            cboTipoVenta.SelectedIndex = 0;
            txtProveedor.Text = string.Empty;
            mskPlazoCredito.ResetText();
            
            dtpFechaCompra.Refresh();    

            mskConsecutivo.ResetText();
            mskClave.ResetText();
            resetProducto();
            txtDescuento.Text = "0";

            chkIncluyeInventario.Checked = false;
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (detalleDoc.Count != 0 && txtTotal.Text != "0")
                {
                    if (validarCamposDoc())
                    {

                        tbCompras documento = crearDocumento();

                        facturacionIns.guadarCompra(documento);
                        if (documento.tipoDoc==(int)Enums.TipoDocumento.ComprasSimplificada)
                        {
                            documento = facturacionIns.GetEntityCompra(documento);
                            reportarCompraSimplificadaHacienda(documento);
                        }
                        MessageBox.Show("La compras se ha guardado correctamente.", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarForm();
                        cargarTotales();
                    }

                }
                else
                {
                    MessageBox.Show("No hay productos o el TOTAL a cobrar es 0.", "Cobrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar la compra.","Compras",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void reportarCompraSimplificadaHacienda(tbCompras doc)
        {
            try
            {
                if (doc != null)
                {
                  
                    if (doc.reporteElectronico == true)
                    {
                        compraGlobal = doc;
                        if (Utility.AccesoInternet())
                        {

                            BackgroundWorker tarea = new BackgroundWorker();                     
                            tarea.DoWork += reportarCompraElectronica;
                            tarea.RunWorkerAsync();                         

                        }
                        else
                        {
                            MessageBox.Show("No hay acceso a internet", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }

                    }
             
                    limpiarForm();
                }
              
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void reportarCompraElectronica(object sender, DoWorkEventArgs e)
        {

            try
            {
                //envio la factura a hacienda
                compraGlobal = facturacionIns.CompraSimplificadaElectronica(compraGlobal);

                System.Threading.Thread.Sleep(3000);
                //consulto a hacienda el estado de la factura
                try
                {
                    string mensaje = facturacionIns.consultarCompraSimplificada(compraGlobal);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al consultar el estado del documento en Hacienda, valida el estado del documento", "Error al consultar el estado del documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txtPrecioProducto.Text);
            }
            catch (Exception)
            {

                txtPrecioProducto.ResetText();
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txtDescuento.Text);
            }
            catch (Exception)
            {

                txtDescuento.ResetText();
            }
        }       

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal.Parse(txtCantidad.Text);
            }
            catch (Exception)
            {

                txtCantidad.ResetText();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar el producto de la compra?", "Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result== DialogResult.Yes)
            {
             
                detalleDoc.Remove(detalleDoc.Where(x => x.idProducto == lstvDocs.SelectedItems[0].Text).SingleOrDefault());
                actualizarListView();
                resetProducto();
                cargarTotales();

            }

            
            
           
        }
    }
}
