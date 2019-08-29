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
using CommonLayer.Exceptions.BusisnessExceptions;
using CommonLayer.Exceptions.DataExceptions;
using DataLayer;


namespace PresentationLayer
{
    public partial class frmAbonoCredito : Form
    {

        public tbClientes clienteGlobal = new tbClientes();//para buscar clientes
        public BFacturacion facturacionB = new BFacturacion();
        IEnumerable<tbDocumento> docsGlobal;
        List<tbDocumento> docsModificados = new List<tbDocumento>();
      List<tbAbonos> abonosModificados = new List<tbAbonos>();
        Bcliente clienteB = new Bcliente();
        


        public frmAbonoCredito()
        {
            InitializeComponent();
        }
        private void frmCredito_Load(object sender, EventArgs e)///load
        {
            chkImprimir.Checked = (bool)Global.Usuario.tbEmpresa.imprimeDoc;
            chkImprimir.Visible= (bool)Global.Usuario.tbEmpresa.imprimeDoc;
        }




        //metodo para buscar clientes
        private void dataBuscar(tbClientes cliente)
        {
           
            clienteGlobal = cliente;            
        
              if ( clienteGlobal !=null && clienteGlobal.id.Trim() != null )//antes tenia cero pero como es string se pone null
            {
                txtIdCliente.Text = cliente.id.Trim();
                if (cliente.tipoId == 1)
                {
                    txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper() + " " + cliente.tbPersona.apellido1.Trim().ToUpper() + " " + cliente.tbPersona.apellido2.Trim().ToUpper();

                }
                else
                {
                    txtCliente.Text = cliente.tbPersona.nombre.Trim().ToUpper();

                }

                txtDireccion.Text = cliente.tbPersona.otrasSenas.Trim().ToUpper();
                txtTel.Text = cliente.tbPersona.telefono.ToString().Trim().ToUpper();
                txtCorreo.Text = cliente.tbPersona.correoElectronico.Trim();

                cargarCreditos();
            }
            else
            {
                limpiarForm();
            }

        }

