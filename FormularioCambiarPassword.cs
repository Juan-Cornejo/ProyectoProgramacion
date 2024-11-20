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
    public partial class FormularioCambiarPassword : Form
    {
        private string contraseñaActual = "1234";
        public FormularioCambiarPassword()
        {
            InitializeComponent();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuEstudiante().Show();
        }
        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            if (txtbOldPass.Text != contraseñaActual)
            {
                MessageBox.Show("La contraseña actual es incorrecta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtbNewPass.Text != txtbConfirmNewPass.Text)
            {
                MessageBox.Show("La nueva contraseña y la confirmación no coinciden.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtbNewPass.Text))
            {
                MessageBox.Show("La nueva contraseña no puede estar vacía.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            contraseñaActual = txtbNewPass.Text;

            MessageBox.Show("Contraseña cambiada exitosamente.",
                "Contraseña cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            new MenuEstudiante().Show();
        }
    }
}
