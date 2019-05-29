using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLayer;
using BusinessLayer;
using EntityLayer;
using CommonLayer.Exceptions.BusisnessExceptions;





namespace PresentationLayer
{
    public partial class frmMovimientoDeDinero : Form
    {
        //BMovimientoDeDinero moviDineInst = new BMovimientoDeDinero();
        BMovimiento moviDineInst = new BMovimiento();
        public static tbMovimientos MoviDineGlobal = new tbMovimientos();
        
        public frmMovimientoDeDinero()
        {
            InitializeComponent();
        }          

        private void frmMovimientoDeDinero_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxMovimientoDeDinero, false);
            tlsBtnBuscar.Enabled = false;
        }
        public void accionMenu(string accion)
        {           
           switch (accion)
            {
                case "Guardar":                   
                    guardar();
                    {                 
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxMovimientoDeDinero, false);
                        tlsBtnBuscar.Enabled = false;
                        Utility.ResetForm(ref gbxMovimientoDeDinero);
                    }
                    break;

                case "Nuevo":                    
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMovimientoDeDinero, true);
                    txtId.Enabled = false;
                    dtpFecha.Enabled = false;
                    tlsBtnBuscar.Enabled = false;
                    Utility.ResetForm(ref gbxMovimientoDeDinero);
                    break;
              
                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxMovimientoDeDinero, false);
                    Utility.ResetForm(ref gbxMovimientoDeDinero);
                    tlsBtnBuscar.Enabled = false;
                    break;

                case "Salir":
                    this.Close();
                    break;
            }
        }


        private void tlsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            accionMenu(e.ClickedItem.Text);
        }
      
        private bool guardar()
        {
            
            tbMovimientos movimientoDinero = new tbMovimientos();
            if (validar())
            {
                try
                {
                    movimientoDinero.fecha = Utility.getDate();
                    movimientoDinero.motivo = txtMotivoMov.Text.ToUpper();
                    movimientoDinero.idTipoMov =int.Parse(cbxTipoMovimiento.SelectedItem.ToString().Substring(0,1));
                    movimientoDinero.total =Convert.ToDecimal(txtTotal.Text);

                    //auditoria
                    movimientoDinero.estado = true;
                    movimientoDinero.fecha_crea = Utility.getDate();
                    movimientoDinero.fecha_ult_mod = Utility.getDate();
                    movimientoDinero.usuario_crea = Global.Usuario.nombreUsuario.ToUpper().Trim();
                    movimientoDinero.usuario_ult_mod = Global.Usuario.nombreUsuario.ToUpper().Trim();

                    tbMovimientos tipo = moviDineInst.Guardar(movimientoDinero);
                    txtId.Text = movimientoDinero.idMovimiento.ToString();

                    MessageBox.Show("El movimiento de Dinero se guardado correctamente");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }              
            }
            return true;
        }

        private bool validar()
        {          
           //empty indica quev el campo esta vacio 
            if (txtTotal.Text == string.Empty)
            {
                MessageBox.Show("indique el total de el movimiento a realizar");
                txtTotal.Focus();
                return false;
            }
            if (cbxTipoMovimiento.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un tipo de movimiento");
                cbxTipoMovimiento.Focus();
                return false;
            }

            if (txtMotivoMov.Text == string.Empty)
            {
                MessageBox.Show("indique un motivo del movimento a realizarrrrrr");
                //focus es mara que al validar y haga falta el campo el me coloque el puntero donde falto el dato 
                txtMotivoMov.Focus();
                return false;
            }
            return true;
        }

        private void gbxMovimientoDeDinero_Enter(object sender, EventArgs e)
        {

        }
    }
}
