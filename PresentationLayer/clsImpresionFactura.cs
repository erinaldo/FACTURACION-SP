﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;

using EntityLayer;
using BusinessLayer;
using PresentationLayer.Reportes;
using CommonLayer;
using System.Data.SqlClient;
using System.Data;

namespace PresentationLayer
{
    public class clsImpresionFactura
    {
        BCanton cantonIns = new BCanton();
        tbCanton _canton { set; get; }
        decimal _paga { set; get; }
        decimal _vuelto { set; get; }
        tbDocumento _doc { set; get; }
        tbClientes _cliente { set; get; }
        tbEmpresa _empresa { set; get; }
        List<tbDocumento> _docs { set; get; }
        decimal _saldo { set; get; }
        string _clienteSimplificada { set; get; }


        public clsImpresionFactura(List<tbDocumento> docs, tbClientes cliente, tbEmpresa empresa, decimal saldoPend)
        {
            _docs = docs;
            _empresa = empresa;
            _cliente = cliente;
            _saldo = saldoPend;

        }
        public clsImpresionFactura(tbDocumento doc, tbEmpresa empresa)
        {
            _doc = doc;
            _empresa = empresa;
          
        }    

        public clsImpresionFactura(tbDocumento doc, tbEmpresa empresa, decimal paga, decimal vuelto)
        {
            _doc = doc;
            _empresa = empresa;
            _paga = paga;
            _vuelto = vuelto;
            _canton = cantonIns.GetEntity(_empresa.tbPersona.canton, _empresa.tbPersona.provincia);
        }

        public clsImpresionFactura(tbDocumento doc, tbEmpresa empresa, decimal paga, decimal vuelto, string cliente)
        {
            _doc = doc;
            _empresa = empresa;
            _paga = paga;
            _vuelto = vuelto;
            _canton = cantonIns.GetEntity(_empresa.tbPersona.canton, _empresa.tbPersona.provincia);
            _clienteSimplificada= cliente;
        }


        public void print()
        {
            //imprimir documentos que no son abono
            if (_docs == null)
            {
                if (_doc.tipoDocumento == (int)Enums.TipoDocumento.FacturaElectronica || _doc.tipoDocumento == (int)Enums.TipoDocumento.TiqueteElectronico)
                {
                    if (_doc.tipoVenta == (int)Enums.tipoVenta.Credito)
                    {

                        printPuntoVenta();
                    }
                    else
                    {
                        printPuntoVenta();
                    }

                }
                else if (_doc.tipoDocumento == (int)Enums.TipoDocumento.NotaCreditoElectronica || _doc.tipoDocumento == (int)Enums.TipoDocumento.NotaDebitoElectronica)
                {
                    printMediaCarta();

                }
                else if (_doc.tipoDocumento == (int)Enums.TipoDocumento.Proforma)
                {
                    printMediaCarta();

                }
            }
            else
            {
                //imprimeAbono
                printPuntoVentaAbono();


            }
           


        }

