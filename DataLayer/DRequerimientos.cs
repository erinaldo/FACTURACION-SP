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
    public class DRequerimientos : IDataGeneric<tbRequerimientos>
    {

        public List<tbRequerimientos> GetListEntities(int estado)
        {

            try
            {
                List<tbRequerimientos> req = new List<tbRequerimientos>();
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        req=(from p in context.tbRequerimientos
                                where p.estado == true
                                select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        req=(from p in context.tbRequerimientos
                                where p.estado == false
                                select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {
                        req=(from p in context.tbRequerimientos
                                select p).ToList();
                    }
                }
                return req;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public tbRequerimientos Guardar(tbRequerimientos req)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbRequerimientos.Add(req);
                    context.SaveChanges();
                }

            }
            catch (SaveEntityException ex)
            {
                throw ex;

            }
            return req;
        }

        public tbRequerimientos Actualizar(tbRequerimientos req)
        {
            try
            {
                using (dbSisSodInaEntities update = new dbSisSodInaEntities())
                {

                    update.Entry(req).State = System.Data.Entity.EntityState.Modified;
                    update.SaveChanges();
                    return req;
                }
            }
            catch (UpdateEntityException ex)
            {
                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }

            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }


        }

        public tbRequerimientos GetEntity(tbRequerimientos req)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from u in context.tbRequerimientos
                            where u.idReq == req.idReq
                            select u).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }
        }



       

    }
}
