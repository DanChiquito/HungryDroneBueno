using System;
using System.Drawing;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormPagar : Form
    {
        PagoTarjeta tarjeta;
        public string nomUsuario;
        public double lat1;
        public double lng1;
        public float total1;
        public byte torta1;
        public byte gringas1;
        public byte sopes1;
        public byte hotdogs1;
        public byte sushi1;
        public byte pizza1;
        public byte pasta1;
        public byte burro1;
        public byte burguer1;


        public FormPagar(string nombre, double lat, double lng, float total, byte torta, byte gringas, byte sopes, byte hotdogs, byte sushi, byte pizza, byte pasta, byte burro, byte burguer)
        {
            InitializeComponent();

            lbSubtotal.Text = total.ToString();
            nomUsuario = nombre;
            lat1 = lat;
            lng1 = lng;
            total1 = total;
            torta1 = torta;
            gringas1 = gringas;
            sopes1 = sopes;
            hotdogs1 = hotdogs;
            sushi1 = sushi;
            pizza1 = pizza;
            pasta1 = pasta;
            burro1 = burro;
            burguer1 = burguer;


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
                        float total = subtotal - (float)(subtotal * 0.25);
                        lbTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no es válido");
                        float total = subtotal;
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

            try
            {
                if ((txtbNombre.Text == "") || (mskNumero.Text == "") || (mskFecha.Text == "") || (mskCvv.Text == ""))
                {
                    throw new ApplicationException("No puede dejar algún campo vacío");
                }
                else
                {
                    if (lbTotal.Text == "")
                    {
                        float subtotal = float.Parse(lbSubtotal.Text);
                        lbTotal.Text = subtotal.ToString();
                    }

                    tarjeta = new PagoTarjeta(mskNumero.Text, mskFecha.Text, mskCvv.Text, txtbNombre.Text);
                    MessageBox.Show("Procesando pago...", "Espere un momento", 0, MessageBoxIcon.Asterisk);
                    FormDatosUsuarioFinal formUsuarioFinal = new FormDatosUsuarioFinal(nomUsuario, lat1, lng1, total1, torta1, gringas1, sopes1, hotdogs1, sushi1, pizza1, pasta1, burro1, burguer1);
                    AddOwnedForm(formUsuarioFinal);
                    formUsuarioFinal.FormBorderStyle = FormBorderStyle.None;
                    formUsuarioFinal.TopLevel = false;
                    formUsuarioFinal.Dock = DockStyle.Fill;
                    this.Controls.Add(formUsuarioFinal);
                    this.Tag = formUsuarioFinal;
                    formUsuarioFinal.BringToFront();
                    formUsuarioFinal.Show();
                    if (tarjeta.Tarjeta())
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Actualice su método de pago","Pago Declinado", 0,MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(ApplicationException error)
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
