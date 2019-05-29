using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions
{
  public   class IsNotANumberException: Exception
    {
        IsNotANumberException():base("Esta celda sólo permite ingresar números, por favor ingresa un número")
        {

        }
    }
}
