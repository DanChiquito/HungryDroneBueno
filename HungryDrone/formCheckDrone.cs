using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Demo.WindowsForms.CustomMarkers;
using System.IO;
using System.IO.Ports;
using System.Threading;

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

        bool rep = true;


        SerialPort serialport;
        HomePage home;
        double LatDrone = 19.334633;
        double LngDrone = -99.595734;  //Coordenadas Que irá leeyendo del puerto serial de arduino
        double LatDestino = 19.356543;
        double LngDestino = -99.564586;
        float X;
        float Y;
        string rawdata;

        public formCheckDrone(HomePage homepage)
        {
            InitializeComponent();
            home = homepage;

            try
            {
                serialport = new SerialPort();
                String[] puertos = SerialPort.GetPortNames();
                Array.Sort(puertos);
                cbPuertos.Items.AddRange(puertos);
                int i1 = cbPuertos.Items.IndexOf("COM8");
                int i2 = cbPuertos.Items.IndexOf("COM6");
                cbPuertos.Items.RemoveAt(i1);
                cbPuertos.Items.RemoveAt(i2);
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void formCheckDrone_Load(object sender, EventArgs e)
        {

            lbLatDest.Text = LatDestino.ToString();
            lbLongDest.Text = LngDestino.ToString();

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
            marker = new GMarkerArrow(new PointLatLng(LatDrone, LngDrone));
            marker.ToolTipText = "Drone";
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.Bearing = 0; // Rotation angle
            marker.Fill = new SolidBrush(Color.FromArgb(155, Color.Red)); // Arrow color
            markerOverlay.Markers.Add(marker);
            #endregion

            #region Destino_Marker
            destino = new GMarkerGoogle(new PointLatLng(LatDestino, LngDestino), GMarkerGoogleType.red);
            markerOverlay.Markers.Add(destino);
            destino.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            destino.ToolTipText = string.Format("Destino: \n Latitud: {0} \n Longitud: {1} \n Distancia:", LatDestino, LngDestino);
            #endregion

            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            try
            {
                rep = true;
                ThreadStart delegado = new ThreadStart(LeerDatos);
                Thread hilo = new Thread(delegado);
                hilo.Start();
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            
        }

        private void LeerDatos()
        {
            serialport.Write(" ");
            while (rep)
            {
                try
                {
                    rawdata = serialport.ReadLine();

                    #region Variables
                    string[] data = rawdata.Split(',');
                    if (data[0] != "************")
                    {
                        LatDrone = double.Parse(data[0]);
                        LngDrone = double.Parse(data[1]);
                    }

                    lbLat.Text = data[0];
                    lbLong.Text = data[1];
                    lbVel.Text = data[2];
                    lbAlt.Text = data[3];
                    X = float.Parse(data[4]);
                    Y = float.Parse(data[5]);
                    lbDistancia.Text = data[6];
                    int d = int.Parse(data[6]);

                    #endregion

                    #region PictureBox_Arriba/Abajo
                    if (X < -2)
                    {
                        pbForward.Visible = true;
                        pbBackward.Visible = false;
                    }
                    else if (X > 2)
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
                    if (Y < -2)
                    {
                        pbRight.Visible = true;
                        pbLeft.Visible = false;
                    }
                    else if (Y > 2)
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
                    if (d > 0 && d < 400)
                    {
                        pb5.Visible = true;
                    }
                    else
                    {
                        pb5.Visible = false;
                    }
                    #endregion

                    #region Actualizar_GPS
                    marker = new GMarkerArrow(new PointLatLng(LatDrone, LngDrone));
                    markerOverlay.Clear();
                    markerOverlay.Markers.Add(destino);
                    markerOverlay.Markers.Add(marker);
                    gMapControl1.Zoom = gMapControl1.Zoom + 1;
                    gMapControl1.Zoom = gMapControl1.Zoom - 1;

                    #endregion
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rep = false;
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
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
                if (cbPuertos.SelectedItem == null)
                {
                    throw new ApplicationException("No ha seleccionado ningún puerto");
                }
                else
                {
                    serialport.BaudRate = 9600;
                    serialport.PortName = cbPuertos.SelectedItem.ToString();
                }
                
            }
            catch(ApplicationException error)
            {
                MessageBox.Show("Error: " + error.Message);
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
                btnIniciar.Enabled = true;
                button1.Enabled = true;
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialport.Close();
            }
            catch(IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
