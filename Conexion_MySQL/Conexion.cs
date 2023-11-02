using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Conexion_MySQL
{
    public class Conexion
    {
        //Se encargara de enviar la cadena de conexion que tenemos de las demas clases
        public static string cadena = ConfigurationManager.ConnectionStrings[""].ToString();


    }
}
