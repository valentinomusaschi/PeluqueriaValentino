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
    public partial class Bajacliente : Form
    { 
        ClasePrincipal principal = new ClasePrincipal();
        int Cliente; 
        public Bajacliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente = int.Parse(textBoxid.Text);
            principal.BajaCliente(Cliente);

            Pantcliente nuevaventana = new Pantcliente();
            nuevaventana.Show();

            this.Close();
        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bajacliente_Load(object sender, EventArgs e)
        {

        }
    }
}
