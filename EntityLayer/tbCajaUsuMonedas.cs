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
    
    public partial class tbCajaUsuMonedas
    {
        public string idMoneda { get; set; }
        public int idCajaUsuario { get; set; }
        public int cantidad { get; set; }
        public int subtotal { get; set; }
    
        public virtual tbCajaUsuario tbCajaUsuario { get; set; }
        public virtual tbMonedas tbMonedas { get; set; }
    }
}
