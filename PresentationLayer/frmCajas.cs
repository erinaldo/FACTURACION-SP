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
using EntityLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using BusinessLayer;


namespace PresentationLayer
{
    public partial class frmCajas : Form
    {
        private tbCajas  CajaGlobal = new tbCajas();
        int bandera;
        BCajas Inscajas = new BCajas();
        public frmCajas()
        {
            InitializeComponent();
        }
        private void frmCajas_Load(object sender, EventArgs e)
        {
            try
            {
                MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                Utility.EnableDisableForm(ref gbxCajas, false);
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
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
                    if (validarCampos())
                    {
                        if (Accionguardar(bandera))
                        {


                            {
                                MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                                Utility.EnableDisableForm(ref gbxCajas, false);
                                Utility.ResetForm(ref gbxCajas);
                            }
                        }
                    }
                    break;


                case "Nuevo":
                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxCajas, true);
                    txtId.Enabled = false;
                    Utility.ResetForm(ref gbxCajas);
                    break;

                case "Modificar":
                    bandera = 2;

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxCajas, true);
                    txtId.Enabled = false;
                    break;
                case "Eliminar":
                    bandera = 3;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;
                case "Buscar":
                    buscar();
                    if (CajaGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.ResetForm(ref gbxCajas);
                        Utility.EnableDisableForm(ref gbxCajas, false);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxCajas, false);
                    }




                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxCajas, false);
                    Utility.ResetForm(ref gbxCajas);

                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }
        private bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el nombre de la caja");
                txtNombre.Focus();
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar una descripcion");
                txtDescripcion.Focus();
                return false;
            }
           

            return true;
        }
        private bool Accionguardar(int trans)
        {
            bool isOk = false;
            
            switch (trans)
            {

                case 1:
                    isOk = guardar();
                    break;

                case 2:
                    isOk = modificar();
                    break;

                case 3:
                    isOk = eliminar();
                    break;


            }
            return true;

        }
        private bool guardar()
        {
            bool isOk = false;
            tbCajas cajas = new tbCajas();

            if (validarCampos())
            {

                try
                {

                    cajas.nombre = txtNombre.Text.ToUpper();
                    cajas.descripcion = txtDescripcion.Text.ToUpper();

                    cajas.estado = true;
                    cajas.fecha_crea = Utility.getDate();
                    cajas.fecha_ult_mod = Utility.getDate();
                    cajas.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper(); 
                    cajas.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();


                    cajas = Inscajas.guardar(cajas);

                    txtId.Text = cajas.id.ToString();
                    isOk = true;
                    MessageBox.Show("La caja se guardó correctamente");
                    
                }

                catch (EntityExistException ex)
                {
                    MessageBox.Show(ex.Message);
                    isOk = false;
                  
                }

                catch (EntityDisableStateException ex)
                {
                    DialogResult result = MessageBox.Show(ex.Message, "  existe la caja ", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        chkEstado.Checked = true;
                        CajaGlobal =Inscajas.getEntity(cajas);
                        
                        modificar();
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
            else
            {
                isOk = false;
            }


            return isOk;
        }
        private bool modificar()
        {
            bool isOk = false;

            try
            {
                CajaGlobal.nombre = txtNombre.Text.ToUpper();
                CajaGlobal.descripcion = txtDescripcion.Text.ToUpper();
                CajaGlobal.estado = chkEstado.Checked;
                CajaGlobal.fecha_ult_mod = Utility.getDate();
                CajaGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper(); 

                CajaGlobal = Inscajas.modificar(CajaGlobal);

                MessageBox.Show("Los datos fueron actualizados (modificado)");

            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show(ex.Message);
            }
            return isOk;
        }

        private bool eliminar()
        {
            bool isOk = false;
            try
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea eliminar la caja?", "Eliminar", MessageBoxButtons.YesNo);//consultar duda
                if (result == DialogResult.Yes)
                {
                    //falta validar los compos obligatorios antes de guardar
                    CajaGlobal.estado = false;
                    CajaGlobal.fecha_ult_mod = Utility.getDate();
                    CajaGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper(); ;
                    tbCajas  tipoIngre = Inscajas.eliminar(CajaGlobal);
                    isOk = true;
                    MessageBox.Show("Los datos fueron actualizados (eliminado)");

                }
            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show(ex.Message);
                isOk = false;
            }
            return isOk;
        }
        private void dataBuscar(tbCajas cajas)
        {

            try
            {
                CajaGlobal  = cajas;
                if (CajaGlobal != null)
                {

                    if (CajaGlobal.id != 0)
                    {
                        txtId.Text = CajaGlobal.id.ToString().Trim();
                        txtNombre.Text = CajaGlobal.nombre.Trim();
                        txtDescripcion.Text = CajaGlobal.descripcion.Trim();
                        chkEstado.Checked = CajaGlobal.estado;

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void buscar()
        {

            try
            {


                frmBuscarCajas buscar = new frmBuscarCajas();
                buscar.pasarDatosEvent += dataBuscar;

                buscar.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
