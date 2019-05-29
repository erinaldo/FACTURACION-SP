using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public static class Enums

    {
        public enum ConsultarHacienda
        {
            Clave = 1,
            Consecutivo = 2,
            IDDocumento = 3

        }
        public enum accionGuardar
        {
            Nuevo = 1,
            Modificar = 2,
            Eliminar = 3

        }
        public enum EstadoBusqueda
        {
            Activo=1,
            Inactivos=2,
            Todos=3

        }

        public enum TipoId
        {
            Fisica = 1,
            Juridica = 2,
            Dimex = 3,
            Nite=4

        }

        public enum Sexo
        {
            Femenino = 1,
            Masculino = 2
        }
    public enum TipoCompra
    {
        Contado = 1,
        Credito = 2
       
    }

        public enum tipoVenta
        {
            Contado = 1,
            Credito = 2,
            Consignacion=3,
            Apartado=4

        }


        public enum TipoPago
        {
            NoAplica=0,
            Efectivo = 1,
            Tarjeta = 2, 
            Cheque = 3,
            Transferencia=4,
            RecaudadoTerceros=5,    
            Otros=99
        }

        public enum TipoDocumento
        {
            
            FacturaElectronica=1,
            NotaDebitoElectronica=2,
            NotaCreditoElectronica=3,
            TiqueteElectronico=4, 
            Proforma=5

        }

        public enum TipoMoneda
        {

            CRC = 1,
            USD = 2


        }

        public enum Mensajes
        {

            Aceptado=1,
            AceptadoParcial=2,
            Rechazado=3
        }


        public enum EstadoFactura
        {
            Cancelada = 1,
            Pendiente = 2,
            Eliminada =3
        }

        public enum tipoMovimiento
        {
            InicioCaja = 1,
            CierreCaja= 2,
            EntradaDinero = 3,
            SalidaDinero = 4,
            PagoProveedor = 5,
            PagoEmpleado = 6,
            Credito = 7,
            Abono = 8

        }

        public enum requerimientos
        {
            Transacion = 1,
            Mantenimiento = 2,
            Tipos = 3,
            Buscar_Cliente = 4,
            Cancelar_Factura = 5,
            Cancelar_Detalle = 6
        }

        public enum reportes
        {
            inventarioGeneral = 1,
            inventarioBajo = 2,
            inventarioSobre = 3,
            inventarioCategoria=4
           
        }

        public enum roles
        {
            Administracion = 1,
            Cajero_Adm = 2,
            Cajero = 3
        }
        public enum TipoNegocio        
        {
            Otro = 1,
            Restaurante = 2
        }
        public enum TipoRef
        {
            AnulaDocumentoReferencia = 1,
            CorrigeTextoDocumentoReferencia = 2,
            CorrigeMonto=3,
            ReferenciaOtroDocumento=4,
            SustituyeComprobanteProvisionalContingencia=5,
            Otros=99

        }
        public enum TipoMedida
        {
            Sp = 4,
            m = 5,
            kg = 6,
            m2 = 12,
            m3 = 13,
            L=16,
            Unid=17,
            g=18

        }
        public enum Estado
        {
            Eliminado = 0,
            Activo = 1        

        }

        public enum EstadoRespuestaHacienda
        {
            Aceptado = 1,
            AceptadoParcial = 2,
            Rechazado=3

        }



    }
}
