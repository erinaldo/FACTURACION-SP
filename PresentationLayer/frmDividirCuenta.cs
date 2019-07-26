using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmDividirCuenta : Form
    {
        List<tbDetalleDocumento> detalleDocumentoParcial = new List<tbDetalleDocumento>();
        public tbDocumento documentoTotal { get; set; }
        public frmDividirCuenta()
        {
            InitializeComponent();
        }

        private void frmDividirCuenta_Load(object sender, EventArgs e)
        {
            try
            {
                cargarListaTotal();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
        }

        private void cargarListaTotal()
        {
           lstViewTotal.Items.Clear();
            foreach (var detalle in documentoTotal.tbDetalleDocumento)
            {
                for (int i = 0; i < detalle.cantidad; i++)
                {
                    ListViewItem item = new ListViewItem();
                    // Place a check mark next to the item.
                    item.Checked = false;
                    item.SubItems.Add(detalle.idProducto);
                    item.SubItems.Add(detalle.tbProducto.nombre.Trim().ToUpper());
                    item.SubItems.Add(detalle.precio.ToString());
                    lstViewTotal.Items.Add(item);
                }
            }
        }

        private void lstViewTotal_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (e.Item.Checked)
                {
                    string prod = e.Item.SubItems[1].Text;
                    var detalle = documentoTotal.tbDetalleDocumento.Where(x => x.idProducto == prod.Trim()).SingleOrDefault();
                    documentoTotal.tbDetalleDocumento.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad = documentoTotal.tbDetalleDocumento.Where(x => x.idProducto == prod.Trim()).SingleOrDefault().cantidad - 1;
                    detalle.cantidad = 1;
                    detalleDocumentoParcial.Add(detalle);
                }
                refrescarListas();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
           
        }

        private void refrescarListas()
        {
            cargarListaParcial();
            cargarListaTotal();
        }

        private void cargarListaParcial()
        {
            lstvListaParcial.Items.Clear();
            foreach (var detalle in detalleDocumentoParcial)
            {
                for (int i = 0; i < detalle.cantidad; i++)
                {
                    ListViewItem item = new ListViewItem();
                    // Place a check mark next to the item.
                    item.Checked = false;
                    item.SubItems.Add(detalle.idProducto);
                    item.SubItems.Add(detalle.tbProducto.nombre.Trim().ToUpper());
                    item.SubItems.Add(detalle.precio.ToString());
                    lstvListaParcial.Items.Add(item);
                }
            }
        }

    }
}
