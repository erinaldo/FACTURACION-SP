using CommonLayer;
using CommonLayer.Exceptions.BussinessExceptions;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace PresentationLayer.Reportes
{
    public class CorreoElectronico
    {

        private tbDocumento _doc { get; set; }
        private tbReporteHacienda _msj { get; set; }
        private int _tipoCorreo { get; set; }

        private List<string> _adjuntos;
        private string _envioCorreo { get; set; }
        private List<string> _destinoCorreo { get; set; }
        private string _mensaje { get; set; }
        private string _subject { get; set; }
        private string _contrasena { get; set; }
        private bool _cargarAdjuntos { get; set; }

        public CorreoElectronico(tbDocumento doc,List<string>correoDestino,bool cargarAdjuntos)
        {
            _tipoCorreo = 1;
             _doc = doc;
            _cargarAdjuntos = cargarAdjuntos;
            _destinoCorreo= correoDestino;

        }
   

        public CorreoElectronico(tbReporteHacienda msj, List<string> correoDestino, bool cargarAdjuntos)
        {

            _tipoCorreo = 2;
            _msj = msj;
            _cargarAdjuntos = cargarAdjuntos;
            _destinoCorreo = correoDestino;

        }



        public bool enviarCorreo()
        {

            bool enviado = false;

            try
            {

                _envioCorreo = Global.Usuario.tbEmpresa.correoElectronicoEmpresa.Trim();
                _contrasena = Global.Usuario.tbEmpresa.contrasenaCorreo.Trim();
                _mensaje = Global.Usuario.tbEmpresa.cuerpoCorreo.Trim();
                _subject = Global.Usuario.tbEmpresa.subjectCorreo.Trim();

                _adjuntos = generarAdjuntos();


               
   

                enviado = enviar();

            }
            catch (Exception ex)
            {

                return false;
            }



            return enviado;

        }

        private List<string> generarAdjuntos()
        {
            List<string> adjuntos = new List<string>();
            try
            {


                if (_cargarAdjuntos)
                {
                    if (_tipoCorreo==1)
                    {
                        if (_doc.tipoDocumento!=(int)Enums.TipoDocumento.FacturaElectronica)
                        {
                            _subject = Enum.GetName(typeof(Enums.TipoDocumento), _doc.tipoDocumento).ToUpper() + ". "+_subject;

                        }
                        
                        string directorio = Global.Usuario.tbEmpresa.rutaCertificado.Trim();
                        string nombreArchivo = _doc.consecutivo;
                        string tipoDoc = Utility.getPrefixTypeDoc(_doc.tipoDocumento);
                        XmlDocument xml;
                        string pdfFactura = generarPDF();
                        if (pdfFactura != string.Empty)
                        {
                            adjuntos.Add(pdfFactura);
                        }
                        if (_doc.tipoDocumento != (int)Enums.TipoDocumento.Proforma)
                        {

                            if (_doc.xmlFirmado != null)
                            {
                                xml = Utility.DecodeBase64ToXML(_doc.xmlFirmado);
                                string archivo = (directorio + (nombreArchivo + tipoDoc + "_02_Firmado.xml"));
                                if (!File.Exists(archivo))
                                {
                                    xml.Save((directorio + (nombreArchivo + tipoDoc + "_02_Firmado.xml")));
                                    XmlTextWriter xmlTextWriter = new XmlTextWriter((directorio + (nombreArchivo + tipoDoc + "_02_Firmado.xml")), new System.Text.UTF8Encoding(false));
                                    xml.WriteTo(xmlTextWriter);
                                    xmlTextWriter.Close();

                                }

                                adjuntos.Add(archivo);
                            }

                            if (_doc.xmlRespuesta != null)
                            {
                                xml = Utility.DecodeBase64ToXML(_doc.xmlRespuesta);
                                string archivo = (directorio + (nombreArchivo + tipoDoc + "_05_RESP.xml"));
                                if (!File.Exists(archivo))
                                {
                                    xml.Save((directorio + (nombreArchivo + tipoDoc + "_05_RESP.xml")));
                                    XmlTextWriter xmlTextWriter = new XmlTextWriter((directorio + (nombreArchivo + tipoDoc + "_05_RESP.xml")), new System.Text.UTF8Encoding(false));
                                    xml.WriteTo(xmlTextWriter);
                                    xmlTextWriter.Close();

                                }

                                adjuntos.Add(archivo);

                            }

                        }



                    }
                    //adjuntos mensajes
                    else
                    {
                        string directorio = Global.Usuario.tbEmpresa.rutaCertificado.Trim() + Global.Usuario.tbEmpresa.rutaXMLCompras.Trim();
                        string nombreArchivo = _msj.consecutivoReceptor;
                        string tipoDoc = "_MS";
                        string reporte = _msj.estadoRecibido == (int)Enums.EstadoRespuestaHacienda.Aceptado ? Enum.GetName(typeof(Enums.EstadoRespuestaHacienda), _msj.estadoRecibido).ToUpper() : Enum.GetName(typeof(Enums.EstadoRespuestaHacienda), _msj.estadoRecibido).ToUpper()+". Razón:"+_msj.razon.Trim().ToUpper() + ".Favor de emitir la respectiva NOTA DE CRÉDITO con su respectiva corrección. ";
                        _mensaje = $"Se ha procesado el documento Clave: {_msj.claveDocEmisor}, con el Monto:{_msj.totalFactura} e impuestos:{_msj.totalImp}. Se ha reportado en un estado: {reporte}. Gracias.";
                        _subject = $"Acuse documento recibido CLAVE:{_msj.claveDocEmisor}. " + _subject;
                        XmlDocument xml;
                        if (_msj.xmlFirmado != null)
                        {
                            xml = Utility.DecodeBase64ToXML(_msj.xmlFirmado);
                            string archivo = (directorio + (nombreArchivo + tipoDoc + "_02_Firmado.xml"));
                            if (!File.Exists(archivo))
                            {
                                xml.Save((directorio + (nombreArchivo + tipoDoc + "_02_Firmado.xml")));
                                XmlTextWriter xmlTextWriter = new XmlTextWriter((directorio + (nombreArchivo + tipoDoc + "_02_Firmado.xml")), new System.Text.UTF8Encoding(false));
                                xml.WriteTo(xmlTextWriter);
                                xmlTextWriter.Dispose();

                            }

                            adjuntos.Add(archivo);
                        }

                        if (_msj.xmlRespuesta != null)
                        {                      


                            xml = Utility.DecodeBase64ToXML(_msj.xmlRespuesta);
                            string archivo = (directorio + (nombreArchivo + tipoDoc + "_05_RESP.xml"));
                            if (!File.Exists(archivo))
                            {
                                xml.Save((directorio + (nombreArchivo + tipoDoc + "_05_RESP.xml")));
                                XmlTextWriter xmlTextWriter = new XmlTextWriter((directorio + (nombreArchivo + tipoDoc + "_05_RESP.xml")), new System.Text.UTF8Encoding(false));
                                xml.WriteTo(xmlTextWriter);
                                xmlTextWriter.Dispose();

                            }

                            adjuntos.Add(archivo);

                        }



                    }

                   

                }
               
              

            }
            catch (Exception ex)
            {

                throw ex;
            }



            return adjuntos;
        }

        private string generarPDF()
        {
            try
            {
                string pdf = string.Empty;
                string tipoDoc = Utility.getPrefixTypeDoc(_doc.tipoDocumento);
                string directorio = Global.Usuario.tbEmpresa.rutaCertificado.Trim();
                //string conec=Properties.Settings.Default.dbSISSODINAConnectionString1.ToString();
            SqlConnection _SqlConnection = new SqlConnection(Utility.stringConexionReportes());
                dtReporteHacienda ds = new dtReporteHacienda();
                if (_doc.idCliente == null)
                {

                    rptFacturaESinCliente Reporte = new rptFacturaESinCliente();

                    //creamos una nueva instancia del table adapter que usaremos para obtener la información de la base de datos
                    Reportes.dtReporteHaciendaTableAdapters.sp_FacturaElectronicaSinClienteTableAdapter dt = new Reportes.dtReporteHaciendaTableAdapters.sp_FacturaElectronicaSinClienteTableAdapter();

                    _SqlConnection.Open();

                    //le pasamos la conexión al tableadapter
                    dt.Connection = _SqlConnection;
                    //llenamos el tableadapter con el método fill
                    dt.Fill(ds.sp_FacturaElectronicaSinCliente, _doc.id, _doc.tipoDocumento);

                    Zen.Barcode.CodeQrBarcodeDraw barcode = new Zen.Barcode.CodeQrBarcodeDraw();

                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {

                        string conse = _doc.clave != null ? _doc.clave.ToString() : _doc.tipoDocumento.ToString() + _doc.id.ToString();
                        Image bar = barcode.Draw(conse, 6);
                        dr["Barcode"] = Utility.ImageToByteArray(bar);
                    }

                    Reporte.SetDataSource(ds);
                    string id = _doc.consecutivo == null ? _doc.id.ToString() : _doc.consecutivo;



                    pdf = directorio.Trim() + (id.Trim() + tipoDoc + "_PDF.pdf");
                    Reporte.ExportToDisk(ExportFormatType.PortableDocFormat, pdf);
                    Reporte.Close();

                }
                else
                {
                    rptFacturaE Reporte = new rptFacturaE();
                    //creamos una nueva instancia del DataSet


                    //creamos una nueva instancia del table adapter que usaremos para obtener la información de la base de datos
                    Reportes.dtReporteHaciendaTableAdapters.sp_FacturaElectronicaTableAdapter dt = new Reportes.dtReporteHaciendaTableAdapters.sp_FacturaElectronicaTableAdapter();

                    _SqlConnection.Open();

                    //le pasamos la conexión al tableadapter
                    dt.Connection = _SqlConnection;
                    //llenamos el tableadapter con el método fill
                    dt.Fill(ds.sp_FacturaElectronica, _doc.id, _doc.tipoDocumento);

                    Zen.Barcode.CodeQrBarcodeDraw barcode = new Zen.Barcode.CodeQrBarcodeDraw();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        string conse = _doc.clave != null ? _doc.clave.ToString() : _doc.tipoDocumento.ToString() + _doc.id.ToString();
                        Image bar = barcode.Draw(conse, 6);
                        dr["Barcode"] = Utility.ImageToByteArray(bar);
                    }

                    Reporte.SetDataSource(ds);

                    string id = _doc.consecutivo == null ? _doc.id.ToString() : _doc.consecutivo;


                    pdf = directorio.Trim() + (id.Trim() + tipoDoc + "_PDF.pdf");
                    Reporte.ExportToDisk(ExportFormatType.PortableDocFormat, pdf);
                    Reporte.Close();
                }

                return pdf;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private bool enviar()
        {
            bool ok = false;
            try
            {
                //Creamos un nuevo Objeto de mensaje
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                //Direccion de correo electronico a la que queremos enviar el mensaje
                foreach (string item in _destinoCorreo)
                {
                    mmsg.To.Add(item);
                }


                //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

                //Asunto
                mmsg.Subject = _subject;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

                ////Direccion de correo electronico que queremos que reciba una copia del mensaje
                //mmsg.Bcc.Add(_destinoCorreo); //Opcional

                //Cuerpo del Mensaje
                mmsg.Body = _mensaje;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

                //Correo electronico desde la que enviamos el mensaje
                mmsg.From = new System.Net.Mail.MailAddress(_envioCorreo);
                try
                {

                    foreach (var item in _adjuntos)
                    {
                        mmsg.Attachments.Add(new Attachment(item));
                    }
                }
                catch (Exception)

                {


                }





                /*-------------------------CLIENTE DE CORREO----------------------*/



                //Creamos un objeto de cliente de correo
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                //Hay que crear las credenciales del correo emisor
                cliente.Credentials =
                    new System.Net.NetworkCredential(_envioCorreo, _contrasena);

                //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
                if (_envioCorreo.Contains("hotmail.com") || _envioCorreo.Contains("outlook.com") || _envioCorreo.Contains("live.com"))
                {
                    cliente.Port = 25;
                    cliente.Host = "smtp.live.com";
                }
                else if (_envioCorreo.Contains("gmail.com"))
                {
                    cliente.Port = 25;
                    cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


                }
                cliente.EnableSsl = true;


                //cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                //cliente.UseDefaultCredentials = false;
                /*-------------------------ENVIO DE CORREO----------------------*/

                try
                {
                    //Enviamos el mensaje      
                    cliente.Send(mmsg);
                }
                catch (System.Net.Mail.SmtpException ex)
                {
                    mmsg = null;
                    cliente = null;
                    throw new EnvioCorreoException(ex);
                }


                mmsg = null;
                cliente = null;
                ok = true;

            }
            catch (Exception ex)
            {


                throw new EnvioCorreoException(ex);


            }


            return ok;
        }

    }
}
