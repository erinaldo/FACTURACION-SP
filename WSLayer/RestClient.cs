using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WSLayer
{

    public enum httpVerb {
			GET,
			POST,
			PUT,
			DELETE
    }

    public class RestClient
    {
		public string endPoint { get; set; }
		public httpVerb httpMethod { get; set; }

		public string userName { get; set; }
        public string passUser { get; set; }


        public RestClient() {

            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
            userName = string.Empty;
            passUser = string.Empty;

        }


        public string makeRequest() {
			


            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();
		
            using (HttpWebResponse response= (HttpWebResponse)request.GetResponse()) {
                if (response.StatusCode!= HttpStatusCode.OK) {
                    throw new ApplicationException("Codigo error: " + response.StatusCode);

                }

                using (Stream responseStream = response.GetResponseStream())
                {
					if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {

                            strResponseValue = reader.ReadToEnd();
                        }

                    }


                }

            }
            return strResponseValue;


        }
    }
}
