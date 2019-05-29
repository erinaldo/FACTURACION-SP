using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using EntityLayer;

namespace SisSodINA
{
    public partial class frmBuscarTipoMedida : Form

    {
        bTipoMedidas tipoMedidaIns = new bTipoMedidas();
        bool banderaSeleccionar = false;


        List<tbTipoMedidas> listaTipoMedida = new List<tbTipoMedidas>();
        tbTipoMedidas tipoMedidaGlo = new tbTipoMedidas();


        // delegado
        public delegate void PasarDatos(tbTipoMedidas entity);


        // evento
        public event PasarDatos pasarDatosEvent;




        public frmBuscarTipoMedida()
        {
            InitializeComponent();
        }
       
        private void buscar()
        {
            List<tbTipoMedidas> listaTipo = new List<tbTipoMedidas>();
            try
            {
                           //trim elimina espacios en blanco
                if (txtBuscarTipoMedida.Text.Trim() != string.Empty)
                {
                    foreach (tbTipoMedidas T in listaTipoMedida)
                    {
                        if (T.nombre.Contains(txtBuscarTipoMedida.Text.ToUpper().Trim()))
                        {
                            listaTipo.Add(T);
                        }
                    }
                    cargarLista(listaTipo);
                }
                else
                {
                    //carga la lista completa
                    cargarLista(listaTipoMedida);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se puede buscar el elemento seleccionado","alerta!");
                throw ex;
            }
        }
             public void cargarLista(List<tbTipoMedidas> lista)
        {
            lstvTipoMedida.Items.Clear();
            foreach (tbTipoMedidas t in lista)
            {
                ListViewItem item = new ListViewItem();
                item.Text = t.idTipoMedida.ToString();
                item.SubItems.Add(t.nombre);

                if (t.estado)
                {
                    item.SubItems.Add("Activo");
                }
                else
                {
                    item.SubItems.Add("Inactivo");
                }
                 lstvTipoMedida.Items.Add(item);
            } 
        }

        private void txtBuscarTipoMedida_TextChanged(object sender, EventArgs e)
        {//textbox buscar
            buscar();
        }
        
        private void lstvTipoMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvTipoMedida.SelectedItems.Count > 0)
            {
                string idSelected = lstvTipoMedida.SelectedItems[0].Text;
                foreach (tbTipoMedidas tipoMedida in listaTipoMedida)
                {
                        if (int.Parse(idSelected) == tipoMedida.idTipoMedida)
                    {
                        tipoMedidaGlo = tipoMedida;
                    }
                }
            }
        }
        private void lstvTipoMedida_DobleClick(object sender, MouseEventArgs e)
        {//este es el doble clic para seleccionar el objeto
            banderaSeleccionar = true;
            pasarDatosEvent(tipoMedidaGlo);// este metodo recibe la variable global tipoMedidaGlo
            this.Dispose();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(tipoMedidaGlo);
            this.Dispose();
        }
        private void frmBuscarTipoMedida_Load(object sender, EventArgs e)
        {
            listaTipoMedida = tipoMedidaIns.getlistatipomedida();
            cargarLista(listaTipoMedida);
        }

        private void cerrarForm(object sender, FormClosedEventArgs e)
        {

            if (!banderaSeleccionar)
            {
            tipoMedidaGlo = null;
            pasarDatosEvent(tipoMedidaGlo);
            }
        }
    }
}
