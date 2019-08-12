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
using CommonLayer;


namespace PresentationLayer
{
    public partial class frmLogin : Form
    {
        //nombramos las variables e instancias necesarias para acceder a los objetos necesarios
        tbUsuarios usuarioB = new tbUsuarios();
        BUsuario insBUsuario = new BUsuario();
        int i = 1;
        int intentos = 3;

        //Creo delegados correspondientes
        public delegate void cerrarFormFacturacion();
        public event cerrarFormFacturacion cerrarFact;

        public delegate void cargarPermisos(tbUsuarios usu);
        public event cargarPermisos permisosEvent;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void CargarNumCaja()
        {
            BCajas insCaja = new BCajas();
            cboNumCaja.DisplayMember = "nombre";
            cboNumCaja.ValueMember = "id";  
            cboNumCaja.DataSource = insCaja.getListTipoing((int)Enums.EstadoBusqueda.Activo);
        }

        //Validamos el ingreso de datos
        private bool Validar()
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar el nombre de usuario");
                txtUsuario.Focus();
                return false;
            }
            if (txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar contraseña");
                txtContraseña.Focus();
                return false;
            }
            //if (cboNumCaja.Text == string.Empty)
            //{
            //    MessageBox.Show("Debe ingresar el número de caja");
            //    cboNumCaja.Focus();
            //    return false;
            //}
            return true;
        }

        //El numero de caja lo cargamos dinamicamente desde base de datos
        private void frmLogin_Load(object sender, EventArgs e)
        {
           // ingresar();
        }

        //Con este metodo verificamos la auteticidad de que el usuario ya existe
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            ingresar();
        }

        private void ingresar()
        {
            if (Validar())
            {
                tbUsuarios login = new tbUsuarios();
                login.nombreUsuario = txtUsuario.Text.ToString();
                login.contraseña = txtContraseña.Text.Trim();
                login = insBUsuario.getLoginUsuario(login);


                if (login != null)
                {
                    if (login.tbEmpresa.fechaCaducidad > Utility.getDate())
                    {
                        Global.Usuario = login;
                        // Global.NumeroCaja = (int)cboNumCaja.SelectedValue;
                        //permisosEvent(login);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("El licenciamiento del producto ha caducado, favor contactar con la empresa", "Vencimiento licenciamiento", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        cerrarFact();
                        this.Close();

                    }



                }
                else
                {
                    //Creamos un ciclo para dar un numero determinado de intentos antes de que se cierre el formulario
                    if (i < intentos)
                    {
                        MessageBox.Show("Usuario o contraseña inválidos");
                        limpiar();
                        txtUsuario.Focus();

                    }
                    else
                    {
                        cerrarFact();
                        this.Close();
                        //desahabilitar y cerrar

                    }

                    i += 1;
                }

            }
        }



        //Limpiamos el formulario de login
        private void limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            cboNumCaja.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            cerrarFact();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
