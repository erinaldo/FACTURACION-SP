using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class DDetalleProducto : IDataGeneric<tbDetalleProducto>
    {
        public tbDetalleProducto Actualizar(tbDetalleProducto entity)
        {
            throw new NotImplementedException();
        }

        public tbDetalleProducto GetEntity(tbDetalleProducto entity)
        {
            throw new NotImplementedException();
        }

        public List<tbDetalleProducto> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }

        public tbDetalleProducto Guardar(tbDetalleProducto entity)
        {
            throw new NotImplementedException();
        }

        public List<tbDetalleProducto> GetListEntitiesByIdProduct(string idProducto)
        {


            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return  (from d in context.tbDetalleProducto
                                    where d.idProducto == idProducto
                                    select d).ToList();


                }

            return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          

        }


    }
}
