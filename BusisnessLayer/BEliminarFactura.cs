using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
namespace BusinessLayer
{
     public class BEliminarFactura
    {
        DEliminarFactura InsEliminarFac = new DEliminarFactura();

        public List<tbDocumento> ListaFaturas(int estado, DateTime fecha, string usuario) {
          return   InsEliminarFac.GetListEntitiesFactura(estado, fecha,usuario);

            
        }
        public List<tbDetalleDocumento> ListaDetalles(int id) {
            return InsEliminarFac.GetListEntitiesDetalle(id);
        }
        public tbDocumento eliminar(tbDocumento EliminarEntidad)
        {


            return InsEliminarFac .Actualizar(EliminarEntidad);

        }
    }
}
