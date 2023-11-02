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


        //Configuracion de formularios por menu
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
            //Acá se esta configurando
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Purple;

            //Acá agregando el formulario al contenedor
            contenedor.Controls.Add(formulario);
            formulario.Show();

        }

        //Se encargara de mostrar el respectivo formulario por menu
        private void menUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios());
        }



        private void submenuRegistrarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuClientes, new FormClientes());
        }

        private void submenuListaCliente_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(menuTarjetas, new formListaClientes());
        }

        private void menuTarjetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormTarjetas());
        }
        
        private void menuPuntos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormPuntos());
        }

        private void menuInventarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem) sender, new FormInventario());
        }

        private void submenuHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuInformes, new FormInformes());
        }

    }

}
   

       

