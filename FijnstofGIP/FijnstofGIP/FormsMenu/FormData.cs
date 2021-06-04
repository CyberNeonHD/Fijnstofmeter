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

namespace FijnstofGIP.FormsMenu
{
    public partial class FormData : Form
    {
        public FormData()
        {
            InitializeComponent();
            comboBoxVullen();
        }
        //De geselecteerde gegevens worden opgeslagen in een datatable
        DataTable dt = new DataTable();
        Int32 RijNummer = 0;
        string fijnstofMeter = "";
        string zoekVeld = "";
        string zoekString = "";
        private void FormData_Load(object sender, EventArgs e)
        {
            VerbindingGegevens();
            GegevensTonen();
        }

        #region kleuren van de panelen veranderen wanneer je op een bepaalde textblock klikt - dit is zodat de gebruiker weet waar hij gaat typen
        private void txtZoekstring_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.DeepSkyBlue;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtMeterID_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.DeepSkyBlue;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtTijdstip_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.DeepSkyBlue;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtDatum_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.DeepSkyBlue;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtTemp_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.DeepSkyBlue;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtPM10_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.DeepSkyBlue;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtPM2_5_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.DeepSkyBlue;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtVochtigheid_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.DeepSkyBlue;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtLuchtdruk_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.DeepSkyBlue;
        }
        #endregion