        private void printPuntoVentaAbono()
        {
            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.AbreCajon();  //abre el cajon
            string nombreEmpresa = string.Empty;
            string nombreComercial = string.Empty;
            if (Global.actividadEconomic.nombreComercial != null)
            {
                nombreComercial = Global.actividadEconomic.nombreComercial.Trim().ToUpper();
            }

            if (_empresa.tipoId == (int)Enums.TipoId.Fisica)
            {
                nombreEmpresa = _empresa.tbPersona.nombre.ToUpper().ToString().Trim() + " " +
                        _empresa.tbPersona.apellido1.ToUpper().ToString().Trim() + " " + _empresa.tbPersona.apellido2.ToUpper().ToString().Trim();
            }
            else
            {
                nombreEmpresa = _doc.tbClientes.tbPersona.nombre.ToUpper().ToString().Trim();

            }


            if (nombreComercial != string.Empty)
            {
                Ticket1.TextoCentro(nombreComercial);
            }
            Ticket1.TextoCentro(nombreEmpresa);
            Ticket1.TextoCentro(_empresa.tbPersona.tbBarrios.tbDistrito.Nombre.Trim().ToUpper() + "-" + _empresa.tbPersona.tbBarrios.tbDistrito.tbCanton.Nombre.Trim().ToUpper() + "-" + _empresa.tbPersona.tbBarrios.tbDistrito.tbCanton.tbProvincia.Nombre.Trim().ToUpper());
            Ticket1.TextoCentro((_empresa.tipoId == (int)Enums.TipoId.Fisica ? "Ced Fisica:" : "Ced Juridica:") + _empresa.tbPersona.identificacion.ToString().Trim());
            Ticket1.TextoCentro("Tel:" + _empresa.tbPersona.telefono.ToString());         
            Ticket1.TextoIzquierda("Fecha:" + Utility.getDate());           
            Ticket1.TextoCentro("");
            Ticket1.TextoCentro("ABONOS");   
            Ticket1.TextoCentro("");
            if (_cliente.id != null)
            {

                string nombre = "";
                string id = _cliente.tbPersona.identificacion.ToString().Trim();
                if (_cliente.tbPersona.tipoId == (int)Enums.TipoId.Fisica)
                {

                    nombre = _cliente.tbPersona.nombre.ToUpper().ToString().Trim() + " " +
                       _cliente.tbPersona.apellido1.ToUpper().ToString().Trim() + " " + _cliente.tbPersona.apellido2.ToUpper().ToString().Trim();
                }
                else
                {
                    nombre = _cliente.tbPersona.nombre.ToUpper().ToString().Trim();
                }
                Ticket1.TextoIzquierda("ID Cliente:" + id);
                Ticket1.TextoIzquierda("Cliente:" + nombre);

            }

            Ticket1.LineasGuion(); // imprime una linea de guiones
            decimal totalAbonos = 0;
            foreach (var abono in _docs)
            {
                Ticket1.TextoIzquierda("# Factura:" + abono.id);
                Ticket1.TextoIzquierda("Monto abonado:" + abono.tbAbonos.Last().monto);
                totalAbonos += (decimal)abono.tbAbonos.Last().monto;
                Ticket1.TextoIzquierda("Saldo:" + ((abono.tbDetalleDocumento.Sum(x => x.totalLinea))- (abono.tbAbonos.Sum(x=>x.monto))).ToString());
                Ticket1.TextoIzquierda("Estado Factura:"+ Enum.GetName(typeof(Enums.EstadoFactura), abono.estadoFactura));
                Ticket1.TextoIzquierda("" );
            }
            Ticket1.LineasAsterisco();
            Ticket1.TextoIzquierda("Total Abonado:" + totalAbonos);
            Ticket1.TextoIzquierda("Saldo Pendiente:" + _saldo);
            Ticket1.LineasAsterisco();
            Ticket1.TextoCentro("GRACIAS POR SU COMPRA");

            Ticket1.CortaTicket(); // corta el ticket
        }

