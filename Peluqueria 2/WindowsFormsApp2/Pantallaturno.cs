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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Pantallaturno : Form
    {
        Turno nuevo = new Turno();
        ClasePrincipal principal = new ClasePrincipal();
        public Pantallaturno()
        {
            InitializeComponent();
        }

        private void Pantallaturno_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevo = new Turno();
            nuevo.id = int.Parse(id.Text);
            nuevo.idcliente = int.Parse(idpersona.Text);
            nuevo.costo = int.Parse(costo.Text);
            nuevo.fecha = fecha.Text;
         

            principal = new ClasePrincipal();
            principal.RellenarLista();
            principal.AltaTurno(nuevo);

            Hide();
            Pantturno Nuevapantalla = new Pantturno();
            Nuevapantalla.Show();
        }

        private void idpersona_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
