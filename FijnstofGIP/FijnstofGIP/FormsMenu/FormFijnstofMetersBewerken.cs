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
    public partial class FormFijnstofMetersBewerken : Form
    {
        public FormFijnstofMetersBewerken()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Int32 RijNummer = 0;
        private void FormFijnstofMetersBewerken_Load(object sender, EventArgs e)
        {
            VerbindingGegevens();
            GegevensTonen();
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

        #region code voor de knopjes :D
        private void btnEerste_Click(object sender, EventArgs e)
        {
            RijNummer = 0;
            GegevensTonen();
        }

        private void btnVorige_Click(object sender, EventArgs e)
        {
            if ((RijNummer <= dt.Rows.Count) && (RijNummer > 0))
            {

                RijNummer -= 1;
                GegevensTonen();
            }
            else
            {
                RijNummer = dt.Rows.Count - 1;
                GegevensTonen();
            }
        }

        private void btnVolgend_Click(object sender, EventArgs e)
        {

            if (RijNummer < dt.Rows.Count - 1)
            {
                RijNummer += 1;
            }
            else
            {
                RijNummer = 0;
            }
            GegevensTonen();
        }

        private void btnLaatste_Click(object sender, EventArgs e)
        {
            RijNummer = dt.Rows.Count - 1;
            GegevensTonen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMeterID.Text = "";
            txtMeterNaam.Text = "";
            txtLatitude.Text = "";
            txtLongtitude.Text = "";
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            { 
                if (txtMeterID.Text == "" && txtMeterNaam.Text == "" && txtLatitude.Text == "" && txtLongtitude.Text == "")
                {
                    MessageBox.Show("Niet alle records zijn ingevuld!?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult gegevensVerwijderen = MessageBox.Show("Ben je zeker dat je deze records wilt verwijderen?", "Records verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    if (gegevensVerwijderen == DialogResult.Yes)
                    {

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = SQLScripts.sqlMeterRecordVerwijderen;
                        cmd.Connection = MijnVerbinding;

                        cmd.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));

                        MijnVerbinding.Open();
                        cmd.ExecuteNonQuery();
                        MijnVerbinding.Close();

                        //clearen van de txt's
                        txtMeterID.Text = "";
                        txtMeterNaam.Text = "";
                        txtLatitude.Text = "";
                        txtLongtitude.Text = "";
                        MessageBox.Show("Je hebt de data succesvol verwijderd!", "SUCCES: record verwijderd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (gegevensVerwijderen == DialogResult.No)
                    {
                        //er gebeurd dan niks
                    }
                    else //FOUT PROTECTIE: moest er iets random foutlopen en de waarde is niet ja of nee 0.0
                    {
                        MessageBox.Show("Er is iets foutgelopen terwijl je op de knop drukte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("ERROR, er is een fout gebeurd bij het verwijderen", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
           try
           { 
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

                        cmd.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));
                        cmd.Parameters.AddWithValue("@meterNaam", Convert.ToString(txtMeterNaam.Text));
                        cmd.Parameters.AddWithValue("@latitude", Convert.ToString(txtLatitude.Text));
                        cmd.Parameters.AddWithValue("@longtitude", Convert.ToString(txtLongtitude.Text));


                        MijnVerbinding.Open();
                        cmd.ExecuteNonQuery();
                        MijnVerbinding.Close();

                        //Code voor de email bij aanmaken van fijnstof meter sturen

                        MailMessage RegistratieBericht = new MailMessage();
                        string van, ww, bericht, onderwerp;

                        van = InfoGebruiker.KalexEmail;
                        ww = InfoGebruiker.KalexWW;
                        bericht = "Beste " + InfoGebruiker.voornaam + " " + InfoGebruiker.familienaam + "," + "<br />" + "<br /> U heeft succesvol een fijnstof meter toegevoegd aan de database.<br /> De info van deze fijnstof meter is: <br />MeterID: " + txtMeterID.Text + "<br />Naam van de meter: " + txtMeterNaam.Text + "<br />Latitude: " + txtLatitude.Text + "<br />Longitude: " + txtLongtitude.Text + "<br /> Als u ooit problemen heeft of suggesties kan u ons altijd een mail sturen. <br /> <br /> Met vriendelijke groeten, <br />Kalex";
                        onderwerp = "Fijnstof meter succesvol aangemaakt!";
                        RegistratieBericht.To.Add(InfoGebruiker.email);
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
            catch
            {
                MessageBox.Show("ERROR, er is een fout gebeurd", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnRecordBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMeterID.Text == "" && txtMeterNaam.Text == "" && txtLatitude.Text == "" && txtLongtitude.Text == "")
                {
                    MessageBox.Show("Je moet alle velden invullen", "Fijnstofmeter toevoegen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult gegevensBewaren = MessageBox.Show("Ben je zeker dat je deze records wilt bewaren?", "Records bewaren", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (gegevensBewaren == DialogResult.Yes)
                    {
                        OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");

                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = SQLScripts.sqlAanpassenMeterRecord;
                        cmd.Connection = MijnVerbinding;

                        cmd.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));
                        cmd.Parameters.AddWithValue("@meterNaam", Convert.ToString(txtMeterNaam.Text));
                        cmd.Parameters.AddWithValue("@latitude", Convert.ToString(txtLatitude.Text));
                        cmd.Parameters.AddWithValue("@longtitude", Convert.ToString(txtLongtitude.Text));

                        MijnVerbinding.Open();
                        cmd.ExecuteNonQuery();
                        MijnVerbinding.Close();
                        MessageBox.Show("Gegevens zijn succesvol bewaard", "Gegevens bewaard!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    VerbindingGegevens();
                    GegevensTonen();
                }
            }
            catch
            {
                MessageBox.Show("ERROR, er is een fout gebeurd bij het bewaren van de records+", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Public void's van VerbindingGegevens en GegevensTonen
        public void VerbindingGegevens()
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlAlleMeters, MijnVerbinding);

                dt.Clear();
                adapter.Fill(dt);
                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Problemen bij verbinding van de gegevens", "Verbinding database mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void GegevensTonen()
        {   //gegevensID is verstopt voor de gebruiker maar nodig voor een record te kunnen verwijderen
            try
            {
                txtMeterID.Text = dt.Rows[RijNummer].ItemArray[0].ToString();
                txtMeterNaam.Text = dt.Rows[RijNummer].ItemArray[1].ToString().TrimEnd();
                txtLatitude.Text = dt.Rows[RijNummer].ItemArray[2].ToString().TrimEnd();
                txtLongtitude.Text = dt.Rows[RijNummer].ItemArray[3].ToString().TrimEnd();
            }
            catch
            {
                //we willen geen error tonen want anders wordt de gebruiker gespammed met errors
            }
        }
        #endregion

    }
}
