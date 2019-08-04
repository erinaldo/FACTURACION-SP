using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BussinessExceptions;
using CrystalDecisions.Shared;
using PresentationLayer.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class frmDocumentosDetalle : Form
    {
        private tbDocumento _doc ;
        BFacturacion facturaIns = new BFacturacion();
        private string _razon = string.Empty;
        CorreoElectronico correoIns;

        public frmDocumentosDetalle()
        {
            InitializeComponent();
        }

        public frmDocumentosDetalle(tbDocumento doc)
        {
            InitializeComponent();
            _doc = doc;
        }

        private void frmFacturaDeshabilitada_Load(object sender, EventArgs e)
        {
            btnReImprimir.Visible = (bool)Global.Usuario.tbEmpresa.imprimeDoc;
            //btnCancelarFactura.Enabled = _doc.tipoDocumento == (int)Enums.TipoDocumento.FacturaElectronica ? true:false;
            if (_doc.estado==false)
            {
                btnCancelarFactura.Enabled = false;
                btnEnviarCorreo.Enabled = false;
            }

            lblTipoDoc.Text= Enum.GetName(typeof(Enums.TipoDocumento), _doc.tipoDocumento).ToUpper();
            cargarForm();
            cargarTotales();
        }

        private void cargarTotales()
        {
           
            decimal total = 0, desc = 0, iva = 0, subtotal = 0, exo = 0;

            foreach (tbDetalleDocumento detalle in _doc.tbDetalleDocumento)
            {
                detalle.totalLinea = (detalle.montoTotal - detalle.montoTotalDesc) + detalle.montoTotalImp;
                total += detalle.totalLinea;
                desc += detalle.montoTotalDesc;
                iva += detalle.montoTotalImp;
                exo += detalle.montoTotalExo;
                subtotal += detalle.montoTotal;

            }
             txtSubtotal.Text = subtotal.ToString("#.##");
            txtDescuento.Text = desc==0?"0": desc.ToString("#.##");
            txtIva.Text = iva == 0 ? "0" : iva.ToString("#.##");
            txtTotal.Text = total == 0 ? "0" : total.ToString("#.##");
            txtExoneracion.Text = exo == 0 ? "0" : exo.ToString("#.##");

        }

        private  void cargarForm()
        {
            txtIdFactura.Text = _doc.id.ToString().Trim();
            likClave.Text = _doc.clave==null?string.Empty: _doc.clave.ToString().Trim();
            txtConsecutivo.Text = _doc.consecutivo==null?string.Empty: _doc.consecutivo.ToString().Trim();
            txtFecha.Text = _doc.fecha.ToString().Trim();
            txtTipoPago.Text = _doc.tipoPago==null?string.Empty: Enum.GetName(typeof(Enums.TipoPago), _doc.tipoPago).ToUpper();
            txtTipoVenta.Text = _doc.tipoVenta == null ? string.Empty : Enum.GetName(typeof(Enums.tipoVenta), _doc.tipoVenta).ToUpper();
            txtEstado.Text =  Enum.GetName(typeof(Enums.Estado), _doc.estado).ToUpper();
            txtClaveRef.Text = _doc.claveRef;
            if (_doc.EstadoFacturaHacienda!=null)
            {
                txtEstadoHacienda.Text = _doc.EstadoFacturaHacienda.ToUpper().Trim();
            }
            else
            {
                txtEstadoHacienda.Text = "SIN ESTADO";
            }
            if (_doc.tipoDocumento==(int)Enums.TipoDocumento.FacturaElectronica)
            {
                txtObser.Text = _doc.observaciones;
            }
            else
            {
                txtObser.Text = _doc.razon;
            }
           
        
            if (_doc.tbClientes == null)
            {
                txtIdCliente.Text= "SIN CLIENTE";
                txtCliente.Text = "SIN CLIENTE";
                chkEnviar.Checked = false;
            }
            else if(_doc.tbClientes.tbPersona.tipoId == (int)Enums.TipoId.Fisica)
            {
                txtIdCliente.Text = _doc.tbClientes.tbPersona.identificacion.ToString().Trim();
                txtCliente.Text = _doc.tbClientes.tbPersona.nombre.ToUpper().ToString().Trim()+" "+
                   _doc.tbClientes.tbPersona.apellido1.ToUpper().ToString().Trim()+" "+ _doc.tbClientes.tbPersona.apellido2.ToUpper().ToString().Trim();
            }
            else
            {
                txtIdCliente.Text = _doc.tbClientes.tbPersona.identificacion.ToString().Trim();
                txtCliente.Text = _doc.tbClientes.tbPersona.nombre.ToUpper().ToString().Trim();
            }
            if (_doc.tbClientes !=null)
            {
                txtTel.Text = _doc.tbClientes.tbPersona.telefono.ToString().Trim();

                txtCorreo.Text = _doc.correo1 == null ? _doc.tbClientes.tbPersona.correoElectronico.Trim() : _doc.correo1.ToString().Trim();


                txtCorreo2.Text = _doc.correo2 == null ? string.Empty : _doc.correo2.ToString().Trim();
            }

            
            lsvFacturas.Items.Clear();
            foreach (tbDetalleDocumento item in _doc.tbDetalleDocumento)
            {

                //Creamos un objeto de tipo ListviewItem
                ListViewItem linea = new ListViewItem();

                linea.Text = item.tbProducto.nombre.ToString().ToUpper().Trim();
                linea.SubItems.Add(item.precio.ToString().Trim());
                linea.SubItems.Add(item.cantidad.ToString().Trim());
                linea.SubItems.Add(item.montoTotal.ToString().Trim());
                linea.SubItems.Add(item.montoTotalDesc.ToString().Trim());
                linea.SubItems.Add(item.montoTotalImp.ToString().Trim());
                linea.SubItems.Add(item.montoTotalExo.ToString().Trim());
                linea.SubItems.Add(item.totalLinea.ToString().Trim());
                //Agregamos el item a la lista.
                lsvFacturas.Items.Add(linea);
            }
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            try
            {
                DialogResult result = MessageBox.Show("Se generará una NOTA DE CREDITO, para anular la factura seleccionada, Desea continuar?", "Anulación de factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (chkEnviar.Checked)
                    {

                        bandera = validarCampos();

                    }
                    if (bandera)
                    {
                        _doc.correo1 = txtCorreo.Text.Trim();
                        if (txtCorreo2.Text != String.Empty)
                        {
                            _doc.correo1 = txtCorreo2.Text.Trim();
                        }
                        frmRazon razon = new frmRazon();
                        razon.pasarDatosEvent += dataBuscar;
                        razon.ShowDialog();
                        if (_razon != string.Empty)
                        {
                            var doc = eliminarFactura();
                            _doc = doc;
                            if (doc != null & doc.reporteElectronic == true)
                            {
                                // BackgroundWorker tarea = new BackgroundWorker();

                                //tarea.DoWork += reportarFacturacionElectronica;
                                // tarea.RunWorkerAsync();
                                reportarFacturacionElectronica();

                            }
                        }

                    }

                }
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar la factura, intente más tarde, no se generó la NOTA DE CRÉDITO", "Error al eliminar el documento", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void reportarFacturacionElectronica()
        {
            if (Utility.AccesoInternet())
            {
              try
                    {
                        _doc = facturaIns.FacturarElectronicamente(_doc);

                        System.Threading.Thread.Sleep(3000);

                        facturaIns.consultarFacturaElectronicaPorClave(_doc.clave);

                        if (chkEnviar.Checked)
                        {
                            List<string> correos = new List<string>();
                   

                            if (_doc.correo1 != null)
                            {
                                correos.Add(_doc.correo1);

                            }

                            if (_doc.correo2 != null)
                            {
                                correos.Add(_doc.correo2);

                            }


                            enviarCorreo(_doc, correos);
                    
                        }
              
               


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("No se pudo emitir el documento NOTA CREDITO", "Error al procesar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }
            else
            {
                MessageBox.Show("No hay acceso a internet, No se enviará el documento a Hacienda, validar en la pantalla de validación, para su envio correspodiente.","Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        private void dataBuscar(string razon)
        {
            _razon = razon;
        }

        private tbDocumento eliminarFactura()
        {
            try
            {
                tbDocumento notaCredito = new tbDocumento();

                notaCredito.correo1 = _doc.correo1;
                notaCredito.correo2 = _doc.correo2;
                notaCredito.estado = true;
                notaCredito.estadoFactura = (int)Enums.EstadoFactura.Cancelada;
                notaCredito.fecha = Utility.getDate();
                notaCredito.fecha_crea = Utility.getDate();
                notaCredito.fecha_ult_mod = Utility.getDate();
                notaCredito.idCliente = _doc.idCliente;
                notaCredito.reporteAceptaHacienda = false;
                notaCredito.idEmpresa = _doc.idEmpresa;
                notaCredito.reporteElectronic = _doc.reporteElectronic;
                notaCredito.tipoVenta = _doc.tipoVenta;
                notaCredito.tipoPago = _doc.tipoPago;
                notaCredito.tipoMoneda = _doc.tipoMoneda;
                notaCredito.tipoCambio =(int) _doc.tipoCambio;

          



                notaCredito.tipoDocumento = (int)Enums.TipoDocumento.NotaCreditoElectronica;
                notaCredito.tipoIdCliente = _doc.tipoIdCliente;
                notaCredito.tipoIdEmpresa = _doc.tipoIdEmpresa;
                notaCredito.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper(); 
                notaCredito.usuario_ult_mod=Global.Usuario.nombreUsuario.Trim().ToUpper();

                //datos de nota de credito
                notaCredito.tipoDocRef = _doc.tipoDocumento;
                notaCredito.claveRef = _doc.clave;
                notaCredito.fechaRef = _doc.fecha;
                notaCredito.codigoRef = (int)Enums.TipoRef.AnulaDocumentoReferencia;             
                notaCredito.razon = _razon;
                notaCredito.observaciones = _razon;
                
                List<tbDetalleDocumento> lista= new List<tbDetalleDocumento>();
                foreach (var item in _doc.tbDetalleDocumento)
                {
                    tbDetalleDocumento detalle = new tbDetalleDocumento();
                    detalle.cantidad = item.cantidad;
                    detalle.descuento = item.descuento;
                    detalle.idProducto = item.idProducto;
                    detalle.montoTotal = item.montoTotal;
                    detalle.montoTotalDesc = item.montoTotalDesc;
                    detalle.montoTotalExo = item.montoTotalExo;
                    detalle.montoTotalImp = item.montoTotalImp;
                    detalle.numLinea = item.numLinea;
                    detalle.precio = item.precio;
                    detalle.totalLinea = item.totalLinea;
                    lista.Add(detalle);

                }
                notaCredito.tbDetalleDocumento = lista;
                notaCredito=facturaIns.guadar(notaCredito);
                return notaCredito;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (Utility.AccesoInternet())
            {
                DialogResult result = MessageBox.Show("Se enviará por correo electrónico la factura seleccionada, Desea continuar?", "Envio de correo electrónico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (validarCampos())
                    {
                        List<string> correos = new List<string>();
                        correos.Add(txtCorreo.Text.Trim());
                       
                        if (txtCorreo2.Text != String.Empty)
                        {
                            correos.Add(txtCorreo2.Text.Trim());
          
                        }
                        enviarCorreo(_doc, correos);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay acceso a internet", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }

        private void enviarCorreo(tbDocumento doc, List<string>correos)
        {
            try
            {
                bool enviado = false;
                //se solicita respuesta, y se confecciona el correo a enviar
             
                CorreoElectronico correo = new CorreoElectronico(doc,correos ,true);
                enviado = correo.enviarCorreo();

                if (enviado)
                {
                    MessageBox.Show("Se envió correctamente el correo electrónico", "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Se produjo un error al enviar el Correo Electrónico", "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
         
            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un error al enviar el Correo Electrónico","Correo Electrónico",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
        }

        private bool validarCampos()
        {
            bool ok= true;
            if(txtCorreo.Text==string.Empty && txtCorreo2.Text == string.Empty)
            {

                MessageBox.Show("Falta indicar al menos 1 correo electrónico para enviar la factura", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCorreo.Focus();
                return false;
            }
            if (txtCorreo.Text != string.Empty)
            {
                if (!Utility.isValidEmail(txtCorreo.Text))
                {

                    MessageBox.Show("El formato de los correo es incorrecto, favor verificar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCorreo.Focus();
                    return false;
                }
            }
            if (txtCorreo2.Text != string.Empty)
            {
                if (!Utility.isValidEmail(txtCorreo2.Text))
                {

                    MessageBox.Show("El formato de los correo es incorrecto, favor verificar", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtCorreo2.Focus();
                    return false;
                }
            }
         
            return ok;
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {

           DialogResult dialogResult=  MessageBox.Show("Desea imprimir el documento?","Imprimir",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult== DialogResult.Yes)
            {

                if (_doc != null)
                {
                    _doc = facturaIns.getEntity(_doc, true);
                    clsImpresionFactura imprimir = new clsImpresionFactura(_doc, Global.Usuario.tbEmpresa);
                    imprimir.print();

                }
                else
                {
                    MessageBox.Show("No hay datos que imprimir", "Imprimir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void likClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConsultaFacturaElectronica consulta = new frmConsultaFacturaElectronica();
            consulta.clave = likClave.Text;
            consulta.ShowDialog();
        }
    }
}
