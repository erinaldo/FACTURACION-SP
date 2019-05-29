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
    public class BTipoVenta
    {
        DtipoVenta tipoVenta = new DtipoVenta();

       

       
        public List<tbTipoVenta> getListaTipoVenta()
        {
            return tipoVenta.GetListEntities(3);     
        }


        
    }
}

