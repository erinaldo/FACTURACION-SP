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


namespace PresentationLayer
{

    public partial class frmAgregarIngredieteProducto : Form
    {

        //Variables globales del formulario.

        List<tbTipoIngrediente> listaCatIngredientes    = new List<tbTipoIngrediente>();
        List<tbIngredientes> listaIngredientes          = new List<tbIngredientes>();

        tbDetalleProducto detalleProducto               = new tbDetalleProducto();

        tbCategoriaProducto categoriasProduc            = new tbCategoriaProducto();

        BTipoIngrediente tipoIngredienteIns             = new BTipoIngrediente();
        BIngredientes ingredietnesIns                   = new BIngredientes(); 



        //Creamos un delegado y su evento para cargar.
        public delegate void pasarDatos(tbDetalleProducto entidad);
        public event pasarDatos recuperarDetalleProducto;



        /// <summary>
        /// Validamos los campos en el formulario.
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {

            if (txtCantidadIngrediente.Text == string.Empty)
            {
                MessageBox.Show("Debe inrgesar una cantidad para poder continuar.", "Error.");
                txtCantidadIngrediente.Focus();
                return false;
            }

            return true;

        }

        /// <summary>
        /// Cargaremos las diferentes categorias de ingredientes en el combo box.
        /// </summary>
        private void cargarCatIngredientes()
        {

            cboCatIngrediente.DisplayMember = "nombre";
            cboCatIngrediente.ValueMember = "id";
            cboCatIngrediente.DataSource = tipoIngredienteIns.getListTipoing(1);

        }

        /// <summary>
        /// Cargamos los diferentes tipos de ingredientes segun la categoria
        /// </summary>
        private void cargarIngredientes()
        {

            lstvIngrediente.Items.Clear();

            //Casteamos el valor ID seleccionado del combobox.
            int idBuscar = (int)cboCatIngrediente.SelectedValue;
            //Ingresamos el ID para buscar los ingredientes segun la categoria.
            listaIngredientes = ingredietnesIns.GetListIngredientesPorID(idBuscar);

            //Recorremos la lista para mostrar los diferentes ingredientes.
            foreach (tbIngredientes p in listaIngredientes)
            {

                ListViewItem ingredienteNuevo = new ListViewItem();

                //Cargamos los valores en la tabla
                lstvIngrediente.View = View.Details;
                ingredienteNuevo.Text = p.idIngrediente.ToString().Trim();
                ingredienteNuevo.SubItems.Add(p.nombre.Trim());
                //Agregamos nomenclatura a la tabla.

                //ingredienteNuevo.SubItems.Add(p.tbTipoMedidas.nomenclatura.Trim());

                
                //ingredienteNuevo.SubItems.Add(p.tbTipoMedidas.nomenclatura.Trim());

                //Cargamos los items nuevos en el listView
                lstvIngrediente.Items.Add(ingredienteNuevo);


            }

        }

         
        public frmAgregarIngredieteProducto()
        {
            InitializeComponent();
        }

        private void btnSeleccionarIngrediente_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

                //Asignamos los valores a la lista.
                if (lstvIngrediente.SelectedItems.Count > 0)
                {
                    
                    int idIngrediente = Convert.ToInt16(lstvIngrediente.SelectedItems[0].Text);
                    foreach (tbIngredientes p in listaIngredientes)
                    {

                        if (idIngrediente == p.idIngrediente)
                        {

                            detalleProducto.cantidad = float.Parse(txtCantidadIngrediente.Text.Trim());
                            detalleProducto.idIngrediente = p.idIngrediente;
                            
                        }

                    }

                    recuperarDetalleProducto(detalleProducto);

                    this.Close();
                }
                else
                {
                    detalleProducto = null;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            detalleProducto = null;

            this.Close();
        }

        private void frmAgregarIngredieteProducto_Load(object sender, EventArgs e)
        {
            //Cargamos las diferentes categorias de los ingredientes.
            cargarCatIngredientes();
            
        }

        /// <summary>
        /// Cambiamos el la categoria en el comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCatIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarIngredientes();
        }

        /// <summary>
        /// Seleccionamos un ingrediente en el ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstvIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvIngrediente.SelectedItems.Count > 0)
            {
                string idSeleccionado = lstvIngrediente.SelectedItems[0].Text;

                foreach (tbIngredientes p in listaIngredientes)
                {

                    if (Convert.ToInt16( idSeleccionado ) == p.idIngrediente)
                    {
                        lblnumeroID.Text = p.idIngrediente.ToString();
                        lblProductoName.Text = p.nombre;


                    }

                }
            }

        }

        private void frmAgregarIngredieteProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Asignamos nulo el campo porque se esta saliendo del formulario
            detalleProducto = null; 
        }

    }
}
