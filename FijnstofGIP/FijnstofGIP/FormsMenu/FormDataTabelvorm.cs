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
    public partial class FormDataTabelvorm : Form
    {
        public FormDataTabelvorm()
        {
            InitializeComponent();
            comboBoxVullen();
        }
        DataSet dsGegevens = new DataSet();
        //standaard laden we deze meter in
        string fijnstofMeter = "esp8266-3130811";
        string zoekVeld = "";

        #region code lay-out -> tab support en kleur paneel veranderen 
        private void txtZoekstring_Click(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.DeepSkyBlue;
        }

        private void txtZoekstring_Enter(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.DeepSkyBlue;
        }
        private void txtZoekstring_Leave(object sender, EventArgs e)
        {
            pnlZoekstring.BackColor = Color.White;
        }
        #endregion

        #region Data inladen en comboboxen opvullen
        private void FormDataTabelvorm_Load(object sender, EventArgs e)
        {
            
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlAlleGegevens, MijnVerbinding);
                //standaard inladen van de hoofdmeter esp8266-3130811
                adapter.SelectCommand.Parameters.AddWithValue("@meterID", fijnstofMeter);
                
                dsGegevens.Clear();
                adapter.Fill(dsGegevens, "MijnTabel");
                GegevensTonen();
                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Problemen bij verbinding van de gegevens", "Verbinding database mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void comboBoxVullen()
        {
            try
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
                //---------------------------------------------------
                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("Er zijn geen fijnstofmeters meer??", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region comboboxen die de strings updaten op basis van een verandering in de combobox + selecteren van meter de basis gegevens van die meter tonen 
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
        private void cmbWelkeMeter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter();


                fijnstofMeter = cmbWelkeMeter.SelectedItem.ToString();

                adapter = new OleDbDataAdapter(SQLScripts.sqlAlleGegevens, MijnVerbinding);
                adapter.SelectCommand.Parameters.AddWithValue("@meterid", fijnstofMeter);

                dsGegevens.Clear();
                adapter.Fill(dsGegevens, "MijnTabel");
                MijnVerbinding.Close();
                GegevensTonen();
            }
            catch
            {
                MessageBox.Show("ERROR: De fijnstof meter die u net heeft aangeduid heeft geen gegevens", "Zoeken Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                adapter = new OleDbDataAdapter(String.Format("SELECT * FROM tblgegevens WHERE (meterID = @meterid) AND ({0} Like @zoekString + '%')", zoekVeld), MijnVerbinding);
                adapter.SelectCommand.Parameters.AddWithValue("@meterid", fijnstofMeter);
                adapter.SelectCommand.Parameters.AddWithValue("@zoekString", txtZoekstring.Text);



                //deze if's zijn onze eigen error ontwijkers
                //persoon zoekt zonder veld in te vullen dan kreeg je een speciale catch error maar via deze manier lossen we het op
                if (zoekVeld == "")
                {
                    MessageBox.Show("Vul eerst het veld in, waarin u wilt zoeken!", "Zoeken Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //we noemen dit zo voor de else if te triggeren
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
                    dsGegevens.Clear();
                    adapter.Fill(dsGegevens, "MijnTabel");
                }             
                MijnVerbinding.Close();
            }     
            catch //moest er buiten de comboxen nog errors komen vangt dit het op 
            {
                MessageBox.Show("De data die u zoekt bestaat niet!", "Zoeken Mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
       
        #endregion

        public void GegevensTonen()
        {
            try
            {
                // Opvullen van de datasource
                dgvGegevens.DataSource = dsGegevens.Tables["MijnTabel"];
            }
            catch
            {
               MessageBox.Show("Fout bij het inladen van de datatabel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
