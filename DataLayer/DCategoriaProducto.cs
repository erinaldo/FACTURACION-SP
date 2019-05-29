using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLayer;

using CommonLayer.Exceptions.DataExceptions;
using CommonLayer;
using CommonLayer.Interfaces;

namespace DataLayer
{
    public  class DCategoriaProducto : IDataGeneric<tbCategoriaProducto>
    {


        /// <summary>
        /// Recuperamos todo las categorias que hay en la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<tbCategoriaProducto> GetListEntities(int estado)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        //Recuperamos los datos de la tabla con el estado en activo.
                        return (from p in context.tbCategoriaProducto.Include("tbProducto")
                                where p.estado == true
                                select p).ToList();
                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        //Recuperamos los valores con el estado en inactivo
                        return (from p in context.tbCategoriaProducto.Include("tbProducto")
                                where p.estado == false
                                select p).ToList();

                    }
                    else
                    {
                        //Recuperamos todos los valores de la tabla.
                        return (from p in context.tbCategoriaProducto.Include("tbProducto")
                                select p).ToList();

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.ToString());
            }

        
        
        }

        /// <summary>
        /// Recuperamos las categorias para realizar el reporte.
        /// </summary>
        /// <returns></returns>
        public List<tbCategoriaProducto> getCategoriasReporte()
        {

            //Creamos una lista de tipo tbCategorias.
            List<tbCategoriaProducto> categorias = new List<tbCategoriaProducto>();

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    //recuperamos los datos en una lista generica
                   var listaCategorias = (from p in context.tbCategoriaProducto
                            select new { p.id, p.nombre, p.descripcion, p.estado, p.fecha_crea, p.usuario_crea  }).ToList();

                   
                    //Recorremos la lista generica para obtener los datos.
                    foreach (var p in listaCategorias)
                    {

                        tbCategoriaProducto cat = new tbCategoriaProducto();
                        cat.id = p.id;
                        cat.nombre = p.nombre;
                        cat.descripcion = p.descripcion;
                        cat.fecha_crea = p.fecha_crea;
                        cat.estado = p.estado;
                        cat.usuario_crea = p.usuario_crea;

                        categorias.Add(cat);
                        
                    }

                }

                return categorias;
            }
            catch (Exception ex)    
            {

                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Actualizamos la informacion de la categoria.
        /// </summary>
        /// <param name="categoriaNueva"></param>
        /// <returns></returns>
        public tbCategoriaProducto Actualizar(tbCategoriaProducto categoriaNueva)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    context.Entry(categoriaNueva).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return categoriaNueva;

                }

            }


            catch (Exception ex)
            {
                throw new UpdateEntityException("Ha ocurrido el siguiente error: " + ex.ToString());
            }

        }


        /// <summary>
        /// Almacenados la categoria en la base de datos.
        /// </summary>
        /// <param name="categoriaNueva"></param>
        /// <returns></returns>
        public tbCategoriaProducto Guardar(tbCategoriaProducto categoriaNueva)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbCategoriaProducto.Add(categoriaNueva);
                    context.SaveChanges();

                    return categoriaNueva;

                }


            }


            catch (Exception ex)
            {
                throw new SaveEntityException("Ha ocurrido el siguiente error: " + ex.ToString());
            }
        
        }




        /// <summary>
        /// Recuperamos la entidad de la base de datos para saber si ya existe.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public tbCategoriaProducto GetEntity(tbCategoriaProducto entity)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                   entity = (from p in context.tbCategoriaProducto
                                where p.nombre == entity.nombre
                                select p).SingleOrDefault();

                   return entity;
                }

            }
            catch (Exception ex)
            {
                
                throw new SaveEntityException(ex.Message);  
            }


        }

        public List<tbIngredientes> GetListIngrediente(int idBuscar)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from p in context.tbIngredientes.Include("tbTipoMedidas")
                            where p.idTipoIngrediente == idBuscar
                            select p).ToList();

                }


            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Retornamos los diferentes tipos de ingredientes.
        /// </summary>
        /// <returns></returns>
        public List<tbTipoIngrediente> GetListTipoIngredientes()
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                { 
                    return (from p in context.tbTipoIngrediente
                                select p).ToList();
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;  
            }
        }
    }
}
