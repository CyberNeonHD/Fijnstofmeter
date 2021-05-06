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
        }
        //De geselecteerde gegevens worden opgeslagen in een datatable
        DataTable dt = new DataTable();
        Int32 RijNummer = 0;


        private void FormData_Load(object sender, EventArgs e)
        {
            VerbindingGegevens();
            GegevensTonen();
        }

        public void VerbindingGegevens()
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlAlleGegevens, MijnVerbinding);
                adapter.SelectCommand.Parameters.AddWithValue("@meterid", Convert.ToString("esp8266-3130811"));

                //combobox vullen met de tabalnamen van de database
                DataSet ds = new DataSet();
                adapter.Fill(ds, "MijnTabel");
                foreach (DataColumn column in ds.Tables[0].Columns)
                {
                    cmbWelkVeld.Items.Add(column.ColumnName);
                }
                //---------------------------------------------------
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
        {
           txtGegevensID.Text = dt.Rows[RijNummer].ItemArray[0].ToString();
           txtMeterNaam.Text = dt.Rows[RijNummer].ItemArray[1].ToString().TrimEnd();
           txtPM2_5.Text = dt.Rows[RijNummer].ItemArray[2].ToString().TrimEnd();
           txtPM10.Text = dt.Rows[RijNummer].ItemArray[3].ToString().TrimEnd();
           txtTemp.Text = dt.Rows[RijNummer].ItemArray[4].ToString().TrimEnd() + " °C";
           txtVochtigheid.Text = dt.Rows[RijNummer].ItemArray[5].ToString().TrimEnd();
           txtLuchtdruk.Text = dt.Rows[RijNummer].ItemArray[6].ToString().TrimEnd();
           txtTijdstip.Text = dt.Rows[RijNummer].ItemArray[7].ToString().TrimEnd();
           txtDatum.Text = dt.Rows[RijNummer].ItemArray[8].ToString().TrimEnd();

        }
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

        private void txtZoekstring_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                String zoekVeld = cmbWelkVeld.SelectedItem.ToString();
                adapter = new OleDbDataAdapter(String.Format("SELECT * FROM tblgegevens WHERE ({0} Like @zoekString + '%')", zoekVeld), MijnVerbinding);
                adapter.SelectCommand.Parameters.AddWithValue("@zoekString", txtZoekstring.Text);

                dt.Clear();
                adapter.Fill(dt);
                MijnVerbinding.Close();
                GegevensTonen();
            }
            catch
            {
                MessageBox.Show("ERROR: er moet iets foutgelopen zijn, heb je op enter gedrukt??", "Zoeken Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        /*
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

            SqlConnection MijnVerbinding = new
            SqlConnection(Properties.Settings.Default.DBTest);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQLScripts.sqlVerwijderKlant;
            cmd.Connection = MijnVerbinding;

            cmd.Parameters.AddWithValue("@Klantnummer", Convert.ToInt32(txtKlantNummer.Text));

            MijnVerbinding.Open();

            cmd.ExecuteNonQuery();

            MijnVerbinding.Close();

            VerbindingGegevens();
            GegevensTonen();

        }
        
        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
            MijnVerbinding.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlAlleGegevens, MijnVerbinding);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQLScripts.sqlAanpassenKlant;
            cmd.Connection = MijnVerbinding;

            cmd.Parameters.AddWithValue("@Klantnummer", Convert.ToInt32(txtKlantNummer.Text));
            cmd.Parameters.AddWithValue("@Naam", Convert.ToString(txtNaam.Text));
            cmd.Parameters.AddWithValue("@Straat", Convert.ToString(txtStraat.Text));
            cmd.Parameters.AddWithValue("@Postnr", Convert.ToString(txtPostCode.Text));
            cmd.Parameters.AddWithValue("@Gemeente", Convert.ToString(txtGemeente.Text));

            MijnVerbinding.Open();
            cmd.ExecuteNonQuery();
            MijnVerbinding.Close();

            VerbindingGegevens();
            GegevensTonen();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            btnBewaren.Visible = true;
            btnAnnuleren.Visible = true;
            btnToevoegen.Visible = false;
            btnAanpassen.Visible = false;
            btnVerwijderen.Visible = false;

            txtNaam.Text = "";
            txtStraat.Text = "";
            txtPostCode.Text = "";
            txtGemeente.Text = "";

            txtKlantNummer.Visible = false;

        }
       
        
        private void btnBewaren_Click(object sender, EventArgs e)
        {
            SqlConnection MijnVerbinding = new SqlConnection(Properties.Settings.Default.DBTest);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = SQLScripts.sqlToevoegenKlant;
            cmd.Connection = MijnVerbinding;

            cmd.Parameters.AddWithValue("@Naam", Convert.ToString(txtNaam.Text));
            cmd.Parameters.AddWithValue("@Straat", Convert.ToString(txtStraat.Text));
            cmd.Parameters.AddWithValue("@Postnr", Convert.ToString(txtPostCode.Text));
            cmd.Parameters.AddWithValue("@Gemeente", Convert.ToString(txtGemeente.Text));

            MijnVerbinding.Open();
            cmd.ExecuteNonQuery();
            MijnVerbinding.Close();

            txtKlantNummer.Visible = true;
            btnBewaren.Visible = false;
            btnAnnuleren.Visible = false;
            btnToevoegen.Visible = true;
            btnAanpassen.Visible = true;
            btnVerwijderen.Visible = true;

            VerbindingGegevens();
            GegevensTonen();
        }
        */
    }
}
