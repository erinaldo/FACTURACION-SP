﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using CommonLayer.Exceptions;
using CommonLayer.Interfaces;
using CommonLayer.Exceptions.DataExceptions;

namespace DataLayer
{
    public class DFacturacion:IDataGeneric<tbDocumento>
    {
        DProductos productoIns = new DProductos();
        DInventario inventarioIns = new DInventario();
        DEliminarFactura detalleFacturaIns = new DEliminarFactura();
       

        public int getNewID(int tipoDoc)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var existe = (from u in context.tbDocumento
                                  where u.tipoDocumento == tipoDoc
                                  orderby u.id descending
                                  select u);
                    if (existe.Count()==0)
                    {
                        return 0;
                    }
                    else
                    {
                         var x= (from u in context.tbDocumento
                                             where u.tipoDocumento== tipoDoc
                                             orderby u.id descending                      
                                             select u).Take(1);

                        return x.First().id;

                    }                  

                
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return -1;

        }

        public int getNewIDMensaje()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var existe = (from u in context.tbReporteHacienda                              
                                  orderby u.id descending
                                  select u);
                    if (existe.Count() == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        var x = (from u in context.tbReporteHacienda                                 
                                 orderby u.id descending
                                 select u).Take(1);

                        return x.First().id;

                    }


                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return -1;

        }

        public bool abonos(IEnumerable<tbDocumento> listaFact)
        {
            List<tbAbonos> listaAbonos = new List<tbAbonos>();



            //try
            //{
             
            //    using ( dbSisSodInaEntities context = new dbSisSodInaEntities())
            //    {
            //        foreach (var doc in listaFact)
            //        {
                    
            //            foreach (var abono in doc.tbAbonos)
            //            {
            //                if (abono.idAbono==0)
            //                {
            //                    context.Entry(abono).State = System.Data.Entity.EntityState.Added;


            //                }
            //                else
            //                {
            //                    context.Entry(abono).State = System.Data.Entity.EntityState.Detached;

            //                }
            //            }
            //        }

            //        foreach (var doc in listaFact)
            //        {
            //            context.Entry(doc).State = System.Data.Entity.EntityState.Modified;

            //            context.SaveChanges();
            //        }





            //     }
            //}
            //catch (Exception ex)
            //{
            //    throw new UpdateEntityException("facturacion actualizacion. Electronica");
            //}

            return true;

        }


        public tbDocumento Actualizar(tbDocumento entity)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
  
                    context.SaveChanges();
                    return entity;

                }
            }
            catch (Exception ex)
            {
                throw new UpdateEntityException("facturacion actualizacion. Electronica");
            }



        }

        //private bool actualizarInventario(string idProducto, decimal cantidad)
        //{
        //    List<tbDetalleProducto> ingredientesLista = detalleProductoIns.GetListEntitiesByIdProduct(idProducto);
        //    tbInventario inventario;
        //    foreach(tbDetalleProducto detalle in ingredientesLista)
        //    {
               
        //        inventario = inventarioIns.GetEntityByIngrediente(detalle.idIngrediente);
        //        if(inventario !=null)
        //        {

        //           // inventario.cantidad = Math.Round(inventario.cantidad - (detalle.cantidad * cantidad), 2);


        //        }


        //    }



        //    return true;
        //}

        public tbDocumento getByConsecutivo(string consecutivo)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                   
                        return (from p in context.tbDocumento.Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto").Include("tbDetalleDocumento.tbProducto.tbImpuestos").Include("tbTipoMoneda")
                                where p.consecutivo==consecutivo
                                select p).FirstOrDefault();
                    
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public tbDocumento getById(int id, int tipo)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from p in context.tbDocumento.Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto").Include("tbDetalleDocumento.tbProducto.tbImpuestos").Include("tbTipoMoneda")
                            where p.id == id && p.tipoDocumento==tipo
                            select p).FirstOrDefault();

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public tbDocumento GetEntity(tbDocumento entity)
        {
            return GetEntity(entity, true);
        }
            public tbDocumento GetEntity(tbDocumento entity, bool cargaEntAnexas)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    if (cargaEntAnexas)
                    {
                        return (from p in context.tbDocumento.Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto.tbImpuestos")
                                where p.id == entity.id && p.tipoDocumento==entity.tipoDocumento
                                select p).FirstOrDefault();


                    }
                    else
                    {
                        return (from p in context.tbDocumento.Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto")
                                where p.id == entity.id && p.tipoDocumento == entity.tipoDocumento
                                select p).FirstOrDefault();

                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public tbDocumento GetEntityByClave(tbDocumento entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbDocumento.Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto").Include("tbDetalleDocumento.tbProducto.tbImpuestos")
                            where p.clave == entity.clave
                            select p).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public tbDocumento GetEntityByClave(string clave)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbDocumento.Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto").Include("tbDetalleDocumento.tbProducto.tbImpuestos")
                            where p.clave == clave
                            select p).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IEnumerable<tbDocumento> getListFacturasAceptadasHacienda()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbDocumento.Include("tbDetalleDocumento").Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto")
                            where (p.reporteAceptaHacienda == true && p.mensajeReporteHacienda.Contains("Accepted") && p.EstadoFacturaHacienda.Contains("aceptado") || p.EstadoFacturaHacienda.Contains("rechazado"))
                            select p).ToList();


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public IEnumerable<tbDocumento> getListAllDocumentos()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbDocumento.Include("tbDetalleDocumento").Include("tbClientes.tbPersona").Include("tbDetalleDocumento.tbProducto.tbImpuestos")
                            select p).ToList();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public List<tbDocumento> getListFactPendiente()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
            {
                return (from p in context.tbDocumento.Include("tbDetalleDocumento").Include("tbDetalleDocumento.tbProducto")
                        where p.estadoFactura==(int)Enums.EstadoFactura.Pendiente
                        select p).ToList();
            }

            }
            catch (Exception ex)
            {

                throw ex;
            }
         

        }

        public IEnumerable<tbReporteHacienda> GetListMensajesCompras()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from p in context.tbReporteHacienda
                                             
                            select p).ToList();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;

        }

        public IEnumerable<tbDocumento> GetListEntities()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                   
                        return (from p in context.tbDocumento.Include("tbDetalleDocumento").Include("tbDetalleDocumento.tbProducto").Include("tbClientes.tbPersona")
                                where p.estadoFactura != (int)Enums.EstadoFactura.Eliminada
                                && (p.EstadoFacturaHacienda == null || p.EstadoFacturaHacienda == "procesando" || p.EstadoFacturaHacienda == "rechazado")
                      && p.reporteElectronic==true
                                select p).ToList();

                  
               
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return null;
            
        }
        public tbReporteHacienda GetMensajeById(int id)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbReporteHacienda
                            where p.id==id
                            select p).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public tbReporteHacienda GetMensajeByClave(string clave)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbReporteHacienda
                            where p.claveReceptor == clave
                            select p).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbReporteHacienda GetMensajeByConsecutivo(string consecutivo)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbReporteHacienda
                            where p.consecutivoReceptor == consecutivo
                            select p).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public tbReporteHacienda GetMensajeByClaveIdEmisor(string clave, string emisor)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbReporteHacienda
                            where p.claveDocEmisor == clave && p.idEmisor==emisor
                            select p).FirstOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbReporteHacienda ActualizarMensaje(tbReporteHacienda entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();

                }
                return entity;
            }
            catch (Exception ex)
            {

                throw new SaveEntityException("Error al reportar mensaje");
            }
        }



        public tbReporteHacienda GuardarMensaje(tbReporteHacienda entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
      

                    context.tbReporteHacienda.Add(entity);
                    context.SaveChanges();

                }
                return entity;
            }
            catch (Exception ex)
            {

                throw new SaveEntityException("Error al reportar mensaje");
            }
        }



        public tbDocumento Guardar(tbDocumento entity)
        {
            try
            {
                entity.tbClientes = null;
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    foreach (var item in entity.tbDetalleDocumento)
                    {
                        if (item.tbProducto!=null)
                        {
                            item.tbProducto = null;
                        }

                        context.Entry(item).State = System.Data.Entity.EntityState.Added;
                    }

                    context.tbDocumento.Add(entity);

                    if (entity.tipoDocumento == (int)Enums.TipoDocumento.NotaCreditoElectronica || entity.tipoDocumento == (int)Enums.TipoDocumento.NotaDebitoElectronica)
                    {
                        if (entity.claveRef != null)
                        {
                            var docActualizar = GetEntityByClave(entity.claveRef);
                            docActualizar.estado = false;//elimino logicamente
                            docActualizar.fecha_ult_mod = Utility.getDate();
                            docActualizar.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim();
                            context.Entry(docActualizar).State = System.Data.Entity.EntityState.Modified;
                        }

                    }



                    if ( (bool)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().manejaInventario && entity.tipoDocumento!=(int)Enums.TipoDocumento.Proforma )
                    {


                        foreach (tbDetalleDocumento detalle in entity.tbDetalleDocumento)
                        {
                            tbProducto producto = productoIns.GetEntityById(detalle.idProducto);
                            //si guardo factura desde 0, y el estado es cancelado, actualizo el inventario
                            if (entity.tipoDocumento == (int)Enums.TipoDocumento.FacturaElectronica)
                            {


                      

                                producto.tbInventario.cantidad = producto.tbInventario.cantidad - detalle.cantidad;




                            }
                            if (entity.tipoDocumento == (int)Enums.TipoDocumento.NotaCreditoElectronica || entity.tipoDocumento == (int)Enums.TipoDocumento.NotaDebitoElectronica)
                            {


                       

                                producto.tbInventario.cantidad = producto.tbInventario.cantidad + detalle.cantidad;





                            }
                            producto.tbImpuestos = null;
                            context.Entry(producto.tbInventario).State = System.Data.Entity.EntityState.Modified;
                        }



                    }

                    context.SaveChanges();

                }
                return entity;
            }
            catch (Exception ex)
            {

                throw new SaveEntityException("Error en Factura");
            }
        }

        public List<tbDocumento> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }
    }
}