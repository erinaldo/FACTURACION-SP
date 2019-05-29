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
using CommonLayer.Exceptions.DataExceptions;


namespace PresentationLayer
{
    
    public partial class frmBuscarEmpleado : Form
    {
        BEmpleado empleadpIns = new BEmpleado();
        tbEmpleado empleadoGlo = new tbEmpleado();
        List<tbEmpleado> listaEmpleado = new List<tbEmpleado>();
        //delegado donde se va a genera el evento
       public delegate void pasarDatos(tbEmpleado entity);
        bool banderaSelecciona = false;
        // evento
        public event pasarDatos pasarDatosEvent;
        public frmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            listaEmpleado = empleadpIns.GetListEntities((int)Enums.EstadoBusqueda.Activo);
            cargarLista(listaEmpleado);
        }

        public void cargarLista(List<tbEmpleado> lista)
        {
            try
            {

                lstvEmpleados.Items.Clear();
                foreach (tbEmpleado e in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = e.id.ToString().Trim();
                    item.SubItems.Add(e.tbPersona.nombre.ToUpper().Trim());

                    if (e.estado)
                    {

                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");

                    }
                    lstvEmpleados.Items.Add(item);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvEmpleados.SelectedItems.Count > 0)
            {
                string idSelected = lstvEmpleados.SelectedItems[0].Text;
                foreach (tbEmpleado tipoEmpleado in listaEmpleado)
                {
                    if (int.Parse(idSelected) == int.Parse(tipoEmpleado.id))
                    {
                        empleadoGlo = tipoEmpleado;
                    }
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            banderaSelecciona = true;
            pasarDatosEvent(empleadoGlo);
            this.Dispose();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            List<tbEmpleado> listaBuscar = new List<tbEmpleado>();
           
            
            if (txtbuscar.Text.Trim() != string.Empty)
            {
                txtbuscar.CharacterCasing = CharacterCasing.Upper;//para escribir los datos en mayuscula
                foreach (tbEmpleado e in listaEmpleado)
                {
                    if (e.tbPersona.nombre.ToUpper().Contains(txtbuscar.Text.ToUpper().Trim()))
                    {

                        listaBuscar.Add(e);
                    }

                }
                cargarLista(listaBuscar);
            }
            else
            {

                cargarLista(listaEmpleado);
            }

        }

        private void lstvEmpleados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            banderaSelecciona = true;
            pasarDatosEvent(empleadoGlo);
            // livera los espacios en memoria
            this.Dispose();
        }

        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            if (!banderaSelecciona)
            {
                empleadoGlo = null;
                pasarDatosEvent(empleadoGlo);
            }
        }
    }
}
