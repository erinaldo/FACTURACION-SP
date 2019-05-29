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
    public partial class frmRazon : Form
    {

        public delegate void pasaDatos(string razon);
        public event pasaDatos pasarDatosEvent;

        public frmRazon()
        {
            InitializeComponent();
        }

        private void frmRazon_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRazon.Text!=string.Empty)
            {
                pasarDatosEvent(txtRazon.Text.ToUpper());
                this.Close();
            }
            else{
                MessageBox.Show("Debe indicar obligatoriamente una razón de la nota de crédito", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
