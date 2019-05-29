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
  public  class BIngredientes
    {
        DIngredientes IngredienteDIns = new DIngredientes();//hago el nuevo objeto para mandarlo a Data
        DTipoMedida medidasIns = new DTipoMedida();
        public tbIngredientes guardar(tbIngredientes ingrediente)
        {
            tbIngredientes ingred = IngredienteDIns.GetEntity(ingrediente);
            if (ingred == null)
            {
                return IngredienteDIns.Guardar(ingrediente);
            }
            else
            {
                if (ingred.estado == true)
                {
                    throw new EntityExistException("Ingrediente");
                }
                else
                {
                    throw new EntityDisableStateException("Ingrediente");
                }
            }

        }
        public tbIngredientes GetEntity(tbIngredientes tIngrediente)
        {
            return IngredienteDIns.GetEntity(tIngrediente);
        }

        public tbIngredientes eliminar(tbIngredientes ingrediente)
        {
            return IngredienteDIns.Actualizar(ingrediente);
        }

        public tbIngredientes modificar(tbIngredientes ingrediente)
        {
            return IngredienteDIns.Actualizar(ingrediente);
        }

        //Sirve para lista ingredientes Alban
        public List<tbIngredientes> GetListaIngrediente(int ListaIngrediente)
        {
            return IngredienteDIns.GetListEntities();
        }

        //Recuperar valores mediante el uso de la clase correspondiente: Tipo de Ingredientes.
        public List<tbTipoIngrediente> getTipoIngrediente(int tipoIngrediente)
        {
            return IngredienteDIns.GetListEntitiesDetalle(tipoIngrediente);
        }


        //Recuperar valores mediante el uso de la clase correspondiente: Tipo de Medida.
        public List<tbTipoMedidas> getTipoMedida(int tipoMedida)
        {
            return medidasIns.GetListEntities(tipoMedida);
        }


        //METODOS DE MOVIMIENTO ( PAGO DE PROVEEDORES)

         
        //cargar lista de ingredientes al form hijo para cuando sea necesarios
        //pasar a la clase ingredientes tanto bussinnes como datalayer
        public List<tbIngredientes> GetListIngredientes(int estado)//nombre del metodo que me extrae la lista de ingredientes
        {

            return IngredienteDIns.GetListEntitiesIngredientes(estado);
        }



        public tbIngredientes GetEntityById(tbIngredientes entity)
        {
            return IngredienteDIns.GetEntityByID(entity);
        }

        public List<tbIngredientes> GetListIngredientesPorID(int p)
        {
            return IngredienteDIns.GetEntityPorID(p);
        }
    }
}
