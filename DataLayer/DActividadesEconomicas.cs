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
    public class DActividadesEconomicas : IDataGeneric<tbActividades>
    {
        public tbActividades Actualizar(tbActividades entity)
        {
            throw new NotImplementedException();
        }

        public tbActividades GetEntity(tbActividades entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())

                    return (from p in context.tbActividades
                               where p.codigoAct == entity.codigoAct
                               select p).SingleOrDefault();

              

            }
            catch (Exception)
            {

                throw new SaveEntityException("Actividad Economica");
            }
        }

        public List<tbEmpresaActividades> getListaEmpresaActividad(string id, int tipo)
        {
            try
            {
                // SE AGREGA EL USING
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())

                    //PARA JALAR LOS DATOS DE LAS TABLAS RELACIONADAS SE USA LA PALABRA RESERVADA INCLUDE....Y ENTRE("")EL NOMBRE DE LAS TABLAS RELACIONADAS.
                    return (from p in context.tbEmpresaActividades
                            where p.idEmpresa == id && p.tipoId == tipo
                            select p
                           ).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tbActividades> GetListEntities(int estado)
        {        
            try
            {
                // SE AGREGA EL USING
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                   
                        //PARA JALAR LOS DATOS DE LAS TABLAS RELACIONADAS SE USA LA PALABRA RESERVADA INCLUDE....Y ENTRE("")EL NOMBRE DE LAS TABLAS RELACIONADAS.
                         return  (from p in context.tbActividades
                                select p).ToList();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbActividades Guardar(tbActividades entity)
        {
            throw new NotImplementedException();
        }
    }
}
