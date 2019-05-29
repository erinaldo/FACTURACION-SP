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
    public class BExoneraciones
    {
        DExoneraciones exoneracion = new DExoneraciones();

     
        public List<tbExoneraciones> getListaExoneraciones()
        {
            return exoneracion.GetListEntities(3);     
        }



        
    }
}

