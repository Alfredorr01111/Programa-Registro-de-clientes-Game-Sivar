using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaTablas
{
    public class Historial
    {
        public int idHistorial { get; set; }
        public string fechaCanjeado { get; set; }
        public int puntosUtilizados { get; set; }
        
        //Me imagino que ira conectado con otro
        public string idCliente { get; set; }
        public string idProducto { get; set; }
    }
}
