using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogin.App_Code
{
    class Conexion
    {
        SqlConnection con = new SqlConnection();

        public SqlConnection Con { get { return con; } set { con = value; } }

        public Conexion()
        {
            this.con.ConnectionString = "Data Source = LAPTOP-D9O5OKFU\\SQLEXPRESS; Initial Catalog=BD_CLASE;Integrated Security=True";
        }
        public void conectar()
        {
            try
            {
                this.con.Open();
                MessageBox.Show("Conexión exitosa.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de conexion.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado.\n" + ex.Message);
            }
        }
        public void desconectar()
        {
            this.con.Close();
            MessageBox.Show("Desconexión exitosa.");
        }
    }
}
