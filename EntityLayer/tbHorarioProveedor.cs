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

public partial class tbHorarioProveedor
{
    public int idTipo { get; set; }
    public string idProveedor { get; set; }
    public int idTipoHorario { get; set; }
    public Nullable<bool> lunes { get; set; }
    public Nullable<bool> martes { get; set; }
    public Nullable<bool> miercoles { get; set; }
    public Nullable<bool> jueves { get; set; }
    public Nullable<bool> viernes { get; set; }
    public Nullable<bool> sabado { get; set; }
    public Nullable<bool> domingo { get; set; }

    public virtual tbProveedores tbProveedores { get; set; }
}
