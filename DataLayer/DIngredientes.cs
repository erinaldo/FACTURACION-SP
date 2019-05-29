using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DIngredientes : IDataGeneric<tbIngredientes>
    {

        public tbIngredientes GetEntity(tbIngredientes ingrediPara)
        {
            tbIngredientes ingrediente;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    ingrediente = (from a in context.tbIngredientes//desde a el el context de tabla ingrediente
                                   where a.idIngrediente == ingrediPara.idIngrediente//donde si a.nombre es = ingrediPara.nombre
                                   select a).SingleOrDefault();//seleccione a
                }
                return ingrediente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public tbIngredientes Guardar(tbIngredientes ingrediente)
        {
            try
            {
                //using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                //{
                //    context.tbIngredientes.Add(ingrediente);
                //    foreach (tbInventario inventario in ingrediente.tbInventario)
                //    {

                //        context.tbInventario.Add(inventario);
                //    }


                //    context.SaveChanges();//guarda los datos en la basedatos
                //}
            }
            catch (Exception ex)
            {
                throw new SaveEntityException("Ingrediente");
            }
            return ingrediente;
        }


        public tbIngredientes Actualizar(tbIngredientes ingrediente)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(ingrediente).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return ingrediente;
                }
            }
            catch (Exception ex)
            {
                throw new UpdateEntityException("Actualizar");
            }

        }


        public List<tbIngredientes> GetListEntities()
        {
            return GetListEntities(3); // ???? 
        }


        public List<tbIngredientes> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    List<tbIngredientes> ingrediente = new List<tbIngredientes>();
                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        ingrediente = (from a in context.tbIngredientes.Include("tbInventario")
                                       where a.estado == true
                                       select a).ToList();
                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        ingrediente = (from a in context.tbIngredientes.Include("tbInventario")
                                       where a.estado == false
                                       select a).ToList();
                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {
                        ingrediente = (from a in context.tbIngredientes.Include("tbInventario")
                                       select a).ToList();
                    }
                    return ingrediente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<tbTipoIngrediente> GetListEntitiesDetalle(int tipoIngrediente)
        {
            List<tbTipoIngrediente> tipoIngre;
            try
            {
                dbSisSodInaEntities context = new dbSisSodInaEntities();

                tipoIngre = (from p in context.tbTipoIngrediente
                             where p.estado == true
                             select p).ToList();


                return tipoIngre;
            }
            catch (Exception ex)
            {
                throw new EntityException("Tipo");//No se pudo obtener el tipo de Ingrediente
            }
        }



       
        //METODOS DE MOVIMIENTO PAGO PROVEEDORES ALBAN


        //OBTENER LOS INGREDIENTES ACTIVOS


        //Metodos para obtener los elementos de la lista ya se activos , inactivos o todos
        public List<tbIngredientes> GetListEntitiesIngredientes(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    List<tbIngredientes> ingrediente = new List<tbIngredientes>();
                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {

                        ingrediente = (from p in context.tbIngredientes.Include("tbTipoMedidas").Include("tbInventario")
                                       where p.estado == true//ACTIVOS
                                       select p).ToList();
                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        ingrediente = (from p in context.tbIngredientes.Include("tbTipoMedidas").Include("tbInventario")
                                       where p.estado == false//INACTIVOS
                                       select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {
                        ingrediente = (from p in context.tbIngredientes.Include("tbTipoMedidas").Include("tbInventario")
                                       select p).ToList();
                    }

                    return ingrediente;
                }
            }
            catch (Exception ex)
            {
                throw new ListEntityException("Lista de Ingredientes");
            }
        }

        /// <summary>
        /// Recuperamos los ingredientes segun el tipo de Ingrediente.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<tbIngredientes> GetEntityPorID(int ID)
        {

            List<tbIngredientes> ingredientes;

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    ingredientes = (from p in context.tbIngredientes.Include("tbTipoMedidas")
                                    where p.idTipoIngrediente == ID
                                    select p).ToList();

                    return ingredientes;

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

       

        /// <summary>
        /// Recuperamos el ingrediente mediante el ID.
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public tbIngredientes GetEntityByID(tbIngredientes entidad)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbIngredientes
                            where p.idIngrediente == entidad.idIngrediente
                            select p).SingleOrDefault();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
