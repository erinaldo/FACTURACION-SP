using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Interfaces;
using CommonLayer;


namespace DataLayer
{
    public class DExoneraciones : IDataGeneric<tbExoneraciones>
    {
        public tbExoneraciones Actualizar(tbExoneraciones entity)
        {
            throw new NotImplementedException();
        }

        public tbExoneraciones GetEntity(int id)
        {
            try
            {



                using (dbSisSodInaEntities context = new dbSisSodInaEntities())//utilizamos el using para todas las consultas
                {



                    return (from tipIn in context.tbExoneraciones
                            where tipIn.id==id
                            select tipIn
                            ).SingleOrDefault();


                }





            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbExoneraciones GetEntity(tbExoneraciones entity)
        {
            throw new NotImplementedException();
        }

        public List<tbExoneraciones> GetListEntities(int estado)
        {
            try
            {



                using (dbSisSodInaEntities context = new dbSisSodInaEntities())//utilizamos el using para todas las consultas
                {



                    return (from tipIn in context.tbExoneraciones
                            select tipIn).ToList();


                }





            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbExoneraciones Guardar(tbExoneraciones entity)
        {
            throw new NotImplementedException();
        }
    }
}





