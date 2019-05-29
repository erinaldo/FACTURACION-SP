using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Exceptions.DataExceptions;

namespace DataLayer
{
    public class DCajaUsuario
    {
        //Consigue entidad que consida con fecha de hoy y caja utilizada
        public tbCajaUsuario GetEntityCajausuarioByFecha(tbCajaUsuario cajaUsuario, tbCajaUsuario numCaja)
        {
            tbCajaUsuario cajaUsu;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    cajaUsu = (from p in context.tbCajaUsuario//.Include("tbCajas")
                               where p.fecha == cajaUsuario.fecha && p.idCaja == numCaja.idCaja// && p.idCaja == cajaUsuario.idCaja
                               select p).SingleOrDefault();
                }
            }
            catch (EntityException ex)
            {
                throw new EntityException();
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException();//cuando hay mas de una entidad que coincida con la busqueda
            }
            return cajaUsu;

        }

        public tbCajaUsuario GetNumeroCaja(tbCajaUsuario caja)
        {
            tbCajaUsuario cajas;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    cajas = (from p in context.tbCajaUsuario
                               where p.idCaja == caja.id
                               select p).SingleOrDefault();
                }
            }
            catch (EntityException ex)
            {
                throw new EntityException();
            }
            return cajas;

        }

       


        public tbCajaUsuario GetNombreUsuario(tbCajaUsuario usuario, tbCajaUsuario caja)
        {
            tbCajaUsuario usuario1;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    usuario1 = (from p in context.tbCajaUsuario
                                where p.idUser == usuario.idUser && p.idCaja == caja.idCaja
                                select p).SingleOrDefault();
                }
            }
            catch (EntityException ex)
            {
                throw new EntityException();
            }
            return usuario1;
        }
        public tbCajaUsuario GetEntityCajaUsuarioByTipoMovCaja(tbCajaUsuario cajaUsuario)
        {
            tbCajaUsuario cajaUsu;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    cajaUsu = (from p in context.tbCajaUsuario
                               where p.tipoMovCaja == cajaUsuario.tipoMovCaja
                               select p).SingleOrDefault();
                }
            }
            catch (EntityException ex)
            {
                throw new EntityException();
            }
            return cajaUsu;
        }
        public tbCajaUsuario Guardar(tbCajaUsuario cajaUsuario)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbCajaUsuario.Add(cajaUsuario);
                    context.SaveChanges();
                }
            }
            catch (SaveEntityException ex)
            {
                throw new SaveEntityException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cajaUsuario;
        }

    }
}
