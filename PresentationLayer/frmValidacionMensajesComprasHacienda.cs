using BusinessLayer;
using CommonLayer;
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
    public partial class frmValidacionMensajesComprasHacienda : Form
    {
        BFacturacion facturaIns = new BFacturacion();
        IEnumerable<tbReporteHacienda> mensajesLista = new List<tbReporteHacienda>();
        public frmValidacionMensajesComprasHacienda()
        {
            InitializeComponent();
        }

        private void frmValidacionMensajesComprasHacienda_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            formatoGrid();
            cargarDatos();
        }

        private void cargarDatos()
        {
            try
            {
                mensajesLista = facturaIns.listaMensajesCompras();
                if (chkFechas.Checked)
                {
                    if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final", "Datos fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        chkFechas.Checked = false;
                    }
                    else
                    {
                        DateTime fechaInicio = dtpFechaInicio.Value.Date;
                        DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1);

                        mensajesLista = mensajesLista.Where(x => x.fecha >= fechaInicio && x.fecha <= fechaFin);
                    }

                }


                if (txtIdRecept.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.id.ToString() == txtIdRecept.Text.Trim());

                }

                if (txtClaveRecept.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.claveReceptor == txtClaveRecept.Text.Trim());

                }


                if (txtConseRecept.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.consecutivoReceptor == txtConseRecept.Text.Trim());


                }




                if (txtIdEmisor.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.idEmisor == txtIdEmisor.Text.Trim());


                }

                if (txtClaveEmisor.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.claveDocEmisor == txtClaveEmisor.Text.Trim());


                }

                if (txtNombreEmisor.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.nombreEmisor.Trim().ToUpper().Contains(txtNombreEmisor.Text.Trim().ToUpper()));


                }

                if (txtArchivo.Text != string.Empty)
                {
                    mensajesLista = mensajesLista.Where(x => x.nombreArchivo.Contains(txtArchivo.Text.Trim()));


                }

                if (chkInconsistentes.Checked)
                {

                    if (mensajesLista.Count() != 0)
                    {
                        mensajesLista = mensajesLista.Where(x => x.EstadoRespHacienda == null || x.EstadoRespHacienda.Trim().ToUpper() == "RECHAZADO" || x.EstadoRespHacienda.Trim().ToUpper() == "PROCESANDO" || x.reporteAceptaHacienda == false || x.mensajeRespHacienda == false);



                    }


                }
                else
                {

                    mensajesLista = mensajesLista.Where(x => x.reporteAceptaHacienda == !chkInconsistentes.Checked && x.mensajeRespHacienda == !chkInconsistentes.Checked && x.EstadoRespHacienda.Trim().ToUpper() == "ACEPTADO");



                }







                cargarGRID(mensajesLista);
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cargarGRID(IEnumerable<tbReporteHacienda> mensajesLista)
        {
            try
            {
                dtgvDetalleFactura.Rows.Clear();
                foreach (var doc in mensajesLista)
                {

                    DataGridViewRow row = (DataGridViewRow)dtgvDetalleFactura.Rows[0].Clone();
                    row.Cells[0].Value = doc.id;
                    row.Cells[1].Value = doc.fecha.ToString().Trim();
                    row.Cells[2].Value = doc.consecutivoReceptor.ToString().Trim();
                    row.Cells[3].Value = doc.fechaEmision.ToString().Trim();
                    row.Cells[4].Value = doc.nombreEmisor.ToString().Trim().ToUpper();
                    row.Cells[5].Value = doc.mensajeReporteHacienda == null ? "SIN ENVIAR" : doc.mensajeReporteHacienda.Trim().ToUpper();
                    row.Cells[6].Value = doc.EstadoRespHacienda == null ? "SIN ENVIAR" : doc.EstadoRespHacienda.Trim().ToUpper();
                    row.Cells[7].Value = "Ver detalle";
                    row.Cells[8].Value = "Enviar Correo";

                    row.Cells[9].Value = doc.EstadoRespHacienda == null ? "SIN VALIDAR" : doc.EstadoRespHacienda.Trim().ToUpper();
                    dtgvDetalleFactura.Rows.Add(row);
                    // dtgvDetalleFactura.Rows[listaDetalleDocumento.Count-1].Selected=true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           





        }

        private void formatoGrid()
        {
            dtgvDetalleFactura.BorderStyle = BorderStyle.None;
            dtgvDetalleFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dtgvDetalleFactura.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvDetalleFactura.DefaultCellStyle.SelectionBackColor = Color.Green;
            dtgvDetalleFactura.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgvDetalleFactura.BackgroundColor = Color.White;

            dtgvDetalleFactura.EnableHeadersVisualStyles = false;
            dtgvDetalleFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvDetalleFactura.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgvDetalleFactura.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //  dtgvDetalleFactura.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                try
                {
                if (e.ColumnIndex == 7)
                {
                    frmDetalleMensaje msj = new frmDetalleMensaje();
                    int id = int.Parse(dtgvDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString());
                    foreach (var item in mensajesLista)
                    {
                        if (item.id == id)
                        {
                            msj.Reporte = item;
                            break;
                        }

                    }
                    msj.ShowDialog();
                }
                else if (e.ColumnIndex == 8)
                {
                    reportarFacturacionElectronica(int.Parse(dtgvDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString()));



                }
                else if (e.ColumnIndex == 9)
                {
                    if (Utility.AccesoInternet())
                    {
                        string id = dtgvDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if (id != string.Empty)
                        {

                            facturaIns.consultarMensajePorIdFact(int.Parse(id));
                            cargarDatos();

                        }

                    }
                    else
                    {
                        MessageBox.Show("No hay acceso a internet, no se validarán los documentos", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

        }

        private void reportarFacturacionElectronica(int id)
        {
            try
            {

                tbReporteHacienda resp = mensajesLista.Where(x => x.id == id).SingleOrDefault();
                List<tbReporteHacienda> lista = new List<tbReporteHacienda>();
                lista.Add(resp);


                if (resp.reporteAceptaHacienda==false || resp.mensajeRespHacienda==false)
                {
                    facturaIns.reportarMensajesHacienda(lista);
                }
              


                enviarCorreo(lista);

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void enviarCorreo(List<tbReporteHacienda> lista)
        {
            try
            {
                bool enviado = false;
                foreach (var item in lista)
                {
                    List<string> correos = new List<string>();


                    if (item.correoElectronico != null)
                    {
                        correos.Add(item.correoElectronico.Trim());

                    }

                    CorreoElectronico correo = new CorreoElectronico(item, correos, true);
                    enviado = correo.enviarCorreo();
                }
                MessageBox.Show("Se han enviado los correos electrónicos.", "Envio de correos electrónicos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo enviar los correos, favor de verificar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Task ProcessData(DataGridView dg, IProgress<ProgressReport> process)
        {

            int index = 1;
            int totalProcess = dg.Rows.Count;
            var ProgressReport = new ProgressReport();
            return Task.Run(() =>
            {

                try
                {
                    foreach (DataGridViewRow item in dtgvDetalleFactura.Rows)
                    {
                        ProgressReport.PorcentComplete = index * 100 / totalProcess;
                        process.Report(ProgressReport);
                        try
                        {

                            

                            string id = item.Cells[0].Value.ToString();
                            if (id != string.Empty)
                            {

                                facturaIns.consultarMensajePorIdFact(int.Parse(id));
                                

                            }

                        }
                        catch (Exception)
                        {


                        }
                        index++;


                    }
                }
                catch (Exception)
                {


                }



            });

        }


        private async void btnValidarTodos_Click(object sender, EventArgs e)
        {


            if (Utility.AccesoInternet())
            {
                progressBar1.Visible = true;
                try
                {

                    var progress = new System.Progress<ProgressReport>();
                    progress.ProgressChanged += (o, report) => {

                        progressBar1.Value = report.PorcentComplete;
                        progressBar1.Update();
                    };


                    await ProcessData(dtgvDetalleFactura, progress);


                }
                catch (Exception)
                {

                }

                cargarDatos();
                progressBar1.Visible = false;


            }
            else
            {
                MessageBox.Show("No hay acceso a internet, no se validarán los documentos", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            progressBar1.Visible = false;

        }

        private void chkFechas_CheckedChanged(object sender, EventArgs e)
        {

            gbxFechas.Enabled = chkFechas.Checked;
          
        }
    }
}
