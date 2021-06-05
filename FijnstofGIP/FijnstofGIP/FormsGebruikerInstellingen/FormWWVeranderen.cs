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

namespace FijnstofGIP.FormsGebruikerInstellingen
{
    public partial class FormWWVeranderen : Form
    {
        public FormWWVeranderen()
        {
            InitializeComponent();
        }
        DataSet dsWW = new DataSet();

        #region lay-out -> bij klik een kleur
        private void txtHuidigWW_Click(object sender, EventArgs e)
        {
            pnlHuidigWW.BackColor = Color.DeepSkyBlue;
        }
        private void txtWW_Click(object sender, EventArgs e)
        {
            pnlHuidigWW.BackColor = Color.White;
            pnlWW.BackColor = Color.DeepSkyBlue;
            pnlWWBevestigen.BackColor = Color.White;
        }

        private void txtWWBevestigen_Click(object sender, EventArgs e)
        {
            pnlHuidigWW.BackColor = Color.White;
            pnlWW.BackColor = Color.White;
            pnlWWBevestigen.BackColor = Color.DeepSkyBlue;
        }
        #endregion

        #region tab support -> kleurtjes
        private void txtHuidigWW_Enter(object sender, EventArgs e)
        {
            pnlHuidigWW.BackColor = Color.DeepSkyBlue;
        }

        private void txtHuidigWW_Leave(object sender, EventArgs e)
        {
            pnlHuidigWW.BackColor = Color.White;
        }
        private void txtWW_Enter(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.DeepSkyBlue;
        }

        private void txtWW_Leave(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.White;
        }

        private void txtWWBevestigen_Enter(object sender, EventArgs e)
        {
            pnlWWBevestigen.BackColor = Color.DeepSkyBlue;
        }

        private void txtWWBevestigen_Leave(object sender, EventArgs e)
        {
            pnlWWBevestigen.BackColor = Color.White;
        }
        #endregion

        #region tekst bij hover -> geeft de gebruiker meer feedback over wat iets doet

        private void btnLock_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te tonen.", btnLock);
        }