        private void cargarCreditos()
        {
            try
            {
                lsvFacturas.Items.Clear();
                IEnumerable<tbDocumento> docs = facturacionB.getListDocCreditoPendienteByCliente(clienteGlobal.tipoId, clienteGlobal.id);

                docsGlobal = docs;

                decimal mnontoGeneral = 0;
                decimal adeudadoGeneral = 0;
                foreach (tbDocumento item in docs)
                {

                    //Creamos un objeto de tipo ListviewItem
                    ListViewItem linea = new ListViewItem();
                    //CheckBox chk = new CheckBox();
                    //linea.ImageIndext4r+= chk;
                    linea.SubItems.Add(item.id.ToString());
                    linea.SubItems.Add(item.fecha.ToString());
                    linea.SubItems.Add(item.consecutivo.Trim());
                    decimal monto = 0;
                    foreach (var detalle in item.tbDetalleDocumento)
                    {
                        monto += detalle.totalLinea;
                    }
                    mnontoGeneral += monto;
                    decimal abonos = 0;
                    foreach (var abono in item.tbAbonos)
                    {
                        abonos += (decimal)abono.monto;
                    }
                    adeudadoGeneral += monto - abonos;

                    linea.SubItems.Add(monto.ToString());
                    linea.SubItems.Add((monto - abonos).ToString());

                    //Agregamos el item a la lista.
                    double daysPlazo = double.Parse(item.plazo.ToString());
                    DateTime fechaVenc = item.fecha.AddDays(daysPlazo);

                    linea.SubItems.Add(fechaVenc.ToString());
                    if (fechaVenc < Utility.getDate())
                    {
                        linea.ForeColor = Color.Red;
                    }
                    lsvFacturas.Items.Add(linea);

                }
                txtAdeudado.Text = adeudadoGeneral.ToString();
                txtFacturado.Text = mnontoGeneral.ToString();

            }
            catch (Exception)
            {

                           MessageBox.Show("El dato al cargar los créditos.", "Cargar Créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }

            
        }

        //funcion que abre formulario de busqueda y asigna metodos a un evento
        private void buscar()
        {
            FrmBuscar buscar = new FrmBuscar();
            buscar.pasarDatosEvent += dataBuscar;
            buscar.ShowDialog();
        }

        //permiten agregar tablas a las lista y evitar ir a base de datos
      
        //boton que al clickearlo limpia los listview y va al metodo buscar() que abre form de busqueda personas
       


        //Metodos para cargar lista de abonos y lista de creditos
       

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar los datos del cliente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void limpiarForm()
        {

            clienteGlobal = null;
            lsvFacturas.Items.Clear();
            txtIdCliente.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtAdeudado.Text = string.Empty;
            txtAbono.Text = string.Empty;
            txtFacturado.Text = string.Empty;
            chkTodos.Checked = false;

            clienteGlobal = null;
            docsGlobal = null;
            docsModificados.Clear();
            abonosModificados.Clear();


        }
        private void cargarDatosCliente() {

            try
            {

                clienteGlobal = clienteB.GetListEntities(1).Where(x=>x.id==clienteGlobal.id && x.tipoId==clienteGlobal.tipoId).SingleOrDefault();
                dataBuscar(clienteGlobal);
            }
            catch (Exception)
            {

                throw;
            }


        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               DialogResult resp= MessageBox.Show($"Esta seguro que desea realizar el abono por el MONTO: {txtAbono.Text} al CLIENTE: { txtIdCliente.Text}-{txtCliente.Text }", "Aplicar abono", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp==DialogResult.Yes)
                {

                    docsModificados.Clear();
                    if (Utility.isNumeroDecimal(txtAbono.Text) && txtAbono.Text != string.Empty)
                    {
                        decimal montoAdeudado = decimal.Parse(txtAdeudado.Text);
                        decimal montoAbono = decimal.Parse(txtAbono.Text);

                        if ((montoAdeudado - montoAbono) >= 0)
                        {
                            foreach (tbDocumento doc in docsGlobal)
                            {
                                abonosModificados.Clear();
                                 decimal abono = (decimal)doc.tbAbonos.Sum(x => x.monto);
                                decimal totalFact = (decimal)doc.tbDetalleDocumento.Sum(x => x.totalLinea);
                                decimal adeudadoFact = 0;

                                //calculo el total adeudado actual
                                adeudadoFact = totalFact - abono;


                                tbAbonos abonoE = new tbAbonos();
                                abonoE.idDoc = doc.id;
                                abonoE.tipoDoc = doc.tipoDocumento;
                                abonoE.estado = true;
                                abonoE.fecha_crea = Utility.getDate();
                                abonoE.fecha_ult_mod = Utility.getDate();
                                abonoE.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
                                abonoE.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

                                //verifica si el abono es mayor a lo adeudado, para poner en 0 y cancelar la factura
                                if (montoAbono >= adeudadoFact)
                                {

                                    abonoE.monto = adeudadoFact;
                                    doc.estadoFactura = (int)Enums.EstadoFactura.Cancelada;
                                    doc.fecha_ult_mod = Utility.getDate();
                                    doc.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
                                }
                                else
                                {
                                    //sino abona lo indicado
                                    abonoE.monto = montoAbono;
                                }
                                abonosModificados.Add(abonoE);
                                doc.tbAbonos.Add(abonoE);
                                docsModificados.Add(doc);
                               
                                montoAdeudado -= (decimal)abonoE.monto;
                                montoAbono -= (decimal)abonoE.monto;
                                if (montoAbono <= 0)
                                {
                                    break;
                                }
                            }
                            if (docsModificados.Count() != 0)
                            {


                                facturacionB.guadarFacturaAbonos(docsModificados);
                                MessageBox.Show("Datos guardados correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              
                                txtAbono.Text = string.Empty;
                                txtFacturado.Text = string.Empty;
                                chkTodos.Checked = false;
                                cargarDatosCliente();
                                if (chkImprimir.Checked)
                                {

                                    clsImpresionFactura imprimir = new clsImpresionFactura(docsModificados, clienteGlobal, Global.Usuario.tbEmpresa, decimal.Parse(txtAdeudado.Text));
                                    imprimir.print();
                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("Se esta abonando más de lo adeudado", "Error de monto ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El dato de abono es incorrecto, favor verifique.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se produjo un error al realizar el abono, vuelva a intentarlo.", "Error al realizar el abono", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

       

        private void checkList(bool chk)
        {
            foreach (var item in lsvFacturas.Items)
            {

                ((ListViewItem)item).Checked = chk;
            }

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            checkList(chkTodos.Checked);
        }

        private void lsvFacturas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //calcularAbono();

        }

        private void calcularAbono()
        {
            decimal total = 0;
            foreach (var item in lsvFacturas.Items)
            {

                if (((ListViewItem)item).Checked)
                {


                    string itemtext = ((ListViewItem)item).SubItems[5].Text.Trim();
                    if (itemtext != string.Empty)
                    {
                        if (Utility.isNumeroDecimal(itemtext))
                        {

                            total += decimal.Parse(itemtext);
                        }

                    }
                }
            }


            txtAbono.Text = total.ToString();
        }

        private void lsvFacturas_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            calcularAbono();
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAbono.Text==string.Empty)
                {
                    txtPendiente.Text = "0";
                }
                txtPendiente.Text = (decimal.Parse(txtAdeudado.Text) - decimal.Parse(txtAbono.Text)).ToString();
            }
            catch (Exception)
            {

                txtAbono.ResetText();
            }
        }
    }
}






