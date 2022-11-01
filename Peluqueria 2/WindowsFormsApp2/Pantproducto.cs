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
    public partial class Pantproducto : Form
    {
        public Pantproducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallaproducto nuevaventana = new Pantallaproducto();
            nuevaventana.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pantproducto_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciapersistencia = new Persistenciadedatos();
            instanciapersistencia.InicializarArchivos();
            ClasePrincipal instanciaclasePrincipal = new ClasePrincipal();
            instanciaclasePrincipal.RellenarLista();
            dataGridView1.DataSource = instanciaclasePrincipal.ValidarProducto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bajaproducto nuevaventana = new Bajaproducto();
            nuevaventana.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarproducto nuevaventana = new modificarproducto();
            nuevaventana.Show();

            this.Close();
        }
    }
}
