using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;
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
    public partial class buscarAct : Form
    {
        
        BActividadesEconomicas ActIns = new BActividadesEconomicas();
        public static List<tbActividades> listaActividades = new List<tbActividades>();
        public static tbActividades actGlo = new tbActividades();

        public delegate void pasaDatos(tbActividades entity);
        public event pasaDatos pasarDatosEvent;


        bool bandSeleccionar = false;

        public buscarAct()
        {
            InitializeComponent();
        }

        private void frmBuscarActividadEconomica_Load(object sender, EventArgs e)
        {
            actGlo = null;

            listaActividades = ActIns.GetListEntities((int)Enums.Estado.Activo);

            cargarLista(listaActividades);
        }

        private void cargarLista(List<tbActividades> listaActividades)
        {
            try
            {
                lsvbuscar.Items.Clear();
                foreach (tbActividades p in listaActividades)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.codigoAct;
                    item.SubItems.Add(p.nombreAct.ToUpper().Trim());                

                    lsvbuscar.Items.Add(item);

                }
            }
            catch (ListEntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsvbuscar.SelectedItems.Count > 0)
                {
                    string idSelected = lsvbuscar.SelectedItems[0].Text;
                    foreach (tbActividades act in listaActividades)
                    {
                        if (idSelected.Trim() == act.codigoAct.Trim())
                        {
                            actGlo = act;
                            break;
                        }
                    }
                }
            }
            catch (LicenseException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            pasarDatosEvent(actGlo);
            this.Dispose();
            bandSeleccionar = true;
        }

        private void lsvbuscar_DoubleClick(object sender, EventArgs e)
        {
            pasarDatosEvent(actGlo);
            this.Dispose();
            bandSeleccionar = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<tbActividades>lista = listaActividades.Where(x => x.codigoAct.Contains(txtBuscar.Text.Trim().ToUpper()) || x.nombreAct.Contains(txtBuscar.Text.Trim().ToUpper())).ToList();
                cargarLista(lista);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar la activdidad.", "Buscar Actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
