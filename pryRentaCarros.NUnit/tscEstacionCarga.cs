using NUnit.Framework;

using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace pryRentaCarros.NUnit
{
    public class tscConcurso
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void fncIngresarEstacionCargaTest()
        {
            string strURL = @"https://localizacionestacioncargawebapi.azurewebsites.net/api/EstacionCarga/Ingresar?strNombre=PRUEBA&dblLatitud=1.11111111&dblLongitud=2.22222222";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            HttpContent content = new StringContent("");
            var stringContent = new StringContent(JsonConvert.SerializeObject(content));
            objHttpResponseMessage = objHttpClient.PostAsync(strURL, stringContent).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncModificarEstacionCargaTest()
        {
            string strURL = @"https://localizacionestacioncargawebapi.azurewebsites.net/api/EstacionCarga/Modificar?intIdEstacionCarga=7&strNombre=PRUEBA_MODIFICAR&dblLatitud=3.33333333&dblLongitud=4.44444444";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            HttpContent content = new StringContent("");
            var stringContent = new StringContent(JsonConvert.SerializeObject(content));
            objHttpResponseMessage = objHttpClient.PutAsync(strURL, stringContent).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncRetirarEstacionCargaTest()
        {
            string strURL = @"https://localizacionestacioncargawebapi.azurewebsites.net/api/EstacionCarga/Retirar?intIdEstacionCarga=7";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.DeleteAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }

        [Test]
        public void fncConsultarEstacionCargaTest()
        {
            string strURL = @"https://localizacionestacioncargawebapi.azurewebsites.net/api/EstacionCarga/Consultar";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage();
            objHttpResponseMessage = objHttpClient.GetAsync(strURL).Result;

            Assert.IsTrue(objHttpResponseMessage.IsSuccessStatusCode);
        }
    }
}