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
    public class DtipoVenta : IDataGeneric<tbTipoVenta>
    {
        public tbTipoVenta Actualizar(tbTipoVenta entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoVenta GetEntity(tbTipoVenta entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoVenta> GetListEntities(int estado)
        {
            try
            {



                using (dbSisSodInaEntities context = new dbSisSodInaEntities())//utilizamos el using para todas las consultas
                {



                    return (from tipIn in context.tbTipoVenta
                            select tipIn).ToList();


                }





            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbTipoVenta Guardar(tbTipoVenta entity)
        {
            throw new NotImplementedException();
        }
    }
}





