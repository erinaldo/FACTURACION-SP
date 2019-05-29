using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CommonLayer;
using EntityLayer;
using BusinessLayer;

using CommonLayer.Exceptions.DataExceptions;


namespace PresentationLayer
{
    public partial class frmDetalleTiquete : Form
    {

        bool banderaImagen = false;
        int bandera = 1;
        string nombreImagen = "";

        string path;

        //Creamos la instancia global para acceder a la capa Business de Detalle Impresion
        BDetalleImpresion detalleImpresionIns = new BDetalleImpresion();

        //Creamos una instancia Global para Detalle
        tbDetalleImpresion detalleImpresionGlo = new tbDetalleImpresion();

        public frmDetalleTiquete()
        {
            InitializeComponent();
        }

        private void frmDetalleTiquete_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gboDatos, false);
        }




        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {



            //Asignamos la imagen al pictureBox

            OpenFileDialog openFile = new OpenFileDialog();

            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "All files (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Recuperamos la direccion fisica de la imagen.
                nombreImagen = openFile.FileName;
                Image imagen = new Bitmap(nombreImagen);

                ptcLogoEmpresa.Image = imagen;


                banderaImagen = true;


            }


        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }


        private void accionMenu(string accion)
        {

            switch (accion)
            {
                case "Guardar":

                    if (accionGuardar(bandera))
                    {

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gboDatos, false);
                        Utility.ResetForm(ref gboDatos);
                    }
                    break;

                case "Nuevo":
                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatos, true);
                    Utility.ResetForm(ref gboDatos);
                    break;

                case "Modificar":
                    bandera = 2;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gboDatos, true);
                    break;

                case "Eliminar":
                    bandera = 3;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;

                case "Buscar":
                    cargarDatos();
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                    Utility.EnableDisableForm(ref gboDatos, false);
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gboDatos, false);
                    Utility.ResetForm(ref gboDatos);
                    break;
 
                case "Salir":
                    this.Close();
                    break;
            }

        }



        private void cargarDatos()
        {

            try
            {

                detalleImpresionGlo = detalleImpresionIns.GetEntity(detalleImpresionGlo);

                if (detalleImpresionGlo == null)
                {
                    MessageBox.Show("No existe información referente a la empresa en la base de datos.", "Error");
                }
                else
                {

                    txtNombreEmpresa.Text = detalleImpresionGlo.NombreEmpresa.Trim();
                    txtDireccionEmpresa.Text = detalleImpresionGlo.DireccionEmpresa.Trim();
                    txtTelefonoEmpresa.Text = detalleImpresionGlo.TelefonoEmpresa.Trim();
                    txtTributacion.Text = detalleImpresionGlo.MensajeTributacion.Trim();
                    txtMensajeDespidad.Text = detalleImpresionGlo.MensajeDespedida.Trim();

                    Image imagen = new Bitmap(detalleImpresionGlo.LogoEmpresa);
                    ptcLogoEmpresa.Image = imagen;


                }



            }
            catch (Exception ex)
            {
                    
                MessageBox.Show(ex.Message);
            }
        
        }


        /// <summary>
        /// Seleccionamos que haremos segun el estado de la bandera.
        /// </summary>
        /// <param name="trans"></param>
        private bool accionGuardar(int trans)
        {

            bool action = false;

            switch (trans)
            {

                case 1:
                    action = guardar();

                    break;

                case 2:
                    action = actualizar();

                    break;

            }

            return action;


        }


        private bool actualizar()
        {
            bool isOK = false;
            try
            {
                detalleImpresionGlo.NombreEmpresa = txtNombreEmpresa.Text.Trim();
                detalleImpresionGlo.DireccionEmpresa = txtDireccionEmpresa.Text.Trim();
                detalleImpresionGlo.TelefonoEmpresa = txtTelefonoEmpresa.Text.Trim();
                detalleImpresionGlo.MensajeTributacion = txtTributacion.Text.Trim();
                detalleImpresionGlo.MensajeDespedida = txtMensajeDespidad.Text.Trim();

                if (banderaImagen) 
                {

                     path = Path.Combine("C:\\TEMP\\", nombreImagen);

                }



                detalleImpresionGlo = detalleImpresionIns.Actualizar(detalleImpresionGlo);

                MessageBox.Show("Los datos han sido actualizados.", "Exito");

                isOK = true;


            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show(ex.Message);
                isOK = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isOK = false;
            }

            return isOK;


        }

        /// <summary>
        /// Guardamos la informacion suministrada en el sistema.
        /// </summary>
        /// <returns></returns>
        private bool guardar()
        {

            bool isOK = false;

            try
            {

                //Creamos una nueva instancia de la entidad 
                tbDetalleImpresion nuevoIngreso = new tbDetalleImpresion();

                nuevoIngreso.NombreEmpresa = txtNombreEmpresa.Text.Trim();
                nuevoIngreso.DireccionEmpresa = txtDireccionEmpresa.Text.Trim();
                nuevoIngreso.TelefonoEmpresa = txtTelefonoEmpresa.Text.Trim();
                nuevoIngreso.MensajeTributacion = txtTributacion.Text.Trim();
                nuevoIngreso.MensajeTributacion = txtMensajeDespidad.Text.Trim();

                string destino = "C:\\TEMP\\";

                //Creamos la ruta de la imagen.
                string foto = Path.Combine(destino, nombreImagen);

                nuevoIngreso.LogoEmpresa = foto;

                nuevoIngreso = detalleImpresionIns.Guardar(nuevoIngreso);

                if (nuevoIngreso.ID != 0)
                {


                    if (Directory.Exists(destino))
                    {
                        File.Copy(nombreImagen, foto);

                        MessageBox.Show("Los datos han sido agregados satisfactoriamente.", "Datos almacenados.");
                        isOK = true;
                    }
                    else
                    {
                        Directory.CreateDirectory(destino);

                        File.Copy(nombreImagen, foto);

                        MessageBox.Show("Los datos han sido agregados satisfactoriamente.", "Datos almacenados.");
                        isOK = true;
                    }
                    
                    


                }

                

            }
            catch (SaveEntityException ex)
            {

                MessageBox.Show(ex.Message);
                isOK = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isOK = false;
            }

            return isOK;
        
        }



    }
}
