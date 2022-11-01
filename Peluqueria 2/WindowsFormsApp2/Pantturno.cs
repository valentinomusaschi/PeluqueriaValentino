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
    public partial class Pantturno : Form
    {
        public Pantturno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pantturno_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciapersistencia = new Persistenciadedatos();
            instanciapersistencia.InicializarArchivos();
            ClasePrincipal instanciaclasePrincipal = new ClasePrincipal();
            instanciaclasePrincipal.RellenarLista();
            dataGridView1.DataSource = instanciaclasePrincipal.ValidarTurno();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantallaturno nuevaventana = new Pantallaturno();
            nuevaventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificaturno nuevaventana = new Modificaturno();
            nuevaventana.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bajaturno nuevaventana = new Bajaturno();
            nuevaventana.Show();

            this.Close();
        }
    }
}
