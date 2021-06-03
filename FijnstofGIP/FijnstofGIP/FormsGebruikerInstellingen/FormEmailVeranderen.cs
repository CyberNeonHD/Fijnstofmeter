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
    public partial class FormEmailVeranderen : Form
    {
        public FormEmailVeranderen()
        {
            InitializeComponent();
        }
        DataSet dsWW = new DataSet();


        #region lay-out -> bij klik een kleur
        private void txtWW_Click(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.DeepSkyBlue;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.DeepSkyBlue;
        }

        #endregion

        #region tab support -> kleurtjes
        private void txtWW_Enter(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.DeepSkyBlue;
        }

        private void txtWW_Leave(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.DeepSkyBlue;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            pnlEmail.BackColor = Color.White;
        }

        #endregion

        #region tekst bij hover -> geeft de gebruiker meer feedback over wat iets doet
        private void btnLockWW_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te tonen.", btnLockWW);
        }

        private void btnOpenLockWW_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te verbergen.", btnOpenLockWW);
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
                if ((Hasher.Hash_SHA1(txtWW.Text) == dsWW.Tables[0].Rows[0]["wachtwoord"].ToString()))
                {   //als de login klopt:
                    pnlWWCheckSectie.Visible = false;
                    pnlEmailSectie.Visible = true;
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
                MessageBox.Show("ERROR: Fout tijdens controleren van het wachtwoord", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region code zichtbaar ww of niet zichtbaar
        private void btnLockWW_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '*')
            {
                btnOpenLockWW.BringToFront();
                txtWW.PasswordChar = '\0';
            }
        }

        private void btnOpenLockWW_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '\0')
            {
                btnLockWW.BringToFront();
                txtWW.PasswordChar = '*';
            }
        }


        #endregion

        #region code knop gegevens Opslaan
        private void btnGegevensOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult emailBewaren = MessageBox.Show("Ben je zeker dat U de juiste gegevens hebt ingevult?", "Nieuwe e-mail bewaren", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (emailBewaren == DialogResult.Yes)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    MijnVerbinding.Open();

                    OleDbCommand cmdAdresAanpassen = new OleDbCommand();
                    cmdAdresAanpassen.CommandType = CommandType.Text;
                    cmdAdresAanpassen.CommandText = SQLScripts.sqlAanpassenAdres;
                    cmdAdresAanpassen.Connection = MijnVerbinding;

                    cmdAdresAanpassen.Parameters.AddWithValue("@gebruikersID", Convert.ToString(InfoGebruiker.gebruikersID));
                    cmdAdresAanpassen.Parameters.AddWithValue("@gebruikersnaam", Convert.ToString(InfoGebruiker.gebruikersnaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@email", Convert.ToString(txtEmail.Text));
                    cmdAdresAanpassen.Parameters.AddWithValue("@voornaam", Convert.ToString(InfoGebruiker.voornaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@familienaam", Convert.ToString(InfoGebruiker.familienaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@straat", Convert.ToString(InfoGebruiker.straat));
                    cmdAdresAanpassen.Parameters.AddWithValue("@huisnummer", Convert.ToInt32(InfoGebruiker.huisnummer));
                    cmdAdresAanpassen.Parameters.AddWithValue("@postcode", Convert.ToInt32(InfoGebruiker.postcode));
                    cmdAdresAanpassen.Parameters.AddWithValue("@gemeente", Convert.ToString(InfoGebruiker.gemeente));

                    cmdAdresAanpassen.ExecuteNonQuery();
                    MijnVerbinding.Close();

                    //updaten van de info over de gebruiker
                    InfoGebruiker.email = txtEmail.Text;
                    MessageBox.Show("Jouw email is upgedate!", "Email bewaard!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGegevensOpslaan.Enabled = false;

                    //versturen van de email om de gebruiker te waarschuwen van het nieuwe wachtwoord
                    MailMessage CodeMail = new MailMessage();
                    string naar, van, ww, bericht, onderwerp;

                    naar = InfoGebruiker.email;
                    van = InfoGebruiker.KalexEmail;
                    ww = InfoGebruiker.KalexWW;
                    bericht = "Beste " + InfoGebruiker.voornaam + " " + InfoGebruiker.familienaam + "," + "<br />" + "<br /> Dit is nu uw nieuwe e-mail waar alle toekomstige notificaties van het programma zullen naartoe worden gestuurd.<br />Nog een prettige dag verder! <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                    onderwerp = "Nieuwe Email";
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
                    //er gebeurd dan niks
                }
            }
            catch
            {

                MessageBox.Show("ERROR: Email bestaat al!", "Opslaan Mislukt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                pnlEmail.BackColor = Color.Red;
            }
        }
        #endregion


    }
}
