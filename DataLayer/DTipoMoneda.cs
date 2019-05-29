using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace DataLayer
{
   public class DTipoMoneda
    {

        public static List<tbTipoMoneda> GetListTipoMoneda(int estado)
        {
            try
            {
                dbSisSodInaEntities contect = new dbSisSodInaEntities();

                return (from m in contect.tbTipoMoneda
                        where m.estado == true
                        select m).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
