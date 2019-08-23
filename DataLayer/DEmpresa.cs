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
    public class DEmpresa : IDataGeneric<tbEmpresa>
    {
        public tbEmpresa Actualizar(tbEmpresa entity)
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
            catch (Exception EX)
            {
                throw new UpdateEntityException(" Empresas  ");


            }
        }

        public tbParametrosEmpresa ActualizarParametros(tbParametrosEmpresa entity)
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
            catch (Exception EX)
            {
                throw new UpdateEntityException(" Parámetros Empresa  ");


            }
        }

        public tbEmpresa GetEntity(tbEmpresa entity)
        {


    


            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())

                    entity = (from p in context.tbEmpresa.Include("tbPersona").Include("tbParametrosEmpresa")
                               where p.id == entity.id
                               && p.tipoId == entity.tipoId

                               select p).SingleOrDefault();

                return entity;

            }
            catch (Exception)
            {

                throw new SaveEntityException("Empresa");
            }

        }

        public tbParametrosEmpresa GetEntityParametros(tbParametrosEmpresa entity)
        {





            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())

                    entity = (from p in context.tbParametrosEmpresa
                              where p.idEmpresa == entity.idEmpresa
                              && p.idTipoEmpresa == entity.idTipoEmpresa

                              select p).SingleOrDefault();

                return entity;

            }
            catch (Exception)
            {

                throw new SaveEntityException("Parámetros Empresa");
            }

        }

        public List<tbEmpresa> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }

        public tbEmpresa Guardar(tbEmpresa entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                  

                    context.tbEmpresa.Add(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw new SaveEntityException("Empresa");

            }
            return entity;

        }

        public tbParametrosEmpresa GuardarParametros(tbParametrosEmpresa entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {



                    context.tbParametrosEmpresa.Add(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw new SaveEntityException("Empresa");

            }
            return entity;

        }
    }
}
