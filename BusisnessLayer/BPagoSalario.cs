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
   public class BPagoSalario
    {
        tbPagos pagosGlo = new tbPagos();
        List<tbPagos> ListaPago = new List<tbPagos>();
        DPagoSalario pagosIns = new DPagoSalario();
        tbEmpleado EmpleadoActivo = new tbEmpleado();





        public tbPagos guardar(tbPagos pagos)
        {
            tbPagos pagoSalario = pagosIns.GetEntity(pagos);
            if (pagoSalario==null)
            {
                return pagosIns.Guardar(pagos);
            }
            else {
                if(EmpleadoActivo.estado)
                {
                    throw new EntityExistException();
                }
                else
                {
                    throw new EntityDisableStateException();
                }
            }
        }
        public tbPagos Modificar(tbPagos PSalario)
        {
            return pagosIns.Actualizar(PSalario);
        }
        public tbPagos eliminar(tbPagos Pago)
        {
            return pagosIns.Actualizar(Pago);
        }
        public List<tbPagos> getListEntity(int TipoPago )
        {
            return pagosIns.GetListEntities(TipoPago);
        }

        public static List<tbTipoPuesto> getTipoPuesto_PagoS()
        {
            return DPagoSalario.getTipoPuesto_PagoS();
        }

    }
}
