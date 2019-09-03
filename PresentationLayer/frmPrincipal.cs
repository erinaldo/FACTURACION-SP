using BusinessLayer;
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
    public partial class frmPrincipal : Form
    {
        
        bool cerrando = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarLogeo();
        }

        private void cargarLogeo()
        {
            frmLogin login = new frmLogin();
            login.cerrarFact += cerrarForm;     
            login.ShowDialog();

        }

        private void cerrarForm()
        {
            cerrando = true;
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrando)
            {
                BPendientes pendientesIns = new BPendientes();
                int cantidadPend = pendientesIns.CantidadPendientes();

                if (cantidadPend!=0)
                {
                    DialogResult result = MessageBox.Show("Existen Pendientes, desea eliminarlos?", "Pendientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        pendientesIns.removeAll();
                        MessageBox.Show("Se ha eliminado los pendientes", "Pendientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                

                DialogResult dialog = MessageBox.Show("Esta seguro que desea cerra la Aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.No)
                {

                    e.Cancel = true;

                }
            }
         
        }
        
        private void OpcionMenu_Click(object sender, EventArgs e)
        {
            
            if (((ToolStripMenuItem)sender).Name == "mnuProductos")
            {
                frmProductos2 frm = new frmProductos2();
               // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuCategoriaProductos")
            {
                frmCategoriaProducto frm = new frmCategoriaProducto();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }


            else if (((ToolStripMenuItem)sender).Name == "mnuMedidasProductos")
            {
                frmTipoMedida frm = new frmTipoMedida();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuClientes")
            {
                frmClientes frm = new frmClientes();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuTipoClientes")
            {
                frmTipoCliente frm = new frmTipoCliente();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuProveedores")
            {
                frmProveedores2 frm = new frmProveedores2();
                // frm.MdiParent = this;
                frm.Show();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuEmpleados")
            {
                frmEmpleado frm = new frmEmpleado();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuIngredientes")
            {
                frmIngredientes frm = new frmIngredientes();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuTipoIngredientes")
            {
                frmTipoIngrediente frm = new frmTipoIngrediente();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuMonedas")
            {
                frmMoneda frm = new frmMoneda();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuTipoMonedas")
            {
                frmMoneda2 frm = new frmMoneda2();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuPuestos")
            {
                frmPuestos frm = new frmPuestos();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
           else if (((ToolStripMenuItem)sender).Name == "mnuCajas")
            {
                frmCajas frm = new frmCajas();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuTipoMovimientos")
            {
                frmTiposMovimiento frm = new frmTiposMovimiento();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuFacturacion")
            {
                frmFacturacion1 frm = new frmFacturacion1();
                frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuInventario")
            {
                frmInventario frm = new frmInventario();
                // frm.MdiParent = this;
                frm.Show();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuModificarInventario")
            {
                frmModificarInventario frm = new frmModificarInventario();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuConsultaFactElecClave")
            {
                frmConsultaFacturaElectronica frm = new frmConsultaFacturaElectronica();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuValidacionHacienda")
            {
                frmValidacionDocsHacienda frm = new frmValidacionDocsHacienda();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuParametrosSistema")
            {
                frmParametrosEmpresa frm = new frmParametrosEmpresa();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuDocumentosEmitidos")
            {
                frmBuscarDocumentos frm = new frmBuscarDocumentos();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuAcercaDe")
            {
                Acerca frm = new Acerca();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuConsultarFacHac")
            {
                frmConsultaFacturaElectronica frm = new frmConsultaFacturaElectronica();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuReporteHacienda")
            {
                frmMensajesHacienda frm = new frmMensajesHacienda();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuConsultaMensajes")
            {
                frmConsultasMensajesHacienda frm = new frmConsultasMensajesHacienda();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuValidarMensajes")
            {
                frmValidacionDocsHacienda frm = new frmValidacionDocsHacienda();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuAbonos")
            {
                frmAbonoCredito frm = new frmAbonoCredito();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuUsuarios")
            {
                frmUsuario frm = new frmUsuario();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuEmpresa")
            {
                frmEmpresa frm = new frmEmpresa();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuCambiarContrasena")
            {
                frmCambiarContrasena frm = new frmCambiarContrasena();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuParametros")
            {
                frmParametrosEmpresa frm = new frmParametrosEmpresa();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuCompras")
            {
                frmCompras frm = new frmCompras();
                // frm.MdiParent = this;
                frm.ShowDialog();

            }





        }



        private void ReporteMenu_Click(object sender, EventArgs e)
        {
            int reporte = 0;
            if (((ToolStripMenuItem)sender).Name == "mnuInventarioGeneral")
            {
                reporte = (int)Enums.reportes.inventarioGeneral;

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuInventarioBajo")
            {

                reporte = (int)Enums.reportes.inventarioBajo;
            }

            else if (((ToolStripMenuItem)sender).Name == "mnuInventarioSobre")
            {
                reporte = (int)Enums.reportes.inventarioSobre;

            }

            else if (((ToolStripMenuItem)sender).Name == "mnuGeneralByCat")
            {
                reporte = (int)Enums.reportes.inventarioCategoria;

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuRptGeneralVenta")
            {
                reporte = (int)Enums.reportes.reporteGeneralVenta;

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuReporteFechaIncioFin")
            {
                reporte = (int)Enums.reportes.ventasFechaInicioFin;

            }
            else if (((ToolStripMenuItem)sender).Name == "mnuNotasCreditoFechas")
            {
                reporte = (int)Enums.reportes.notasCreditoFechaIncioFin;

            }



            frmReportes frm = new frmReportes(reporte);         
            frm.ShowDialog();



        }

            private void mnuInventarioPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void validacionDeDocumentosHaciendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFacturacion form = new frmFacturacion();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes form = new frmClientes();
            form.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores2 form = new frmProveedores2();
            form.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos2 form = new frmProductos2();
            form.ShowDialog();
        }

        private void btnValidacion_Click(object sender, EventArgs e)
        {
            frmValidacionDocsHacienda form = new frmValidacionDocsHacienda();
            form.ShowDialog();
        }

        private void btnDocEmitidos_Click(object sender, EventArgs e)
        {
            frmBuscarDocumentos form = new frmBuscarDocumentos();
            form.ShowDialog();
        }

        private void btnConsultaHac_Click(object sender, EventArgs e)
        {
            frmConsultaFacturaElectronica form = new frmConsultaFacturaElectronica();
            form.ShowDialog();
        }

        private void facturaciónElectrónicaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMensajesCompras_Click(object sender, EventArgs e)
        {
            frmMensajesHacienda form = new frmMensajesHacienda();
            form.ShowDialog();
        }

        private void btnValidarCompras_Click(object sender, EventArgs e)
        {
            frmValidacionDocsHacienda form = new frmValidacionDocsHacienda();
            form.ShowDialog();
        }

        private void btnConsultaMensajeHacienda_Click(object sender, EventArgs e)
        {
            frmConsultasMensajesHacienda form = new frmConsultasMensajesHacienda();
            form.ShowDialog();
        }

        private void generalVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuNotasCreditoFechas_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmCompras form = new frmCompras();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAbonoCredito form = new frmAbonoCredito();
            form.ShowDialog();
        }
    }
}
