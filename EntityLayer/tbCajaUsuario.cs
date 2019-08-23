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
    
    public partial class tbCajaUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCajaUsuario()
        {
            this.tbCajaUsuMonedas = new HashSet<tbCajaUsuMonedas>();
            this.tbMovimientos = new HashSet<tbMovimientos>();
        }
    
        public int id { get; set; }
        public int idCaja { get; set; }
        public string idUser { get; set; }
        public int tipoId { get; set; }
        public int tipoMovCaja { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> total { get; set; }
        public System.DateTime fecha_crea { get; set; }
        public System.DateTime fecha_ult_mod { get; set; }
        public string usuario_crea { get; set; }
        public string usuario_ult_mod { get; set; }
        public bool estado { get; set; }
    
        public virtual tbCajas tbCajas { get; set; }
        public virtual tbUsuarios tbUsuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCajaUsuMonedas> tbCajaUsuMonedas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMovimientos> tbMovimientos { get; set; }
    }
}
