using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.BussinessExceptions
{
    public class ConsultaHaciendaExcpetion: Exception
    {
        public ConsultaHaciendaExcpetion() : base()
        {

        }
        public ConsultaHaciendaExcpetion(Exception ex) :
           base(ex.Message)
        {

        }
    }
}
