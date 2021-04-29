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
using System.Net;
using System.Net.Mail;

namespace FijnstofGIP.FormsMenu
{
    public partial class FormFijnstofmeterToevoegen : Form
    {
        public FormFijnstofmeterToevoegen()
        {
            InitializeComponent();
        }
        #region kleuren van de panelen veranderen wanneer je op een bepaalde textblock klikt - dit is zodat de gebruiker weet waar hij gaat typen
        private void txtMeterID_Click(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.DeepSkyBlue;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;
        }

        private void txtMeterNaam_Click(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.DeepSkyBlue;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;
        }

        private void txtLatitude_Click(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.DeepSkyBlue;
            pnllongitude.BackColor = Color.White;
        }

        private void txtLongtitude_Click(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.DeepSkyBlue;
        }
        #endregion

        #region Kleuren van de panelen veranderen via tab - full tab support
        private void txtMeterID_Enter(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.DeepSkyBlue;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;
        }

        private void txtMeterID_Leave(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;
        }

        private void txtMeterNaam_Enter(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.DeepSkyBlue;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;

        }

        private void txtMeterNaam_Leave(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;

        }

        private void txtLatitude_Enter(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.DeepSkyBlue;
            pnllongitude.BackColor = Color.White;
        }

        private void txtLatitude_Leave(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;
        }

        private void txtLongtitude_Enter(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.DeepSkyBlue;
        }

        private void txtLongtitude_Leave(object sender, EventArgs e)
        {
            pnlMeterID.BackColor = Color.White;
            pnlMeterNaam.BackColor = Color.White;
            pnlLatitude.BackColor = Color.White;
            pnllongitude.BackColor = Color.White;
        }
        #endregion

        #region "advanced coding" voor email en opslaan van nieuwe fijnstofmeter
        private void btnGegevensOpslaan_Click(object sender, EventArgs e)
        {
            // try
            //{

            if (txtMeterID.Text == "" && txtMeterNaam.Text == "" && txtLatitude.Text == "" && txtLongtitude.Text == "")
            {
                MessageBox.Show("Je moet alle velden invullen", "Fijnstofmeter toevoegen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult Toevoegen = MessageBox.Show("Ben je zeker dat je deze gegevens wilt toevoegen?", "Fijnstofmeter toevoegen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Toevoegen == DialogResult.Yes)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SQLScripts.sqlFijnstofMeterAanmaken;
                    cmd.Connection = MijnVerbinding;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlFijnstofMeterAanmaken, MijnVerbinding);

                    cmd.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));
                    cmd.Parameters.AddWithValue("@meternaam", Convert.ToString(txtMeterNaam.Text));
                    cmd.Parameters.AddWithValue("@latitude", Convert.ToString(txtLatitude.Text));
                    cmd.Parameters.AddWithValue("@longyitude", Convert.ToString(txtLongtitude.Text));


                    MijnVerbinding.Open();
                    cmd.ExecuteNonQuery();
                    MijnVerbinding.Close();

                    //Code voor de email bij aanmaken van fijnstof meter sturen

                    MailMessage RegistratieBericht = new MailMessage();
                    string naar, van, ww, bericht, onderwerp;

                    naar = InfoGebruiker.email;
                    van = InfoGebruiker.KalexEmail;
                    ww = InfoGebruiker.KalexWW;
                    bericht = "Beste " + InfoGebruiker.voornaam + " " + InfoGebruiker.familienaam + "," + "<br />" + "<br /> U heeft succesvol een fijnstof meter toegevoegd aan de database.<br /> De info van deze fijnstof meter is: <br />MeterID: " + txtMeterID.Text + "<br />Naam van de meter: " + txtMeterNaam.Text + "<br />Latitude: " + txtLatitude.Text + "<br />Longitude: " + txtLongtitude.Text + "<br /> Als u ooit problemen heeft of suggesties kan u ons altijd een mail sturen. <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                    onderwerp = "Fijnstof meter succesvol aangemaakt!";
                    RegistratieBericht.To.Add(naar);
                    RegistratieBericht.From = new MailAddress(van);
                    RegistratieBericht.Body = bericht;
                    RegistratieBericht.Subject = onderwerp;
                    RegistratieBericht.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(van, ww);
                    smtp.Send(RegistratieBericht);
                    //einde code voor de email

                    txtMeterID.Text = "";
                    txtMeterNaam.Text = "";
                    txtLatitude.Text = "";
                    txtLongtitude.Text = "";
                    MessageBox.Show("Je hebt de meter succesvol toegevoegd! ", "Aanmaken van fijnstofmter is gelukt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); //deze form sluiten form verbergen
                }
                else if (Toevoegen == DialogResult.No)
                {
                    //er gebeurd dan niks
                }
                else //FOUT PROTECTIE: moest er iets random foutlopen en de waarde is niet ja of nee 0.0
                {
                    MessageBox.Show("Er is iets foutgelopen terwijl je op de knop drukte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /* catch
         {
             MessageBox.Show("ERROR, er is een fout gebeurd", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
        */
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

