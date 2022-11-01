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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pantallalogin_Load(object sender, EventArgs e)
        {
            Persistenciadedatos instanciaPersistencia = new Persistenciadedatos();
            instanciaPersistencia.InicializarArchivos();
            ClasePrincipal instanciaClasePrincipal = new ClasePrincipal();
            instanciaClasePrincipal.RellenarLista();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength < 0)
                MessageBox.Show("Ingresar caracteres");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validarusuario(string nombre, string clave)
        {
            return (nombre == "valentino") && (clave == "10");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {

                if (validarusuario(textBox1.Text.Trim(), textBox2.Text.Trim()))
                {
                    this.Hide();

                    Menuprincipal NuevaPantalla = new Menuprincipal();

                    NuevaPantalla.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o clave Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Usuario");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
