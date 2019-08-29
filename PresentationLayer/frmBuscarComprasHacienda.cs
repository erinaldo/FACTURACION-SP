using BusinessLayer;
using EntityLayer;
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
    public partial class frmBuscarComprasHacienda : Form
    {
        public delegate void pasarDatos(tbReporteHacienda entity);
        public event pasarDatos pasarDatosEvent;

        List<tbReporteHacienda> listaReportes = new List<tbReporteHacienda>();
        BFacturacion facturacionIns = new BFacturacion();
        public frmBuscarComprasHacienda()
        {
            InitializeComponent();
        }

        private void frmBuscarComprasHacienda_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

        private void cargarDatos()
        {
            listaReportes= (List<tbReporteHacienda>)facturacionIns.listaMensajesCompras();
            listaReportes = listaReportes.Where(x=>x.EstadoRespHacienda.Trim().ToUpper()=="ACEPTADO" && x.tbCompras.Count==0).ToList();
            cargarLista(listaReportes);
        }
        public void cargarLista(List<tbReporteHacienda> lista)
        {
            try
            {
                lstvReportes.Items.Clear();
                foreach (tbReporteHacienda e in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = e.claveDocEmisor.ToString().Trim();
                    item.SubItems.Add(e.fechaEmision.ToString().Trim());
                    item.SubItems.Add(e.idEmisor.ToUpper().Trim());
                    item.SubItems.Add(e.nombreEmisor.ToUpper().Trim());
                    item.SubItems.Add(e.totalImp.ToString().Trim());
                    item.SubItems.Add(e.totalFactura.ToString().Trim());    
                    lstvReportes.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            pasarDatosSeleccionados();
        }

        private void pasarDatosSeleccionados()
        {
            if (lstvReportes.SelectedItems.Count > 0)
            {
                string id = lstvReportes.SelectedItems[0].Text.Trim();
                tbReporteHacienda pro = listaReportes.Where(x => x.claveDocEmisor == id).SingleOrDefault();
                if (pro != null)
                {
                    pasarDatosEvent(pro);
                    this.Dispose();
                }


            }

        }

        private void lstvReportes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pasarDatosSeleccionados();
        }
    }
}
