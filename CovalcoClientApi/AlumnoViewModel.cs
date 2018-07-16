using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovalcoClientApi
{
    public class AlumnoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

        // Constructor nulo, ya que sino al serializar en el Form daba problemas
        public AlumnoViewModel() { }

        public AlumnoViewModel(int id, string nombre, string apellidos, string dni)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
        }
        
        
        public AlumnoViewModel(string nombre, string apellidos, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
        }
        
    }
}
