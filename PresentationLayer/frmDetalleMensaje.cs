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
    public partial class frmDetalleMensaje : Form
    {
       private tbReporteHacienda reporte;
        public frmDetalleMensaje()
        {
            InitializeComponent();
        }

        public tbReporteHacienda Reporte { get => reporte; set => reporte = value; }

        private void frmDetalleMensaje_Load(object sender, EventArgs e)
        {
            txtCorreo.Text = reporte.correoElectronico.Trim();
            txtNombre.Text = reporte.nombreEmisor.Trim();

            txtFecha.Text = reporte.fechaEmision.ToString().Trim();
            txtClaveEmisor.Text = reporte.claveDocEmisor.Trim();
            txtConsecutivoEmisor.Text = reporte.claveDocEmisor.Substring(31, 10).Trim();

            txtTotal.Text = reporte.totalFactura.ToString().Trim();
            txtImp.Text = reporte.totalImp.ToString().Trim();
            txtArchivo.Text = reporte.nombreArchivo.Trim();

            txtClaveReceptor.Text = reporte.claveReceptor;
            txtConseReceptor.Text = reporte.consecutivoReceptor;
            txtIdReceptor.Text = reporte.id.ToString().Trim();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
