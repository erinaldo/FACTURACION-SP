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
   public class BTipoIngrediente
    {

        DTipoIngrediente TipoIngIns = new DTipoIngrediente();//debo cear instancia para llamar a DL

        public  tbTipoIngrediente guardar(tbTipoIngrediente tipoIngre)
        {

            tbTipoIngrediente tipoIngLocal = TipoIngIns.GetEntity(tipoIngre);
            if (tipoIngLocal == null)
            {
                
                return TipoIngIns.Guardar(tipoIngre);
            }
            else
            {

                if (tipoIngLocal.estado == true)
                {

                    throw new EntityExistException("  tipo ingrediente  " );

                }
                else
                {
                    throw new EntityDisableStateException("  tipo Ingrediente  ");
                }

              /*  exist = true;
                return tipoIngLocal;*/
            }
        }

        public tbTipoIngrediente  modificar(tbTipoIngrediente tipoIngre)
        {


            return TipoIngIns.Actualizar(tipoIngre);

        }
        public tbTipoIngrediente eliminar(tbTipoIngrediente tipoIngre)
        {


            return TipoIngIns.Actualizar(tipoIngre);

        }



        public  List<tbTipoIngrediente> getListTipoing(int estado)
        {


            return TipoIngIns.GetListEntities(estado);


        }


        public tbTipoIngrediente getEntity(tbTipoIngrediente eltipoIngrediente)
        {
            return TipoIngIns.GetEntity(eltipoIngrediente);
        }








    }
}
