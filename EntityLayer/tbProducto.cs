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
    
    public partial class tbProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProducto()
        {
            this.tbDetalleDocumento = new HashSet<tbDetalleDocumento>();
            this.tbDetalleDocumentoPendiente = new HashSet<tbDetalleDocumentoPendiente>();
        }
    
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
        public System.DateTime fecha_crea { get; set; }
        public System.DateTime fecha_ult_mod { get; set; }
        public string usuario_crea { get; set; }
        public string usuario_ult_mod { get; set; }
    
        public virtual tbCategoriaProducto tbCategoriaProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDetalleDocumento> tbDetalleDocumento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDetalleDocumentoPendiente> tbDetalleDocumentoPendiente { get; set; }
        public virtual tbImpuestos tbImpuestos { get; set; }
        public virtual tbInventario tbInventario { get; set; }
        public virtual tbProveedores tbProveedores { get; set; }
        public virtual tbTipoMedidas tbTipoMedidas { get; set; }
    }
}
