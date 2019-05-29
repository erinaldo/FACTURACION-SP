using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace BusinessLayer
{
   public class BCajaUsuario
    {
        DCajaUsuario DCajaUsuarioIns = new DCajaUsuario();
  
        public tbCajaUsuario GetFechaCajaUsuario(tbCajaUsuario cajaUsuario, tbCajaUsuario NumCaja)
        {
            return DCajaUsuarioIns.GetEntityCajausuarioByFecha(cajaUsuario, NumCaja);
        }

        public tbCajaUsuario GetUsuario(tbCajaUsuario usuario, tbCajaUsuario caja)
        {
            return DCajaUsuarioIns.GetNombreUsuario(usuario, caja);
        }
        //Busca el número de caja
        public tbCajaUsuario GetNumeroCaja(tbCajaUsuario caja)
        {
            return DCajaUsuarioIns.GetNumeroCaja(caja);
        }

      


        public tbCajaUsuario Guardar(tbCajaUsuario cajaUsuario)
        {
           
              return DCajaUsuarioIns.Guardar(cajaUsuario);
           
        }
    }
}
