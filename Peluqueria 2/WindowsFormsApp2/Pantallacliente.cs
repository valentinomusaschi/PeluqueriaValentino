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
    public partial class Pantallacliente : Form
    {
        Cliente nuevo = new Cliente();
        ClasePrincipal principal = new ClasePrincipal();

        public Pantallacliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo = new Cliente();
            nuevo.nombre = textBoxnombre.Text;
            nuevo.telefono = TexBoxtelefono.Text;
            nuevo.gmail = TexBoxgmail.Text;
            nuevo.dni = int.Parse(TexBoxdni.Text);
            nuevo.direccion = TexBoxdireccion.Text;
            nuevo.id = int.Parse(textBoxid.Text);
            
            principal = new ClasePrincipal();
            principal.RellenarLista();
            principal.AltaCliente(nuevo);

            Hide();
            Pantcliente Nuevapantalla = new Pantcliente();
            Nuevapantalla.Show();

        }

        private void Pantallacliente_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}