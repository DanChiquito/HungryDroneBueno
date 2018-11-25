using System;
using System.Drawing;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormPagar : Form
    {
        private PagoTarjeta tarjeta;
        private HomePage home;
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

        private double latTotal;
        private double lngTotal;
        private double latTotal1;
        private double lngTotal1;
        private double distancia;
        private int tiempo;
        private double rapidesDrone = 666.666;

        public FormPagar(HomePage homePage)
        {
            InitializeComponent();
            home = homePage;
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
            lbSubtotal.Text = total.ToString();

            #region CALCULOS PARA CALCULAR EL TIEMPO DE LLEGADA
            latTotal = 19.3316664 - home.lat;
            lngTotal = -99.1869205 - home.lng;
            latTotal1 = latTotal * 60 * 1852; ;
            lngTotal1 = (lngTotal * Math.Cos(19.3316664 * Math.PI / 180)) * 60 * 1852;
            distancia = Math.Sqrt(Math.Pow(latTotal1, 2) + Math.Pow(lngTotal1, 2));
            tiempo = (int)(distancia / rapidesDrone);
            #endregion

        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbCodigo.Text == "")
                {
                    throw new ApplicationException();
                }
                else
                {
                    float subtotal = float.Parse(lbSubtotal.Text);
                    if (txtbCodigo.Text == "HungryDrone")
                    {
                        total = subtotal - (float)(subtotal * 0.25);
                        lbTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es válido");
                        total = subtotal;
                        lbTotal.Text = total.ToString();
                    }
                }
            }
            catch
            {
                errorProv.SetError(btnIngresar, "No ha ingresado ningún código");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelfinal.Visible = true;
            try
            {
                if ((txtbNombre.Text == "") || (mskNumero.Text == "") || (mskFecha.Text == "") || (mskCvv.Text == ""))
                {
                    throw new FormatException("No puede dejar algún campo vacío");
                }
                else
                {
                    if (lbTotal.Text == "")
                    {
                        float subtotal = float.Parse(lbSubtotal.Text);
                        total = subtotal;
                        lbTotal.Text = total.ToString();
                        
                    }
                    
                    string[] verificacion = mskFecha.Text.Split('/');
                    if(int.Parse(verificacion[0]) < 1 || int.Parse(verificacion[0])>12 || int.Parse(verificacion[1]) < 18)
                    {
                        throw new ApplicationException("Ingresa una fecha válida");
                    }
                    #region PANEL DEL USUARIO
                    //panel del usuario
                    lblTotal.Text = total.ToString() + " MXN";
                    lblUsuario.Text = home.nomUsuario;
                    lblTiempo.Text = tiempo.ToString() + " min";
                    if (torta != 0)
                    {
                        dgvPedidos.Rows.Add("Torta Loca",torta);
                    }
                    if (gringas != 0)
                    {
                        dgvPedidos.Rows.Add("Gringas de Chorizo", gringas);
                    }
                    if (hotdogs != 0)
                    {
                        dgvPedidos.Rows.Add("HotDog Campesino", hotdogs);
                    }
                    if (sushi != 0)
                    {
                        dgvPedidos.Rows.Add("Sushi con huevos de pescado", sushi);
                    }
                    if (pizza != 0)
                    {
                        dgvPedidos.Rows.Add("Pizza Caprichosa", pizza);
                    }
                    if (pasta != 0)
                    {
                        dgvPedidos.Rows.Add("Pasta con Salmón", pasta);
                    }
                    if (burguer != 0)
                    {
                        dgvPedidos.Rows.Add("HungryBurguer", burguer);
                    }
                    if (burro != 0)
                    {
                        dgvPedidos.Rows.Add("Burros Supremos", burro);
                    }
                    if (sopes != 0)
                    {
                        dgvPedidos.Rows.Add("Sopes de pollo", sopes);
                    }
                    #endregion

                    tarjeta = new PagoTarjeta(mskNumero.Text, mskFecha.Text, mskCvv.Text, txtbNombre.Text);
                }
            }
            catch (ApplicationException error)
            {
                errorProv.SetError(mskFecha, error.Message);
            }
            catch (FormatException error)
            {
                errorProv.SetError(txtbNombre, error.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
        }


    }
}
