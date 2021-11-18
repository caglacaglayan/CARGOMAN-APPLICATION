using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace CARGOMAN
{
    public partial class Map : Form
    {
        List<PointLatLng> points;
        public static float konumx;
        public static float konumy;
        public Map()
        {
            InitializeComponent();
            points = new List<PointLatLng>();
        }

        public CargoManDataSet CargoManDataSet
        {
            get => default;
            set
            {
            }
        }

        public Status Status
        {
            get => default;
            set
            {
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            Gmap1.ShowCenter = false;
        }

        private void toStatusButton_Click(object sender, EventArgs e)
        {
            Status gecis = new Status();
            gecis.Show();
            this.Hide();
        }

        GMapOverlay markers = new GMapOverlay("markers");
        private void submitbutton_Click(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            Gmap1.CacheLocation = @"cache";

            Gmap1.DragButton = MouseButtons.Left;

            Gmap1.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(LatBox.Text);
            double longt = Convert.ToDouble(LongBox.Text);
            Gmap1.Position = new PointLatLng(lat, longt);
            Gmap1.MinZoom = 1;
            Gmap1.MaxZoom = 100;
            Gmap1.Zoom = 10;

            PointLatLng point = new PointLatLng(lat,longt);
            GMapMarker marker = new GMarkerGoogle(point,GMarkerGoogleType.red_pushpin);

            
            markers.Markers.Add(marker);
            Gmap1.Overlays.Add(markers);

        }

        private void AddlocButton_Click(object sender, EventArgs e)
        {
            points.Add(new PointLatLng(Convert.ToDouble(LatBox.Text), Convert.ToDouble(LongBox.Text)));
        }

        private void Routebutton_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(points[0],points[1],false,false,14);
            var r = new GMapRoute(route.Points, "My Route");
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            Gmap1.Overlays.Add(routes);
        
        
        }

        private void Gmap1_MouseClick(object sender, MouseEventArgs e)
        {
             if(e.Button == MouseButtons.Right)
            {
                var point = Gmap1.FromLocalToLatLng(e.X,e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                LatBox.Text = lat+"";
                LongBox.Text = lng+"";

                LoadMap(point);

                AddMarker(point);
            }
        }

        private void LoadMap(PointLatLng point)
        {
            Gmap1.Position = point;
        }

        private void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red_dot)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            Gmap1.Overlays.Add(markers);
        }

        private void chooseLocbutton_Click(object sender, EventArgs e)
        {
            konumx = Convert.ToSingle(LatBox.Text);
            konumy = Convert.ToSingle(LongBox.Text);

            EklemeEkrani gecis = new EklemeEkrani(konumx,konumy,EklemeEkrani.ad,EklemeEkrani.durum);
            gecis.Show();
            this.Hide();

            
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            if (Gmap1.Overlays.Count > 0)
            {
                Gmap1.Overlays.Remove(markers);
                Gmap1.Refresh();
            }
 
        }
    }
}
