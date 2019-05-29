using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BMovimiento
    {
        DMovimientos MovimientoD = new DMovimientos();
        public tbMovimientos Guardar(tbMovimientos movimiento)//funcion recibe objeto
        {

            tbMovimientos moviTra = MovimientoD.GetEntity(movimiento);//cliente no tiene nombre solo persona lo tiene 

            if (moviTra == null)
            {
               
                return MovimientoD.Guardar(movimiento);
            }
            else
            {
                //Modificar este codigo ya que se consulta es el estado para ejecutar segun cada excepcion
                if (moviTra.estado)
                {
                    throw new EntityExistException("Credito");
                }
                else
                {
                    throw new EntityDisableStateException("Credito");
                }
            }

        }
        public tbMovimientos Modificar(tbMovimientos modificarMov)//tabla de creditos no de clientes
        {
            try
            {

                return MovimientoD.Modificar(modificarMov);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
      //Obtener la lista de movimientos guardados PAGO PROVEEDORES

        public List<tbMovimientos> getListMovimiento(int listaMovimiento)
        {
            return MovimientoD.GetListEntities(listaMovimiento);
        }


        public tbMovimientos ModificarLista(List<tbMovimientos> modificarMov)//tabla de creditos no de clientes
        {
            try
            {

                return MovimientoD.ModificarLista(modificarMov);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
