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
    
    public partial class tbRequerimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRequerimientos()
        {
            this.tbRoles = new HashSet<tbRoles>();
        }
    
        public int idReq { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        public System.DateTime fecha_crea { get; set; }
        public System.DateTime fecha_ult_mod { get; set; }
        public string usuario_crea { get; set; }
        public string usuario_ult_mod { get; set; }
        public int idCategoriaReq { get; set; }
    
        public virtual tbCategoriaRequerimiento tbCategoriaRequerimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRoles> tbRoles { get; set; }
    }
}
