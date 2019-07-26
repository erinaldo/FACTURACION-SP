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
    public partial class frmAliasMesa : Form
    {
        public delegate void pasaDatos(string alias);
        public event pasaDatos pasarDatosEvent;

        public string alias { get; set; }
        public frmAliasMesa()
        {
            InitializeComponent();
        }

        private void frmAliasMesa_Load(object sender, EventArgs e)
        {
            txtAliasMesa.Focus();
        }

        private void txtAliasMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                aceptar();
            }
        }

        private void aceptar()
        {

            if (txtAliasMesa.Text!=string.Empty)
            {
                alias = txtAliasMesa.Text.ToUpper();
                pasarDatosEvent(alias);
                this.Close();

            }
            else
            {
                MessageBox.Show("Cantidad incorrecta, verifique", "Error cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pasarDatosEvent(null);
            this.Close();
        }
    }
}
