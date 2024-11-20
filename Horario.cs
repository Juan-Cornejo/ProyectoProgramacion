using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogin
{
    public partial class Horario : Form
    {
        public Horario()
        {
            InitializeComponent();
            CrearHorario();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuEstudiante().Show();
        }
        private void CrearHorario()
        {
            // Definir días de la semana y nuevas horas del día
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            string[] horas = { "8:00 - 10:30", "11:00 - 13:30", "15:00 - 17:00" };

            // Definir las clases (ramos) para cada celda del horario
            string[,] ramos = {
        { "Programación II", "Inglés Técnico I", "Diseño de Software", "Programación II", "" },
        { "Inglés Técnico I", "Taller Creatividad e Innovación", "Base de Datos II", "Diseño de Software", "" },
        { "Base de Datos II", "Persona, Comunión y Servicio", "Taller Creatividad e Innovación", "Persona, Comunión y Servicio", "" }
    };

            // Mapeo entre el nombre del ramo y su color correspondiente
            Dictionary<string, Color> coloresRamos = new Dictionary<string, Color>()
    {
        { "Programación II", Color.LightBlue },
        { "Inglés Técnico I", Color.LightGreen },
        { "Diseño de Software", Color.LightPink },
        { "Taller Creatividad e Innovación", Color.LightYellow },
        { "Base de Datos II", Color.LightCoral },
        { "Persona, Comunión y Servicio", Color.LightSalmon },
        { "", SystemColors.Control } // Celdas vacías o "Libre"
    };

            // Crear un TableLayoutPanel
            TableLayoutPanel table = new TableLayoutPanel();
            table.ColumnCount = dias.Length + 1; // Días + columna de horas
            table.RowCount = horas.Length + 1;  // Horas + fila de encabezados
            table.Dock = DockStyle.Fill; // Hacer que se adapte al tamaño del formulario
            table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single; // Bordes visibles

            // Ajustar proporciones automáticas para filas y columnas
            for (int i = 0; i < table.ColumnCount; i++)
            {
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, i == 0 ? 20 : 16)); // Primera columna más ancha (horas)
            }
            for (int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / table.RowCount));
            }

            // Agregar encabezados de días
            table.Controls.Add(new Label() { Text = "", BackColor = Color.DarkGray }, 0, 0); // Celda vacía (esquina superior izquierda)
            for (int i = 0; i < dias.Length; i++)
            {
                table.Controls.Add(new Label()
                {
                    Text = dias[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = SystemColors.HotTrack,
                    ForeColor = Color.White, // Texto blanco para contraste
                    Font = new Font("Bahnschrift", 12, FontStyle.Regular), // Fuente Bahnschrift
                    Dock = DockStyle.Fill
                }, i + 1, 0); // Columnas de encabezado
            }

            // Agregar encabezados de horas
            for (int i = 0; i < horas.Length; i++)
            {
                table.Controls.Add(new Label()
                {
                    Text = horas[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = SystemColors.ActiveCaption,
                    ForeColor = Color.White, // Texto blanco para contraste
                    Font = new Font("Bahnschrift", 12, FontStyle.Regular), // Fuente Bahnschrift
                    Dock = DockStyle.Fill
                }, 0, i + 1); // Filas de encabezado
            }

            // Agregar celdas del horario con los ramos definidos
            for (int i = 0; i < horas.Length; i++)
            {
                for (int j = 0; j < dias.Length; j++)
                {
                    string ramo = ramos[i, j];
                    Label labelCelda = new Label()
                    {
                        Text = ramo, // Texto personalizado para cada celda
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill,
                        Font = new Font("Bahnschrift", 10, FontStyle.Regular),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = coloresRamos.ContainsKey(ramo) ? coloresRamos[ramo] : SystemColors.Control // Color asignado según el ramo
                    };

                    table.Controls.Add(labelCelda, j + 1, i + 1);
                }
            }
            this.Controls.Add(table);
        }
    }
}