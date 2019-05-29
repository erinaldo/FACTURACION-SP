using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLayer
{
    public static class MenuGenerico
    {
        public static void CambioEstadoMenu(ref ToolStrip menu, int estado)
        {

            switch (estado)
            {

                case (int)EnumMenu.OpcionMenu.Guardar:
                    menu.Items[(int)EnumMenu.OpcionMenu.Guardar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Nuevo].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Modificar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Eliminar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Buscar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Cancelar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Salir].Enabled = false;
                    break;
                case (int)EnumMenu.OpcionMenu.Nuevo:
                    menu.Items[(int)EnumMenu.OpcionMenu.Nuevo].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Guardar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Modificar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Eliminar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Buscar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Cancelar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Salir].Enabled = true;


                    break;
                case (int)EnumMenu.OpcionMenu.Modificar:
                    menu.Items[(int)EnumMenu.OpcionMenu.Modificar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Guardar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Nuevo].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Eliminar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Buscar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Cancelar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Salir].Enabled = false;

                    break;
                case (int)EnumMenu.OpcionMenu.Eliminar:
                    menu.Items[(int)EnumMenu.OpcionMenu.Modificar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Guardar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Nuevo].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Eliminar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Buscar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Cancelar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Salir].Enabled = true;


                    break;
                case (int)EnumMenu.OpcionMenu.Buscar:


                    break;
                case (int)EnumMenu.OpcionMenu.Cancelar:
                    menu.Items[(int)EnumMenu.OpcionMenu.Nuevo].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Guardar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Modificar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Eliminar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Buscar].Enabled = true;
                    menu.Items[(int)EnumMenu.OpcionMenu.Cancelar].Enabled = false;
                    menu.Items[(int)EnumMenu.OpcionMenu.Salir].Enabled = true;

                    break;

            }

        }
    }
}
