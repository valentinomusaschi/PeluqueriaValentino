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
    public partial class modificarproducto : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Producto productoModificado = new Producto();
        int producto;
        public modificarproducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                producto = int.Parse(textBoxid.Text);



                productoModificado.idcliente = int.Parse(textBoxidcliente.Text);
                productoModificado.tipo = textBoxTipo.Text;
                productoModificado.cantidad = int.Parse(textBoxCantidad.Text);
                productoModificado.id = int.Parse(textBoxid.Text);
              

                principal = new ClasePrincipal();
                principal.RellenarLista();
                principal.modificarproducto(productoModificado, producto);

                this.Close();
                Pantproducto NuevaPantalla = new Pantproducto();
                NuevaPantalla.Show();

            }
        }

        private void textBoxTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
