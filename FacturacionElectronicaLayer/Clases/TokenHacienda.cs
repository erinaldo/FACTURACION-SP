using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using CommonLayer;

namespace FacturacionElectronicaLayer.Clases
{
    public class TokenHacienda
    {        //private string IDP_CLIENT_ID_DESA= "api-stag";
             //private string IDP_CLIENT_ID_PRO= "api-prod";
             //private string IDP_URI_PRO = "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut/protocol/openid-connect/token";
             //private string IDP_URI_DESA = "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token";

        private string IDP_CLIENT;
        private String IDP_URI_G;

        public TokenHacienda()
        {
            IDP_CLIENT = Utility.IDP_CLIENT_TOKEN((bool)Global.Usuario.tbEmpresa.ambientePruebas);
            IDP_URI_G = Utility.IDP_URI_TOKEN((bool)Global.Usuario.tbEmpresa.ambientePruebas);

        }

        public string accessToken { get; set; }
        public string refreshToken { get; set; }

        public async Task<string>  GetTokenHacienda(string usuario, string password)
        {
           
                accessToken = "";
                refreshToken = "";


                string IDP_CLIENT_ID = IDP_CLIENT;
                string IDP_URI = IDP_URI_G;
       


                HttpClient http = new HttpClient();
                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                param.Add(new KeyValuePair<string, string>("client_id", IDP_CLIENT_ID));
                param.Add(new KeyValuePair<string, string>("grant_type", "password"));
                param.Add(new KeyValuePair<string, string>("username", usuario));
                param.Add(new KeyValuePair<string, string>("password", password));
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);

                HttpResponseMessage response = http.PostAsync(IDP_URI, content).Result;
                string res = await response.Content.ReadAsStringAsync();
                Token tk = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(res);
                if ((response.StatusCode != System.Net.HttpStatusCode.OK))
                {
                    throw new Exception(("Error: " + response.GetHashCode()));
                }

                accessToken = tk.access_token;
                refreshToken = tk.refresh_token;
                if (accessToken == String.Empty)                {

                    throw new Exception("No se pudo crear el token.");
                }

                return accessToken;
            
           
        }
    }
}
