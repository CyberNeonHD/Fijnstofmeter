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

namespace FijnstofGIP.FormsGebruikerInstellingen
{
    public partial class FormAdresVeranderen : Form
    {
        public FormAdresVeranderen()
        {
            InitializeComponent();
        }
        private void FormAdresVeranderen_Load(object sender, EventArgs e)
        {
            txtStraat.Text = InfoGebruiker.straat;
            txtHuisNummer.Text = InfoGebruiker.huisnummer;
            txtPostcode.Text = InfoGebruiker.postcode;
            txtGemeente.Text = InfoGebruiker.gemeente;
        }
        #region kleuren van de panelen veranderen wanneer je op een bepaalde textblock klikt - dit is zodat de gebruiker weet waar hij gaat typen
        private void txtStraat_Click(object sender, EventArgs e)
        {
            pnlstraat.BackColor = Color.DeepSkyBlue;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
        }
        private void txtPostcode_Click(object sender, EventArgs e)
        {
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.DeepSkyBlue;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.White;
        }
        private void txtHuisNummer_Click(object sender, EventArgs e)
        {
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.DeepSkyBlue;
            pnlgemeente.BackColor = Color.White;
        }
        private void txtGemeente_Click(object sender, EventArgs e)
        {
            pnlstraat.BackColor = Color.White;
            pnlpostcode.BackColor = Color.White;
            pnlhuisnummer.BackColor = Color.White;
            pnlgemeente.BackColor = Color.DeepSkyBlue;
        }
        #endregion

        #region  Kleuren van de panelen veranderen via tab - full tab support
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
        #endregion

        #region Code Knop gegevensOpslaan
        private void btnGegevensOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult gegevensBewaren = MessageBox.Show("Ben je zeker dat U de juiste gegevens hebt ingevult?", "Adres bewaren", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gegevensBewaren == DialogResult.Yes)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    MijnVerbinding.Open();

                    OleDbCommand cmdAdresAanpassen = new OleDbCommand();
                    cmdAdresAanpassen.CommandType = CommandType.Text;
                    cmdAdresAanpassen.CommandText = SQLScripts.sqlAanpassenAdres;
                    cmdAdresAanpassen.Connection = MijnVerbinding;

                    //updaten van de info over de gebruiker
                    InfoGebruiker.straat = txtStraat.Text;
                    InfoGebruiker.huisnummer = txtHuisNummer.Text;
                    InfoGebruiker.postcode = txtPostcode.Text;
                    InfoGebruiker.gemeente = txtGemeente.Text;

                    cmdAdresAanpassen.Parameters.AddWithValue("@gebruikersID", Convert.ToString(InfoGebruiker.gebruikersID));
                    cmdAdresAanpassen.Parameters.AddWithValue("@gebruikersnaam", Convert.ToString(InfoGebruiker.gebruikersnaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@email", Convert.ToString(InfoGebruiker.email));
                    cmdAdresAanpassen.Parameters.AddWithValue("@voornaam", Convert.ToString(InfoGebruiker.voornaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@familienaam", Convert.ToString(InfoGebruiker.familienaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@straat", Convert.ToString(txtStraat.Text));
                    cmdAdresAanpassen.Parameters.AddWithValue("@huisnummer", Convert.ToInt32(txtHuisNummer.Text));
                    cmdAdresAanpassen.Parameters.AddWithValue("@postcode", Convert.ToInt32(txtPostcode.Text));
                    cmdAdresAanpassen.Parameters.AddWithValue("@gemeente", Convert.ToString(txtGemeente.Text));

                    cmdAdresAanpassen.ExecuteNonQuery();
                    MijnVerbinding.Close();
                    MessageBox.Show("Jouw adres is upgedate!", "Gegevens bewaard!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //er gebeurd dan niks
                }
            }
            catch 
            {

                MessageBox.Show("ERROR: Tijdens het opslaan is er een fout gebeurd", "Oplsaan Mislukt!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

        }
        #endregion

    }
}