        private void btnLockBevestigen_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te tonen.", btnLockBevestigen);
        }

        private void btnLockHuidigWW_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te tonen.", btnLockHuidigWW);
        }

        private void btnOpenLock_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te verbergen.", btnOpenLock);
        }

        private void btnOpenLockBevestigen_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te verbergen.", btnOpenLockBevestigen);
        }

        private void btnOpenLockHuidigWW_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te verbergen.", btnOpenLockHuidigWW);
        }
        #endregion

        #region code knop gegevens Opslaan
        private void btnGegevensOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWW.Text == "" & txtWWBevestigen.Text == "")
                {
                    MessageBox.Show("Je moet alle velden invullen", "Wachtwoord verandern mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnlWW.BackColor = Color.Red;
                    pnlWWBevestigen.BackColor = Color.Red;
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

                    cmdInfoWW.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);
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

                    cmdWWVeranderen.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);
                    cmdWWVeranderen.Parameters.AddWithValue("@wachtwoord", hashedWW);
                    cmdWWVeranderen.Parameters.AddWithValue("@wachtwoordID", wachtwoordID);
                    cmdWWVeranderen.ExecuteNonQuery();

                    VerbindingWWVeranderen.Close();


                    MessageBox.Show("U heeft uw wachtwoord succesvol verandered, gelieve uit te loggen zodat U met uw nieuwe gegevens kan inloggen.", "Succesvol nieuw wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlWWCheckSectie.Visible = true;
                    pnlWWVeranderenSectie.Visible = false;
                    btnGegevensOpslaan.Enabled = false;
                    txtHuidigWW.Clear();
                    txtWW.Clear();
                    txtWWBevestigen.Clear();

                    //versturen van de email om de gebruiker te waarschuwen van het nieuwe wachtwoord
                    MailMessage CodeMail = new MailMessage();
                    string naar, van, ww, bericht, onderwerp;

                    naar = InfoGebruiker.email;
                    van = InfoGebruiker.KalexEmail;
                    ww = InfoGebruiker.KalexWW;
                    bericht = "Beste " + InfoGebruiker.voornaam + " " + InfoGebruiker.familienaam + "," + "<br />" + "<br /> U wachtwoord is succesvol veranderd op: " + DateTime.Now.ToString("dd MMMM yyyy") + " om " + DateTime.Now.ToString("H:m:s") + ".<br /> Uw wachtwoord is veranderd via de gebruikersinstellingen (dus na het inloggen).<br /> Als U dit niet was gelieve persoonlijk contact met ons op te nemen.<br /> Nog een prettige dag verder! <br /> <br /> Met vriendelijke groeten, <br />Kalex";
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
                    MessageBox.Show("Wachtwoorden komen niet overeen, gelieve opnieuw te proberen", "Wachtwoord veranderen Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pnlWW.BackColor = Color.Red;
                    pnlWWBevestigen.BackColor = Color.Red;

                    txtWW.Clear();
                    txtWWBevestigen.Clear();
                }

            }
            catch 
            {
                MessageBox.Show("ERROR: Tijdens het opslaan is er een fout gebeurd", "Oplsaan Mislukt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region code knop bevestigen
        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                //via de gebruikersID die we verkregen hebben via gebruikersnaam nemen we het wachtwoord
                string loginWW = "SELECT wachtwoord FROM tblgebruikersWW WHERE gebruikersID=@gebruikersID";

                OleDbDataAdapter adapterWW = new OleDbDataAdapter(loginWW, MijnVerbinding);
                adapterWW.SelectCommand.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);

                //we vullen de datasetten in
                adapterWW.Fill(dsWW, "loginWW");

                //We gaan op een hoofdletter gevoelige manier checken of het wachtwoord wel klopt
                if ((Hasher.Hash_SHA1(txtHuidigWW.Text) == dsWW.Tables[0].Rows[0]["wachtwoord"].ToString()))
                {   //als de login klopt:
                    pnlWWCheckSectie.Visible = false;
                    pnlWWVeranderenSectie.Visible = true;
                    MessageBox.Show("Wachtwoord klopt", "Juist wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGegevensOpslaan.Enabled = true;
                }
                else
                {
                    //als een hoofdletter niet klopt krijg deze melding te zien
                    MessageBox.Show("Ongeldig wachtwoord, probeer opnieuw aub", "Login mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MijnVerbinding.Close();
            }
            catch 
            {
                MessageBox.Show("ERROR: Fout tijdens controloren van het wachtwoord", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region code zichtbaar ww of niet zichtbaar
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '*')
            {
                btnOpenLock.BringToFront();
                txtWW.PasswordChar = '\0';
            }
        }

        private void btnOpenLock_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '\0')
            {
                btnLock.BringToFront();
                txtWW.PasswordChar = '*';
            }
        }

        private void btnLockBevestigen_Click(object sender, EventArgs e)
        {
            if (txtWWBevestigen.PasswordChar == '*')
            {
                btnOpenLockBevestigen.BringToFront();
                txtWWBevestigen.PasswordChar = '\0';
            }
        }

        private void btnOpenLockBevestigen_Click(object sender, EventArgs e)
        {
            if (txtWWBevestigen.PasswordChar == '\0')
            {
                btnLockBevestigen.BringToFront();
                txtWWBevestigen.PasswordChar = '*';
            }
        }


        
        private void btnLockHuidigWW_Click(object sender, EventArgs e)
        {
            if (txtHuidigWW.PasswordChar == '*')
            {
                btnOpenLockHuidigWW.BringToFront();
                txtHuidigWW.PasswordChar = '\0';
            }
        }

        private void btnOpenLockHuidigWW_Click(object sender, EventArgs e)
        {
            if (txtHuidigWW.PasswordChar == '\0')
            {
                btnLockHuidigWW.BringToFront();
                txtHuidigWW.PasswordChar = '*';
            }
        }
        #endregion
    }
}
