using System;
using System.Collections;
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
    public partial class FormEditarAlumno : Form
    {
        AlumnoViewModel alumno;
        HttpApiController httpclient;

        public FormEditarAlumno()
        {
            InitializeComponent();
        }

        private void ButtonClickEditar(object sender, EventArgs e)
        {
            // Envio al Web Service
            alumno = new AlumnoViewModel(Convert.ToInt32(tbEdit_id.Text), tbEdit_nombre.Text, tbEdit_apellido.Text, tbEdit_dni.Text);

            httpclient = new HttpApiController();
            httpclient.EditarAlumnos(Convert.ToInt32(tbEdit_id.Text), alumno);

            this.Close();
        }

        private void LoadFormEditar(object sender, EventArgs e)
        {
            // Auto rellenado
            Dictionary<string, string> arrayAlumno = FormGrid.dictAlumno;

            tbEdit_id.Text = arrayAlumno["id"];
            tbEdit_nombre.Text = arrayAlumno["nombre"];
            tbEdit_apellido.Text = arrayAlumno["apellido"];
            tbEdit_dni.Text = arrayAlumno["dni"];
        }
    }
}
