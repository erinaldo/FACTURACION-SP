using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Exceptions.DataExceptions;


namespace DataLayer
{
   public class DCajaUsuarioMonedas
    {
        public List<tbMonedas> CargarListaMonedas()
        {
            try
            {
                List<tbMonedas> listaMonedas;
                using(dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    listaMonedas = (from p in context.tbMonedas
                                    select p).ToList();
                }
                return listaMonedas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
      //public tbCajaUsuMonedas Guardar(tbCajaUsuMonedas cajaUsuMone)
      //  {
      //      try
      //      {
      //          using(dbSisSodInaEntities context = new dbSisSodInaEntities())
      //          {
      //              context.tbCajaUsuMonedas.Add(cajaUsuMone);
      //              context.SaveChanges();
      //          }
      //      }
      //      catch(Exception ex)
      //      {
      //          throw new SaveEntityException("Caja Usuario Monedas");
      //      }
      //      return cajaUsuMone;
      //  }

        
    }
}
