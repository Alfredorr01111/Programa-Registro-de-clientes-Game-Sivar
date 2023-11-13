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
    public partial class FormClientes : Form
    {
        private static string cadenaConexion = "server=localhost;port=3306;user id=root;password=root;database=gamesivar";

        private MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);


        public FormClientes()
        {
            InitializeComponent();
        }

        //Muestra la lista de registros 
        private void btnLista_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter("SELECT * FROM clientes", conexionBD))
                {
                    adaptadorMySQL.Fill(tabla);
                }

                dgvTabla.DataSource = tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message);
            }
        }

        //Agrega un nuevo registro
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                conexionBD.Open();

                //Inserta los datos la base de datos
                using (MySqlCommand consulta = new MySqlCommand("INSERT INTO clientes (Nombre, Apellido, Fecha_nacimiento) VALUES (@nombre, @apellidos, @fechaNacimiento)", conexionBD))
                {
                    consulta.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    consulta.Parameters.AddWithValue("@apellidos", txtApellido.Text);
                    consulta.Parameters.AddWithValue("@fechaNacimiento", txtFecha.Text);

                    consulta.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente Agregado Exitosamente!");
                LimpiarCampos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        //elimina un registro
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvTabla.CurrentRow.Cells["idClientes"].Value);
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;
            consulta.CommandText = $"DELETE FROM clientes WHERE idClientes = {id}";
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                MessageBox.Show("Cliente eliminado!!");

                consulta.CommandText = ("select * from clientes");
                adaptadorMySQL.Fill(tabla);
                dgvTabla.DataSource = tabla;
            }
            finally
            {
                conexionBD.Close();
            }
        }

        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtFecha.Clear();

        }

        //Modifica un registro
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTabla.CurrentRow.Cells["idClientes"].Value);
                MySqlCommand consulta = new MySqlCommand();
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                consulta.Connection = conexionBD;

                //se obtienen los nuevos datos de los TextBox
                string nuevoNombre = txtNombre.Text;
                string nuevoApellido = txtApellido.Text;
                string nuevaFecha = txtFecha.Text;

                //se realiza la actualización en la base de datos
                consulta.CommandText = $"UPDATE clientes SET Nombre = '{nuevoNombre}', Apellido = '{nuevoApellido}', Fecha_nacimiento = '{nuevaFecha}' WHERE idClientes = {id}";

                try
                {
                    conexionBD.Open();
                    consulta.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado exitosamente!");

                    //muestra la lista con los datos actualizados
                    consulta.CommandText = "SELECT * FROM clientes";
                    MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter(consulta);
                    DataTable tabla = new DataTable();
                    adaptadorMySQL.Fill(tabla);
                    dgvTabla.DataSource = tabla;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para modificar.");
            }
        }

    }
    
}
