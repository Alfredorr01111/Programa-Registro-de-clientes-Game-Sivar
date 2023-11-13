using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
using MySql.Data.MySqlClient;


namespace Programa_Registro_de_clientes_Game_Sivar
{
    public partial class Principal : Form
    {
        //Para el formulario activo en el momento, se mostrara en el form "Principal"
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Principal() 
        {
            InitializeComponent();
        }

        //Configuracion de aspectos del los menus
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
      
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Purple;

            //Acá se agrega el formulario al contenedor
            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        //Se encargara de mostrar el respectivo formulario por menu
        private void menUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());
        }

        private void menuTarjetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormTarjetas());
        }   
         
        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuClientes, new FormClientes());
        }

        private void menuInventarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuInventarios, new FormInventario());
        }

        private void iconmenuTransaccion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuPuntos, new FormPuntos());
        }

        private void iconmenuCanjear_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuPuntos, new FormCanjear());
        }

        private void menucerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
   

       

