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
using System.Net; //voor de mail
using System.Net.Mail; //voor de mail

namespace FijnstofGIP
{
    public partial class Registratiescherm : Form
    {
        
        public Registratiescherm()
        {
            InitializeComponent();
        }

        #region kleuren van de panelen veranderen wanneer je op een bepaalde textblock klikt - dit is zodat de gebruiker weet waar hij gaat typen
        private void txtVoornaam_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.DeepSkyBlue;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtFamilienaam_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.DeepSkyBlue;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtStraat_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.DeepSkyBlue;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtPostcode_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.DeepSkyBlue;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtHuisNummer_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.DeepSkyBlue;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtGemeente_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.DeepSkyBlue;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtGebruikersnaam_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.DeepSkyBlue;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.DeepSkyBlue;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtWachtwoord_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.DeepSkyBlue;
            pnlwwbevestigen.BackColor = Color.White;
        }
        private void txtWachtwoordBevestigen_Click(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
            pnlfamilie.BackColor = Color.White;
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
            pnlgebruikersnaam.BackColor = Color.White;
            pnlEmail.BackColor = Color.White;
            pnlww.BackColor = Color.White;
            pnlwwbevestigen.BackColor = Color.DeepSkyBlue;
        }
        #endregion

        #region Kleuren van de panelen veranderen via tab - full tab support
        private void txtVoornaam_Enter(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.DeepSkyBlue;
        }

        private void txtVoornaam_Leave(object sender, EventArgs e)
        {
            pnlvoornaam.BackColor = Color.White;
        }

        private void txtFamilienaam_Enter(object sender, EventArgs e)
        {
            pnlfamilie.BackColor = Color.DeepSkyBlue;
        }

        private void txtFamilienaam_Leave(object sender, EventArgs e)
        {
            pnlfamilie.BackColor = Color.White;
        }

        private void txtStraat_Enter(object sender, EventArgs e)
        {
            pnlstraat.BackColor = Color.DeepSkyBlue;
        }
        private void txtStraat_Leave(object sender, EventArgs e)
        {

            pnlstraat.BackColor = Color.White;
        }
        private void txtPostcode_Enter(object sender, EventArgs e)
        {
            pnlpostcode.BackColor = Color.DeepSkyBlue;
        }

        private void txtPostcode_Leave(object sender, EventArgs e)
        {
            pnlpostcode.BackColor = Color.White;
        }

        private void txtHuisNummer_Enter(object sender, EventArgs e)
        {

            pnlhuisnummer.BackColor = Color.DeepSkyBlue;
        }

        private void txtHuisNummer_Leave(object sender, EventArgs e)
        {

            pnlhuisnummer.BackColor = Color.White;
        }

        private void txtGemeente_Enter(object sender, EventArgs e)
        {
            pnlgemeente.BackColor = Color.DeepSkyBlue;
        }

        private void txtGemeente_Leave(object sender, EventArgs e)
        {
            pnlgemeente.BackColor = Color.White;
        }

        private void txtGebruikersnaam_Enter(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.DeepSkyBlue;
        }

        private void txtGebruikersnaam_Leave(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.DeepSkyBlue;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
        }

        private void txtWachtwoord_Enter(object sender, EventArgs e)
        {
            pnlww.BackColor = Color.DeepSkyBlue;
        }

        private void txtWachtwoord_Leave(object sender, EventArgs e)
        {
            pnlww.BackColor = Color.White;
        }

        private void txtWachtwoordBevestigen_Enter(object sender, EventArgs e)
        {
            pnlwwbevestigen.BackColor = Color.DeepSkyBlue;
        }

        private void txtWachtwoordBevestigen_Leave(object sender, EventArgs e)
        {
            pnlwwbevestigen.BackColor = Color.White;
        }
        #endregion

