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

namespace FijnstofGIP
{
    public partial class Aanmeldscherm : Form
    {
        public Aanmeldscherm()
        {
            InitializeComponent();
        }
        //code die naar het registratie scherm gaat wnr je nog geen account hebt
        private void lblGeenAccount_Click(object sender, EventArgs e)
        {
            Registratiescherm volgendForm = new Registratiescherm(); //volgend form declareren
            volgendForm.Show(); //tonen van volgend form
            this.Hide(); //Aanmeldscherm form verbergen
        }
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
        private void lblGeenAccount_Hover(object sender, EventArgs e)
        {
            lblGeenAccount.ForeColor = Color.DeepSkyBlue;
        }
        private void lblGeenAccount_GeenHover(object sender, EventArgs e)
        {
            lblGeenAccount.ForeColor = Color.SteelBlue;
        }
        #endregion

        private void txtWachtwoord_TextChanged(object sender, EventArgs e)
        {

        }
        #region code voor de knop aanmelden
        private void btnAanmelden_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                OleDbCommand cmd = new OleDbCommand();
                MijnVerbinding.Open();
                string login = "SELECT * FROM tblgebruikers WHERE gebruikersnaam= '" + txtGebruikersnaam.Text + "' and wachtwoord= '" + txtWachtwoord.Text + "'";
                string naamGebruiker = "SELECT voornaam,familienaam FROM tblgebruikers WHERE gebruikersnaam= '" + txtGebruikersnaam.Text + "' and wachtwoord= '" + txtWachtwoord.Text + "'";
                cmd = new OleDbCommand(login, MijnVerbinding);
                OleDbDataReader dr = cmd.ExecuteReader();

                //gegevens van gebruiker krijgen bij login
                OleDbCommand cmdnaamGebruiker = new OleDbCommand();
                cmdnaamGebruiker = new OleDbCommand(naamGebruiker, MijnVerbinding);
                OleDbDataReader drnaamGebruiker = cmdnaamGebruiker.ExecuteReader();

                while (drnaamGebruiker.Read())
                {
                    InfoGebruiker.voornaam = drnaamGebruiker.GetValue(0).ToString();
                    InfoGebruiker.familienaam = drnaamGebruiker.GetValue(1).ToString();
                }
                string gebruiker = txtGebruikersnaam.Text;
                InfoGebruiker.gebruikersnaam = gebruiker.Substring(0, 1).ToUpper() + gebruiker.Substring(1);
                //----------------------------------------

                //als de de datareader kan lezen met andere woorden de login bestaat/is juist dan log je in
                if (dr.Read() == true)
                {
                    Menu volgendForm = new Menu(); //volgend form declareren
                    volgendForm.Show(); //tonen van volgend form
                    this.Hide(); //Aanmeldscherm form verbergen
                }
                else
                {
                    MessageBox.Show("Ongeldige gebruikersnaam of wachtwoord, probeer opnieuw aub", "Login mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGebruikersnaam.Text = "";
                    txtWachtwoord.Text = "";
                    txtGebruikersnaam.Focus();
                }
                //--------------------------------------------------------------------------------------------
                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: er moet iets foutgelopen zijn", "Aanmelden Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
