using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Windows.Forms;
using System.Data.OleDb;


namespace FijnstofGIP
{
    public partial class Aanmeldscherm : Form
    {

        public Aanmeldscherm()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataSet dsWW = new DataSet();

        #region code die naar andere from verwijst
        private void btnGeenAccount_Click(object sender, EventArgs e)
        {
            Registratiescherm volgendForm = new Registratiescherm(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Hide(); //Aanmeldscherm form verbergen
        }
        private void btnWWVergeten_Click(object sender, EventArgs e)
        {
            WachtwoordReset volgendForm = new WachtwoordReset(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Hide(); //Aanmeldscherm form verbergen
        }
        #endregion

        #region kleuren van de panelen veranderen wanneer je op een bepaalde textblock klikt + hover over label - dit is de gebruiker feedback geven waar hij typt en waar hij kan drukken
        private void txtGebruikersnaam_Click(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.DeepSkyBlue;
            pnlwachtwoord.BackColor = Color.White;

        }
        private void txtWachtwoord_Click(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.White;
            pnlwachtwoord.BackColor = Color.DeepSkyBlue;
        }
        private void btnGeenAccount_Hover(object sender, EventArgs e)
        {
            btnGeenAccount.ForeColor = Color.DeepSkyBlue;
        }
        private void btnGeenAccount_GeenHover(object sender, EventArgs e)
        {
            btnGeenAccount.ForeColor = Color.SteelBlue;
        }
        private void btnWWVergeten_Hover(object sender, EventArgs e)
        {
            btnWWVergeten.ForeColor = Color.DeepSkyBlue;
        }
        private void btnWWVergeten_GeenHover(object sender, EventArgs e)
        {
            btnWWVergeten.ForeColor = Color.SteelBlue;
        }

        #endregion

        #region Kleuren van de panelen veranderen via de tab - full tab support
        private void txtGebruikersnaam_Enter(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.DeepSkyBlue;
            pnlwachtwoord.BackColor = Color.White;
        }

        private void txtGebruikersnaam_Leave(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.White;
            pnlwachtwoord.BackColor = Color.White;
        }

        private void txtWachtwoord_Enter(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.White;
            pnlwachtwoord.BackColor = Color.DeepSkyBlue;
        }

        private void txtWachtwoord_Leave(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.White;
            pnlwachtwoord.BackColor = Color.White;
        }

        private void btnGeenAccount_Enter(object sender, EventArgs e)
        {
            btnGeenAccount.ForeColor = Color.DeepSkyBlue;
        }

        private void btnGeenAccount_Leave(object sender, EventArgs e)
        {
            btnGeenAccount.ForeColor = Color.SteelBlue;
        }

        private void btnWWVergeten_Enter(object sender, EventArgs e)
        {
            btnWWVergeten.ForeColor = Color.DeepSkyBlue;
        }

        private void btnWWVergeten_Leave(object sender, EventArgs e)
        {
            btnWWVergeten.ForeColor = Color.SteelBlue;
        }
        #endregion

        #region code voor de knop aanmelden -> ingewikkeld door de 2 tabellen
        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            try
            {
                //gegevens van gebruiker krijgen bij login -> ik heb een aparte connectie moeten maken en dit voor de wachtwoord check moeten doen anders werden de variabele niet opgevuld 0.0
                OleDbConnection verbindingInfoGebruiker = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                verbindingInfoGebruiker.Open();

                OleDbCommand cmdGebrInfo = new OleDbCommand();
                cmdGebrInfo.CommandType = CommandType.Text;
                cmdGebrInfo.CommandText = SQLScripts.sqlInfoGebruiker;
                cmdGebrInfo.Connection = verbindingInfoGebruiker;

                cmdGebrInfo.Parameters.AddWithValue("@gebruikersnaam", Convert.ToString(txtGebruikersnaam.Text));

                cmdGebrInfo.ExecuteNonQuery();
                OleDbDataReader drGebrInfo = cmdGebrInfo.ExecuteReader();

                //we slaan deze op in de InfoGebruiker -> handig om de gebruiker zijn info te hebben bij ALLE forms + ID van gebruiker krijgen
                while (drGebrInfo.Read())
                {
                    InfoGebruiker.gebruikersID = drGebrInfo.GetValue(0).ToString();
                    InfoGebruiker.email = drGebrInfo.GetValue(1).ToString();
                    InfoGebruiker.voornaam = drGebrInfo.GetValue(2).ToString();
                    InfoGebruiker.familienaam = drGebrInfo.GetValue(3).ToString();
                    InfoGebruiker.huisnummer = drGebrInfo.GetValue(4).ToString();
                    InfoGebruiker.straat = drGebrInfo.GetValue(5).ToString();
                    InfoGebruiker.postcode = drGebrInfo.GetValue(6).ToString();
                    InfoGebruiker.gemeente = drGebrInfo.GetValue(7).ToString();
                }
                InfoGebruiker.gebruikersnaam = txtGebruikersnaam.Text;
                
                verbindingInfoGebruiker.Close();
                //--------------------------------------------------------------------------------------------

                //Login instructie ----------------------------------------------------------------------------
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();
                //we nemen de gebruikersnaam via de gebruikersnaam -> we doen dit omdat we de adapter login gaan vullen
                string login = "SELECT gebruikersnaam FROM tblgebruikers WHERE gebruikersID=@gebruikersID";
                //via de gebruikersID die we verkregen hebben via gebruikersnaam nemen we het wachtwoord
                string loginWW = "SELECT wachtwoord FROM tblgebruikersWW WHERE gebruikersID=@gebruikersID";

                OleDbDataAdapter adapter = new OleDbDataAdapter(login, MijnVerbinding);
                adapter.SelectCommand.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);
                OleDbDataAdapter adapterWW = new OleDbDataAdapter(loginWW, MijnVerbinding);
                adapterWW.SelectCommand.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);

                //we vullen de datasetten in
                adapter.Fill(ds, "login");
                adapterWW.Fill(dsWW, "loginWW");

                //deze if zorgt ervoor dat we de login HOOFDLETTER gevoelig maken, heel belangrijk!
                //Hasher.Hash_SHA1 neemt de hash code van de string
                if ((Hasher.Hash_SHA1(txtWachtwoord.Text) == dsWW.Tables[0].Rows[0]["wachtwoord"].ToString()) && (txtGebruikersnaam.Text == ds.Tables[0].Rows[0]["gebruikersnaam"].ToString()))
                {   //als de login klopt wordt je ingelogd
                    Menu volgendForm = new Menu(); //volgend form declareren
                    volgendForm.Show(); //tonen van volgend form
                    this.Hide(); //Aanmeldscherm form verbergen
                }
                else
                {
                    //als een hoofdletter niet klopt krijg deze melding te zien
                    //uit veiligheid geven we de globale melding "Ongeldige gebruikersnaam of wachtwoord"
                    MessageBox.Show("Ongeldige gebruikersnaam of wachtwoord, probeer opnieuw aub", "Login mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGebruikersnaam.Text = "";
                    txtWachtwoord.Text = "";
                    txtGebruikersnaam.Focus();
                }
                
                MijnVerbinding.Close();
                //---------------------------------------------------------------------------------------------------      
            }
            catch
            {   //wanneer de gebruiker niet bestaat en er dus geen gebruikersID is gebeurd er een error dus tonen we deze globale melding
                MessageBox.Show("Ongeldige gebruikersnaam of wachtwoord, probeer opnieuw aub", "Aanmelden Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region code zichtbaar ww of niet zichtbaar ww
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


        #endregion
    }
}
