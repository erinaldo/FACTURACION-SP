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
namespace PresentationLayer
{
    public partial class frmDetalleFactura : Form
    {
        //public frmCancelarFactura detalle = new frmCancelarFactura();
        public List<tbDetalleDocumento> listadetalle = new List<tbDetalleDocumento>();
        public BEliminarFactura factura = new BEliminarFactura();
        public frmDetalleFactura()
        {
            InitializeComponent();
        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
        {
            cargarDetalle();
            
        }
        private void cargarDetalle()
        {
            int id = frmCancelarFactura.CancelaFac.id;
            listadetalle =factura.ListaDetalles(id);
    
            foreach (tbDetalleDocumento u in listadetalle)
            {
              
                    ListViewItem item = new ListViewItem();
                    item.Text = u.tbProducto.nombre.ToString();
                    item.SubItems.Add(u.cantidad.ToString());
                    item.SubItems.Add(u.precio.ToString());
                    item.SubItems.Add(u.totalLinea.ToString());
                    lvstDetalleFac.Items.Add(item);
                
            }
        }

        private void lvstDetalleFac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
