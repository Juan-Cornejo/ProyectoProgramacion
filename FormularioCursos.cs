using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestLogin
{
    public partial class FormularioCursos : Form
    {
        public FormularioCursos()
        {
            InitializeComponent();
            CargarCursos();
        }

        // Definir la clase Curso
        public class Curso
        {
            public string IDCurso { get; set; }
            public string NombreCurso { get; set; }
            public string Semestre { get; set; }
            public string Profesor { get; set; }
        }

        // Método para cargar los cursos en el FlowLayoutPanel
        private void CargarCursos()
        {
            // Crear una lista de cursos
            List<Curso> cursos = new List<Curso>
            {
                new Curso { IDCurso = "101", NombreCurso = "Programación II", Semestre = "2do Semestre", Profesor = "Ana González" },
                new Curso { IDCurso = "102", NombreCurso = "Inglés Técnico I", Semestre = "2do Semestre", Profesor = "Pedro Martínez" },
                new Curso { IDCurso = "103", NombreCurso = "Base de Datos II", Semestre = "2do Semestre", Profesor = "Laura Fernández" },
                new Curso { IDCurso = "104", NombreCurso = "Taller de Creatividad e Innovación", Semestre = "2do Semestre", Profesor = "Jorge Rodríguez" },
                new Curso { IDCurso = "105", NombreCurso = "Diseño de Software", Semestre = "2do Semestre", Profesor = "Carla López" },
                new Curso { IDCurso = "106", NombreCurso = "Persona, Comunión y Servicio", Semestre = "2do Semestre", Profesor = "Luis Hernández" }
            };

            // Definir una lista de colores para el fondo de los panels
            List<Color> colores = new List<Color>
            {
                Color.LightSkyBlue,
                Color.LightGreen,
                Color.LightCoral,
                Color.LightYellow,
                Color.LightPink,
                Color.LightSalmon
            };

            // Iterar sobre los cursos y crear un panel por cada curso
            for (int i = 0; i < cursos.Count; i++)
            {
                var curso = cursos[i];

                // Crear un Panel para cada curso
                Panel panelCurso = new Panel
                {
                    Size = new Size(flowLayoutPanel1.Width - 20, 100),
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = colores[i % colores.Count] // Asignar color diferente a cada panel
                };

                // Establecer la fuente para los Labels
                Font fuente = new Font("Bahnschrift", 12);

                // Crear un Label para el ID del curso
                Label labelID = new Label
                {
                    Text = "ID: " + curso.IDCurso,
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = fuente
                };

                // Crear un Label para el Nombre del curso
                Label labelNombre = new Label
                {
                    Text = "Curso: " + curso.NombreCurso,
                    Location = new Point(10, 40),
                    AutoSize = true,
                    Font = fuente
                };

                // Crear un Label para el semestre
                Label labelSemestre = new Label
                {
                    Text = "Semestre: " + curso.Semestre,
                    Location = new Point(10, 70),
                    AutoSize = true,
                    Font = fuente
                };

                // Crear un Label para el profesor
                Label labelProfesor = new Label
                {
                    Text = "Profesor: " + curso.Profesor,
                    Location = new Point(150, 10),
                    AutoSize = true,
                    Font = fuente
                };

                // Agregar los Labels al Panel
                panelCurso.Controls.Add(labelID);
                panelCurso.Controls.Add(labelNombre);
                panelCurso.Controls.Add(labelSemestre);
                panelCurso.Controls.Add(labelProfesor);

                // Agregar el Panel al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panelCurso);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuEstudiante().Show();
        }
    }
}