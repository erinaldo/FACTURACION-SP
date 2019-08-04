using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;

namespace FacturacionElectronicaLayer.ClasesDatos
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using CommonLayer;
    using CommonLayer.Exceptions.BussinessExceptions;
    using EntityLayer;
    using Microsoft.VisualBasic;

    public class FacturaElectronicaCR
    {
      
        private System.IO.MemoryStream mXML;
        private tbDocumento _doc = null;
        private string _numeroConsecutivo = "";
        private string _numeroClave = "";
        private Emisor _emisor;
        private Receptor _receptor;
        private string _condicionVenta = "";
        private string _plazoCredito = "";
        private string _medioPago = "";
        private ICollection<tbDetalleDocumento> _listaDetalle;
        private string _codigoMoneda = "";
        private decimal _tipoCambio;
        private string _Obsv;
        private tbEmpresa _empresa;
        private tbReporteHacienda _mensajeHacienda;

        public FacturaElectronicaCR(tbReporteHacienda mensaje)
        {

            _mensajeHacienda = mensaje;


        }


        public FacturaElectronicaCR(tbDocumento doc,string numeroConsecutivo, string numeroClave, Emisor emisor, Receptor receptor,
                                    string condicionVenta, string plazoCredito, string medioPago,
                                    ICollection< tbDetalleDocumento> listaDetalle, string codigoMoneda, decimal tipoCambio, tbEmpresa empresa, string obsv)
        {
            _doc = doc;
            _numeroConsecutivo = numeroConsecutivo;
            _numeroClave = numeroClave;
            _emisor = emisor;
            _receptor = receptor;
            _condicionVenta = condicionVenta;
            _plazoCredito = plazoCredito;
            _medioPago = medioPago;
            _listaDetalle = listaDetalle;
            _codigoMoneda = codigoMoneda;
            _tipoCambio = tipoCambio;
            _empresa = empresa;
            _Obsv = obsv;

        }

        // 'Este documento esta para la factura electronica, 
        // 'Para la nota de credito es un documento similar pero cambia algunos nodos.
        // 'Lo vemos luego.

        // 'Segun la normativa, estos son los datos basicos que seguramente van a ocupar,
        // 'Es posible que algunos no los ocupen y requieran otros, es normal y los veremos conforme vayamos 
        // 'desarrollando la factura. Cuando se envien los datos a Hacienda, ahi seguramente nos daremos cuenta en las pruebas



        public XmlDocument CreaXMLMensajeHacienda()
        {
            try
            {
                mXML = new System.IO.MemoryStream();

                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(mXML, System.Text.Encoding.UTF8);

                XmlDocument docXML = new XmlDocument();

                GeneraXMLReceptorHacienda4_3(writer);

                mXML.Seek(0, System.IO.SeekOrigin.Begin);

                docXML.Load(mXML);

                writer.Close();

                // Retorna el documento xml y ahi se puede salvar docXML.Save
                return docXML;
            }
            catch (Exception ex)
            {
                throw new generarXMLException(ex);
            }
        }
        public XmlDocument CreaXMLFacturaElectronica()
        {
            try
            {
                mXML = new System.IO.MemoryStream();

                System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(mXML, System.Text.Encoding.UTF8);

                XmlDocument docXML = new XmlDocument();

                if (_doc.tipoDocumento==(int)Enums.TipoDocumento.FacturaElectronica)
                {
                    //if (_doc.idCliente !=null && (bool)_doc.clienteContribuyente)
                    //{
                        //genera factura al contribuyente
                            GeneraXMLFacturaElectronica4_3(writer);
                    //}
                    //else
                    //{
                    //    //genera contribuyente a no contribuyente
                    //    GeneraXMLFacturaElectronicaNoContribuyente4_3(writer);

                    //}
                    

                }
                else if (_doc.tipoDocumento == (int)Enums.TipoDocumento.NotaCreditoElectronica)
                {
                    GeneraXMLNotaCredito4_3(writer);
                }
                

                mXML.Seek(0, System.IO.SeekOrigin.Begin);

                docXML.Load(mXML);

                writer.Close();

                // Retorna el documento xml y ahi se puede salvar docXML.Save
                return docXML;
            }
            catch (Exception ex)
            {
                throw new generarXMLException(ex);
            }
        }
        #region 4.2
        private void GeneraXMLFacturaElectronica4_3(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("FacturaElectronica");

                writer.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica");
                writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");
                /*
                writer.WriteAttributeString("xmlns:targetNamespace", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica");
                writer.WriteAttributeString("xmlns:elementFormDefault", "qualified");
                writer.WriteAttributeString("xmlns:attributeFormDefault", "unqualified");
                writer.WriteAttributeString("xmlns:version", "4.3");
                writer.WriteAttributeString("xmlns:vc:minVersion", "1.1");
                */
               



                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _numeroClave);
                writer.WriteElementString("CodigoActividad", _emisor.codigoActividad.ToString().PadLeft(6, '0'));


              
                // 'El numero de secuencia es de 20 caracteres, 
                // 'Se debe de crear con la función CreaNumeroSecuencia de la clase Datos
                writer.WriteElementString("NumeroConsecutivo", _numeroConsecutivo);

                // 'El formato de la fecha es yyyy-MM-ddTHH:mm:sszzz
                writer.WriteElementString("FechaEmision", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteStartElement("Emisor");

                writer.WriteElementString("Nombre", _emisor.Nombre);
                writer.WriteStartElement("Identificacion");
                writer.WriteElementString("Tipo", _emisor.Identificacion_Tipo);
                writer.WriteElementString("Numero", _emisor.Identificacion_Numero);
                writer.WriteEndElement(); // 'Identificacion

                // '-----------------------------------
                // 'Los datos de las ubicaciones los puede tomar de las tablas de datos, 
                // 'Debe ser exacto al que hacienda tiene registrado para su compañia
                writer.WriteStartElement("Ubicacion");
                writer.WriteElementString("Provincia", _emisor.Ubicacion_Provincia);
                writer.WriteElementString("Canton", _emisor.Ubicacion_Canton);
                writer.WriteElementString("Distrito", _emisor.Ubicacion_Distrito);
                writer.WriteElementString("Barrio", _emisor.Ubicacion_Barrio);
                writer.WriteElementString("OtrasSenas", _emisor.Ubicacion_OtrasSenas);
                writer.WriteEndElement(); // 'Ubicacion

                writer.WriteStartElement("Telefono");
                writer.WriteElementString("CodigoPais", _emisor.Telefono_CodigoPais);
                writer.WriteElementString("NumTelefono", _emisor.Telefono_Numero.ToString());
                writer.WriteEndElement(); // 'Telefono

                writer.WriteElementString("CorreoElectronico", _emisor.CorreoElectronico);

                writer.WriteEndElement(); // Emisor
             
                    writer.WriteStartElement("Receptor");                      // 'Receptor es similar con emisor, los datos opcionales siempre siempre siempre omitirlos.

                    writer.WriteElementString("Nombre", _receptor.Nombre);
                    writer.WriteStartElement("Identificacion");
                    // 'Los tipos de identificacion los puede ver en la tabla de datos
                    writer.WriteElementString("Tipo", _receptor.Identificacion_Tipo);
                    writer.WriteElementString("Numero", _receptor.Identificacion_Numero);
                    writer.WriteEndElement(); // 'Identificacion

                    writer.WriteElementString("CorreoElectronico", _receptor.CorreoElectronico);

                    writer.WriteEndElement(); // Receptor
                                  // '------------------------------------
                



                                            // 'Loa datos estan en la tabla correspondiente
                writer.WriteElementString("CondicionVenta", _condicionVenta);
                // '01: Contado
                // '02: Credito
                // '03: Consignación
                // '04: Apartado
                // '05: Arrendamiento con opcion de compra
                // '06: Arrendamiento con función financiera
                // '99: Otros

                // 'Este dato se muestra si la condicion venta es credito
                if (_condicionVenta=="02")
                {
                writer.WriteElementString("PlazoCredito", _plazoCredito);
                }
                
                               
                writer.WriteElementString("MedioPago", _medioPago);
                // '01: Efectivo
                // '02: Tarjeta
                // '03: Cheque
                // '04: Transferecia - deposito bancario
                // '05: Recaudado por terceros            
                // '99: Otros

                writer.WriteStartElement("DetalleServicio");
              
                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    writer.WriteStartElement("LineaDetalle");

                    writer.WriteElementString("NumeroLinea", detalle.numLinea.ToString().Trim());

                    writer.WriteStartElement("CodigoComercial");
                    writer.WriteElementString("Tipo", "01");
                    writer.WriteElementString("Codigo", detalle.idProducto.ToString().Trim());
                    writer.WriteEndElement(); // 'codigo comercial

                   // int cant = (int)detalle.cantidad;//convierte entero, elimina decimales
                    writer.WriteElementString("Cantidad", String.Format("{0:N3}", detalle.cantidad.ToString()));
                    // 'Para las unidades de medida ver la tabla correspondiente
                    writer.WriteElementString("UnidadMedida", Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida));//nomenlatura kg etc

                    writer.WriteElementString("Detalle", detalle.tbProducto.nombre.ToString().Trim());


                    writer.WriteElementString("PrecioUnitario", String.Format("{0:N3}", detalle.precio.ToString().Trim()));
                    writer.WriteElementString("MontoTotal", String.Format("{0:N3}", detalle.montoTotal.ToString().Trim()));

                    if (detalle.montoTotalDesc!=0)
                    {

                   
                        writer.WriteStartElement("Descuento");
                        writer.WriteElementString("MontoDescuento", String.Format("{0:N3}", detalle.montoTotalDesc.ToString().Trim()));
                        writer.WriteElementString("NaturalezaDescuento", "Descuento aplicado al cliente");//agregar naturaleza desc                        
                        writer.WriteEndElement(); // 'descuento

                    }
                    writer.WriteElementString("SubTotal", String.Format("{0:N3}", (detalle.montoTotal - detalle.montoTotalDesc).ToString().Trim()));
                   
                    if (detalle.montoTotalImp != 0)
                    {

                        writer.WriteStartElement("Impuesto");
                        writer.WriteElementString("Codigo", detalle.tbProducto.tbImpuestos.id.ToString().PadLeft(2, '0'));// impueto aplicado codigo
                        writer.WriteElementString("CodigoTarifa", "08");
                        writer.WriteElementString("Tarifa", String.Format("{0:N3}", detalle.tbProducto.tbImpuestos.valor.ToString()));// %aplicado valor
                        writer.WriteElementString("Monto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));

                        if (detalle.montoTotalExo != 0)
                        {
                            writer.WriteStartElement("Exoneracion");
                            writer.WriteElementString("TipoDocuento", _receptor.tipoExoneracion.PadLeft(2, '0'));// impueto aplicado codigo
                            writer.WriteElementString("NumeroDocumento", _receptor.institucionExo);// impueto aplicado codigo

                            writer.WriteElementString("NombreInstitucion",_receptor.institucionExo);// impueto aplicado codigo
                            writer.WriteElementString("FechaEmision", _receptor.fechaEmisionExo.ToString("yyyy-MM-ddTHH:mm:sszzz"));// impueto aplicado codigo
                            writer.WriteElementString("PorcentajeExoneracion", _receptor.valorExo.ToString());// impueto aplicado codigo

                            writer.WriteElementString("MontoExoneracion", String.Format("{0:N3}", detalle.montoTotalExo.ToString().Trim()));// impueto aplicado codigo

                            writer.WriteEndElement(); // exoneracion
                        }

                        writer.WriteEndElement(); // Impuesto
                        writer.WriteElementString("ImpuestoNeto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));
                    }      

                    writer.WriteElementString("MontoTotalLinea", String.Format("{0:N3}", detalle.totalLinea.ToString().Trim()));
                    writer.WriteEndElement(); // LineaDetalle
                }
                // '-------------------------------------

                writer.WriteEndElement(); // DetalleServicio

                writer.WriteStartElement("ResumenFactura");

                writer.WriteStartElement("CodigoTipoMoneda");
                writer.WriteElementString("CodigoMoneda", _codigoMoneda);

                if (_codigoMoneda.ToUpper().Trim() == "USD")
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", _empresa.tbParametrosEmpresa.First().cambioDolar.ToString().Trim()));

                }
                else
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", "1"));

                }
                writer.WriteEndElement(); // CodigoTipoMoneda


                
                decimal totalProdGravados = 0;
                decimal totalProdExcentos = 0;
                decimal totalSevGravados = 0;
                decimal totalServExcentos = 0;
                decimal totalServExonerado = 0;
                decimal totalProdExonerado = 0;

                decimal totalDescuento = 0;
                decimal totalComprobante = 0;
                decimal impuestos = 0;

                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    totalDescuento += detalle.montoTotalDesc;//total de decuento
                    totalComprobante += detalle.totalLinea;//total de comprobante


                    if (detalle.montoTotalImp == 0)//valida si exonera es 0, si tiene valor de impuesto no exonera
                    {//acumulo monto total, sin descuento. monto total es precio*cantidad
                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")//valida si es producto o servicio y acumula en su respectiva variable
                        {
                            totalServExonerado += detalle.montoTotalExo;
                            totalServExcentos += detalle.montoTotal;
                        }
                        else//si es producto
                        {
                            totalProdExonerado += detalle.montoTotalExo;
                            totalProdExcentos += detalle.montoTotal;

                        }


                    }
                    else
                    {
                        impuestos += detalle.montoTotalImp;

                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")
                        {//si tiene impuesto y es un servicio
                            totalServExonerado += detalle.montoTotalExo;
                            totalSevGravados += detalle.montoTotal;
                        }
                        else
                        {
                            totalProdExonerado += detalle.montoTotalExo;
                            totalProdGravados += detalle.montoTotal;//si es un prodcuto

                        }
                    }

                }
               
                writer.WriteElementString("TotalServGravados", String.Format("{0:N3}", totalSevGravados.ToString()));
               
                writer.WriteElementString("TotalServExentos", String.Format("{0:N3}", totalServExcentos.ToString()));
               
                writer.WriteElementString("TotalServExonerado", String.Format("{0:N3}", totalServExonerado.ToString()));
                
                writer.WriteElementString("TotalMercanciasGravadas", String.Format("{0:N3}", totalProdGravados.ToString()));
                
                writer.WriteElementString("TotalMercanciasExentas", String.Format("{0:N3}", totalProdExcentos.ToString()));
                
                writer.WriteElementString("TotalMercExonerada", String.Format("{0:N3}", totalProdExonerado.ToString()));              

                decimal totalGravados = totalSevGravados + totalProdGravados;
                decimal totalExentos = totalProdExcentos + totalServExcentos;
                decimal totalExo = totalProdExonerado + totalServExonerado;
               
                writer.WriteElementString("TotalGravado", String.Format("{0:N3}", totalGravados.ToString()));     

                writer.WriteElementString("TotalExento", String.Format("{0:N3}", totalExentos.ToString()));     
                
                writer.WriteElementString("TotalExonerado", String.Format("{0:N3}", totalExo.ToString()));

                decimal totalVenta = totalGravados + totalExentos+ totalExo;//total de venta, gravados y exonerados
                decimal totalVentaNeta = totalVenta - totalDescuento;//calula el monto de descuento

                writer.WriteElementString("TotalVenta", String.Format("{0:N3}", totalVenta.ToString()));
               
                writer.WriteElementString("TotalDescuentos", String.Format("{0:N3}", totalDescuento.ToString()));
               
                writer.WriteElementString("TotalVentaNeta", String.Format("{0:N3}", totalVentaNeta.ToString()));
               
                writer.WriteElementString("TotalImpuesto", String.Format("{0:N3}", impuestos.ToString()));                     

                writer.WriteElementString("TotalComprobante", String.Format("{0:N3}", totalComprobante.ToString()));
                writer.WriteEndElement(); // ResumenFactura

                // 'Estos datos te los tiene que brindar los encargados del area financiera
                //writer.WriteStartElement("Normativa");
                //writer.WriteElementString("NumeroResolucion", _empresa.numeroResolucion.Trim());
                //writer.WriteElementString("FechaResolucion", ((DateTime)_empresa.fechaResolucio).ToString("dd-MM-yyyy HH:MM:ss"));
                //writer.WriteEndElement(); // Normativa

                if (_doc.observaciones != null && _doc.observaciones.Trim() != string.Empty)
                {
                    //otros
                    writer.WriteStartElement("Otros");
                    writer.WriteElementString("OtroTexto", _doc.observaciones.Substring(0, 180).Trim());
                    writer.WriteEndElement();//Otros
                }

                // 'Aqui va la firma, despues la agregamos.

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
         }
        private void GeneraXMLFacturaElectronicaNoContribuyente4_3(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("FacturaElectronicaCompra");

                writer.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronicaCompra");
                writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");
                /*
                writer.WriteAttributeString("xmlns:targetNamespace", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica");
                writer.WriteAttributeString("xmlns:elementFormDefault", "qualified");
                writer.WriteAttributeString("xmlns:attributeFormDefault", "unqualified");
                writer.WriteAttributeString("xmlns:version", "4.3");
                writer.WriteAttributeString("xmlns:vc:minVersion", "1.1");
                */




                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _numeroClave);
                writer.WriteElementString("CodigoActividad", _emisor.codigoActividad.ToString().PadLeft(6, '0'));



                // 'El numero de secuencia es de 20 caracteres, 
                // 'Se debe de crear con la función CreaNumeroSecuencia de la clase Datos
                writer.WriteElementString("NumeroConsecutivo", _numeroConsecutivo);

                // 'El formato de la fecha es yyyy-MM-ddTHH:mm:sszzz
                writer.WriteElementString("FechaEmision", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteStartElement("Emisor");

                writer.WriteElementString("Nombre", _emisor.Nombre);
                writer.WriteStartElement("Identificacion");
                writer.WriteElementString("Tipo", _emisor.Identificacion_Tipo);
                writer.WriteElementString("Numero", _emisor.Identificacion_Numero);
                writer.WriteEndElement(); // 'Identificacion

                // '-----------------------------------
                // 'Los datos de las ubicaciones los puede tomar de las tablas de datos, 
                // 'Debe ser exacto al que hacienda tiene registrado para su compañia
                writer.WriteStartElement("Ubicacion");
                writer.WriteElementString("Provincia", _emisor.Ubicacion_Provincia);
                writer.WriteElementString("Canton", _emisor.Ubicacion_Canton);
                writer.WriteElementString("Distrito", _emisor.Ubicacion_Distrito);
                writer.WriteElementString("Barrio", _emisor.Ubicacion_Barrio);
                writer.WriteElementString("OtrasSenas", _emisor.Ubicacion_OtrasSenas);
                writer.WriteEndElement(); // 'Ubicacion

                writer.WriteStartElement("Telefono");
                writer.WriteElementString("CodigoPais", _emisor.Telefono_CodigoPais);
                writer.WriteElementString("NumTelefono", _emisor.Telefono_Numero.ToString());
                writer.WriteEndElement(); // 'Telefono

                writer.WriteElementString("CorreoElectronico", _emisor.CorreoElectronico);

                writer.WriteEndElement(); // Emisor
                                          // '------------------------------------
                                          // 'Receptor es similar con emisor, los datos opcionales siempre siempre siempre omitirlos.
                if (_receptor != null)
                {
                    writer.WriteStartElement("Receptor");
                    writer.WriteElementString("Nombre", _receptor.Nombre);
                    writer.WriteStartElement("Identificacion");
                    // 'Los tipos de identificacion los puede ver en la tabla de datos
                    writer.WriteElementString("Tipo", _receptor.Identificacion_Tipo);
                    writer.WriteElementString("Numero", _receptor.Identificacion_Numero);
                    writer.WriteEndElement(); // 'Identificacion

                    //writer.WriteStartElement("Telefono");
                    //writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                    //writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                    //writer.WriteEndElement(); // 'Telefono

                    //writer.WriteStartElement("Fax");
                    //writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                    //writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                    //writer.WriteEndElement(); // 'Telefono

                    writer.WriteElementString("CorreoElectronico", _receptor.CorreoElectronico);

                    writer.WriteEndElement(); // Receptor

                }

                // 'Loa datos estan en la tabla correspondiente
                writer.WriteElementString("CondicionVenta", _condicionVenta);
                // '01: Contado
                // '02: Credito
                // '03: Consignación
                // '04: Apartado
                // '05: Arrendamiento con opcion de compra
                // '06: Arrendamiento con función financiera
                // '99: Otros

                // 'Este dato se muestra si la condicion venta es credito
                if (_condicionVenta == "02")
                {
                    writer.WriteElementString("PlazoCredito", _plazoCredito);
                }




                writer.WriteElementString("MedioPago", _medioPago);
                // '01: Efectivo
                // '02: Tarjeta
                // '03: Cheque
                // '04: Transferecia - deposito bancario
                // '05: Recaudado por terceros            
                // '99: Otros

                writer.WriteStartElement("DetalleServicio");
                //-----variables resumes de montos pagados


                // '-------------------------------------
                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    writer.WriteStartElement("LineaDetalle");

                    writer.WriteElementString("NumeroLinea", detalle.numLinea.ToString().Trim());

                    //writer.WriteStartElement("Codigo");
                    //writer.WriteElementString("Tipo", "01");//codigo del prodcuto del vendedor nota 12.
                    writer.WriteElementString("Codigo", detalle.idProducto.ToString().Trim());
                    //writer.WriteEndElement(); // 'Codigo

                    int cant = (int)detalle.cantidad;//convierte entero, elimina decimales
                    writer.WriteElementString("Cantidad", cant.ToString());
                    // 'Para las unidades de medida ver la tabla correspondiente
                    writer.WriteElementString("UnidadMedida", Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida));//nomenlatura kg etc

                    writer.WriteElementString("Detalle", detalle.tbProducto.nombre.ToString().Trim());


                    writer.WriteElementString("PrecioUnitario", String.Format("{0:N3}", detalle.precio.ToString().Trim()));
                    writer.WriteElementString("MontoTotal", String.Format("{0:N3}", detalle.montoTotal.ToString().Trim()));

                    if (detalle.montoTotalDesc != 0)
                    {


                        writer.WriteStartElement("Descuento");
                        writer.WriteElementString("MontoDescuento", String.Format("{0:N3}", detalle.montoTotalDesc.ToString().Trim()));
                        writer.WriteElementString("NaturalezaDescuento", "Descuento aplicado al cliente");//agregar naturaleza desc                        
                        writer.WriteEndElement(); // 'descuento

                    }
                    writer.WriteElementString("SubTotal", String.Format("{0:N3}", (detalle.montoTotal - detalle.montoTotalDesc).ToString().Trim()));
                    //writer.WriteElementString("BaseImponible", String.Format("{0:N3}", detalle.xxxx.ToString().Trim()));




                    if (detalle.montoTotalImp != 0)
                    {

                        writer.WriteStartElement("Impuesto");
                        writer.WriteElementString("Codigo", detalle.tbProducto.tbImpuestos.id.ToString().PadLeft(2, '0'));// impueto aplicado codigo
                        writer.WriteElementString("CodigoTarifa", "08");
                        writer.WriteElementString("Tarifa", detalle.tbProducto.tbImpuestos.valor.ToString());// %aplicado valor
                        writer.WriteElementString("Monto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));

                        if (detalle.montoTotalExo != 0)
                        {
                            writer.WriteStartElement("Exoneracion");
                            writer.WriteElementString("TipoDocuento", _receptor.tipoExoneracion.PadLeft(2, '0'));// impueto aplicado codigo
                            writer.WriteElementString("NumeroDocumento", _receptor.institucionExo);// impueto aplicado codigo

                            writer.WriteElementString("NombreInstitucion", _receptor.institucionExo);// impueto aplicado codigo
                            writer.WriteElementString("FechaEmision", _receptor.fechaEmisionExo.ToString("yyyy-MM-ddTHH:mm:sszzz"));// impueto aplicado codigo
                            writer.WriteElementString("PorcentajeExoneracion", _receptor.valorExo.ToString());// impueto aplicado codigo

                            writer.WriteElementString("MontoExoneracion", String.Format("{0:N3}", detalle.montoTotalExo.ToString().Trim()));// impueto aplicado codigo

                            writer.WriteEndElement(); // exoneracion



                        }

                        writer.WriteEndElement(); // Impuesto
                        writer.WriteElementString("ImpuestoNeto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));

                    }

                    writer.WriteElementString("MontoTotalLinea", String.Format("{0:N3}", detalle.totalLinea.ToString().Trim()));

                    writer.WriteEndElement(); // LineaDetalle
                }
                // '-------------------------------------

                writer.WriteEndElement(); // DetalleServicio


                writer.WriteStartElement("ResumenFactura");

                writer.WriteStartElement("CodigoTipoMoneda");
                writer.WriteElementString("CodigoMoneda", _codigoMoneda);

                if (_codigoMoneda.ToUpper().Trim() == "USD")
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", _empresa.tbParametrosEmpresa.First().cambioDolar.ToString().Trim()));

                }
                else
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", "1"));

                }
                writer.WriteEndElement(); // CodigoTipoMoneda



                decimal totalProdGravados = 0;
                decimal totalProdExcentos = 0;
                decimal totalSevGravados = 0;
                decimal totalServExcentos = 0;
                decimal totalServExonerado = 0;
                decimal totalProdExonerado = 0;

                decimal totalDescuento = 0;
                decimal totalComprobante = 0;
                decimal impuestos = 0;

                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    totalDescuento += detalle.montoTotalDesc;//total de decuento
                    totalComprobante += detalle.totalLinea;//total de comprobante


                    if (detalle.montoTotalImp == 0)//valida si exonera es 0, si tiene valor de impuesto no exonera
                    {//acumulo monto total, sin descuento. monto total es precio*cantidad
                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")//valida si es producto o servicio y acumula en su respectiva variable
                        {
                            totalServExonerado += detalle.montoTotalExo;
                            totalServExcentos += detalle.montoTotal;
                        }
                        else//si es producto
                        {
                            totalProdExonerado += detalle.montoTotalExo;
                            totalProdExcentos += detalle.montoTotal;

                        }


                    }
                    else
                    {
                        impuestos += detalle.montoTotalImp;

                        if (detalle.tbProducto.tbCategoriaProducto.nombre.Trim().ToUpper() == "SERVICIOS PROFESIONALES")
                        {//si tiene impuesto y es un servicio
                            totalServExonerado += detalle.montoTotalExo;
                            totalSevGravados += detalle.montoTotal;
                        }
                        else
                        {
                            totalProdExonerado += detalle.montoTotalExo;
                            totalProdGravados += detalle.montoTotal;//si es un prodcuto

                        }


                    }



                }
                writer.WriteElementString("TotalServGravados", String.Format("{0:N3}", totalSevGravados.ToString()));
                writer.WriteElementString("TotalServExentos", String.Format("{0:N3}", totalServExcentos.ToString()));
                writer.WriteElementString("TotalServExonerado", String.Format("{0:N3}", totalServExonerado.ToString()));

                writer.WriteElementString("TotalMercanciasGravadas", String.Format("{0:N3}", totalProdGravados.ToString()));
                writer.WriteElementString("TotalMercanciasExentas", String.Format("{0:N3}", totalProdExcentos.ToString()));
                writer.WriteElementString("TotalMercExonerada", String.Format("{0:N3}", totalProdExonerado.ToString()));

                decimal totalGravados = totalSevGravados + totalProdGravados;
                decimal totalExentos = totalProdExcentos + totalServExcentos;
                decimal totalExo = totalProdExonerado + totalServExonerado;
                writer.WriteElementString("TotalGravado", String.Format("{0:N3}", totalGravados.ToString()));
                writer.WriteElementString("TotalExento", String.Format("{0:N3}", totalExentos.ToString()));
                writer.WriteElementString("TotalExonerado", String.Format("{0:N3}", totalExo.ToString()));




                decimal totalVenta = totalGravados + totalExentos + totalExo;//total de venta, gravados y exonerados
                decimal totalVentaNeta = totalVenta - totalDescuento;//calula el monto de descuento
                writer.WriteElementString("TotalVenta", String.Format("{0:N3}", totalVenta.ToString()));
                writer.WriteElementString("TotalDescuentos", String.Format("{0:N3}", totalDescuento.ToString()));
                writer.WriteElementString("TotalVentaNeta", String.Format("{0:N3}", totalVentaNeta.ToString()));

                writer.WriteElementString("TotalImpuesto", String.Format("{0:N3}", impuestos.ToString()));


                writer.WriteElementString("TotalComprobante", String.Format("{0:N3}", totalComprobante.ToString()));
                writer.WriteEndElement(); // ResumenFactura

                // 'Estos datos te los tiene que brindar los encargados del area financiera
                //writer.WriteStartElement("Normativa");
                //writer.WriteElementString("NumeroResolucion", _empresa.numeroResolucion.Trim());
                //writer.WriteElementString("FechaResolucion", ((DateTime)_empresa.fechaResolucio).ToString("dd-MM-yyyy HH:MM:ss"));
                //writer.WriteEndElement(); // Normativa

                if (_doc.observaciones != null && _doc.observaciones.Trim() != string.Empty)
                {
                    //otros
                    writer.WriteStartElement("Otros");
                    writer.WriteElementString("OtroTexto", _doc.observaciones.Substring(0, 180).Trim());
                    writer.WriteEndElement();//Otros
                }

                // 'Aqui va la firma, despues la agregamos.

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void GeneraXMLNotaCredito4_3(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
                {
                    try
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("NotaCreditoElectronica");

                        writer.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/notaCreditoElectronica");
                        writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                        writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                        writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");
                        // writer.WriteAttributeString("xsi:schemaLocation", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/notaCreditoElectronica https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/notaCreditoElectronica.xsd");

                        /*
                        writer.WriteAttributeString("xmlns:targetNamespace", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/facturaElectronica");
                        writer.WriteAttributeString("xmlns:elementFormDefault", "qualified");
                        writer.WriteAttributeString("xmlns:attributeFormDefault", "unqualified");
                        writer.WriteAttributeString("xmlns:version", "4.3");
                        writer.WriteAttributeString("xmlns:vc:minVersion", "1.1");
                        */




                        // La clave se crea con la función CreaClave de la clase Datos
                        writer.WriteElementString("Clave", _numeroClave);
                        writer.WriteElementString("CodigoActividad", _emisor.codigoActividad.ToString().PadLeft(6, '0'));



                        // 'El numero de secuencia es de 20 caracteres, 
                        // 'Se debe de crear con la función CreaNumeroSecuencia de la clase Datos
                        writer.WriteElementString("NumeroConsecutivo", _numeroConsecutivo);

                        // 'El formato de la fecha es yyyy-MM-ddTHH:mm:sszzz
                        writer.WriteElementString("FechaEmision", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                        writer.WriteStartElement("Emisor");

                        writer.WriteElementString("Nombre", _emisor.Nombre);
                        writer.WriteStartElement("Identificacion");
                        writer.WriteElementString("Tipo", _emisor.Identificacion_Tipo);
                        writer.WriteElementString("Numero", _emisor.Identificacion_Numero);
                        writer.WriteEndElement(); // 'Identificacion

                        // '-----------------------------------
                        // 'Los datos de las ubicaciones los puede tomar de las tablas de datos, 
                        // 'Debe ser exacto al que hacienda tiene registrado para su compañia
                        writer.WriteStartElement("Ubicacion");
                        writer.WriteElementString("Provincia", _emisor.Ubicacion_Provincia);
                        writer.WriteElementString("Canton", _emisor.Ubicacion_Canton);
                        writer.WriteElementString("Distrito", _emisor.Ubicacion_Distrito);
                        writer.WriteElementString("Barrio", _emisor.Ubicacion_Barrio);
                        writer.WriteElementString("OtrasSenas", _emisor.Ubicacion_OtrasSenas);
                        writer.WriteEndElement(); // 'Ubicacion

                        writer.WriteStartElement("Telefono");
                        writer.WriteElementString("CodigoPais", _emisor.Telefono_CodigoPais);
                        writer.WriteElementString("NumTelefono", _emisor.Telefono_Numero.ToString());
                        writer.WriteEndElement(); // 'Telefono

                        writer.WriteElementString("CorreoElectronico", _emisor.CorreoElectronico);

                        writer.WriteEndElement(); // Emisor
                                                    // '------------------------------------
                                                    // 'Receptor es similar con emisor, los datos opcionales siempre siempre siempre omitirlos.
                        if (_receptor != null)
                        {
                            writer.WriteStartElement("Receptor");
                            writer.WriteElementString("Nombre", _receptor.Nombre);
                            writer.WriteStartElement("Identificacion");
                            // 'Los tipos de identificacion los puede ver en la tabla de datos
                            writer.WriteElementString("Tipo", _receptor.Identificacion_Tipo);
                            writer.WriteElementString("Numero", _receptor.Identificacion_Numero);
                            writer.WriteEndElement(); // 'Identificacion

                            //writer.WriteStartElement("Telefono");
                            //writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                            //writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                            //writer.WriteEndElement(); // 'Telefono

                            //writer.WriteStartElement("Fax");
                            //writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                            //writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                            //writer.WriteEndElement(); // 'Telefono

                            writer.WriteElementString("CorreoElectronico", _receptor.CorreoElectronico);

                            writer.WriteEndElement(); // Receptor

                        }

                        // 'Loa datos estan en la tabla correspondiente
                        writer.WriteElementString("CondicionVenta", _condicionVenta);
                        // '01: Contado
                        // '02: Credito
                        // '03: Consignación
                        // '04: Apartado
                        // '05: Arrendamiento con opcion de compra
                        // '06: Arrendamiento con función financiera
                        // '99: Otros

                        // 'Este dato se muestra si la condicion venta es credito
                        if (_condicionVenta == "02")
                        {
                            writer.WriteElementString("PlazoCredito", _plazoCredito);
                        }




                        writer.WriteElementString("MedioPago", _medioPago);
                // '01: Efectivo
                // '02: Tarjeta
                // '03: Cheque
                // '04: Transferecia - deposito bancario
                // '05: Recaudado por terceros            
                // '99: Otros

                writer.WriteStartElement("DetalleServicio");

                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    writer.WriteStartElement("LineaDetalle");

                    writer.WriteElementString("NumeroLinea", detalle.numLinea.ToString().Trim());

                    writer.WriteStartElement("CodigoComercial");
                    writer.WriteElementString("Tipo", "01");
                    writer.WriteElementString("Codigo", detalle.idProducto.ToString().Trim());
                    writer.WriteEndElement(); // 'codigo comercial

                   // int cant = (int)detalle.cantidad;//convierte entero, elimina decimales
                    writer.WriteElementString("Cantidad", String.Format("{0:N3}", detalle.cantidad.ToString()));
                    // 'Para las unidades de medida ver la tabla correspondiente
                    writer.WriteElementString("UnidadMedida", Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida));//nomenlatura kg etc

                    writer.WriteElementString("Detalle", detalle.tbProducto.nombre.ToString().Trim());


                    writer.WriteElementString("PrecioUnitario", String.Format("{0:N3}", detalle.precio.ToString().Trim()));
                    writer.WriteElementString("MontoTotal", String.Format("{0:N3}", detalle.montoTotal.ToString().Trim()));

                    if (detalle.montoTotalDesc != 0)
                    {


                        writer.WriteStartElement("Descuento");
                        writer.WriteElementString("MontoDescuento", String.Format("{0:N3}", detalle.montoTotalDesc.ToString().Trim()));
                        writer.WriteElementString("NaturalezaDescuento", "Descuento aplicado al cliente");//agregar naturaleza desc                        
                        writer.WriteEndElement(); // 'descuento

                    }
                    writer.WriteElementString("SubTotal", String.Format("{0:N3}", (detalle.montoTotal - detalle.montoTotalDesc).ToString().Trim()));

                    if (detalle.montoTotalImp != 0)
                    {

                        writer.WriteStartElement("Impuesto");
                        writer.WriteElementString("Codigo", detalle.tbProducto.tbImpuestos.id.ToString().PadLeft(2, '0'));// impueto aplicado codigo
                        writer.WriteElementString("CodigoTarifa", "08");
                        writer.WriteElementString("Tarifa", String.Format("{0:N3}", detalle.tbProducto.tbImpuestos.valor.ToString()));// %aplicado valor
                        writer.WriteElementString("Monto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));

                        if (detalle.montoTotalExo != 0)
                        {
                            writer.WriteStartElement("Exoneracion");
                            writer.WriteElementString("TipoDocuento", _receptor.tipoExoneracion.PadLeft(2, '0'));// impueto aplicado codigo
                            writer.WriteElementString("NumeroDocumento", _receptor.institucionExo);// impueto aplicado codigo

                            writer.WriteElementString("NombreInstitucion", _receptor.institucionExo);// impueto aplicado codigo
                            writer.WriteElementString("FechaEmision", _receptor.fechaEmisionExo.ToString("yyyy-MM-ddTHH:mm:sszzz"));// impueto aplicado codigo
                            writer.WriteElementString("PorcentajeExoneracion", _receptor.valorExo.ToString());// impueto aplicado codigo

                            writer.WriteElementString("MontoExoneracion", String.Format("{0:N3}", detalle.montoTotalExo.ToString().Trim()));// impueto aplicado codigo

                            writer.WriteEndElement(); // exoneracion
                        }

                        writer.WriteEndElement(); // Impuesto
                        writer.WriteElementString("ImpuestoNeto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));
                    }

                    writer.WriteElementString("MontoTotalLinea", String.Format("{0:N3}", detalle.totalLinea.ToString().Trim()));
                    writer.WriteEndElement(); // LineaDetalle
                }
                // '-------------------------------------

                writer.WriteEndElement(); // DetalleServicio

                writer.WriteStartElement("ResumenFactura");

                writer.WriteStartElement("CodigoTipoMoneda");
                writer.WriteElementString("CodigoMoneda", _codigoMoneda);

                if (_codigoMoneda.ToUpper().Trim() == "USD")
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", _empresa.tbParametrosEmpresa.First().cambioDolar.ToString().Trim()));

                }
                else
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", "1"));

                }
                writer.WriteEndElement(); // CodigoTipoMoneda



                decimal totalProdGravados = 0;
                decimal totalProdExcentos = 0;
                decimal totalSevGravados = 0;
                decimal totalServExcentos = 0;
                decimal totalServExonerado = 0;
                decimal totalProdExonerado = 0;

                decimal totalDescuento = 0;
                decimal totalComprobante = 0;
                decimal impuestos = 0;

                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    totalDescuento += detalle.montoTotalDesc;//total de decuento
                    totalComprobante += detalle.totalLinea;//total de comprobante


                    if (detalle.montoTotalImp == 0)//valida si exonera es 0, si tiene valor de impuesto no exonera
                    {//acumulo monto total, sin descuento. monto total es precio*cantidad
                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")//valida si es producto o servicio y acumula en su respectiva variable
                        {
                            totalServExonerado += detalle.montoTotalExo;
                            totalServExcentos += detalle.montoTotal;
                        }
                        else//si es producto
                        {
                            totalProdExonerado += detalle.montoTotalExo;
                            totalProdExcentos += detalle.montoTotal;

                        }


                    }
                    else
                    {
                        impuestos += detalle.montoTotalImp;

                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")
                        {//si tiene impuesto y es un servicio
                            totalServExonerado += detalle.montoTotalExo;
                            totalSevGravados += detalle.montoTotal;
                        }
                        else
                        {
                            totalProdExonerado += detalle.montoTotalExo;
                            totalProdGravados += detalle.montoTotal;//si es un prodcuto

                        }
                    }

                }

                writer.WriteElementString("TotalServGravados", String.Format("{0:N3}", totalSevGravados.ToString()));

                writer.WriteElementString("TotalServExentos", String.Format("{0:N3}", totalServExcentos.ToString()));

                writer.WriteElementString("TotalServExonerado", String.Format("{0:N3}", totalServExonerado.ToString()));

                writer.WriteElementString("TotalMercanciasGravadas", String.Format("{0:N3}", totalProdGravados.ToString()));

                writer.WriteElementString("TotalMercanciasExentas", String.Format("{0:N3}", totalProdExcentos.ToString()));

                writer.WriteElementString("TotalMercExonerada", String.Format("{0:N3}", totalProdExonerado.ToString()));

                decimal totalGravados = totalSevGravados + totalProdGravados;
                decimal totalExentos = totalProdExcentos + totalServExcentos;
                decimal totalExo = totalProdExonerado + totalServExonerado;

                writer.WriteElementString("TotalGravado", String.Format("{0:N3}", totalGravados.ToString()));

                writer.WriteElementString("TotalExento", String.Format("{0:N3}", totalExentos.ToString()));

                writer.WriteElementString("TotalExonerado", String.Format("{0:N3}", totalExo.ToString()));

                decimal totalVenta = totalGravados + totalExentos + totalExo;//total de venta, gravados y exonerados
                decimal totalVentaNeta = totalVenta - totalDescuento;//calula el monto de descuento

                writer.WriteElementString("TotalVenta", String.Format("{0:N3}", totalVenta.ToString()));

                writer.WriteElementString("TotalDescuentos", String.Format("{0:N3}", totalDescuento.ToString()));

                writer.WriteElementString("TotalVentaNeta", String.Format("{0:N3}", totalVentaNeta.ToString()));

                writer.WriteElementString("TotalImpuesto", String.Format("{0:N3}", impuestos.ToString()));

                writer.WriteElementString("TotalComprobante", String.Format("{0:N3}", totalComprobante.ToString()));
                writer.WriteEndElement(); // ResumenFactura


                // 'Estos datos te los tiene que brindar los encargados del area financiera
                //writer.WriteStartElement("Normativa");
                //writer.WriteElementString("NumeroResolucion", _empresa.numeroResolucion.Trim());
                //writer.WriteElementString("FechaResolucion", ((DateTime)_empresa.fechaResolucio).ToString("dd-MM-yyyy HH:MM:ss"));
                //writer.WriteEndElement(); // Normativa

                writer.WriteStartElement("InformacionReferencia");//referencia
                        writer.WriteElementString("TipoDoc", _doc.tipoDocRef.ToString().PadLeft(2, '0'));
                        writer.WriteElementString("Numero", _doc.claveRef);
                        writer.WriteElementString("FechaEmision", _doc.fechaRef.Value.ToString("yyyy-MM-ddTHH:mm:sszzz"));
                        writer.WriteElementString("Codigo", _doc.codigoRef.ToString().PadLeft(2, '0'));
                        writer.WriteElementString("Razon", _doc.razon.ToUpper().Substring(0, 180).Trim());
                        writer.WriteEndElement(); // referencia


                        if (_doc.observaciones != null && _doc.observaciones.Trim() != string.Empty)
                        {
                            //otros
                            writer.WriteStartElement("Otros");
                            writer.WriteElementString("OtroTexto", _doc.observaciones.Substring(0, 180).Trim());
                            writer.WriteEndElement();//Otros
                        }
                
                        // 'Aqui va la firma, despues la agregamos.

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Flush();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                private void GeneraXMLMensajeHacienda4_3(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
                {
                    try
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("MensajeHacienda");

                        writer.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/mensajeHacienda");
                        writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                        writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                        writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");


                        // La clave se crea con la función CreaClave de la clase Datos
                        writer.WriteElementString("Clave", _mensajeHacienda.claveDocEmisor);

                        //EMISOR
                        writer.WriteElementString("NombreEmisor", _mensajeHacienda.nombreEmisor.Trim());
                        writer.WriteElementString("TipoIdentificacionEmisor", _mensajeHacienda.tipoIdEmisor.ToString().Trim());
                        writer.WriteElementString("NumeroCedulaEmisor", _mensajeHacienda.idEmisor.Trim());


                        //RECEPTOR
                        writer.WriteElementString("NombreReceptor", _mensajeHacienda.nombreReceptor.Trim());//nombre
                        writer.WriteElementString("TipoIdentificacionReceptor", _mensajeHacienda.tipoIdEmpresa.ToString().Trim());
                        writer.WriteElementString("NumeroCedulaReceptor", _mensajeHacienda.idEmpresa.Trim());


                        //MENSAJE HACIENDA
                        writer.WriteElementString("Mensaje", _mensajeHacienda.estadoRecibido.ToString());
                        if (_mensajeHacienda.razon != null)
                        {
                            writer.WriteElementString("DetalleMensaje", _mensajeHacienda.razon.ToString());
                        }              
               

                        //IMPUESTOS
                      
                            writer.WriteElementString("MontoTotalImpuesto", String.Format("{0:N3}", _mensajeHacienda.totalImp.ToString().Trim()));


                       
                        //TOTAL DE FACTURA
                        writer.WriteElementString("TotalFactura", String.Format("{0:N3}", _mensajeHacienda.totalFactura.ToString().Trim()));

                                                             
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Flush();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
        private void GeneraXMLReceptorHacienda4_3(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("MensajeReceptor");

                writer.WriteAttributeString("xmlns", "https://cdn.comprobanteselectronicos.go.cr/xml-schemas/v4.3/mensajeReceptor");
                writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");



                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _mensajeHacienda.claveDocEmisor);
             
                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("NumeroCedulaEmisor", _mensajeHacienda.idEmisor.Trim());
                writer.WriteElementString("FechaEmisionDoc", _mensajeHacienda.fechaEmision.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteElementString("Mensaje", _mensajeHacienda.estadoRecibido.ToString());
                if (_mensajeHacienda.estadoRecibido !=1)
                {
                    writer.WriteElementString("DetalleMensaje", _mensajeHacienda.razon.ToString());
                }
               writer.WriteElementString("MontoTotalImpuesto", String.Format("{0:N3}", _mensajeHacienda.totalImp.ToString().Trim()));
               writer.WriteElementString("CodigoActividad", _mensajeHacienda.codigoActividadEmisor);

                writer.WriteElementString("TotalFactura", String.Format("{0:N3}", _mensajeHacienda.totalFactura.ToString().Trim()));


                writer.WriteElementString("NumeroCedulaReceptor", _mensajeHacienda.idEmpresa.Trim());
                writer.WriteElementString("NumeroConsecutivoReceptor", _mensajeHacienda.consecutivoReceptor.Trim());

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region 4.3

        private void GeneraXMLMensajeHacienda(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("MensajeReceptor");

                writer.WriteAttributeString("xmlns", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/mensajeReceptor");
                writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");


                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _mensajeHacienda.claveDocEmisor);

                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("NumeroCedulaEmisor", _mensajeHacienda.idEmisor.Trim());
                writer.WriteElementString("FechaEmisionDoc", _mensajeHacienda.fechaEmision.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteElementString("Mensaje", _mensajeHacienda.estadoRecibido.ToString());

                if (_mensajeHacienda.totalImp != 0)
                {
                    writer.WriteElementString("MontoTotalImpuesto", String.Format("{0:N3}", _mensajeHacienda.totalImp.ToString().Trim()));


                }

                writer.WriteElementString("TotalFactura", String.Format("{0:N3}", _mensajeHacienda.totalFactura.ToString().Trim()));


                writer.WriteElementString("NumeroCedulaReceptor", _mensajeHacienda.idEmpresa.Trim());
                writer.WriteElementString("NumeroConsecutivoReceptor", _mensajeHacienda.consecutivoReceptor.Trim());

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GeneraXMLFacturaElectronica(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("FacturaElectronica");

                writer.WriteAttributeString("xmlns", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/facturaElectronica");
                writer.WriteAttributeString("xmlns:ds", "http://www.w3.org/2000/09/xmldsig#");
                writer.WriteAttributeString("xmlns:vc", "http://www.w3.org/2007/XMLSchema-versioning");
                writer.WriteAttributeString("xmlns:xs", "http://www.w3.org/2001/XMLSchema");

                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _numeroClave);

                // 'El numero de secuencia es de 20 caracteres, 
                // 'Se debe de crear con la función CreaNumeroSecuencia de la clase Datos
                writer.WriteElementString("NumeroConsecutivo", _numeroConsecutivo);

                // 'El formato de la fecha es yyyy-MM-ddTHH:mm:sszzz
                writer.WriteElementString("FechaEmision", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteStartElement("Emisor");

                writer.WriteElementString("Nombre", _emisor.Nombre);
                writer.WriteStartElement("Identificacion");
                writer.WriteElementString("Tipo", _emisor.Identificacion_Tipo);
                writer.WriteElementString("Numero", _emisor.Identificacion_Numero);
                writer.WriteEndElement(); // 'Identificacion

                // '-----------------------------------
                // 'Los datos de las ubicaciones los puede tomar de las tablas de datos, 
                // 'Debe ser exacto al que hacienda tiene registrado para su compañia
                writer.WriteStartElement("Ubicacion");
                writer.WriteElementString("Provincia", _emisor.Ubicacion_Provincia);
                writer.WriteElementString("Canton", _emisor.Ubicacion_Canton);
                writer.WriteElementString("Distrito", _emisor.Ubicacion_Distrito);
                writer.WriteElementString("Barrio", _emisor.Ubicacion_Barrio);
                writer.WriteElementString("OtrasSenas", _emisor.Ubicacion_OtrasSenas);
                writer.WriteEndElement(); // 'Ubicacion

                writer.WriteStartElement("Telefono");
                writer.WriteElementString("CodigoPais", _emisor.Telefono_CodigoPais);
                writer.WriteElementString("NumTelefono", _emisor.Telefono_Numero.ToString());
                writer.WriteEndElement(); // 'Telefono

                writer.WriteElementString("CorreoElectronico", _emisor.CorreoElectronico);

                writer.WriteEndElement(); // Emisor
                                          // '------------------------------------
                                          // 'Receptor es similar con emisor, los datos opcionales siempre siempre siempre omitirlos.
                if (_receptor != null)
                {
                    writer.WriteStartElement("Receptor");
                    writer.WriteElementString("Nombre", _receptor.Nombre);
                    writer.WriteStartElement("Identificacion");
                    // 'Los tipos de identificacion los puede ver en la tabla de datos
                    writer.WriteElementString("Tipo", _receptor.Identificacion_Tipo);
                    writer.WriteElementString("Numero", _receptor.Identificacion_Numero);
                    writer.WriteEndElement(); // 'Identificacion

                    //writer.WriteStartElement("Telefono");
                    //writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                    //writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                    //writer.WriteEndElement(); // 'Telefono

                    writer.WriteElementString("CorreoElectronico", _receptor.CorreoElectronico);

                    writer.WriteEndElement(); // Receptor

                }

                // 'Loa datos estan en la tabla correspondiente
                writer.WriteElementString("CondicionVenta", _condicionVenta);
                // '01: Contado
                // '02: Credito
                // '03: Consignación
                // '04: Apartado
                // '05: Arrendamiento con opcion de compra
                // '06: Arrendamiento con función financiera
                // '99: Otros

                // 'Este dato se muestra si la condicion venta es credito

                writer.WriteElementString("PlazoCredito", _plazoCredito);



                writer.WriteElementString("MedioPago", _medioPago);
                // '01: Efectivo
                // '02: Tarjeta
                // '03: Cheque
                // '04: Transferecia - deposito bancario
                // '05: Recaudado por terceros            
                // '99: Otros

                writer.WriteStartElement("DetalleServicio");
                //-----variables resumes de montos pagados


                // '-------------------------------------
                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    writer.WriteStartElement("LineaDetalle");

                    writer.WriteElementString("NumeroLinea", detalle.numLinea.ToString().Trim());

                    writer.WriteStartElement("Codigo");
                    writer.WriteElementString("Tipo", "01");//codigo del prodcuto del vendedor nota 12.
                    writer.WriteElementString("Codigo", detalle.idProducto.ToString().Trim());
                    writer.WriteEndElement(); // 'Codigo

                    int cant = (int)detalle.cantidad;//convierte entero, elimina decimales
                    writer.WriteElementString("Cantidad", cant.ToString());
                    // 'Para las unidades de medida ver la tabla correspondiente
                    writer.WriteElementString("UnidadMedida", Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida));//nomenlatura kg etc

                    writer.WriteElementString("Detalle", detalle.tbProducto.nombre.ToString().Trim());


                    writer.WriteElementString("PrecioUnitario", String.Format("{0:N3}", detalle.precio.ToString().Trim()));
                    writer.WriteElementString("MontoTotal", String.Format("{0:N3}", detalle.montoTotal.ToString().Trim()));
                    writer.WriteElementString("MontoDescuento", String.Format("{0:N3}", detalle.montoTotalDesc.ToString().Trim()));


                    if (detalle.montoTotalDesc == 0)
                    {

                        writer.WriteElementString("NaturalezaDescuento", "Sin descuento");//agregar naturaleza desc
                    }
                    else
                    {
                        writer.WriteElementString("NaturalezaDescuento", "Descuento aplicado al cliente");//agregar naturaleza desc
                    }

                    writer.WriteElementString("SubTotal", String.Format("{0:N3}", (detalle.montoTotal - detalle.montoTotalDesc).ToString().Trim()));




                    if (detalle.montoTotalImp != 0)
                    {

                        writer.WriteStartElement("Impuesto");
                        writer.WriteElementString("Codigo", detalle.tbProducto.tbImpuestos.id.ToString().PadLeft(2, '0'));// impueto aplicado codigo
                        writer.WriteElementString("Tarifa", detalle.tbProducto.tbImpuestos.valor.ToString());// %aplicado valor
                        writer.WriteElementString("Monto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));
                        writer.WriteEndElement(); // Impuesto
                    }



                    //if (!detalle.tbProducto.esExento)
                    //{
                    //    if (detalle.tbProducto.tbTipoMedidas.nomenclatura.ToUpper().Trim() == "SP")
                    //    {
                    //        if (detalle.montoTotalImp==0)
                    //        {

                    //            totalSevGravados += detalle.montoTotal;
                    //        }
                    //        else
                    //        {
                    //            totalSevGravados += detalle.montoTotal-detalle.montoTotalExo;
                    //        }


                    //    }
                    //    else
                    //    {
                    //        totalProdGravados += detalle.montoTotalExo;
                    //    }
                    //    impuestos += detalle.montoTotalImp;
                    //    exoneracion += detalle.montoTotalExo;

                    //}
                    //else
                    //{
                    //    if (detalle.tbProducto.tbTipoMedidas.nomenclatura.ToUpper().Trim()=="SP")
                    //    {
                    //        totalServExcentos += detalle.montoTotal;

                    //    }
                    //    else
                    //    {
                    //        totalProdExcentos += detalle.montoTotal;
                    //    }

                    //}


                    writer.WriteElementString("MontoTotalLinea", String.Format("{0:N3}", detalle.totalLinea.ToString().Trim()));

                    writer.WriteEndElement(); // LineaDetalle
                }
                // '-------------------------------------

                writer.WriteEndElement(); // DetalleServicio


                writer.WriteStartElement("ResumenFactura");

                // Estos campos son opcionales, solo fin desea facturar en dólares
                writer.WriteElementString("CodigoMoneda", _codigoMoneda);
                if (_codigoMoneda.ToUpper().Trim() == "USD")
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", _empresa.tbParametrosEmpresa.First().cambioDolar.ToString().Trim()));

                }
                else
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", "1"));

                }
                // =================

                // 'En esta parte los totales se pueden ir sumando linea a linea cuando se carga el detalle
                // 'ó se pasa como parametros al inicio


                decimal totalProdGravados = 0;
                decimal totalProdExcentos = 0;
                decimal totalSevGravados = 0;
                decimal totalServExcentos = 0;
                decimal totalDescuento = 0;
                decimal totalComprobante = 0;
                decimal impuestos = 0;

                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    totalDescuento += detalle.montoTotalDesc;//total de decuento
                    totalComprobante += detalle.totalLinea;//total de comprobante


                    if (detalle.montoTotalImp == 0)//valida si exonera es 0, si tiene valor de impuesto no exonera
                    {//acumulo monto total, sin descuento. monto total es precio*cantidad
                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")//valida si es producto o servicio y acumula en su respectiva variable
                        {

                            totalServExcentos += detalle.montoTotal;
                        }
                        else//si es producto
                        {

                            totalProdExcentos += detalle.montoTotal;

                        }


                    }
                    else
                    {
                        impuestos += detalle.montoTotalImp;

                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")
                        {//si tiene impuesto y es un servicio

                            totalSevGravados += detalle.montoTotal;
                        }
                        else
                        {

                            totalProdGravados += detalle.montoTotal;//si es un prodcuto

                        }


                    }



                }
                writer.WriteElementString("TotalServGravados", String.Format("{0:N3}", totalSevGravados.ToString()));
                writer.WriteElementString("TotalServExentos", String.Format("{0:N3}", totalServExcentos.ToString()));

                writer.WriteElementString("TotalMercanciasGravadas", String.Format("{0:N3}", totalProdGravados.ToString()));
                writer.WriteElementString("TotalMercanciasExentas", String.Format("{0:N3}", totalProdExcentos.ToString()));

                decimal totalGravados = totalSevGravados + totalProdGravados;
                decimal totalExentos = totalProdExcentos + totalServExcentos;

                writer.WriteElementString("TotalGravado", String.Format("{0:N3}", totalGravados.ToString()));
                writer.WriteElementString("TotalExento", String.Format("{0:N3}", totalExentos.ToString()));

                decimal totalVenta = totalGravados + totalExentos;//total de venta, gravados y exonerados
                decimal totalVentaNeta = totalVenta - totalDescuento;//calula el monto de descuento
                writer.WriteElementString("TotalVenta", String.Format("{0:N3}", totalVenta.ToString()));
                writer.WriteElementString("TotalDescuentos", String.Format("{0:N3}", totalDescuento.ToString()));
                writer.WriteElementString("TotalVentaNeta", String.Format("{0:N3}", totalVentaNeta.ToString()));
                if (totalGravados != 0)
                {
                    writer.WriteElementString("TotalImpuesto", String.Format("{0:N3}", impuestos.ToString()));
                }

                writer.WriteElementString("TotalComprobante", String.Format("{0:N3}", totalComprobante.ToString()));
                writer.WriteEndElement(); // ResumenFactura

                // 'Estos datos te los tiene que brindar los encargados del area financiera
                writer.WriteStartElement("Normativa");
                writer.WriteElementString("NumeroResolucion", _empresa.numeroResolucion.Trim());
                writer.WriteElementString("FechaResolucion", ((DateTime)_empresa.fechaResolucio).ToString("dd-MM-yyyy HH:MM:ss"));
                writer.WriteEndElement(); // Normativa

                if (_doc.observaciones != null && _doc.observaciones.Trim() != string.Empty)
                {
                    //otros
                    writer.WriteStartElement("Otros");
                    writer.WriteElementString("OtroTexto", _doc.observaciones.Substring(0, 180).Trim());
                    writer.WriteEndElement();//Otros
                }

                // 'Aqui va la firma, despues la agregamos.

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void GeneraXMLNotaCredito(System.Xml.XmlTextWriter writer) // As System.Xml.XmlTextWriter
        {
            try
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("NotaCreditoElectronica");

                writer.WriteAttributeString("xmlns", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/notaCreditoElectronica");
                writer.WriteAttributeString("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
                writer.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("xsi:schemaLocation", "https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/notaCreditoElectronica https://tribunet.hacienda.go.cr/docs/esquemas/2017/v4.2/notaCreditoElectronica.xsd");

                // La clave se crea con la función CreaClave de la clase Datos
                writer.WriteElementString("Clave", _numeroClave);

                // 'El numero de secuencia es de 20 caracteres, 
                // 'Se debe de crear con la función CreaNumeroSecuencia de la clase Datos
                writer.WriteElementString("NumeroConsecutivo", _numeroConsecutivo);

                // 'El formato de la fecha es yyyy-MM-ddTHH:mm:sszzz
                writer.WriteElementString("FechaEmision", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz"));

                writer.WriteStartElement("Emisor");

                writer.WriteElementString("Nombre", _emisor.Nombre);
                writer.WriteStartElement("Identificacion");
                writer.WriteElementString("Tipo", _emisor.Identificacion_Tipo);
                writer.WriteElementString("Numero", _emisor.Identificacion_Numero);
                writer.WriteEndElement(); // 'Identificacion

                // '-----------------------------------
                // 'Los datos de las ubicaciones los puede tomar de las tablas de datos, 
                // 'Debe ser exacto al que hacienda tiene registrado para su compañia
                writer.WriteStartElement("Ubicacion");
                writer.WriteElementString("Provincia", _emisor.Ubicacion_Provincia);
                writer.WriteElementString("Canton", _emisor.Ubicacion_Canton);
                writer.WriteElementString("Distrito", _emisor.Ubicacion_Distrito);
                writer.WriteElementString("Barrio", _emisor.Ubicacion_Barrio);
                writer.WriteElementString("OtrasSenas", _emisor.Ubicacion_OtrasSenas);
                writer.WriteEndElement(); // 'Ubicacion

                writer.WriteStartElement("Telefono");
                writer.WriteElementString("CodigoPais", _emisor.Telefono_CodigoPais);
                writer.WriteElementString("NumTelefono", _emisor.Telefono_Numero.ToString());
                writer.WriteEndElement(); // 'Telefono

                writer.WriteElementString("CorreoElectronico", _emisor.CorreoElectronico);

                writer.WriteEndElement(); // Emisor
                                          // '------------------------------------
                                          // 'Receptor es similar con emisor, los datos opcionales siempre siempre siempre omitirlos.
                                          // 'La ubicacion para el receptor es opcional por ejemplo
                if (_receptor != null)
                {
                    writer.WriteStartElement("Receptor");
                    writer.WriteElementString("Nombre", _receptor.Nombre);
                    writer.WriteStartElement("Identificacion");
                    // 'Los tipos de identificacion los puede ver en la tabla de datos
                    writer.WriteElementString("Tipo", _receptor.Identificacion_Tipo);
                    writer.WriteElementString("Numero", _receptor.Identificacion_Numero);
                    writer.WriteEndElement(); // 'Identificacion

                    //writer.WriteStartElement("Telefono");
                    //writer.WriteElementString("CodigoPais", _receptor.Telefono_CodigoPais);
                    //writer.WriteElementString("NumTelefono", _receptor.Telefono_Numero.ToString());
                    //writer.WriteEndElement(); // 'Telefono

                    writer.WriteElementString("CorreoElectronico", _receptor.CorreoElectronico);

                    writer.WriteEndElement(); // Receptor

                }

                // 'Loa datos estan en la tabla correspondiente
                writer.WriteElementString("CondicionVenta", _condicionVenta);
                // '01: Contado
                // '02: Credito
                // '03: Consignación
                // '04: Apartado
                // '05: Arrendamiento con opcion de compra
                // '06: Arrendamiento con función financiera
                // '99: Otros

                // 'Este dato se muestra si la condicion venta es credito

                writer.WriteElementString("PlazoCredito", _plazoCredito);



                writer.WriteElementString("MedioPago", _medioPago);
                // '01: Efectivo
                // '02: Tarjeta
                // '03: Cheque
                // '04: Transferecia - deposito bancario
                // '05: Recaudado por terceros            
                // '99: Otros

                writer.WriteStartElement("DetalleServicio");
                //-----variables resumes de montos pagados


                // '-------------------------------------
                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    writer.WriteStartElement("LineaDetalle");

                    writer.WriteElementString("NumeroLinea", detalle.numLinea.ToString().Trim());

                    //writer.WriteStartElement("Codigo");
                    //writer.WriteElementString("Tipo", "01");//codigo del prodcuto del vendedor nota 12.
                    //writer.WriteElementString("Codigo", detalle.idProducto.ToString().Trim());
                    //writer.WriteEndElement(); // 'Codigo

                    int cant = (int)detalle.cantidad;//convierte entero, elimina decimales
                    writer.WriteElementString("Cantidad", cant.ToString());
                    // 'Para las unidades de medida ver la tabla correspondiente
                    writer.WriteElementString("UnidadMedida", Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida));//nomenlatura kg etc

                    writer.WriteElementString("Detalle", detalle.tbProducto.nombre.ToString().Trim());


                    writer.WriteElementString("PrecioUnitario", String.Format("{0:N3}", detalle.precio.ToString().Trim()));
                    writer.WriteElementString("MontoTotal", String.Format("{0:N3}", detalle.montoTotal.ToString().Trim()));
                    writer.WriteElementString("MontoDescuento", String.Format("{0:N3}", detalle.montoTotalDesc.ToString().Trim()));


                    if (detalle.montoTotalDesc == 0)
                    {

                        writer.WriteElementString("NaturalezaDescuento", "Sin descuento");//agregar naturaleza desc
                    }
                    else
                    {
                        writer.WriteElementString("NaturalezaDescuento", "Descuento aplicado al cliente");//agregar naturaleza desc
                    }

                    writer.WriteElementString("SubTotal", String.Format("{0:N3}", (detalle.montoTotal - detalle.montoTotalDesc).ToString().Trim()));




                    if (detalle.montoTotalImp != 0)
                    {

                        writer.WriteStartElement("Impuesto");
                        writer.WriteElementString("Codigo", detalle.tbProducto.tbImpuestos.id.ToString().PadLeft(2, '0'));// impueto aplicado codigo
                        writer.WriteElementString("Tarifa", detalle.tbProducto.tbImpuestos.valor.ToString());// %aplicado valor
                        writer.WriteElementString("Monto", String.Format("{0:N3}", (detalle.montoTotalImp).ToString().Trim()));
                        writer.WriteEndElement(); // Impuesto
                    }



                    //if (!detalle.tbProducto.esExento)
                    //{
                    //    if (detalle.tbProducto.tbTipoMedidas.nomenclatura.ToUpper().Trim() == "SP")
                    //    {
                    //        if (detalle.montoTotalImp==0)
                    //        {

                    //            totalSevGravados += detalle.montoTotal;
                    //        }
                    //        else
                    //        {
                    //            totalSevGravados += detalle.montoTotal-detalle.montoTotalExo;
                    //        }


                    //    }
                    //    else
                    //    {
                    //        totalProdGravados += detalle.montoTotalExo;
                    //    }
                    //    impuestos += detalle.montoTotalImp;
                    //    exoneracion += detalle.montoTotalExo;

                    //}
                    //else
                    //{
                    //    if (detalle.tbProducto.tbTipoMedidas.nomenclatura.ToUpper().Trim()=="SP")
                    //    {
                    //        totalServExcentos += detalle.montoTotal;

                    //    }
                    //    else
                    //    {
                    //        totalProdExcentos += detalle.montoTotal;
                    //    }

                    //}


                    writer.WriteElementString("MontoTotalLinea", String.Format("{0:N3}", detalle.totalLinea.ToString().Trim()));

                    writer.WriteEndElement(); // LineaDetalle
                }
                // '-------------------------------------

                writer.WriteEndElement(); // DetalleServicio


                writer.WriteStartElement("ResumenFactura");

                // Estos campos son opcionales, solo fin desea facturar en dólares
                writer.WriteElementString("CodigoMoneda", _codigoMoneda);
                if (_codigoMoneda.ToUpper().Trim() == "USD")
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", _empresa.tbParametrosEmpresa.First().cambioDolar.ToString().Trim()));

                }
                else
                {
                    writer.WriteElementString("TipoCambio", String.Format("{0:N3}", "1"));

                }
                // =================

                // 'En esta parte los totales se pueden ir sumando linea a linea cuando se carga el detalle
                // 'ó se pasa como parametros al inicio


                decimal totalProdGravados = 0;
                decimal totalProdExcentos = 0;
                decimal totalSevGravados = 0;
                decimal totalServExcentos = 0;
                decimal totalDescuento = 0;
                decimal totalComprobante = 0;
                decimal impuestos = 0;

                foreach (tbDetalleDocumento detalle in _listaDetalle)
                {
                    totalDescuento += detalle.montoTotalDesc;//total de decuento
                    totalComprobante += detalle.totalLinea;//total de comprobante


                    if (detalle.montoTotalImp == 0)//valida si exonera es 0, si tiene valor de impuesto no exonera
                    {//acumulo monto total, sin descuento. monto total es precio*cantidad
                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")//valida si es producto o servicio y acumula en su respectiva variable
                        {

                            totalServExcentos += detalle.montoTotal;
                        }
                        else//si es producto
                        {

                            totalProdExcentos += detalle.montoTotal;

                        }


                    }
                    else
                    {
                        impuestos += detalle.montoTotalImp;

                        if (Enum.GetName(typeof(Enums.TipoMedida), detalle.tbProducto.idMedida).Trim().ToUpper() == "SP")
                        {//si tiene impuesto y es un servicio

                            totalSevGravados += detalle.montoTotal;
                        }
                        else
                        {

                            totalProdGravados += detalle.montoTotal;//si es un prodcuto

                        }


                    }



                }
                writer.WriteElementString("TotalServGravados", String.Format("{0:N3}", totalSevGravados.ToString()));
                writer.WriteElementString("TotalServExentos", String.Format("{0:N3}", totalServExcentos.ToString()));

                writer.WriteElementString("TotalMercanciasGravadas", String.Format("{0:N3}", totalProdGravados.ToString()));
                writer.WriteElementString("TotalMercanciasExentas", String.Format("{0:N3}", totalProdExcentos.ToString()));

                decimal totalGravados = totalSevGravados + totalProdGravados;
                decimal totalExentos = totalProdExcentos + totalServExcentos;

                writer.WriteElementString("TotalGravado", String.Format("{0:N3}", totalGravados.ToString()));
                writer.WriteElementString("TotalExento", String.Format("{0:N3}", totalExentos.ToString()));

                decimal totalVenta = totalGravados + totalExentos;//total de venta, gravados y exonerados
                decimal totalVentaNeta = totalVenta - totalDescuento;//calula el monto de descuento
                writer.WriteElementString("TotalVenta", String.Format("{0:N3}", totalVenta.ToString()));
                writer.WriteElementString("TotalDescuentos", String.Format("{0:N3}", totalDescuento.ToString()));
                writer.WriteElementString("TotalVentaNeta", String.Format("{0:N3}", totalVentaNeta.ToString()));
                if (totalGravados != 0)
                {
                    writer.WriteElementString("TotalImpuesto", String.Format("{0:N3}", impuestos.ToString()));
                }

                writer.WriteElementString("TotalComprobante", String.Format("{0:N3}", totalComprobante.ToString()));
                writer.WriteEndElement(); // ResumenFactura


                writer.WriteStartElement("InformacionReferencia");//referencia
                writer.WriteElementString("TipoDoc", _doc.tipoDocRef.ToString().PadLeft(2, '0'));
                writer.WriteElementString("Numero", _doc.claveRef);
                writer.WriteElementString("FechaEmision", _doc.fechaRef.Value.ToString("yyyy-MM-ddTHH:mm:sszzz"));
                writer.WriteElementString("Codigo", _doc.codigoRef.ToString().PadLeft(2, '0'));
                writer.WriteElementString("Razon", _doc.razon.ToUpper().Substring(0, 180).Trim());
                writer.WriteEndElement(); // referencia


                // 'Estos datos te los tiene que brindar los encargados del area financiera
                writer.WriteStartElement("Normativa");
                writer.WriteElementString("NumeroResolucion", _empresa.numeroResolucion.Trim());
                writer.WriteElementString("FechaResolucion", ((DateTime)_empresa.fechaResolucio).ToString("dd-MM-yyyy HH:MM:ss"));
                writer.WriteEndElement(); // Normativa

                // 'Aqui va la firma, despues la agregamos.

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }

}
