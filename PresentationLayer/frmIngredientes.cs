using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using EntityLayer;
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
    public partial class frmIngredientes : Form
    {
        BIngredientes IngredienteBIns = new BIngredientes();
        public  tbIngredientes IngredienteGlobal = new tbIngredientes();

        int bandera;
        public frmIngredientes()
        {
            InitializeComponent();
        }
        private bool guardar()//méto guardar formulario
        {
            bool isOk = false;
            tbIngredientes ingrediente = new tbIngredientes();
            try
            {
                ingrediente.nombre = txtNombre.Text.ToUpper();
                ingrediente.precioCompra = decimal.Parse(mskPrecioCompra.Text.ToString());
                ingrediente.idTipoMedida = (int)cboTipoMedida.SelectedValue;
                ingrediente.idTipoIngrediente = (int)cboTipoIngrediente.SelectedValue;
                ingrediente.estado = true;
                ingrediente.fecha_crea = Utility.getDate();
                ingrediente.fecha_ult_mod = Utility.getDate();
                ingrediente.usuario_crea = Global.Usuario.nombreUsuario;
                ingrediente.usuario_ult_mod = Global.Usuario.nombreUsuario;

                // agrego al inventario el producto nuevo
                //tbInventario inventario = new tbInventario();
                //inventario.idIngrediente = ingrediente.idIngrediente;
                //inventario.cantidad = int.Parse(txtcantAct.Text);
                //inventario.cant_max = int.Parse(txtCantMax.Text);
                //inventario.cant_min = int.Parse(txtCantMin.Text);
                //inventario.estado = true;
                //inventario.fecha_crea = ingrediente.fecha_crea;
                //inventario.fecha_ult_mod=ingrediente.fecha_ult_mod;
                //inventario.usuario_crea = ingrediente.usuario_crea;
                //inventario.usuario_ult_mod = ingrediente.usuario_ult_mod;

                List<tbInventario> listaInventario = new List<tbInventario>();
                //listaInventario.Add(inventario);

                //ingrediente.tbInventario = listaInventario;




                tbIngredientes ingred = IngredienteBIns.guardar(ingrediente);
                isOk = true;
                MessageBox.Show("Los datos fueron guardados correctamente");


            }
            catch (EntityDisableStateException ex)
            {
                DialogResult result = MessageBox.Show("El ingrediente ya existe pero se encuentra inactivo,¿Desea activarlo?", "Existen ingredientes",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    chkEstado.Checked = true;
                    IngredienteGlobal = IngredienteBIns.GetEntity(ingrediente);
                    modificar();
                    isOk = true;
                }
                else
                {
                    isOk = false;
                }
            }
            catch (EntityExistException ex)
            {
                MessageBox.Show(ex.Message);
                isOk = false;
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isOk;
        }
        private bool eliminar()///método eliminar formulario
        {
            bool isOk = false;
            try
            {
                if (validarCampos())
                {
                    DialogResult result = MessageBox.Show("Está seguro que desea eliminar el ingrediente", "Eliminar ingrediente", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        IngredienteGlobal.estado = false;
                        IngredienteGlobal.fecha_ult_mod = Utility.getDate();
                        IngredienteGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                        IngredienteBIns.eliminar(IngredienteGlobal);
                        isOk = true;
                        MessageBox.Show("Los datos han sido eliminados correctamente");
                    }

                }

            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show(ex.Message);
                isOk = false;
            }
            return isOk;
        }
        private bool modificar()
        {
     
        
            bool isOk = false;
            try
            {
                IngredienteGlobal.nombre = txtNombre.Text.ToUpper();
                IngredienteGlobal.estado = chkEstado.Checked;
                IngredienteGlobal.fecha_ult_mod = Utility.getDate();
                IngredienteGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                IngredienteGlobal.precioCompra = decimal.Parse(mskPrecioCompra.Text.ToString());
                IngredienteBIns.modificar(IngredienteGlobal);
                isOk = true;

                MessageBox.Show("Los datos han sido modificados correctamente");


            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isOk;
        }
        public bool validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debes de indicar el nombre del ingrediente");
                txtNombre.Focus();
                return false;
            }
            if (mskPrecioCompra.Text == string.Empty)
            {
                MessageBox.Show("Debes de indicar el precio de compra del ingrediente");
                mskPrecioCompra.Focus();
                return false;
            }
            if (txtcantAct.Text == string.Empty)
            {
                MessageBox.Show("Debes indicar una cantidad actual");
                txtcantAct.Focus();
                return false;


            }
            if (txtCantMax.Text == string.Empty)
            {
                MessageBox.Show("Debes indicar una cantidad maxima");
                txtCantMax.Focus();
                return false;


            }
            if (txtCantMin.Text == string.Empty)
            {
                MessageBox.Show("Debes indicar una cantidad minima");
                txtCantMin.Focus();
                return false;


            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmIngredientes_Load(object sender, EventArgs e)
        {
            try
            {
                MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                Utility.EnableDisableForm(ref gbxIngredientes, false);
                //esto es para cargas los combos de otras tablas
                cboTipoIngrediente.DataSource = IngredienteBIns.getTipoIngrediente((int)Enums.EstadoBusqueda.Activo);
                cboTipoIngrediente.DisplayMember = "nombre";
                cboTipoIngrediente.ValueMember = "id";

                cboTipoMedida.DataSource = IngredienteBIns.getTipoMedida((int)Enums.EstadoBusqueda.Todos);
                cboTipoMedida.DisplayMember = "nombre";
                cboTipoMedida.ValueMember = "idTipoMedida";
            }
            catch (EntityException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool guardar(int trans)
        {
            bool isOk = false;
            switch (trans)
            {
                case 1:
                 isOk=   guardar();
                    break;
                case 2:
                  isOk=  modificar();
                    break;
                case 3:
                  isOk=  eliminar();
                    break;
            }
            return true;
        }
        private void buscarDatos(tbIngredientes ingrediente)//método buscar datos
        {
            try
            {
                IngredienteGlobal = ingrediente;
                if (IngredienteGlobal != null)
                {


                    if (IngredienteGlobal.idIngrediente != 0)
                    {
                        txtIdIngrediente.Text = IngredienteGlobal.idIngrediente.ToString().Trim();
                        txtNombre.Text = IngredienteGlobal.nombre.ToString().Trim();
                        mskPrecioCompra.Text = IngredienteGlobal.precioCompra.ToString().Trim();

                        txtCantMin.Text = "0";
                        txtCantMax.Text = "0";
                        txtcantAct.Text = "0";


                        chkEstado.Checked = IngredienteGlobal.estado;
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buscar()
        {
            frmBuscarIngrediente buscar = new frmBuscarIngrediente();
            buscar.pasarDatosEvent += buscarDatos;
            buscar.ShowDialog();
        }

       
        private void accionMenu(string accion)
        {
            switch (accion)
            {
                case "Guardar":
                    if (validarCampos())
                    {
                        if (guardar(bandera))
                        {
                            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);//si se da guardar cambia a nuevo
                            Utility.EnableDisableForm(ref gbxIngredientes, false);//deshabilita el formulario
                            Utility.ResetForm(ref gbxIngredientes);//resetea el formulario
                        }
                       
                       
                    }
                    break;
                case "Nuevo":
                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxIngredientes, true);
                    txtIdIngrediente.Enabled = false;
                    Utility.ResetForm(ref gbxIngredientes);
                    gbxInv.Enabled = true;
                    txtCantMin.Text = "0";
                    txtCantMax.Text = "0";
                    txtcantAct.Text = "0";
                    break;
                case "Modificar":
                    bandera = 2;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxIngredientes, true);
                    txtIdIngrediente.Enabled = false;
                    gbxInv.Enabled = false;
                    break;
                case "Eliminar":
                    bandera = 3;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;
                case "Buscar":
                    buscar();
                    if(IngredienteGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxIngredientes, false);
                        Utility.ResetForm(ref gbxIngredientes);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxIngredientes, false);
                    }
                
                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxIngredientes, false);
                    Utility.ResetForm(ref gbxIngredientes);
                    break;
                case "Salir":
                    this.Close();
                    break;

            }

        }

      

        private void tlsMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);//que la accion menu sea conforme la que está en el texto del item clikeado
        }

        private void tlsBtnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tlsBtnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            
            
        }

        private void txtcantAct_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
