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
using CommonLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class frmBuscarCategoriaProducto : Form
    {

        //Creamos las variables globales que usaremos en el formulario
         tbCategoriaProducto categoriaProducGlobal = new tbCategoriaProducto();
        List<tbCategoriaProducto> listaCategoriaProducto = new List<tbCategoriaProducto>();

        BCategoriaProducto CatProductIns = new BCategoriaProducto();


        //Creamos el delegado y el evento
        public delegate void pasarDatos(tbCategoriaProducto entity);

        public event pasarDatos recuperamosEntidad;
        


        /// <summary>
        /// Cargamos la lista con las diferentes categorias que hay en la bse de datos.
        /// </summary>
        private void cargarLista()
        {

            listaCategoriaProducto = CatProductIns.getCategorias(3);
            foreach (tbCategoriaProducto p in listaCategoriaProducto)
            {
                    
                //Creamos un nuevo Item del tipo ListViewItem
                ListViewItem itemNuevo = new ListViewItem();

                itemNuevo.Text = p.id.ToString();
                itemNuevo.SubItems.Add(p.nombre.Trim());

                if (p.estado == true)
                {
                    itemNuevo.SubItems.Add("Activa");

                }
                else 
                {
                    itemNuevo.SubItems.Add("Inactiva");
                }

                //Agregamops el itme a la lista.
                lstvCategoriaProductos.Items.Add(itemNuevo);


            }


        }



        public frmBuscarCategoriaProducto()
        {
            InitializeComponent();
        }

        private void txtCategoriaProducto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstvCategoriaProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(lstvCategoriaProductos.SelectedItems.Count > 0)
            {

                //Seleccionamos el indice 1 del elemento selccionado.
                int select = Convert.ToInt16( lstvCategoriaProductos.SelectedItems[0].Text );
                foreach (tbCategoriaProducto p in listaCategoriaProducto)
                {
                    
                    if(p.id == select)
                    {
                        categoriaProducGlobal = p;

                    }

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            categoriaProducGlobal = null;

            this.Close();
        }

        private void frmBuscarCategoriaProducto_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            recuperamosEntidad(categoriaProducGlobal);

            this.Dispose();
        }

        private void frmBuscarCategoriaProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoriaProducGlobal = null;

        }

        private void frmBuscarCategoriaProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            categoriaProducGlobal = null;
        }
    }
}
