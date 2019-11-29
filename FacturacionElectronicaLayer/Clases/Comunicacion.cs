// FirmaElectronicaCR es un programa para la firma y envio de documentos XML para la Factura Electrónica de Costa Rica
//
// Comunicacion es la clase para el envío del documento XML para la Factura Electrónica de Costa Rica
//
// Esta clase de Firma fue realizado tomando como base el trabajo realizado por:
// - Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
// - XAdES Starter Kit desarrollado por Microsoft Francia
// - Cambios y funcionalidad para Costa Rica - Roy Rojas - royrojas@dotnetcr.com
//
// La clase comunicación fue creada en conjunto con Cristhian Sancho
//
// Este programa es software libre: puede redistribuirlo y / o modificarlo
// bajo los + términos de la Licencia Pública General Reducida de GNU publicada por
// la Free Software Foundation, ya sea la versión 3 de la licencia, o
// (a su opción) cualquier versión posterior.C:\Users\walpi\Desktop\SISSOD INA 12-2018 FINAL\SisSodIna\FacturacionElectronicaLayer\Clases\Comunicacion.cs
//
// Este programa se distribuye con la esperanza de que sea útil,
// pero SIN NINGUNA GARANTÍA; sin siquiera la garantía implícita de
// COMERCIABILIDAD O IDONEIDAD PARA UN PROPÓSITO PARTICULAR. 
// Licencia pública general menor de GNU para más detalles.
//
// Deberías haber recibido una copia de la Licencia Pública General Reducida de GNU
// junto con este programa.Si no, vea http://www.gnu.org/licenses/.
//
// This program Is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program.If Not, see http://www.gnu.org/licenses/. 


