using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;   // Nodig voor google map in te laden
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace FijnstofGIP.FormsMenu
{
    public partial class FormMapWeergeven : Form
    {
        public FormMapWeergeven()
        {
            InitializeComponent();
        }

        private void FormMapWeergeven_Load(object sender, EventArgs e)
        {

            try
            {   //rood kruis van het midden weghalen
                GoogleMap.ShowCenter = false;

                //Start settings en locatie 
                GoogleMap.MapProvider = GMapProviders.GoogleMap;
                GoogleMap.Position = new GMap.NET.PointLatLng(50.9, 4);
                GoogleMap.MinZoom = 8;
                GoogleMap.MaxZoom = 25;
                GoogleMap.Zoom = 10;

                //markers maken
                PointLatLng point = new PointLatLng(50.9, 4);
                GMapMarker meterLocatie = new GMarkerGoogle(point, GMarkerGoogleType.blue_pushpin);
                meterLocatie.ToolTipText = "Fijnstofmeter De bloem";
                GMapOverlay locaties = new GMapOverlay("Locaties");
                locaties.Markers.Add(meterLocatie);
                GoogleMap.Overlays.Add(locaties);
            }
            catch
            {
                MessageBox.Show("Er is een fout gebeurd bij het inladen van de map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
