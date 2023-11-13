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
    public partial class FormInventario : Form
    {
        // Declaración de la conexión a la base de datos
        static string servidor = "localhost";
        static string bd = "gamesivar";
        static string usuario = "root";
        static string password = "root";

        static string cadenaConexion = $"server={servidor};user id={usuario};password={password};database={bd};";

        MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarInventarios();
        }


        // Método para cargar los datos de inventarios
        private void CargarInventarios()
        {
            try
            {
                conexionBD.Open();

                string consulta = "SELECT * FROM inventarios";
                MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaInventarios = new DataTable();
                adaptador.Fill(tablaInventarios);

                if (tablaInventarios.Rows.Count > 0)
                {
                    // Muestra los datos en los controles correspondientes
                    lblExistenciasGold.Text = tablaInventarios.Rows[0]["existencia_productos"].ToString();
                    lblTarjetaMasVendida.Text = tablaInventarios.Rows[0]["tipo_tarjeta_mas_vendida"].ToString();
                    lblTarjetaMenosVendida.Text = tablaInventarios.Rows[0]["tipo_tarjeta_menos_vendida"].ToString();

                    // Carga los detalles de inventario en el DataGridView
                    dgvInventarios.DataSource = tablaInventarios;
                }
                else
                {
                    MessageBox.Show("No hay datos de inventarios disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventarios: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

         // Evento del botón "Lista" para mostrar los detalles de inventario
         private void btnLista_Click(object sender, EventArgs e)
         {
                CargarInventarios();
         }


        private void ActualizarExistencias(int cantidadAsignada)
        {
            try
            {
                conexionBD.Open();

                // Obtén las existencias actuales
                string consultaExistencias = "SELECT existencia_productos FROM inventarios";
                MySqlCommand cmdExistencias = new MySqlCommand(consultaExistencias, conexionBD);
                int existenciasActuales = Convert.ToInt32(cmdExistencias.ExecuteScalar());

                // Actualiza las existencias restando la cantidad asignada
                int nuevasExistencias = existenciasActuales - cantidadAsignada;

                // Actualiza las existencias en la base de datos
                string consultaActualizarExistencias = $"UPDATE inventarios SET existencia_productos = {nuevasExistencias}";
                MySqlCommand cmdActualizarExistencias = new MySqlCommand(consultaActualizarExistencias, conexionBD);
                cmdActualizarExistencias.ExecuteNonQuery();

                // Vuelve a cargar los datos de inventarios después de la actualización
                CargarInventarios();

                MessageBox.Show($"Existencias actualizadas. Cantidad asignada: {cantidadAsignada}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar existencias: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }

}

