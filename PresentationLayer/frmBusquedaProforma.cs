using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.PresentationsExceptions;
using EntityLayer;
using PresentationLayer.Reportes;
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
    public partial class frmBusquedaProforma : Form
    {
        public delegate void pasaDatos(tbDocumento entity);
        public event pasaDatos pasarDatosEvent;
        public static tbDocumento documentoGlo = new tbDocumento();
        BFacturacion factIns = new BFacturacion();

        public frmBusquedaProforma()
        {
            InitializeComponent();
        }

        private void frmBusquedaProforma_Load(object sender, EventArgs e)
        {
            obtenerAplicarFiltro();
        }

        private void obtenerAplicarFiltro()
        {

            try
            {
                IEnumerable<tbDocumento> fact = factIns.getListAllDocumentos();
                fact = fact.Where(x => x.estado == true && x.tipoDocumento == (int)Enums.TipoDocumento.Proforma);


                if (txtFactura.Text != string.Empty)
                {
                    fact = fact.Where(x => x.id == int.Parse(txtFactura.Text.Trim()));

                }

                if (txtCedula.Text != string.Empty)
                {
                    fact = fact.Where(x => x.idCliente != null && x.idCliente.Trim() == txtCedula.Text.Trim());
                }

                if (txtNombre.Text != string.Empty)
                {
                    fact = fact.Where(x => x.idCliente != null && x.tbClientes.tbPersona.nombre.ToUpper().Contains(txtNombre.Text.ToUpper().Trim()));
                }


                if (txtApell1.Text != string.Empty)
                {
                    fact = fact.Where(x => x.idCliente != null && x.tbClientes.tbPersona.apellido1 != null && x.tbClientes.tbPersona.apellido1.ToUpper().Contains(txtApell1.Text.ToUpper().Trim()));

                }
                if (txtApell2.Text != string.Empty)
                {
                    fact = fact.Where(x => x.idCliente != null && x.tbClientes.tbPersona.apellido2 != null && x.tbClientes.tbPersona.apellido2.ToUpper().Contains(txtApell2.Text.ToUpper().Trim()));

                }

                fact = fact.OrderByDescending(x => x.id);
                cargarLista(fact);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar datos, favor verificar los datos ingresdos.", "Datos errones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarLista(IEnumerable<tbDocumento> documentos)
        {
            lsvFacturas.Items.Clear();
            foreach (tbDocumento item in documentos)
            {
                //Agregamos el item a la lista.
                double daysPlazo = double.Parse(item.plazo.ToString());
                DateTime fechaVenc = item.fecha.AddDays(daysPlazo);

              
                if (fechaVenc < Utility.getDate())
                {
                    continue;
                }
                //Creamos un objeto de tipo ListviewItem
                ListViewItem linea = new ListViewItem();

                linea.Text = item.id.ToString();

                if (item.tipoIdCliente == null)
                {
                    linea.SubItems.Add("SIN  CLIENTE");
                    linea.SubItems.Add("SIN  CLIENTE");
                }
                else if (item.tipoIdCliente == (int)Enums.TipoId.Fisica)
                {
                    linea.SubItems.Add(item.idCliente.ToString().Trim());
                    linea.SubItems.Add(item.tbClientes.tbPersona.nombre.Trim().ToUpper() + " " + item.tbClientes.tbPersona.apellido1.Trim().ToUpper() + " " + item.tbClientes.tbPersona.apellido2.Trim().ToUpper());

                }
                else
                {
                    linea.SubItems.Add(item.idCliente.ToString().Trim());
                    linea.SubItems.Add(item.tbClientes.tbPersona.nombre.Trim().ToUpper());

                }

                linea.SubItems.Add(item.fecha.ToString());
                decimal monto = item.tbDetalleDocumento.Sum(x => x.totalLinea);

                linea.SubItems.Add(monto.ToString());


                lsvFacturas.Items.Add(linea);

            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            obtenerAplicarFiltro();
        }

        private void btnTrasnferir_Click(object sender, EventArgs e)
        {
            buscarDatosSeleccionado();
        }

        private void lsvFacturas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buscarDatosSeleccionado();

        }

        private void buscarDatosSeleccionado()
        {

            try
            {
                if (lsvFacturas.SelectedItems.Count > 0)
                {

                    int idProforma = int.Parse(lsvFacturas.SelectedItems[0].Text);

                    enviarProforma(idProforma);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void enviarProforma(int idProforma)
        {
            try
            {


                IEnumerable<tbDocumento> fact = factIns.getListAllDocumentos();
                tbDocumento proforma = fact.Where(x => x.id == idProforma && x.tipoDocumento == (int)Enums.TipoDocumento.Proforma).SingleOrDefault();
                pasarDatosEvent(proforma);
                this.Dispose();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (lsvFacturas.SelectedItems.Count > 0)
            {

                int idProforma = int.Parse(lsvFacturas.SelectedItems[0].Text);

                IEnumerable<tbDocumento> fact = factIns.getListAllDocumentos();
                tbDocumento proforma = fact.Where(x => x.id == idProforma && x.tipoDocumento == (int)Enums.TipoDocumento.Proforma).SingleOrDefault();

                if (proforma!=null)
                {
                    enviarCorreo(proforma);
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar alguna proforma", "Proforma", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

           
        }

        private void enviarCorreo(tbDocumento proforma)
        {
            if (Utility.AccesoInternet())
            {
                DialogResult result = MessageBox.Show("Se enviará por correo electrónico la factura seleccionada, Desea continuar?", "Envio de correo electrónico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    List<string> correos = new List<string>();
                    if (proforma.correo1!=null)
                    {
                        correos.Add(proforma.correo1.Trim());
                    }
                    if (proforma.correo2 != null)
                    {
                        correos.Add(proforma.correo2.Trim());
                    }


                    bool enviado = false;
                    try
                    {
                        CorreoElectronico correo = new CorreoElectronico(proforma, correos, true);
                        enviado = correo.enviarCorreo();
                    }
                    catch (CorreoSinDestinatarioException ex)
                    {

                        MessageBox.Show(ex.Message, "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (enviado)
                    {
                        MessageBox.Show("Se envió correctamente el correo electrónico", "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al enviar el Correo Electrónico", "Correo Electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            else
            {
                MessageBox.Show("No hay acceso a internet", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        
    }
}
