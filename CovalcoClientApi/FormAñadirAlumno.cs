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
        HttpApiController controller;

        public FormAñadirAlumno()
        {
            InitializeComponent();
            controller = new HttpApiController();
        }



        private void Button_guardar(object sender, EventArgs e)
        {
            //List<AlumnoViewModel> listado = new List<AlumnoViewModel>();
            //listado = controller.AñadirAlumnos(tb_nombre.Text, tb_apellido.Text, tb_dni.Text);

            controller.AñadirAlumnos(tb_nombre.Text, tb_apellido.Text, tb_dni.Text);

        }
    }
}
