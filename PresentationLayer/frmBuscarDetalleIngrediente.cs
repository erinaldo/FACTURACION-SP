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
using CommonLayer;


namespace PresentationLayer
{
     public partial class frmBuscarDetalleIngrediente : Form

        {
            BIngredientes ingredienteIns = new BIngredientes();

            List<tbIngredientes> listaIngredientes = new List<tbIngredientes>();//lista ngredientes 

            public static tbIngredientes ingredienteGlo = new tbIngredientes();//Variable global 

            //DELEGADO  Y EVENTO
            public delegate void pasarIngrediente(tbIngredientes entity);
            public event pasarIngrediente pasarIngreEven;
        
            bool banderaSeleccionar = false;//Si selecciono un elemento me cargue la variable global con la entidad seleccionada y sino entonces ciemrro el form y la variable global queda vacia
             
            public frmBuscarDetalleIngrediente()
            {
                InitializeComponent();
            }



           //Obtengo los ingredientes y muestro los ingredientes que cargue

        private void frmBuscarDetalleIngrediente_Load(object sender, EventArgs e)
           {
            try
              {
                listaIngredientes = ingredienteIns.GetListIngredientes((int)Enums.EstadoBusqueda.Activo);      //tengo que crear los enumeradores y definirlos luego que ingreso los que deseo mostrar dentro de parenticis
                cargarlista(listaIngredientes);
              }
            catch (ListEntityException ex)//RESIVO EL MENJAME PERSONALIZADO QUE BIENE DE LA CAPA DATALAYER
              {

                MessageBox.Show(ex.Message);
              }            
            }

           //Metodo para cargar los ingredientes  (ID,NOMBRE,ESTADO....)

         public void cargarlista(List<tbIngredientes> listaIng)
            {
             
                lstvDetalleIngrediente.Items.Clear();

                foreach (tbIngredientes p in listaIng)
                {

                    ListViewItem item = new ListViewItem();

                    item.Text = p.idIngrediente.ToString();
                    item.SubItems.Add(p.nombre);

                    if (p.estado)
                    {
                        item.SubItems.Add("Activo");
                    }
                    else
                    {
                        item.SubItems.Add("Inactivo");


                    }

                  lstvDetalleIngrediente.Items.Add(item);
               
                 }
           }
        private void txtBuscarIngrediente_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        //Metodo para buscar por medio del texbox los elmentos de la lista que necesito a traves de una 
        //letra o palabra como referencia

        private void buscar()
        {
            lstvDetalleIngrediente.Items.Clear();

            List<tbIngredientes> BuscarListIngre = new List<tbIngredientes>();

            //TRIM ELIMINA LOS ESPACIO VACIOS
            if (txtBuscarIngrediente.Text.Trim() != string.Empty)
            {
                foreach (tbIngredientes p in listaIngredientes)
                {
                    if (p.nombre.Contains(txtBuscarIngrediente.Text.ToUpper().Trim()))
                    {
                        BuscarListIngre.Add(p);
                    }

                }
                cargarlista(BuscarListIngre);
            }
            else
            {//carga lista completa
                cargarlista(listaIngredientes);
            }
        }


        //Dentro del list View

        //En pocas palabras cargo la fila seleccionada a mi variable global  (ingredienteGlo)

        //1-Consulto si he selecionado ID de mi lisView cargado
        //2-El ID selecionado es = a lo que tenga mi listView en la posicion cero (que es la POSOCIO que por defecto esta el ID)
        //3-Luego recorro con foreach la tbIngredientes   y le asigno a la variable gloval(ingredi..Glo) lo que ten la variable (ingrediente)
        private void lstvDetalleIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvDetalleIngrediente.SelectedItems.Count > 0)// 1
            {
                string idSelected = lstvDetalleIngrediente.SelectedItems[0].Text;//-2

                foreach (tbIngredientes ingrediente in listaIngredientes)//-3
                {
                    if (int.Parse(idSelected) == ingrediente.idIngrediente)
                    {
                        ingredienteGlo = ingrediente;
                    }
                }

            }
        }

        //Evento Seleccionar
        private void btnSeleccionar_Click(object sender, EventArgs e)
          {
            banderaSeleccionar = true;
            pasarIngreEven(ingredienteGlo);
            listaIngredientes = null;
            this.Dispose();
          }

        
        //Evento DobleClick
        private void frmBuscarDetalleIngrediente_DoubleClick(object sender, EventArgs e)
          {
            banderaSeleccionar = true;
            pasarIngreEven(ingredienteGlo);
            listaIngredientes = null;
            this.Dispose();

          }

        //Cierra el formulario  ingredientes  y limpia
        private void frmBuscarDetalleIngrediente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (banderaSeleccionar == false)
            {
                ingredienteGlo = null;

                pasarIngreEven(ingredienteGlo);
                listaIngredientes = null;
                this.Dispose();
            }
        }
    }
}