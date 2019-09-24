using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;
using CommonLayer;


namespace DataLayer
{
    public class DUsuario : IDataGeneric<tbUsuarios>
    {
        DPersona persona = new DPersona();
        public List<tbUsuarios> GetListEntities(int estado)
        {
            
            try
            {
                List<tbUsuarios> usuario = new List<tbUsuarios>();
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    
                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        return (from p in context.tbUsuarios.Include("tbPersona").Include("tbEmpresa.tbParametrosEmpresa")
                                where p.estado == true
                                select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        return (from p in context.tbUsuarios.Include("tbPersona").Include("tbEmpresa.tbParametrosEmpresa")
                                where p.estado == false
                                select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {
                        return (from p in context.tbUsuarios.Include("tbPersona").Include("tbEmpresa.tbParametrosEmpresa")
                                select p).ToList();
                    }

                }
                

                return usuario;


            }
            catch (Exception ex)
            {
                throw ex;

            }




        }


        public tbUsuarios Guardar(tbUsuarios usuario)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    if (persona.GetEntity(usuario.tbPersona) != null)
                    {


                        context.Entry(usuario.tbPersona).State = System.Data.Entity.EntityState.Modified;



                    }
                    context.tbUsuarios.Add(usuario);
                    context.SaveChanges();
                }

            }
            catch (SaveEntityException ex)
            {
                throw ex;
                
            }
            return usuario;
        }




        //public static List<tbUsuarios> getListtUsuario()
        //{
        //    try
        //    {
        //       dbSisSodInaEntities1 context = new dbSisSodInaEntities1();

        //            return (from u in context.tbUsuarios
        //                           where u.estado == true
        //                           select u).ToList();


                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;

        //    }
        //}
            



        public bool eliminar(tbUsuarios usuario)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(usuario.tbPersona).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }




        /// <summary>
        /// Retornamos los diferentes roles de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<tbRoles> getRoles()
        {

            List<tbRoles> listaUsuario;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    listaUsuario = (from p in context.tbRoles
                                    select p).ToList();

                    return listaUsuario;
                }
            }
            catch (SaveEntityException ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);  
            }
        }




        public tbUsuarios Actualizar(tbUsuarios usuario)
        {

      
            try
            {
                using (dbSisSodInaEntities update = new dbSisSodInaEntities())
                {
                    //update.tbPersona.Attach(usuario.tbPersona);
                    update.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                    update.Entry(usuario.tbPersona).State = System.Data.Entity.EntityState.Modified;
                    update.SaveChanges();
                    return usuario;
                }
            }
            catch (UpdateEntityException ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }
        }




        public  tbUsuarios GetEntity (tbUsuarios usuario)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    return (from u in context.tbUsuarios
                            where u.id == usuario.id && u.tipoId == usuario.tipoId
                            select u).SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }
        }


        //MAX método para mi formulario Login...

        public tbUsuarios GetLoginUsuario(tbUsuarios usuario)
        {
            try
            {
                tbUsuarios uslogin; //= new tbUsuarios();
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    uslogin = (from us in context.tbUsuarios.Include("tbPersona").Include("tbEmpresa.tbParametrosEmpresa")
                               where us.nombreUsuario == usuario.nombreUsuario && us.contraseña == usuario.contraseña
                               select us).SingleOrDefault();
                    if (uslogin !=null)
                    {
                        uslogin.tbPersona = (from us in context.tbPersona.Include("tbBarrios.tbDistrito.tbCanton.tbProvincia")
                                             where us.identificacion == uslogin.id && us.tipoId == uslogin.tipoId
                                             select us).SingleOrDefault();
                    }
                    else
                    {
                        throw new Exception("Datos incorrectos");
                    }

                
                }
                return uslogin;
            }
            catch (EntityException ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.Message);
            }
        }

        //Extraer la lista de requerimientos de la base de datos.
        public List<tbRequerimientos> getReque()
        {
            List<tbRequerimientos> listaReque;
            using (dbSisSodInaEntities context = new dbSisSodInaEntities())
            {
                listaReque = (from p in context.tbRequerimientos
                              select p).ToList();

                return listaReque;
            }
        }


    }
}

       