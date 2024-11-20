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
    public partial class MenuPrincipal : Form
    {
        RegistroProfesores Menu = new RegistroProfesores();
        RegistroEstudiantes Menu2 = new RegistroEstudiantes();
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu.Show();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2.Show();
        }
    }
}
