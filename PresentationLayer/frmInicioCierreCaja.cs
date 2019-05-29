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
using BusinessLayer;
using CommonLayer.Exceptions.DataExceptions;
using CommonLayer.Exceptions;
using CommonLayer;

namespace PresentationLayer
{
    public partial class frmInicioCierreCaja : Form
    {
        tbCajaUsuMonedas cajaUsuMOneGlobal = new tbCajaUsuMonedas();
        tbCajaUsuario cajaUsuarioGlobal = new tbCajaUsuario();
        BCajaUsuarioMonedas BCajaUsuMonedasIns = new BCajaUsuarioMonedas();
        BCajaUsuario bCajaUsuarioIns = new BCajaUsuario();
        tbCajaUsuario usuarioGlobal = new tbCajaUsuario();
        tbCajaUsuario usuarioGlobal2 = new tbCajaUsuario();
        List<tbMonedas> ListaMonedasGlobal = new List<tbMonedas>();
        int cantidad = 0;
        int subtotal = 0;
        private static List<DataGridViewRow> listaDataGridMonedas = new List<DataGridViewRow>();//Lista para DataGridView

        public frmInicioCierreCaja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicioCierreCaja_Load(object sender, EventArgs e)
        {
           
            try
            {
                txtIdCaja.Text = Global.NumeroCaja.ToString();//Numero de caja en txtIdCaja
                txtIdUsuario.Text = Global.Usuario.nombreUsuario;//Nombre de Usuario en txtIsUsuario
                ListaMonedasGlobal = BCajaUsuMonedasIns.getListMonedas();
                cargarDatagridView(ListaMonedasGlobal);//Carga el datagrid view
                cajaUsuarioGlobal.fecha = Utility.GetDateByDay();
                usuarioGlobal2.idCaja = Global.NumeroCaja;
                //busca una celda que contenga fecha de hoy con id de caja usada
                tbCajaUsuario cajaUsuFecha = bCajaUsuarioIns.GetFechaCajaUsuario(cajaUsuarioGlobal, usuarioGlobal2);
                usuarioGlobal.idUser = Global.Usuario.id;
                //método para conseguir una celda de un registro que coincida con usuario y caja
                tbCajaUsuario usuario = bCajaUsuarioIns.GetUsuario(usuarioGlobal, usuarioGlobal2);
                if ((cajaUsuFecha == null && usuario == null) || (cajaUsuFecha == null && usuario != null))
                {   
                    //si es nulo es por que no hay fecha con usuario(Inicio de caja)
                    cboTipoMovimientoCaja.Text = cboTipoMovimientoCaja.Items[0].ToString();

                }
                else if (cajaUsuFecha != null && usuario != null)
                {

                    //Cierre de caja
                    cboTipoMovimientoCaja.Text = cboTipoMovimientoCaja.Items[1].ToString();

                }
                else if (usuario == null && cajaUsuFecha != null)
                {   
                    //Encuentra fecha pero no usuario(usuario diferente)
                    dgvMonedas.Visible = false;
                    btnGuardar.Visible = false;
                    MessageBox.Show("Error, logueate con el mismo nombre de usuario del inicio de caja");
                    this.Close();
                }
            }
            catch(InvalidOperationException ex)//excepcion implementada al haber más de dos entidades en el metodo GET
            {
                MessageBox.Show("Ya hay un Inicio y Cierre de caja de hoy "+ DateTime.Today.ToShortDateString()+
                    " en caja número " + Global.NumeroCaja);
                this.Close();
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        public void cargarDatagridView(List<tbMonedas> lista)

        {
            int monedas;
            dgvMonedas.Rows.Clear();
            foreach (tbMonedas moneda in lista)
            {
                DataGridViewRow row = (DataGridViewRow)dgvMonedas.Rows[0].Clone();
                row.Cells[0].Value = moneda.moneda;
                row.Cells[3].Value = moneda.idMoneda.ToString();
                monedas = int.Parse(row.Cells[0].Value.ToString());
   
                dgvMonedas.Rows.Add(row);
            }

        }
        public void guardarCajaUsuario()
        {
            tbCajaUsuMonedas cajaUsuMoneda;
            tbCajaUsuario CajaUsuario = new tbCajaUsuario();

            ICollection<tbCajaUsuMonedas> listaCajaUsuMone = new List<tbCajaUsuMonedas>();


            try
            {
                CajaUsuario.idCaja = Global.NumeroCaja;
                CajaUsuario.idUser = Global.Usuario.id;
                CajaUsuario.tipoId = Global.Usuario.tipoId;
                CajaUsuario.tipoMovCaja = int.Parse(cboTipoMovimientoCaja.Text.ToString().Substring(0,1));
                CajaUsuario.fecha = Utility.GetDateByDay();
                CajaUsuario.total = int.Parse(txtTotal.Text);

                CajaUsuario.fecha_crea = Utility.getDate();
                CajaUsuario.fecha_ult_mod = Utility.getDate();
                CajaUsuario.usuario_crea = Global.Usuario.nombreUsuario;
                CajaUsuario.usuario_ult_mod = Global.Usuario.nombreUsuario;                
               
                foreach(DataGridViewRow row  in dgvMonedas.Rows)//Guarda valores para TbCajaUsuMonedas
                {
                    if(row.Cells[0].Value != null)
                    {
                        if (row.Cells[3].Value != null)
                        {
                            
                            if (row.Cells[2].Value != null)//si hay un id de moneda
                            {
                                cajaUsuMoneda = new tbCajaUsuMonedas();
                                //cajaUsuMoneda.idMoneda = int.Parse(row.Cells[3].Value.ToString());
                                //cajaUsuMoneda.subtotal = int.Parse(row.Cells[2].Value.ToString());
                                //cajaUsuMoneda.cantidad = int.Parse(row.Cells[1].Value.ToString());
                                cajaUsuMoneda.idCajaUsuario = CajaUsuario.id;
                                listaCajaUsuMone.Add(cajaUsuMoneda);
                            }
                           
                        }
                        
                        
                    }
                    
                }
                


                CajaUsuario.tbCajaUsuMonedas = listaCajaUsuMone;//guardo la tabla cajaUsoMonedas (Collection)
                bCajaUsuarioIns.Guardar(CajaUsuario);
              // BCajaUsuMonedasIns.guardarListaCajaUsuarioMoneda(listaCajaUsuMone);
                

                MessageBox.Show("Caja guardada correctamente");
                this.Close();
            

            }
            
            catch(SaveEntityException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void enableDisableForm(bool estado)
        {

        }

        private void dgvMonedas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void dgvMonedas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //evento para controlar el momento en que cambia un valor en el DGV
            int monedas = 0;
            int suma = 0;
            
            try
            {   
                
                if (dgvMonedas.Columns[e.ColumnIndex].Name == "colCantidad")
                {
                   if (dgvMonedas.Rows[e.RowIndex].Cells[0].Value != null)
                   {

                        if (dgvMonedas.Rows[e.RowIndex].Cells[1].Value != null)
                        {
                          
                                cantidad = int.Parse(dgvMonedas.Rows[e.RowIndex].Cells[1].Value.ToString());
                                monedas = int.Parse(dgvMonedas.Rows[e.RowIndex].Cells[0].Value.ToString());
                                subtotal = cantidad * monedas;
                                dgvMonedas.Rows[e.RowIndex].Cells[2].Value = subtotal;                  
                        }
                        
                   }                  


                }

                foreach (DataGridViewRow row in dgvMonedas.Rows)
                {
                    if(row.Cells[2].Value != null)
                    {
                        suma += int.Parse(row.Cells[2].Value.ToString());
                    }
                    
                }
                txtTotal.Text = suma.ToString();

            }
            catch ( IsNotANumberException ex)//esto no sirve
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCajaUsuario();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtIdUsuario.Text = Global.Usuario.nombreUsuario;
        }

        private void txtIdCaja_TextChanged(object sender, EventArgs e)
        {
            txtIdCaja.Text = Global.NumeroCaja.ToString();
        }

        //valida que sólo se ingresen números
        private void dgvMonedas_KeyPress(object sender, KeyPressEventArgs e)
        {       
            
            if (dgvMonedas.Columns[1].Name == "colCantidad")
            {
                if (Char.IsNumber(e.KeyChar))//si la tecla precionada es un número
                {
                    e.Handled = false;//se habilita la digitacion
                }
                else if (Char.IsControl(e.KeyChar))//si la tecla precionada es una tecla de control(ejemplo delete)
                {
                    e.Handled = false;
                }
                //else if(Char.IsSeparator(e.KeyChar))
                //{
                //    e.Handled = false;
                //}
                else
                {
                    e.Handled = true; //desabilitamos lo que el usuario teclee
                }
            }
               
        }

      

       
    }
}
