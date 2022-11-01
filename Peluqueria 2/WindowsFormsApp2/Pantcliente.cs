using System;
using Logica_Peluqueria_2;
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
    public partial class Pantcliente : Form
    {
        public Pantcliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pantcliente_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciapersistencia = new Persistenciadedatos();
            instanciapersistencia.InicializarArchivos();
            ClasePrincipal instanciaclasePrincipal = new ClasePrincipal();
            instanciaclasePrincipal.RellenarLista();
            dataGridView1.DataSource = instanciaclasePrincipal.ValidarCliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallacliente nuevaventana = new Pantallacliente();
            nuevaventana.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bajacliente nuevaventana = new Bajacliente();
            nuevaventana.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificacliente nuevaventana = new modificacliente();
            nuevaventana.Show();

            this.Close(); 
        }
    }
}
