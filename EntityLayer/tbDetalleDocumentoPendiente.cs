//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDetalleDocumentoPendiente
    {
        public string alias { get; set; }
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
    
        public virtual tbDocumentosPendiente tbDocumentosPendiente { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