        private void printPuntoVenta( )
        {

            CreaTicket Ticket1 = new CreaTicket();
            Ticket1.AbreCajon();  //abre el cajon
            string nombreEmpresa = string.Empty;
            string nombreComercial = string.Empty;
            if (Global.actividadEconomic.nombreComercial != null )
            {
                nombreComercial = Global.actividadEconomic.nombreComercial.Trim().ToUpper();
            }
           
            if (_empresa.tipoId == (int)Enums.TipoId.Fisica)
            {
                nombreEmpresa = _empresa.tbPersona.nombre.ToUpper().ToString().Trim() + " " +
                        _empresa.tbPersona.apellido1.ToUpper().ToString().Trim() + " " + _empresa.tbPersona.apellido2.ToUpper().ToString().Trim();
            }
            else
            {
                nombreEmpresa = _doc.tbClientes.tbPersona.nombre.ToUpper().ToString().Trim();

            }


            if (nombreComercial != string.Empty)
            {
                Ticket1.TextoCentro(nombreComercial);
            }
            Ticket1.TextoCentro(nombreEmpresa); 
            Ticket1.TextoCentro(_empresa.tbPersona.tbBarrios.tbDistrito.Nombre.Trim().ToUpper()+"-"+ _empresa.tbPersona.tbBarrios.tbDistrito.tbCanton.Nombre.Trim().ToUpper() + "-" + _empresa.tbPersona.tbBarrios.tbDistrito.tbCanton.tbProvincia.Nombre.Trim().ToUpper());
            Ticket1.TextoCentro((_empresa.tipoId==(int)Enums.TipoId.Fisica?"Ced Fisica:":"Ced Juridica:")+_empresa.tbPersona.identificacion.ToString().Trim());
            Ticket1.TextoCentro("Tel:" + _empresa.tbPersona.telefono.ToString());
            Ticket1.TextoIzquierda("Factura #:"+ _doc.id);
            Ticket1.TextoIzquierda("Fecha:" + _doc.fecha);       
            Ticket1.TextoIzquierda("Tipo Venta:" + Enum.GetName(typeof(Enums.tipoVenta), _doc.tipoVenta));
            Ticket1.TextoIzquierda("Forma Pago:" + Enum.GetName(typeof(Enums.TipoPago), _doc.tipoPago));
            Ticket1.TextoCentro("");
            if (_doc.tipoDocumento==(int)Enums.TipoDocumento.FacturaElectronica)
            {
                Ticket1.TextoCentro("FACTURA ELECTRONICA");
            }
            else if (_doc.tipoDocumento == (int)Enums.TipoDocumento.TiqueteElectronico)
            {
                Ticket1.TextoCentro("TIQUETE ELECTRONICO");
            }
            
            Ticket1.TextoIzquierda("Consecutivo:" + _doc.consecutivo);
            Ticket1.TextoCentro(_doc.clave.Substring(0,40));
            Ticket1.TextoCentro(_doc.clave.Substring(40, 10));
            Ticket1.TextoCentro(""); 
            if (_doc.idCliente!=null)
            {
               
                string nombre = "";
                string id = _doc.tbClientes.tbPersona.identificacion.ToString().Trim();
                if (_doc.tbClientes.tbPersona.tipoId == (int)Enums.TipoId.Fisica)
                {
          
                    nombre = _doc.tbClientes.tbPersona.nombre.ToUpper().ToString().Trim() + " " +
                       _doc.tbClientes.tbPersona.apellido1.ToUpper().ToString().Trim() + " " + _doc.tbClientes.tbPersona.apellido2.ToUpper().ToString().Trim();
                }
                else
                {     
                    nombre = _doc.tbClientes.tbPersona.nombre.ToUpper().ToString().Trim();
                }
                Ticket1.TextoIzquierda("ID Cliente:" + id);
                Ticket1.TextoIzquierda("Cliente:" +nombre);

            }
            else
            {
                if (_clienteSimplificada!=string.Empty)
                {
                    Ticket1.TextoIzquierda("Cliente:" + _clienteSimplificada);
                }
            }
  
            Ticket1.LineasGuion(); // imprime una linea de guiones
            Ticket1.EncabezadoVenta(); // imprime encabezados
            foreach (tbDetalleDocumento item in _doc.tbDetalleDocumento)
            {
                Ticket1.AgregaArticulo(item.tbProducto.nombre.Trim().ToUpper(), item.cantidad, item.precio, item.montoTotal); //imprime una linea de descripcion
            }

            Ticket1.LineasTotales(); // imprime linea 

            Ticket1.AgregaTotales("SubTotal", _doc.tbDetalleDocumento.Sum(x => x.montoTotal)); // imprime linea con total
            Ticket1.AgregaTotales("Descuento", _doc.tbDetalleDocumento.Sum(x => x.montoTotalDesc));
            decimal exo = _doc.tbDetalleDocumento.Sum(x => x.montoTotalExo);
            if ( exo!=0)
            {
                Ticket1.AgregaTotales("Exoneracion", exo);
            }        
            Ticket1.AgregaTotales("IVA", _doc.tbDetalleDocumento.Sum(x => x.montoTotalImp));
            Ticket1.AgregaTotales("Total", _doc.tbDetalleDocumento.Sum(x=>x.totalLinea)); // imprime linea con total
            Ticket1.LineasGuion();
            Ticket1.AgregaTotales("Pago", _paga); // imprime linea con total
            Ticket1.AgregaTotales("Vuelto", _vuelto); // imprime linea con total
            Ticket1.LineasGuion();
            Ticket1.TextoIzquierda("Autorizada mediante resolución No. DGT-R");
            Ticket1.TextoIzquierda("-48-2016 del 7 de octubre del 2016");
            
            Ticket1.TextoCentro("GRACIAS POR SU COMPRA");

            Ticket1.CortaTicket(); // corta el ticket

        }



