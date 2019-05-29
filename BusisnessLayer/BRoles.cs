using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using EntityLayer;
using DataLayer;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace BusinessLayer
{
    public class BRoles
    {
        //Creamos una instancia para llamar la capa de datos.
        DRoles DrolesIsnt = new DRoles();
      

        public tbRoles Guardar(tbRoles rol)
        {

            tbRoles rolEntity = DrolesIsnt.GetEntity(rol);//consulto si existe dicha entidad
            if (rolEntity == null)//si esta vacio  
            {
              
                return DrolesIsnt.Guardar(rol);// envio a guardar
            }
            else
            {
                if (rolEntity.estado)//Si existe entonces se manejaran  las siguien excepciones
                {
                    throw new EntityExistException(" Roles");
                }
                else
                {

                    throw new EntityDisableStateException(" Roles");
                }

            }
        }

        //Obtener La Entidad
        public tbRoles GetEntity(tbRoles rol)
        {
            return DrolesIsnt.GetEntity(rol);
        }

        //Modificar la Entidad
        public tbRoles Modificar(tbRoles rol)
        {
           return DrolesIsnt.Actualizar(rol);
        }
        //Eliminar la Entidad
        public tbRoles Eliminar(tbRoles rol)
        {
            return DrolesIsnt.Actualizar(rol);
        }
        //Obtener una lista de entidades
        public List<tbRoles> GetListEntity(int estado)
        {
            return DrolesIsnt.GetListEntities(estado);
        }

    }
}
