﻿using CommonLayer;
using CrystalDecisions.CrystalReports.Engine;
using EntityLayer;
using PresentationLayer.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmReportes : Form
    {

        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public tbClientes clienteGlo { get; set; }

        private int reporte { get; set; }

        public frmReportes()
        {
            InitializeComponent();
        }

        public frmReportes(int reporte)
        {
            InitializeComponent();
            this.reporte = reporte;
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection _SqlConnection = new SqlConnection(Utility.stringConexionReportes());

                dsReportes ds = new dsReportes();
                _SqlConnection.Open();
                object Reporte = new object();
                if (reporte == (int)Enums.reportes.inventarioGeneral)
                {
                    Reporte = new rptInventarioCategoria();
                    Reportes.dsReportesTableAdapters.sp_InventarioGeneralTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_InventarioGeneralTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_InventarioGeneral);


                }
               
                else if (reporte == (int)Enums.reportes.inventarioBajo)
                {

                    Reporte = new rptIneventarioBajo();
                    Reportes.dsReportesTableAdapters.sp_InventarioBajoTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_InventarioBajoTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_InventarioBajo);



                }
                else if (reporte == (int)Enums.reportes.inventarioSobre)
                {
                    Reporte = new rptInventarioSobre();
                    Reportes.dsReportesTableAdapters.sp_InventarioSobreTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_InventarioSobreTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_InventarioSobre);
                }
                else if (reporte == (int)Enums.reportes.inventarioCategoria)
                {
                    Reporte = new rptInventarioGeneral();
                    Reportes.dsReportesTableAdapters.sp_InventarioGeneralTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_InventarioGeneralTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_InventarioGeneral);
                }
                else if (reporte == (int)Enums.reportes.reporteGeneralVenta)
                {
                    this.fechaInicio = Utility.getDate();
                    this.fechaFin = Utility.getDate();
                    Reporte = new rptVentaDia();
                    Reportes.dsReportesTableAdapters.spReporteVentasPorFechaEspTableAdapter dt = new Reportes.dsReportesTableAdapters.spReporteVentasPorFechaEspTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.spReporteVentasPorFechaEsp, this.fechaInicio, this.fechaFin);

                }
                else if (reporte == (int)Enums.reportes.ventasFechaInicioFin)
                {
                    frmFechaInicoFin buscar = new frmFechaInicoFin();
                    buscar.pasarDatosEvent += datosFechas;
                    buscar.ShowDialog();
                    if (this.fechaInicio==DateTime.MinValue && this.fechaFin==DateTime.MinValue)
                    {
                        this.Close();
                    }

                    Reporte = new rptVentasFechasInicioFin1();
                    Reportes.dsReportesTableAdapters.spReporteVentasPorFechaEspTableAdapter dt = new Reportes.dsReportesTableAdapters.spReporteVentasPorFechaEspTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.spReporteVentasPorFechaEsp,this.fechaInicio, this.fechaFin);
                }
                else if (reporte == (int)Enums.reportes.notasCreditoFechaIncioFin)
                {
                    frmFechaInicoFin buscar = new frmFechaInicoFin();
                    buscar.pasarDatosEvent += datosFechas;
                    buscar.ShowDialog();
                    if (this.fechaInicio == DateTime.MinValue && this.fechaFin == DateTime.MinValue)
                    {
                        this.Close();
                    }

                    Reporte = new rptNotasCreditoFechaIncioFin();
                    Reportes.dsReportesTableAdapters.sp_NotasCreditoPorFechaEspTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_NotasCreditoPorFechaEspTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_NotasCreditoPorFechaEsp, this.fechaInicio, this.fechaFin);
                }
                else if (reporte == (int)Enums.reportes.estadoCuentaCliente)
                {
                    frmClienteReporte buscar = new frmClienteReporte();
                    buscar.pasarDatosEvent += datoscliente;
                    buscar.ShowDialog();
                    if (clienteGlo==null)
                    {
                        this.Close();
                        return;
                    }

                    Reporte = new rptEstadoCuentaClienteEsp();
                    Reportes.dsReportesTableAdapters.sp_EstadoCuentaClienteEspTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_EstadoCuentaClienteEspTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_EstadoCuentaClienteEsp, (int)clienteGlo.tipoId, clienteGlo.id.Trim().ToString());
                }
                else if (reporte == (int)Enums.reportes.morosos)
                {              

                    Reporte = new rptMoridadClientes();
                    Reportes.dsReportesTableAdapters.sp_MorosidadClientesTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_MorosidadClientesTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_MorosidadClientes);
                }




                ((ReportDocument)Reporte).SetDataSource(ds);

                crvReporte.ReportSource = Reporte;
                crvReporte.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el reporte.","Error reporte",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          

        }

        private void datoscliente(tbClientes entity)
        {
          
                clienteGlo = entity;
           
        }

        private void datosFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
        }
    }
}
