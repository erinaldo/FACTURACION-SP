using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLayer;


using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;
using CommonLayer;

namespace DataLayer
{
    public class DProductos : IDataGeneric<tbProducto>
    {
        DDetalleProducto detalleProductoIns = new DDetalleProducto();


        /// <summary>
        /// Guardamos la entidad en la base de datos.
        /// </summary>
        /// <param name="productoNuevo"></param>
        /// <returns></returns>
        public tbProducto Guardar(tbProducto productoNuevo)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    context.tbProducto.Add(productoNuevo);
                    context.SaveChanges();

                    return productoNuevo;

                }


            }
            catch (Exception ex)
            {

                throw new SaveEntityException(ex.Message);
            }

        }
        
        public bool ActualizarProductosImports(List<tbProducto> listaPro)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    foreach (var item in listaPro)
                    {
                        tbProducto pro = GetEntityById(item.idProducto);
                        if (pro != null)
                        {
                            pro.tbImpuestos = null;

                            pro.idMedida = item.idMedida;
                            pro.nombre = item.nombre;
                            pro.precio_real = item.precio_real;
                            pro.precioVenta1 = item.precioVenta1;
                            pro.precioVenta2 = item.precioVenta2;
                            pro.precioVenta3 = item.precioVenta3;
                            pro.precioVariable = item.precioVariable;
                            pro.precioUtilidad1 = item.precioUtilidad1;
                            pro.precioUtilidad2 = item.precioUtilidad2;
                            pro.precioUtilidad3 = item.precioUtilidad3;
                            pro.utilidad1Porc = item.utilidad1Porc;
                            pro.utilidad2Porc = item.utilidad2Porc;
                            pro.utilidad3Porc = item.utilidad3Porc;
                            pro.aplicaDescuento = item.aplicaDescuento;
                            pro.descuento_max = item.descuento_max;
                            pro.esExento = item.esExento;
                            context.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                        }
                    }

                    context.SaveChanges();

                    return true;

                }
            }
            catch (Exception ex )
            {

                throw ex;
            }

        }
        /// <summary>
        /// Actualizamos el producto en la base de datos.
        /// </summary>
        /// <param name="productoNuevo"></param>
        /// <returns></returns>
        public tbProducto Actualizar(tbProducto productoNuevo)
        {

            try
            {
                bool bandera = false;

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    productoNuevo.tbImpuestos = null;
                    context.Entry(productoNuevo).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(productoNuevo.tbInventario).State = System.Data.Entity.EntityState.Modified;


                    context.SaveChanges();

                    return productoNuevo;

                }
            }
            catch (Exception ex)
            {
                throw new UpdateEntityException(ex.Message);
            }

        }




        /// <summary>
        /// Recuperamos los productos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<tbProducto> GetListEntities(int estado)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {

                        return (from p in context.tbProducto.Include("tbProveedores").Include("tbInventario").Include("tbImpuestos")
                                where p.estado == true
                                select p).ToList();


                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        return (from p in context.tbProducto.Include("tbProveedores").Include("tbInventario").Include("tbImpuestos")
                                where p.estado == false
                                select p).ToList();


                    }
                    else
                    {

                        return (from p in context.tbProducto.Include("tbProveedores").Include("tbInventario").Include("tbImpuestos")
                                select p).ToList();


                    }


                }


            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        /// <summary>
        /// Recuperamos la entidad de la base de datos.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbProducto GetEntityActualizar(tbProducto entity)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    entity = (from p in context.tbProducto.Include("tbProveedores").Include("tbInventario").Include("tbImpuestos")
                              where p.idProducto == entity.idProducto
                              select p).SingleOrDefault();

                    return entity;
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }


        }



        /// <summary>
        /// Recuperamos la entidad de la base de datos.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbProducto GetEntity(tbProducto entity)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    entity = (from p in context.tbProducto.Include("tbProveedores").Include("tbInventario").Include("tbImpuestos")
                              where p.idProducto == entity.idProducto
                              select p).SingleOrDefault();

                    return entity;
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }


        }

        public tbProducto GetEntityById(string id)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                  return (from p in context.tbProducto.Include("tbProveedores").Include("tbInventario").Include("tbImpuestos")
                              where p.idProducto == id
                              select p).SingleOrDefault();

          
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }


        }
        public tbDetalleProducto GetEntityByIdProdcutoIngre(int ingre, string prod)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return  (from p in context.tbDetalleProducto
                              where p.idIngrediente == ingre && p.idProducto==prod
                              select p).SingleOrDefault();

                    
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }


        }




        /// <summary>
        /// Recuperamos el nombre del ingrediente segun su iD
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<tbIngredientes> getNombreIngrediente(int id)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    //Recuperamos el nombre del ingrediente segun su id
                    return (from p in context.tbIngredientes
                            where p.idIngrediente == id
                            select p).ToList();

                }

            }

            catch (Exception ex)
            {
                throw ex;
            }


        }


        public List<tbProducto> getListProductoByCategoria(int id)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    //Recuperamos la lista de productos segun la categoria
                    return (from p in context.tbProducto
                            where p.id_categoria == id
                            select p).ToList();

                }

            }

            catch (Exception ex)
            {
                throw ex;
            }


        }




        /// <summary>
        /// Retornamos el detalle segun el id ingresado.
        /// </summary>
        /// <param name="idBuscar"></param>
        /// <returns></returns>
        public List<tbDetalleProducto> getDetalleProducto(string idBuscar)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    return (from p in context.tbDetalleProducto.Include("tbIngredientes")
                            where p.idProducto == idBuscar
                            select p).ToList();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        /// <summary>
        /// Obtenemos el nombre segun el ID ingresado
        /// </summary>
        /// <param name="IdBuscar"></param>
        /// <returns></returns>
        public tbIngredientes getNomrePreID(int IdBuscar)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    //Recuperamos el nombre del ingrediente segun su id
                    return (from p in context.tbIngredientes
                            where p.idIngrediente == IdBuscar
                            select p).SingleOrDefault();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// Borramos la informacion enviada de la base de datos.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbDetalleProducto EliminarDetalleProducto(tbDetalleProducto entity)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw;
            }

        }





        /// <summary>
        /// Guardamos el nuevo detalle de producto.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbDetalleProducto GuardarDetalleProducto(tbDetalleProducto entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbDetalleProducto.Add(entity);
                    context.SaveChanges();
                    return entity;

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}