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

namespace PresentationLayer
{
    public partial class frmBuscarMovimiento : Form
    {
        BMovimiento BMovimientosIns = new BMovimiento();//Instancia para consultar y acceder a los movimientos almacenados

        List<tbMovimientos> listaMovimiento = new List<tbMovimientos>();//Variable tipo lista que resive los movimientos almacenados

        private  tbMovimientos MovimientoGlobal = new tbMovimientos();//Bariable gloBal que almacena el movimiento que selecciono y deseo cargar en mi form padre

        bool banderaSeleccionar = false;//Si selecciono un elemento me cargue la variable global con la entidad seleccionada y sino entonces ciemrro el form y la variable global queda vacia

        //generar tanto delagodo 
        public delegate void pasarDatos(tbMovimientos entity);

        //generar evento
        public event pasarDatos pasarDatosEvent;

        public frmBuscarMovimiento()
        {
            InitializeComponent();
        }


       //Metodo para obtener los  elementos de la lista activos
        private void frmBuscarMovimiento_Load(object sender, EventArgs e)
        {
            try
            {

                listaMovimiento = BMovimientosIns.getListMovimiento((int)Enums.EstadoBusqueda.Activo);
                cargarListaMov(listaMovimiento);
            }
            catch (Exception  ex)
            {

                MessageBox.Show("No se pudo obtener los movimientos");
            }
        }



        //Metodo para cargar la lista con los elementos obtenidos de la lista movimiento

        private void cargarListaMov(List<tbMovimientos> listaMov)
        {
            try
            {
                lstvMovimientos.Items.Clear();
                foreach (tbMovimientos p in listaMov)
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = p.idMovimiento.ToString();

                    item.SubItems.Add(p.tbTipoMovimiento.nombre.ToString());

                    item.SubItems.Add(p.motivo);
                    //  item.SubItems.Add(p.tbDetalleMovimiento.)

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
            catch (Exception ex)
            {

              MessageBox.Show(ex.Message)  ;
            }
          }
        
        //Buscar elementos de la lista
        private void buscar()
        {
            try
            {
                List<tbMovimientos> listaBuscarMov = new List<tbMovimientos>();

                if (txtBuscarMovimiento.Text.Trim() != string.Empty)
                {
                    foreach (tbMovimientos p in listaMovimiento)
                    {
                        if (p.idMovimiento.ToString().Contains(txtBuscarMovimiento.Text.ToUpper().Trim().ToString()))
                        {
                            listaBuscarMov.Add(p);
                        }
                    }
                    cargarListaMov(listaBuscarMov);//Cargo este metodo con la lista que obtengo a travez de la busqueda
                }
                else
                {
                    cargarListaMov(listaMovimiento);//Sino Cargo el metodo con la lista completa  de la TABLA
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        //Dentro del listview de buscar Movimiento

        private void lstvMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstvMovimientos.SelectedItems.Count > 0)
                {
                    string idSelected = lstvMovimientos.SelectedItems[0].Text;

                    foreach (tbMovimientos movimiento in listaMovimiento)
                    {
                        if (int.Parse(idSelected) == movimiento.idMovimiento)
                        {
                            MovimientoGlobal = movimiento;


                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
       //TexBox para buscar el movimiento 
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(MovimientoGlobal);
            this.Dispose();
        }

        private void lstvMovimientos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(MovimientoGlobal);
            this.Dispose();
        }

        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            if (banderaSeleccionar ==false)
            {
                MovimientoGlobal = null;
                pasarDatosEvent(MovimientoGlobal);
            }
        }

        private void gbxMovimientos_Enter(object sender, EventArgs e)
        {

        }
    }
}
