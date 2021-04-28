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
        private void Registratiescherm_Load(object sender, EventArgs e)
        {

        }
        #region code voor de knop registeren
        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtVoornaam.Text == "" && txtFamilienaam.Text == "" && txtStraat.Text == "" && txtHuisNummer.Text == "" && txtPostcode.Text == "" && txtGemeente.Text == "" && txtGebruikersnaam.Text == "" && txtEmail.Text == "" && txtWachtwoord.Text == "" && txtWachtwoordBevestigen.Text == "")
                {
                    MessageBox.Show("Je moet alle velden invullen", "Registratie Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtWachtwoord.Text == txtWachtwoordBevestigen.Text)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SQLScripts.sqlRegistreren;
                    cmd.Connection = MijnVerbinding;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlRegistreren, MijnVerbinding);

                    cmd.Parameters.AddWithValue("@gebruikersnaam", Convert.ToString(txtGebruikersnaam.Text));
                    cmd.Parameters.AddWithValue("@email", Convert.ToString(txtEmail.Text));
                    cmd.Parameters.AddWithValue("@wachtwoord", Convert.ToString(txtWachtwoord.Text));
                    cmd.Parameters.AddWithValue("@voornaam", Convert.ToString(txtVoornaam.Text));
                    cmd.Parameters.AddWithValue("@familienaam", Convert.ToString(txtFamilienaam.Text));
                    cmd.Parameters.AddWithValue("@huisnummer", Convert.ToInt32(txtHuisNummer.Text));
                    cmd.Parameters.AddWithValue("@straat", Convert.ToString(txtStraat.Text));
                    cmd.Parameters.AddWithValue("@postcode", Convert.ToInt32(txtPostcode.Text));
                    cmd.Parameters.AddWithValue("@gemeente", Convert.ToString(txtGemeente.Text));

                    MijnVerbinding.Open();
                    cmd.ExecuteNonQuery();
                    MijnVerbinding.Close();

                    MessageBox.Show("Je bent succesvol geregistreerd! ", "Registratie Gelukt", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    //Code voor de email bij registratie te sturen

                    MailMessage RegistratieBericht = new MailMessage();
                    string naar, van, ww, bericht, onderwerp;

                    naar = txtEmail.Text;
                    van = "kalex.fijnstofmeter@gmail.com";
                    ww = "eY2d2Cwd2DKd3VG";
                    bericht = "Beste " + txtVoornaam.Text + " " + txtFamilienaam.Text + "," +  "<br />" + "<br /> Dank u voor te registreren bij de fijnstofmeter van Kalex.<br /> Als u ooit problemen heeft kan u ons altijd een mail sturen. <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                    onderwerp = "Welkom bij Kalex";
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

                    Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
                    volgendForm.Show(); //tonen van volgend form
                    this.Hide(); //Registratiescherm form verbergen
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen, gelieve opnieuw te proberen", "Registratie Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWachtwoord.Text = "";
                    txtWachtwoordBevestigen.Text = "";
                    txtWachtwoord.Focus();
                }

            }
            catch
            {
                MessageBox.Show("ERROR, er is een fout gebeurd", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region code coor de knop terugkeren (naar login)
        private void btnNaarLogin_Click(object sender, EventArgs e)
        {
            Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Hide(); //Registratiescherm form verbergen
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

    }
}
