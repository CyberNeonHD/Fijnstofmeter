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



            Int32 PM2_5AVG = Convert.ToInt32(cmdAVG.ExecuteScalar());
            Int32 PM10AVG = Convert.ToInt32(cmdAVG2.ExecuteScalar());
            Int32 TempAVG = Convert.ToInt32(cmdAVG3.ExecuteScalar());
            Int32 VochtigheidAVG = Convert.ToInt32(cmdAVG4.ExecuteScalar());

            txtPM2_5AVG.Text = Convert.ToString(PM2_5AVG);
            txtPM10AVG.Text = Convert.ToString(PM10AVG);
            txtTempAVG.Text = Convert.ToString(TempAVG);
            txtVochtigheidAVG.Text = Convert.ToString(VochtigheidAVG);
            txtLuchtdrukAVG.Text = Convert.ToString(cmdAVG5.ExecuteScalar());

            //ervoor zorgen dat bepaalde waarde categoriëen bepaalde kleuren krijgen
            if (PM2_5AVG <=20)
            {
                pnl2_5PMAVG.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if((PM2_5AVG > 20) && (PM2_5AVG <= 25))
            {
                pnl2_5PMAVG.BackColor = Color.Yellow;
            }
            else if ((PM2_5AVG > 25))
            {
                pnl2_5PMAVG.BackColor = Color.Red;
            }

            if (PM10AVG <= 40)
            {
                pnlPM10AVG.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((PM10AVG > 40) && (PM10AVG <= 50))
            {
                pnlPM10AVG.BackColor = Color.Yellow;
            }
            else if ((PM10AVG > 50))
            {
                pnlPM10AVG.BackColor = Color.Red;
            }

            if (TempAVG <= 30)
            {
                pnlTempAVG.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((TempAVG > 30) && (TempAVG <= 55))
            {
                pnlTempAVG.BackColor = Color.Yellow;
            }
            else if ((TempAVG > 55))
            {
                pnlTempAVG.BackColor = Color.Red;
            }


            if (VochtigheidAVG <= 50)
            {
                pnlVochtigheidAVG.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((VochtigheidAVG > 50) && (VochtigheidAVG <= 60))
            {
                pnlVochtigheidAVG.BackColor = Color.Yellow;
            }
            else if ((VochtigheidAVG > 60))
            {
                pnlVochtigheidAVG.BackColor = Color.Red;
            }
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


            Int32 PM2_5MIN = Convert.ToInt32(cmdMIN.ExecuteScalar());
            Int32 PM10MIN = Convert.ToInt32(cmdMIN2.ExecuteScalar());
            Int32 TempMIN = Convert.ToInt32(cmdMIN3.ExecuteScalar());
            Int32 VochtigheidMIN = Convert.ToInt32(cmdMIN4.ExecuteScalar());


            txtPM2_5MIN.Text = Convert.ToString(PM2_5MIN);
            txtPM10MIN.Text = Convert.ToString(PM10MIN);
            txtTempMIN.Text = Convert.ToString(TempMIN);
            txtVochtigheidMIN.Text = Convert.ToString(VochtigheidMIN);
            txtLuchtdrukMIN.Text = Convert.ToString(cmdMIN5.ExecuteScalar());

            //ervoor zorgen dat bepaalde waarde categoriëen bepaalde kleuren krijgen
            if (PM2_5MIN <= 20)
            {
                pnl2_5PMMin.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((PM2_5MIN > 20) && (PM2_5MIN <= 25))
            {
                pnl2_5PMMin.BackColor = Color.Yellow;
            }
            else if ((PM2_5MIN > 25))
            {
                pnl2_5PMMin.BackColor = Color.Red;
            }

            if (PM10MIN <= 40)
            {
                pnl10PMMin.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((PM10MIN > 40) && (PM10MIN <= 50))
            {
                pnl10PMMin.BackColor = Color.Yellow;
            }
            else if ((PM10MIN > 50))
            {
                pnl10PMMin.BackColor = Color.Red;
            }

            if (TempMIN <= 30)
            {
                pnlTempMin.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((TempMIN > 30) && (TempMIN <= 55))
            {
                pnlTempMin.BackColor = Color.Yellow;
            }
            else if ((TempMIN > 55))
            {
                pnlTempMin.BackColor = Color.Red;
            }

            if (VochtigheidMIN <= 50)
            {
                pnlVochtigheidMin.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((VochtigheidMIN > 50) && (VochtigheidMIN <= 60))
            {
                pnlVochtigheidMin.BackColor = Color.Yellow;
            }
            else if ((VochtigheidMIN > 60))
            {
                pnlVochtigheidMin.BackColor = Color.Red;
            }
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

            Int32 PM2_5MAX = Convert.ToInt32(cmdMAX.ExecuteScalar());
            Int32 PM10MAX = Convert.ToInt32(cmdMAX2.ExecuteScalar());
            Int32 TempMAX = Convert.ToInt32(cmdMAX3.ExecuteScalar());
            Int32 VochtigheidMAX= Convert.ToInt32(cmdMIN4.ExecuteScalar());

            txtPM2_5MAX.Text = Convert.ToString(PM2_5MAX);
            txtPM10MAX.Text = Convert.ToString(PM10MAX);
            txtTempMAX.Text = Convert.ToString(TempMAX);
            txtVochtigheidMAX.Text = Convert.ToString(VochtigheidMAX);
            txtLuchtdrukMAX.Text = Convert.ToString(cmdMAX5.ExecuteScalar());

            MijnVerbinding.Close();

            // ervoor zorgen dat bepaalde waarde categoriëen bepaalde kleuren krijgen
            if (PM2_5MAX <= 20)
            {
                pnl2_5PMMax.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((PM2_5MAX > 20) && (PM2_5MAX <= 25))
            {
                pnl2_5PMMax.BackColor = Color.Yellow;
            }
            else if ((PM2_5MAX > 25))
            {
                pnl2_5PMMax.BackColor = Color.Red;
            }

            if (PM10MAX <= 40)
            {
                pnl10PMMax.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((PM10MAX > 40) && (PM10MAX <= 50))
            {
                pnl10PMMax.BackColor = Color.Yellow;
            }
            else if ((PM10MAX > 50))
            {
                pnl10PMMax.BackColor = Color.Red;
            }

            if (TempMAX <= 30)
            {
                pnlTempMax.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((TempMAX > 30) && (TempMAX <= 55))
            {
                pnlTempMax.BackColor = Color.Yellow;
            }
            else if ((TempMAX > 55))
            {
                pnlTempMax.BackColor = Color.Red;
            }

            if (VochtigheidMAX <= 50)
            {
                pnlVochtigheidMAX.BackColor = Color.FromArgb(57, 255, 20);
            }
            else if ((VochtigheidMAX > 50) && (VochtigheidMAX <= 60))
            {
                pnlVochtigheidMAX.BackColor = Color.Yellow;
            }
            else if ((VochtigheidMAX > 60))
            {
                pnlVochtigheidMAX.BackColor = Color.Red;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
