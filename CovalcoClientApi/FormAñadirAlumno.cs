using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovalcoClientApi
{
    public partial class FormAñadirAlumno : Form
    {
        private FormGrid form_grid;
        HttpApiController controller;

        public FormAñadirAlumno()
        {
            InitializeComponent();
            controller = new HttpApiController();
        }



        private void Button_guardar(object sender, EventArgs e)
        {
            // Crear objeto Alumno con los datos del formulario 
            AlumnoViewModel alumno = new AlumnoViewModel(tb_nombre.Text, tb_apellido.Text, tb_dni.Text);

            // Enviar el objeto, para ser enviado por llamada al web service
            controller.AñadirAlumnos(alumno);

            //FormGrid grid = new FormGrid();
            
            //grid.grid_form.Refresh();
        }
    }
}
