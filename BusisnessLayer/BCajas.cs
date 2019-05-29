using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer;
using DataLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Interfaces;
namespace BusinessLayer
{
   public class BCajas

    {
        DCajas Inscajas = new DCajas();


        public tbCajas guardar(tbCajas cajas)
        {

            tbCajas cajasL= Inscajas.GetEntity(cajas);
            if (cajasL == null)
            {

                return Inscajas.Guardar(cajas);
            }
            else
            {

                if (cajasL.estado == true)
                {

                    throw new EntityExistException("  cajas ");

                }
                else
                {
                    throw new EntityDisableStateException("  cajas ");
                }

              
            }
        }

        public tbCajas modificar(tbCajas cajas)
        {


            return Inscajas.Actualizar(cajas);

        }
        public tbCajas eliminar(tbCajas cajas)
        {


            return Inscajas.Actualizar(cajas);

        }



        public List<tbCajas> getListTipoing(int estado)
        {


            return Inscajas.GetListEntities(estado);


        }


        public tbCajas getEntity(tbCajas cajas)
        {
            return Inscajas.GetEntity(cajas);
        }


    }
}
