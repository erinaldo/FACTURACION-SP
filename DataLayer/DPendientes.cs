using CommonLayer.Interfaces;
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

        public List<tbDocumentosPendiente> GetListEntities(int estado)
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

        public tbDocumentosPendiente Guardar(tbDocumentosPendiente entity)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    context.tbDocumentosPendiente.Add(entity);
                    context.SaveChanges();
                    return entity;

                }
            }
            catch (Exception)

            {
                throw new EntityException();
            }
        }

        public tbDocumentosPendiente GetEntityByAlias(string alias)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var pend= (from p in context.tbDocumentosPendiente.Include("tbDetalleDocumentoPendiente")
                            where p.alias.Trim().ToUpper()==alias select p).SingleOrDefault();
                    if (pend!=null)
                    {
                        foreach (var item in pend.tbDetalleDocumentoPendiente)
                        {
                            item.tbProducto = productoIns.GetEntityById(item.idProducto);
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
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    var pend = GetEntityByAlias(alias);
                    if (pend!=null)
                    {
                        foreach (var item in pend.tbDetalleDocumentoPendiente)
                        {
                            context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                        }
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
            catch (Exception)

            {
                throw new EntityException();
            }
        }

        public bool removeAll()
        {
            try
            {
                var lista = GetListEntities(1);
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

    }
}
