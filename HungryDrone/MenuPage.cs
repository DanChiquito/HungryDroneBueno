using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormMenu : Form
    {
        #region Atributos

        decimal cantidadproductos;
        HomePage home;
        Producto HotDog;
        Producto torta;
        Producto gringa;
        Producto Sushi;
        Producto Pizza;
        Producto Pasta;
        Producto Hambu;
        Producto Burros;
        Producto Sopes;


        #endregion

        #region Constructor
        public FormMenu(HomePage homePage)

        {
            InitializeComponent();
            home = homePage;
            #region productos
            #region torta
            torta.ingredientes = new Ingrediente[7];
            torta.nombre = "Torta Loca";
            torta.precio = 65;
            torta.ingredientes[0].nombre = "Bolillo";
            torta.ingredientes[1].nombre = "Jamón de pierna";
            torta.ingredientes[2].nombre = "Salchicha de pavo";
            torta.ingredientes[3].nombre = "Pimiento morrón verde";
            torta.ingredientes[4].nombre = "Cebolla";
            torta.ingredientes[5].nombre = "Queso manchego";
            torta.ingredientes[6].nombre = "Aderezo";
            #endregion
            #region gringa
            gringa.ingredientes = new Ingrediente[4];
            gringa.nombre = "Gringa de chorizo";
            gringa.precio = 70;
            gringa.ingredientes[0].nombre = "Tortilla de harina";
            gringa.ingredientes[1].nombre = "Chorizo";
            gringa.ingredientes[2].nombre = "Queso manchego";
            gringa.ingredientes[3].nombre = "Pimiento morrón verde";
            #endregion
            #region Hotdog
            HotDog.ingredientes = new Ingrediente[5];
            HotDog.nombre = "HotDog Campesino";
            HotDog.precio = 35;
            HotDog.ingredientes[0].nombre = "Pan para hotdog campesino";
            HotDog.ingredientes[1].nombre = "Salchicha de tocino";
            HotDog.ingredientes[2].nombre = "Queso manchego";
            HotDog.ingredientes[3].nombre = "Pimiento morrón verde";
            HotDog.ingredientes[4].nombre = "cebollín";
            #endregion
            #region Sushi

            Sushi.ingredientes = new Ingrediente[5];
            Sushi.nombre = "Sushi con huevos de pescado";
            Sushi.precio = 130;
            Sushi.ingredientes[0].nombre = "Arroz para sushi";
            Sushi.ingredientes[1].nombre = "Hongos japoneses";
            Sushi.ingredientes[2].nombre = "Masa tempura";
            Sushi.ingredientes[3].nombre = "Cebolla de verdeo";
            Sushi.ingredientes[4].nombre = "Huevos de pescado";
            #endregion
            #region Pizza

            Pizza.ingredientes = new Ingrediente[5];
            Pizza.nombre = "Pizza Capricciosa";
            Pizza.precio = 220;
            Pizza.ingredientes[0].nombre = "Masa artesanal";
            Pizza.ingredientes[1].nombre = "Queso mozzarella";
            Pizza.ingredientes[2].nombre = "Aceitunas negras";
            Pizza.ingredientes[3].nombre = "Pimiento morrón verde";
            Pizza.ingredientes[4].nombre = "Salsa de tomate";
            #endregion
            #region Pasta
            Pasta.ingredientes = new Ingrediente[5];
            Pasta.nombre = "Pasta con salmon";
            Pasta.precio = 170;
            Pasta.ingredientes[0].nombre = "Pasta fresca";
            Pasta.ingredientes[1].nombre = "Salmón ahumado";
            Pasta.ingredientes[2].nombre = "Jitomate secado al sol";
            Pasta.ingredientes[3].nombre = "Queso parmesano";
            Pasta.ingredientes[4].nombre = "Espinaca";
            #endregion
            #region Hamburguesa
            Hambu.ingredientes = new Ingrediente[6];
            Hambu.nombre = "HungryBurguer";
            Hambu.precio = 95;
            Hambu.ingredientes[0].nombre = "Bollos de ajonjoli";
            Hambu.ingredientes[1].nombre = "Lechuga";
            Hambu.ingredientes[2].nombre = "Aros fritos de cebolla";
            Hambu.ingredientes[3].nombre = "carne de arrachera";
            Hambu.ingredientes[4].nombre = "Queso manchego";
            Hambu.ingredientes[5].nombre = "Papas fritas";
            #endregion
            #region Burros
            Burros.ingredientes = new Ingrediente[7];
            Burros.nombre = "Burros supremos";
            Burros.precio = 120;
            Burros.ingredientes[0].nombre = "Tortilla de harina";
            Burros.ingredientes[1].nombre = "Lechuga";
            Burros.ingredientes[2].nombre = "Bisteck";
            Burros.ingredientes[3].nombre = "Frijoles";
            Burros.ingredientes[4].nombre = "Queso manchego";
            Burros.ingredientes[5].nombre = "Cebolla";
            Burros.ingredientes[6].nombre = "Pimiento morrón verde";
            #endregion
            #region Sopes
            Sopes.ingredientes = new Ingrediente[7];
            Sopes.nombre = "Burros supremos";
            Sopes.precio = 120;
            Sopes.ingredientes[0].nombre = "Tortilla de harina";
            Sopes.ingredientes[1].nombre = "Lechuga";
            Sopes.ingredientes[2].nombre = "Bisteck";
            Sopes.ingredientes[3].nombre = "Frijoles";
            Sopes.ingredientes[4].nombre = "Queso manchego";
            Sopes.ingredientes[5].nombre = "Cebolla";
            Sopes.ingredientes[6].nombre = "Pimiento morrón verde";
            #endregion
            #endregion
        }
        #endregion



        #region Estructuras

        public struct Producto
        {
            public string nombre;
            public float precio;
            public Ingrediente [] ingredientes; 
        }

        public struct Ingrediente
        {
            public string nombre;
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
            float totGringas = (byte)cantidadGringas.Value * gringa.precio;
            float totTorta = (byte)cantidadTorta.Value * torta.precio;
            float totHotDog = (byte)cantidadHotDog.Value * HotDog.precio;
            float totSushi = (byte)cantidadSushi.Value * Sushi.precio;
            float totPizza = (byte)cantidadPizza.Value * Pizza.precio;
            float totPasta = (byte)cantidadPasta.Value * Pasta.precio;
            float totHambu = (byte)cantidadHambu.Value * Hambu.precio;
            float totBurros = (byte)cantidadBurro.Value * Burros.precio;
            float totSopes = (byte)cantidadSopes.Value * Sopes.precio;

            float Total = totGringas + totTorta + totBurros + totHotDog + totSushi + totPizza + totPasta +totSopes + totHambu;
            home.total = Total;

            try
            {
                if (cantidadproductos == 0)
                {
                    throw new ApplicationException("No se ha seleccionado ningún producto");
                }
                else
                {
                    home.hotdogs = (byte)cantidadHotDog.Value;
                    home.sushi = (byte)cantidadSushi.Value;
                    home.pizza = (byte)cantidadPizza.Value;
                    home.pasta = (byte)cantidadPasta.Value;
                    home.burro = (byte)cantidadBurro.Value;
                    home.burguer = (byte)cantidadHambu.Value;
                    home.torta = (byte)cantidadTorta.Value;
                    home.gringas = (byte)cantidadGringas.Value;
                    home.sopes = (byte)cantidadSopes.Value;

                    FormPagar formPagar = new FormPagar(home);
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