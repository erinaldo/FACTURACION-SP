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
    public partial class frmBuscarProducto : Form
    {

        BCategoriaProducto CatProductosIns = new BCategoriaProducto();
        //Creamos la instancia global para almacenar al producto bsucado.
        private tbProducto productoiG = new tbProducto();
        private IEnumerable<tbProducto> listaProductos = new List<tbProducto>();

        BProducto ProductoIns = new BProducto();


        //Creamos el delegado y evento para pasar la informacion corregida.
        public delegate void pasarDatos(tbProducto entidad);

        public event pasarDatos recuperarEntidad;



        /// <summary>
        /// Cargamos los productos en la lista.
        /// </summary>
        private void cargarProductos(IEnumerable<tbProducto> listaProductos)
        {

           
            //Leemos lista para pasarla al ListView
            foreach (tbProducto item in listaProductos)
            {

                //Creamos un objeto de tipo ListviewItem
                ListViewItem p = new ListViewItem();

                p.Text = item.idProducto.ToString();
                p.SubItems.Add(item.nombre);

                //Agregamos el item a la lista.
                lstvProductos.Items.Add(p);

            }

        }


        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {

            productoiG = null;

            //Cargamos la lista con los productos.
            buscar();
            cargarCategorias();
            cboCategoriaProducto.SelectedIndex = -1;

        }
        private void buscar()
        {

            try
            {
                lstvProductos.Items.Clear();
                IEnumerable<tbProducto> productos =  ProductoIns.getProductos((int)Enums.EstadoBusqueda.Activo);
                if (txtId.Text != string.Empty)
                {
                    productos = productos.Where(x => x.idProducto == txtId.ToString());

                }
                if (txtNombre.Text != string.Empty)
                {
                    productos = productos.Where(x => x.nombre.Trim().ToUpper().Contains(txtNombre.Text.Trim().ToUpper()));

                }

                if (cboCategoriaProducto.Text != string.Empty)
                {
                    productos = productos.Where(x => x.id_categoria == (int)cboCategoriaProducto.SelectedValue);

                }

                cargarProductos(productos);
                listaProductos = productos;
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }


        }

        private void cargarCategorias()
        {

            cboCategoriaProducto.ValueMember = "id";
            cboCategoriaProducto.DisplayMember = "nombre";
            cboCategoriaProducto.DataSource = CatProductosIns.getCategorias((int)Enums.EstadoBusqueda.Activo);
         

        }

        /// <summary>
        /// Agregamos el producto seleccionado a la entidad global de tipo tbProducto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (lstvProductos.SelectedItems.Count > 0)
            {
                string id =  lstvProductos.SelectedItems[0].Text.Trim();
                foreach (tbProducto p in listaProductos)
                {

                    if (id == p.idProducto)
                    {
                        productoiG = p;                       
                        recuperarEntidad(productoiG);

                        this.Dispose();
                    }

                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            productoiG = null;
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void cboCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void lstvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvProductos.SelectedItems.Count > 0)
            {
                string id = lstvProductos.SelectedItems[0].Text.Trim();
                tbProducto pro = listaProductos.Where(x => x.idProducto == id).SingleOrDefault();
                if (pro!=null)
                {
                   recuperarEntidad(pro);
                    this.Dispose();
                }
    
                
            }

        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cboCategoriaProducto.SelectedIndex = -1;
            buscar();
        }
    }
}
