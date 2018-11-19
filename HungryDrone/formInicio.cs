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
        int filaseleccionada = 0;
        double latInicial = 19.3316664;
        double lngInicial = -99.1869205;
        System.Data.DataTable dt;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        
        

        public formInicio()
        {
            InitializeComponent();
        }

        private void formInicio_Load(object sender, EventArgs e)
        {
            dt = new System.Data.DataTable();
            dt.Columns.Add(new System.Data.DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new System.Data.DataColumn("Latitud", typeof(double)));
            dt.Columns.Add(new System.Data.DataColumn("Longitud", typeof(double)));

            dt.Rows.Add("Cede Hungry Drone", latInicial,lngInicial);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

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


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaseleccionada = e.RowIndex; // numero de fila que selecciono
            txtbDescripcion.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            txtbLatitud.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            txtbLongitud.Text = dataGridView1.Rows[filaseleccionada].Cells[2].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txtbLatitud.Text), Convert.ToDouble(txtbLongitud.Text));

            gMapControl1.Position = marker.Position;

        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtbLatitud.Text = lat.ToString();
            txtbLongitud.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación:\n Latitud: {0}\n Longitud:{1}", lat, lng);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                string milatitud =dataGridView1.Rows[0].Cells[1].Value.ToString();
                string milongitud = dataGridView1.Rows[0].Cells[2].Value.ToString();
                if (txtbLatitud.Text == milatitud && txtbLongitud.Text == milongitud)
                {
                    throw new ApplicationException();
                }
                else
                {
                    dt.Rows.Add(txtbDescripcion.Text, txtbLatitud.Text, txtbLongitud.Text);
                }
            }
            catch(ApplicationException)
            {
                MessageBox.Show("¿Esta seguro que las coordenadas son diferentes a las de la cede?","Parece que hubo un error",0, MessageBoxIcon.Question);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaseleccionada);
        }
    }
}
