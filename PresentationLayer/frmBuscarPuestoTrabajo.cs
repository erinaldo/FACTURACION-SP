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
using CommonLayer;

namespace PresentationLayer
{
    


    public partial class frmBuscarPuestoTrabajo : Form
    {
        BPuesto PuestoIns = new BPuesto();
        List<tbTipoPuesto> listaPuesto = new List<tbTipoPuesto>();
        tbTipoPuesto puestoGlo = new tbTipoPuesto();
        public delegate void pasarDatos(tbTipoPuesto entity);
        public event pasarDatos pasarDatosEvent;
        bool banderaSelecciona = false;
        public frmBuscarPuestoTrabajo()
        {
            InitializeComponent();
        }

        private void frmBuscarPuestoTrabajo_Load(object sender, EventArgs e)
        {
            listaPuesto = PuestoIns.getlistEntities((int)Enums.EstadoBusqueda.Todos);
            cargarLista(listaPuesto);

        }

        public void cargarLista(List<tbTipoPuesto> lista) {


            try
            {

                lstvPuestos.Items.Clear();
                foreach (tbTipoPuesto p in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.idTipoPuesto.ToString();
                    item.SubItems.Add(p.nombre);

                    if (p.estado)
                    {

                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");

                    }
                    lstvPuestos.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            banderaSelecciona = true;
            pasarDatosEvent(puestoGlo);
            this.Dispose();

        }

      /*  private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListViewItem item= lstvPuestos.FindItemWithText(txtBuscar.Text);
            if (item != null)
            {
                item.BackColor = SystemColors.HighlightText;
            
            }
        }*/

        private void lstvPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvPuestos.SelectedItems.Count > 0) {

                string idSelected = lstvPuestos.SelectedItems[0].Text;


           
                foreach (tbTipoPuesto puesto in listaPuesto) {

                    if (int.Parse(idSelected) == puesto.idTipoPuesto) {
                        puestoGlo = puesto;
                    }
                }
            }
        }



        private void lstvPuestos_DobleClick(object sender, MouseEventArgs e)
        {
            banderaSelecciona = true;
            pasarDatosEvent(puestoGlo);
            this.Dispose(); 
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            List<tbTipoPuesto> listaBuscar = new List<tbTipoPuesto>();
            //trim elimina espacios en blanco
            if (txtBuscar.Text.Trim() != string.Empty) {
                
                txtBuscar.CharacterCasing = CharacterCasing.Upper;//para escribir los datos en mayuscula
                foreach (tbTipoPuesto p in listaPuesto)
                {
                    if (p.nombre.Contains(txtBuscar.Text.ToUpper().Trim())) {

                        listaBuscar.Add(p);
                    }

                }
                cargarLista(listaBuscar);
            }
            else
            {
                //carga la lista completa
                cargarLista(listaPuesto);
            }  
            
       }
    }
}
