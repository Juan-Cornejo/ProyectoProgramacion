namespace TestLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtbUser.Text == "admin" && txtbPassword.Text == "1234")
            {
                new MenuPrincipal().Show();
                this.Hide();
                MessageBox.Show("Bienvenido Admin.",
                    "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtbUser.Text == "user@alu.cc.cl" && txtbPassword.Text == "1234")
            {
                new MenuEstudiante().Show();
                this.Hide();
                MessageBox.Show("Bienvenido Estudiante.",
                    "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El usuario o contraseña es incorrecto, inténtelo nuevamente."
                    ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbUser.Clear();
                txtbPassword.Clear();
                txtbUser.Focus();
            }
        }
    }
}
