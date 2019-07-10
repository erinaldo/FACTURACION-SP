using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CommonLayer
{
    public class Utility
    {

        /// <summary>
        /// Recuperamos la fecha actual de la computadora.
        /// </summary>
        /// 
        /// 
        /// 
        /// 
        /// 
        /// <returns></returns>
        /// 


        public static bool AccesoInternet()
        {

            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;

            }
            catch (Exception es)
            {

                return false;
            }

        }
        public static string stringConexionReportes() {
            return "data source=localhost\\SQLEXPRESS;initial catalog=dbSISSODINA;user id=sa;password=crpp;";
        }
        public static XmlDocument DecodeBase64ToXML(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(myStr);
            return xmlDoc;
        }

        public static string DecodeBase64ToString(string valor)
        {
            byte[] myBase64ret = Convert.FromBase64String(valor);
            string myStr = System.Text.Encoding.UTF8.GetString(myBase64ret);
            return myStr;
        }

        public static string EncodeStrToBase64(string valor)
        {
            byte[] myByte = System.Text.Encoding.UTF8.GetBytes(valor);
            string myBase64 = Convert.ToBase64String(myByte);
            return myBase64;
        }



        public static bool generarArchivos(tbDocumento doc)
        {

            try
            {






            }
            catch (Exception)
            {

                return false;
            }


            return true;
        }

        public static DateTime getDate()
        {
            return DateTime.Now;
        }
        public static DateTime GetDateByDay()
        {
            return DateTime.Today;
        }





        public static byte[] ImageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        
        public static bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail.Trim()))
                return (true);
            else
                return (false);
        }
        public static bool isNumeroDecimal(string valor)
        {
            decimal res = 0;
            if (valor!=string.Empty)
            {

                if (decimal.TryParse(valor, out res))
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }

            return false;
           
        }

        public static bool isNumerInt(string valor)
        {
            int res = 0;
            if (valor != string.Empty)
            {

                if (int.TryParse(valor, out res))
                {
                    return true;
                }
                else
                {
                    return false;

                }

            }
            return false;
        }
        public static string getPrefixTypeDoc(int tipo)
        {
            string nome=string.Empty;
            if (tipo == (int)Enums.TipoDocumento.NotaCreditoElectronica)
            {
                nome= "_NC";
            }
            else if (tipo == (int)Enums.TipoDocumento.NotaDebitoElectronica)
            {

                nome = "_ND";
            }
            else if (tipo == (int)Enums.TipoDocumento.FacturaElectronica)
            {

                nome = "_FE";
            }
            else if (tipo == (int)Enums.TipoDocumento.TiqueteElectronico)
            {

                nome = "_TE";
            }
            else if (tipo == (int)Enums.TipoDocumento.Proforma)
            {

                nome = "_PROFORMA";
            }
            return nome;


        }
        /// <summary>
        /// Habilitamos y deshabilitamos el formulario.
        /// </summary>
        /// <param name="gbx"></param>
        /// <param name="estado"></param>
        public static void EnableDisableForm(ref GroupBox gbx, bool estado)
        {


            foreach (Object obj in gbx.Controls)
            {

                if (obj is TextBox)
                {

                    ((TextBox)obj).Enabled = estado;

                }
                if (obj is MaskedTextBox)
                {

                    ((MaskedTextBox)obj).Enabled = estado;

                }

                if (obj is ComboBox)
                {

                    ((ComboBox)obj).Enabled = estado;
                
                }

                if (obj is GroupBox)
                {

                    ((GroupBox)obj).Enabled = estado;

                }
                if (obj is CheckBox)
                {

                    ((CheckBox)obj).Enabled = estado;

                }
                if (obj is RadioButton)
                {

                    ((RadioButton)obj).Enabled = estado;

                }

                if (obj is ListView)
                {

                    ((ListView)obj).Enabled = estado;

                }
                if (obj is DataGrid)
                {

                    ((DataGrid)obj).Enabled = estado;

                }
                if (obj is DateTimePicker)
                {

                    ((DateTimePicker)obj).Enabled = estado;

                }
                if (obj is Button)
                {

                    ((Button)obj).Enabled = estado;

                }
                if (obj is PictureBox)
                {

                    ((PictureBox)obj).Enabled = estado;

                }
            }

        }

       /// <summary>
       /// Reseteamos el formulario.
       /// </summary>
       /// <param name="gbx"></param>
       public static void ResetForm(ref GroupBox gbx)
        {
            foreach (Object obj in gbx.Controls)
            {

                if (obj is TextBox)
                {
                    if (((TextBox)obj).Name.Contains("Int")) {

                        ((TextBox)obj).Text = "0";
                    }
                    else
                    {
                        ((TextBox)obj).Text = string.Empty;

                    }
                    

                }
                if (obj is MaskedTextBox)
                {

                    ((MaskedTextBox)obj).Text = string.Empty;

                }

                if (obj is ComboBox)
                {
                    if (((ComboBox)obj).Items.Count == 0)
                    {
                        ((ComboBox)obj).Text = string.Empty;

                    }
                    else {
                        ((ComboBox)obj).SelectedIndex = 0;
                    }
                    
                    //((ComboBox)obj).SelectedIndex = 0;
                    //((ComboBox)obj).SelectedItem = 0;

                }


                if (obj is CheckBox)
                {

                    ((CheckBox)obj).Checked = false;

                }

                if (obj is ListView)
                {

                    ((ListView)obj).Items.Clear();

                }
                if (obj is DataGridView)
                {

                    ((DataGridView)obj).Rows.Clear();

                }
                if (obj is DateTimePicker)
                {

                    ((DateTimePicker)obj).Value = DateTime.Now;

                }

                if (obj is PictureBox)
                {

                    ((PictureBox)obj).Image = null;

                }

            }

        }


        public static int redondearNumero(decimal valor)
        {
            int entero = (int)valor;
            return ((entero + 5) / 10 * 10);           

        }

        public static String URL_RECEPCION(bool pruebas)
        {
            if (pruebas)
            {
                return "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/";

            }
            else
            {
                return "https://api.comprobanteselectronicos.go.cr/recepcion/v1/";
            }
        }

        public static String IDP_CLIENT_TOKEN(bool pruebas)
        {
            if (pruebas)
            {
                return "api-stag";

            }
            else
            {
                return "api-prod";
            }
        }

        public static String IDP_URI_TOKEN(bool pruebas)
        {
            if (pruebas)
            {
                return "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token";

            }
            else
            {
                return "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut/protocol/openid-connect/token";
            }
        }
    }
}
