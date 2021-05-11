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
    public partial class WachtwoordReset : Form
    {
        public WachtwoordReset()
        {
            InitializeComponent(); 
        }
        //globale variabele die we gebruiken in meerdere private voids
        Int32 codeWW = 0;
        string gebruikerEmail = "";
        string gebruikersID = "";
        string voornaam = "";
        string achternaam = "";

        #region  kleuren van de panelen veranderen wanneer je op een bepaalde textblock klikt - dit is zodat de gebruiker weet waar hij gaat typen
        private void txtEmail_Click(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.DeepSkyBlue;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.DeepSkyBlue;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtWW_Click(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.DeepSkyBlue;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtWWBevestigen_Click(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.DeepSkyBlue;
        }

        #endregion

        #region Kleuren van de panelen veranderen via tab - full tab support
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.DeepSkyBlue;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            pnlCode.BackColor = Color.DeepSkyBlue;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtWW_Enter(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.DeepSkyBlue;
        }

        private void txtWW_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtWWBevestigen_Enter(object sender, EventArgs e)
        {
            pnlWWBevestigen.BackColor = Color.DeepSkyBlue;
        }

        private void txtWWBevestigen_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
            pnlCode.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.White;
        }

        #endregion

        #region de code voor alle knoppen
        private void btnCodeVersturen_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("Als uw e-mail gelinkt is aan een account zal u een e-mail met een code ontvangen", "Code versturen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OleDbConnection Mijnverbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                Mijnverbinding.Open();

                OleDbCommand cmdMailChecken = new OleDbCommand();
                cmdMailChecken.CommandType = CommandType.Text;
                cmdMailChecken.CommandText = SQLScripts.sqlEmailGebruiker;
                cmdMailChecken.Connection = Mijnverbinding;


                cmdMailChecken.Parameters.AddWithValue("@email", Convert.ToString(txtEmail.Text));
                cmdMailChecken.ExecuteNonQuery();

                //als de email bestaat zal hij de string vullen
                OleDbDataReader drInfoViaEmail = cmdMailChecken.ExecuteReader();
                Boolean mailBestaat = false;
                while (drInfoViaEmail.Read())
                {
                    gebruikersID = drInfoViaEmail.GetValue(0).ToString();
                    gebruikerEmail = drInfoViaEmail.GetValue(1).ToString();
                    voornaam = drInfoViaEmail.GetValue(2).ToString();
                    achternaam = drInfoViaEmail.GetValue(3).ToString();

                    //via dit vermijden we een error -> als de email gwn random text is zal dit niet true zijn en zal de code van de mail ook niet worden uitgevoerd
                    //als deze variabele wel true is dan bestaat de mail gewoon -> deze manier gaat ook niet hoofdletter gevoelig zijn
                    mailBestaat = true;
                }
                Mijnverbinding.Close();

                if (mailBestaat == true)
                {
                    //Code aanmaken + versturen van de email

                    Random rnd = new Random();
                    Int32 codeRnd = rnd.Next(132579, 999999);
                    codeWW = codeRnd;
                    MailMessage CodeMail = new MailMessage();
                    string naar, van, ww, bericht, onderwerp;

                    naar = txtEmail.Text;
                    van = InfoGebruiker.KalexEmail;
                    ww = InfoGebruiker.KalexWW;
                    bericht = "Beste " + voornaam + " " + achternaam + "," + "<br />" + "<br /> U heeft een code aangevraagd om uw wachtwoord te veranderen, dit is uw code: " + codeWW + " <br /> Nog een prettige dag verder! <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                    onderwerp = "Code nieuw wachtwoord";
                    CodeMail.To.Add(naar);
                    CodeMail.From = new MailAddress(van);
                    CodeMail.Body = bericht;
                    CodeMail.Subject = onderwerp;
                    CodeMail.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(van, ww);
                    smtp.Send(CodeMail);
                    // einde code voor de email

                    //de variabele waar false maken
                    mailBestaat = false;
                }
                else
                {
                    //niks
                }

                //verder gaan naar andere sectie
                pnlCodeSectie.Visible = true;
                pnlEmailSectie.Visible = false;
            }
            catch
            {
                MessageBox.Show("Onverwachte error", "Code connectie mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCodeIndienen_Click(object sender, EventArgs e)
        {
            try
            {
                //als we txtCode naar int converteren gaat dat problemen opleveren als de gebruiker dan ook gwn tekst invoerd -> daarom maken we van de code een string, dit zal geen problemenen geven
                if (txtCode.Text == Convert.ToString(codeWW))
                {
                    MessageBox.Show("De ingevoerde code is juist!", "Juiste code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlWWVeranderenSectie.Visible = true;
                    pnlCodeSectie.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Onverwachte error", "Code indienen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNieuweCode_Click(object sender, EventArgs e)
        {
            DialogResult nieuweCode = MessageBox.Show("Soms kan het even duren voordat U een mail ontvangt en soms belandt de mail ook bij spam. Als u echt geen code ontvangen heeft kan u altijd een nieuwe aanvragen. Druk op ja voor een nieuwe code en op nee als u nog even wilt wachten.", "Nieuwe code", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (nieuweCode == DialogResult.Yes)
            {
                pnlEmailSectie.Visible = true;
                pnlCodeSectie.Visible = false;
                txtEmail.Text = "";
            }
            else
            {
                //er gebeurd dan niks
            }

        }

        private void btnWWBevestigen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWW.Text == "" && txtWWBevestigen.Text == "")
                {
                    MessageBox.Show("Je moet alle velden invullen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtWW.Text == txtWWBevestigen.Text)
                {
                    //code voor het verkrijgen van het wachtwoord ID van de gebruiker via GebruikersID -> via deze ID updaten we het WW van de gebruiker
                    OleDbConnection VerbindingInfoWW = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    VerbindingInfoWW.Open();

                    OleDbCommand cmdInfoWW = new OleDbCommand();
                    cmdInfoWW.CommandType = CommandType.Text;
                    cmdInfoWW.CommandText = SQLScripts.sqlWachtwoordID;
                    cmdInfoWW.Connection = VerbindingInfoWW;

                    cmdInfoWW.Parameters.AddWithValue("@gebruikersID", gebruikersID);
                    cmdInfoWW.ExecuteNonQuery();

                    OleDbDataReader drInfoWW = cmdInfoWW.ExecuteReader();

                    string wachtwoordID = "";
                    while (drInfoWW.Read())
                    {
                        wachtwoordID = drInfoWW.GetValue(0).ToString();
                    }

                    VerbindingInfoWW.Close();

                    //code voor het wachtwoord te veranderen
                    OleDbConnection VerbindingWWVeranderen = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    VerbindingWWVeranderen.Open();

                    OleDbCommand cmdWWVeranderen = new OleDbCommand();
                    cmdWWVeranderen.CommandType = CommandType.Text;
                    cmdWWVeranderen.CommandText = SQLScripts.sqlAanpassenWWGebruiker;
                    cmdWWVeranderen.Connection = VerbindingWWVeranderen;

                    //zet het wachtwoord om naar Hash CODE
                    string hashedWW = Hasher.Hash_SHA1(txtWWBevestigen.Text);

                    cmdWWVeranderen.Parameters.AddWithValue("@gebruikersID", gebruikersID);
                    cmdWWVeranderen.Parameters.AddWithValue("@wachtwoord", hashedWW);
                    cmdWWVeranderen.Parameters.AddWithValue("@wachtwoordID", wachtwoordID);
                    cmdWWVeranderen.ExecuteNonQuery();

                    VerbindingWWVeranderen.Close();

                    MessageBox.Show("U heeft uw wachtwoord succesvol verandered.", "Succesvol nieuw wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Na het succesvol veranderen terug naar aanmeldscherm sturen
                    Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
                    volgendForm.Show(); //tonen van volgend form
                    this.Hide(); //Aanmeldscherm form verbergen
                    //-----------------------------------------------------

                    //versturen van de email om de gebruiker te waarschuwen van het nieuwe wachtwoord
                    MailMessage CodeMail = new MailMessage();
                    string naar, van, ww, bericht, onderwerp;

                    naar = gebruikerEmail;
                    van = InfoGebruiker.KalexEmail;
                    ww = InfoGebruiker.KalexWW;
                    bericht = "Beste " + voornaam + " " + achternaam + "," + "<br />" + "<br /> U wachtwoord is succesvol veranderd op: " + DateTime.Now.ToString("dd MMMM yyyy") +  " om " + DateTime.Now.ToString("H:m:s")  + ".<br />Als U dit niet was gelieve persoonlijk contact met ons op te nemen.<br /> Nog een prettige dag verder! <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                    onderwerp = "Wachtwoord veranderd";
                    CodeMail.To.Add(naar);
                    CodeMail.From = new MailAddress(van);
                    CodeMail.Body = bericht;
                    CodeMail.Subject = onderwerp;
                    CodeMail.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(van, ww);
                    smtp.Send(CodeMail);
                    // einde code voor de email -------------------------------------
                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen, gelieve opnieuw te proberen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWW.Text = "";
                    txtWWBevestigen.Text = "";
                    txtWW.Focus();
                }
            }
            catch
            {

            }
        }

        private void btnTerugkeren_Click(object sender, EventArgs e)
        {
            Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Hide(); //Aanmeldscherm form verbergen
        }


        #endregion

        #region code zichtbaar ww of niet zichtbaar
        private void iconbtnLock_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '*')
            {
                iconbtnOpenLock.BringToFront();
                txtWW.PasswordChar = '\0';
            }
        }

        private void iconbtnOpenLock_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '\0')
            {
                iconbtnLock.BringToFront();
                txtWW.PasswordChar = '*';
            }
        }

        private void iconbtnLockBevestigen_Click(object sender, EventArgs e)
        {
            if (txtWWBevestigen.PasswordChar == '*')
            {
                iconbtnOpenLockBevestigen.BringToFront();
                txtWWBevestigen.PasswordChar = '\0';
            }
        }

        private void iconbtnOpenLockBevestigen_Click(object sender, EventArgs e)
        {
            if (txtWWBevestigen.PasswordChar == '\0')
            {
                iconbtnLockBevestigen.BringToFront();
                txtWWBevestigen.PasswordChar = '*';
            }
        }
        #endregion
    }
}
