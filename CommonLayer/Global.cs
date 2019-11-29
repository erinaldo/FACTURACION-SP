using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public static class Global
    {

        private static tbUsuarios usuario;
        private static int numeroCaja;

        public static int sucursal { get; set; }
        public static tbEmpresaActividades actividadEconomic { get; set; }
        public static bool multiActividad { get; set; }

        public static tbUsuarios Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public static int NumeroCaja
        {
            get
            {
                return numeroCaja;
            }

            set
            {
                numeroCaja = value;
            }
        }
    }
}
