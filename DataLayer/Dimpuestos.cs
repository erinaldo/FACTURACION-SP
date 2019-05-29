using CommonLayer;
using CommonLayer.Interfaces;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Dimpuestos : IDataGeneric<tbImpuestos>
    {
        public tbImpuestos Actualizar(tbImpuestos entity)
        {
            throw new NotImplementedException();
        }

        public tbImpuestos GetEntity(tbImpuestos entity)
        {
            throw new NotImplementedException();
        }

        public List<tbImpuestos> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        //Recuperamos los datos de la tabla con el estado en activo.
                        return (from p in context.tbImpuestos
                                where p.estado == true
                                select p).ToList();
                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        //Recuperamos los valores con el estado en inactivo
                        return (from p in context.tbImpuestos
                                where p.estado == false
                                select p).ToList();

                    }
                    else
                    {
                        //Recuperamos todos los valores de la tabla.
                        return (from p in context.tbImpuestos
                                select p).ToList();

                    }

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido el siguiente error: " + ex.ToString());
            }

        }

        public tbImpuestos Guardar(tbImpuestos entity)
        {
            throw new NotImplementedException();
        }
    }
}
