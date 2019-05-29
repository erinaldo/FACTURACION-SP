using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Interfaces;

namespace BusinessLayer
{
    public class BEmpleado
    {
        DEmpleado empleadIns = new DEmpleado();//creo un nuevo objeto para eviar a datos
      
        public  tbEmpleado guardar(tbEmpleado empleado)
        {// verifica si existe
           
            tbEmpleado buscarEmpleado = empleadIns.GetEntity(empleado);
           
            if (buscarEmpleado == null)
            {
                return empleadIns.Guardar(empleado);
            }
            else
            {
                // si el estado es verdadero
                if (buscarEmpleado.estado== true)
                {
                    throw new EntityExistException("empleado");
                }
                else
                {
                    throw new EntityDisableStateException("empleado");
                }
            }
        }
            public  List<tbEmpleado> GetListEntities(int estado)
            {
            return empleadIns.GetListEntities(estado);
            }

        /// <summary>
        /// pasamos los datos a modificar en la base de datos.
        /// </summary>
        /// <returns></returns>
            public tbEmpleado modificar(tbEmpleado emp)
            {

             return empleadIns.Actualizar(emp);
            }
        /// <summary>
        /// pasamos los datos a modificar en la base de datos.
        /// </summary>
        /// <returns></returns>
           public tbEmpleado eliminar(tbEmpleado empleado)
          {
            return empleadIns.Actualizar(empleado);
          }

    }
}

