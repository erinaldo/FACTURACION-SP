using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.BussinessExceptions
{
    public class generarXMLException:Exception
    {
        public generarXMLException() : base()
        {

        }
        public generarXMLException(Exception ex) :
           base(ex.Message)
        {

        }
    }
}
