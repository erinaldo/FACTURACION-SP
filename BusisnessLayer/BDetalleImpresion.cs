using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityLayer;
using DataLayer;




namespace BusinessLayer
{
    public class BDetalleImpresion
    {

        //Creamos la instancia global para acceder a los metedos de la DDetalleImpresion
        DDetalleImpresion detalleImpresionIns = new DDetalleImpresion();

        public tbDetalleImpresion Guardar(tbDetalleImpresion entity)
        {
            return detalleImpresionIns.Actualizar(entity);
        }

        public tbDetalleImpresion Actualizar(tbDetalleImpresion entity)
        {
            return detalleImpresionIns.Actualizar(entity);
        }

        public tbDetalleImpresion GetEntity(tbDetalleImpresion entity)
        {
            return detalleImpresionIns.GetEntity(entity);
        }

    }
}
