//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class tbClientes
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tbClientes()
    {
        this.tbDocumento = new HashSet<tbDocumento>();
    }

    public string id { get; set; }
    public int tipoId { get; set; }
    public int tipoCliente { get; set; }
    public string descripcion { get; set; }
    public bool estado { get; set; }
    public int precioAplicar { get; set; }
    public int descuentoMax { get; set; }
    public int creditoMax { get; set; }
    public int plazoCreditoMax { get; set; }
    public string nombreTributario { get; set; }
    public string encargadoConta { get; set; }
    public string correoElectConta { get; set; }
    public Nullable<int> idExonercion { get; set; }
    public System.DateTime fecha_crea { get; set; }
    public System.DateTime fecha_ult_mod { get; set; }
    public string usuario_crea { get; set; }
    public string usuario_ult_crea { get; set; }
    public string contacto { get; set; }

    public virtual tbExoneraciones tbExoneraciones { get; set; }
    public virtual tbPersona tbPersona { get; set; }
    public virtual tbTipoClientes tbTipoClientes { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tbDocumento> tbDocumento { get; set; }
}