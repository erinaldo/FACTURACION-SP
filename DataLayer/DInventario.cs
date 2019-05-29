using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using CommonLayer.Interfaces;
using CommonLayer.Exceptions.DataExceptions;

namespace DataLayer
{
    public class DInventario:IDataGeneric<tbInventario>
    {



        public  List<tbInventario> GetListEntities(int estado)
        {
            List<tbInventario> inventario;
            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        inventario=(from u in context.tbInventario.Include("tbProducto.tbTipoMedidas").Include("tbProducto.tbCategoriaProducto")
                                where u.estado == true
                                select u).ToList();
                        

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        inventario = (from u in context.tbInventario.Include("tbProducto.tbTipoMedidas").Include("tbProducto.tbCategoriaProducto")
                                      where u.estado == false
                                select u).ToList();

                    }
                    else
                    {
                        inventario = (from u in context.tbInventario.Include("tbProducto.tbTipoMedidas").Include("tbProducto.tbCategoriaProducto")
                                      select u).ToList();
                    }
                    return inventario;

                }
            }
            catch (Exception ex)
            {
                throw new ListEntityException ("Inventario"); 

            }
        }








        public tbInventario Actualizar(tbInventario inve)
        {
            try
            { 
                using (dbSisSodInaEntities update = new dbSisSodInaEntities())
                {

                    update.Entry(inve).State = System.Data.Entity.EntityState.Modified;
                    //si se quiere modicar mas entidas se pone . despues del envi y se le da la tabla
                    update.SaveChanges();

                    return inve;
                }
            }
            catch(Exception ex)
            {

                 throw new UpdateEntityException("Inventario");
            }


        }

        public tbInventario Guardar(tbInventario entity)
        {
            throw new NotImplementedException();
        }

        public tbInventario GetEntity(tbInventario entity)
        {
            

            tbInventario inv;
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    inv = (from p in context.tbInventario
                                  where p.idProducto == entity.idProducto
                           select p).SingleOrDefault();//singleordefault me conviete en un solo registro
                }
                return inv;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public tbInventario GetEntityByIngrediente(int idIngrediente)
        {


            tbInventario inv;
            try
            {
                //using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                //{
                //    inv = (from p in context.tbInventario
                //           where p.idIngrediente ==idIngrediente
                //           select p).SingleOrDefault();//singleordefault me conviete en un solo registro
                //}
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
