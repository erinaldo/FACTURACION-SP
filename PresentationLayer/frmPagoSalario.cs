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
    public partial class frmPagosSalario : Form
    {

        BPagoSalario pagoSalarioIns = new BPagoSalario();
        public static tbPagos GlobalPagoSalario = new tbPagos();
        public static tbEmpleado EmpleadoGlo = new tbEmpleado();
        public BMovimiento MovimientoB = new BMovimiento();
        public static tbMovimientos movimientoGlobal = new tbMovimientos();
        public static List<tbTipoMovimiento> tipoMovimientoGlobal = new List<tbTipoMovimiento>();
        int banderaAux = 0;

        int bandera = 1;


        public frmPagosSalario()
        {
            InitializeComponent();
        }

        private void frmPagosSalario_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
        }
        public tbMovimientos guardarMovimientos()//guardar un nuevo movimiento De pago salarial
        {
            try
            {
                tbMovimientos movimiento = new tbMovimientos();
                BTipoMovimiento tipoMovimientoB = new BTipoMovimiento();
                tipoMovimientoGlobal = tipoMovimientoB.getListTipoMovimiento(3);



                foreach (tbTipoMovimiento u in tipoMovimientoGlobal)
                {
                    if (u.idTipo == (int)Enums.tipoMovimiento.PagoEmpleado)
                    {
                        movimiento.fecha = DateTime.Now;
                        movimiento.estado = true;
                        movimiento.motivo = txtDescripcion.Text;
                        movimiento.total = decimal.Parse(txtTotal.Text);
                        movimiento.idTipoMov =(int)Enums.tipoMovimiento.PagoEmpleado;
                        movimiento.fecha_ult_mod = DateTime.Now;
                        movimiento.fecha_crea = DateTime.Now;
                        movimiento.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                        movimiento.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                        movimientoGlobal = movimiento;
                        return MovimientoB.Guardar(movimiento);
                    
                    }
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }


        }

        private bool ValidarCampos()
        {
            bool Isok = false;
            if(txtIdentificacion.Text==string.Empty)
            {
                MessageBox.Show("Error!!, Seleccione un empleado ");
                btnBuscar.Focus();
                Isok = false;
            }

            else if (txtHoras.Text == string.Empty)
            {
                MessageBox.Show("digite las horas trabajadas por el empleado");
                txtHoras.Focus();
                Isok = false;
            }
            else if (txtHExtras.Text == string.Empty)
            {
                MessageBox.Show("debe ingresar la cantidad de horas extras");
                txtHExtras.Focus();
                Isok = false;
            }
            else
            {
                Isok = true;
            }
            return Isok;
        }
        
        private bool Guardar()
        {
            bool isOk = false;
            tbPagos GuardarPagos = new tbPagos();
            tbEmpleado GuardarDatosEmpleado = new tbEmpleado();
            tbMovimientos mov = guardarMovimientos();
            if (ValidarCampos()&& mov!=null)
            {
                try
                {
                    GuardarPagos.idEmpleado = txtIdentificacion.Text.Trim();
                    GuardarPagos.cantidad_horaExtra = (int.Parse(txtHExtras.Text));
                    GuardarPagos.Cantidad_horas = (int.Parse(txtHoras.Text));
                    GuardarPagos.descripcion = txtDescripcion.Text;
                    GuardarPagos.total = float.Parse(txtTotal.Text);
                    GuardarPagos.fecha_pago = DateTime.Now;
                    GuardarPagos.idMovimiento = mov.idMovimiento;
                    GuardarPagos.tipoId = EmpleadoGlo.tipoId;//guardar el tipo de Id del empleado


                    //// auditoria////

                    GuardarPagos.fecha_crea = DateTime.Now;
                    GuardarPagos.fecha_ult_mod = DateTime.Now;
                    GuardarPagos.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();
                    GuardarPagos.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();

                    pagoSalarioIns.guardar(GuardarPagos);
                    isOk = true;

                }
                catch (SaveEntityException ex)
                {
                    MessageBox.Show(ex.Message);
                    isOk = false;
                }
            }
            return isOk;
            
        }

        private bool modificar()
        {
            bool isOk = false;
            try
            {
                GlobalPagoSalario.descripcion = txtDescripcion.Text;
                GlobalPagoSalario.cantidad_horaExtra = int.Parse(txtHExtras.Text);
                GlobalPagoSalario.Cantidad_horas = int.Parse(txtHoras.Text);
                GlobalPagoSalario.total = int.Parse(txtTotal.Text);
                



                /*   auditoria   */
                GlobalPagoSalario.fecha_ult_mod = DateTime.Now;
                GlobalPagoSalario.fecha_crea = DateTime.Now;
                GlobalPagoSalario.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();
                GlobalPagoSalario.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();

                pagoSalarioIns.Modificar(GlobalPagoSalario);
                isOk = true;
                bool isProcess = isOk;

                if (isOk)
                {
                    MessageBox.Show("los datos fueron modificados correctamente", "atención");
                    isOk = true;
                }
                else
                {
                    MessageBox.Show("no se pudieron Actualizar los datos", "Alerta");
                    isOk = false;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                isOk = false;
            }
            return isOk;// <--- tiene la misma funcion de una bandera
        }

        
        private bool accionGuardar(int trans)
        {
            bool IsOk = false;
            switch (trans)
            {
                case (int)Enums.accionGuardar.Nuevo:
                    IsOk = Guardar();
                    if (IsOk)
                    {
                        MessageBox.Show("Se guardo pago correctamente");
                        banderaAux = 1;
                    }
                    break;

                case (int)Enums.accionGuardar.Modificar:
                    IsOk = modificar();
                    break;

                    //case  (int)Enums.accionGuardar.ELiminar:
                    //    IsOk = Eliminar();
                    //    break;
            }
            return IsOk;
        }
        private void accionMenu(string estado)
        {
            //la bandera funciona para indicar la accion realizada 
            switch (estado)
            {
                case "Guardar":
                    accionGuardar(bandera);
                    if (banderaAux == 1)
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, false);
                        Utility.ResetForm(ref gbxPrimarioPagoSalario);
                        Utility.ResetForm(ref gbxIdentificacion);
                        Utility.ResetForm(ref gbxDatosLaborales);
                        banderaAux = 0;
                    }
                    break;

                case "Nuevo":
                    bandera = (int)Enums.accionGuardar.Nuevo;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, true);
                    Utility.ResetForm(ref gbxPrimarioPagoSalario);
                    gbxPrimarioPagoSalario.Enabled = true;
                    break;

                case "Modificar":
                    bandera = (int)Enums.accionGuardar.Modificar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, true);
                    txtIdentificacion.Enabled = false;
                    break;

                case "Eliminar":
                    bandera = (int)Enums.accionGuardar.Eliminar;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    break;

                case "Buscar":
                        buscar();
                    if (pagoSalarioIns == null)
                    {

                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, false);
                        Utility.ResetForm(ref gbxPrimarioPagoSalario);
                    }
                    else
                    {
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Modificar);
                        Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, false);
                    }
                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, false);
                    Utility.ResetForm(ref gbxPrimarioPagoSalario);
                    Utility.ResetForm(ref gbxDatosLaborales);
                    Utility.ResetForm(ref gbxIdentificacion);
                    break;
                case
                "Salir":
                        this.Close();
                    break;
            }
        }
        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }
 
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            total();
        }
     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
          buscar();
        }

        private void buscar()
        {
            frmBuscarEmpleado buscarEmpleado = new frmBuscarEmpleado();

            //Cargar metodo al evento.-
            buscarEmpleado.pasarDatosEvent += datosBuscar;
            buscarEmpleado.ShowDialog();
        }

        private void datosBuscar(tbEmpleado entity)
        {//enviar los datos al formulario para manipularlos
            try
            {
                EmpleadoGlo = entity;
                if (EmpleadoGlo != null)
                {
                    if (EmpleadoGlo.id != null)
                    {
                        txtIdentificacion.Text = EmpleadoGlo.id.ToString().Trim();
                        txtNombre.Text = EmpleadoGlo.tbPersona.nombre.ToString().Trim();
                        txtPuesto.Text = EmpleadoGlo.tbTipoPuesto.nombre.ToString().Trim();

                        //DATOS DE HORAS LABORADAS
                        txtPrecHoraExt.Text = EmpleadoGlo.tbTipoPuesto.precio_ext.ToString().Trim();
                        txtPrecioHora.Text = EmpleadoGlo.tbTipoPuesto.precio_hora.ToString().Trim();
                    }
                }
                else
                {
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxPrimarioPagoSalario, false);
                    Utility.ResetForm(ref gbxPrimarioPagoSalario);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void total()
        {
            int TotalHoras = 0;//cantidad de horas
            int PrecioH = 0;//precio por hora
            int calculoTotalHExt = 0;
            int totalHrExt = 0;//cantidad de horas extras
            int PrecioHExt = 0;//precio Hr Extra
            int calculoTotalHoras = 0;

            if (txtHExtras.Text == string.Empty)
            {
                if (txtHoras.Text==string.Empty)
                {

                txtHExtras.Text = "0";
                txtPrecHoraExt.Text = "0";
                    txtHoras.Text = "0";
                    txtPrecioHora.Text = "0";
                }
            }
            else
            {
                totalHrExt = int.Parse(txtHExtras.Text);//cantidad de horas Extras
                PrecioHExt = int.Parse(txtPrecHoraExt.Text); //precio por hora extra
                PrecioH = int.Parse(txtPrecioHora.Text);
                TotalHoras = int.Parse(txtHoras.Text);

                calculoTotalHExt = totalHrExt * PrecioHExt;//calculo de hora extra por cantidad de hora extra
                calculoTotalHoras = TotalHoras * PrecioH + calculoTotalHExt;//calculo de hora por cantidad de horas
                txtTotal.Text = calculoTotalHoras.ToString();//calcula toda la operacion anterior y la muestra en el textbox
            }
        }

        private void tlsBtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
