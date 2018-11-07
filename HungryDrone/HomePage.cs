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

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormMenu());
        }

        private void btnMenuLat_Click(object sender, EventArgs e)
        {
            if(panelMenuLat.Width ==200)
            {
                panelMenuLat.Width = 80;
            }
            else
            {
                panelMenuLat.Width = 200;
            }
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormControlLogIn());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new formInicio());
        }
    }
}