using CommonLayer;
using CommonLayer.Exceptions.BussinessExceptions;
using CommonLayer.Logs;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace FacturacionElectronicaLayer.Clases
{
    public  class Comunicacion
    {

        //private string URL_RECEPCION_DESA = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/";
        //private string URL_RECEPCION_PRO = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";

        private string URL = string.Empty;





        public Comunicacion()
        {
            
                URL = Utility.URL_RECEPCION((bool)Global.Usuario.tbEmpresa.ambientePruebas);
           

        }

        public XmlDocument xmlRespuesta { get; set; }
        public string jsonEnvio { get; set; }
        public string jsonRespuesta { get; set; }
        public string mensajeRespuesta { get; set; }
        public string estadoFactura { get; set; }
        public string statusCode { get; set; }
        public string estadoEnvio { get; set; }
        public bool existeRespuesta { get; set; }
        public string xmlCodificado { get; set; }
        public async Task<String> EnvioDatos(string TK, Recepcion objRecepcion)
        {
            try
            {
                String URL_RECEPCION = URL;



                HttpClient http = new HttpClient();

                Newtonsoft.Json.Linq.JObject JsonObject = new Newtonsoft.Json.Linq.JObject();
                JsonObject.Add(new Newtonsoft.Json.Linq.JProperty("clave", objRecepcion.clave));
                JsonObject.Add(new JProperty("fecha", objRecepcion.fecha));
                JsonObject.Add(new JProperty("emisor",
                                             new JObject(new JProperty("tipoIdentificacion", objRecepcion.emisor.TipoIdentificacion),
                                                         new JProperty("numeroIdentificacion", objRecepcion.emisor.numeroIdentificacion.Trim()))));

                if (objRecepcion.receptor.sinReceptor == false) 
                {
                    JsonObject.Add(new JProperty("receptor",
                                             new JObject(new JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                         new JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))));
                }
               
                JsonObject.Add(new JProperty("comprobanteXml", objRecepcion.comprobanteXml));

                jsonEnvio = JsonObject.ToString();

                StringContent oString = new StringContent(JsonObject.ToString());

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));

                HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;
                // mensajeRespuesta = Localizacion
                estadoEnvio= response.StatusCode.ToString();


                //http = new HttpClient();
                //http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));
                //response = http.GetAsync((URL_RECEPCION + ("recepcion/" + objRecepcion.clave))).Result;
                //res = await response.Content.ReadAsStringAsync();

                //jsonRespuesta = res.ToString();

                //RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaHacienda>(res);
                //if (RH !=null)
                //{
                //    existeRespuesta = true;
                //    if ((RH.respuesta_xml != null ))
                //    {
                //        xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml);
                //    }
                //    estadoFactura = RH.ind_estado;

                //}
                //else
                //{

                //    existeRespuesta = false;
                //}

                //mensajeRespuesta = estadoFactura;
                statusCode = response.StatusCode.ToString();
                return statusCode;
            }
            catch (Exception ex)
            {
                clsEvento evento = new clsEvento(ex.Message, "1");
                throw new FacturacionElectronicaException(ex);
            }
        }


        public async Task<String> EnvioMensaje(string TK, RecepcionMensaje objRecepcion)
        {
            try
            {
                String URL_RECEPCION = URL;



                HttpClient http = new HttpClient();

                Newtonsoft.Json.Linq.JObject JsonObject = new Newtonsoft.Json.Linq.JObject();
                JsonObject.Add(new Newtonsoft.Json.Linq.JProperty("clave", objRecepcion.clave));
                JsonObject.Add(new JProperty("fecha", objRecepcion.fecha));
                JsonObject.Add(new JProperty("emisor",
                                             new JObject(new JProperty("tipoIdentificacion", objRecepcion.emisor.TipoIdentificacion),
                                                         new JProperty("numeroIdentificacion", objRecepcion.emisor.numeroIdentificacion.Trim()))));

                if (objRecepcion.receptor.sinReceptor == false)
                {
                    JsonObject.Add(new JProperty("receptor",
                                             new JObject(new JProperty("tipoIdentificacion", objRecepcion.receptor.TipoIdentificacion),
                                                         new JProperty("numeroIdentificacion", objRecepcion.receptor.numeroIdentificacion))));
                }

                JsonObject.Add(new JProperty("consecutivoReceptor", objRecepcion.consecutivoReceptor));
                JsonObject.Add(new JProperty("comprobanteXml", objRecepcion.comprobanteXml));

      

                jsonEnvio = JsonObject.ToString();

                StringContent oString = new StringContent(JsonObject.ToString());

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));

                HttpResponseMessage response = http.PostAsync((URL_RECEPCION + "recepcion"), oString).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;
                // mensajeRespuesta = Localizacion
                estadoEnvio = response.StatusCode.ToString();
                mensajeRespuesta= response.Headers.Location.ToString();

                //http = new HttpClient();
                //http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));
                //response = http.GetAsync((URL_RECEPCION + ("recepcion/" + objRecepcion.clave))).Result;
                //res = await response.Content.ReadAsStringAsync();

                //jsonRespuesta = res.ToString();

                //RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaHacienda>(res);
                //if (RH !=null)
                //{
                //    existeRespuesta = true;
                //    if ((RH.respuesta_xml != null ))
                //    {
                //        xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml);
                //    }
                //    estadoFactura = RH.ind_estado;

                //}
                //else
                //{

                //    existeRespuesta = false;
                //}

                //mensajeRespuesta = estadoFactura;
                statusCode = response.StatusCode.ToString();
                return statusCode;
            }
            catch (Exception ex)

            {
                clsEvento evento = new clsEvento(ex.Message, "1");
                throw new FacturacionElectronicaException(ex);
            }
        }
        public async void ConsultaEstatus(string TK, string claveConsultar)
        {
            try
            {
                


                String URL_RECEPCION = URL;

                HttpClient http = new HttpClient();

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));

                HttpResponseMessage response = http.GetAsync((URL_RECEPCION + ("recepcion/" + claveConsultar))).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;

                jsonRespuesta = res.ToString();
                RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaHacienda>(res);
                if (RH != null)
                {                    

                    if ((RH.respuesta_xml != "" && RH.respuesta_xml!=null))
                    {
                        xmlCodificado = RH.respuesta_xml;
                        xmlRespuesta = Utility.DecodeBase64ToXML(RH.respuesta_xml);
                    }
                    estadoFactura = RH.ind_estado;
                   
                }
                

                
                statusCode = response.StatusCode.ToString();
                mensajeRespuesta = ("Confirmación: " + (statusCode + "\r\n"));
                mensajeRespuesta = (mensajeRespuesta + ("Estado: " + estadoFactura));
            }
            catch (Exception ex)
            {
                clsEvento evento = new clsEvento(ex.Message, "1");
                throw new RespuestaHaciendaException(ex);
            }
        }



        public async void ConsultaEstatusMensajes(string TK, string url)
        {
            try
            {
       
                HttpClient http = new HttpClient();

                http.DefaultRequestHeaders.Add("authorization", ("Bearer " + TK));

                HttpResponseMessage response = http.GetAsync(url).Result;
                string res = await response.Content.ReadAsStringAsync();

                object Localizacion = response.StatusCode;

                jsonRespuesta = res.ToString();
                RespuestaHacienda RH = Newtonsoft.Json.JsonConvert.DeserializeObject<RespuestaHacienda>(res);
                if (RH != null)
                {

                    if ((RH.respuesta_xml != "" && RH.respuesta_xml != null))
                    {
                        xmlCodificado = RH.respuesta_xml;
                        xmlRespuesta = Utility.DecodeBase64ToXML(RH.respuesta_xml);
                    }
                    estadoFactura = RH.ind_estado;

                }

                statusCode = response.StatusCode.ToString();
                mensajeRespuesta = ("Confirmación: " + (statusCode + "\r\n"));
                mensajeRespuesta = (mensajeRespuesta + ("Estado: " + estadoFactura));
            }
            catch (Exception ex)
            {
                clsEvento evento = new clsEvento(ex.Message, "1");
                throw new RespuestaHaciendaException(ex);
            }
        }
    }
}
