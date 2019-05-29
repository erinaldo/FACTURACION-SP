using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using DataLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Interfaces;
namespace BusinessLayer
{
   public class BProvincias

    {
        DProvincia InsProvincia = new DProvincia();

        

        public List<tbProvincia> getListTipoing(int estado)
        {


            return InsProvincia.GetListEntities(estado);


        }

        

    }
}
