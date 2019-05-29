using BusinessLayer;
using CommonLayer;
using CommonLayer.Exceptions.BusisnessExceptions;
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
    public partial class frmMoneda2 : Form
    {

        BMoneda BMonedaIns = new BMoneda();
        tbMonedas monedaGlo = new tbMonedas();
        BTipoMoneda tipoMone = new BTipoMoneda();
        int bandera = 1;
        List<tbMonedas> listaMoneda = new List<tbMonedas>();
        bool banderaExistMoneda = false;

        public frmMoneda2()
        {
            InitializeComponent();
        }
        private bool guardar()
        {
            bool isok = false;
            try
            {

                BMonedaIns.guardarLista(listaMoneda);
                cargarLista((int)cboTipoMoneda.SelectedValue);

                MessageBox.Show("Los datos se guardaron correctamente");
                isok = true;

            }

            catch (EntityDisableStateException ex)
            {
                MessageBox.Show(ex.Message);
                isok = false;
            }

            return isok;
        }

        private bool accionGuardar(int trans)
        {
            bool IsOk = false;
            switch (trans)
            {
                case 1:
                    IsOk = guardar();
                    break;

            }
            return IsOk;
        }
        public bool validar()
        {

            return true;
        }
        public void accionMenu(string accion)
        {
            switch (accion)
            {
                case "Guardar":
                    if (validar())
                    {
                        guardar();
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxMoneda, true);
                        //  Utility.ResetForm(ref gbxMoneda);
                        txtValor.Text = string.Empty;
                        tlsBtnBuscar.Enabled = false;
                        gbxMoneda.Enabled = false;
                    }
                    break;

                case "Nuevo":

                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMoneda, true);
                    //Utility.ResetForm(ref gbxMoneda);
                    txtValor.Text = string.Empty;
                    tlsBtnBuscar.Enabled = false;
                    gbxMoneda.Enabled = true;
                    break;

                case "Modificar":
                    bandera = 2;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMoneda, true);

                    break;

                case "Eliminar":
                    bandera = 3;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);

                    break;

                case "Buscar":
                    tlsBtnBuscar.Enabled = false;
                    //MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    //Utility.EnableDisableForm(ref gbxMoneda, false);

                    break;

                case "Cancelar":
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                    Utility.EnableDisableForm(ref gbxMoneda, false);
                    Utility.ResetForm(ref gbxMoneda);
                    tlsBtnBuscar.Enabled = false;
                    txtValor.Text = string.Empty;
                    gbxMoneda.Enabled = false;
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

        private void frmMoneda2_Load(object sender, EventArgs e)
        {
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxMoneda, false);
            cargarCombos();
        }

        private void cargarCombos()
        {


            cboTipoMoneda.DataSource = tipoMone.GetListTipoMoneda((int)Enums.EstadoBusqueda.Activo);
            cboTipoMoneda.ValueMember = "id";
            cboTipoMoneda.DisplayMember = "nombre";



        }
        private void cargarLista(int idTipoMoneda)
        {

            listaMoneda.Clear();


            listaMoneda = BMonedaIns.GetListEntities((int)Enums.EstadoBusqueda.Todos, idTipoMoneda);
            cargarLista(listaMoneda);

        }
        private void cargarLista(List<tbMonedas> lista)
        {


            lstvMonedas.Items.Clear();
            foreach (tbMonedas moneda in lista)
            {
                if (moneda.estado)
                {
                   
                    string[] row = { moneda.moneda.Trim() };
                    var listViewItem = new ListViewItem(row);
                    lstvMonedas.Items.Add(listViewItem);
                    moneda.estado = true;
               
                }
            }






        }
        private void cboTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoMoneda_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarLista((int)cboTipoMoneda.SelectedValue);
            }
            catch { }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            banderaExistMoneda = false;
            if (!existValor())
            {
                if (!banderaExistMoneda) {

                    string[] row = { txtValor.Text.Trim() };
                    var listViewItem = new ListViewItem(row);
                    lstvMonedas.Items.Add(listViewItem);



                    tbMonedas moneda = new tbMonedas();
                    moneda.moneda = txtValor.Text.Trim();
                    moneda.idTipoMoneda =(int) cboTipoMoneda.SelectedValue;
                    moneda.estado = true;
                    listaMoneda.Add(moneda);




                }
               


            }
            else
            {

                MessageBox.Show("El valor ya se enuentra registrador para ese tipo de moneda.");

            }
        }



        private bool existValor()
        {
            if (txtValor.Text.Trim() != "")
            {

                foreach (tbMonedas item in listaMoneda)
                {

                    if (item.moneda.Trim().Equals(txtValor.Text.Trim()))
                    {
                        if (item.estado == false)
                        {


                            DialogResult ok = MessageBox.Show("Este valor ha sido ingresado, pero se encuentra deshabilitado, desea activarlo?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                            if (ok == DialogResult.Yes)
                            {


                                item.estado = true;
                                banderaExistMoneda = true;
                                
                            }

                            return false;
                        }

                        return true;
                    }


                }
            }
            return false;


        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem eachItem in lstvMonedas.SelectedItems)
            {


                foreach (tbMonedas mon in listaMoneda)
                {

                    if (mon.moneda.Trim() == eachItem.Text.Trim())
                    {

                        mon.estado = false;
                      
                        break;

                    }
                }
             


            }
            cargarLista(listaMoneda);
        }



    

    }
 }
