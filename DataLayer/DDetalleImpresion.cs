using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLayer;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;

namespace DataLayer
{
    public class DDetalleImpresion : IDataGeneric<tbDetalleImpresion>
    {
         /// <summary>
         /// Guardamos la informacion requerida.
         /// </summary>
         /// <param name="entity"></param>
         /// <returns></returns>
        public tbDetalleImpresion Guardar(tbDetalleImpresion entity)
        {

            try
            {

                using(dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    //Almacenamos la informacion.
                    context.tbDetalleImpresion.Add(entity);
                    context.SaveChanges();

                    return entity;

                }

            }
            catch (Exception ex)
            {

                throw new SaveEntityException(ex.Message);
            }


        }

         /// <summary>
         /// Actualizamos la informacion de la empresa en la base de datos.
         /// </summary>
         /// <param name="entity"></param>
         /// <returns></returns>
        public tbDetalleImpresion Actualizar(tbDetalleImpresion entity)
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

                throw new UpdateEntityException(ex.Message);
            }

        }

         /// <summary>
         /// Obtenemos la informacion de la empresa.
         /// </summary>
         /// <param name="entity"></param>
         /// <returns></returns>
        public tbDetalleImpresion GetEntity(tbDetalleImpresion entity)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    entity = (from p in context.tbDetalleImpresion
                              select p).SingleOrDefault();

                    return entity;
                
                }


            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

         /// <summary>
         /// Este no lo vamos a utlizar
         /// </summary>
         /// <param name="estado"></param>
         /// <returns></returns>
        public List<tbDetalleImpresion> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }
    }
}
