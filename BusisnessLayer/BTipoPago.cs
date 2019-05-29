using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
//using CommontLayer.exceptions.bussinessException;

namespace BusinessLayer
{
    public class BTipoPago
    {
        DTipoPago tipoPago = new DTipoPago();

       
        public List<tbTipoPago> getListaTipoPagos()
        {
            return tipoPago.GetListEntities(3);     
        }

        
    }
}

