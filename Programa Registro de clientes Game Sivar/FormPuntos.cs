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
using System.Data.Sql;

namespace Programa_Registro_de_clientes_Game_Sivar
{
    public partial class FormPuntos : Form
    {
        //Conexion con el servidor de la base de datos
        static string servidor = "localhost";
        static string bd = "gamesivar";
        static string usuario = "root";
        static string password = "root";

        static string cadenaConexion = $"server={servidor};user id={usuario};password={password};database={bd};";

        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);


        public FormPuntos()
        {
            InitializeComponent();
        }

        private void FormPuntos_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        //metodo para cargar los clientes de la base de datos
        private void CargarClientes()
        {
            try
            {
                conexionBD.Open();
                string consulta = "SELECT idClientes, CONCAT(nombre, ' ', apellido) as NombreCompleto FROM clientes";
                MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaClientes = new DataTable();
                adaptador.Fill(tablaClientes);

                //para meter los datos al combobox para que muestre y se seleccione un cliente para asociarlo a la tarjeta
                cmbClientes.DisplayMember = "NombreCompleto";
                cmbClientes.ValueMember = "idclientes";
                cmbClientes.DataSource = tablaClientes;
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


        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCliente = (int)cmbClientes.SelectedValue;
            CargarTarjetas(idCliente);
        }

        private void CargarTarjetas(int idCliente)
        {
            try
            {
                conexionBD.Open();
                string consulta = $"SELECT idtarjetas, tipo FROM tarjetas WHERE idcliente = {idCliente}";
                MySqlCommand cmd = new MySqlCommand(consulta, conexionBD);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                DataTable tablaTarjetas = new DataTable();
                adaptador.Fill(tablaTarjetas);

                // Asignar los datos al ComboBox para mostrar y seleccionar la tarjeta
                cmbTipoTarjetas.DisplayMember = "tipo";
                cmbTipoTarjetas.ValueMember = "idtarjetas";
                cmbTipoTarjetas.DataSource = tablaTarjetas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tarjetas: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Verificar que se ha seleccionado una tarjeta
            if (cmbTipoTarjetas.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una tarjeta antes de registrar el juego.");
                return;
            }

            //Obtiene el tipo de juego del ComboBox
            string tipoJuego = cmbTipoJuego.SelectedItem.ToString();


            int idCliente = (int)cmbClientes.SelectedValue;
            int idTarjeta = (int)cmbTipoTarjetas.SelectedValue;
            bool doblePuntos = checkDoblePuntos.Checked;

            decimal puntosGanados = CalcularPuntosGanados(idTarjeta, tipoJuego, doblePuntos);


            RegistrarTransaccion(idTarjeta, tipoJuego, puntosGanados);

            ActualizarSaldoActual(idTarjeta, puntosGanados);

            LimpiarCampos();

            MessageBox.Show("Juego registrado correctamente!");

        }


        private void RegistrarTransaccion(int idTarjeta, string tipoJuego, decimal puntosGanados)
        {
            try
            {
                conexionBD.Open();

                // Insertar la transacción en la base de datos
                string consultaRegistrarJuego = $"INSERT INTO transacciones (idtarjeta, fecha, monto, tipojuego, puntosobtenidos) " +
                                                $"VALUES ({idTarjeta}, CURDATE(), {puntosGanados}, '{tipoJuego}', {puntosGanados})";

                MySqlCommand cmdRegistrarJuego = new MySqlCommand(consultaRegistrarJuego, conexionBD);
                cmdRegistrarJuego.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar juego: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private decimal CalcularPuntosGanados(int idTarjeta, string tipoJuego, bool doblePuntos)
        {
            try
            {
                conexionBD.Open();

                decimal puntosGanados = (tipoJuego == "Electrónico") ? 3 : 5;

                if (doblePuntos)
                {
                    puntosGanados *= 2;
                }

                return puntosGanados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular puntos ganados: " + ex.Message);
                return 0;
            }
            finally
            {
                conexionBD.Close();
            }
        }

            //SaldoActual
            private void ActualizarSaldoActual(int idCliente, decimal puntosGanados)
        {
            try
            {
                conexionBD.Open();

                string consultaSaldo = $"SELECT saldo_actual FROM tarjetas WHERE idcliente = {idCliente}";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexionBD);

                decimal saldoActual = Convert.ToDecimal(cmdSaldo.ExecuteScalar());
                decimal nuevoSaldo = saldoActual + puntosGanados;

                string consultaActualizarSaldo = $"UPDATE tarjetas SET saldo_actual = {nuevoSaldo} WHERE idcliente = {idCliente}";
                MySqlCommand cmdActualizarSaldo = new MySqlCommand(consultaActualizarSaldo, conexionBD);
                cmdActualizarSaldo.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar saldo actual: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void RegistrarJuego(int idCliente, string tipoJuego, decimal puntosGanados)
        {
            try
            {
                conexionBD.Open();

                string consultaIdTarjeta = $"SELECT idtarjetas FROM tarjetas WHERE idcliente = {idCliente}";
                MySqlCommand cmdIdTarjeta = new MySqlCommand(consultaIdTarjeta, conexionBD);
                int idTarjeta = Convert.ToInt32(cmdIdTarjeta.ExecuteScalar());

                // Insertar la transacción en la base de datos
                string consultaRegistrarJuego = $"INSERT INTO transacciones (idtarjeta, fecha, monto, tipojuego, puntosobtenidos) " +
                                                $"VALUES ({idTarjeta}, CURDATE(), {puntosGanados}, '{tipoJuego}', {puntosGanados})";

                MySqlCommand cmdRegistrarJuego = new MySqlCommand(consultaRegistrarJuego, conexionBD);
                cmdRegistrarJuego.ExecuteNonQuery();

                MessageBox.Show("Juego registrado correctamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar juego: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void LimpiarCampos()
        {

            checkDoblePuntos.Checked = false;
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;
            consulta.CommandText = ("select * from transacciones");
            try
            {
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter();
                adaptadorMySQL.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvListaTransacciones.DataSource = tabla;
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
    }

}

