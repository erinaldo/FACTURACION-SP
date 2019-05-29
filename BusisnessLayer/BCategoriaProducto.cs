using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BCategoriaProducto
    {


        //Creamos una instancia global para el acceso a la capa de negocios.
        DCategoriaProducto catProductosIns = new DCategoriaProducto();


        /// <summary>
        /// Recuperamos todas las categorias de la base de datos.
        /// </summary>
        /// <returns></returns>
        public  List<tbCategoriaProducto> getCategorias(int estado)
        {
            return catProductosIns.GetListEntities(estado);
        }

        public tbCategoriaProducto Getentity(tbCategoriaProducto entity)
        {
            return catProductosIns.GetEntity(entity);
        }

        /// <summary>
        /// Recuperamos las categorias para el reporte.
        /// </summary>
        /// <returns></returns>
        public List<tbCategoriaProducto> getCategoriasReport()
        {
            return catProductosIns.getCategoriasReporte();
        }




        /// <summary>
        /// Actualizamos la informacion de la categoria
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        public  tbCategoriaProducto actualizarCategoria(tbCategoriaProducto categoria)
        {
            return catProductosIns.Actualizar(categoria);
        }


        /// <summary>
        /// Guardamos la categoria nueva en la base de datos.
        /// </summary>
        /// <param name="categoriaNueva"></param>
        /// <returns></returns>
        public  tbCategoriaProducto guardarCategoria(tbCategoriaProducto categoriaNueva)
        {

            tbCategoriaProducto existe = catProductosIns.GetEntity(categoriaNueva);
            if (existe == null)
            {
                //Enviamos la entidad a guardarse.
                return catProductosIns.Guardar(categoriaNueva);

            }
            else
            {
                //Lo enviamos a modificar.


                existe.descripcion = categoriaNueva.descripcion;
                existe.estado = categoriaNueva.estado;
                existe.fecha_ult_mod = categoriaNueva.fecha_ult_mod;
                existe.usuario_ult_mod = categoriaNueva.usuario_ult_mod;
                existe.fotocategoria = categoriaNueva.fotocategoria;




                return catProductosIns.Actualizar(existe);

            }
            
        }



        public List<tbIngredientes> getIngredientesPorCategoria(int idBuscar)
        {
            return catProductosIns.GetListIngrediente(idBuscar);
        }


        public List<tbTipoIngrediente> getCategoriaIngredientes()
        {

            return catProductosIns.GetListTipoIngredientes();
            
        }
    }
}
