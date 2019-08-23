using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class DetalleFacturaPendiente
    {

        public DetalleFacturaPendiente()
        {
        }

        public int idTipoDoc { get; set; }
        public int idDoc { get; set; }
        public string idProducto { get; set; }
        public int numLinea { get; set; }
        public decimal cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal montoTotal { get; set; }
        public decimal descuento { get; set; }
        public decimal montoTotalDesc { get; set; }
        public decimal montoTotalImp { get; set; }
        public decimal montoTotalExo { get; set; }
        public decimal totalLinea { get; set; }

        public tbProducto tbProducto { get; set; }


    }


    public class FacturasPendientes
    {


      
     


        public FacturasPendientes()
        {
            this.detalleFacturaPendiente  = new List<DetalleFacturaPendiente>();
        }

        public string alias { get; set; }
        public bool servicioMesa { get; set; }
        public List<DetalleFacturaPendiente> detalleFacturaPendiente { get; set; }
    }
}
