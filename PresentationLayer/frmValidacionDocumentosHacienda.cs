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
    public partial class frmValidacionDocumentosHacienda : Form
    {
        BFacturacion facturaIns = new BFacturacion();
        IEnumerable<tbDocumento> facturas = new List<tbDocumento>();
        public frmValidacionDocumentosHacienda()
        {
            InitializeComponent();
        }

        private void frmValidacionDocumentosHacienda_Load(object sender, EventArgs e)
        {
            formatoGrid();
            cargarDatos();
            progressBar1.Visible = false;


        }

        private void cargarDatos()
        {
            facturas = facturaIns.listaFacturas();
            facturas = facturas.Where(x => x.estado == true);

            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final", "Datos fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);

              
            }
            else
            {
                DateTime fechaInicio = dtpFechaInicio.Value.Date;
                DateTime fechaFin = dtpFechaFin.Value.Date.AddDays(1);

                facturas = facturas.Where(x => x.fecha >= fechaInicio && x.fecha <= fechaFin);
            }

            cargarGRID(facturas);

        }

        private void cargarGRID(IEnumerable<tbDocumento> docs)
        {

            dtgvDetalleFactura.Rows.Clear();
            foreach (tbDocumento doc in docs)
            {
               
                DataGridViewRow row = (DataGridViewRow)dtgvDetalleFactura.Rows[0].Clone();
                row.Cells[0].Value = doc.tipoDocumento;
                row.Cells[1].Value = doc.id.ToString().Trim();
                row.Cells[2].Value = Enum.GetName(typeof(Enums.TipoDocumento), doc.tipoDocumento).ToUpper();
                row.Cells[3].Value = doc.consecutivo==null?"": doc.consecutivo.ToString().Trim();
                row.Cells[4].Value = doc.fecha.ToString().Trim();
                if(doc.tipoIdCliente==null)
                {
                    row.Cells[5].Value = "SIN CLIENTE";
                }
                else if (doc.tipoIdCliente==2)
                {
                    row.Cells[5].Value = doc.idCliente.Trim() + "-" + doc.tbClientes.tbPersona.nombre.Trim().ToUpper() ;

                }
                else
                {
                    row.Cells[5].Value = doc.idCliente.Trim() + "-" + doc.tbClientes.tbPersona.nombre.Trim().ToUpper() + " " + doc.tbClientes.tbPersona.apellido1.Trim().ToUpper() + " " + doc.tbClientes.tbPersona.apellido2.Trim().ToUpper();

                }

                 row.Cells[6].Value = doc.mensajeReporteHacienda==null?"SIN ENVIAR": doc.mensajeReporteHacienda.Trim().ToUpper();

                row.Cells[7].Value = doc.EstadoFacturaHacienda==null ?"SIN VALIDAR": doc.EstadoFacturaHacienda.Trim().ToUpper();
          
                dtgvDetalleFactura.Rows.Add(row);
                // dtgvDetalleFactura.Rows[listaDetalleDocumento.Count-1].Selected=true;
            }


        }

        private void formatoGrid()
        {
            dtgvDetalleFactura.BorderStyle = BorderStyle.None;
            dtgvDetalleFactura.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgvDetalleFactura.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvDetalleFactura.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
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

        private void dtgvDetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Utility.AccesoInternet())
                {
                    if (e.ColumnIndex == 8)
                    {
                        string idFactura = dtgvDetalleFactura.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string tipoDoc = dtgvDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if (idFactura != string.Empty && tipoDoc != string.Empty)
                        {
                            tbDocumento doc = new tbDocumento();
                            doc.id = int.Parse(idFactura);
                            doc.tipoDocumento = int.Parse(tipoDoc);
                            facturaIns.consultarFacturaElectronicaPorIdFact(doc);
                            cargarDatos();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay acceso a internet, no se validarán los documentos", "Sin Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private Task ProcessData(DataGridView dg , IProgress <ProgressReport> process) {

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
                            string idFactura = item.Cells[1].Value.ToString();
                            string tipoDoc = item.Cells[0].Value.ToString();
                            if (idFactura != string.Empty && tipoDoc != string.Empty)
                            {

                                tbDocumento doc = new tbDocumento();
                                doc.id = int.Parse(idFactura);
                                doc.tipoDocumento = int.Parse(tipoDoc);
                                facturaIns.consultarFacturaElectronicaPorIdFact(doc);
                                // cargarDatos();

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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
