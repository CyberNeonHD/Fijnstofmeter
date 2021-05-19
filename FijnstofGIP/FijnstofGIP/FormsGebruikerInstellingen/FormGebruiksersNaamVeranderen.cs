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
    public partial class FormGebruiksersNaamVeranderen : Form
    {
        public FormGebruiksersNaamVeranderen()
        {
            InitializeComponent();
        }
        private void FormGebruiksersNaamVeranderen_Load(object sender, EventArgs e)
        {
            txtGebruikersnaam.Text = InfoGebruiker.gebruikersnaam;
        }

        #region lay-out -> tab support en op klik kleur veranderen
        private void txtGebruikersnaam_Click(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.DeepSkyBlue;
        }

        private void txtGebruikersnaam_Enter(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.DeepSkyBlue;
        }

        private void txtGebruikersnaam_Leave(object sender, EventArgs e)
        {
            pnlgebruikersnaam.BackColor = Color.White;
        }
        #endregion

        #region Code Knop gegevensOpslaan
        private void btnGegevensOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult gegevensBewaren = MessageBox.Show("Ben je zeker dat U de juiste gegevens hebt ingevult?", "Gebruikersnaam opslaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gegevensBewaren == DialogResult.Yes)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    MijnVerbinding.Open();

                    OleDbCommand cmdAdresAanpassen = new OleDbCommand();
                    cmdAdresAanpassen.CommandType = CommandType.Text;
                    cmdAdresAanpassen.CommandText = SQLScripts.sqlAanpassenGebruikersnaam;
                    cmdAdresAanpassen.Connection = MijnVerbinding;

                    //updaten van de info over de gebruiker
                    InfoGebruiker.gebruikersnaam = txtGebruikersnaam.Text;

                    cmdAdresAanpassen.Parameters.AddWithValue("@gebruikersID", Convert.ToString(InfoGebruiker.gebruikersID));
                    cmdAdresAanpassen.Parameters.AddWithValue("@gebruikersnaam", Convert.ToString(txtGebruikersnaam.Text));
                    cmdAdresAanpassen.Parameters.AddWithValue("@email", Convert.ToString(InfoGebruiker.email));
                    cmdAdresAanpassen.Parameters.AddWithValue("@voornaam", Convert.ToString(InfoGebruiker.voornaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@familienaam", Convert.ToString(InfoGebruiker.familienaam));
                    cmdAdresAanpassen.Parameters.AddWithValue("@straat", Convert.ToString(InfoGebruiker.straat));
                    cmdAdresAanpassen.Parameters.AddWithValue("@huisnummer", Convert.ToInt32(InfoGebruiker.huisnummer));
                    cmdAdresAanpassen.Parameters.AddWithValue("@postcode", Convert.ToInt32(InfoGebruiker.postcode));
                    cmdAdresAanpassen.Parameters.AddWithValue("@gemeente", Convert.ToString(InfoGebruiker.gemeente));

                    cmdAdresAanpassen.ExecuteNonQuery();
                    MijnVerbinding.Close();
                    MessageBox.Show("Jouw gebruikersnaam is veranderd, gelieve uit te loggen zodat U met uw nieuwe gegevens kan inloggen.", "Gebruikersnaam bewaard!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
