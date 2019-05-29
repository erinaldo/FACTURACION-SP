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
    public partial class frmBuscarIngrediente : Form
    {
        bool bandera;
        BIngredientes ingredienteBIns = new BIngredientes();
        List<tbIngredientes> listaIngrediente = new List<tbIngredientes>();
        public static tbIngredientes ingredienteGlo = new tbIngredientes();
        public delegate void pasarDatos(tbIngredientes entity);
        public event pasarDatos pasarDatosEvent;

        public frmBuscarIngrediente()
        {
            InitializeComponent();
        }

        private void frmBuscarIngrediente_Load(object sender, EventArgs e)
        {
            try
            {
                listaIngrediente = ingredienteBIns.GetListaIngrediente((int)Enums.EstadoBusqueda.Activo);
                cargarLista(listaIngrediente);
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        public void cargarLista(List<tbIngredientes> lista)

        {
            lstvIngredientes.Items.Clear();
            foreach (tbIngredientes a in lista)
            {
                ListViewItem item = new ListViewItem();
                item.Text = a.idIngrediente.ToString();
                item.SubItems.Add(a.nombre);
                if (a.estado)
                {
                    item.SubItems.Add("Activo");
                }
                else
                {
                    item.SubItems.Add("Inactivo");
                }
                lstvIngredientes.Items.Add(item);
            }

        }

   
        private void buscar()//texto buscar
        {
            List<tbIngredientes> listaBuscar = new List<tbIngredientes>();

            if (txtBuscar.Text.Trim() != string.Empty)
            {
                foreach (tbIngredientes a in listaIngrediente)
                {
                    if (a.nombre.Contains(txtBuscar.Text.ToUpper().Trim()))
                    {
                        listaBuscar.Add(a);
                    }
                }
                cargarLista(listaBuscar);

            }
            else
            {
                cargarLista(listaIngrediente);
            }

        }

    

        private void lstvIngredientes_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            pasarDatosEvent(ingredienteGlo);
            this.Dispose();
            bandera = true;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            buscar();
        }

        private void lstvIngredientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstvIngredientes.SelectedItems.Count > 0)
            {

                string idSelected = lstvIngredientes.SelectedItems[0].Text;
                foreach (tbIngredientes ingrediente in listaIngrediente)
                {
                    if (int.Parse(idSelected) == ingrediente.idIngrediente)
                    {
                        ingredienteGlo = ingrediente;
                    }
                }
            }
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            pasarDatosEvent(ingredienteGlo);
            this.Dispose();
            bandera = true;
        }

        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (!bandera)
            {
                ingredienteGlo = null;
                pasarDatosEvent(ingredienteGlo);
            }
        }

        private void lstvIngredientes_DoubleClick_1(object sender, EventArgs e)
        {
            
        }
    }
}
