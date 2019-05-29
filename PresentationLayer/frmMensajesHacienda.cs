using BusinessLayer;
using CommonLayer;
using PresentationLayer.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class frmMensajesHacienda : Form
    {
        List<tbReporteHacienda> listaRespHacienda = new List<tbReporteHacienda>();
        BFacturacion facturaIns = new BFacturacion();

        public frmMensajesHacienda()
        {
            InitializeComponent();
        }

        private void frmMensajesHacienda_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();



            cboEstado.DataSource = Enum.GetValues(typeof(Enums.Mensajes));


        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter ="All files (*.XML)|*.XML";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Archivos XML de compras";
        }
      
        private void cargarLista() {

            lsvDoc.Items.Clear();
            foreach (var resp in listaRespHacienda)
            {

                ListViewItem item = new ListViewItem();

                item.Text = resp.claveDocEmisor;

                item.SubItems.Add(resp.idEmisor);
                item.SubItems.Add(resp.nombreEmisor);
                item.SubItems.Add(resp.fechaEmision.ToString());
                item.SubItems.Add(resp.totalImp.ToString());
                item.SubItems.Add(resp.totalFactura.ToString());
                item.SubItems.Add(Enum.GetName(typeof(Enums.EstadoRespuestaHacienda), resp.estadoRecibido));
           
                lsvDoc.Items.Add(item);

            }

        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            //lsvDoc.Items.Clear();
            limpiar();
            listaRespHacienda.Clear();
            txtMensaje.Text = string.Empty;
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Read the files
                foreach (String file in openFileDialog1.FileNames)
                 
                {
                    // Create a PictureBox.
                    try
                    {
                        /////
                        ///
                        if (File.Exists(file))
                        {

                           
                            XmlDocument xDoc = new XmlDocument();
                            xDoc.Load(file);
                           
                            var fecha = xDoc.GetElementsByTagName("FechaEmision").Item(0).InnerText;
                            var emisor=xDoc.GetElementsByTagName("Emisor");
                            var identificacion = ((XmlElement)emisor[0]).GetElementsByTagName("Identificacion");
                            var nombreEmisor= ((XmlElement)emisor[0]).GetElementsByTagName("Nombre").Item(0).InnerText;
                            var correo = ((XmlElement)emisor[0]).GetElementsByTagName("CorreoElectronico").Item(0).InnerText;

                            var numeroId = ((XmlElement)identificacion[0]).GetElementsByTagName("Numero").Item(0).InnerText;
                            var tipoId = ((XmlElement)identificacion[0]).GetElementsByTagName("Tipo").Item(0).InnerText;

                            var total = xDoc.GetElementsByTagName("ResumenFactura");
                            var imp = ((XmlElement)total[0]).GetElementsByTagName("TotalImpuesto").Item(0).InnerText;
                            var totalComprobante = ((XmlElement)total[0]).GetElementsByTagName("TotalComprobante").Item(0).InnerText;

                            

                            tbReporteHacienda resp = new tbReporteHacienda();
                            resp.fecha = Utility.getDate();
                            resp.claveDocEmisor = xDoc.GetElementsByTagName("Clave").Item(0).InnerText;
                            resp.idEmisor = numeroId;
                            resp.nombreEmisor = nombreEmisor;
                            resp.tipoIdEmisor = int.Parse(tipoId);
                            resp.fechaEmision =  DateTime.Parse( fecha);
                            resp.totalImp = decimal.Parse(imp);
                            resp.totalFactura = decimal.Parse(totalComprobante);
                            resp.correoElectronico = correo;
                            //por defecto se indica como aceptado
                            resp.estadoRecibido = 1;

                            resp.mensajeRespHacienda = false;
                            resp.reporteAceptaHacienda = false;

                            resp.fecha_crea = Utility.getDate();
                            resp.fecha_ult_mod = Utility.getDate();
                            resp.usuario_crea = Global.Usuario.nombreUsuario;
                            resp.usuario_ult_mod = Global.Usuario.nombreUsuario;

                            resp.idEmpresa= Global.Usuario.tbEmpresa.id;
                            resp.tipoIdEmpresa = Global.Usuario.tbEmpresa.tipoId;
                            resp.nombreArchivo = file.Substring(file.LastIndexOf('\\'));


                            listaRespHacienda.Add(resp);
              



                        }

                    }
                    
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("El documento seleccionado no tiene el formato requerido. " + file.Substring(file.LastIndexOf('\\'))
                           );
                    }
                }

                cargarLista();
            }
        }

        private bool validarDatos()
        {

            foreach (var item in listaRespHacienda)
            {
                if (item.estadoRecibido != (int)Enums.Mensajes.Aceptado)
                {
                    if (item.razon.Trim()==string.Empty)
                    {

                        MessageBox.Show($"Debe indicar una razón para el documento #{item.claveDocEmisor}, Emisor: {item.nombreEmisor}, ya que se encuentra en estado: {Enum.GetName(typeof(Enums.EstadoRespuestaHacienda), item.estadoRecibido).ToUpper()} ","Datos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return false;

                    }
                   

                }
            }

            return true;
        }



        private void limpiar() {
            txtClave.Text = string.Empty;
            txtID.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtEmisor.Text = string.Empty;

            cboEstado.SelectedIndex = 0;

            txtImp.Text = string.Empty;
            txtTotal.Text = string.Empty;
  

        }
        private void lsvDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboEstado.SelectedValue==1)
            {
                txtRazon.Enabled = false;
                txtRazon.Text = string.Empty;

            }
            else
            {

                foreach (var item in listaRespHacienda)
                {
                    if (item.claveDocEmisor.Trim() == txtClave.Text.Trim())
                    {
                        txtRazon.Text = item.razon;
                        break;

                    }
                }
                txtRazon.Enabled = true;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if ((int)cboEstado.SelectedValue != (int)Enums.Mensajes.Aceptado && txtRazon.Text.Trim()==string.Empty)
            {
                MessageBox.Show($"Debe indicar una razón para el documento #{txtClave.Text}, Emisor:{txtEmisor.Text}, Estado:{cboEstado.Text} ", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                foreach (var item in listaRespHacienda)
                {
                    if (item.claveDocEmisor.Trim() == txtClave.Text.Trim())
                    {
                        item.estadoRecibido = (int)cboEstado.SelectedValue;
                        item.razon = txtRazon.Text.Trim().ToUpper();
                        break;

                    }
                }
                MessageBox.Show("Datos actualizados correctamente", "Actulización de datos",MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarLista();
                limpiar();


            }

        }

        private void lsvDoc_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lsvDoc.SelectedItems.Count > 0)
                {
                    txtClave.Text = lsvDoc.SelectedItems[0].Text;
                    txtID.Text = lsvDoc.SelectedItems[0].SubItems[1].Text;
                    txtFecha.Text = lsvDoc.SelectedItems[0].SubItems[3].Text;
                    txtEmisor.Text = lsvDoc.SelectedItems[0].SubItems[2].Text;

                    cboEstado.SelectedItem = lsvDoc.SelectedItems[0].SubItems[6].Text;

                    txtImp.Text = lsvDoc.SelectedItems[0].SubItems[4].Text;
                    txtTotal.Text = lsvDoc.SelectedItems[0].SubItems[5].Text;

                    foreach (var item in listaRespHacienda)
                    {
                        if (item.claveDocEmisor.Trim() == txtClave.Text.Trim())
                        {

                            if (item.estadoRecibido != (int)Enums.Mensajes.Aceptado)
                            {
                                txtRazon.Text = item.razon;
                                txtRazon.Enabled = true;

                            }
                            else
                            {
                                txtRazon.Text = string.Empty;
                                txtRazon.Enabled = false;
                            }
                            cboEstado.ResetText();
                            cboEstado.SelectedText = Enum.GetName(typeof(Enums.EstadoRespuestaHacienda), item.estadoRecibido);

                            break;
                        }

                    }

                }
            }
            catch (LicenseException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resul = MessageBox.Show("Favor revisar los estados en la lista de los documentos, deacuerdo a los cambios realizados si fuese el caso.  ¿Desea enviar los documentos?","Envio mensajes Hacienda",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (resul==DialogResult.OK)
                {

                    txtMensaje.Text = facturaIns.envioMensaje(listaRespHacienda);

                 //   enviarCorreo(lista);
                   // MessageBox.Show(mensaje, "Procesados...", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                    lsvDoc.Items.Clear();
                    limpiar();
                    MessageBox.Show("Se han procesados los archivos, en segundo plano se enviarán los correos electrónicos", "Archivos procesados.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BackgroundWorker tarea = new BackgroundWorker();
          
                    tarea.DoWork += reportarFacturacionElectronica;
                    tarea.RunWorkerAsync();
                





                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrió un error al procesar los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void reportarFacturacionElectronica(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<tbReporteHacienda> lista = new List<tbReporteHacienda>();
                lista = listaRespHacienda;
                facturaIns.reportarMensajesHacienda(lista);
    
 
       
                enviarCorreo(lista);

            }
            catch (Exception)
            {

                throw;
            }
        

        }

        private void enviarCorreo(List<tbReporteHacienda> lista)
        {
            try
            {
                bool enviado = false;
                foreach (var item in lista)
                {
                    List<string> correos = new List<string>();


                    if (item.correoElectronico != null)
                    {
                        correos.Add(item.correoElectronico.Trim());

                    }

                    CorreoElectronico correo = new CorreoElectronico(item, correos, true);
                    enviado = correo.enviarCorreo();
                }
                MessageBox.Show("Se han enviado los correos electrónicos.", "Envio de correos electrónicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo enviar los correos, favor de verificar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
