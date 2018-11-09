using System;

using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormControlLogIn : Form
    {
        private string password = "HungryDrone";
        public FormControlLogIn()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            { 
                errorProvAdmin.Clear();
                if(txtbUser.Text == ""|| txtbPass.Text == "")
                {
                    throw new ApplicationException();
                }
                else 
                {
                    if (txtbPass.Text == password)
                    {
                        txtbPass.Clear();
                    }
                    else
                    {
                        throw new ApplicationException();
                    }
                }
                
            }
            catch(ApplicationException)
            {
                if (txtbUser.Text == "" &&  txtbPass.Text == "")
                {
                    MessageBox.Show("Los campos no se pueden dejar en blanco", "No se puede continuar",0,MessageBoxIcon.Exclamation);
                }
                else if(txtbUser.Text == "")
                {
                    errorProvAdmin.SetError(txtbUser, "Falta el nombre del usuario");
                }
                else if (txtbPass.Text == "" || txtbPass.Text != password)
                {
                    errorProvAdmin.SetError(txtbPass, "La contraseña es incorrecta o el campo esta en blanco");
                }
                
            }
        }
    }
}
