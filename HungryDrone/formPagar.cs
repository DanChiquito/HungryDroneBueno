using System;
using System.Drawing;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormPagar : Form
    {
        PagoTarjeta tarjeta;

        public FormPagar(float total, byte hotdogs, byte sushi, byte pizza, byte pasta)
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
                    MessageBox.Show("Procesando pago...", "Espere un momento",0 ,MessageBoxIcon.Asterisk);
                    if (tarjeta.Tarjeta())
                    {
                        FormDatosUsuarioFinal formUsuarioFinal = new FormDatosUsuarioFinal(txtbNombre.Text,"","",float.Parse(lbTotal.Text));
                            AddOwnedForm(formUsuarioFinal);
                        formUsuarioFinal.FormBorderStyle = FormBorderStyle.None;
                        formUsuarioFinal.TopLevel = false;
                        formUsuarioFinal.Dock = DockStyle.Fill;
                        this.Controls.Add(formUsuarioFinal);
                        this.Tag = formUsuarioFinal;
                        formUsuarioFinal.BringToFront();
                        formUsuarioFinal.Show();
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

        private void FormPagar_Load(object sender, EventArgs e)
        {

        }
    }
}
