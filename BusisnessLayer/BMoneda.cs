using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using DataLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;

namespace BusinessLayer
{
   public class BMoneda
    {
        DMoneda monedaIns = new DMoneda();//creo un nuevo objeto para eviar a datos

        public tbMonedas guardar(tbMonedas moneda)
        {

            try
            {
                tbMonedas buscarMoneda = monedaIns.GetEntity(moneda);
                if (buscarMoneda == null)
                {
                    return monedaIns.Guardar(moneda);
                }
                else
                {

                    if (buscarMoneda.estado == true)
                    {
                        throw new EntityExistException("moneda");
                    }
                    else
                    {
                        throw new EntityDisableStateException("moneda");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Recuperamos los datos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<tbMonedas> GetListEntities(int estado)
        {
            return monedaIns.GetListEntities(estado);

        }

        public List<tbMonedas> GetListEntities(int estado, int tipoMoneda)
        {
            return monedaIns.GetListEntitiesByTipo(estado, tipoMoneda);

        }

        public tbMonedas GetEntities(tbMonedas moneda)
        {
            return monedaIns.GetEntity(moneda);
        }



        public List<tbMonedas> guardarLista(List<tbMonedas> monedaList)
        {
            List<tbMonedas> modedasList = new List<tbMonedas>();

            try
            {
                tbMonedas buscarMoneda;
                foreach (tbMonedas moneda in monedaList)
                {
                    buscarMoneda = monedaIns.GetEntity(moneda);
                    if (buscarMoneda == null)
                    {

                        buscarMoneda = monedaIns.Guardar(moneda);

                    }else  if (buscarMoneda.estado != moneda.estado) {
                        buscarMoneda=monedaIns.Actualizar(moneda);

                    }
                    modedasList.Add(buscarMoneda);

                }

            }
            catch (EntityExistException ex)
            {
            
                throw ex;
            }
            return modedasList;

        }
    }
}
