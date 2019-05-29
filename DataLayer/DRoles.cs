using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;

namespace DataLayer
{
    //ESTABLESCO LA INTERFAZ QUE LLEBARA DICHA CAPA
    public class DRoles : IDataGeneric<tbRoles>
    {
    //CREO UN METODO Y OBTENGO LA ENTDIDAD ROL
        public tbRoles GetEntity(tbRoles roles)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from u in context.tbRoles.Include("tbRequerimientos")
                            where u.idRol == roles.idRol
                            select u).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }
        }
     //MANDO A GUARDAR EL ROL UNA VEZ YA QUE HALLA CONSULTADO SI EXISTE 
        public tbRoles Guardar(tbRoles rol)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    foreach (tbRequerimientos roles in rol.tbRequerimientos)
                    {
                        context.Entry(roles).State = System.Data.Entity.EntityState.Unchanged;
                    
                    }
                   
                   
                    context.tbRoles.Add(rol);
                    context.SaveChanges();
                }

            }
            catch (SaveEntityException ex)
            {
                throw ex;

            }
            return rol;
        }
  
       
        
      
          
        
        //METODO TANTO PARA MODIFICAR  LA ENTIDAD
        public tbRoles Actualizar(tbRoles rol_)
        {
         //NOTA=  NO SE MODIFICA...CORRECTAMENTE

            try
            {
                    using (dbSisSodInaEntities update = new dbSisSodInaEntities())
                    {
                    update.Entry(rol_).State = System.Data.Entity.EntityState.Modified;
                 
                    update.SaveChanges();
                }
                return rol_;

                }
                catch (UpdateEntityException ex)
                {

                    throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        //OBTENGO UN LISTA DE ENTIDADES O ROLES SEGUN SU ESTADO(1-2 o 3) (ACTIVOS,INACTVOS,O TODOS)
        public List<tbRoles> GetListEntities(int estado)
        {

            try
            {

                List<tbRoles> rol = new List<tbRoles>();

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        rol = (from p in context.tbRoles.Include("tbRequerimientos")
                               where p.estado==true
                               select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        rol = (from p in context.tbRoles.Include("tbRequerimientos")
                               where p.estado == false
                               select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {
                        rol = (from p in context.tbRoles.Include("tbRequerimientos")
                               select p).ToList();
                    }
                }
                return rol;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


    }
}
