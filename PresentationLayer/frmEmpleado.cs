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
using EntityLayer;
using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace PresentationLayer
{
    public partial class frmEmpleado : Form
    {
        BEmpleado empleadoIns = new BEmpleado();
        BPuesto BPuestos = new BPuesto();
        BTipoId tipoIdIns = new BTipoId();

        //   bool banderaValida;
        int bandera = 1;
        public static tbEmpleado empleadosGlo = new tbEmpleado();


        public frmEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// manda a guardar los datos
        /// </summary>
        /// <returns></returns>
        private bool guardar()        
        {
           bool isOK = false;
            if (validarCampos())
            {
                tbEmpleado empleado = new tbEmpleado();
                tbPersona persona = new tbPersona();
                //banderaValida = true;

                try
                {
                    persona.tipoId = (int)cbotipoId.SelectedValue;
                    if (persona.tipoId == (byte)Enums.TipoId.Fisica)
                    {
                        persona.identificacion = mskId.Text.Trim();
                    }
                    //else
                    //{
                    //    persona.identificacion = txtId.Text.Trim();
                    //}
                    persona.nombre = txtNombre.Text.Trim().ToUpper();
                    persona.apellido1 = txtApellido1.Text.Trim().ToUpper();
                    persona.apellido2 = txtApellido2.Text.Trim().ToUpper();
                    persona.fechaNac = dtpFechaNac.Value;
                    persona.telefono = int.Parse(mskTelefono.Text);
                    persona.codigoPaisTel = "506";
                    persona.correoElectronico = txtCorreo.Text;
                    if (rbtmasc.Checked == true)
                    {
                        persona.sexo = 1;
                    }
                    else if (rbtfem.Checked == true)
                    {
                        persona.sexo = 2;
                    }

                    empleado.tipoId = persona.tipoId;
                    empleado.id = persona.identificacion;
                    empleado.fecha_ingreso = dtpFecha_Ingreso.Value;
                     empleado.idPuesto = (int)cbxPustTrab.SelectedValue;
                    

                    empleado.estado = true;
                    empleado.fecha_ult_mod = Utility.getDate();
                    empleado.fecha_crea = Utility.getDate();
                    empleado.usuario_crea = Global.Usuario.nombreUsuario;
                    empleado.usuario_ult_crea = Global.Usuario.nombreUsuario;
                    empleado.tbPersona = persona;
                    empleado.direccion = txtDireccion.Text;
                    empleado.esContraDefinido = !chkContradoFin.Checked;
                    if (empleado.esContraDefinido)
                    {

                        empleado.fecha_salida = dtpFecha_Salida.Value;

                    }
                    else {
                        empleado.fecha_salida = null;
                    }

                    tbEmpleado empleados = empleadoIns.guardar(empleado);
                    isOK = true;
                    // txtId.Text = empleado.idPuesto.ToString();
                    MessageBox.Show("Los datos han sido almacenada en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                  catch (EntityExistException ex)
                  {
                    MessageBox.Show(ex.Message);
                    isOK = false;

                  }
                  catch (EntityDisableStateException ex)
                  {
                    DialogResult result = MessageBox.Show("Datos ya existe en la base datos, ¿Desea actualizarlos?", "Datos Existentes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                  {
                      empleadosGlo = empleado;
                     isOK=  modificar();
                     

                  }
                    else
                    {
                        isOK = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    isOK = false;
                }
                 
            }
            else {

                isOK = false;

            }
            return  isOK;
        }

        /// <summary>
        /// valida los campos
        /// </summary>
        /// <returns></returns>
        private bool validarCampos()
        {
            if (cbotipoId.SelectedValue != null)
            {
                if ((int)cbotipoId.SelectedValue == (int)Enums.TipoId.Juridica) {
                    MessageBox.Show("No puede indicar un empleado con tipo de indentidad Jurídica");
                    cbotipoId.Focus();
                    return false;
                }
            }
           



            if (cbotipoId.Text == string.Empty)
            {
                MessageBox.Show("Debe de indicar el tipo de identidad");
                cbotipoId.Focus();
                return false;
            }

            if ((int)cbotipoId.SelectedValue==(int)Enums.TipoId.Fisica)
            {
                if (mskId.Text == string.Empty)
                {
                    MessageBox.Show("Debe de indicar el numero de idenficación");
                    mskId.Focus();
                    return false;
                }
            }
            else
            {

                //if (txtId.Text == string.Empty)
                //{
                //    MessageBox.Show("Debe de indicar un numero de idenficación");
                //    txtId.Focus();
                //    return false;
                //}
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe de indicar un Nombre");
                txtNombre.Focus();
                return false;
            }
            if (cbxPustTrab.Text == string.Empty)
            {
                MessageBox.Show("Debe de indicar un puesto de trabajo");
                cbxPustTrab.Focus();
                return false;
            }
            if (txtApellido1.Text == string.Empty)
            {
                MessageBox.Show("Debe de indicar un apellido");
                txtApellido1.Focus();
                return false;
            }

            if (txtApellido2.Text == string.Empty)
            {
                MessageBox.Show("Debe de indicar un segundo apellido");
                txtApellido2.Focus();
                return false;
            }

            if (mskTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe de indicar un numero de Telefono");
                mskTelefono.Focus();
                return false;
            }


            return true;
        }

        
        private void datosBuscar(tbEmpleado empleado)
        {
            try
            {
                empleadosGlo = empleado;
                if (empleadosGlo != null)
                {

                    if (empleadosGlo.id != null)
                    {
                        cbotipoId.Text = empleadosGlo.tipoId.ToString().Trim().ToUpper();
                        //txtId.Text = empleadosGlo.id.ToString().Trim();
                        mskId.Text = empleadosGlo.id.ToString().Trim();
                        txtNombre.Text = empleadosGlo.tbPersona.nombre.Trim().ToUpper();
                        txtApellido1.Text = empleadosGlo.tbPersona.apellido1.Trim().ToUpper();
                        txtApellido2.Text = empleadosGlo.tbPersona.apellido2.Trim().ToUpper();
                        mskTelefono.Text = empleadosGlo.tbPersona.telefono.ToString().Trim().ToUpper();
                        cbxPustTrab.Text = empleadosGlo.tbTipoPuesto.nombre;
                        dtpFechaNac.Value = empleadosGlo.tbPersona.fechaNac.Value;
                        txtCorreo.Text = empleadosGlo.tbPersona.correoElectronico;
                        txtDireccion.Text = empleadosGlo.direccion;
                        dtpFecha_Ingreso.Value = empleadosGlo.fecha_ingreso;
                        chkContradoFin.Checked = !empleadosGlo.esContraDefinido;
                        if (empleadosGlo.esContraDefinido)
                        {
                            dtpFecha_Salida.Value = empleadosGlo.fecha_salida.Value;
                            
                        }
                        else {

                            dtpFecha_Salida.Value = DateTimePicker.MinimumDateTime;
                        }
                      
                        if (empleadosGlo.tbPersona.sexo == 1)
                        {

                            rbtfem.Checked = false;
                            rbtmasc.Checked = true;

                        }
                        else {

                            rbtfem.Checked = true;
                            rbtmasc.Checked = false;
                        }

                    }
                }
                else
                {
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxEmpleados, false);
                    Utility.ResetForm(ref gbxEmpleados);

                }
            }
          
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Buscar()
          {
            frmBuscarEmpleado buscar = new frmBuscarEmpleado();
            buscar.pasarDatosEvent += datosBuscar;
            buscar.ShowDialog();
            //empleadosGlo = FrmBuscarEmpleado.empleadoGlo;

         }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            validarCampos();
            modificar();
            
        }
        /// <summary>
        /// manda a modificar a la base de datos
        /// </summary>
        /// <returns></returns>
        private bool modificar()
        {
            bool isOK = false;
            try
            {
      
                empleadosGlo.tbPersona.nombre = txtNombre.Text.ToUpper().Trim();
                empleadosGlo.tbPersona.apellido1 = txtApellido1.Text.ToUpper().Trim();
                empleadosGlo.tbPersona.apellido2 = txtApellido2.Text.ToUpper().Trim();
                empleadosGlo.tbPersona.telefono = int.Parse(mskTelefono.Text);
                empleadosGlo.tbPersona.correoElectronico = txtCorreo.Text;
                empleadosGlo.idPuesto =(int)cbxPustTrab.SelectedValue;
                empleadosGlo.tbTipoPuesto = null;
      
                empleadosGlo.direccion = txtDireccion.Text;
                if (rbtmasc.Checked == true)
                {
                    empleadosGlo.tbPersona.sexo = 1;
                }
                else if (rbtfem.Checked == true)
                {
                    empleadosGlo.tbPersona.sexo = 2;
                }


                empleadosGlo.fecha_ult_mod = Utility.getDate();
                empleadosGlo.usuario_ult_crea = Global.Usuario.nombreUsuario;
                empleadosGlo.fecha_salida = dtpFecha_Salida.Value;
            
                empleadoIns.modificar(empleadosGlo);
                isOK = true;
                MessageBox.Show("Los datos han sido actualizados en la base de datos.", "Actualización.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)                                                                                                            
            {
                MessageBox.Show("Ha ocurrido un error. Comuniquese con el administrador " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isOK = false;
            }
            return isOK;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        /// <summary>
        /// manda a eliminar a la base de datos
        /// </summary>
        /// <returns></returns>
        private bool eliminar()
        {
            bool isOk = false;
            try 
            {
                DialogResult result = MessageBox.Show("¿Se encuentra seguro de eliminar los datos?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
              
                empleadosGlo.estado = false;
                empleadosGlo.usuario_ult_crea = Global.Usuario.nombreUsuario;
                empleadosGlo.fecha_ult_mod = Utility.getDate();
                tbEmpleado empleado = empleadoIns.eliminar(empleadosGlo);
                isOk = true;
                    MessageBox.Show("Los datos han sido eliminados de la base datos.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (UpdateEntityException ex)
            {

                MessageBox.Show(ex.Message);
                isOk = false;
            }
            return isOk;
        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxEmpleados, false);

  
            cargarCombos();
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            dtpFechaNac.Enabled = false;

        }
        /// <summary>
        /// carga el combo para tipo puesto
        /// </summary>
        private void cargarCombos()
        {

            cbotipoId.ValueMember = "id";
            cbotipoId.DisplayMember = "nombre";
            cbotipoId.DataSource = tipoIdIns.getListaTipoId();

            cbxPustTrab.DisplayMember = "nombre";
            cbxPustTrab.ValueMember = "idTipoPuesto";
            cbxPustTrab.DataSource = BPuestos.getlistEntities((int)Enums.EstadoBusqueda.Activo);
        }

        private bool guardar(int trans)
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
            return isOk;
        }

        private void accionMenu(string accion)
        {
            switch (accion)
            {
                case "Guardar":

                    if(guardar(bandera)==true)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxEmpleados, false);
                        Utility.ResetForm(ref gbxEmpleados);
                        rbtfem.Checked = false;
                        rbtmasc.Checked = true;

                    }
   
                    break;

                case "Nuevo":
                    
                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                   Utility.EnableDisableForm(ref gbxEmpleados, true);


                    Utility.ResetForm(ref gbxEmpleados);
                    cbotipoId.SelectedIndex = 0;
                    cbotipoId.Enabled = false;

                    mskId.Enabled = true;
                    rbtfem.Checked = false;
                    rbtmasc.Checked = true;
                    break;

                case "Modificar":
                    bandera = 2;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxEmpleados, true);
                   // txtId.Enabled = false;
                    mskId.Enabled = false;
                    cbotipoId.Enabled = false;
                    if (chkContradoFin.Checked)
                    {
                        dtpFecha_Salida.Enabled = false;

                    }
                    else {
                        dtpFecha_Salida.Enabled = true;

                    }
                   // banderaValida = true;
                    break;

                case "Eliminar":
                    bandera = 3;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    // banderaValida = true;
                    mskId.Enabled = false;
                    cbotipoId.Enabled = false;
                    break;

                case "Buscar":
                    Buscar();
                    if (empleadosGlo == null)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxEmpleados, false);
                        // banderaValida = true;
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxEmpleados, false);
                    }
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxEmpleados, false);
                    Utility.ResetForm(ref gbxEmpleados);
                    rbtfem.Checked = false;
                    rbtmasc.Checked = true;
                    // banderaValida = true;
                    break;

                case "Salir":
                    this.Close();
                    break;
            }
        }

        private void tlsMenu_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }
      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado buscar = new frmBuscarEmpleado();
            buscar.ShowDialog();
           // empleadosGlo = FrmBuscarEmpleado.empleadoGlo;

            if (empleadosGlo.id !=null)
            {

                //if(Convert.ToByte(cbotipoId.Text.Substring(0,1)) == (byte)Enums.TipoId.fisica)
                //{ 

                //txtId.Text = empleadosGlo.id.ToString().Trim();
                //}
                //else if(Convert.ToByte(cbotipoId.Text.Substring(0, 1)) == (byte)Enums.TipoId.dimex)
                //{
                //    mskId.Text = empleadosGlo.id.ToString().Trim();
                //}
                mskId.Text = empleadosGlo.id.ToString().Trim();
                cbxPustTrab.Text = empleadosGlo.idPuesto.ToString();
                txtNombre.Text = empleadosGlo.tbPersona.nombre;
                mskTelefono.Text = empleadosGlo.tbPersona.telefono.ToString();
                txtDireccion.Text = empleadosGlo.direccion;
                txtCorreo.Text = empleadosGlo.tbPersona.correoElectronico;
                if (empleadosGlo.tbPersona.sexo == 1)
                {
                    rbtmasc.Checked = true;
                    rbtfem.Checked = false;
                }
                else {
                    rbtmasc.Checked = false;
                    rbtfem.Checked = true;

                }


            }
        }
        private void cambiarTiposId()
        {
            if (cbotipoId.SelectedValue != null)
            {
                if ((int)cbotipoId.SelectedValue == (int)Enums.TipoId.Juridica)
                {
                    

                    txtApellido1.Enabled = false;
                    txtApellido2.Enabled = false;
                    dtpFechaNac.Enabled = false;
                    gboSexo.Enabled = false;
                    mskId.Visible = false;
                    //txtId.Visible = true;
                    //txtId.Enabled = true;


                }
                else
                {
                    mskId.Enabled = true;
                    mskId.Visible = true;
                    mskId.Visible = true;
                    txtApellido1.Enabled = true;
                    txtApellido2.Enabled = true;
                    dtpFechaNac.Enabled = true;
                    gboSexo.Enabled = true;
                }

            }
        }
        private void cboTipoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //valida los dato de la mascara
            cambiarTiposId();
        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContradoFin.Checked)
            {
                dtpFecha_Salida.Enabled = false;               

            }
            else {

                dtpFecha_Salida.Enabled = true;
            }
        }

        private void gbxEmpleados_Enter(object sender, EventArgs e)
        {

        }

        private void cbxPustTrab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
