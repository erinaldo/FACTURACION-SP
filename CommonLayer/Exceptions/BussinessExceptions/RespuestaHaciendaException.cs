using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.BussinessExceptions
{
    public class RespuestaHaciendaException : Exception
    {
        public RespuestaHaciendaException()
        {
        }

        public RespuestaHaciendaException(Exception ex) : base(ex.Message)
        {
        }
    }
}
