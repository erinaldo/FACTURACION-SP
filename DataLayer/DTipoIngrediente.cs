using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Interfaces;

namespace DataLayer
{
   public class DTipoIngrediente: IDataGeneric<tbTipoIngrediente>
    {

        public  tbTipoIngrediente GetEntity(tbTipoIngrediente eltipoIngrediente)
        {
            tbTipoIngrediente tipoIngrediente;

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

               
                //desde      CONSULTA:
                tipoIngrediente = (from tipIn in context.tbTipoIngrediente
                                   where tipIn.nombre == eltipoIngrediente.nombre
                                   select tipIn).SingleOrDefault();//me devuelve una sola entidad

                return tipoIngrediente;
                }

            }
            catch (Exception ex)
            {
                throw new EntityException("tipo ingrediente");
            }


        }


        public  tbTipoIngrediente Guardar(tbTipoIngrediente tipoIngrediente)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbTipoIngrediente.Add(tipoIngrediente);
                    context.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                throw new SaveEntityException("Tipo ingrediente");
            }



            return tipoIngrediente;
        }



        public tbTipoIngrediente Actualizar(tbTipoIngrediente tipoIngrediente)
        {
            try
            {


                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    context.Entry(tipoIngrediente).State = System.Data.Entity.EntityState.Modified;
                    //para la herencia se utiliza el mismo codigo ej: context.entry(cliente.tbpersona).state = 

                    context.SaveChanges();
                    return tipoIngrediente;
                




                }

                    
            }
            catch(Exception ex)
            {

                throw new UpdateEntityException ("tipo ingrediente");
            }


        }



        public  List<tbTipoIngrediente> GetListEntities(int estado)//aqui accedo a la lista
        {

            try
            {

                 List<tbTipoIngrediente> tipoIngrediente = new List<tbTipoIngrediente>();

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())//utilizamos el using para todas las consultas
                {


                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        tipoIngrediente = (from tipIn in context.tbTipoIngrediente//.include(tbpersona)
                                           where tipIn.estado == true
                                           select tipIn).ToList();


                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        tipoIngrediente = (from tipIn in context.tbTipoIngrediente
                                           where tipIn.estado == false
                                           select tipIn).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {

                        tipoIngrediente = (from tipIn in context.tbTipoIngrediente
                                           select tipIn).ToList();
                    }

                }
                    return tipoIngrediente;

                
                

            }
            
            catch (Exception)
            {

                throw new ListEntityException("tipo ingrediente");
            }




        }


       

       
    }
}
