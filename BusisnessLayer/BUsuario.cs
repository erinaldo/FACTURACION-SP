using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using CommonLayer.Exceptions.BusisnessExceptions;


namespace BusinessLayer
{
    public class BUsuario
    {
        DUsuario usuarioIns = new DUsuario();

        DUsuario usuarioD = new DUsuario();






        //public static List<tbPersona> getListPersona()
        //{
        //    return DUsuario.getListPersona();
        //}
        public  tbUsuarios guardar(tbUsuarios usuario)
        {

            tbUsuarios user = usuarioIns.GetEntity(usuario);//verifica si existe en la base de datos 
            if (user == null)
            {
                
                return usuarioIns.Guardar(usuario);
            }
            else
            {
                if (user.estado == true)
                {
                    throw new EntityExistException("Usuario");
                }
                else
                {
                    throw new EntityDisableStateException("Usuario");
                    
                }
                    
                //exist = true;
                //return user;
            }
        }

        public  List<tbUsuarios> getListUsuario(int estado)
        {
            return usuarioIns.GetListEntities(estado);
        }

        public tbUsuarios eliminar(tbUsuarios usuario)
        {
            return usuarioIns.Actualizar( usuario);
        }

        public tbUsuarios modificar(tbUsuarios usuario)
        {
            return usuarioIns.Actualizar( usuario);
        }

        public  List<tbRoles> getRoles()
        {
            return DUsuario.getRoles();
        }



        //public static bool guardar(tbUsuarios usuario)
        //{

        //        return DUsuario.guardar(usuario);

        //}



        //Max aquí voy a crear un método para mi formulario Login.....
        //Esto me permite cargar los usuarios de la base de datos
        public tbUsuarios getLoginUsuario(tbUsuarios usuario)
        {

            return usuarioIns.GetLoginUsuario(usuario);

        }

        //Esto me permite cargar la lista de los requerimientos de la base de datos.
        public List<tbRequerimientos> getReque()
        {
            return usuarioIns.getReque();
        }

    }
}
