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
    public partial class frmBuscarCajas : Form
    {
        List<tbCajas> listacajas = new List<tbCajas>();
        tbCajas  cajasGlo = new tbCajas();
        BCajas Inscajas = new BCajas();
        bool banderaSeleccionar = false;
        public frmBuscarCajas()
        {
            InitializeComponent();
        }

        //creo mi delegado
        public delegate void pasaDatos(tbCajas entity);

        //evento
        public event pasaDatos pasarDatosEvent;

        private void frmBuscarCajas_Load(object sender, EventArgs e)
        {
            try
            {
                listacajas = Inscajas.getListTipoing((int)Enums.EstadoBusqueda.Todos);
                cargarLista(listacajas);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(cajasGlo);//llamar al evento 
            this.Dispose();
        }

        public void cargarLista(List<tbCajas> lista)
        {

            try
            {
                
                lstvCajas.Items.Clear();
                foreach (tbCajas u in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = u.id.ToString();
                    item.SubItems.Add(u.nombre);

                    if (u.estado)
                    {

                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");

                    }
                    lstvCajas.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void lstvCajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvCajas.SelectedItems.Count > 0)
            {


                string idSelected = lstvCajas.SelectedItems[0].Text;



                foreach (tbCajas cajas in listacajas)
                {

                    if (int.Parse(idSelected) == cajas.id)
                    {
                        cajasGlo = cajas;
                    }
                }
            }
        }

        private void buscar()
        {
            List<tbCajas> listaBuscar = new List<tbCajas>();

            if (txtBuscar.Text.Trim() != string.Empty)
            {

                foreach (tbCajas u in listacajas)
                {
                    if (u.nombre.Contains(txtBuscar.Text.Trim()))
                    {

                        listaBuscar.Add(u);
                    }

                }
                cargarLista(listaBuscar);
            }
            else
            {

                cargarLista(listacajas);
            }

        }
        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            if (!banderaSeleccionar)
            {
                cajasGlo = null;
                pasarDatosEvent(cajasGlo);
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }


   
}
