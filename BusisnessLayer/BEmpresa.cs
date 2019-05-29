using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BEmpresa
    {
        DEmpresa empresaIns = new DEmpresa();
        public tbEmpresa getEntity(tbEmpresa entity)
        {
            return empresaIns.GetEntity(entity);
        }
        public tbParametrosEmpresa getEntityParametros(tbParametrosEmpresa entity)
        {
            return empresaIns.GetEntityParametros(entity);
        }
        public tbEmpresa guardar(tbEmpresa entity)
        {
            return empresaIns.Guardar(entity);
        }
        public tbEmpresa modificar(tbEmpresa entity)
        {
            return empresaIns.Actualizar(entity);
        }

        public tbParametrosEmpresa GuardarParametros(tbParametrosEmpresa entity)
        {
            return empresaIns.GuardarParametros(entity);
        }
        public tbParametrosEmpresa modificarParamtros(tbParametrosEmpresa entity)
        {
            return empresaIns.ActualizarParametros(entity);
        }
    }
}
