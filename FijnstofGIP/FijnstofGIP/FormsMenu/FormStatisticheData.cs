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
    public partial class FormStatisticheData : Form
    {
        string datumP1 = "";
        string datumP2 = "";
        public FormStatisticheData()
        {
            InitializeComponent();
        }

        private void FormStatisticheData_Load(object sender, EventArgs e)
        {
            comboBoxVullen();
            //bij inladen ook een datum
            datumP1 = Convert.ToString(dtpDatumP1.Value.Date.ToShortDateString());
            datumP2 = Convert.ToString(dtpDatumP2.Value.Date.ToShortDateString());
        }

        public void comboBoxVullen()
        {
            OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
            MijnVerbinding.Open();
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
            MijnVerbinding.Close();
            //---------------------------------------------------
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            datumP1 = Convert.ToString(dtpDatumP1.Value.Date.ToShortDateString());
        }
        private void dtpDatumP2_ValueChanged(object sender, EventArgs e)
        {
            datumP2 = Convert.ToString(dtpDatumP2.Value.Date.ToShortDateString());
        }
        private void cmbWelkeMeter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
            MijnVerbinding.Open();
            //AVG -----------------------------------------------------------------------------------
            OleDbCommand cmdAVG = new OleDbCommand();
            OleDbCommand cmdAVG2 = new OleDbCommand();
            OleDbCommand cmdAVG3 = new OleDbCommand();
            OleDbCommand cmdAVG4 = new OleDbCommand();
            OleDbCommand cmdAVG5 = new OleDbCommand();
            

            cmdAVG = new OleDbCommand(SQLScripts.sqlStatistischeGegevensAVG, MijnVerbinding);
            cmdAVG2 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensAVG2, MijnVerbinding);
            cmdAVG3 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensAVG3, MijnVerbinding);
            cmdAVG4 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensAVG4, MijnVerbinding);
            cmdAVG5 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensAVG5, MijnVerbinding);

            String fijnstofMeter = cmbWelkeMeter.SelectedItem.ToString();
            cmdAVG.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdAVG.Parameters.AddWithValue("@datumP1", datumP1);
            cmdAVG.Parameters.AddWithValue("@datumP2", datumP2);
            cmdAVG2.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdAVG2.Parameters.AddWithValue("@datumP1", datumP1);
            cmdAVG2.Parameters.AddWithValue("@datumP2", datumP2);
            cmdAVG3.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdAVG3.Parameters.AddWithValue("@datumP1", datumP1);
            cmdAVG3.Parameters.AddWithValue("@datumP2", datumP2);
            cmdAVG4.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdAVG4.Parameters.AddWithValue("@datumP1", datumP1);
            cmdAVG4.Parameters.AddWithValue("@datumP2", datumP2);
            cmdAVG5.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdAVG5.Parameters.AddWithValue("@datumP1", datumP1);
            cmdAVG5.Parameters.AddWithValue("@datumP2", datumP2);



            txtPM2_5AVG.Text = Convert.ToString(cmdAVG.ExecuteScalar());
            txtPM10AVG.Text = Convert.ToString(cmdAVG2.ExecuteScalar());
            txtTempAVG.Text = Convert.ToString(cmdAVG3.ExecuteScalar());
            txtVochtigheidAVG.Text = Convert.ToString(cmdAVG4.ExecuteScalar());
            txtLuchtdrukAVG.Text = Convert.ToString(cmdAVG5.ExecuteScalar());

           
            //--------------------------------------------------------------------------------------
            //MIN ----------------------------------------------------------------------------------

            OleDbCommand cmdMIN = new OleDbCommand();
            OleDbCommand cmdMIN2 = new OleDbCommand();
            OleDbCommand cmdMIN3 = new OleDbCommand();
            OleDbCommand cmdMIN4 = new OleDbCommand();
            OleDbCommand cmdMIN5 = new OleDbCommand();


            cmdMIN = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMIN, MijnVerbinding);
            cmdMIN2 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMIN2, MijnVerbinding);
            cmdMIN3 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMIN3, MijnVerbinding);
            cmdMIN4 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMIN4, MijnVerbinding);
            cmdMIN5 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMIN5, MijnVerbinding);

            cmdMIN.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMIN.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMIN.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMIN2.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMIN2.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMIN2.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMIN3.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMIN3.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMIN3.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMIN4.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMIN4.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMIN4.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMIN5.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMIN5.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMIN5.Parameters.AddWithValue("@datumP2", datumP2);

            txtPM2_5MIN.Text = Convert.ToString(cmdMIN.ExecuteScalar());
            txtPM10MIN.Text = Convert.ToString(cmdMIN2.ExecuteScalar());
            txtTempMIN.Text = Convert.ToString(cmdMIN3.ExecuteScalar());
            txtVochtigheidMIN.Text = Convert.ToString(cmdMIN4.ExecuteScalar());
            txtLuchtdrukMIN.Text = Convert.ToString(cmdMIN5.ExecuteScalar());

           
            //--------------------------------------------------------------------------------------
            //MAX ----------------------------------------------------------------------------------
            OleDbCommand cmdMAX = new OleDbCommand();
            OleDbCommand cmdMAX2 = new OleDbCommand();
            OleDbCommand cmdMAX3 = new OleDbCommand();
            OleDbCommand cmdMAX4 = new OleDbCommand();
            OleDbCommand cmdMAX5 = new OleDbCommand();


            cmdMAX = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMAX, MijnVerbinding);
            cmdMAX2 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMAX2, MijnVerbinding);
            cmdMAX3 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMAX3, MijnVerbinding);
            cmdMAX4= new OleDbCommand(SQLScripts.sqlStatistischeGegevensMAX4, MijnVerbinding);
            cmdMAX5 = new OleDbCommand(SQLScripts.sqlStatistischeGegevensMAX5, MijnVerbinding);

            cmdMAX.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMAX.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMAX.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMAX2.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMAX2.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMAX2.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMAX3.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMAX3.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMAX3.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMAX4.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMAX4.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMAX4.Parameters.AddWithValue("@datumP2", datumP2);
            cmdMAX5.Parameters.AddWithValue("@meterid", fijnstofMeter);
            cmdMAX5.Parameters.AddWithValue("@datumP1", datumP1);
            cmdMAX5.Parameters.AddWithValue("@datumP2", datumP2);
            

            txtPM2_5MAX.Text = cmdMAX.ExecuteScalar().ToString();
            txtPM10MAX.Text = cmdMAX2.ExecuteScalar().ToString();
            txtTempMAX.Text = cmdMAX3.ExecuteScalar().ToString();
            txtVochtigheidMAX.Text = cmdMAX4.ExecuteScalar().ToString();
            txtLuchtdrukMAX.Text = cmdMAX5.ExecuteScalar().ToString();

           
            MijnVerbinding.Close();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
