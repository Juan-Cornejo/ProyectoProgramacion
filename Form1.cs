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
            if (txtbUser.Text == "test" && txtbPassword.Text == "1234")
            {
                new AdminForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contrase�a es incorrecto, int�ntelo nuevamente."
                    ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbUser.Clear();
                txtbPassword.Clear();
                txtbUser.Focus();
            }
        }
    }
}
