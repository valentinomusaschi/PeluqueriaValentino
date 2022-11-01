using Logica_Peluqueria_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bajaproducto : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        int Producto;
        public Bajaproducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto = int.Parse(textBoxid.Text);
            principal.BajaProducto(Producto);

            Pantproducto nuevaventana = new Pantproducto();
            nuevaventana.Show();

            this.Close();
        }
    }
}
