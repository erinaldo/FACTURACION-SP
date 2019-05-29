using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class DDetalleProdcuto : IDataGeneric<tbDetalleProducto>
    {
        public tbDetalleProducto Actualizar(tbDetalleProducto entity)
        {
            throw new NotImplementedException();
        }

        public tbDetalleProducto GetEntity(tbDetalleProducto entity)
        {
            throw new NotImplementedException();
        }

        public tbDetalleProducto GetEntityById( int id)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return  (from p in context.tbDetalleProducto
                              where p.id == id
                              select p).SingleOrDefault();

                 
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }

        }

        public List<tbDetalleProducto> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }

        public tbDetalleProducto Guardar(tbDetalleProducto entity)
        {
            throw new NotImplementedException();
        }
    }
}
