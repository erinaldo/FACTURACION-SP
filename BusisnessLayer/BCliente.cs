using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using BusinessLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;

namespace BusinessLayer
{
    public class Bcliente
    {// LUGAR DONDE SE MANEJA LA LOGICA DEL APLICATIVO....
        tbClientes clienteGlobal = new tbClientes();
        //DClientes ListaGlobal = new DClientes();
        DClientes clienteIns = new DClientes();

        public tbClientes Guardar(tbClientes cliente)
        {

            tbClientes clientExist = clienteIns.GetEntity(cliente);
            if (clientExist == null)
            {
                return clienteIns.Guardar(cliente);
            }
            else
            {
                if (clientExist.estado)
                {// LUGAR DE DONDE SE LANZAN LAS EXCEPCION PARA SER ATRAPADA EL FORM...
                    throw new EntityExistException(" Cliente");
                }
                else
                {

                    throw new EntityDisableStateException(" Cliente");
                }

            }
        }
      


        public tbClientes Modificar(tbClientes cliente)
        {


            return clienteIns.Actualizar(cliente);

        }


        public List<tbClientes> GetListEntities(int tipoCliente)
        {
            return clienteIns.GetListEntities(tipoCliente);
        }


        public static List<tbTipoClientes> getTipoCliente()
        {
            return DClientes.getTipoCliente();
        }
        public  tbClientes GetClienteById(string id)
        {
            return clienteIns.GetClienteById(id);
        }
        public tbPersonasTribunalS GetClienteByIdTribunal(string id)
        {
            return clienteIns.GetClienteByIdTribunal(id);
        }



    }


}