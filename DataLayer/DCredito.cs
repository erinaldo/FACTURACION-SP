using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;

namespace DataLayer
{
   public class DCredito:  IDataGeneric<tbCreditos> 
    {

        public  tbCreditos GetEntity(tbCreditos elCredito)
        {
            tbCreditos credito;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    credito = (from p in context.tbCreditos.Include("tbMovimientos.tbTipoMovimiento")
                               where p.idCredito == elCredito.idCredito
                               select p).SingleOrDefault();//singleordefault me conviete en un solo registro
                }
                return credito;
            }
            catch (Exception)
            {
                throw new EntityException();
            }


        }
        public  tbCreditos Guardar(tbCreditos credito)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbCreditos.Add(credito);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw ex;
                //throw new SaveEntityException();
            }


            return credito;
        } //Guardar

        public  List<tbCreditos> GetListEntities( int estado)
        {
           // List<tbCreditos> listaCreditos;
            try
            {
                dbSisSodInaEntities context = new dbSisSodInaEntities();
                
                    if (estado == 1)
                    {
                        return (from p in context.tbCreditos
                                         where p.idEstado == true
                                         select p).ToList();//
                    }
                if (estado == 2)
                {
                    return (from p in context.tbCreditos
                            where p.idEstado == false
                            select p).ToList();//
                }
                else
                {
                    return (from p in context.tbCreditos
                             select p).ToList();//
                }


            }
            catch (Exception)
            {
                throw new EntityException();
            }
        } //GetListEntities
        public tbCreditos Modificar(tbCreditos credito)
        {
            try
            {
                tbCreditos creditoNuevo = new tbCreditos();
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    creditoNuevo = GetEntity(credito);

                    if (creditoNuevo == null)
                    {
                        context.tbCreditos.Add(credito);
                    }
                    else
                    {
                        context.Entry(credito).State = System.Data.Entity.EntityState.Modified;//mnada entidad y la modifica

                    }

                   
                    //Si viniera otra tabla relacionada que se debiera modificar se pone la misma linea de coduigo de arriba 
                    //y se manda a modificar
                    context.SaveChanges();
                    return creditoNuevo;
                }
            }
            catch(Exception ex)
            {
                throw new UpdateEntityException();
            }

        } //Modificar
        /// <summary>
        /// metodo que obtiene la lista de creditos de una sola persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  List<tbCreditos> obtenerListaCreditos(string id)
        {
            List<tbCreditos> credito;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    credito = (from p in context.tbCreditos.Include("tbAbonos")//.Include("tbTipoMovimiento")
                               where p.idCliente == id && p.idEstado == true
                               select p).ToList();//singleordefault me conviete en un solo registro
                }
                return credito;
            }
            catch (Exception e)
            {
                throw e;
            }

        } //obtenerListaCreditos

        public tbCreditos Actualizar(tbCreditos entity)
        {
            throw new NotImplementedException();
        }
    }
}
