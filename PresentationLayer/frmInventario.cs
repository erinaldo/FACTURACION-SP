
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
using CommonLayer;
using CommonLayer.Exceptions.DataExceptions;

namespace PresentationLayer
{
    public partial class frmInventario : Form
    {
        //
        //ESTE ES
        //
        public static int banderalis;
        public static  List<tbInventario> listainve = new List<tbInventario>();
        public static tbInventario inveGlo = new tbInventario();
        public BInventario inveIns = new BInventario();
        tbInventario inventarioGlo = new tbInventario();
        BCategoriaProducto CatProductosIns = new BCategoriaProducto();

        public frmInventario()
        {
            InitializeComponent();
        }

        private void cargarCombos()
        {



         
            cboCategoriaProducto.ValueMember = "id";
            cboCategoriaProducto.DisplayMember = "nombre";
            cboCategoriaProducto.DataSource = CatProductosIns.getCategorias((int)Enums.EstadoBusqueda.Activo);


        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {

            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
            Utility.EnableDisableForm(ref gbxInventario, false);
            tlsBtnBuscar.Enabled = false;
            tlsBtnCancelar.Enabled = false;
            tlsBtnEliminar.Enabled = false;
            tlsBtnSalir.Enabled = true;
            listainve = inveIns.GetListEntities(3);
       
            cargarCombos();
            cboCategoriaProducto.SelectedIndex = -1;
            cargarLista(listainve);

        }
     


        public void cargarLista(List<tbInventario> lista)
        {
            
            try
            {

                ltvCargar.Items.Clear();


                foreach (tbInventario u in lista)
                {
              


                        ListViewItem item = new ListViewItem();
                        item.Text = u.idProducto.ToString().Trim();
                        item.SubItems.Add(u.tbProducto.nombre.Trim().ToUpper().ToString());
                        item.SubItems.Add(u.tbProducto.tbTipoMedidas.nomenclatura.Trim().ToUpper().ToString());
                        item.SubItems.Add(u.tbProducto.tbCategoriaProducto.nombre.Trim().ToUpper().ToString());
                        item.SubItems.Add(u.cantidad.ToString());
                        item.SubItems.Add(u.cant_max.ToString());
                        item.SubItems.Add(u.cant_min.ToString());
                        ltvCargar.Items.Add(item);
           

                }
            }
            catch (ListEntityException ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void modificar()
        {
            
            try
            {
                if (banderalis == 1)
                {
                    inveIns.modificar(listainve);
                    cargarLista(listainve);

                    MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    banderalis = 0;
                }
                else
                {
                    MessageBox.Show("No hay datos que actualizar", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":


                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxInventario, false);
                    tlsBtnBuscar.Enabled = false;
                    tlsBtnCancelar.Enabled = false;
                    tlsBtnEliminar.Enabled = false;
                    tlsBtnSalir.Enabled = true;
                    modificar();
                    break;

                case "Nuevo":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxInventario, true);

                    Utility.ResetForm(ref gbxInventario);
                    break;

                case "Modificar":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxInventario, true);
                    tlsBtnSalir.Enabled = true;
                    //tlsBtnCancelar.Enabled = false;
                  


                    break;
                case "Eliminar":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;
                case "Buscar":

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxInventario, true);

                    break;
                case "Cancelar":
                    listainve.Clear();
                    Utility.ResetForm(ref gbxInventario);
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gbxInventario, false);
                    tlsBtnBuscar.Enabled = false;
                    tlsBtnCancelar.Enabled = false;
                    tlsBtnEliminar.Enabled = false;
                    tlsBtnSalir.Enabled = true;
                    listainve = inveIns.GetListEntities(3);
                    cargarLista(listainve);

                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }





        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }



        private void ltvCargar_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (ltvCargar.SelectedItems.Count > 0)
            {

                string idSelected = ltvCargar.SelectedItems[0].Text;



                //foreach (tbInventario inve in listainve)
                //{

                //    if (int.Parse(idSelected) == inve.idInventario)
                //    {
                //        inveGlo = inve;
                       
                //    }
                //}

            }

        }

       

        //metodo buscar en el textbox
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = "Buscar por código...";
            cboCategoriaProducto.SelectedIndex = -1;
            buscar();
          
        }
        private void buscar()
        {
            buscar(-1,1);

        }


        private void buscar(int codigo, int busqueda)
        {
            List<tbInventario> listaBuscar = new List<tbInventario>();
            //trim elimina espacios en blanco

            if (busqueda == 1)
            {
                if (txtBuscar.Text.Trim() != string.Empty)
                {

                    foreach (tbInventario p in listainve)
                    {
                        if (p.tbProducto.nombre.ToUpper().Contains(txtBuscar.Text.ToUpper().Trim()))
                        {

                            listaBuscar.Add(p);
                        }

                    }
                    cargarLista(listaBuscar);
                }
                else
                {
                    //carga la lista completa
                    cargarLista(listainve);
                }
            }
            else if (busqueda == 2)
            {
                if ((int)cboCategoriaProducto.SelectedValue != -1)
                {

                    foreach (tbInventario p in listainve)
                    {
                        if (p.tbProducto.id_categoria == codigo)
                        {

                            listaBuscar.Add(p);
                        }

                    }
                    cargarLista(listaBuscar);
                }
                else
                {
                    //carga la lista completa
                    cargarLista(listainve);
                }


            }
            else {
                if (txtCodigo.Text != string.Empty)
                {

                    foreach (tbInventario p in listainve)
                    {
                        if (p.tbProducto.idProducto.Trim().ToUpper().Contains( txtCodigo.Text.ToUpper().Trim()))
                        {

                            listaBuscar.Add(p);
                        }

                    }
                    cargarLista(listaBuscar);
                }
                else
                {
                    //carga la lista completa
                    cargarLista(listainve);
                }


            }

           


        }

        private void gbxInventario_Enter(object sender, EventArgs e)
        {

        }
        private void ltvCargar_SelectedIndex(object sender, MouseEventArgs e)
        {

            string idProd = string.Empty;

      
            if (ltvCargar.SelectedItems.Count > 0)
            {
                ListViewItem listItem = ltvCargar.SelectedItems[0];

                idProd = listItem.Text;
                
            }

            foreach (tbInventario item in listainve)
            {
                if (item.idProducto==idProd)
                {

                    inventarioGlo = item;
                    break;
                }

            }
            if (inventarioGlo != null)
            {

                frmModificarInventario cargar = new frmModificarInventario();
                cargar.inventarioGlobal = inventarioGlo;
                cargar.pasarDatosEvent += datosBuscar;
                cargar.ShowDialog();

            }


            //cargarLista(listainve);


            //ss
        }

        private void datosBuscar(tbInventario inventario)
        {

            listainve.Remove(inventarioGlo);
            listainve.Add(inventario);
            cargarLista(listainve);
            banderalis = 1;

        }
        private void Click_Cambiar(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
           // txtBuscar.Text = "Buscar Producto...";

        }

        private void cboCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategoriaProducto.SelectedValue!=null)
            {
                int categoriaBuscar = (int)cboCategoriaProducto.SelectedValue;

                buscar(categoriaBuscar,2);

            }
  



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar por Nombre...";
            cboCategoriaProducto.SelectedIndex = -1;
            buscar(-1,3);
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
        }
    }
}

