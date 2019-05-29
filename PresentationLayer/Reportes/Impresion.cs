using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Reportes
{
    public class Impresion
    {
       

        public Impresion(ReportDocument reporte)
        {
            _reporte = reporte;
        }

        ReportDocument _reporte { set; get; }


        public bool imprimirFacturacion()
        {


            return false;

        }


    }
}
