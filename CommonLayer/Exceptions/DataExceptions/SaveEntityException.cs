using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonLayer.Exceptions.DataExceptions
{
   public class SaveEntityException:System.Exception
    {
        public SaveEntityException() : base()
        {

        }
        public SaveEntityException(string entityName) : 
            base("Error al guardar la entidad " + entityName)
        {

        }
    }
}
