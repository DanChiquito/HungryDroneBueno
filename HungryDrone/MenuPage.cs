using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using ManejaProducto;

namespace HungryDrone
{
    public partial class FormMenu : Form
    {
        #region Atributos

        Producto Gringa = new Producto("Gringa de chorizo", 70 , true);

        Producto Torta = new Producto("Torta loca", 65, true);

        Producto HotDog = new Producto("Hot Dog Campesino", 35 , true);

        Producto Sushi = new Producto("Sushi con huevos de pescado", 130, true);

        Producto Pizza = new Producto("Pizza Capricciosa", 220, true);

        Producto Pasta = new Producto("Pasta con salmon", 170, true);

        Producto Hamburguesa = new Producto("HungryBurguer", 95, true);

        Producto Burros = new Producto("Burros Supremos", 120, true);

        Producto Sopes = new Producto("Sopes de pollo", 80, true);

        decimal cantidadproductos;
        #endregion

        #region Constructor
        public FormMenu()
        {
            InitializeComponent();
            
        }
        #endregion

        #region Control de Pedidos

        private void cantidadHotDog_MouseDown(object sender, MouseEventArgs e)
        {
            cantidadproductos = cantidadGringas.Value+ cantidadTorta.Value+ cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value+ cantidadSopes.Value;
            try
            {

                if (cantidadproductos > 3)
                {
                    throw new ApplicationException("El drone no puede llevar más de 3 ordenes a la vez");

                }
            }
            catch (ApplicationException error1)
            {
                errorProv.SetError(btnPagar, error1.Message);
            }
            btnPagar.Enabled = false;
            if (cantidadproductos <= 3)
            {
                errorProv.Clear();
                btnPagar.Enabled = true;
            }
            
        }
        #endregion

        #region Eventos
        private void btnPagar_Click(object sender, EventArgs e)
        {
            cantidadproductos = cantidadGringas.Value + cantidadTorta.Value + cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value + cantidadSopes.Value;
            float totGringas = (byte)cantidadGringas.Value * Gringa.Precio;
            float totTorta = (byte)cantidadTorta.Value * Torta.Precio;
            float totHotDog = (byte)cantidadHotDog.Value * HotDog.Precio;
            float totSushi = (byte)cantidadSushi.Value * Sushi.Precio;
            float totPizza = (byte)cantidadPizza.Value * Pizza.Precio;
            float totPasta = (byte)cantidadPasta.Value * Pasta.Precio;
            float totHambu = (byte)cantidadHambu.Value * Hamburguesa.Precio;
            float totBurros = (byte)cantidadBurro.Value * Burros.Precio;
            float totSopes = (byte)cantidadSopes.Value * Sopes.Precio;

            float Total = totGringas + totTorta + totBurros + totHotDog + totSushi + totPizza + totPasta + totBurros + totHambu;

            try
            {
                if (cantidadproductos == 0)
                {
                    throw new ApplicationException("No se ha seleccionado ningún producto");
                }
                else
                {
                    byte hotdog = (byte)cantidadHotDog.Value;
                    byte sushi = (byte)cantidadSushi.Value;
                    byte pizza = (byte)cantidadPizza.Value;
                    byte pasta = (byte)cantidadPasta.Value;
                    byte burrito = (byte)cantidadBurro.Value;
                    byte burguer = (byte)cantidadHambu.Value;
                    byte torta = (byte)cantidadTorta.Value;
                    byte gringa = (byte)cantidadGringas.Value;
                    byte sopes = (byte)cantidadSopes.Value;

                    FormPagar formPagar = new FormPagar(Total,torta,gringa,sopes, hotdog, sushi, pizza, pasta , burrito, burguer);
                    AddOwnedForm(formPagar);
                    formPagar.FormBorderStyle = FormBorderStyle.None;
                    formPagar.TopLevel = false;
                    formPagar.Dock= DockStyle.Fill;
                    this.Controls.Add(formPagar);
                    this.Tag = formPagar;
                    formPagar.BringToFront();
                    formPagar.Show();

                }

                
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(btnPagar, error.Message);
            }

        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
