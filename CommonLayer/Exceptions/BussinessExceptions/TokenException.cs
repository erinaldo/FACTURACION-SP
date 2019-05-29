using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.BussinessExceptions
{
    public class TokenException: Exception
    {
        public TokenException() : base()
        {

        }
        public TokenException(Exception ex) :
           base(ex.Message)
        {

        }
    }
}
