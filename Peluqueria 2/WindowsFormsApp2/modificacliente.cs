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
    public partial class modificacliente : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Cliente clienteModificado = new Cliente();
        int cliente;
        public modificacliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente = int.Parse(textBoxid.Text);

            if (textBoxnombre.Text.Length > 5 && TexBoxtelefono.Text.Length > 5 && TexBoxgmail.Text.Length > 6  && TexBoxdni.Text.Length > 5 && TexBoxdireccion.Text.Length > 4)
            {

                clienteModificado.telefono = TexBoxtelefono.Text;
                clienteModificado.gmail = TexBoxgmail.Text;
                clienteModificado.nombre = textBoxnombre.Text;
                clienteModificado.dni = int.Parse(TexBoxdni.Text); 
                clienteModificado.direccion = TexBoxdireccion.Text;
                clienteModificado.id = int.Parse(textBoxid.Text);

                principal = new ClasePrincipal();
                principal.RellenarLista();
                principal.modificarcliente(clienteModificado, cliente);

                this.Close();
                Pantcliente NuevaPantalla = new Pantcliente();
                NuevaPantalla.Show();
            }
            else
            {
                MessageBox.Show("DEBE COMPLETAR LOS CAMPOS DE FORMA CORRECTA");
            }
        }

        private void TexBoxtelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TexBoxgmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TexBoxdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificacliente_Load(object sender, EventArgs e)
        {

        }
    }
    }
