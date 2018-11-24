using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Demo.WindowsForms.CustomMarkers;
using System.IO;
using System.IO.Ports;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace HungryDrone
{
    public partial class formCheckDrone : Form
    {
        GMarkerGoogle destino;
        GMapOverlay markerOverlay;
        GMarkerArrow marker;


        SerialPort serialport;

        double LatDrone = 19.334633;
        double LngDrone = -99.595734;  //Coordenadas Que irá leeyendo del puerto serial de arduino
        double LatDestino = 19.356543;
        double LngDestino = -99.564586;
        int waittime = 0;
        string rawdata;

        public formCheckDrone()
        {
            InitializeComponent();

            try
            {
                String[] puertos = SerialPort.GetPortNames();
                cbPuertos.Items.AddRange(puertos);
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            
        }

        private void formCheckDrone_Load(object sender, EventArgs e)
        {

            #region GMAP_Config
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
            #endregion

            #region Drone_Marker
            markerOverlay = new GMapOverlay("HungryDrone"); //SI FUNCIONA DEBERÍA DE IR EN EL TIMER
            
            #endregion

            #region Destino_Marker
            destino = new GMarkerGoogle(new PointLatLng(LatDestino, LngDestino), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(destino);
            destino.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            destino.ToolTipText = string.Format("Destino: \n Latitud: {0} \n Longitud: {1} \n Distancia:", LatDestino, LngDestino);
            #endregion

            gMapControl1.Overlays.Add(markerOverlay);

            //FALTA AGERGAR MARCADOR PERSONALIZADO Y QUE GIRE CON RESPECTO A LA INFORMACIÓN RECIBIDA POR SERIAL PORT

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            waittime = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(waittime > 5)
            {
                try
                {
                    rawdata = serialport.ReadLine();
                    
                }
                catch(IOException error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }

                #region Variables
                string[] data = rawdata.Split(',');
                LatDrone = double.Parse(data[0]);
                LngDrone = double.Parse(data[1]);
                lbLat.Text = data[0];
                lbLong.Text = data[1];
                lbVel.Text = data[2];
                lbAlt.Text = data[3];
                lbDistancia.Text = data[6];
                int d = int.Parse(data[6]);

                #endregion

                #region PictureBox_Arriba/Abajo
                if (int.Parse(data[4]) < -2)
                {
                    pbForward.Visible = true;
                    pbBackward.Visible = false;
                }
                else if (int.Parse(data[4]) > 2)
                {
                    pbForward.Visible = false;
                    pbBackward.Visible = true;
                }
                else
                {
                    pbForward.Visible = false;
                    pbBackward.Visible = false;
                }
                #endregion

                #region PictureBox_Der/Izq
                if (int.Parse(data[5]) < -2)
                {
                    pbRight.Visible = true;
                    pbLeft.Visible = false;
                }
                else if (int.Parse(data[5]) > 2)
                {
                    pbRight.Visible = false;
                    pbLeft.Visible = true;
                }
                else
                {
                    pbRight.Visible = false;
                    pbLeft.Visible = false;
                }
                #endregion

                #region PictureBox Distancia
                if (d > 400 && d < 500)
                {
                    pb1.Visible = true;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                }
                else if (d > 300 && d <= 400)
                {
                    pb1.Visible = false;
                    pb2.Visible = true;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                }
                else if (d > 200 && d < 300)
                {
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = true;
                    pb4.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = false;
                }
                else if (d > 100 && d < 200)
                {
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = true;
                    pb4.Visible = false;
                    pb5.Visible = false;
                }
                else if (d > 50 && d < 100)
                {
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb4.Visible = true;
                    pb5.Visible = false;
                }
                else if (d > 0 && d < 50)
                {
                    pb1.Visible = false;
                    pb2.Visible = false;
                    pb3.Visible = false;
                    pb4.Visible = false;
                    pb4.Visible = false;
                    pb5.Visible = true;
                }
                else
                {
                        pb1.Visible = false;
                        pb2.Visible = false;
                        pb3.Visible = false;
                        pb4.Visible = false;
                        pb4.Visible = false;
                        pb5.Visible = false;
                }
                #endregion

                #region Actualizar_GPS
                marker = new GMarkerArrow(new PointLatLng(LatDrone, LngDrone));
                marker.ToolTipText = "Drone";
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.Bearing = 90; // Rotation angle
                marker.Fill = new SolidBrush(Color.FromArgb(155, Color.Red)); // Arrow color
                markerOverlay.Markers.Add(marker); //Agregamos al mapa
                gMapControl1.Overlays.Add(markerOverlay);
                gMapControl1.Zoom = gMapControl1.Zoom + 1;
                gMapControl1.Zoom = gMapControl1.Zoom - 1;

                #endregion

            }

        }

        private void actualizarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LEER LOS VALORES DEL MENU PUBLIC
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.BaudRate = 9600;
                serialport.PortName = cbPuertos.SelectedItem.ToString();
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void conectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Open();
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        
    }
}
