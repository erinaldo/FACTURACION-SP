using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DPendientes : IDataGeneric<tbDocumentosPendiente>
    {
        DProductos productoIns = new DProductos();
        public tbDocumentosPendiente Actualizar(tbDocumentosPendiente entity)
        {
            throw new NotImplementedException();
        }

        public tbDocumentosPendiente GetEntity(tbDocumentosPendiente entity)
        {
            throw new NotImplementedException();
        }

        public List<tbDocumentosPendiente> GetListEntities()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from p in context.tbDocumentosPendiente select p).ToList();

                }
            }
            catch (Exception)

            {
                throw new EntityException();
            }
        }

        public int CantidadPendientes()
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return context.tbDocumentosPendiente.Count();

                }
            }
            catch (Exception)

            {
                throw new EntityException();
            }
        }

        public tbDocumentosPendiente Guardar(tbDocumentosPendiente entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    //busci el nuevo alias, para borrarlo y crear con los datos nuevos
                    var pend = GetEntityByAlias(entity.alias, false);
                    if (pend != null)
                    {

                        context.tbDetalleDocumentoPendiente.RemoveRange(context.tbDetalleDocumentoPendiente.Where(x => x.alias == pend.alias).ToList());
                        pend.tbDetalleDocumentoPendiente = null;
                        context.Entry(pend).State = System.Data.Entity.EntityState.Deleted;                      

                    }


                    context.tbDocumentosPendiente.Add(entity);
                    context.SaveChanges();
                    return entity;

                }
            }
            catch (Exception ex)

            {
                throw new EntityException();
            }
        }
        public tbDocumentosPendiente GetEntityByAlias(string alias)
        {
           return GetEntityByAlias(alias, true);

        }
        public tbDocumentosPendiente GetEntityByAlias(string alias, bool anexas)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var pend= (from p in context.tbDocumentosPendiente.Include("tbDetalleDocumentoPendiente")
                            where p.alias.Trim().ToUpper()==alias.Trim().ToUpper() select p).SingleOrDefault();
                    if (anexas)
                    {
                        if (pend != null)
                        {
                            foreach (var item in pend.tbDetalleDocumentoPendiente)
                            {
                                item.tbProducto = productoIns.GetEntityById(item.idProducto);
                            }
                        }
                    }


                    
                    return pend;
                }
            }
            catch (Exception)

            {
                throw new EntityException();
            }
        }

        public bool existAlias(string alias)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var pend = (from p in context.tbDocumentosPendiente
                                where p.alias.Trim().ToUpper() == alias
                                select p).SingleOrDefault();
                    
                    return pend!=null;
                }
            }
            catch (Exception)

            {
                throw new EntityException();
            }
        }

        public bool removeByAlias(string alias)
        {

            try
            {    var pend = GetEntityByAlias(alias,false);
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                          
                    if (pend!=null)
                    {

                       context.tbDetalleDocumentoPendiente.RemoveRange(context.tbDetalleDocumentoPendiente.Where(x => x.alias == pend.alias).ToList());
                        pend.tbDetalleDocumentoPendiente = null;                     
                        context.Entry(pend).State = System.Data.Entity.EntityState.Deleted;

                        context.SaveChanges();
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)

            {
                throw new EntityException();
            }
        }

        public bool removeAll()
        {
            try
            {
                var lista = GetListEntities();
                foreach (var pend in lista)
                {
                    removeByAlias(pend.alias);
                }
                return true;

            }
            catch (Exception)
            {

                throw new EntityException();
            }
            


        }

        public List<tbDocumentosPendiente> GetListEntities(int estado)
        {
            throw new NotImplementedException();
        }
    }
}
