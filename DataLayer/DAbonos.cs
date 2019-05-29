using CommonLayer.Exceptions.DataExceptions;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAbonos
    {
        public List<tbAbonos> GetListEntities()
        {
            // List<tbCreditos> listaCreditos;
            try
            {
                dbSisSodInaEntities context = new dbSisSodInaEntities();


                return (from p in context.tbAbonos
                        select p).ToList();//



            }
            catch (Exception)
            {
                throw new EntityException();
            }
        } //GetListEntities
        public tbAbonos Guardar(tbAbonos abono)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbAbonos.Add(abono);
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw ex;
                //throw new SaveEntityException();
            }


            return abono;
        } //Guardar

        public tbAbonos Modificar(tbAbonos abono)
        {
            try
            {
                tbAbonos creditoNuevo = new tbAbonos();
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(abono).State = System.Data.Entity.EntityState.Modified;//mnada entidad y la modifica
                    //Si viniera otra tabla relacionada que se debiera modificar se pone la misma linea de coduigo de arriba 
                    //y se manda a modificar
                    context.SaveChanges();
                    return creditoNuevo;
                }
            }
            catch (Exception ex)
            {
                throw new UpdateEntityException();
            }

        }
    }
}
