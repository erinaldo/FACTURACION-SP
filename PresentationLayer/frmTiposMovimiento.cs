using BusinessLayer;
using CommonLayer;
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
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Exceptions.BusisnessExceptions;


namespace PresentationLayer
{
    public partial class frmTiposMovimiento : Form
    {
      
        BTipoMovimiento btipoMovimientoIns = new BTipoMovimiento();
        int bandera ;
        private tbTipoMovimiento TipoMovimientoGlobal = new tbTipoMovimiento();
        public frmTiposMovimiento()
        {
            InitializeComponent();
        }
        private bool guardar()
        {
            bool isOk = false;
            tbTipoMovimiento movimiento = new tbTipoMovimiento();

              try
                {
                movimiento.idTipo = int.Parse(txtId.Text.Trim());
                    movimiento.nombre = txtNombre.Text;
                    movimiento.descripcion = txtDescripcion.Text;
                    movimiento.estado = true;
                    movimiento.fecha_crea = Utility.getDate();
                    movimiento.fecha_ult_mod = Utility.getDate();
                    movimiento.usuario_crea = Global.Usuario.nombreUsuario;
                    movimiento.usuario_ult_mod = Global.Usuario.nombreUsuario;
                   // txtId.Text = movimiento.idTipo.ToString();
                    movimiento.afecta_conta = short.Parse(cboAfectaInv.SelectedItem.ToString().Substring(0, 1));
               
                    tbTipoMovimiento tipMovimiento = btipoMovimientoIns.guardar(movimiento);

                isOk = true;
                MessageBox.Show("Los datos han sido almacenada en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);




            }

                catch (EntityDisableStateException)
                {
                    DialogResult result = MessageBox.Show("Datos ya existe en la base datos, ¿Desea actualizarlos?", "Datos Existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    {

                        
                        TipoMovimientoGlobal = btipoMovimientoIns.GetEntity(movimiento);//consulta a base da datos
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
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isOk;


        }
        private bool eliminar()
        {
            bool isOk = false;
            try
            {
                if (validarCampos())
                {

                
                DialogResult result = MessageBox.Show("¿Se encuentra seguro de eliminar los datos?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                       
                        TipoMovimientoGlobal.estado = false;
                        TipoMovimientoGlobal.fecha_ult_mod = Utility.getDate();
                        TipoMovimientoGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
                        btipoMovimientoIns.eliminar(TipoMovimientoGlobal);
                        isOk = true;
                        MessageBox.Show("Los datos han sido eliminados de la base datos.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOk = false;
            }
            return isOk;
        }
        private bool modificar()
        {
            bool isOk = false;
            try
            {
              

                TipoMovimientoGlobal.idTipo = int.Parse(txtId.Text.Trim());
                TipoMovimientoGlobal.nombre = txtNombre.Text.ToUpper();
                TipoMovimientoGlobal.descripcion = txtDescripcion.Text.ToUpper();
                TipoMovimientoGlobal.fecha_ult_mod = Utility.getDate();
                TipoMovimientoGlobal.usuario_ult_mod = Global.Usuario.nombreUsuario;
            
                TipoMovimientoGlobal.afecta_conta = short.Parse(cboAfectaInv.SelectedItem.ToString().Substring(0, 1));

                btipoMovimientoIns.modificar(TipoMovimientoGlobal);

                isOk = true;
                MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (UpdateEntityException ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isOk;
        }

        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }

        private void gbxMovimientos_Enter(object sender, EventArgs e)
        {

        }

        private void frmTiposMovimiento_Load(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            try
            {
                MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                Utility.EnableDisableForm(ref gbxMovimientos, false);
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Accionguardar(int trans)
        { bool isOk = false;

            switch (trans)
            {

                case (int)Enums.accionGuardar.Nuevo:
                    isOk = guardar();
                    break;

                case (int)Enums.accionGuardar.Modificar:
                   isOk= modificar();
                    break;

                case (int)Enums.accionGuardar.Eliminar:
                  isOk=  eliminar();
                    break;


            }
            return true;

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
                                Utility.EnableDisableForm(ref gbxMovimientos, false);
                                Utility.ResetForm(ref gbxMovimientos);
                            }
                        }
                    }
                    break;


                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMovimientos, true);
                    txtId.Enabled = true;
                    Utility.ResetForm(ref gbxMovimientos);
                    cboAfectaInv.SelectedIndex = 0;
                    
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;

                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMovimientos, true);
                    txtId.Enabled = false;
                    break;
                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;
                case "Buscar":
                    buscar();
                    if(TipoMovimientoGlobal == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.ResetForm(ref gbxMovimientos);
                        Utility.EnableDisableForm(ref gbxMovimientos, false);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxMovimientos, false);
                    }
                    

              

                    break;
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxMovimientos, false);
                    Utility.ResetForm(ref gbxMovimientos);

                    break;
                case "Salir":
                    this.Close();
                    break;
            }

        }
        private bool buscarDatos(tbTipoMovimiento movimiento)//este es el método que voy a llamar cuandos e ejecuta el evento
        {
            TipoMovimientoGlobal = movimiento;
            if (TipoMovimientoGlobal!=null)
            {
                
                if (TipoMovimientoGlobal.idTipo != 0)
                {
                    txtId.Text = TipoMovimientoGlobal.idTipo.ToString().Trim();
                    txtNombre.Text = TipoMovimientoGlobal.nombre.Trim();
                    txtDescripcion.Text = TipoMovimientoGlobal.descripcion.Trim();
      
                    cboAfectaInv.SelectedIndex = TipoMovimientoGlobal.afecta_conta;


                }
            }
            else
            {

            }
               
            return true;
          
        }
        private void buscar()
        {

            frmBuscarTiposMovimiento buscar = new frmBuscarTiposMovimiento();
            buscar.pasarDatosEvent += buscarDatos;

            buscar.ShowDialog();//muestra el formulario

            //ya esto de abajo no se ocupa porque los datos del formulario hijo se están pasando por medio de un evento
          //  puestoGlobal = frmBuscarTiposMovimiento.puestoGlo;



          /*  if (puestoGlobal.idTipo != 0)
            {
                txtId.Text = puestoGlobal.idTipo.ToString().Trim();
                txtNombre.Text = puestoGlobal.nombre.Trim();
                txtDescripcion.Text = puestoGlobal.descripcion.Trim();
                chkEstado.Checked = puestoGlobal.estado;
                cboAfectaInv.SelectedItem = puestoGlobal.afecta_inv - 1;


            }*/
        }
        private bool validarCampos()
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar el tipo Id");
                txtId.Focus();
                return false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debes de indicar el nombre del tipo de movimiento");
                txtNombre.Focus();
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debes de indicar alguna descripción del tipo de movimiento");
                txtDescripcion.Focus();
                return false;
            }
            if (cboAfectaInv.Text == string.Empty)
            {
                MessageBox.Show("Debes de indicar cómo afecta la contabilidad, si la aumenta  o la disminuye");
                cboAfectaInv.Focus();
                return false;
            }
           
                return true;
        }


      
        private void tlsBtnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
          /*  if(chkEstado.Checked == false)
            {
                MessageBox.Show 
            }*/
        }
    }
}
