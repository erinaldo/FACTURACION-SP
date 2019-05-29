using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Interfaces
{
   public interface IDataGeneric<T>
    {
        T Guardar(T entity);
        T Actualizar(T entity);
        T GetEntity(T entity);
        List<T> GetListEntities(int estado);
    }
}
