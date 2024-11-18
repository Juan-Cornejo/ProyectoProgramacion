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

        private void linkLabelProfesores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu.Show();
            this.Hide();
        }

        private void linkLabelEstudiantes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu2.Show();
            this.Hide();
        }
    }
}