        #region code voor de knop registeren
        private void btnRegistreren_Click(object sender, EventArgs e)
        {
 
            if (txtVoornaam.Text == "" && txtFamilienaam.Text == "" && txtGebruikersnaam.Text == "" && txtEmail.Text == "" && txtWachtwoord.Text == "" && txtWachtwoordBevestigen.Text == "")
            {
                MessageBox.Show("Je moet alle verplichte velden invullen", "Registratie Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtWachtwoord.Text == txtWachtwoordBevestigen.Text)
            {   //deze variabele zal een 2de foutmelding vermijden
                Boolean foutMelding = false;

                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                //volledige registratie in de tabel gebruikers zetten
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SQLScripts.sqlRegistreren;
                cmd.Connection = MijnVerbinding;

                //aanmaken van eigen gebruikersID -> dit zorgt ervoor dat we geen autonummering moeten hebben en dus gebruikersinstellingen kunnen aanmaken want je moet de gebruikersID ook "updaten" bij (UPDATE SQL commando) en bij autonummering gaf dat problemen
                Random rnd = new Random();
                string codeRnd = Convert.ToString(rnd.Next(132526, 999999));


                //we moeten een data in de tabel zetten dus als de gebruiker geen data invoert, voeren we zelf standaardwaarde in
                if (txtHuisNummer.Text == "")
                {
                    txtHuisNummer.Text = "0";
                }
                if (txtStraat.Text == "")
                {
                    txtStraat.Text = "geen data";
                }
                if (txtPostcode.Text == "")
                {
                    txtPostcode.Text = "0";
                }
                if (txtGemeente.Text == "")
                {
                    txtGemeente.Text = "geen data";
                }
                if (txtStraat.Text == "")
                {
                    txtStraat.Text = "geen data";
                }

                string idGebruiker = "";
                string gebruikersID = "";
                string email = "";
                string voornaam = "";
                string familienaam = "";
                try
                {   //aanmaken van onze eigen gebruikersid
                    gebruikersID = txtVoornaam.Text.ToString().Substring(0, 1).ToUpper() + txtVoornaam.Text.ToString().Substring(1, 1) + txtFamilienaam.Text.ToString().Substring(0, 1).ToUpper() + txtFamilienaam.Text.ToString().Substring(1, 1) + "_" + codeRnd;

                    //Ten allen tijden de eerste letter van de voornaam en familienaam en gebruikersnaam als hoofdletter zetten
                    string gebruikersnaam = txtGebruikersnaam.Text.ToString().Substring(0, 1).ToUpper() + txtGebruikersnaam.Text.ToString().Substring(1, txtGebruikersnaam.Text.Length - 1);
                    voornaam = txtVoornaam.Text.ToString().Substring(0, 1).ToUpper() + txtVoornaam.Text.ToString().Substring(1, txtVoornaam.Text.Length - 1);
                    familienaam = txtFamilienaam.Text.ToString().Substring(0, 1).ToUpper() + txtFamilienaam.Text.ToString().Substring(1, txtFamilienaam.Text.Length - 1);

                    cmd.Parameters.AddWithValue("@gebruikersid", gebruikersID);
                    cmd.Parameters.AddWithValue("@gebruikersnaam", gebruikersnaam);
                    cmd.Parameters.AddWithValue("@email", Convert.ToString(txtEmail.Text));
                    cmd.Parameters.AddWithValue("@voornaam", voornaam);
                    cmd.Parameters.AddWithValue("@familienaam", familienaam);
                    cmd.Parameters.AddWithValue("@straat", Convert.ToString(txtStraat.Text));
                }
                catch 
                {
                    MessageBox.Show("FOUT bij voornaam of achternaam, heb je wel een naam gebruikt dat langer dan 2 letters is ? Als jouw naam langer is dan 2 letters is er een onverwachte zeldzame fout gebeurd. Gelieve opnieuw te proberen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foutMelding = true;
                    pnlvoornaam.BackColor = Color.Red;
                    pnlfamilie.BackColor = Color.Red;
                }
                //via deze manier geeft gebruikersID op lijn 396 geen error -_-
                idGebruiker = gebruikersID;

                //via deze manier geeft gebruikersID op lijn 430 geen error -_-
                email = txtEmail.Text;




                //als de gebruiker een tekst ingeeft komt er een error -> we maken dus specifiek deze melding
                try
                {
                    cmd.Parameters.AddWithValue("@huisnummer", Convert.ToInt32(txtHuisNummer.Text));
                }
                catch 
                {
                    MessageBox.Show("FOUT bij huisnummer, heb je wel een getal gebruikt?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foutMelding = true;
                    pnlhuisnummer.BackColor = Color.Red;
                }

                //als de gebruiker een tekst ingeeft komt er een error -> we maken dus specifiek deze melding
                try
                {
                    cmd.Parameters.AddWithValue("@postcode", Convert.ToInt32(txtPostcode.Text));
                }
                catch
                {
                    MessageBox.Show("FOUT bij postcode, heb je wel een getal gebruikt?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foutMelding = true;
                    pnlpostcode.BackColor = Color.Red;
                }
                    cmd.Parameters.AddWithValue("@gemeente", Convert.ToString(txtGemeente.Text));

            

                // bestaat email ja of nee?
                Boolean EmailBestaat = false;
                try
                {
                    if (foutMelding == true)
                    {
                        //we doen niks want anders krijgen we een 2de error bij de ExecuteNonQuery
                        foutMelding = false;
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        //invoegen van het wachtwoord in aparte tabel 
                        OleDbCommand cmdWW = new OleDbCommand();
                        cmdWW.CommandType = CommandType.Text;
                        cmdWW.CommandText = SQLScripts.sqlWWInvoeren;
                        cmdWW.Connection = MijnVerbinding;

                        //zet het wachtwoord om naar Hash CODE
                        string hashedWW = Hasher.Hash_SHA1(txtWachtwoord.Text);

                        cmdWW.Parameters.AddWithValue("@gebruikersid", idGebruiker);
                        cmdWW.Parameters.AddWithValue("@wachtwoord", hashedWW);
                        cmdWW.ExecuteNonQuery();

                        MijnVerbinding.Close();
                        MessageBox.Show("Je bent succesvol geregistreerd!", "Registratie Gelukt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
                        volgendForm.Show(); //tonen van volgend form
                        this.Close(); //Registratiescherm form sluiten
                    }
                        
                }
                catch 
                {
                    MessageBox.Show("Opgepast, gebruikersnaam of email bestaat al. Gelieve een andere gebruikersnaam of email te gebruiken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlgebruikersnaam.BackColor = Color.Red;
                    pnlEmail.BackColor = Color.Red;
                    EmailBestaat = true;
                }

                try
                {

                    if (EmailBestaat == true)
                    {
                        //we doen niks want anders krijgt een persoon die de email bezit de mail en dat mag niet
                        EmailBestaat = false;
                    }
                    else
                    {
                        
                        //Code voor de email bij registratie te sturen
                        MailMessage RegistratieBericht = new MailMessage();
                        string naar, van, ww, bericht, onderwerp;

                        naar = email;
                        van = InfoGebruiker.KalexEmail;
                        ww = InfoGebruiker.KalexWW;
                        bericht = "Beste " + voornaam + " " + familienaam + "," + "<br />" + "<br /> Dank u voor te registreren bij Particulated, het fijnstofmeter programma van Kalex.<br /> Als u ooit problemen heeft kan u ons altijd een mail sturen. <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                        onderwerp = "Welkom bij Particulated";
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
                        // einde code voor de email

                        txtGebruikersnaam.Text = "";
                        txtWachtwoord.Text = "";
                        txtWachtwoordBevestigen.Text = "";
                        txtVoornaam.Text = "";
                        txtFamilienaam.Text = "";
                        txtHuisNummer.Text = "";
                        txtStraat.Text = "";
                        txtPostcode.Text = "";
                        txtGemeente.Text = "";
                        
                    }
                }
                catch
                {
                    MessageBox.Show("Fout bij de ingevoerde email. Heb je wel een geldige email ingevoerd?", "Registratie Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foutMelding = true;
                    pnlEmail.BackColor = Color.Red;
                }


            }
            else
            {
                MessageBox.Show("Wachtwoorden komen niet overeen, gelieve opnieuw te proberen", "Registratie Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWachtwoord.Text = "";
                txtWachtwoordBevestigen.Text = "";
                txtWachtwoord.Focus();
                pnlww.BackColor = Color.Red;
                pnlwwbevestigen.BackColor = Color.Red;
            }

        }
        #endregion

        #region code voor de knop terugkeren (naar login)
        private void btnNaarLogin_Click(object sender, EventArgs e)
        {
            Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Close(); //Registratiescherm form sluiten
        }
        #endregion

        #region code zichtbaar ww of niet zichtbaar
        private void iconbtnLock_Click(object sender, EventArgs e)
        {
            if (txtWachtwoord.PasswordChar == '*')
            {
                iconbtnOpenLock.BringToFront();
                txtWachtwoord.PasswordChar = '\0';
            }
        }

        private void iconbtnOpenLock_Click(object sender, EventArgs e)
        {
            if (txtWachtwoord.PasswordChar == '\0')
            {
                iconbtnLock.BringToFront();
                txtWachtwoord.PasswordChar = '*';
            }
        }

        private void iconbtnLockBevestigen_Click(object sender, EventArgs e)
        {
            if (txtWachtwoordBevestigen.PasswordChar == '*')
            {
                iconbtnOpenLockBevestigen.BringToFront();
                txtWachtwoordBevestigen.PasswordChar = '\0';
            }
        }

        private void iconbtnOpenLockBevestigen_Click(object sender, EventArgs e)
        {
            if (txtWachtwoordBevestigen.PasswordChar == '\0')
            {
                iconbtnLockBevestigen.BringToFront();
                txtWachtwoordBevestigen.PasswordChar = '*';
            }
        }


        #endregion

        #region tekst bij hover -> geeft de gebruiker meer feedback over wat iets doet
        private void iconbtnLock_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            ToolTip.Show("  Klik om jouw wachtwoord te tonen", iconbtnLock);
        }

        private void iconbtnLockBevestigen_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            ToolTip.Show("  Klik om jouw wachtwoord te tonen", iconbtnLockBevestigen);
        }

        private void iconbtnOpenLock_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            ToolTip.Show("  Klik om jouw wachtwoord te verbergen", iconbtnOpenLock);
        }

        private void iconbtnOpenLockBevestigen_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            ToolTip.Show("  Klik om jouw wachtwoord te verbergen", iconbtnOpenLockBevestigen);
        }


        #endregion
    }
}
