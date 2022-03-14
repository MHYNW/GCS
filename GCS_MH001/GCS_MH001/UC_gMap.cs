using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.ToolTips;
using System.Threading;
using System.Runtime.InteropServices;

namespace GCS_MH001
{
    public partial class UC_gMap : UserControl
    {

        //좌표 지점 설정
        List<PointLatLng> points = new List<PointLatLng>();
        List<PointLatLng> eject_points = new List<PointLatLng>();

        GMapControl map = new GMapControl();
        GMapOverlay markerOverlay = new GMapOverlay("markerOverlay"); // 마커
        GMapOverlay routes = new GMapOverlay("routes");// 경로

        //GMapRoute route = new GMapRoute();

        GMapMarker currentMarker = new GMarkerGoogle(new PointLatLng(37.513593, 127.098149), new Bitmap("boing0.gif"));
        public UC_gMap()
        {
            InitializeComponent();

            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; // serverandcache, serveronly 바꿔도 가능
            //map.SetPositionByKeywords("Seoul");
            map.Position = new GMap.NET.PointLatLng(37.513593, 127.098149);
            map.ShowCenter = false; // Hiding the red cross
            // Zoom (important sequence)
            map.MinZoom = 1;
            map.MaxZoom = 20;
            map.Zoom = 8;
            

            map.Size = this.Size;
            map.Overlays.Add(markerOverlay);
            panelGmap.Controls.Add(map);

            //markerOverlay.Markers.Add(currentMarker); //비행기마커

            //데이터조작파트(지우세요)--------------
           // points.Add(new PointLatLng(37.547432, 127.119337));
           // points.Add(new PointLatLng(37.547526, 127.119369));
           // points.Add(new PointLatLng(37.547620, 127.119390));
           // points.Add(new PointLatLng(37.547739, 127.119411));
           // points.Add(new PointLatLng(37.547867, 127.119422));
           // points.Add(new PointLatLng(37.547961, 127.119401));
           // points.Add(new PointLatLng(37.548063, 127.119347));
           // points.Add(new PointLatLng(37.548114, 127.119272));
            //points.Add(new PointLatLng(37.548156, 127.119175));
            //points.Add(new PointLatLng(37.548164, 127.119089));
           // points.Add(new PointLatLng(37.548164, 127.118992));
          //  points.Add(new PointLatLng(37.548130, 127.118928));
          //  points.Add(new PointLatLng(37.548087, 127.118896));
          //  points.Add(new PointLatLng(37.548053, 127.118832));
          //  points.Add(new PointLatLng(37.548010, 127.118800));
          //  points.Add(new PointLatLng(37.547950, 127.118800));
          //  points.Add(new PointLatLng(37.547848, 127.118779));
          //  points.Add(new PointLatLng(37.547793, 127.118768));
          //  points.Add(new PointLatLng(37.547746, 127.118757));
          //  points.Add(new PointLatLng(37.547708, 127.118746));
          //  points.Add(new PointLatLng(37.547688, 127.118738));
          //  points.Add(new PointLatLng(37.547662, 127.118729));
          //  points.Add(new PointLatLng(37.547649, 127.118708));
            

           // GMapRoute route1 = new GMapRoute(points, "");
            
             //   route1.Stroke = new Pen(Color.Blue, 3);
                //routes.Routes.Add(route1);
               // map.Overlays.Add(routes);
            

           // eject_points.Add(new PointLatLng(37.547649, 127.118708));
           // eject_points.Add(new PointLatLng(37.547659, 127.118671));
           // eject_points.Add(new PointLatLng(37.547668, 127.118615));
           // eject_points.Add(new PointLatLng(37.547681, 127.118564));
           // eject_points.Add(new PointLatLng(37.547696, 127.118529));
           // GMapRoute route2 = new GMapRoute(eject_points, "");
            
            //   route2.Stroke = new Pen(Color.Red, 3);
           //    routes.Routes.Add(route2);
            //    map.Overlays.Add(routes);
                // double distance = route.Distance;
            

            //---------------------------

        }


        public void updateMarker(double lat, double lng)
        {
            GMapMarker newMarker = new GMarkerGoogle(new PointLatLng(lat, lng), new Bitmap("recordimg.gif"));
            //GMapMarker curMarker = new GMarkerGoogle(new PointLatLng(lati, lngt), new Bitmap("boing0.gif"));
            // new marker 

            markerOverlay.Markers.Add(newMarker);
        }
        /*
        public void updateRoute(List<PointLatLng> points)
        {
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            route.Stroke = new Pen(Color.Red, 3);
            routes.Routes.Add(route);
            map.Overlays.Add(routes);
        }
        */
        public void updateRoute(double latitude, double longitude, bool eject)
        {
            if (eject == true)
            {
                PointLatLng newPoint = new PointLatLng();
                newPoint = new PointLatLng(latitude, longitude);
                eject_points.Add(newPoint);
                GMapRoute route = new GMapRoute(eject_points, "");
                this.Invoke(new Action(delegate ()
                {
                    route.Stroke = new Pen(Color.Red, 3);
                    routes.Routes.Add(route);
                    map.Overlays.Add(routes);
                   // double distance = route.Distance;
                }));
            }
            else if (eject == false)
            {
                PointLatLng newPoint = new PointLatLng();
                newPoint = new PointLatLng(latitude, longitude);
                points.Add(newPoint);
                GMapRoute route = new GMapRoute(points, "");
                this.Invoke(new Action(delegate ()
                {
                    route.Stroke = new Pen(Color.Blue, 3);
                    routes.Routes.Add(route);
                    map.Overlays.Add(routes);
                }));
            }

 
        }

        private void panelGmap_Paint(object sender, PaintEventArgs e)
        {

        }


        // 마커, 좌표 제거
        public void ClearMarker()
        {
            routes.Clear();
            markerOverlay.Clear();
            points.RemoveRange(0, points.Count);
            eject_points.RemoveRange(0, eject_points.Count);
        }
        
        // 지도 중심을 현재점으로 맞추기, 렉이 심할시 삭제
        public void Focus(double latitude, double longitude)
        {
            this.Invoke(new Action(delegate ()
            {
                map.Position = new GMap.NET.PointLatLng(latitude, longitude);
            }));

        }
        
        // 스크롤바 
        public void Zooming(int zoom)
        {
            map.Zoom = 20 - zoom;
        }

        // 사출 한 후 거리 구하기
        public void getDistance()
        {
            PointLatLng firstPoint = points[points.Count];
            PointLatLng lastpoint = eject_points[eject_points.Count];


        }

        // MOUSE Click 버전
        private void MapMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                double lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = map.FromLocalToLatLng(e.X, e.Y).Lng;
                updateMarker(lat, lng);
            }
        }
        
    }
}

