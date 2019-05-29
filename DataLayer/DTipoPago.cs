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
    public class DTipoPago : IDataGeneric<tbTipoPago>
    {
        public tbTipoPago Actualizar(tbTipoPago entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoPago GetEntity(tbTipoPago entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoPago> GetListEntities(int estado)
        {
            try
            {



                using (dbSisSodInaEntities context = new dbSisSodInaEntities())//utilizamos el using para todas las consultas
                {



                    return (from tipIn in context.tbTipoPago
                            select tipIn).ToList();


                }





            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public tbTipoPago Guardar(tbTipoPago entity)
        {
            throw new NotImplementedException();
        }
    }
}





