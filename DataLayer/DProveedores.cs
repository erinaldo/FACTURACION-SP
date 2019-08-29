using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using CommonLayer.Interfaces;
using CommonLayer.Exceptions.DataExceptions;



namespace DataLayer
{ 
    public class DProveedores: IDataGeneric<tbProveedores>
    {
        DPersona persona = new DPersona();

        public tbProveedores Guardar(tbProveedores proveedor)
        {

            //manejo de excepciones si se guardan correctamente o no 
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    if (persona.GetEntity(proveedor.tbPersona) != null)
                    {
                        context.Entry(proveedor.tbPersona).State = System.Data.Entity.EntityState.Modified;

                        

                    }
                        // estoy agragando los datos de proveedor
                     context.tbProveedores.Add(proveedor);
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                throw new SaveEntityException("Proveedores");
            }


            return proveedor;
        }

        //getProveedor(string nombreProveedor) ----> obtenga el proveedor
        public tbProveedores GetEntity(tbProveedores nombreProveedor)
        {
            tbProveedores proveedor;

            try
            {
                using(dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    //consulatr de la tabla lo que esté en el contexto y lo que este en el contexto lo mete en p 
                    proveedor = (from p in context.tbProveedores
                                 where p.tbPersona.identificacion == nombreProveedor.tbPersona.identificacion
                                 select p).SingleOrDefault();//SingleOrDefault() para que la consulta linq la convierta el un solo objeto o registro o entidad

                    return proveedor;
                }
            }

            catch (Exception ex)
            {
                throw ex;

            }

        }






        public tbProveedores Actualizar(tbProveedores proveedor)
        {
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                   
                      context.Entry(proveedor.tbPersona).State = System.Data.Entity.EntityState.Modified;          
       
                    context.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                  
                    context.SaveChanges();
                    return proveedor;
                }
            }

            catch(Exception ex)
            {
                throw new UpdateEntityException("Proveedor");
            }
        }





        tbProveedores IDataGeneric<tbProveedores>.Actualizar(tbProveedores entity)
        {
            throw new NotImplementedException();
        }



        public List<tbProveedores> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        return (from p in context.tbProveedores.Include("tbPersona")
                                    where p.estado == true
                                    select p).ToList();
                        }
                        else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                        {
                            return (from p in context.tbProveedores.Include("tbPersona")
                                    where p.estado == false
                                    select p).ToList();

                        }

                        else if (estado == (int)Enums.EstadoBusqueda.Todos)
                        {
                            return (from p in context.tbProveedores.Include("tbPersona")

                                    select p).ToList();

                        }
                    
                    
                }
            }

            catch (Exception ex)
            {
                throw ex;

            }

            throw new SaveEntityException("Proveedores");

        }


        public tbProveedores getProveedorById(string id)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {                   
                        return (from p in context.tbProveedores.Include("tbPersona")
                                where p.id == id
                                select p).SingleOrDefault(); 


                }
            }

            catch (Exception ex)
            {
                throw ex;

            }

            throw new SaveEntityException("Proveedores");

        }

        

    }
}
