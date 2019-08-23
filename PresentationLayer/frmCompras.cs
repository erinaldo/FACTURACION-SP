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

namespace PresentationLayer
{
    public partial class frmCompras : Form
    {
        Bcliente clienteInst = new Bcliente();
        BProvincias provinciasIns = new BProvincias();
        BTipoId tipoIdIns = new BTipoId();
        BImpuestos ImpIns = new BImpuestos();
        bTipoMedidas medidaIns = new bTipoMedidas();
        BExoneraciones exoneraIns = new BExoneraciones();

        List<tbProvincia> provinciasGlo = null;
        List<tbCanton> cantonesGlo = null;
        List<tbDistrito> distritosGlo = null;
        List<tbDetalleDocumento> detalleDoc = new List<tbDetalleDocumento>();

        public frmCompras()
        {
            InitializeComponent();
        }

        private void lsvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotipoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarTiposId();

        }
        private void cambiarTiposId()
        {
            if (cbotipoId.SelectedValue != null)
            {
                if ((int)cbotipoId.SelectedValue != (int)Enums.TipoId.Fisica)
                {
                    txtIdentificacion.Mask = (int)cbotipoId.SelectedValue == (int)Enums.TipoId.Juridica ? "##########" : "";
                    mskidentificacion.Visible = false;
                    txtIdentificacion.Visible = true;
                    txtIdentificacion.Enabled = true;


                }
                else
                {
                    mskidentificacion.Enabled = true;
                    mskidentificacion.Visible = true;
                    txtIdentificacion.Visible = false;
                   
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CargarCombos()
        {
          

            provinciasGlo = provinciasIns.getListTipoing((int)Enums.EstadoBusqueda.Activo);

            cboProvincia.ValueMember = "Cod";
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.DataSource = provinciasGlo;

            cbotipoId.ValueMember = "id";
            cbotipoId.DisplayMember = "nombre";
            cbotipoId.DataSource = tipoIdIns.getListaTipoId();

            cboExoneracion.ValueMember = "id";
            cboExoneracion.DisplayMember = "nombre";
            cboExoneracion.DataSource = exoneraIns.getListaExoneraciones();

            //tipopago
            cboTipoPago.DataSource = Enum.GetValues(typeof(Enums.TipoPago));
            //tipoveta
            cboTipoVenta.DataSource = Enum.GetValues(typeof(Enums.tipoVenta));

            cboImpuesto.ValueMember = "id";
            cboImpuesto.DisplayMember = "valor";
            cboImpuesto.DataSource = ImpIns.getImpuestos((int)Enums.EstadoBusqueda.Activo);

            cboMedida.ValueMember = "idTipoMedida";
            cboMedida.DisplayMember = "nomenclatura";
            cboMedida.DataSource = medidaIns.getlistatipomedida();

        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            CargarCombos();
            chkAplicaExo.Checked = false;
            gbxExoneracion.Enabled = false;
        }

        private void cboTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cboTipoVenta.SelectedValue==(int)Enums.tipoVenta.Credito)
            {
                mskPlazoCredito.Enabled = true;

            }
            else
            {
                mskPlazoCredito.Enabled = false;
                mskPlazoCredito.Text = string.Empty;
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue != null)
            {

                List<tbCanton> cantones = new List<tbCanton>();

                foreach (tbProvincia pro in provinciasGlo)
                {
                    if (pro.Cod == cboProvincia.SelectedValue.ToString())
                    {

                        foreach (tbCanton can in pro.tbCanton)
                        {
                            cantones.Add(can);
                        }

                        cantonesGlo = cantones;
                        cboCanton.DataSource = cantones;
                        cboCanton.ValueMember = "Canton";
                        cboCanton.DisplayMember = "Nombre";

                    }
                }

            }
        }

        private void cboCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCanton.SelectedValue != null)
            {

                List<tbDistrito> distritos = new List<tbDistrito>();

                foreach (tbCanton can in cantonesGlo)
                {
                    if (can.Canton == cboCanton.SelectedValue.ToString())
                    {
                        foreach (tbDistrito dis in can.tbDistrito)
                        {
                            distritos.Add(dis);
                        }

                        distritosGlo = distritos;
                        cboDistrito.DataSource = distritos;
                        cboDistrito.ValueMember = "Distrito";
                        cboDistrito.DisplayMember = "Nombre";

                    }
                }

            }
        }

        private void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistrito.SelectedValue != null)
            {

                List<tbBarrios> barrios = new List<tbBarrios>();

                foreach (tbDistrito dis in distritosGlo)
                {
                    if (dis.Distrito == cboDistrito.SelectedValue.ToString())
                    {
                        if (dis.tbBarrios.Count != 0)
                        {
                            foreach (tbBarrios barrio in dis.tbBarrios)
                            {
                                barrios.Add(barrio);
                            }


                            cboBarrios.DataSource = barrios;
                            cboBarrios.ValueMember = "barrio";
                            cboBarrios.DisplayMember = "nombre";
                        }


                    }
                }

            }

        }
            

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {

                    tbDetalleDocumento detalle = new tbDetalleDocumento();
                    detalle.numLinea = detalleDoc.Count + 1;
                    detalle.idProducto = txtCodigoProducto.Text.Trim();
                    detalle.precio = decimal.Parse(txtPrecioProducto.Text);
                    detalle.cantidad = decimal.Parse(mskCantidadProd.Text);
                    detalle.montoTotal = detalle.precio * detalle.cantidad;

                    tbProducto pro = new tbProducto();
                    pro.idProducto = detalle.idProducto;
                    pro.nombre = txtNombreProducto.Text.Trim().ToUpper();
                    tbTipoMedidas medida = new tbTipoMedidas();
                    medida.idTipoMedida = (int)cboMedida.SelectedValue;
                    medida.nomenclatura = cboMedida.Text;
                    pro.tbTipoMedidas = medida;
                    detalle.tbProducto = pro;
                    detalle.montoTotalDesc = decimal.Parse(txtDescuento.Text);
                    detalle.montoTotalImp = (((detalle.montoTotal - detalle.montoTotalDesc) * (1 + decimal.Parse(cboImpuesto.Text) / 100))) - (detalle.montoTotal - detalle.montoTotalDesc);
                    if (chkAplicaExo.Checked)

                    {
                        detalle.montoTotalExo = detalle.montoTotalImp;
                        detalle.montoTotalImp = 0;

                    }
                    else
                    {
                        detalle.montoTotalExo = 0;
                    }
                    detalle.totalLinea = (detalle.montoTotal - detalle.montoTotalDesc) + detalle.montoTotalImp - detalle.montoTotalExo;

                    detalleDoc.Add(detalle);
                    actualizarListView();
                    resetProducto();
                    cargarTotales();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un error al agregar el producto","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cargarTotales()
        {

            decimal total = 0, desc = 0, iva = 0, subtotal = 0, exo = 0;

            foreach (tbDetalleDocumento detalle in detalleDoc)
            {
                detalle.totalLinea = (detalle.montoTotal - detalle.montoTotalDesc) + detalle.montoTotalImp;
                total += detalle.totalLinea;
                desc += detalle.montoTotalDesc;
                iva += detalle.montoTotalImp;
                exo += detalle.montoTotalExo;
                subtotal += detalle.montoTotal;

            }
            txtSubtotal.Text = subtotal.ToString("#.##");
            txtDescuentoTotal.Text = desc == 0 ? "0" : desc.ToString("#.##");
            txtIva.Text = iva == 0 ? "0" : iva.ToString("#.##");
            txtTotal.Text = total == 0 ? "0" : total.ToString("#.##");
            txtExoneracion.Text = exo == 0 ? "0" : exo.ToString("#.##");
            
        }

        private void resetProducto()
        {
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            mskCantidadProd.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            txtDescuento.Text = string.Empty;
            cboMedida.SelectedItem = 0;
            cboImpuesto.SelectedIndex = 0;
        }

        private void actualizarListView()
        {
            lstvDocs.Items.Clear();
            foreach (tbDetalleDocumento item in detalleDoc)
            {

                //Creamos un objeto de tipo ListviewItem
                ListViewItem linea = new ListViewItem();

                linea.Text = item.numLinea.ToString();
                linea.SubItems.Add( item.idProducto.Trim());
                linea.SubItems.Add(item.tbProducto.nombre);
                linea.SubItems.Add(item.cantidad.ToString().Trim());
                linea.SubItems.Add(item.precio.ToString().Trim());
                linea.SubItems.Add(item.tbProducto.tbTipoMedidas.nomenclatura);
                linea.SubItems.Add(item.montoTotal.ToString().Trim());
                linea.SubItems.Add(item.montoTotalDesc.ToString().Trim());
                linea.SubItems.Add(item.montoTotalImp.ToString().Trim());
                linea.SubItems.Add(item.montoTotalExo.ToString().Trim());
                linea.SubItems.Add(item.totalLinea.ToString().Trim());
                //Agregamos el item a la lista.
                lstvDocs.Items.Add(linea);
            }

        }

        private bool validarCampos()
        {
            if (txtCodigoProducto.Text == string.Empty)
            {
                txtCodigoProducto.Focus();
                MessageBox.Show("Debe indicar el código del producto", "Error de datos");
                return false;
            }

            if (txtNombreProducto.Text == string.Empty)
            {
                txtNombreProducto.Focus();
                MessageBox.Show("Debe indicar el nombre del producto", "Error de datos");
                return false;
            }

            if (mskCantidadProd.Text == string.Empty)
            {
                mskCantidadProd.Focus();
                MessageBox.Show("Debe indicar la cantidad del producto", "Error de datos");
                return false;
            }

            if (txtPrecioProducto.Text == string.Empty)
            {
                txtPrecioProducto.Focus();
                MessageBox.Show("Debe indicar el precio del producto", "Error de datos");
                return false;
            }

            if (!Utility.isNumeroDecimal(txtPrecioProducto.Text))
            {
                txtPrecioProducto.Focus();
                MessageBox.Show("El precio indicado tiene formato incorrecto, no es númerico", "Error de datos");
                return false;
            }

            if (cboMedida.Text==string.Empty)
            {
                cboMedida.Focus();
                MessageBox.Show("No se indicó una medida del producto", "Error de datos");
                return false;
            }

            if (txtDescuento.Text == string.Empty)
            {
                txtDescuento.Focus();
                MessageBox.Show("Debe indicar el descuento del producto", "Error de datos");
                return false;
            }
            if (cboImpuesto.Text == string.Empty)
            {
                cboImpuesto.Focus();
                MessageBox.Show("Debe indicar el impuesto del producto", "Error de datos");
                return false;
            }

            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkAplicaExo_CheckedChanged(object sender, EventArgs e)
        {
            cboExoneracion.SelectedIndex = 0;
            txtDocExo.Text = string.Empty;
            txtInstitucionExo.Text = string.Empty;
            dtpFechaEmisionExo.Value = DateTime.Now;
            gbxExoneracion.Enabled = chkAplicaExo.Checked;

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (detalleDoc.Count != 0 && txtTotal.Text != "0")
            {
                if (validarCamposDoc())
                {

                    tbDocumento documento = crearDocumento();
                    frmCobrar form = new frmCobrar();
                    //form.recuperarTotal += respuesta;
                    //form.facturaGlobal = documento;
                    form.ShowDialog();


                }

            }
            else
            {
                MessageBox.Show("No hay productos o el TOTAL a cobrar es 0.", "Cobrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCamposDoc()
        {



            return true;
        }
        private tbDocumento crearDocumento()
        {
            tbDocumento documento = new tbDocumento();

            documento.tipoDocumento = (int)Enums.TipoDocumento.Compras;
            documento.id = int.Parse(txtIdFactura.Text);
            documento.fecha =dtpFechaEmision.Value;
            documento.tipoMoneda = (int)Enums.TipoMoneda.CRC;
            documento.tipoCambio = 0;
            documento.reporteElectronic = (bool)Global.Usuario.tbEmpresa.tbParametrosEmpresa.First().facturacionElectronica;
            documento.tipoVenta = (int)cboTipoVenta.SelectedValue;
            documento.plazo = 0;
            documento.estadoFactura = (int)Enums.EstadoFactura.Cancelada;
            if ((int)cboTipoVenta.SelectedValue== (int)Enums.tipoVenta.Credito)
            {

                documento.plazo = int.Parse(mskPlazoCredito.Text);
                documento.estadoFactura = (int)Enums.EstadoFactura.Pendiente;
            }
            
            documento.tipoPago = (int)cboTipoPago.SelectedValue;

            //documento.reporteAceptaHacienda = false;
            //documento.notificarCorreo = chkEnviar.Checked;
            //documento.observaciones = txtObservaciones.Text.ToUpper().Trim();
            documento.idEmpresa = Global.Usuario.tbEmpresa.id;
            documento.tipoIdEmpresa = Global.Usuario.tbEmpresa.tipoId;
            //en caso que no tenga cliente asignado, sera no contribuyente

            tbClientes cliente = new tbClientes();
            cliente.tipoId = (int)cbotipoId.SelectedValue;
            if (cliente.tipoId==(int)Enums.TipoId.Fisica)
            {
                cliente.id = mskidentificacion.Text;
            }
            else
            {
                cliente.id = txtIdentificacion.Text;
            }

            tbPersona persona = new tbPersona();
            persona.nombre = txtNombre.Text;
            persona.correoElectronico = txtCorreo.Text;
            persona.provincia = cboProvincia.SelectedValue.ToString();
            persona.canton = cboCanton.SelectedValue.ToString();
            persona.distrito = cboDistrito.SelectedValue.ToString();
            persona.barrio = cboBarrios.SelectedValue.ToString();
            persona.otrasSenas = txtOtrasSenas.Text;

            cliente.contribuyente = false;
            cliente.exonera = chkAplicaExo.Checked;
            if ((bool)cliente.exonera)
            {
                cliente.FechaEmisionExo = dtpFechaEmisionExo.Value;
                cliente.institucionExo = txtInstitucionExo.Text;
                cliente.numeroDocumentoExo = txtDocExo.Text;
                cliente.idExonercion = (int)cboExoneracion.SelectedValue;

            }
            //cliente.
            cliente.tbPersona = persona;
            documento.tbClientes = cliente;
            documento.tbDetalleDocumento = detalleDoc;
            

            documento.estado = true;

         

            //Atributos de Auditoria

            documento.fecha_crea = Utility.getDate();
            documento.fecha_ult_mod = Utility.getDate();
            documento.usuario_crea = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;
            documento.usuario_ult_mod = Global.Usuario.nombreUsuario.Trim().ToUpper();   // Global.Usuario.nombreUsuario;

            return documento;
        }
    }
}
