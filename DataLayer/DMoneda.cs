using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using CommonLayer.Interfaces;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;

namespace DataLayer
{
   public class DMoneda
    {

        public tbMonedas Guardar(tbMonedas monedas)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbMonedas.Add(monedas);
                    context.SaveChanges();

                }
                return monedas;
            }
            catch (EntityExistException ex)
            {

                throw ex;
            }
        }

        public tbMonedas Actualizar(tbMonedas moneda)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    //SE LE AGRAGA OTRO CONTEX CON LA RELACION A LA TABLA DE LA CUAL OCUPAMOS DATOS.....

                    context.Entry(moneda).State = System.Data.Entity.EntityState.Modified;

                  
                    context.SaveChanges();
                    return moneda;
                }

            }
            catch (Exception)
            {
                throw new UpdateEntityException(" Moneda  ");


            }
        }
        public List<tbMonedas> GetListEntitiesByTipo(int estado, int tipoMoneda)
        {
            try
            {
                using (dbSisSodInaEntities contex = new dbSisSodInaEntities())
                {

                    List<tbMonedas> monedas = new List<tbMonedas>();

                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        monedas = (from m in contex.tbMonedas.AsNoTracking().Include("tbTipoMoneda")
                                   where m.estado == true && m.idTipoMoneda==tipoMoneda
                                   select m).ToList();

                    }

                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        monedas = (from m in contex.tbMonedas
                                   where m.estado == false && m.idTipoMoneda == tipoMoneda
                                   select m).ToList();

                    }
                    if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {

                        monedas = (from m in contex.tbMonedas
                                   where m.idTipoMoneda == tipoMoneda
                                   select m 
                                   ).ToList();

                    }


                    return monedas;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<tbMonedas> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities contex = new dbSisSodInaEntities())
                {

                    List<tbMonedas> monedas = new List<tbMonedas>();

                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        monedas = (from m in contex.tbMonedas.AsNoTracking().Include("tbTipoMoneda")
                                   where m.estado == true
                                   select m).ToList();

                    }

                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        monedas = (from m in contex.tbMonedas
                                   where m.estado == false
                                   select m).ToList();

                    }
                    if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {

                        monedas = (from m in contex.tbMonedas
                                   select m).ToList();

                    }


                    return monedas;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public tbMonedas GetEntity(tbMonedas moned)
        {
            tbMonedas moneda;

            try
            {
                using (dbSisSodInaEntities contex = new dbSisSodInaEntities())
                {
                    moneda = (from m in contex.tbMonedas.Include("tbtipoMoneda")
                              where m.moneda == moned.moneda && m.idTipoMoneda == moned.idTipoMoneda
                              select m).SingleOrDefault();
                }
                return moneda;
            }
            
            catch (EntityExistException ex)
            {

                throw ex;
            }
        }

    }
}
