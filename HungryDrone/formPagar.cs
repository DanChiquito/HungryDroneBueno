using System;
using System.Drawing;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormPagar : Form
    {
        PagoTarjeta tarjeta;
        HomePage home;
        float total;

        public FormPagar(HomePage homePage)
        {
            InitializeComponent();
            home = homePage;
            total = home.total;
            lbSubtotal.Text = total.ToString();
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
                    

                   
                    if (tarjeta.Tarjeta())
                    {
                        MessageBox.Show("Procesando pago...", "Espere un momento", 0, MessageBoxIcon.Asterisk);
                        FormDatosUsuarioFinal formUsuarioFinal = new FormDatosUsuarioFinal(home);
                        //FormFinalUser formUsuarioFinal = new FormFinalUser();
                        AddOwnedForm(formUsuarioFinal);
                        formUsuarioFinal.FormBorderStyle = FormBorderStyle.None;
                        formUsuarioFinal.TopLevel = false;
                        formUsuarioFinal.Dock = DockStyle.Fill;
                        this.Controls.Add(formUsuarioFinal);
                        this.Tag = formUsuarioFinal;
                        formUsuarioFinal.Show();
                        formUsuarioFinal.BringToFront();
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
