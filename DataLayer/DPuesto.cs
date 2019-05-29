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
    public class DPuesto:IDataGeneric<tbTipoPuesto>
    {
     


          public  tbTipoPuesto GetEntity(tbTipoPuesto entity)
           {
             tbTipoPuesto puesto;
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    puesto = (from p in context.tbTipoPuesto //desde a el el context de tabla puestos
                              where p.nombre ==entity.nombre //donde si p.nombre es = entity.nombre
                              select p).SingleOrDefault();//seleccione a

                }

                return puesto;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public  tbTipoPuesto Guardar(tbTipoPuesto entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbTipoPuesto.Add(entity);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return entity;

        }


        public tbTipoPuesto Actualizar(tbTipoPuesto entity)
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


                throw new UpdateEntityException("entity");
            }
       
        }


        public  List<tbTipoPuesto> GetListEntities(int estado)
        {

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    List<tbTipoPuesto> puesto = new List<tbTipoPuesto>();
                    if (estado == 1)
                    {
                        puesto = (from p in context.tbTipoPuesto
                                  where p.estado == true
                                  select p).ToList();


                    }
                    else if (estado == 2)
                    {

                        puesto = (from p in context.tbTipoPuesto
                                  where p.estado == false
                                  select p).ToList();

                    }
                    else if (estado == 3)
                    {

                        puesto = (from p in context.tbTipoPuesto
                                  select p).ToList();
                    }

                    return puesto;


                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
