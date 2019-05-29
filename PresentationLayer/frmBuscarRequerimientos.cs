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
    public partial class frmBuscarRequerimientos : Form
    {

        tbRequerimientos RequeriGlo = new tbRequerimientos();
      
        List<tbRequerimientos> listaRequeri = new List<tbRequerimientos>();
        public BRequerimientos proveedorIns = new BRequerimientos();
        bool banderaSeleccionar = false;


        //puntero o delegado
        public delegate void pasarDatos(tbRequerimientos entity);

        //evento
        public event pasarDatos pasarDatosEvent;
        public frmBuscarRequerimientos()
        {
            InitializeComponent();
        }

        private void frmBuscarRequerimientos_Load(object sender, EventArgs e)
        {
            listaRequeri = proveedorIns.GetListEntities((int)Enums.EstadoBusqueda.Todos);

            cargarLista1(listaRequeri);

        }

   

   

        public void cargarLista1(List<tbRequerimientos> lista)
        {
            lsvtBuscarRequeri.Items.Clear();

          
            foreach (tbRequerimientos p in lista)
            {
                ListViewItem item = new ListViewItem();
                item.Text         = p.idReq.ToString();
                item.SubItems.Add(p.nombre);

                if (p.estado == true)
                {
                    item.SubItems.Add("Activo");
                }
                else
                {
                    item.SubItems.Add("Inactivo");
                }
                lsvtBuscarRequeri.Items.Add(item);
            }
        }


        private void lsvtRequerimientos(object sender, MouseEventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(RequeriGlo);
            this.Dispose();
        }

        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            if (!banderaSeleccionar == true)
            {
                RequeriGlo = null;
                pasarDatosEvent(RequeriGlo);
            }
        }

        private void lsvtBuscarRequeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvtBuscarRequeri.SelectedItems.Count > 0)
            {
                string Selected = lsvtBuscarRequeri.SelectedItems[0].Text;
                foreach (tbRequerimientos nombrepro in listaRequeri)
                {
                    if (Selected == nombrepro.idReq.ToString())
                    {
                        RequeriGlo = nombrepro;
                        btnSeleccionar.Enabled = true;
                        break;
                        
                    }
                }
            }
        }

        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(RequeriGlo);
            this.Dispose();
        }

        private void lsvtBuscarRequerimientos(object sender, MouseEventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(RequeriGlo);
            this.Dispose();
        }


        private void buscar()
        {
            List<tbRequerimientos> listaBuscar = new List<tbRequerimientos>();
            
            if (txtBuscar.Text.Trim() != string.Empty)
            {
                txtBuscar.CharacterCasing = CharacterCasing.Upper;
                //CharacterCasing es para que al digitar en un  txt sea en mayúscula
                foreach (tbRequerimientos r in listaRequeri)
                {
                    if (r.nombre.Contains(txtBuscar.Text.Trim()))
                    {

                        listaBuscar.Add(r);
                    }

                }
                cargarLista1(listaBuscar);
            }
            else
            {
                //carga la lista completa
                cargarLista1(listaRequeri);
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
    

