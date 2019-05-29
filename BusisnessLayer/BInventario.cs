using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BInventario
    {
        DInventario inveIns = new DInventario();
        tbInventario inventario = new tbInventario();

        //Creamos una lsta del inventario.
        List<tbInventario> listaInventario = new List<tbInventario>();
        
        /// <summary>
        /// Incrementamos o Desminuimos el inventario segun lo requerido.
        /// </summary>
        /// <param name="factura"> Factura a trabajar.</param>
        /// <param name="estado">Estado de la factura: 0 = resta, 1 = suma </param>
        /// <param name="productos"> Es la lista de los productos del formulario de facturacion. </param>
        public void ActualizarInventario(tbDocumento factura, List<tbProducto> productos , int estado)
        {

            // Creamos las variables para recuperar.
            string idProducto = string.Empty;  int  idIngrediente = 0;
            double cantidadComprada = 0.0F, cantInventario = 0.0F, cantidadIngrediente = 0.0F, cantNueva = 0.0F;
            int  cantMin = 0;


            // Cargamos la lista de inventario.
            listaInventario = GetListEntities(3);

            try
            {

                // Recorremos la lista del detalleFactura para recuperar el ID del Producto.
                foreach (tbDetalleDocumento produc in factura.tbDetalleDocumento)
                {

                    // Cargamos el id y la cantidad del producto comprado.
                    idProducto = produc.idProducto;
                    cantidadComprada =(double) produc.cantidad;


                    // Recorremos la lista de productos para recuperar el ID del producto
                    foreach (tbProducto item in productos)
                    {

                        if (idProducto == item.idProducto)
                        {
                                                        
                            // Creamos una lista de detalleProducto
                            ICollection<tbDetalleProducto> listaDetalleProducto = new List<tbDetalleProducto>();
                           // listaDetalleProducto = item.tbDetalleProducto;

                            // Recorremos la lista de DetalleProducto para recuperar el ID del ingrediente
                            foreach (tbDetalleProducto ingrediente in listaDetalleProducto)
                            {
                                if (idProducto == ingrediente.idProducto)
                                {
                                    // Cargamos al ID del ingrediente y la cantidad usada en el producto.
                                    cantidadIngrediente = ingrediente.cantidad;
                                    idIngrediente = ingrediente.idIngrediente;


                                    //foreach (tbInventario inventario in listaInventario)
                                    //{
                                    //    if (inventario.idIngrediente == idIngrediente)
                                    //    {

                                    //        // Procedemos a realizar la multiplicacion de la cantidad comprada por la cantidad usada en el producto.
                                    //        cantInventario = inventario.cantidad;
                                    //        cantMin = (int)inventario.cant_max;

                                    //        double temp = (cantidadComprada * cantidadIngrediente);

                                    //        // Si el estado es 0, se restara el inventario de X ingrediente.
                                    //        // Si el estado es 1, se sumara el inventario de X ingrediente.


                                    //        cantNueva = estado == 0 ? cantInventario - temp : cantInventario + temp;
                                            
                                    //        //ACtualizamos la cantidad en dicho producto.
                                    //        inventario.cantidad = cantNueva;

                                    //        //Actualizamos la entidad en cuestion.
                                    //        inveIns.Actualizar(inventario);


                                    //    }
                                    //}
                                    
                                }
                            }
                            
                        }

                    }
                    
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }




        public  List<tbInventario> GetListEntities(int estado)
        {
            return inveIns.GetListEntities(estado);
        }
        /*public static List<tbIngredientes> getListingre()
        {
            return DInventario.getListingre();
        }
        public static List<tbTipoMedidas> getListipo()
        {
            return DInventario.getListipo();
        }*/
        public List<tbInventario> modificar(List<tbInventario> inve)
        {
           // List<tbInventario> listaInventario = new List<tbInventario>();
            try
            {
               
                foreach (tbInventario u in inve) {


                   inveIns.Actualizar(u);
                }
                
                return inve;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
