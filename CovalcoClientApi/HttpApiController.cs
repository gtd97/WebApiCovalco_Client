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
            catch(Exception ex)
            {
                throw ex;
            }

            // Parseo a listado
            return listado.ToList();
        }


        //public async Task<List<AlumnoViewModel>> AñadirAlumnos(string nombre, string apellido, string dni)
        public async void AñadirAlumnos(string nombre, string apellido, string dni)
        {
            IEnumerable<AlumnoViewModel> detallesNuevoAlumno = new List<AlumnoViewModel>();

            AlumnoViewModel alumno = new AlumnoViewModel(nombre, apellido, dni);
            //var alumno = JsonConvert.SerializeObject(nombre, apellido, dni);

            try
            {
                
                var stringContent = new StringContent(alumno.ToString(), UnicodeEncoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync(Resource.obtenerAlumnos, stringContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    var alumnoJsonString = await response.Content.ReadAsStringAsync();
                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<AlumnoViewModel>>(alumnoJsonString);
                    detallesNuevoAlumno = deserialized;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }


    }
}
