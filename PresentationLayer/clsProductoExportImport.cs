using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class clsProductoExportImport
    {
        public string idProducto { get; set; }
        public string nombre { get; set; }
        public int id_categoria { get; set; }
        public string idProveedor { get; set; }
        public int idMedida { get; set; }
        public Nullable<int> idTipoIdProveedor { get; set; }
        public Nullable<bool> precioVariable { get; set; }
        public Nullable<decimal> precioUtilidad1 { get; set; }
        public Nullable<decimal> precioUtilidad2 { get; set; }
        public Nullable<decimal> precioUtilidad3 { get; set; }
        public decimal precioVenta1 { get; set; }
        public decimal precioVenta2 { get; set; }
        public decimal precioVenta3 { get; set; }
        public decimal utilidad1Porc { get; set; }
        public decimal utilidad3Porc { get; set; }
        public decimal utilidad2Porc { get; set; }
        public decimal precio_real { get; set; }
        public bool esExento { get; set; }
        public int idTipoImpuesto { get; set; }
        public Nullable<bool> aplicaDescuento { get; set; }
        public string foto { get; set; }
        public Nullable<decimal> descuento_max { get; set; }
        public bool estado { get; set; }
    }
}
