using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Peluqueria_2
{
    public class Turno
    {
        public int id { get; set; }
        public int idcliente { get; set; }
        public string fecha { get; set; }
        public int costo { get; set; }

        public int demora_estimada { get; set; }
        public int hora_disponible { get; set; }
    }
}