        private void printMediaCarta()
        {

            SqlConnection _SqlConnection = new SqlConnection(Utility.stringConexionReportes());
            dtReporteHacienda ds = new dtReporteHacienda();
            if (_doc.idCliente == null)
            {

                rptFacturaMediaCarta Reporte = new rptFacturaMediaCarta();

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
                Reporte.PrintToPrinter(1, false, 0, 0);

                Reporte.Close();


            }
            else
            {
                rptFacturaMediaCarta Reporte = new rptFacturaMediaCarta();
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
                Reporte.PrintToPrinter(1, false, 0, 0);




                Reporte.Close();





            }

        }



        private void printCartaCompleta()
        {

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
                Reporte.PrintToPrinter(1, false, 0, 0);

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
                Reporte.PrintToPrinter(1, false, 0, 0);




                Reporte.Close();





            }

        }

        //void imprimirFactura(object sender, PrintPageEventArgs e)
        //{
            

        //    //Configuramos el docmumento para imprimir.
        //    Graphics plantilla = e.Graphics;
        //    Font font = new Font("Courier New", 10);
        //    int startX = 50;
        //    int startY = 55;
        //    int Offset = 40;

        //    plantilla.DrawString(_empresa.tbPersona.nombre,
        //                        new Font("Courier New", 14),
        //                        new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    plantilla.DrawString(_empresa.tbPersona.otrasSenas,
        //             new Font("Courier New", 14),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    plantilla.DrawString("Número factura: " + _doc.id,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    plantilla.DrawString("Fecha: " + _doc.fecha,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    plantilla.DrawString("Atendido por: " + _doc.usuario_crea,
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 40;
        //    plantilla.DrawString("Cant.      Nombre.        P/u",
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 20;
        //    plantilla.DrawString("---------------------------------------",
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    //Aqui ira el ciclo para recorrer los productos comprados.
        //    foreach (tbDetalleDocumento item in _doc.tbDetalleDocumento)
        //    {

        //        Offset = Offset + 20;
        //        plantilla.DrawString(item.cantidad.ToString().Trim() ,
        //                 new Font("Courier New", 12),
        //                 new SolidBrush(Color.Black), startX, startY + Offset);

        //        //Este sera el nombre del producto, debo recorrer la lista de productos y ver cual coincide con el ID.
               
        //        plantilla.DrawString(item.tbProducto.nombre.Trim(),
        //            new Font("Courier New", 12),
        //            new SolidBrush(Color.Black), 100, startY + Offset);
             


        //        plantilla.DrawString(item.totalLinea.ToString().Trim(),
        //         new Font("Courier New", 12),
        //         new SolidBrush(Color.Black), 300, startY + Offset);
                
        //    }



        //    Offset = Offset + 20;
        //    plantilla.DrawString("---------------------------------------",
        //             new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);

        //    Offset = Offset + 40;
        //    plantilla.DrawString( "Subtotal: " + 23432,
        //    new Font("Courier New", 12),
        //             new SolidBrush(Color.Black), startX, startY + Offset);


        //    Offset = Offset + 20;
        //    //plantilla.DrawString("IVA: " + facturaGlo.iva,
        //    //         new Font("Courier New", 12),
        //    //         new SolidBrush(Color.Black), startX, startY + Offset);


        //    //Offset = Offset + 20;
        //    //plantilla.DrawString("Pago con: " + facturaGlo.pago,
        //    //         new Font("Courier New", 12),
        //    //         new SolidBrush(Color.Black), startX, startY + Offset);


        //    //Offset = Offset + 20;
        //    //plantilla.DrawString("Vuelto: " + (facturaGlo.pago - facturaGlo.total).ToString(),
        //    //         new Font("Courier New", 12),
        //    //         new SolidBrush(Color.Black), startX, startY + Offset);

        //}


    }
}
