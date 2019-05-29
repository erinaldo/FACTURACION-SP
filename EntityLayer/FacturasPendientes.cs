using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class FacturasPendientes
    {


       private tbDocumento facturaPendiente;
       private string alias;
       private ICollection<tbDetalleDocumento> listaDetalle;



        public FacturasPendientes()
        {
        }


        public ICollection<tbDetalleDocumento> ListaDetalle
        {

            get
            {
                return listaDetalle;
            }

            set
            {
                listaDetalle = value;
            }
            
        }


        public tbDocumento FacturaPendiente
        {
            get
            {
                return facturaPendiente;
            }

            set
            {
                facturaPendiente = value;
            }
        }

        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }
    }
}
