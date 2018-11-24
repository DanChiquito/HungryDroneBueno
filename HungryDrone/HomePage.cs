using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Runtime.InteropServices;
using System.Linq;

namespace HungryDrone
{
    public partial class HomePage : Form
    {
        FormPagar formpagar;
        public HomePage()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
   
        private void AbrirFormInPanel<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario==null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                formulario.BringToFront();
            }
               
        }


        #region Botones del menu Lateral

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<formInicio>();
            panelMenuLat.Enabled = true;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu("", 0, 0);
            AddOwnedForm(menu);
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Dock = DockStyle.Fill;
            this.Controls.Add(menu);
            this.Tag = menu;
            menu.BringToFront();
            menu.Show();

            panelMenuLat.Enabled = true;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel<FormControlLogIn>();
            panelMenuLat.Enabled = true;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }

        #endregion

        private void btnMenuLat_Click(object sender, EventArgs e)
        {
            if (panelMenuLat.Width == 200)
            {
                panelMenuLat.Width = 80;
                panelContenedor.Enabled = true;
                panelMenuLat.Enabled = true;
            }
            else
            {
                panelMenuLat.Width = 200;
                panelContenedor.Enabled = false;
                panelMenuLat.Enabled = true;
            }
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de que desea salir?", "Esta a punto de dejar Hungry Drone", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void horaFeha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = System.DateTime.Now.ToLongTimeString();
            lbFecha.Text = System.DateTime.Now.ToLongDateString();
        }
    }
}
