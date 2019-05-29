using CommonLayer;
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

namespace PresentationLayer
{
    public partial class frmBuscarUsuario : Form
    {
        BUsuario usuarioIns = new BUsuario();
        List<tbUsuarios> listaUsuario = new List<tbUsuarios>();
        tbUsuarios usuarioGlo = new tbUsuarios();
        bool banderaSeleccionar = false;
        //public static tbPersona personaGlo = new tbPersona();

                

        //delegado / puntero
        public delegate void pasarDatos(tbUsuarios entity);

        public event pasarDatos pasarDatosEvent;
        //evento



        public frmBuscarUsuario()
        {
            InitializeComponent();
        }


        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {
            listaUsuario = usuarioIns.getListUsuario((int)Enums.EstadoBusqueda.Todos);
            cargarLista1(listaUsuario);
            btnSelect.Enabled = false;
        }
        
        //Carga los datos de usuario en la entidad "lista"        
        public void cargarLista1(List<tbUsuarios> lista)
        {

                lstvBuscar.Items.Clear();

                foreach (tbUsuarios u in lista)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = u.id.ToString();
                    item.SubItems.Add(u.nombreUsuario.ToString().ToUpper());
                    item.SubItems.Add(u.idRol.ToString());

                    if (u.estado == true)
                    {
                        item.SubItems.Add("activo");
                    }
                    else
                    {
                        item.SubItems.Add("inactivo");
                    }

                    lstvBuscar.Items.Add(item);
                }


            }
           
        private void button1_Click(object sender, EventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(usuarioGlo);
            this.Dispose();
        }

        /// <summary>
        /// Ubica los valores dependiendo de la celda seleccionada en el listview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltvBuscar_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (lstvBuscar.SelectedItems.Count > 0)
            {
                string Selected = lstvBuscar.SelectedItems[0].SubItems[1].Text.Trim();
                foreach (tbUsuarios nombreuser in listaUsuario)
                {
                    if (Selected == nombreuser.nombreUsuario.ToUpper().Trim())
                    {
                        usuarioGlo = nombreuser;
                        btnSelect.Enabled = true;
                        break;
                    }
                    
                }
              
            }

        }

        //Metodo necesario para buscar los datos del listview mediante el textbox
        private void buscar()
        {
            List<tbUsuarios> listaBuscar = new List<tbUsuarios>();
            
            if (txtBuscar.Text.Trim() != string.Empty)
            {
                txtBuscar.CharacterCasing = CharacterCasing.Upper;
                foreach (tbUsuarios u in listaUsuario)
                {
                    if (u.nombreUsuario.Contains(txtBuscar.Text.Trim()))
                    {

                        listaBuscar.Add(u);
                    }

                }
                cargarLista1(listaBuscar);
            }
            else
            {
                //carga la lista completa
                cargarLista1(listaUsuario);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void ltvBuscar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            banderaSeleccionar = true;
            pasarDatosEvent(usuarioGlo);
            this.Dispose();
        }

        private void cerrarFormBuscar(object sender, FormClosedEventArgs e)
        {
            if(!banderaSeleccionar == true)
            {
                usuarioGlo = null;
                banderaSeleccionar = true;
                pasarDatosEvent(usuarioGlo); 
            }
        }
    }
}
