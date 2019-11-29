using BusinessLayer;
using CommonLayer;
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
    public partial class frmActividadEconomicaCombo : Form
    {
        BActividadesEconomicas actINs = new BActividadesEconomicas();
 
        public List<tbEmpresaActividades> listaAct { get; set; }
        public frmActividadEconomicaCombo()
        {
            InitializeComponent();
        }

        private void frmActividadEconomicaCombo_Load(object sender, EventArgs e)
        {
            listaAct = actINs.getListaEmpresaActividad(Global.Usuario.idEmpresa, (int)Global.Usuario.idTipoIdEmpresa);

            cargarDatos();
        }

        private void cargarDatos()
        {
                if (listaAct.Count==0)
            {
                //MessageBox.Show();
            }
            else if(listaAct.Count == 1)
            {

            }
            else
            {
                cboEmpresa.DisplayMember = "nombreComercial";
                cboEmpresa.ValueMember = "CodActividad";
                cboEmpresa.DataSource = listaAct;

            }
        
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cboEmpresa.Text==string.Empty)
            {
                MessageBox.Show("Debe indicar una empresa");
            }
            else
            {
                //DialogResult result = MessageBox.Show("¿Desea cambiar la actividad económica?","Cambiar Actividad Económica", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (result== DialogResult.Yes)
                //{
                    Global.actividadEconomic = listaAct.Where(x => x.CodActividad.Trim() == cboEmpresa.SelectedValue.ToString().Trim()).SingleOrDefault();
                    this.Close();
                //}
         
            }
        }

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEmpresa.Text = cboEmpresa.Text.Trim();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
