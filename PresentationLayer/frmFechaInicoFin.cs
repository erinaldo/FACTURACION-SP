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
    public partial class frmFechaInicoFin : Form
    {
        public delegate void pasaDatos(DateTime fechaInicio, DateTime fechaFin);
        public event pasaDatos pasarDatosEvent;

        public frmFechaInicoFin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pasarDatosEvent(DateTime.MinValue, DateTime.MinValue);
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                pasarDatosEvent(dtpInicio.Value, dtpFin.Value);
                this.Close();

            }
        }

        private bool validar()
        {
            if (dtpFin.Value.Date<dtpInicio.Value.Date)
            {
                MessageBox.Show("La fecha de inicio es mayor que la fecha fin.","Faltan datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
    }
}
