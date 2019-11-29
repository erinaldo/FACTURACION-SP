using CommonLayer;
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BActividadesEconomicas
    {
        DActividadesEconomicas DActIns = new DActividadesEconomicas();
        public List<tbActividades> GetListEntities(int estado)
        {
            return DActIns.GetListEntities(estado);
        }
        public tbActividades getById(tbActividades act)
        {
            return DActIns.GetEntity(act);
        }

        public List<tbEmpresaActividades> getListaEmpresaActividad(string id, int tipo)
        {
            return DActIns.getListaEmpresaActividad(id, tipo);
        }

    }
}
