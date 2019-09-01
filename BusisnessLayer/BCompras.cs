using CommonLayer;
using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BCompras
    {

        string codigoPais = "506";
        string sucursal = "1";
        string caja = "1";
        BFacturacion facturacionIns = new BFacturacion();
        DCompras comprasIns = new DCompras();
        public tbCompras Actualizar(tbCompras entity)
        {
            return comprasIns.Actualizar(entity);
        }

        public tbCompras GetEntity(tbCompras entity)
        {
            return comprasIns.GetEntity(entity);
        }

        public List<tbCompras> GetListEntities(int estado)
        {
            return comprasIns.GetListEntities(estado);
        }

        public tbCompras Guardar(tbCompras entity)
        {

            int id = comprasIns.getNewID(entity.tipoDoc) + 1;

            entity.id = id;
            foreach (var item in entity.tbDetalleCompras)
            {
                item.idCompra = id;
                item.TipoCompra = entity.tipoDoc;
            }
            if (entity.clave == null && entity.tipoDoc==(int)Enums.TipoDocumento.ComprasSimplificada)
            {


                entity.consecutivo = BFacturacion.CreaNumeroConsecutivo(sucursal,
                                                              caja,
                                                              ((int)Enums.TipoDocumento.Compras).ToString(),
                                                              entity.id.ToString().Trim());



                string codigoSeguridad = BFacturacion.CreaCodigoSeguridad(((int)Enums.TipoDocumento.Compras).ToString(),
                                                                sucursal,
                                                                caja,
                                                                entity.fecha,
                                                                entity.id.ToString().Trim());
                entity.clave = BFacturacion.CreaClave(codigoPais,
                                            entity.fecha.Day.ToString(),
                                            entity.fecha.Month.ToString(),
                                            entity.fecha.Year.ToString(),
                                            Global.Usuario.tbPersona.tbEmpresa.id.Trim(),
                                            entity.consecutivo,
                                            entity.estadoCompra.ToString().Trim(),
                                            codigoSeguridad);

        


            }


            return comprasIns.Guardar(entity);
        }
    }
}
