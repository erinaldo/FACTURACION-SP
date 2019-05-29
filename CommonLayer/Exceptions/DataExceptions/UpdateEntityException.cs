using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonLayer.Exceptions.DataExceptions
{
   public class UpdateEntityException:Exception
    { 
        public UpdateEntityException() : base()
        {

        }
        public UpdateEntityException(string entityName) : 
            base("Error al actualizar la entidad "+entityName)
        {

        }

    }
}
