using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Peluqueria_2
{
    public class Cliente: Persona
    {
        public int id { get; set; }
        public int idpersona { get; set; }
        public int idturno { get; set; }
        public int idcompra { get; set; }
    }
}
