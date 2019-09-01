using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DCompras : IDataGeneric<tbCompras>
    {
        public int getNewID(int tipoDoc)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var existe = (from u in context.tbCompras
                                  where u.tipoDoc == tipoDoc
                                  orderby u.id descending
                                  select u);
                    if (existe.Count() == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        var x = (from u in context.tbCompras
                                 where u.tipoDoc == tipoDoc
                                 orderby u.id descending
                                 select u).Take(1);

                        return x.First().id;

                    }


                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return -1;

        }

        public tbCompras Actualizar(tbCompras entity)
        {
            throw new NotImplementedException();
        }

        public tbCompras GetEntity(tbCompras entity)
        {
            throw new NotImplementedException();
        }

        public List<tbCompras> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }

        public tbCompras Guardar(tbCompras entity)
        {
            try
            {
                
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    

                    context.tbCompras.Add(entity);                  
                   

                    context.SaveChanges();
                    
                }
                return entity;
            }
            catch (Exception ex)
            {

                throw new SaveEntityException("Error en Factura");
            }
        }
    }
}
