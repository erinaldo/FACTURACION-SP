using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace BusinessLayer
{
    public class BTipoMovimiento
    {
        public static tbTipoMovimiento tipoMovGlobal = new tbTipoMovimiento();
        DTipoMovimiento tipoMovimientoD = new DTipoMovimiento();
        public tbTipoMovimiento guardar(tbTipoMovimiento movimiento)
        {
            tbTipoMovimiento tiposMov = tipoMovimientoD.GetEntity(movimiento);
            if (tiposMov == null)
            {

                return tipoMovimientoD.Guardar(movimiento);
            }
            else
            {
                if (tiposMov.estado == true)
                {   

                    throw new EntityExistException("Tipo Movimiento");
                }
                else
                {
                    throw new EntityDisableStateException("Tipo de Movimiento");
                }


            }

        }
        public tbTipoMovimiento modificar(tbTipoMovimiento movimiento)
        {

            return tipoMovimientoD.Actualizar(movimiento);
        }
        public tbTipoMovimiento eliminar(tbTipoMovimiento movimiento)
        {

            return tipoMovimientoD.Actualizar(movimiento);
        }
        public List<tbTipoMovimiento> getListTipoMovimiento(int listaMovimiento)
        {


            return tipoMovimientoD.GetListEntities();


        }
        public tbTipoMovimiento GetEntity(tbTipoMovimiento tmovimiento)
        {
            return tipoMovimientoD.GetEntity(tmovimiento);

        }



    }
}

