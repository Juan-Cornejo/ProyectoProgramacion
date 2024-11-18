using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestLogin
{
    public partial class MenuPrincipal : Form
    {
        RegistroProfesores Menu = new RegistroProfesores();
        RegistroEstudiantes Menu1 = new RegistroEstudiantes();
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
            Menu1.Show();
            this.Hide();
        }
    }
}
