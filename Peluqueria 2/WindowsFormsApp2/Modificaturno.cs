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
    public partial class Modificaturno : Form
    {
        ClasePrincipal principal = new ClasePrincipal();
        Turno turnoModificado = new Turno();
        int turno;
        public Modificaturno()
        {
            InitializeComponent();
        }

        private void Modificaturno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                turno = int.Parse(TexBoxid.Text);

              

                    turnoModificado.idcliente = int.Parse(TexBoxidcliente.Text);
                    turnoModificado.costo = int.Parse(Texboxcosto.Text);
                    turnoModificado.fecha = TexBoxfecha.Text;
                    turnoModificado.id = int.Parse(TexBoxid.Text);

                    principal = new ClasePrincipal();
                    principal.RellenarLista();
                    principal.modificarturno(turnoModificado, turno);

                    this.Close();
                    Pantturno NuevaPantalla = new Pantturno();
                    NuevaPantalla.Show();

            }

        }

        private void TexBoxidpersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Texboxcosto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
