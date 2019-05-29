using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace BusinessLayer
{
   public class BTipoMoneda
    {
       // DTipoMedida TipoMonedaIns = new DTipoMedida();

        public  List<tbTipoMoneda> GetListTipoMoneda(int estado)
        {
            return DTipoMoneda.GetListTipoMoneda(1);
        }
    }
}
