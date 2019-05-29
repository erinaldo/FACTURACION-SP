using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.BussinessExceptions
{
    public class FacturacionElectronicaException: Exception
    {

        public FacturacionElectronicaException() : base()
        {

        }
        public FacturacionElectronicaException(Exception ex) :
           base(ex.Message)
        {

        }

    }
}
