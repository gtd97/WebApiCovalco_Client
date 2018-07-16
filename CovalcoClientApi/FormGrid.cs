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
    public partial class FormGrid : Form
    {
        HttpApiController controller;

        public FormGrid()
        {
            InitializeComponent();
            grid_form.AutoGenerateColumns = true;
            controller = new HttpApiController();
        }

        private void Button_añadir(object sender, EventArgs e)
        {
            // Abrir formulario
            FormAñadirAlumno formularioAñadir = new FormAñadirAlumno();
            formularioAñadir.Show();
        }

        private void Button_Actualizar(object sender, EventArgs e)
        {
            // Llamada a webservice
            List<AlumnoViewModel> listado = new List<AlumnoViewModel>();
            listado = controller.ObtenerAlumnos().Result;
            grid_form.DataSource = listado;
            grid_form.Refresh();

            /*
            HttpApiController controller = new HttpApiController();
            List<AlumnoViewModel> alumnos = new List<AlumnoViewModel>();
            alumnos = controller.GetCall().Result;
            grid_form.DataSource = alumnos;
            grid_form.Refresh();
            */

        }
    }
}
