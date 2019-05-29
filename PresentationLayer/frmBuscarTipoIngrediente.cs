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
    public partial class frmBuscarTipoIngrediente : Form
    {
        List<tbTipoIngrediente> listaTipoIng = new List<tbTipoIngrediente>();
        tbTipoIngrediente TipInGlobal = new tbTipoIngrediente();
        BTipoIngrediente tipoBIns = new BTipoIngrediente();
        bool banderaSeleccionar = false;

        //creo mi delegado
        public delegate void pasaDatos(tbTipoIngrediente entity);

        //evento
        public event pasaDatos pasarDatosEvent;

        public frmBuscarTipoIngrediente()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // this.Close();
            banderaSeleccionar = true;
            pasarDatosEvent(TipInGlobal);//llamar al evento 
            this.Dispose();
        
        }

        private void frmBuscarTipoIngrediente_Load(object sender, EventArgs e)
        {
            try
            {
                listaTipoIng = tipoBIns.getListTipoing((int)Enums.EstadoBusqueda.Todos);
                cargarLista(listaTipoIng);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void cargarLista (List<tbTipoIngrediente> lista)
        {



            try
            {
                lstvTipoIngred.Items.Clear();
                foreach (tbTipoIngrediente tipIn in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = tipIn.id.ToString();
                    item.SubItems.Add(tipIn.nombre);

                    if (tipIn.estado)
                    {

                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");

                    }
                    lstvTipoIngred.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void lstvTipoIngred_SelectedIndexChanged(object sender, EventArgs e)//cuando selecciono un index diferente
        {
            if (lstvTipoIngred.SelectedItems.Count > 0)
            {

                string idSelected = lstvTipoIngred.SelectedItems[0].Text;



                foreach (tbTipoIngrediente tipoIngrediente in listaTipoIng)
                {

                    if (int.Parse(idSelected) == tipoIngrediente.id)
                    {
                        TipInGlobal = tipoIngrediente;
                    }
                }
            }
        }

        private void lstvTipoIngred_DoubleClick(object sender, MouseEventArgs e)
        {
            // this.Close();
            banderaSeleccionar = true;
            this.Dispose();
            pasarDatosEvent(TipInGlobal);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }


        private void buscar()
        {
            List<tbTipoIngrediente> listaBuscar = new List<tbTipoIngrediente>();
            
            if (txtBuscar.Text.Trim() != string.Empty)
            {

                foreach (tbTipoIngrediente tipIn in listaTipoIng)
                {
                    if (tipIn.nombre.Contains(txtBuscar.Text.ToUpper().Trim()))
                    {

                        listaBuscar.Add(tipIn);
                    }

                }
                cargarLista(listaBuscar);
            }
            else
            {
                
                cargarLista(listaTipoIng);
            }

        }

        private void cerrarForm(object sender, FormClosedEventArgs e)
        {
            if (!banderaSeleccionar)
            {
                TipInGlobal = null;
                pasarDatosEvent(TipInGlobal);
            }

        }
    }
}
