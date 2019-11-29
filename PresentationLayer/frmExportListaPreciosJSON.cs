using AutoMapper;
using BusinessLayer;
using CommonLayer;
using EntityLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmExportListaPreciosJSON : Form
    {
        BProducto ProductoIns = new BProducto();
        public frmExportListaPreciosJSON()
        {
            InitializeComponent();
        }

        private void btnRutaXML_Click(object sender, EventArgs e)
        {
            try
            {
                txtRutaXML.Text = rutaExport();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string rutaExport()
        {
            try
            {
                SaveFileDialog iFile = new SaveFileDialog();
                iFile.Filter = "Json File|*.json";
                iFile.Title = "Guardar Archivo Json";
                iFile.FileName = Utility.getDate().ToString("dd-MM-yyyy");
                iFile.ShowDialog();
                return iFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
               if (txtRutaXML.Text == string.Empty)
                {
                    MessageBox.Show("Debe indicar un ruta donde guardar el archivo");
                    return;
                }


                IEnumerable<tbProducto> productos = ProductoIns.getProductos((int)Enums.EstadoBusqueda.Activo);

                string path = txtRutaXML.Text ;
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<tbProducto, clsProductoExportImport>(); });
                IMapper iMapper = config.CreateMapper();
                List<clsProductoExportImport> listaProd = new List<clsProductoExportImport>();
                foreach (var item in productos)
                {
                    listaProd.Add(iMapper.Map<tbProducto, clsProductoExportImport>(item));

                }
                string JSON = JsonConvert.SerializeObject(listaProd);
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(JSON);
                    tw.Close();
                }

                MessageBox.Show("Los datos han sido exportados.", "Exportar archivo productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                txtRutaXML.ResetText();
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique la ruta indicada", "Exportar archivo productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmExportListaPreciosJSON_Load(object sender, EventArgs e)
        {

        }
    }
}
