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
    
    public partial class tbParametrosEmpresa
    {
        public int id { get; set; }
        public string idEmpresa { get; set; }
        public int idTipoEmpresa { get; set; }
        public float utilidadBase { get; set; }
        public bool manejaInventario { get; set; }
        public Nullable<decimal> cambioDolar { get; set; }
        public Nullable<decimal> descuentoBase { get; set; }
        public Nullable<bool> aprobacionDescuento { get; set; }
        public Nullable<int> precioBase { get; set; }
        public Nullable<bool> facturacionElectronica { get; set; }
        public Nullable<bool> clienteObligatorioFact { get; set; }
        public Nullable<int> plazoMaximoCredito { get; set; }
        public Nullable<int> plazoMaximoProforma { get; set; }
        public bool servicioMesa { get; set; }
        public Nullable<decimal> porcServicioMesa { get; set; }
    
        public virtual tbEmpresa tbEmpresa { get; set; }
    }
}
