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
        HomePage home;
        private float total;
        private byte torta;
        private byte gringas;
        private byte sopes;
        private byte hotdogs;
        private byte sushi;
        private byte pizza;
        private byte pasta;
        private byte burro;
        private byte burguer;

        public FormDatosUsuarioFinal(HomePage homePage)
        {
            InitializeComponent();
            home = homePage;
            lblUsuario.Text = home.nomUsuario;
            total = home.total;
            torta = home.torta;
            gringas = home.gringas;
            sopes = home.sopes;
            hotdogs = home.hotdogs;
            sushi = home.sushi;
            pizza = home.pizza;
            pasta = home.pasta;
            burro = home.burro;
            burguer = home.burguer;
            /*
            lblTorta.Text = torta.ToString();
            lblGringa.Text = gringas.ToString();
            lblSope.Text = sopes.ToString();
            lblHotDog.Text = hotdogs.ToString();
            lblSuchi.Text = sushi.ToString();
            lblPizza.Text = pizza.ToString();
            lblPasta.Text = pasta.ToString();
            lblBurro.Text = burro.ToString();
            lblBurguer.Text = burguer.ToString();
            */
        }

        
    }
}
