using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Registro_de_clientes_Game_Sivar
{
    public partial class FormUsuarios : Form
    {
        static string servidor = "localhost";
        static string bd = "gamesivar";
        static string usuario = "root";
        static string password = "root";

        static string cadenaConexion = $"server={servidor};user id={usuario};password={password};database={bd};";

        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);


        public FormUsuarios()
        {
            InitializeComponent();
        }

        //Boton agregar a la tabla usuarios
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;  
            consulta.CommandText = $"insert into usuarios_sistema (nombre_usuario, contrasenia_usuario) values ('{txtUser.Text}', '{txtPassword.Text}')";
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);

                consulta.CommandText = ("select * from usuarios_sistema");
                adaptadorMySQL.Fill(tabla);
                dgvTabla.DataSource = tabla;
                MessageBox.Show("Agregado Exitosamente!!");
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;
            consulta.CommandText = ("select * from usuarios_sistema");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvTabla.DataSource = tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTabla.CurrentRow.Cells["idusuarios"].Value);
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;
            consulta.CommandText = $"DELETE FROM usuarios_sistema WHERE idusuarios = {id}";


            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                MessageBox.Show("Elemento eliminado!!");

                consulta.CommandText = ("select * from usuarios_sistema");
                adaptadorMySQL.Fill(tabla);
                dgvTabla.DataSource = tabla;
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LimpiarCampos()
        {
            txtUser.Clear();
            txtPassword.Clear();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTabla.CurrentRow.Cells["idusuarios"].Value);
                MySqlCommand consulta = new MySqlCommand();
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                consulta.Connection = conexionBD;

                // Obtenemos los nuevos datos de los TextBox
                string nuevoNombre = txtUser.Text;
                string nuevaContraseña = txtPassword.Text;

                // Realizamos la actualización en la base de datos
                consulta.CommandText = $"UPDATE usuarios_sistema SET nombre_usuario = '{nuevoNombre}', contrasenia_usuario = '{nuevaContraseña}' WHERE idusuarios = {id}";

                try
                {
                    conexionBD.Open();
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado exitosamente!");

                    // Actualizamos la vista con los datos actualizados
                    consulta.CommandText = "SELECT * FROM usuarios_sistema";
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter(consulta);
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla);
                    dgvTabla.DataSource = tabla;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para modificar.");
            }
        }
    }
}
