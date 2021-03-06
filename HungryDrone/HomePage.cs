﻿using System;
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
        public string nomUsuario = "";
        public double lat = 0;
        public double lng = 0;
        public float total = 0;
        public byte torta = 0;
        public byte gringas = 0;
        public byte sopes = 0;
        public byte hotdogs = 0;
        public byte sushi = 0;
        public byte pizza = 0;
        public byte pasta = 0;
        public byte burro = 0;
        public byte burguer = 0;

       


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
            btnMenuLat.Enabled = true;
            formInicio forminicio = new formInicio(this);
            AddOwnedForm(forminicio);
            forminicio.FormBorderStyle = FormBorderStyle.None;
            forminicio.TopLevel = false;
            forminicio.Dock = DockStyle.Fill;
            this.Controls.Add(forminicio);
            this.Tag = forminicio;
            forminicio.BringToFront();
            forminicio.Show();

            panelMenuLat.Enabled = false;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }
        private void btnMenu2_Click(object sender, EventArgs e)
        {
            btnMenuLat.Enabled = true;
            FormMenu formMenu = new FormMenu(this);
            AddOwnedForm(formMenu);
            formMenu.FormBorderStyle = FormBorderStyle.None;
            formMenu.TopLevel = false;
            formMenu.Dock = DockStyle.Fill;
            this.Controls.Add(formMenu);
            this.Tag = formMenu;
            formMenu.BringToFront();
            formMenu.Show();


            panelMenuLat.Enabled = false;
            panelMenuLat.Width = 80;
            panelContenedor.Enabled = true;
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnMenuLat.Enabled = true;
            FormControlLogIn formPass = new FormControlLogIn(this);
            AddOwnedForm(formPass);
            formPass.FormBorderStyle = FormBorderStyle.None;
            formPass.TopLevel = false;
            formPass.Dock = DockStyle.Fill;
            this.Controls.Add(formPass);
            this.Tag = formPass;
            formPass.BringToFront();
            formPass.Show();

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

        private void horaFeha_Tick(object sender, EventArgs e)
        {

            lbHora.Text = System.DateTime.Now.ToString("HH:mm:ss");
            lbFecha.Text = System.DateTime.Now.ToLongDateString();
            string[] hora = lbHora.Text.Split(':');

            if (int.Parse(hora[0]) < 6 || int.Parse(hora[0]) > 22)
            {
                ptbClosed.Visible = true;
                ptbOpen.Visible = false;
                panelMenuLat.Enabled = false;
                btnMenuLat.Enabled = false;
            }
            else
            {
                ptbOpen.Visible = true;
                ptbClosed.Visible = false;
            }
        }
    }
}
