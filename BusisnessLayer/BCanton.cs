using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   
    public class BCanton
    {
        DCanton cantonIns = new DCanton();

        public tbCanton GetEntity(string idC, string idP)
        {
            return cantonIns.GetEntity(idC, idP);
        }
    }
}
