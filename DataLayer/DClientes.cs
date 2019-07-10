using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer;
using CommonLayer.Interfaces;

namespace DataLayer
{
    public partial class DClientes : IDataGeneric<tbClientes>
    {// LLAMA A LAS INTERFACES Y SE CREAN LOS METODOS CON LOS MISMOS PARAMETROS QUE FUERON DECLARADOS...

        DPersona persona = new DPersona();
        public tbClientes GetEntity(tbClientes clientes)
        {
            tbClientes cliente;


            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())

                    cliente = (from p in context.tbClientes
                           where p.id == clientes.id
                           && p.tipoId ==clientes.tipoId

                           select p).SingleOrDefault();

                return cliente;

            }
            catch (Exception)
            {

                throw new SaveEntityException("Cliente");
            }
        }
       


        public tbClientes Guardar(tbClientes clientes)
        {


            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    if (persona.GetEntity(clientes.tbPersona) != null)
                    {


                        context.Entry(clientes.tbPersona).State = System.Data.Entity.EntityState.Modified;



                    }

                    context.tbClientes.Add(clientes);
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                throw new SaveEntityException("Cliente");

            }
            return clientes;
        }
      
        public tbClientes Actualizar(tbClientes cliente)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    //SE LE AGRAGA OTRO CONTEX CON LA RELACION A LA TABLA DE LA CUAL OCUPAMOS DATOS.....
                     
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;

                    context.Entry(cliente.tbPersona).State = System.Data.Entity.EntityState.Modified;
                 
                    context.SaveChanges();
                    return cliente;
                }

            }
catch (Exception EX)
            {
                throw new UpdateEntityException(" Cliente  ");


            }
        }

        public static List<tbTipoClientes> getTipoCliente()
        {
            List<tbTipoClientes> tipoCLiente;

            try
            {

                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {

                    tipoCLiente = (from p in context.tbTipoClientes select p).ToList();


                    return tipoCLiente;
                }

            }
            catch (Exception)
            {
                throw new ListEntityException(" Cliente");

            }

        }


        public List<tbClientes> GetListClientes(int TipoCliente)
        {
            List<tbClientes> tipoCliente;
            try
            {
                dbSisSodInaEntities context = new dbSisSodInaEntities();

                tipoCliente = (from p in context.tbClientes
                               where p.estado == true
                               select p).ToList();

                return tipoCliente;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<tbClientes> GetListEntities(int estado)
        {
            

                try
                {
                // SE AGREGA EL USING
                     using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        //PARA JALAR LOS DATOS DE LAS TABLAS RELACIONADAS SE USA LA PALABRA RESERVADA INCLUDE....Y ENTRE("")EL NOMBRE DE LAS TABLAS RELACIONADAS.
                        return (from p in context.tbClientes.Include("tbPersona").Include("tbTipoClientes").Include("tbDocumento.tbDetalleDocumento")
                                //.Include("tbDocumento.tbAbonos")
                                where p.estado == true
                                select p).ToList();

                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        return (from p in context.tbClientes.Include("tbPersona").Include("tbTipoClientes").Include("tbDocumento.tbDetalleDocumento")
                                //.Include("tbDocumento.tbAbonos")
                                where p.estado == false
                                select p).ToList();
                    }
                    else
                    {
                        return (from p in context.tbClientes.Include("tbPersona").Include("tbTipoClientes").Include("tbDocumento.tbDetalleDocumento")
                                //.Include("tbDocumento.tbAbonos")
                                select p).ToList();
                    }


                }
                catch (Exception ex)
                {
                    throw ex;
                }

        }

        public tbClientes GetClienteById( string id)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbClientes.Include("tbPersona")
                            where p.estado == true && p.id == id 
                            select p).SingleOrDefault();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public tbClientes GetClienteById(int tipo, string id)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbClientes.Include("tbPersona")
                        where p.estado == true && p.id == id.Trim() && p.tipoId==tipo
                        select p).SingleOrDefault();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public tbPersonasTribunalS GetClienteByIdTribunal(string id)
        {

            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    return (from p in context.tbPersonasTribunalS
                            where  p.ID == id
                            select p).SingleOrDefault();

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}



