using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace BusinessLayer
{
   public  class BCredito
    {
        public DCredito creditoD = new DCredito();
        public  tbCreditos Guardar(tbCreditos credito)//funcion recibe objeto
        {
           
                
                return creditoD.Guardar(credito);
           
        }

        public  List<tbCreditos> GetListEntities(int estado)
        {
            return creditoD.GetListEntities(estado);
        }

        public  tbCreditos GetEntity(tbCreditos elCredito)
        {
            return creditoD.GetEntity(elCredito);
        }

      
        /// <summary>
        /// metodo que llama a data layer para obtener creditos de una persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public  List<tbCreditos> obtenerListaCreditos(string id)
        {
            
            return creditoD.obtenerListaCreditos(id); 
        }

        public List<tbCreditos> Modificar(List<tbCreditos> credito)//tabla de creditos no de clientes
        {
            try
            {
                foreach ( tbCreditos u in credito)
                {
                    creditoD.Modificar(u);
                }
                return credito;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
