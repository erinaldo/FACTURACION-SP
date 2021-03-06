﻿using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BPendientes
    {
        DPendientes pendientesIns = new DPendientes();
        public List<tbDocumentosPendiente> GetListEntities()
        {
            return pendientesIns.GetListEntities();
        }

        public tbDocumentosPendiente Guardar(tbDocumentosPendiente entity)
        {
            return pendientesIns.Guardar(entity);
        }

        public tbDocumentosPendiente GetEntityByAlias(string alias)
        {
            return pendientesIns.GetEntityByAlias(alias);
        }

        public bool existAlias(string alias)
        {

            return pendientesIns.existAlias(alias);
        }

        public bool removeByAlias(string alias)
        {
            return pendientesIns.removeByAlias(alias);
        }

        public bool removeAll()
        {

            return pendientesIns.removeAll();

        }

        public int CantidadPendientes()
        {
            return pendientesIns.CantidadPendientes();
        }

    }
}
