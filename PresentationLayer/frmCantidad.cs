using CommonLayer;
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
    public partial class frmCantidad : Form
    {

        public delegate void pasaDatos(decimal peso);
        public event pasaDatos pasarDatosEvent;

        public decimal peso { get; set; }
        public frmCantidad()
        {
            InitializeComponent();
        }

        private void frmCantidad_Load(object sender, EventArgs e)
        {
            txtCantidad.Focus();
        }





        private void aceptar()
        {

            if (Utility.isNumeroDecimal(txtCantidad.Text) )
            {
                peso = decimal.Parse(txtCantidad.Text);
                pasarDatosEvent(peso);
                this.Close();

            }
            else
            {
                MessageBox.Show("Cantidad incorrecta, verifique","Error cantidad",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                aceptar();
            }
        }
    }
}
