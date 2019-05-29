using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace BusinessLayer
{
  public  class BCajaUsuarioMonedas
    {
        DCajaUsuarioMonedas DCajaUsuMoneIns = new DCajaUsuarioMonedas();

        public List<tbMonedas> getListMonedas()
        {

            return DCajaUsuMoneIns.CargarListaMonedas();
        }

        //public tbCajaUsuMonedas Guardar(tbCajaUsuMonedas cajaUsuMoneda)
        //{
        //    return DCajaUsuMoneIns.Guardar(cajaUsuMoneda);
        //}

        //public List<tbCajaUsuMonedas> guardarListaCajaUsuarioMoneda(List<tbCajaUsuMonedas> cajaUsuMonedaList)
        //{
        //    List<tbCajaUsuMonedas> monedasList = new List<tbCajaUsuMonedas>();
        //    tbCajaUsuMonedas buscarCajaUsuMoneda;
        //    foreach (tbCajaUsuMonedas cajaUsuMonedas in cajaUsuMonedaList)
        //    {
        //        if (cajaUsuMonedaList != null)
        //        {

        //            buscarCajaUsuMoneda = DCajaUsuMoneIns.Guardar(cajaUsuMonedas);



        //            monedasList.Add(buscarCajaUsuMoneda);

        //        }
        //    }

        //    return monedasList;

        //}
    }

}
