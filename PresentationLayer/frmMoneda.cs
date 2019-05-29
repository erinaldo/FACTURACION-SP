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
using CommonLayer;
using DataLayer;
using BusinessLayer;
using CommonLayer.Exceptions.BusisnessExceptions;

namespace PresentationLayer
{
    public partial class frmMoneda : Form
    {
        BMoneda BMonedaIns = new BMoneda();
        tbMonedas monedaGlo = new tbMonedas();
        BTipoMoneda tipoMone = new BTipoMoneda();
        int  bandera=1;
        List<tbMonedas>  listaMoneda = new List<tbMonedas>();

        
        public frmMoneda()
        {
            InitializeComponent();
        }

        /// <summary>
        /// guarda los datos de lista
        /// </summary>
        /// <returns></returns>
        private  bool guardar()
        {
            bool isok = false;
            try
             {
                dgvMoneda.Rows.Clear();
                //recorre el grid
                foreach (DataGridViewRow row in dgvMoneda.Rows)
             {
                if (validar())
                {
                        
                    if (row.Cells[0].Value != null)
                    {
                        tbMonedas moneda = new tbMonedas();
                          
                        moneda.moneda = row.Cells[0].Value.ToString();
                        moneda.idTipoMoneda = int.Parse(row.Cells[1].Value.ToString());
                        moneda.estado = true;

                       listaMoneda.Add(moneda);
                        
                      }
                 }
             }
                //manda a guardar la lista
                BMonedaIns.guardarLista(listaMoneda);

                MessageBox.Show("Los datos se guardaron correctamente");
                isok = true;

          }
          
            catch(EntityDisableStateException ex)
            {
                MessageBox.Show(ex.Message);
                isok = false;
            }

            return isok;
        }
        /// <summary>
        /// valida si el tipo de moneda fue ingresado
        /// </summary>
        /// <returns></returns>
        public bool validar()
        {
            if (dgvMoneda.Rows.Count-1 ==0)
            {
                MessageBox.Show("debe de ingresar los datos para tipo de moneda");
                return false;
            }
            return true;
        }

        public void imprimir()
        {
          
           // dgvMoneda.Rows.Clear();
            foreach (tbMonedas moneda in listaMoneda)
            {
                
                DataGridViewRow row = (DataGridViewRow) dgvMoneda.Rows[0].Clone();

                row.Cells[0].Value = moneda.moneda.ToString();
                row.Cells[1].Value = moneda.tbTipoMoneda.nombre.ToString();

                
                dgvMoneda.Rows.Add(row);
            }


        }
        private void frmMoneda_Load(object sender, EventArgs e)
        {
           

            //estatico // dgvColTipoMoneda.Items.Add("dolar");
            MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
            Utility.EnableDisableForm(ref gbxMoneda, false);
            tlsBtnBuscar.Enabled = false;
            dgvMoneda.Enabled = false;

            //carga el combo tipoMoneda
        
            dgvColTipoMoneda.DataSource = tipoMone.GetListTipoMoneda(1);           
            dgvColTipoMoneda.DisplayMember = "nombre";
            dgvColTipoMoneda.ValueMember = "id";
            //dgvMoneda.Rows.Clear();
          
            ///monedas
            listaMoneda = BMonedaIns.GetListEntities(1);
            imprimir();



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

        public void accionMenu(string accion)
        {
            switch (accion)
            {
                case "Guardar":
                    if (validar())
                    {
                        guardar();
                        MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Nuevo);
                        Utility.EnableDisableForm(ref gbxMoneda,true);
                      //  Utility.ResetForm(ref gbxMoneda);
                   
                        tlsBtnBuscar.Enabled = false;
                    }
                    break;

                case "Nuevo":

                    bandera = 1;
                    MenuGenerico.CambioEstadoMenu(ref tlsMenu, (int)EnumMenu.OpcionMenu.Guardar);
                    Utility.EnableDisableForm(ref gbxMoneda, true);
                    //Utility.ResetForm(ref gbxMoneda);
                    dgvMoneda.Enabled = true;
                    tlsBtnBuscar.Enabled = false;
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


    }
}
