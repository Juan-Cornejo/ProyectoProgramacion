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
    public partial class MenuEstudiante : Form
    {
        public MenuEstudiante()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
        private void btnHorario_Click(object sender, EventArgs e)
        {
            Horario HorarioForm = new Horario();
            this.Hide();
            HorarioForm.Show();
        }
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            FormularioCambiarPassword CambiarPasswordForm = new FormularioCambiarPassword();
            CambiarPasswordForm.Show();
        }
        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormularioCursos CursosForm = new FormularioCursos();
            this.Hide();
            CursosForm.Show();
        }
    }
}
