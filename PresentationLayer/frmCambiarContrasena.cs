using BusinessLayer;
using CommonLayer;
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
    public partial class frmCambiarContrasena : Form
    {
        BUsuario usuarioIns = new BUsuario();
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    Global.Usuario.contraseña = txtNueva.Text.Trim();
                    usuarioIns.modificar(Global.Usuario);
                    MessageBox.Show("La contraseña se ha cambiado satisfactoriamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNueva.Text = string.Empty;
                    txtConfirmacion.Text = string.Empty;
                    txtAnterior.Text = string.Empty;

                }


            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo guardar los datos.", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool validarDatos()
        {
            if (txtAnterior.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Constreseña Anterior", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnterior.Focus();
                return false;
            }
            else if (txtNueva.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Constreseña Nueva", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNueva.Focus();
                return false;
            }
            else if (txtConfirmacion.Text.Trim() == string.Empty)
            {

                MessageBox.Show("Debe completar el campo de Constreseña Confirmación", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmacion.Focus();
                return false;
            }
            else if (txtAnterior.Text.Trim() != Global.Usuario.contraseña.Trim())
            {

                MessageBox.Show("No coinciden la constraseña indica.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnterior.Focus();
                return false;
            }
            else if (txtNueva.Text.Trim()!= txtConfirmacion.Text.Trim())
            {

                MessageBox.Show("Contraseñas no coinciden.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNueva.Focus();
                return false;
            }



            return true;

        }

        private void frmCambiarContrasena_Load(object sender, EventArgs e)
        {
          
        }
    }
}
