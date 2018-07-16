using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Resources;

namespace CovalcoClientApi
{
    public class HttpApiController
    {
        static HttpClient httpClient;

        public HttpApiController() { }

        static HttpApiController()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:53007/");
        }
        

        public async Task<List<AlumnoViewModel>> ObtenerAlumnos()
        {
            IEnumerable<AlumnoViewModel> listado = new List<AlumnoViewModel>();

            try
            {
                // Using System.Resources -> File recursos
                HttpResponseMessage response = httpClient.GetAsync(Resource.obtenerAlumnos).Result;  
                //HttpResponseMessage response = httpClient.GetAsync("api/Alumnoes").Result;

                if (response.IsSuccessStatusCode)
                {
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<AlumnoViewModel>>(alumnoJsonString);
                    listado = deserialized;
                }
            }
            catch(Exception)
            {
                throw;
            }

            // Parseo a listado
            return listado.ToList();
        }


        public async void AñadirAlumnos(AlumnoViewModel alumno)
        {
            // Serializacion del objeto alumno
            var alumnoJSON = JsonConvert.SerializeObject(alumno);

            try
            {
                // Creacion de objeto de contenido para enviar la informacion
                var encodingToBytes = System.Text.Encoding.UTF8.GetBytes(alumnoJSON);
                var byteContent = new ByteArrayContent(encodingToBytes);

                // Especificamos en el header que se trata de un tipo JSON
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var result = await httpClient.PostAsync(Resource.obtenerAlumnos, byteContent);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}
