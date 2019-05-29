using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLayer;
using CommonLayer;
namespace PresentationLayer
{
    public partial class frmCancelarFactura : Form
    {
        public List<tbDocumento> ListaFacturas = new List<tbDocumento>();
        public BEliminarFactura InsFactura = new BEliminarFactura();
        public static tbDocumento CancelaFac = new tbDocumento();
        public string usuario = Global.Usuario.nombreUsuario.Trim().ToUpper();
        public DateTime fecha = DateTime.Now;
        TimeSpan hora = new TimeSpan(00, 00, 00);

        //Creamos una instancia de tipo Lista de los productos
        List<tbProducto> listaProductos = new List<tbProducto>();

        //Creamos una instancia de la capa de negocios de productos
        BProducto productoIns = new BProducto();

        // Creamos una instancia de BInventario.
        BInventario invenarioIns = new BInventario();

        // Creamos una nuevo delegado  y su evento.
        public delegate void recuperarProductos(List<tbProducto> lista);
        public event recuperarProductos recuperarProductosLista;
        
        public frmCancelarFactura()
        {
            InitializeComponent();
        }

        private void recuperarListaProductos(List<tbProducto> productosFacturacion)
        {
            listaProductos = productosFacturacion;
        }


        private void frmCancelarFactura_Load(object sender, EventArgs e)
        {
            fecha = fecha.Date + hora;
            lblfecha.Text = Utility.getDate().ToString();

            recuperarProductosLista(listaProductos);


            ListaFacturas = InsFactura.ListaFaturas(1, fecha, usuario);
            CargarFacturas(ListaFacturas);


            //Cargamos los productos de la base de datos.
            listaProductos = productoIns.getProductos(3);

            
        }

        /// <summary>
        /// Cargamos la factura en el ListView.
        /// </summary>
        /// <param name="lista"></param>
        private void CargarFacturas(List<tbDocumento>lista) {

            try
            {
                foreach (tbDocumento u in lista)
                {

                    ListViewItem item = new ListViewItem();

                    item.Text = u.id.ToString();
                    if (u.idCliente == null)
                    {
                        item.SubItems.Add("Sin nombre");
                    }
                    else
                    {
                        item.SubItems.Add(u.tbClientes.tbPersona.nombre.ToString().Trim());
                    }
                    //Asignamos el tipo de factura segun su tipo de pago.
                    if (u.tipoPago == (int)Enums.TipoCompra.Contado)
                    {
                        item.SubItems.Add("Contado");
                    }

                    else if (u.tipoPago == (int)Enums.TipoCompra.Credito)
                    {
                        item.SubItems.Add("Credito");
                    }

                    else
                    {
                        item.SubItems.Add("Tarjeta");
                    }

                    //item.SubItems.Add(u.total.ToString());

                    //Asignamos el estado de la factura.
                    if (u.estadoFactura == (int)Enums.EstadoFactura.Cancelada)
                    {
                        item.SubItems.Add("Cancelada");
                    }
                    //else if (u.estadoFactura == (int)Enums.EstadoFactura.Eliminada)
                    //{

                    //    item.SubItems.Add("Eliminada");
                    //    item.SubItems[4].ForeColor = Color.Red;
                    //    item.UseItemStyleForSubItems = false;
                    //}
                    //else
                    //{
                    //    item.SubItems.Add("Pediente");
                    //}

                    //Cargamos el item en el listview
                    lstvCancelarFac.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void lstvCancelarFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvCancelarFac.SelectedItems.Count > 0)
            {

                int idSelected = int.Parse( lstvCancelarFac.SelectedItems[0].Text);
                foreach (tbDocumento cancelar in ListaFacturas )
                {

                    if (idSelected == cancelar.id)
                    {
                        CancelaFac = cancelar;

                    }
                }
           


            }
        }

        private void lstvCancelarFac_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmDetalleFactura detalle = new frmDetalleFactura();
            detalle.ShowDialog();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            if(eliminar())
            {
                // Falta recueperar la lista de productos desde facturacion-.
                invenarioIns.ActualizarInventario(CancelaFac, listaProductos, 1);
            }
            


        }

        /// <summary>
        /// Actualiza el estado de la factura a Eliminada.
        /// </summary>
       private bool  eliminar ()
        {
            bool isOK = false;

            try
            {
                //CancelaFac.estadoFactura = (int)Enums.EstadoFactura.Eliminada;
                InsFactura.eliminar(CancelaFac);

                lstvCancelarFac.Items.Clear();
                ListaFacturas = InsFactura.ListaFaturas(1, fecha, usuario);
                CargarFacturas(ListaFacturas);

                isOK = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }

            return isOK;

        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {

            //Aqui llamamos a la impresion.
            //Creamos una instancia de la clase de impresion.
           // clsImpresionFactura imprimir = new clsImpresionFactura();
            //imprimir.obtenerEntidades += cargarImpresion;

            //imprimir.print();

        }

        /// <summary>
        /// Cargaremo los datos requeridos para realizar la impresion de la factura.
        /// </summary>
        private void cargarImpresion(ref tbDocumento factura, ref List<tbProducto> Productos)
        {

            factura = CancelaFac;
            Productos = listaProductos;

        }
    }
}
