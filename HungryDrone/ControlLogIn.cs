using System;
using System.Threading;
using System.Windows.Forms;

namespace HungryDrone
{
    public partial class FormControlLogIn : Form
    {
        private HomePage home;
        private string password = "HungryDrone";
        private string user1 = "Daniel";
        private string user2 = "Nataly";
        private string user3 = "Itan";
        private float total;
        private string nomUsuario;

        public FormControlLogIn(HomePage homepage)
        {
            InitializeComponent();
            home = homepage;
            total = home.total;
            nomUsuario = home.nomUsuario;
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
                MessageBox.Show("Comprobando contraseña y usuario...","Espere un momento",0,MessageBoxIcon.Information);
                if(txtbUser.Text == ""|| txtbPass.Text == "")
                {
                    throw new ApplicationException();
                }
                else 
                {
                    if (txtbPass.Text == "a" && (txtbUser.Text == "a" || txtbUser.Text == user1 || txtbUser.Text == user2 || txtbUser.Text == user3))
                    {

                            formCheckDrone formchecardrone = new formCheckDrone(home);
                            formchecardrone.BringToFront();
                            formchecardrone.Show();
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
                if(txtbUser.Text == "" || txtbUser.Text != user1 || txtbUser.Text != user2 || txtbUser.Text != user3)
                {
                    errorProvAdmin.SetError(txtbUser, "El campo esta vacío o el nombre de usuario no existe");
                }
                if (txtbPass.Text == "" || txtbPass.Text != password)
                {
                    errorProvAdmin.SetError(txtbPass, "La contraseña es incorrecta o el campo esta en blanco");
                }
                
                
            }
        }
    }
}
