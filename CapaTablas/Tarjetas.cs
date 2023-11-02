using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaTablas
{
    public class Tarjetas
    {
        public int idTarjetas { get; set; }
        public string tipo { get; set; }
        public int limiteCredito { get; set; }
        public decimal saldoActual { get; set; }
        public string fechaVencimineto { get; set; }
        
        //conectado
        public int idCliente { get; set; }
    }
}
