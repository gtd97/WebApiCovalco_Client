using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Configuration;
//using System.Resources;

namespace CovalcoClientApi
{
    public class HttpApiController
    {
        static HttpClient httpClient;

        public HttpApiController() { }

        static HttpApiController()
        {            
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ConfigurationSettings.AppSettings["path"].ToString());
        }
        

        public async Task<List<AlumnoViewModel>> ObtenerAlumnos()
        {
            IEnumerable<AlumnoViewModel> listado = new List<AlumnoViewModel>();

            try
            {
                // Using System.Resources -> File recursos
                HttpResponseMessage response = httpClient.GetAsync(ConfigurationSettings.AppSettings["obtenerAlumnos"].ToString()).Result;

                if (response.IsSuccessStatusCode)
                {
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<AlumnoViewModel>>(alumnoJsonString);
                    listado = deserialized;
                }
            }
            catch(Exception ex)
            {
                throw ex;
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

                var result = await httpClient.PostAsync(ConfigurationSettings.AppSettings["añadirAlumnos"].ToString(), byteContent);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async void EditarAlumnos(int id, AlumnoViewModel alumno)
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
                
                var result = await httpClient.PutAsync( String.Concat(ConfigurationSettings.AppSettings["editAlumnos"].ToString(), id), byteContent);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async void EliminarAlumnos(int id)
        {
            try
            {
                var result = await httpClient.DeleteAsync(String.Concat(ConfigurationSettings.AppSettings["deleteAlumnos"].ToString(), id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


    }
}
