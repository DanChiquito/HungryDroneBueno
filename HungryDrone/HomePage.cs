using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Runtime.InteropServices;

namespace HungryDrone
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarLogo();
        }

        private void mostrarLogo()
        {
            AbrirFormInPanel(new formLogo());
        }
        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        #region Botones del menu Lateral

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new formInicio());
            panelMenuLat.Enabled = false;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormMenu());
            panelMenuLat.Enabled = false;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormControlLogIn());
            panelMenuLat.Enabled = false;
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
                panelMenuLat.Enabled = false;
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

       
    }
}
