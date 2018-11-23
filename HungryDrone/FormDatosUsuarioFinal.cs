using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormDatosUsuarioFinal : Form
    {
        public FormDatosUsuarioFinal(string nombre, double lat, double lng, float total, byte torta, byte gringas, byte sopes, byte hotdogs, byte sushi, byte pizza, byte pasta, byte burro, byte burguer)
        {
            InitializeComponent();
            lblUsuario.Text = nombre;
            lblTorta.Text = torta.ToString();
            lblGringa.Text = gringas.ToString();
            lblSope.Text = sopes.ToString();
            lblHotDog.Text = hotdogs.ToString();
            lblSuchi.Text = sushi.ToString();
            lblPizza.Text = pizza.ToString();
            lblPasta.Text = pasta.ToString();
            lblBurro.Text = burro.ToString();
            lblBurguer.Text = burguer.ToString();
        }

        
    }
}
