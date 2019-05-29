using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public static class EnumMenu
    {
        public enum OpcionMenu
        {
            Guardar = 0,
            Nuevo = 2,
            Modificar = 4,
            Eliminar = 6,
            Buscar = 8,
            Cancelar = 10,
            Salir = 12
        }


        public enum HabilarDeshabilitar
        {
            habilitar = 1,
            deshabiltar = 2
        }

    }
}

