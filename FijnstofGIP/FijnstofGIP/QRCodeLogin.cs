using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.OleDb;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace FijnstofGIP
{
    public partial class QRCodeLogin : Form
    {
        public QRCodeLogin()
        {
            InitializeComponent();
        }

        DataSet dsWW = new DataSet();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;



        private void QRCodeLogin_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo FilterInfo in filterInfoCollection)
            {
                cmbWebcams.Items.Add(FilterInfo.Name);
            }

            try
            {
                cmbWebcams.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Opgepast, geen webcam gevonden.", "Webcam niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnWebcam_Click(object sender, EventArgs e)
        {
            try
            {
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbWebcams.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer.Start();
                btnWebcam.Enabled = false;

            }
            catch 
            {
                MessageBox.Show("Je hebt geen webcam aangeduid", "Webcam niet gevonden", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                WebcamBox.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch
            {
                MessageBox.Show("Onverwachte error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void QRCodeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning == true)
                {
                    captureDevice.Stop();
                }
            }
            catch
            {
                //we willen geen error maar ook geen bericht tonen
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (WebcamBox.Image != null)
                {
                    BarcodeReader Reader = new BarcodeReader();
                    Result result = Reader.Decode((Bitmap)WebcamBox.Image);

                    if (result != null)
                    {
                        string decoded = result.ToString().Trim();
                        timer.Stop();


                        //Login instructie ----------------------------------------------------------------------------
                        OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                        MijnVerbinding.Open();

                        string loginWW = "SELECT wachtwoord,gebruikersID FROM tblgebruikersWW WHERE wachtwoord=@wachtwoord";

                        OleDbCommand cmdWW = new OleDbCommand();
                        cmdWW.CommandType = CommandType.Text;
                        cmdWW.CommandText = loginWW;
                        cmdWW.Connection = MijnVerbinding;

                        cmdWW.Parameters.AddWithValue("@wachtwoord", decoded);
                        OleDbDataReader drWW = cmdWW.ExecuteReader();

                        while (drWW.Read())
                        {
                            decoded = drWW.GetValue(0).ToString();
                            InfoGebruiker.gebruikersID = drWW.GetValue(1).ToString();
                        }
                        drWW.Close();
                        MijnVerbinding.Close();

                        //gegevens van gebruiker krijgen bij login
                        OleDbConnection verbindingInfoGebruiker = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                        verbindingInfoGebruiker.Open();

                        OleDbCommand cmdGebrInfo = new OleDbCommand();
                        cmdGebrInfo.CommandType = CommandType.Text;
                        cmdGebrInfo.CommandText = SQLScripts.sqlInfoGebruikerQRCode;
                        cmdGebrInfo.Connection = verbindingInfoGebruiker;

                        cmdGebrInfo.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);

                        cmdGebrInfo.ExecuteNonQuery();
                        OleDbDataReader drGebrInfo = cmdGebrInfo.ExecuteReader();

                        //we slaan deze op in de InfoGebruiker -> handig om de gebruiker zijn info te hebben bij ALLE forms + ID van gebruiker krijgen
                        while (drGebrInfo.Read())
                        {
                            InfoGebruiker.gebruikersnaam = drGebrInfo.GetValue(0).ToString();
                            InfoGebruiker.email = drGebrInfo.GetValue(1).ToString();
                            InfoGebruiker.voornaam = drGebrInfo.GetValue(2).ToString();
                            InfoGebruiker.familienaam = drGebrInfo.GetValue(3).ToString();
                            InfoGebruiker.huisnummer = drGebrInfo.GetValue(4).ToString();
                            InfoGebruiker.straat = drGebrInfo.GetValue(5).ToString();
                            InfoGebruiker.postcode = drGebrInfo.GetValue(6).ToString();
                            InfoGebruiker.gemeente = drGebrInfo.GetValue(7).ToString();
                        }
                        drGebrInfo.Close();
                        verbindingInfoGebruiker.Close();
                        MessageBox.Show("QR Code login gelukt!", "Succesvol ingelogd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu volgendForm = new Menu(); //volgend form declareren
                        volgendForm.Show(); //tonen van volgend form
                        this.Close(); //Aanmeldscherm form verbergen

                    if (captureDevice.IsRunning == true)
                        {
                            captureDevice.Stop();
                        }
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Ongeldige QR Code", "Login mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsWW.Clear();
            }
        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Close(); //sluiten van form
        }
    }
}
