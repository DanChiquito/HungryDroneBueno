using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace HungryDrone
{
    public partial class formCheckDrone : Form
    {
        GMarkerGoogle marker; //Será el marcador de la ubicación de HungryDrone
        GMarkerGoogle destino;
        GMapOverlay markerOverlay;

        double LatDrone = 19.360881;
        double LngDrone = -99.123048;  //Coordenadas Que irá leeyendo del puerto serial de arduino
        double LatDestino = 19.356543;
        double LngDestino = -99.564586;

        public formCheckDrone()
        {
            InitializeComponent();
        }

        private void formCheckDrone_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.Position = new PointLatLng(LatDrone, LngDrone);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador del Drone
            markerOverlay = new GMapOverlay("HungryDrone");
            marker = new GMarkerGoogle(new PointLatLng(LatDrone, LngDrone), GMarkerGoogleType.blue_dot);
            markerOverlay.Markers.Add(marker); //Agregamos al mapa

            //Marcador destino
            destino = new GMarkerGoogle(new PointLatLng(LatDestino, LngDestino), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(destino);
            destino.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            destino.ToolTipText = string.Format("Destino: \n Latitud: {0} \n Longitud: {1} \n Distancia:", LatDestino, LngDestino);

            gMapControl1.Overlays.Add(markerOverlay);


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
