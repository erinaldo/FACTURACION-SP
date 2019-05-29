﻿using CommonLayer;
using CrystalDecisions.CrystalReports.Engine;
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
                if (reporte == (int)Enums.reportes.inventarioCategoria)
                {
                    Reporte = new rptInventarioGeneral();
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
                    // Reporte = new rpt();
                    Reportes.dsReportesTableAdapters.sp_InventarioSobreTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_InventarioSobreTableAdapter();
                    dt.Connection = _SqlConnection;
                    dt.Fill(ds.sp_InventarioSobre);
                }
                else if (reporte == (int)Enums.reportes.inventarioCategoria)
                {
                    // Reporte = new rpt();
                    Reportes.dsReportesTableAdapters.sp_InventarioByCategoriaTableAdapter dt = new Reportes.dsReportesTableAdapters.sp_InventarioByCategoriaTableAdapter();
                    dt.Connection = _SqlConnection;
                   // dt.Fill(ds.sp_InventarioByCategoria,parametro);
                }


                ((ReportDocument)Reporte).SetDataSource(ds);

                crvReporte.ReportSource = Reporte;
                crvReporte.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar el reporte.","Error reporte",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

          

        }
    }
}