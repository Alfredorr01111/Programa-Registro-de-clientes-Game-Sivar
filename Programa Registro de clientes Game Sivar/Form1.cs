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

namespace Programa_Registro_de_clientes_Game_Sivar
{
    public partial class frmLogin : Form
    {
        // Define errorProvider como un campo de clase
        private ErrorProvider errorProvider = new ErrorProvider();

        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            if (user != "usuarioValido" || password != "contrasenaValida")
            {
                errorProvider.SetError(txtUser, "Nombre de usuario o contraseña incorrectos.");
                errorProvider.SetError(txtPassword, "Nombre de usuario o contraseña incorrectos.");
                return;
            }

            // Abrir el formulario principal y cerrar el formulario de inicio de sesión si las credenciales son válidas.
            mainMenu mainForm = new mainMenu();
            mainForm.Show();
            this.Hide();

        }
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Mostrar el formulario de inicio de sesión al iniciar la aplicación.
                Application.Run(new frmLogin());
            }
        }
    }

    //este metodo encripta la contraseña
    //Hola mundo
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes("TuClaveSecreta")))
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = hmac.ComputeHash(passwordBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
