using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.BusisnessExceptions
{
   public class EntityDisableStateException:System.Exception
    {


        public EntityDisableStateException() : base()
        {

        }
        public EntityDisableStateException(string entityName) : base("La entidad "+entityName+" se encuentra en la base de datos desabilitada, desea habilitarla?")
        {

        }
    }
}
