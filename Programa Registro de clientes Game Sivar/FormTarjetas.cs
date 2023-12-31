﻿using MySql.Data.MySqlClient;
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
    public partial class FormTarjetas : Form
    {
        //Conexion con el servidor de la base de datos
        static string servidor = "localhost";
        static string bd = "gamesivar";
        static string usuario = "root";
        static string password = "root";

        static string cadenaConexion = $"server={servidor};user id={usuario};password={password};database={bd};";

        static MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        //Se agrega una propiedad para almacenar la instancia del FormPuntos
        public FormPuntos FormuularioPuntos { get; set; }

        // Agregar propiedad para obtener la lista de transacciones
        public DataGridView ListaTransacciones => dgvListaTransacciones;

        public DataGridView dgvListaTransacciones { get; private set; }

        public FormTarjetas()
        {
            InitializeComponent();
            Load += FormTarjetas_Load; 
            cmbTipoTarjetas.SelectedIndexChanged += cmbTipoTarjetas_SelectedIndexChanged;  
        }
        public void MostrarListaTransacciones()
        {
            // Código para mostrar la lista de transacciones en dgvListaTransacciones
        }



        //Es para que al seleccionar un tipo de tarjeta se escriba en automatico para evitar hacerlo manualmente, asi esta predefinido, con la fecha de vencimiento de la tarjeta se hizo que se ponga la fecha actual
        private void cmbTipoTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoTarjeta = cmbTipoTarjetas.Text;

            //Esstablece el límite de credito según el tipo de tarjeta
            switch (tipoTarjeta)
            {
                case "Gold":
                    txtLimiteCredito.Text = "300";
                    break;
                case "Silver":
                    txtLimiteCredito.Text = "150";
                    break;
                case "Plus":
                    txtLimiteCredito.Text = "50";
                    break;
                default:
                    break;
            }

            //establece la fecha de vencimiento para el propio mes
            DateTime fechaVencimiento = DateTime.Now.AddMonths(1);
            txtFechaVencimiento.Text = fechaVencimiento.ToString("yyyy-MM-dd");
        }


        private void FormTarjetas_Load(object sender, EventArgs e)
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

        //Boton agregar, que agrega el nuevo registro a la tabla tarjetas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
            string tipoTarjeta = cmbTipoTarjetas.Text;
            decimal limiteCredito;

            //Esta era una validacion pero se puso en automatico al seleccionarse una tarjeta
            if (decimal.TryParse(txtLimiteCredito.Text, out limiteCredito))
            {
                //si el valor es un numero decimal valido, puedes usarse limiteCredito 
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el límite de crédito.");
            }

            decimal saldoActual = 0; //Inicializamos el saldo actual en 0


            //Valida el formato de fecha en yyyy-MM-dd como esta en la base de datos
            if (DateTime.TryParse(txtFechaVencimiento.Text, out DateTime fechaVencimiento))
            {

                int puntosAcumulados = 0;


                //Resto del código para insertar en la base de datos
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexionBD;
                cmd.CommandText = $"INSERT INTO tarjetas (idcliente, tipo, limitecredito, saldo_actual, fecha_vencimiento, puntos) VALUES ({idCliente}, '{tipoTarjeta}', {limiteCredito}, {saldoActual}, '{fechaVencimiento.ToString("yyyy-MM-dd")}', {puntosAcumulados})";


                try
                {
                    //abre la conexión y ejecuta la consulta
                    conexionBD.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tarjeta agregada exitosamente!");

                    //Limpia los controles despues de que se agregan
                    LimpiarCampos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al agregar tarjeta: {ex.Message}");
                }
                finally
                {
                    //cierra la conexion
                    conexionBD.Close();
                }

            }
            else
            {
                MessageBox.Show("Fecha de vencimiento no válida. Por favor, ingrese una fecha válida en formato 'yyyy-MM-dd'.");
            }

        }

        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            txtSaldoActual.Text = "";
            txtLimiteCredito.Text = "";
            txtFechaVencimiento.Text = "";
        }

        //Boton lista para mostrar los registros que hay
        private void btnLista_Click_1(object sender, EventArgs e)
        {
            MySqlCommand consulta = new MySqlCommand();
            conexionBD.Open();
            consulta.Connection = conexionBD;
            consulta.CommandText = ("select * from tarjetas");
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

        public void ActualizarTablaTarjetas()
        {
            // Método para actualizar la tabla de tarjetas desde el FormPuntos
            try
            {
                conexionBD.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tarjetas", conexionBD);
                MySqlDataAdapter adaptadorMySQL = new MySqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptadorMySQL.Fill(tabla);
                dgvTabla.DataSource = tabla;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar la tabla de tarjetas: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


    }
}
