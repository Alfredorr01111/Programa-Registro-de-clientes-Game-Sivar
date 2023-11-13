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
    public partial class FormCanjear : Form
    {
        // Conexión con el servidor de la base de datos
        static string servidor = "localhost";
        static string bd = "gamesivar";
        static string usuario = "root";
        static string password = "root";

        static string cadenaConexion = $"server={servidor};user id={usuario};password={password};database={bd};";

        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        public FormCanjear()
        {
            InitializeComponent();
        }

        private void FormCanjear_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                conexionBD.Open();

                // Consulta para obtener clientes con tarjetas asociadas
                string consultaClientes = "SELECT DISTINCT c.idClientes, CONCAT(c.Nombre, ' ', c.Apellido) as NombreCompleto " +
                                          "FROM clientes c " +
                                          "INNER JOIN tarjetas t ON c.idClientes = t.idcliente";

                MySqlCommand cmdClientes = new MySqlCommand(consultaClientes, conexionBD);
                MySqlDataAdapter adaptadorClientes = new MySqlDataAdapter(cmdClientes);
                DataTable tablaClientes = new DataTable();
                adaptadorClientes.Fill(tablaClientes);

                if (tablaClientes.Rows.Count == 0)
                {
                    MessageBox.Show("No hay clientes con tarjetas asociadas.");
                    this.Close();
                }
                else
                {
                    cmbClientes.DisplayMember = "NombreCompleto";
                    cmbClientes.ValueMember = "idClientes";
                    cmbClientes.DataSource = tablaClientes;

                    CargarTarjetasAsociadas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void CargarTarjetasAsociadas()
        {
            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);

            try
            {
                conexionBD.Open();

                // Consulta para obtener tarjetas asociadas al cliente seleccionado
                string consultaTarjetas = $"SELECT idtarjetas, tipo FROM tarjetas WHERE idcliente = {idCliente}";

                MySqlCommand cmdTarjetas = new MySqlCommand(consultaTarjetas, conexionBD);
                MySqlDataAdapter adaptadorTarjetas = new MySqlDataAdapter(cmdTarjetas);
                DataTable tablaTarjetas = new DataTable();
                adaptadorTarjetas.Fill(tablaTarjetas);

                // Asigna el origen de datos al ComboBox de tarjetas
                cmbTipoTarjetas.DisplayMember = "tipo";
                cmbTipoTarjetas.ValueMember = "idtarjetas";
                cmbTipoTarjetas.DataSource = tablaTarjetas;

                // Muestra los puntos acumulados por todas las tarjetas del cliente
                MostrarPuntosAcumulados(idCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tarjetas asociadas: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al cambiar el cliente seleccionado, cargar las tarjetas asociadas
            CargarTarjetasAsociadas();
        }

        private void cmbTipoTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //al cambiar la tarjeta seleccionada, debe mostrar los puntos de la tarjeta
            MostrarPuntosTarjeta();
        }

        private void MostrarPuntosAcumulados(int idCliente)
        {
            try
            {
                conexionBD.Open();

                string consultaPuntosAcumulados = $"SELECT SUM(puntos) as PuntosAcumulados FROM tarjetas WHERE idcliente = {idCliente}";

                MySqlCommand cmdPuntosAcumulados = new MySqlCommand(consultaPuntosAcumulados, conexionBD);
                object resultado = cmdPuntosAcumulados.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int puntosAcumulados))
                {
                    lblAcumulados.Text = $"Puntos Acumulados: {puntosAcumulados}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener puntos acumulados: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void MostrarPuntosTarjeta()
        {
            int idTarjeta = Convert.ToInt32(cmbTipoTarjetas.SelectedValue);

            try
            {
                conexionBD.Open();

                string consultaPuntosTarjeta = $"SELECT puntos FROM tarjetas WHERE idtarjetas = {idTarjeta}";

                MySqlCommand cmdPuntosTarjeta = new MySqlCommand(consultaPuntosTarjeta, conexionBD);
                object resultado = cmdPuntosTarjeta.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int puntosTarjeta))
                {
                    lblPuntosTarjeta.Text = $"Puntos en Tarjeta: {puntosTarjeta}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener puntos de la tarjeta: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnCanjear_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);

            int idTarjeta = Convert.ToInt32(cmbTipoTarjetas.SelectedValue);

            int puntosTarjeta = ObtenerPuntosTarjeta(idTarjeta);

            int puntosAcumulados = ObtenerPuntosAcumulados(idCliente);

            lblPuntosTarjeta.Text = $"Puntos en Tarjeta: {puntosTarjeta}";

            lblAcumulados.Text = $"Puntos Acumulados: {puntosAcumulados}";

            MostrarPuntosTarjeta();
            MostrarPuntosAcumulados(idCliente);
            LimpiarControles();
        }

        private int ObtenerPuntosTarjeta(int idTarjeta)
        {
            string consultaPuntosTarjeta = $"SELECT puntos FROM tarjetas WHERE idtarjetas = {idTarjeta}";

            try
            {
                conexionBD.Open();
                MySqlCommand cmdPuntosTarjeta = new MySqlCommand(consultaPuntosTarjeta, conexionBD);
                object resultado = cmdPuntosTarjeta.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int puntosTarjeta))
                {
                    return puntosTarjeta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener puntos de la tarjeta: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            return 0;
        }

        private int ObtenerPuntosAcumulados(int idCliente)
        {
            // Consulta para obtener los puntos acumulados por todas las tarjetas del cliente
            string consultaPuntosAcumulados = $"SELECT SUM(puntos) as PuntosAcumulados FROM tarjetas WHERE idcliente = {idCliente}";

            try
            {
                conexionBD.Open();
                MySqlCommand cmdPuntosAcumulados = new MySqlCommand(consultaPuntosAcumulados, conexionBD);
                object resultado = cmdPuntosAcumulados.ExecuteScalar();

                if (resultado != null && int.TryParse(resultado.ToString(), out int puntosAcumulados))
                {
                    return puntosAcumulados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener puntos acumulados: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            return 0;
        }

        private void LimpiarControles()
        {
            // Limpia la selección de los ComboBox
            cmbClientes.SelectedIndex = -1;
            cmbTipoTarjetas.SelectedIndex = -1;

            // Limpia las etiquetas
            lblPuntosTarjeta.Text = "Puntos en Tarjeta: ";
            lblAcumulados.Text = "Puntos Acumulados: ";
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            MostrarListaCanjes();

        }
        private void MostrarListaCanjes()
        {
            try
            {
                conexionBD.Open();

                string consulta = "SELECT * FROM canjeproductos";

                MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter(cmd);
                DataTable tablaCanjes = new DataTable();
                adaptadorMySQL.Fill(tablaCanjes);

                dgvProductosCanjeados.DataSource = tablaCanjes; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de canjes: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


    }
}


    

