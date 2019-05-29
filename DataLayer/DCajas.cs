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
   public class DCajas: IDataGeneric<tbCajas>
    {
        public tbCajas  GetEntity(tbCajas caja)
        {
            tbCajas  cajas;

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    //desde      CONSULTA:
                    cajas = (from u in context.tbCajas
                                       where u.nombre == caja.nombre
                                       select u).SingleOrDefault();//me devuelve una sola entidad

                    return cajas;
                }

            }
            catch (Exception )
            {
                throw new EntityException("caja");
            }


        }


        public tbCajas Guardar(tbCajas caja)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbCajas.Add(caja);
                    context.SaveChanges();
                }
            }

            catch (Exception ex)
            {
                throw new SaveEntityException("caja");
            }



            return caja;
        }



        public tbCajas Actualizar(tbCajas caja)
        {
            try
            {


                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {


                    context.Entry(caja).State = System.Data.Entity.EntityState.Modified;
                    //para la herencia se utiliza el mismo codigo ej: context.entry(cliente.tbpersona).state = 

                    context.SaveChanges();
                    return caja;





                }


            }
            catch (Exception ex)
            {

                throw new UpdateEntityException("caja");
            }


        }



        public List<tbCajas> GetListEntities(int estado)//aqui accedo a la lista
        {

            try
            {

                List<tbCajas> cajas = new List<tbCajas>();

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())//utilizamos el using para todas las consultas
                {


                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        cajas = (from tipIn in context.tbCajas//.include(tbpersona)
                                           where tipIn.estado == true
                                           select tipIn).ToList();


                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {

                        cajas = (from tipIn in context.tbCajas
                                           where tipIn.estado == false
                                           select tipIn).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    {

                        cajas = (from tipIn in context.tbCajas
                                           select tipIn).ToList();
                    }

                }
                return cajas;




            }

            catch (Exception ex)
            {

                throw new ListEntityException("cajas");
            }




        }

    }
}
