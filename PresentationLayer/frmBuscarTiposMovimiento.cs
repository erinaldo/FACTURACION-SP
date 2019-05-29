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
    public partial class frmBuscarTiposMovimiento : Form
    {
        bool banderaSeleccionar;
        BTipoMovimiento bTipoMovimientoIns = new BTipoMovimiento();
        List<tbTipoMovimiento> listaMovimiento = new List<tbTipoMovimiento>();
        public static tbTipoMovimiento puestoGlo = new tbTipoMovimiento();

        //delegado
        public delegate bool pasarDatos(tbTipoMovimiento entity);//aquí hago el delegado

        //evento
        public event pasarDatos pasarDatosEvent;// este evento es en pasarDatos porque el apuntador lo esta permitiendo

        public frmBuscarTiposMovimiento()
        {
            InitializeComponent();
        }

        private void frmBuscarTiposMovimiento_Load(object sender, EventArgs e)
        {
            try
            {
                listaMovimiento = bTipoMovimientoIns.getListTipoMovimiento((int)Enums.EstadoBusqueda.Activo);
                cargarLista(listaMovimiento);
            }
            catch (EntityException ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        public void cargarLista(List<tbTipoMovimiento> lista)
        {



            try
            {
                lstvMovimientos.Items.Clear();
                foreach (tbTipoMovimiento p in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.idTipo.ToString();
                    item.SubItems.Add(p.nombre);

                    if (p.estado)
                    {

                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");

                    }
                    lstvMovimientos.Items.Add(item);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(puestoGlo);
            this.Dispose();
        }

        private void lstvMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstvMovimientos.SelectedItems.Count > 0)
            {

                string idSelected = lstvMovimientos.SelectedItems[0].Text;



                foreach (tbTipoMovimiento movimiento in listaMovimiento)
                {

                    if (int.Parse(idSelected) == movimiento.idTipo)
                    {
                        puestoGlo = movimiento;
                    }
                }
            }
        }

        private void lstvMovimientos_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()//busca lo que este en el listview de frmBuscar
        {
            List<tbTipoMovimiento> listaBuscar = new List<tbTipoMovimiento>();
            if (txtBuscar.Text.ToUpper().Trim() != string.Empty)
            {

                foreach (tbTipoMovimiento p in listaMovimiento)
                {
                    if (p.nombre.Contains(txtBuscar.Text.ToUpper().Trim()))//si p.nombre que está en la tabla contiene lo mismo que se escribe en el buscar
                    {

                        listaBuscar.Add(p);
                    }

                }
                cargarLista(listaBuscar);
            }
            else
            {
                
                cargarLista(listaMovimiento);
            }
        }

        private void txtBuscar_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void lstv_Tipo_Movimiento_Selected_DoubleClick(object sender, MouseEventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(puestoGlo);
            this.Dispose();
        }

        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (!banderaSeleccionar)
            {
                puestoGlo = null;
                pasarDatosEvent(puestoGlo);
            }
           
        }
    }
  
}


