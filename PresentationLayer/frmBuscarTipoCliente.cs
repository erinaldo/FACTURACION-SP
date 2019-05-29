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
using CommonLayer;
using EntityLayer;
using DataLayer;


namespace PresentationLayer
{
    public partial class frmBuscarTipoCliente : Form
    {

        List<tbTipoClientes> listaTipoCliente = new List<tbTipoClientes>();

        BTipoCliente tipoCLienteIns = new BTipoCliente();
        
        
            
         tbTipoClientes tipoClienteGlo = new tbTipoClientes();

        public delegate void buscarDatos(tbTipoClientes cliente);
        public event buscarDatos buscarDatosEvent;
        bool banderaSeleccionar = false;
        public frmBuscarTipoCliente()
        {
            InitializeComponent();
        }

        private void BuscarTipoCliente_Load(object sender, EventArgs e)
        {
            try
            {

                listaTipoCliente = tipoCLienteIns.GetListEntities((int)Enums.EstadoBusqueda.Todos);
                cargarLista(listaTipoCliente);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void cargarLista(List<tbTipoClientes> lista)
        {
            try
            {
                lstvTipoCliente.Items.Clear();
                foreach (tbTipoClientes p in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.id.ToString();
                    item.SubItems.Add(p.nombre);

                    if (p.estado == true)
                    {

                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");

                    }
                    lstvTipoCliente.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

          

        }


        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            buscarDatosEvent(tipoClienteGlo);
            this.Dispose();
        }
         private void lstvTipoCliente_DoubleClickMouse(object sender, MouseEventArgs e)
        {
            banderaSeleccionar = true;
            buscarDatosEvent(tipoClienteGlo);
            this.Dispose();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            List<tbTipoClientes> listaBuscar = new List<tbTipoClientes>();
            if (txtBuscar.Text.Trim() != string.Empty)
            {
                foreach (tbTipoClientes p in listaTipoCliente)
                {
                    if (p.nombre.ToUpper().Trim().Contains(txtBuscar.Text.ToUpper().Trim()))
                    {
                        listaBuscar.Add(p);
                    }
                    cargarLista(listaBuscar);
                }
            }

            else
            {
                cargarLista(listaTipoCliente);
            }

        }
        

        private void lstvTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (lstvTipoCliente.SelectedItems.Count > 0)
            {
                string idselected = lstvTipoCliente.SelectedItems[0].Text;

                foreach (tbTipoClientes tipo in listaTipoCliente)
                {
                    if (int.Parse(idselected) == tipo.id)
                    {
                        tipoClienteGlo = tipo;
                    }
                }
            }
        }
   

       

        private void cerrarform(object sender, FormClosedEventArgs e)
        {
            //!bandSeleccionar es para que sea lo contrario a lo que tenga la bandera 
            if (banderaSeleccionar==false)
            {
                tipoClienteGlo = null;
                buscarDatosEvent(tipoClienteGlo);
            }
           
        }
    }
}
