using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLayer;
using DataLayer;

using CommonLayer.Exceptions.BusisnessExceptions;

namespace BusinessLayer
{
    public class BProducto
    {

        DProductos productoIns = new DProductos();


        /// <summary>
        /// Recuperamos el detalle del producto.
        /// </summary>
        /// <param name="idBuscar"></param>
        /// <returns></returns>
        public List<tbDetalleProducto> getDetalleProducto(string idBuscar)
        {
            return productoIns.getDetalleProducto(idBuscar);
        }

        public tbDetalleProducto getDetalleProdByIngreProd(int idIngre, string idProd)
        {
            return productoIns.GetEntityByIdProdcutoIngre(idIngre,idProd);
        }


        /// <summary>
        /// Recuperamos los productos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<tbProducto> getProductos(int estado)
        {

            return productoIns.GetListEntities(estado);

        }

        public bool actualizarProductosImport(List<tbProducto> listaPro)
        {

            return productoIns.ActualizarProductosImports(listaPro);
        }


        /// <summary>
        /// Pasamos la informacion para actualizar en la base da datos.
        /// </summary>
        /// <param name="productoNuevo"></param>
        /// <returns></returns>
        public tbProducto actualizarProducto(tbProducto productoNuevo)
        {
            try
            {
                           
                // Ejecutamos el actualizar del producto
                return productoIns.Actualizar(productoNuevo);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        /// <summary>
        /// Recuperamos la entidad.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public tbProducto GetEntity(tbProducto producto)
        {

            return productoIns.GetEntity(producto);

        }


        /// <summary>
        /// Pasamos la informacion para almacenar en la base de datos.
        /// </summary>
        /// <param name="productoNUevo"></param>
        /// <returns></returns>
        public tbProducto guardarProducto(tbProducto productoNUevo)
        {

            tbProducto productoExiste = productoIns.GetEntity(productoNUevo);

            if (productoExiste == null)
            {
                return productoIns.Guardar(productoNUevo);
            }
            else
            {
                if (productoNUevo.estado == true)
                {
                    throw new EntityExistException("producto");
                }
                else
                {
                    throw new EntityDisableStateException("producto");
                }
            }
        }




        /// <summary>
        /// Recuperamos el nombre del ingrediente segun su iD.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<tbIngredientes> getNombreIngrediente(int p)
        {
            return productoIns.getNombreIngrediente(p);
        }



        public tbIngredientes getNombrePorID(int Id)
        {
            return productoIns.getNomrePreID(Id);
        }


        /// <summary>
        /// Recuperamos el producto segun su categoria
        /// </summary>
        /// <param name="cate"></param>
        /// <returns></returns>
        public List<tbProducto> getListProductoByCategoria(int cate)
        {
            return productoIns.getListProductoByCategoria(cate);
        }



        /// <summary>
        /// Eliminamos el detalle del producto de la base de datos.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbDetalleProducto BorrarDetalleProducto(tbDetalleProducto entity)
        {
            return productoIns.EliminarDetalleProducto(entity);

        }

        /// <summary>
        /// Guardamos el detalle de producto nuevo.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbDetalleProducto guardarDetalleProducto(tbDetalleProducto entity)
        {
            return productoIns.GuardarDetalleProducto(entity);
        }

    }
}
