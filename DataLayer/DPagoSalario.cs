
using EntityLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer;
using CommonLayer.Interfaces;

//using CommonLayer.Exceptions.DataExceptions;
//using CommonLayer.Interfaces;
//using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DPagoSalario : IDataGeneric<tbPagos>
    {

        public tbPagos GetEntity(tbPagos PagoSa)
        {
            tbPagos pago;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                    pago = (from P in context.tbPagos
                            where P.id == PagoSa.id
                            && P.id == PagoSa.tipoId
                            select P).SingleOrDefault();
                return pago;
            }
            catch (Exception)
            {
                throw new SaveEntityException("pagos");
            }


        }
        public tbPagos Actualizar(tbPagos pagos)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                    context.Entry(pagos).State = System.Data.Entity.EntityState.Modified;
                
                 
               // context.saveChanges();

               //context.Entry(entity.tbEmpleado.tbTipoPuesto.).State = System.Data.Entity.EntityState.Modified;

                return pagos;
            }
            catch (Exception)
            {

                throw new UpdateEntityException("pagos");
            }
        }

        public static List<tbTipoPuesto> getTipoPuesto_PagoS()
        {
            List<tbTipoPuesto> tipoPuesto;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    tipoPuesto = (from P in context.tbTipoPuesto select P).ToList();
                    return tipoPuesto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         

        public List<tbPagos> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        return (from P in context.tbPagos.Include("tbEmpleado").Include("tbMovimientos")
                                where P.tbEmpleado.estado == true
                                select P).ToList();
                    }
                    if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        return (from P in context.tbPagos.Include("tbEmpleado").Include("tbMovimientos")
                                where P.tbEmpleado.estado == false
                                select P).ToList();
                    }
                    return (from P in context.tbPagos.Include("tbEmpleado").Include("tbMovimientos")
                            select P).ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 


        public tbPagos Guardar(tbPagos PagoSalario)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    context.tbPagos.Add(PagoSalario);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new SaveEntityException("PagoSalario");
            }
            return PagoSalario;
        }
       
    }
}
