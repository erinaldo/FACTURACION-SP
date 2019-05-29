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

public partial class tbDocumento
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tbDocumento()
    {
        this.tbDetalleDocumento = new HashSet<tbDetalleDocumento>();
    }

    public int id { get; set; }
    public int tipoDocumento { get; set; }
    public string consecutivo { get; set; }
    public string clave { get; set; }
    public bool reporteElectronic { get; set; }
    public System.DateTime fecha { get; set; }
    public string idCliente { get; set; }
    public Nullable<int> tipoIdCliente { get; set; }
    public Nullable<int> tipoVenta { get; set; }
    public Nullable<int> plazo { get; set; }
    public Nullable<int> tipoPago { get; set; }
    public string refPago { get; set; }
    public Nullable<int> tipoMoneda { get; set; }
    public Nullable<decimal> tipoCambio { get; set; }
    public int estadoFactura { get; set; }
    public string EstadoFacturaHacienda { get; set; }
    public bool reporteAceptaHacienda { get; set; }
    public string mensajeReporteHacienda { get; set; }
    public Nullable<bool> mensajeRespHacienda { get; set; }
    public System.DateTime fecha_crea { get; set; }
    public System.DateTime fecha_ult_mod { get; set; }
    public string usuario_crea { get; set; }
    public string usuario_ult_mod { get; set; }
    public bool estado { get; set; }
    public bool notificarCorreo { get; set; }
    public string correo1 { get; set; }
    public string correo2 { get; set; }
    public string observaciones { get; set; }
    public string idEmpresa { get; set; }
    public int tipoIdEmpresa { get; set; }
    public Nullable<int> tipoDocRef { get; set; }
    public string claveRef { get; set; }
    public Nullable<System.DateTime> fechaRef { get; set; }
    public Nullable<int> codigoRef { get; set; }
    public string razon { get; set; }
    public string xmlSinFirma { get; set; }
    public string xmlFirmado { get; set; }
    public string xmlRespuesta { get; set; }

    public virtual tbClientes tbClientes { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<tbDetalleDocumento> tbDetalleDocumento { get; set; }
    public virtual tbEmpresa tbEmpresa { get; set; }
    public virtual tbTipoDocumento tbTipoDocumento { get; set; }
    public virtual tbTipoMoneda tbTipoMoneda { get; set; }
    public virtual tbTipoPago tbTipoPago { get; set; }
    public virtual tbTipoVenta tbTipoVenta { get; set; }
}
