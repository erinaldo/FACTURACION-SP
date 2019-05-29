using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
namespace BusinessLayer
{
    public class BRequerimientos
    {

        DRequerimientos reqIns = new DRequerimientos();

        public tbRequerimientos guardar(tbRequerimientos requeri)
        {
            try
            {
            return reqIns.Guardar(requeri);
            }

            catch (Exception ex)
            {
                throw;
            }
        }


        public List<tbRequerimientos> GetListEntities(int estado)
        {
            return reqIns.GetListEntities(estado);
        }


        public tbRequerimientos Actualizar(tbRequerimientos requeri)
        {
            try
            {
                return requeri = reqIns.Actualizar(requeri);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public tbRequerimientos GetEntity(tbRequerimientos requeri)
        {
            return reqIns.GetEntity(requeri);
        }

        public tbRequerimientos eliminar(tbRequerimientos requeri)
        {
            try
            {
                return reqIns.Actualizar(requeri);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
