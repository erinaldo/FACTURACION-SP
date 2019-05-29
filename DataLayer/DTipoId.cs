using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Interfaces;
using CommonLayer;


namespace DataLayer
{
    public class DTipoId : IDataGeneric<tbTipoId>
    {
        public tbTipoId Actualizar(tbTipoId entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoId GetEntity(tbTipoId entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoId> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                   
                        return (from T in context.tbTipoId                               
                                select T).ToList();
                  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbTipoId Guardar(tbTipoId entity)
        {
            throw new NotImplementedException();
        }
    }
}





