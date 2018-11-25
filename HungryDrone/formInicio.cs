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
    public partial class formInicio : Form
    {
        double lat;
        double lng;
        double latInicial = 19.3316664;
        double lngInicial = -99.1869205;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        HomePage home;
        
        

        public formInicio(HomePage homepage)
        {
            InitializeComponent();
            home = homepage;
            lat = latInicial;
            lng = lngInicial;
            
        }
        #region diseño del mapa
        private void formInicio_Load(object sender, EventArgs e)
        { 

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial, lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("Su pocisión");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación:\nLatitud {0} \nLongitud:{1}", latInicial, lngInicial);

            gMapControl1.Overlays.Add(markerOverlay);
        }
        #endregion

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación:\n Latitud: {0}\n Longitud:{1}", lat, lng);
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbNombre.Text == "")
                {
                    throw new ApplicationException();
                }
                else
                {
                    if (latInicial == lat && lngInicial == lng)
                    {
                        throw new ApplicationException();
                    }
                    else
                    {
                        home.nomUsuario = txtbNombre.Text;
                        home.lat = lat;
                        home.lng = lng;
                        

                        FormMenu formMenu = new FormMenu(home);
                        AddOwnedForm(formMenu);
                        formMenu.FormBorderStyle = FormBorderStyle.None;
                        formMenu.TopLevel = false;
                        formMenu.Dock = DockStyle.Fill;
                        this.Controls.Add(formMenu);
                        this.Tag = formMenu;
                        formMenu.BringToFront();
                        formMenu.Show();
                    }
                }
            }
            catch(ApplicationException)
            {
                if(txtbNombre.Text == "")
                {
                    errorProvider1.SetError(txtbNombre, "No se pueden dejar los campos vacíos");
                }
                if(latInicial == lat && lngInicial == lng)
                {
                    errorProvider1.SetError(gMapControl1, "Tu ubicación tiene que ser diferente de la ubicación de la cede");
                }
            }
        }
    }
}
