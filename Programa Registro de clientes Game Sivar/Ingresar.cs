using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Programa_Registro_de_clientes_Game_Sivar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            chkmostrarPass.CheckedChanged += chkmostrarPass_CheckedChanged;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string contraseña = txtPassword.Text;


            // Credenciales válidas, muestra el formulario principal
            bool credencialesValidas = ValidarCredenciales(user, contraseña);

            if (credencialesValidas)
            {                
                Principal form = new Principal();
                form.Show();
                this.Hide();
                form.FormClosing += frmClosing;
            }
            else
            {
                // Credenciales inválidas, muestra un mensaje de error.
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
            }
          
        }

        // Este es para regresar al anterior de inicio de sesion y borrar los datos
        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtUser.Focus();
            this.Show();
        }

        // Realiza una consulta a la base de datos para verificar las credenciales
        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user id=root;password=root;database=gamesivar;"))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM usuarios_sistema WHERE nombre_usuario = @usuario AND contrasenia_usuario = @contrasenia";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasenia", contraseña);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0; // si count es mayor que 0, las credenciales son válidas.
            }
        }




        // Botón Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Para mostrar la contraseña con la casilla check
        private void chkmostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkmostrarPass.Checked)
    {
                // Mostrar la contraseña como texto legible, estableciendo el passwordchar en un valor nulo
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                // Ocultar la contraseña (mostrar asteriscos *)
                txtPassword.PasswordChar = '*';
            }
        }
    } 


}