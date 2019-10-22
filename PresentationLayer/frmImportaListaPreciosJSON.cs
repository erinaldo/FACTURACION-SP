using AutoMapper;
using BusinessLayer;
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
    public partial class frmImportaListaPreciosJSON : Form
    {
        BProducto proIns = new BProducto();
        public frmImportaListaPreciosJSON()
        {
            InitializeComponent();
        }

        private void btnRutaXML_Click(object sender, EventArgs e)
        {
            try
            {
                txtRutaArchivo.Text = rutaImport();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private string rutaImport()
        {
            try
            {
                OpenFileDialog iFile = new OpenFileDialog();
                iFile.ShowDialog();
                return iFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtRutaArchivo.Text;
                if (path == string.Empty)
                {
                    MessageBox.Show("Indique el nombre del archivo");
                    return;
                }

                if (File.Exists(path))
                {
                    string Jsontxt = File.ReadAllText(path);
                    var products = JsonConvert.DeserializeObject<List<clsProductoExportImport>>(Jsontxt);



                    DialogResult resul = MessageBox.Show("Desea importar los datos", "Importar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                    if (resul == DialogResult.Yes)
                    {
                        var config = new MapperConfiguration(cfg => { cfg.CreateMap<clsProductoExportImport, tbProducto>(); });
                        IMapper iMapper = config.CreateMapper();
                        List<tbProducto> listaProd = new List<tbProducto>();
                        foreach (var item in products)
                        {
                            listaProd.Add(iMapper.Map<clsProductoExportImport, tbProducto>(item));

                        }

                        if (proIns.actualizarProductosImport(listaProd))
                        {
                            MessageBox.Show("Los datos han sido importados correctamente.", "Exportar archivo productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtRutaArchivo.ResetText();
                        }

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo realizar la importación de datos, puede que el archivo este corrupto.","Importar datos",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            




        }
    }
}
