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
    public class DMovimientos : IDataGeneric<tbMovimientos>
    {
        DInventario inventarioD = new DInventario();
        public tbMovimientos GetEntity(tbMovimientos elMovimiento)
        {
            
            
            tbMovimientos movimiento;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    movimiento = (from p in context.tbMovimientos.Include("tbTipoMovimiento")
                                  where p.idMovimiento == elMovimiento.idMovimiento
                                  select p).SingleOrDefault();//singleordefault me conviete en un solo registro
                }
                return movimiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public tbMovimientos Guardar(tbMovimientos movimientos)
        {
            tbInventario inv;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    if (movimientos.idTipoMov == (int)Enums.tipoMovimiento.PagoProveedor)
                    {
            
                   
                        foreach (tbDetalleMovimiento detalle in movimientos.tbDetalleMovimiento)
                        {
                            //inv = new tbInventario();
                            //inv.idIngrediente = detalle.idIngrediente;
                            //inv = inventarioD.GetEntity(inv);
                            //inv.cantidad = inv.cantidad + detalle.cantidad;

                            //inv.fecha_ult_mod = movimientos.fecha_ult_mod;
                            //inv.usuario_ult_mod = movimientos.usuario_ult_mod;
                            //context.Entry(inv).State = System.Data.Entity.EntityState.Modified;

                        }



       


                    }
                         context.tbMovimientos.Add(movimientos);
                        
                          context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return movimientos;
        }
        public tbMovimientos Modificar(tbMovimientos modificarMov)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(modificarMov).State = System.Data.Entity.EntityState.Modified;//mnada entidad y la modifica
                    context.SaveChanges();
                    return modificarMov;
                }
            }
            catch (Exception)
            {
                throw new UpdateEntityException();
            }

        }
        public List<tbMovimientos> GetListEntities()
        {
            return GetListEntities(1);
        }
        public List<tbMovimientos> GetListEntities(int estado)
        {
            //List<tbMovimientos> listaMov;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    if(estado==1)
                    {
                        return (from p in context.tbMovimientos.Include("tbDetalleMovimiento").Include("tbTipoMovimiento").Include("tbDetalleMovimiento.tbIngredientes.tbTipoMedidas")
                                where p.estado == true
                                select p).ToList();//
                    }
                    else if(estado==2)
                    {
                        return (from p in context.tbMovimientos.Include("tbDetalleMovimiento").Include("tbTipoMovimiento").Include("tbDetalleMovimiento.tbIngredientes.tbTipoMedidas")
                                where p.estado == false
                                select p).ToList();//
                    }
                    else
                    {
                        return (from p in context.tbMovimientos.Include("tbDetalleMovimiento").Include("tbTipoMovimiento").Include("tbDetalleMovimiento.tbIngredientes.tbTipoMedidas")
                                select p).ToList();//
                    }
                    
                }
               
            }
            catch (Exception ex)
            {
                throw new ListEntityException("Lista");
            }

        }

        public tbMovimientos Actualizar(tbMovimientos entity)
        {
            throw new NotImplementedException();
        }

        public tbMovimientos ModificarLista(List<tbMovimientos> modificarMov)
        {
            try
            {
                tbMovimientos mov = new tbMovimientos();
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(mov).State = System.Data.Entity.EntityState.Modified;//mnada entidad y la modifica
                    context.SaveChanges();
                    return mov;
                }
            }
            catch (Exception)
            {
                throw new UpdateEntityException();
            }

        }

    }
}