        #region Kleuren van de panelen veranderen via tab - full tab support
        private void txtZoekstring_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.DeepSkyBlue;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtMeterID_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.DeepSkyBlue;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtTijdstip_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.DeepSkyBlue;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtDatum_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.DeepSkyBlue;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtTemp_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.DeepSkyBlue;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtPM10_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.DeepSkyBlue;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtPM2_5_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.DeepSkyBlue;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtVochtigheid_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.DeepSkyBlue;
            pnlLuchtdruk.BackColor = Color.White;
        }

        private void txtLuchtdruk_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
            pnlMeterID.BackColor = Color.White;
            pnlTijdstip.BackColor = Color.White;
            pnlDatum.BackColor = Color.White;
            pnlTemp.BackColor = Color.White;
            pnlPM10.BackColor = Color.White;
            pnl2_5.BackColor = Color.White;
            pnlVochtigheid.BackColor = Color.White;
            pnlLuchtdruk.BackColor = Color.DeepSkyBlue;
        }


        #endregion

        #region Public void's van VerbindingGegevens en GegevensTonen
        public void VerbindingGegevens()
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlAlleGegevens, MijnVerbinding);
                //standaard inladen van de hoofdmeter esp8266-3130811
                adapter.SelectCommand.Parameters.AddWithValue("@meterid", Convert.ToString("esp8266-3130811"));

                dt.Clear();
                adapter.Fill(dt);
                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Problemen bij verbinding van de gegevens", "Verbinding database mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void comboBoxVullen()
        {
            OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
            MijnVerbinding.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlDataAlleGegevens, MijnVerbinding);

            //combobox -> CmbWelkVeld vullen met de tabelnamen van de database
            DataSet ds = new DataSet();
            adapter.Fill(ds, "MijnTabelnamen");
            foreach (DataColumn column in ds.Tables[0].Columns)
            {
                cmbWelkVeld.Items.Add(column.ColumnName);
            }


            //---------------------------------------------------

            //combobox -> cmbWelkeMeter vullen met de fijnstofmeters die er zijn
            OleDbCommand cmd = new OleDbCommand();
            cmd = new OleDbCommand(SQLScripts.sqlMeterID, MijnVerbinding);
            OleDbDataReader Sdr = cmd.ExecuteReader();
            while (Sdr.Read())
            {
                for (int i = 0; i < Sdr.FieldCount; i++)
                {
                    cmbWelkeMeter.Items.Add(Sdr.GetString(i));
                }
            }
            //standaard waarde geven aan cmbWelkeMeter
            cmbWelkeMeter.SelectedItem = "esp8266-3130811";
            fijnstofMeter = "esp8266-3130811";
            //---------------------------------------------------
            MijnVerbinding.Close();
        }

        public void GegevensTonen()
        {   //gegevensID is verstopt voor de gebruiker maar nodig voor een record te kunnen verwijderen
            try
            {
                txtGegevensID.Text = dt.Rows[RijNummer].ItemArray[0].ToString();
                txtMeterID.Text = dt.Rows[RijNummer].ItemArray[1].ToString().TrimEnd();
                txtPM2_5.Text = dt.Rows[RijNummer].ItemArray[2].ToString().TrimEnd();
                txtPM10.Text = dt.Rows[RijNummer].ItemArray[3].ToString().TrimEnd();
                txtTemp.Text = dt.Rows[RijNummer].ItemArray[4].ToString().TrimEnd();
                txtVochtigheid.Text = dt.Rows[RijNummer].ItemArray[5].ToString().TrimEnd();
                txtLuchtdruk.Text = dt.Rows[RijNummer].ItemArray[6].ToString().TrimEnd();
                txtTijdstip.Text = dt.Rows[RijNummer].ItemArray[7].ToString().TrimEnd();
                txtDatum.Text = dt.Rows[RijNummer].ItemArray[8].ToString().TrimEnd();
            }
            catch 
            {
                //we willen geen error tonen want anders wordt de gebruiker gespammed met errors
            }
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
            txtGegevensID.Text = "";
            txtPM2_5.Text = "";
            txtPM10.Text = "";
            txtTemp.Text = "";
            txtVochtigheid.Text = "";
            txtLuchtdruk.Text = "";
            txtTijdstip.Text = "";
            txtDatum.Text = "";
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPM2_5.Text == "" && txtPM10.Text == "" && txtTemp.Text == "" && txtVochtigheid.Text == "" && txtLuchtdruk.Text == "" && txtTijdstip.Text == "" && txtDatum.Text == "")
                {
                    MessageBox.Show("Niet alle records zijn ingevuld!?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult gegevensVerwijderen = MessageBox.Show("Ben je zeker dat je deze records wilt verwijderen?", "Records verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                    if (gegevensVerwijderen == DialogResult.Yes)
                    {

                        OleDbCommand cmdVindID = new OleDbCommand();
                        cmdVindID.CommandType = CommandType.Text;
                        cmdVindID.CommandText = SQLScripts.sqlDataRecordVindID;
                        cmdVindID.Connection = MijnVerbinding;

                        cmdVindID.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));
                        cmdVindID.Parameters.AddWithValue("@PM2_5", Convert.ToInt32(txtPM2_5.Text));
                        cmdVindID.Parameters.AddWithValue("@PM10", Convert.ToInt32(txtPM10.Text));
                        cmdVindID.Parameters.AddWithValue("@temperatuur", Convert.ToInt32(txtTemp.Text));
                        cmdVindID.Parameters.AddWithValue("@vochtigheid", Convert.ToInt32(txtVochtigheid.Text));
                        cmdVindID.Parameters.AddWithValue("@luchtdruk", Convert.ToInt32(txtLuchtdruk.Text));
                        cmdVindID.Parameters.AddWithValue("@tijdstip", Convert.ToString(txtTijdstip.Text));
                        cmdVindID.Parameters.AddWithValue("@datum", Convert.ToString(txtDatum.Text));
                        cmdVindID.Parameters.AddWithValue("@gegevensid", Convert.ToString(txtGegevensID.Text));

                        MijnVerbinding.Open();
                        cmdVindID.ExecuteNonQuery();

                        OleDbDataReader drVindID = cmdVindID.ExecuteReader();
                        string gegevensID = "";
                        while (drVindID.Read())
                        {
                            gegevensID = drVindID.GetValue(0).ToString();
                        }

                        OleDbCommand cmdVerwijderen = new OleDbCommand();
                        cmdVerwijderen.CommandType = CommandType.Text;
                        cmdVerwijderen.CommandText = SQLScripts.sqlDataRecordVerwijderen;
                        cmdVerwijderen.Connection = MijnVerbinding;

                        cmdVerwijderen.Parameters.AddWithValue("@gegevensid", gegevensID);

                        
                        cmdVerwijderen.ExecuteNonQuery();
                        MijnVerbinding.Close();

                        //clearen van de txt's
                        txtGegevensID.Text = "";
                        txtPM2_5.Text = "";
                        txtPM10.Text = "";
                        txtTemp.Text = "";
                        txtVochtigheid.Text = "";
                        txtLuchtdruk.Text = "";
                        txtTijdstip.Text = "";
                        txtDatum.Text = "";
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
                if (txtMeterID.Text == "" && txtPM2_5.Text == "" && txtPM10.Text == "" && txtTemp.Text == "" && txtVochtigheid.Text == "" && txtLuchtdruk.Text == "" && txtTijdstip.Text == "" && txtDatum.Text == "")
                {
                    MessageBox.Show("Je moet alle velden invullen", "Data toevoegen mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DialogResult Toevoegen = MessageBox.Show("Ben je zeker dat je deze gegevens wilt toevoegen?", "Data toevoegen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Toevoegen == DialogResult.Yes)
                    {
                        OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = SQLScripts.sqlDataAanmaken;
                        cmd.Connection = MijnVerbinding;
                        //OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlDataAanmaken, MijnVerbinding);

                        cmd.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));
                        cmd.Parameters.AddWithValue("@PM2_5", Convert.ToInt32(txtPM2_5.Text));
                        cmd.Parameters.AddWithValue("@PM10", Convert.ToInt32(txtPM10.Text));
                        cmd.Parameters.AddWithValue("@temperatuur", Convert.ToInt32(txtTemp.Text));
                        cmd.Parameters.AddWithValue("@vochtigheid", Convert.ToInt32(txtVochtigheid.Text));
                        cmd.Parameters.AddWithValue("@luchtdruk", Convert.ToInt32(txtLuchtdruk.Text));
                        cmd.Parameters.AddWithValue("@tijdstip", Convert.ToString(txtTijdstip.Text));
                        cmd.Parameters.AddWithValue("@datum", Convert.ToString(txtDatum.Text));

                        MijnVerbinding.Open();
                        cmd.ExecuteNonQuery();
                        MijnVerbinding.Close();

                        txtMeterID.Text = "";
                        txtPM2_5.Text = "";
                        txtPM10.Text = "";
                        txtTemp.Text = "";
                        txtVochtigheid.Text = "";
                        txtLuchtdruk.Text = "";
                        txtTijdstip.Text = "";
                        txtDatum.Text = "";
                        MessageBox.Show("Je hebt de data succesvol toegevoegd!", "SUCCES: data toegevoegd", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                DialogResult gegevensBewaren = MessageBox.Show("Ben je zeker dat je deze records wilt bewaren?", "Records bewaren", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gegevensBewaren == DialogResult.Yes)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SQLScripts.sqlAanpassenDataRecord;
                    cmd.Connection = MijnVerbinding;

                    cmd.Parameters.AddWithValue("@meterid", Convert.ToString(txtMeterID.Text));
                    cmd.Parameters.AddWithValue("@PM2_5", Convert.ToInt32(txtPM2_5.Text));
                    cmd.Parameters.AddWithValue("@PM10", Convert.ToInt32(txtPM10.Text));
                    cmd.Parameters.AddWithValue("@temperatuur", Convert.ToInt32(txtTemp.Text));
                    cmd.Parameters.AddWithValue("@vochtigheid", Convert.ToInt32(txtVochtigheid.Text));
                    cmd.Parameters.AddWithValue("@luchtdruk", Convert.ToInt32(txtLuchtdruk.Text));
                    cmd.Parameters.AddWithValue("@tijdstip", Convert.ToString(txtTijdstip.Text));
                    cmd.Parameters.AddWithValue("@datum", Convert.ToString(txtDatum.Text));
                    cmd.Parameters.AddWithValue("@gegevensid", Convert.ToString(txtGegevensID.Text));

                    MijnVerbinding.Open();
                    cmd.ExecuteNonQuery();
                    MijnVerbinding.Close();
                    MessageBox.Show("Gegevens zijn succesvol bewaard", "Gegevens bewaard!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //er gebeurd dan niks
                }

                VerbindingGegevens();
                GegevensTonen();
            }
            catch
            {
                MessageBox.Show("ERROR, er is een fout gebeurd bij het bewaren van de records+", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region code van de zoekfuncties die werken op het zoeken van strings EN meterID
        private void txtZoekstring_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                zoekString = Convert.ToString(txtZoekstring.Text);
                adapter = new OleDbDataAdapter(String.Format("SELECT * FROM tblgegevens WHERE (meterID = @meterid) AND ({0} Like @zoekString + '%')", zoekVeld), MijnVerbinding);/*meterID,PM2_5,PM10,temperatuur,vochtigheid,luchtdruk,tijdstip,datum FROM tblgegevens*/
                adapter.SelectCommand.Parameters.AddWithValue("@meterid", fijnstofMeter);
                adapter.SelectCommand.Parameters.AddWithValue("@zoekString", zoekString);

                

                //deze if's zijn onze eigen error ontwijkers
                //persoon zoekt zonder veld in te vullen dan kreeg je een speciale catch error maar via deze manier lossen we het op
                if (zoekVeld == "")
                {
                    MessageBox.Show("Vul eerst het veld in, waarin u wilt zoeken!", "Zoeken Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    zoekVeld = "geenTweedeError";
                    txtZoekstring.Clear();
                }
                else if (zoekVeld == "geenTweedeError")
                {
                    //dit is zo omdat we anders een dubbele error message krijgen wanneer we de txtZoekstring.Text legen
                    zoekVeld = ""; //na tweede error mag het leeg -> stel je voor koppige gebruiker doet het opnieuw
                }
                else
                {
                    dt.Clear();
                    adapter.Fill(dt);
                    GegevensTonen();
                }

                MijnVerbinding.Close();
            }     //via dit ontwijken we een error die komt wanneer de comboboxen leeg zijn maar de persoon wel wilt zoeken
            catch 
            {
                //we willen geen error tonen want anders wordt de gebruiker gespammed met errors -> dit komt niet voor bij datagridview ondanks zelfde code 0.0
            }
            
           
        }
        private void cmbWelkeMeter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();


                fijnstofMeter = cmbWelkeMeter.SelectedItem.ToString();
                //alle tekstvakken leegmaken en meter opvullen met de meter dit is puur en alleen voor meters die nog geen data hebben en een error geven --> nu dat alles leeg is behalve de meterid kan de gebruiker makkelijk data toevoegen :D
                txtMeterID.Text = fijnstofMeter;
                txtGegevensID.Text = "";
                txtPM2_5.Text = "";
                txtPM10.Text = "";
                txtTemp.Text = "";
                txtVochtigheid.Text = "";
                txtLuchtdruk.Text = "";
                txtTijdstip.Text = "";
                txtDatum.Text = "";
                adapter = new OleDbDataAdapter(SQLScripts.sqlAlleGegevens, MijnVerbinding);
                adapter.SelectCommand.Parameters.AddWithValue("@meterid", fijnstofMeter);

                dt.Clear();
                adapter.Fill(dt);
                MijnVerbinding.Close();
                GegevensTonen();
            }
            catch
            {
                MessageBox.Show("ERROR: De fijnstof meter die u net heeft aangeduid heeft geen gegevens", "Zoeken Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbWelkVeld_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                zoekVeld = cmbWelkVeld.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("ERROR: Toen U het veld selecteerde is er een ovenverwachte error gebeurd...", "Veld selectie error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }
        #endregion

    }
}
