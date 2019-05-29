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
    public partial class frmBuscarRoles : Form
    {
        private List<tbRoles> listaROLES = new List<tbRoles>();//LISTA PARA CARGAR LOS ROLES

        tbRoles rolesGLOBAL = new tbRoles();// VARIABLE GLOBAL PARA ASIGNARLE LA ENTIDAD SELECCIONADA

        bool bandera = false;//LA BANDERA ES PARA QUE SEGUN EL EVENTO QUE SE EJECUTE;..LA BANDERA TENDRA
                             // UN ESTADO Y SEGUN ESE ESTADO EL EVENTO REALIZARA SIERTAS ACCIONES

        public delegate void pasarDatos(tbRoles roles);//DELEGADO

        public event pasarDatos pasarDatosEvent;//EVENTO

        BRoles BrolesINS = new BRoles();//INSTACIA A  LA CAPA B ROLES
        public frmBuscarRoles()
        {
            InitializeComponent();
        }

        private void frmBuscarRoles_Load(object sender, EventArgs e)
        {
            listaROLES =BrolesINS.GetListEntity((int)Enums.EstadoBusqueda.Todos);
            cargarRoles(listaROLES);
        }

        private void cargarRoles(List<tbRoles> requerimientos)
        {
            lstvRolesAlmacenados.Items.Clear();
            foreach (tbRoles R in requerimientos)
            {
                ListViewItem item = new ListViewItem();
                item.Text = R.idRol.ToString();
                item.SubItems.Add(R.nombre);

                if (R.estado == true)
                {
                    item.SubItems.Add("Activo");
                }
                else
                {
                    item.SubItems.Add("Inactivo");
                }

                lstvRolesAlmacenados.Items.Add(item);

            }
        }

        private void lstvRolesAlmacenados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvRolesAlmacenados.SelectedItems.Count > 0)
            {
                string idSelec = lstvRolesAlmacenados.SelectedItems[0].Text;

                foreach (tbRoles ROL in listaROLES)
                {
                    if (int.Parse(idSelec) == ROL.idRol)
                    {
                       

                        rolesGLOBAL = ROL;
                    }
                }
            }
        }

        private void buscarROL()
        {
            List<tbRoles> ListaBusquedaRol = new List<tbRoles>();

            try
            {
                if (txtBuscarRol.Text.Trim() != string.Empty)
                {
                    foreach (tbRoles rol in listaROLES)
                    {
                        if (rol.nombre.Contains(txtBuscarRol.Text.ToUpper().Trim()))
                        {
                            ListaBusquedaRol.Add(rol);
                        }
                    }
                    cargarRoles(ListaBusquedaRol);
                }
                else
                {
                    cargarRoles(listaROLES);
                }
            } 
            catch (Exception ex)
            {

                throw;
            }
        
        }

        private void txtBuscarRol_TextChanged(object sender, EventArgs e)
        {
            buscarROL();
        }

       

       
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            bandera = true;
            pasarDatosEvent(rolesGLOBAL);
            this.Dispose();
        }

        private void frmBuscarRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bandera==false)
            {
                rolesGLOBAL = null;
                pasarDatosEvent(rolesGLOBAL);
            }

        }

        private void lstvRolesAlmacenados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bandera = true;
            pasarDatosEvent(rolesGLOBAL);
            this.Dispose();
        }
    }
}
