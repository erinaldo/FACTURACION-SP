using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using CommonLayer.Interfaces;
using CommonLayer;


namespace DataLayer
{
    public class DTipoMedida : IDataGeneric<tbTipoMedidas>
    {

    public tbTipoMedidas GetEnity(tbTipoMedidas NombreTipoMedida)
        {
           
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities()) 

                return (from T in context.tbTipoMedidas
                        where T.nombre == NombreTipoMedida.nombre
                        select T).SingleOrDefault();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbTipoMedidas GetEnityById(tbTipoMedidas medida)
        {
            
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())

                    return  (from T in context.tbTipoMedidas
                            where T.idTipoMedida == medida.idTipoMedida
                            select T).SingleOrDefault();
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Guardar(tbTipoMedidas tipoMedidas)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.tbTipoMedidas.Add(tipoMedidas);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                
                return false;
                throw ex;
                
            }
            return true;
        }

public List<tbTipoMedidas> GetListEntities(int estado)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    List<tbTipoMedidas> BuscarTipoMedida = new List<tbTipoMedidas>();
                    if (estado == (int)Enums.EstadoBusqueda.Activo)
                    {
                        return (from T in context.tbTipoMedidas
                                where T.estado == true
                                select T).ToList();
                    }
                    else if (estado == (int)Enums.EstadoBusqueda.Inactivos)
                    {
                        return (from T in context.tbTipoMedidas
                                where T.estado == false
                                select T).ToList();
                    }

                    else if (estado == (int)Enums.EstadoBusqueda.Todos)
                    
                    {
                        return (from T in context.tbTipoMedidas
                                select T).ToList();
                    }
                    return BuscarTipoMedida;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public   bool Actualizar(tbTipoMedidas TipoMedida)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(TipoMedida).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool eliminar(tbTipoMedidas TipoMedida)
        {
            try
            {
                using (dbSisSodInaEntities context = new dbSisSodInaEntities())
                {
                    context.Entry(TipoMedida).State = System.Data.Entity.EntityState.Modified;
                                                                                                         
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception   ex)
            {
                throw new Exception(ex.Message);
            }
        }

        tbTipoMedidas IDataGeneric<tbTipoMedidas>.Guardar(tbTipoMedidas entity)
        {
            throw new NotImplementedException();
        } 

        tbTipoMedidas IDataGeneric<tbTipoMedidas>.Actualizar(tbTipoMedidas entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoMedidas GetEntity(tbTipoMedidas entity)
        {
            throw new NotImplementedException();
        }
    }
}





