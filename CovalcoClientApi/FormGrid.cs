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
    public partial class FormGrid : Form
    {
        HttpApiController controller;
        FormEditarAlumno editarAlumno;
        public static Dictionary<string, string> dictAlumno = new Dictionary<string, string>();

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

        public void Button_Actualizar(object sender, EventArgs e)
        {
            // Llamada a webservice
            List<AlumnoViewModel> listado = new List<AlumnoViewModel>();

            listado = controller.ObtenerAlumnos().Result;
            grid_form.DataSource = listado;
            
            // Columna botones editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btn_editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            grid_form.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btn_eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;

            grid_form.Columns.Add(btnEliminar);

            grid_form.Refresh();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(grid_form.Rows[e.RowIndex].Cells[0].Value);
                string nombre = grid_form.Rows[e.RowIndex].Cells[1].Value.ToString();
                string apellido = grid_form.Rows[e.RowIndex].Cells[2].Value.ToString();
                string dni = grid_form.Rows[e.RowIndex].Cells[3].Value.ToString();

                dictAlumno.Add("id", id.ToString());
                dictAlumno.Add("nombre", nombre);
                dictAlumno.Add("apellido", apellido);
                dictAlumno.Add("dni", dni);

                editarAlumno = new FormEditarAlumno();
                editarAlumno.Show();
            }
        }
    }
}
