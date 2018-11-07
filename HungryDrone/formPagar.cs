using System;
using System.Drawing;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormPagar : Form
    {
        PagoTarjeta tarjeta;

        public FormPagar(float total)
        {
            InitializeComponent();
            lbTotal.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if((txtbNombre.Text == "") || (mskNumero.Text == "") || (mskFecha.Text == "") || (mskCvv.Text == ""))
                {
                    throw new ApplicationException("No puede dejar algún campo vacío");
                }
                else
                {
                    tarjeta = new PagoTarjeta(mskNumero.Text,mskFecha.Text,mskCvv.Text,txtbNombre.Text);
                    MessageBox.Show("Procesando pago...");
                    if (tarjeta.Tarjeta())
                    {
                        MessageBox.Show("Pago aceptado, pedido en camino");
                    }
                    else
                    {
                        MessageBox.Show("Pago declinado, actualice su método de pago");
                    }
                }
            }
            catch(ApplicationException error)
            {
                errorProv.SetError(txtbNombre, error.Message);
            }
        }

        private void FormPagar_Load(object sender, EventArgs e)
        {

        }
    }
}
