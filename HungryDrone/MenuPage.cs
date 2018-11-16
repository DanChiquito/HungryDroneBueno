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
        Producto HotDog = new Producto("Hot Dog Gourmet", 30, true);

        Producto Sushi = new Producto("Sushi con huevos de pescado", 130, true);

        Producto Pizza = new Producto("Pizza Capricciosa", 250, true);

        Producto Pasta = new Producto("Pasta con salmon", 220, true);

        Producto Hamburguesa = new Producto("HungryBurguer", 180, true);

        Producto Burros = new Producto("Burros Supremos", 220, true);

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
            cantidadproductos = cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value;
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
        private void cantidadSushi_MouseDown(object sender, MouseEventArgs e)
        {
            cantidadproductos = cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value;
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

        private void cantidadPizza_MouseDown(object sender, MouseEventArgs e)
        {
            cantidadproductos = cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value;
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

        private void cantidadPasta_MouseDown(object sender, MouseEventArgs e)
        {
            cantidadproductos = cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value;
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

        private void cantidadHambu_MouseDown(object sender, MouseEventArgs e)
        {
            cantidadproductos = cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value;
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

        private void cantidadBurro_MouseDown(object sender, MouseEventArgs e)
        {
            cantidadproductos = cantidadSushi.Value + cantidadHotDog.Value + cantidadPizza.Value + cantidadPasta.Value + cantidadBurro.Value + cantidadHambu.Value;
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
            float totHotDog = (byte)cantidadHotDog.Value * HotDog.Precio;
            float totSushi = (byte)cantidadSushi.Value * Sushi.Precio;
            float totPizza = (byte)cantidadPizza.Value * Pizza.Precio;
            float totPasta = (byte)cantidadPasta.Value * Pasta.Precio;
            float totHambu = (byte)cantidadHambu.Value * Hamburguesa.Precio;
            float totBurros = (byte)cantidadBurro.Value * Burros.Precio;

            float Total = totHotDog + totSushi + totPizza + totPasta + totBurros + totHambu;

            try
            {
                if (cantidadHotDog.Value == 0 && cantidadSushi.Value == 0 && cantidadPizza.Value == 0 && cantidadPasta.Value == 0)
                {
                    throw new ApplicationException("No se ha seleccionado ningún producto");
                }
                else
                {
                    FormPagar formPagar = new FormPagar(Total,(byte)cantidadHotDog.Value, (byte)cantidadSushi.Value, (byte)cantidadPizza.Value, (byte)cantidadPasta.Value);
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
