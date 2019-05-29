using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Exceptions.DataExceptions
{
   public class ListEntityException:System.Exception
    {
        public ListEntityException() : base()
        {

        }
        public ListEntityException(string entityName) : 
            base("Error al obtener la lista de entidades "+ entityName+"")
        {

        }
    }
}
