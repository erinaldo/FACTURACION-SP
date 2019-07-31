using CommonLayer;
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
    public partial class frmDividirCuenta : Form
    {

        bool respuestaAprobaDesc = false;
        decimal porcDesc = 0;
        int tipoDoc = 1;
        List<tbDetalleDocumento> detalleDocumentoParcial = new List<tbDetalleDocumento>();
        public tbDocumento documentoTotal { get; set; }
        public frmDividirCuenta()
        {
            InitializeComponent();
        }

        private void frmDividirCuenta_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaTotal();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }

        private void cargarListaTotal()
        {
            lstvTotal.Items.Clear();
            foreach (var detalle in documentoTotal.tbDetalleDocumento)
            {
                for (int i = 0; i < detalle.cantidad; i++)
                {
                    ListViewItem item = new ListViewItem();
                    // Place a check mark next to the item.
                    item.Checked = false;
                    item.SubItems.Add(detalle.idProducto);
                    item.SubItems.Add(detalle.tbProducto.nombre.Trim().ToUpper());
                    item.SubItems.Add(detalle.precio.ToString());
                    lstvTotal.Items.Add(item);
                }
            }
        }


        private void refrescarListas()
        {
            detalleDocumentoParcial = calcularMontosT(detalleDocumentoParcial);
            cargarListaParcial();
            cargarListaTotal();

        }

        private void cargarListaParcial()
        {
            lstvListaParcial.Items.Clear();
            foreach (var detalle in detalleDocumentoParcial)
            {

                ListViewItem item = new ListViewItem();
                // Place a check mark next to the item.
                item.Checked = false;
                item.SubItems.Add(detalle.idProducto);
                item.SubItems.Add(detalle.tbProducto.nombre.Trim().ToUpper());
                item.SubItems.Add(detalle.cantidad.ToString().Trim());
                item.SubItems.Add(detalle.precio.ToString());
                lstvListaParcial.Items.Add(item);

            }
        }

        private void lstvTotal_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (e.Item.Checked)
                {
                    string prod = e.Item.SubItems[1].Text;
                    var detalle = documentoTotal.tbDetalleDocumento.Where(a => a.idProducto == prod.Trim()).SingleOrDefault();
                    documentoTotal.tbDetalleDocumento.Where(b => b.idProducto == prod.Trim()).SingleOrDefault().cantidad = documentoTotal.tbDetalleDocumento.Where(c => c.idProducto == prod.Trim()).SingleOrDefault().cantidad - 1;

                    var x = detalleDocumentoParcial.Where(v => v.idProducto == prod.Trim()).SingleOrDefault();
                    if (x == null)
                    {
                        tbDetalleDocumento detalleParcial = new tbDetalleDocumento();
                        detalleParcial.cantidad = 1;
                        detalleParcial.idProducto = detalle.idProducto;
                        detalleParcial.precio = detalle.precio;
                        detalleParcial.montoTotal = detalleParcial.cantidad * detalleParcial.precio;

                        detalleParcial.tbProducto = detalle.tbProducto;
                        detalleDocumentoParcial.Add(detalleParcial);
                    }
                    else
                    {
                        detalleDocumentoParcial.Where(c => c.idProducto == prod.Trim()).SingleOrDefault().cantidad++;
                        detalleDocumentoParcial.Where(c => c.idProducto == prod.Trim()).SingleOrDefault().montoTotal = detalleDocumentoParcial.Where(y => y.idProducto == prod.Trim()).SingleOrDefault().cantidad *
                            detalleDocumentoParcial.Where(f => f.idProducto == prod.Trim()).SingleOrDefault().precio;
                    }



                    refrescarListas();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void lstvListaParcial_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (e.Item.Checked)
                {
                    string prod = e.Item.SubItems[1].Text;
                    var detalle = documentoTotal.tbDetalleDocumento.Where(x => x.idProducto == prod.Trim()).SingleOrDefault();
                    documentoTotal.tbDetalleDocumento.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad = documentoTotal.tbDetalleDocumento.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad + 1;

                    detalleDocumentoParcial.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad--;
                    detalleDocumentoParcial.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().montoTotal = detalleDocumentoParcial.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad * detalleDocumentoParcial.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().precio;

                    if (detalleDocumentoParcial.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad == 0)
                    {
                        detalleDocumentoParcial.Remove(detalleDocumentoParcial.Where(x => x.idProducto == prod.Trim()).SingleOrDefault());
                    }
                    detalleDocumentoParcial.Remove(detalle);
                    refrescarListas();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }

        }



        private List<tbDetalleDocumento> calcularMontosT(List<tbDetalleDocumento> lista)
        {
            lista = asignarLineasNumero(lista);
            lista = calcularDescuentos(lista);
            lista = calcularImpuestos(lista);
            lista = calcularTotales(lista);
            return lista;
        }

        private List<tbDetalleDocumento> asignarLineasNumero(List<tbDetalleDocumento> lista)
        {
            int linea = 0;
            foreach (tbDetalleDocumento det in lista)
            {
                linea++;
                det.numLinea = linea;
            }
            return lista;

        }

        private List<tbDetalleDocumento> calcularTotales(List<tbDetalleDocumento> lista)
        {
            decimal total = 0, desc = 0, iva = 0, subtotal = 0, exo = 0;

            foreach (tbDetalleDocumento detalle in lista)
            {
                detalle.totalLinea = (detalle.montoTotal - detalle.montoTotalDesc) + detalle.montoTotalImp;
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
            return lista;
        }

        private List<tbDetalleDocumento> calcularImpuestos(List<tbDetalleDocumento> lista)
        {

            foreach (tbDetalleDocumento detalle in lista)
            {
                //sino es excento el producto
                if (!detalle.tbProducto.esExento)
                {
                    //aplica exoneracion al cliente
                    if (false)
                    {
                        detalle.montoTotalExo = (detalle.montoTotal - detalle.montoTotalDesc) * (((decimal)detalle.tbProducto.tbImpuestos.valor) / 100);
                        detalle.montoTotalImp = 0;
                    }
                    else
                    {
                        //aplica el impuesto
                        detalle.montoTotalExo = 0;
                        detalle.montoTotalImp = (detalle.montoTotal - detalle.montoTotalDesc) * (((decimal)detalle.tbProducto.tbImpuestos.valor) / 100);
                    }

                }
                else
                {//no aplica impuesto ya que el producto es excento.
                    detalle.montoTotalImp = 0;
                    detalle.montoTotalExo = 0;

                }

            }
            return lista;

        }

        private List<tbDetalleDocumento> calcularDescuentos(List<tbDetalleDocumento> lista)
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

                foreach (tbDetalleDocumento detalle in lista)
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
                lista = calcularMontosT(lista);
            }
            respuestaAprobaDesc = false;
            return lista;

        }

        private void respuestaAprobacion(bool aprob)
        {
            respuestaAprobaDesc = aprob;
            porcDesc = decimal.Parse(txtPorcetaje.Text.Trim());
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

                    detalleDocumentoParcial = calcularMontosT(detalleDocumentoParcial);
                }
                catch (Exception)
                {


                    MessageBox.Show("Se produjo un error al ingresar el producto, corrija los datos", "Calcular descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            tipoDoc = (int)Enums.TipoDocumento.FacturaElectronica;



            if (detalleDocumentoParcial.Count != 0 && txtTotal.Text != "0")
            {


                tbDocumento documento = crearDocumento();
                frmCobrar form = new frmCobrar();
                // form.recuperarTotal += respuesta;
                form.facturaGlobal = documento;
                form.ShowDialog();

            }
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
            // documento.observaciones = txtObservaciones.Text.ToUpper().Trim();
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
            //if (clienteGlo != null)
            //{
            //    documento.idCliente = clienteGlo.id;
            //    documento.tipoIdCliente = clienteGlo.tipoId;
            //    //asigna el valor que tenga el cliente si es contribuyente o no

            //    documento.tbClientes = clienteGlo;
            //}

            //documento.estado = true;

            //foreach (tbDetalleDocumento detalle in listaDetalleDocumento)
            //{
            //    detalle.tbProducto = null;
            //}

            //documento.tbDetalleDocumento = listaDetalleDocumento;

            //Atributos de Auditoria

            documento.fecha_crea = Utility.getDate();
            documento.fecha_ult_mod = Utility.getDate();
            documento.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
            documento.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

            return documento;
        }
    }
}