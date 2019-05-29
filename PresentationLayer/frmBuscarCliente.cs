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
using CommonLayer.Exceptions.DataExceptions;

namespace PresentationLayer
{

    public partial class FrmBuscar : Form
    {

        Bcliente clienteIns = new Bcliente();
        public static List<tbClientes> listaclientes = new List<tbClientes>();
        public static tbClientes clienteGlo = new tbClientes();

        public delegate void pasaDatos(tbClientes entity);
        public event pasaDatos pasarDatosEvent;


      bool  bandSeleccionar = false;

        public FrmBuscar()
        {
            InitializeComponent();
        }
        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            clienteGlo = null;

             listaclientes = clienteIns.GetListEntities((int)Enums.EstadoBusqueda.Activo);
        
            cargarLista(listaclientes);
        }
        public void cargarLista(List<tbClientes> lista)
        {
            try
            {
                lsvbuscar.Items.Clear();
                   foreach (tbClientes p in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.id.ToString().Trim();
                    item.SubItems.Add(p.tbTipoClientes.nombre.ToString().Trim());
                    if (p.tipoId==1)
                    {

                        item.SubItems.Add(p.tbPersona.nombre.Trim() + " " + p.tbPersona.apellido1.Trim() + " " + p.tbPersona.apellido2.Trim());

                    }
                    else
                    {
                        item.SubItems.Add(p.tbPersona.nombre.Trim());
                    }
                   // item.SubItems.Add(p.tbPersona.nombre.Trim());

                    if (p.estado == true)
                    {
                        item.SubItems.Add("ACTIVO");
                    }
                    else
                    {
                        item.SubItems.Add("INACTIVO");
                    }



                    lsvbuscar.Items.Add(item);

                }
            }
            catch (ListEntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            pasarDatosEvent(clienteGlo);
            this.Dispose();
            bandSeleccionar = true;
        }

        private void lsvbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (lsvbuscar.SelectedItems.Count > 0)
                {
                    string idSelected = lsvbuscar.SelectedItems[0].Text;
                    foreach (tbClientes busCliente in listaclientes)
                    {
                        if (idSelected == busCliente.id.Trim())
                        {
                            clienteGlo = busCliente;
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


        private void lsvBuscar_DoubleClick(object sender, EventArgs e)
        {
            pasarDatosEvent(clienteGlo);
            this.Dispose();
            bandSeleccionar = true;
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            ListaCoincid();
        }
        private void ListaCoincid()
        {
            List<tbClientes> listaBuscar = new List<tbClientes>();
            string nombre="";

            if (txtBuscar.Text.Trim() != string.Empty)
            {

                foreach (tbClientes p in listaclientes)
                {
                    nombre = p.tbPersona.nombre.Trim() + " " + p.tbPersona.apellido1.Trim() + " " + p.tbPersona.apellido2.Trim();

                    if (nombre.Contains(txtBuscar.Text.ToUpper().Trim()))
                    {

                        listaBuscar.Add(p);
                    }

                }
                cargarLista(listaBuscar);
            }else {
                cargarLista(listaclientes);
            }
            
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
           
            if (!bandSeleccionar)
            {
                clienteGlo = null;
                pasarDatosEvent(clienteGlo);
            }
        }

        
    }
}
