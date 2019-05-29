using CommonLayer;
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
    public class DTiposMovimiento:IDataGeneric<tbTipoMovimiento>
    {
        public  tbTipoMovimiento GetEntity(tbTipoMovimiento tmovimiento)
        {
            tbTipoMovimiento movimiento;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    movimiento = (from p in context.tbTipoMovimiento
                                  where p.nombre == tmovimiento.nombre
                                  select p).SingleOrDefault();

                }
                return movimiento;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public  tbTipoMovimiento Guardar(tbTipoMovimiento movimiento)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbTipoMovimiento.Add(movimiento);
                    context.SaveChanges();
                }
            }
            catch (Exception )
            {
                throw new SaveEntityException("Tipo de Movimiento");
            }
            return movimiento;
        }
        public  tbTipoMovimiento Actualizar(tbTipoMovimiento movimiento)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(movimiento).State = System.Data.Entity.EntityState.Modified;
                    //se hay que modificar otra entidad se agrega la line ad earriba con el nombre de 
                    context.SaveChanges();
                    return movimiento;
                }
            }
            catch(Exception ex)
            {

                throw new UpdateEntityException("Actualizar");
            }
        }
        public  List<tbTipoMovimiento> GetListEntities()
        {

            return GetListEntities(3);

        }
        public  List<tbTipoMovimiento> GetListEntities(int estado)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    List<tbTipoMovimiento> movimiento = new List<tbTipoMovimiento>();
                    if (estado ==(int) Enums.EstadoBusqueda.Activo)
                    {
                        movimiento = (from p in context.tbTipoMovimiento
                                      where p.estado == true
                                      select p).ToList();


                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        movimiento = (from p in context.tbTipoMovimiento
                                      where p.estado == false
                                      select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {

                        movimiento = (from p in context.tbTipoMovimiento
                                      select p).ToList();
                    }

                    return movimiento;

                }
            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
