﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
        using System;
        using System.Data.Entity;
        using System.Data.Entity.Infrastructure;
    
        using EntityLayer;
    
    public partial class dbSisSodInaEntities : DbContext
    {
        public dbSisSodInaEntities()
            : base("name=dbSisSodInaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<publishers> publishers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbAbonos> tbAbonos { get; set; }
        public virtual DbSet<tbActividades> tbActividades { get; set; }
        public virtual DbSet<tbBarrios> tbBarrios { get; set; }
        public virtual DbSet<tbCajas> tbCajas { get; set; }
        public virtual DbSet<tbCajaUsuario> tbCajaUsuario { get; set; }
        public virtual DbSet<tbCajaUsuMonedas> tbCajaUsuMonedas { get; set; }
        public virtual DbSet<tbCanton> tbCanton { get; set; }
        public virtual DbSet<tbCategoriaProducto> tbCategoriaProducto { get; set; }
        public virtual DbSet<tbCategoriaRequerimiento> tbCategoriaRequerimiento { get; set; }
        public virtual DbSet<tbClientes> tbClientes { get; set; }
        public virtual DbSet<tbCompras> tbCompras { get; set; }
        public virtual DbSet<tbCreditos> tbCreditos { get; set; }
        public virtual DbSet<tbDetalleCompras> tbDetalleCompras { get; set; }
        public virtual DbSet<tbDetalleDocumento> tbDetalleDocumento { get; set; }
        public virtual DbSet<tbDetalleDocumentoPendiente> tbDetalleDocumentoPendiente { get; set; }
        public virtual DbSet<tbDetalleImpresion> tbDetalleImpresion { get; set; }
        public virtual DbSet<tbDetalleMovimiento> tbDetalleMovimiento { get; set; }
        public virtual DbSet<tbDetalleProducto> tbDetalleProducto { get; set; }
        public virtual DbSet<tbDistrito> tbDistrito { get; set; }
        public virtual DbSet<tbDocumento> tbDocumento { get; set; }
        public virtual DbSet<tbDocumentosPendiente> tbDocumentosPendiente { get; set; }
        public virtual DbSet<tbEmpleado> tbEmpleado { get; set; }
        public virtual DbSet<tbEmpresa> tbEmpresa { get; set; }
        public virtual DbSet<tbEmpresaActividades> tbEmpresaActividades { get; set; }
        public virtual DbSet<tbExoneraciones> tbExoneraciones { get; set; }
        public virtual DbSet<tbHorarioProveedor> tbHorarioProveedor { get; set; }
        public virtual DbSet<tbImpuestos> tbImpuestos { get; set; }
        public virtual DbSet<tbIngredienteProveedor> tbIngredienteProveedor { get; set; }
        public virtual DbSet<tbIngredientes> tbIngredientes { get; set; }
        public virtual DbSet<tbInventario> tbInventario { get; set; }
        public virtual DbSet<tbMonedas> tbMonedas { get; set; }
        public virtual DbSet<tbMovimientos> tbMovimientos { get; set; }
        public virtual DbSet<tbPagos> tbPagos { get; set; }
        public virtual DbSet<tbParametrosEmpresa> tbParametrosEmpresa { get; set; }
        public virtual DbSet<tbPersona> tbPersona { get; set; }
        public virtual DbSet<tbPersonasTribunalS> tbPersonasTribunalS { get; set; }
        public virtual DbSet<tbProducto> tbProducto { get; set; }
        public virtual DbSet<tbProveedores> tbProveedores { get; set; }
        public virtual DbSet<tbProvincia> tbProvincia { get; set; }
        public virtual DbSet<tbPRUEBA2> tbPRUEBA2 { get; set; }
        public virtual DbSet<tbReporteHacienda> tbReporteHacienda { get; set; }
        public virtual DbSet<tbRequerimientos> tbRequerimientos { get; set; }
        public virtual DbSet<tbRoles> tbRoles { get; set; }
        public virtual DbSet<tbTipoClientes> tbTipoClientes { get; set; }
        public virtual DbSet<tbTipoDocumento> tbTipoDocumento { get; set; }
        public virtual DbSet<tbTipoId> tbTipoId { get; set; }
        public virtual DbSet<tbTipoIngrediente> tbTipoIngrediente { get; set; }
        public virtual DbSet<tbTipoMedidas> tbTipoMedidas { get; set; }
        public virtual DbSet<tbTipoMoneda> tbTipoMoneda { get; set; }
        public virtual DbSet<tbTipoMovimiento> tbTipoMovimiento { get; set; }
        public virtual DbSet<tbTipoPago> tbTipoPago { get; set; }
        public virtual DbSet<tbTipoPuesto> tbTipoPuesto { get; set; }
        public virtual DbSet<tbTipoVenta> tbTipoVenta { get; set; }
        public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }
    }
}
