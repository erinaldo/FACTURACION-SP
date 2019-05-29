using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using CommonLayer;
using CommonLayer.Exceptions;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Interfaces;



namespace BusinessLayer
{
    public  class BPuesto
    {
        DPuesto PuestoIns = new DPuesto();//creo un nuevo objeto para eviar a datos
        public  List<tbTipoPuesto> getlistEntities(int estado)
        {

            return PuestoIns.GetListEntities(estado);
        }

        public  tbTipoPuesto guardar(tbTipoPuesto puesto)
        {

            tbTipoPuesto puestoTra = PuestoIns.GetEntity(puesto);
            if (puestoTra == null)
            {
               
                return PuestoIns.Guardar(puesto);
            }
            else
            {

                if (puestoTra.estado == true)
                {
                    throw new EntityExistException("puesto");
                }
                else
                {
                    throw new EntityDisableStateException("puesto");
                }

               
            }
        }

        public tbTipoPuesto modificar(tbTipoPuesto entity)
        {

            return PuestoIns.Actualizar(entity);

        }
        public tbTipoPuesto eliminar(tbTipoPuesto entity)
        {

            return PuestoIns.Actualizar(entity);

        }




        }

    }

