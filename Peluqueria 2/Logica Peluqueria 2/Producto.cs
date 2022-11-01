using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Peluqueria_2
{
    public class Producto
    {
		public int id { get; set; }
		public int idcliente { get; set; }
		public int idprecio { get; set; }
		public string tipo { get; set; }
		public int cantidad { get; set; }
	}
}
