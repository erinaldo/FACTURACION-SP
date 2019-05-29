using EntityLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BAbonos
    {

        public DAbonos abonosD = new DAbonos();
        public List<tbAbonos> GetListEntities()
        {
            return abonosD.GetListEntities();
        }

        public tbAbonos Guardar(tbAbonos abono)//funcion recibe objeto
        {


            return abonosD.Guardar(abono);



        }

        public List<tbAbonos> Modificar(List<tbAbonos> entity)//tabla de creditos no de clientes
        {
            try
            {
                foreach (tbAbonos u in entity)
                {
                    abonosD.Modificar(u);

                }

                return entity;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
