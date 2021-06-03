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
    public partial class FormCSVToevoegen : Form
    {
        public FormCSVToevoegen()
        {
            InitializeComponent();
        }

        private void btnSelecteren_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";

                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable dtNew = new DataTable();
                        dtNew = GetDataTabletFromCSVFile(dialog.FileName);
                        if (Convert.ToString(dtNew.Columns[0]) != "meterID")
                        {
                            MessageBox.Show("Invalid Items File");
                            btnOpslaan.Enabled = false;
                            return;
                        }
                        txtTekst.Text = dialog.SafeFileName;
                        SourceURl = dialog.FileName;
                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {
                            dgCSV.DataSource = dtNew;
                        }
                        foreach (DataGridViewRow row in dgCSV.Rows)
                        {
                            if (Convert.ToString(row.Cells["meterID"].Value) == "" || row.Cells["meterID"].Value == null
                                || Convert.ToString(row.Cells["PM2_5"].Value) == "" || row.Cells["PM2_5"].Value == null
                                || Convert.ToString(row.Cells["PM10"].Value) == "" || row.Cells["PM10"].Value == null
                                || Convert.ToString(row.Cells["temperatuur"].Value) == "" || row.Cells["temperatuur"].Value == null
                                || Convert.ToString(row.Cells["vochtigheid"].Value) == "" || row.Cells["vochtigheid"].Value == null
                                || Convert.ToString(row.Cells["luchtdruk"].Value) == "" || row.Cells["luchtdruk"].Value == null
                                || Convert.ToString(row.Cells["tijdstip"].Value) == "" || row.Cells["tijdstip"].Value == null
                                || Convert.ToString(row.Cells["datum"].Value) == "" || row.Cells["datum"].Value == null)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                inValidItem += 1;
                            }
                            else
                            {
                                ImportedRecord += 1;
                            }
                        }
                        if (dgCSV.Rows.Count == 0)
                        {
                            btnOpslaan.Enabled = false;
                            MessageBox.Show("There is no data in this file", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return csvData;
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtItem = (DataTable)(dgCSV.DataSource);
                string meterID, PM2_5, PM10, temperatuur, vochtigheid, luchtdruk, tijdstip, datum;
                string InsertItemQry = "";
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    meterID = Convert.ToString(dr["meterID"]);
                    PM2_5 = Convert.ToString(dr["PM2_5"]);
                    PM10 = Convert.ToString(dr["PM10"]);
                    temperatuur = Convert.ToString(dr["temperatuur"]);
                    vochtigheid = Convert.ToString(dr["vochtigheid"]);
                    luchtdruk = Convert.ToString(dr["luchtdruk"]);
                    tijdstip = Convert.ToString(dr["tijdstip"]);
                    datum = Convert.ToString(dr["datum"]);

                    if (meterID != "" && PM2_5 != "" && PM10 != "" && temperatuur != "" && vochtigheid != "" && luchtdruk != "" && tijdstip != "" && datum != "")
                    {
                        InsertItemQry += "Insert into tblgegevens(meterID,PM2_5,PM10,temperatuur,vochtigheid,luchtdruk, tijdstip, datum,) Values('" + dr["meterID"] + "','" + dr["PM2_5"] + "','" + dr["PM10"] + "','" + dr["temperatuur"] + "','" + dr["vochtigheid"] + "','" + dr["luchtdruk"] + "'," + dr["tijdstip"] + ",'" + dr["datum"] + "',GETDATE()); ";
                        count++;
                    }
                }
                if (InsertItemQry.Length > 5)
                {
                    OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");

                    OleDbCommand cmdCSV = new OleDbCommand();
                    cmdCSV.CommandType = CommandType.Text;
                    cmdCSV.CommandText = InsertItemQry;
                    cmdCSV.Connection = MijnVerbinding;

                    cmdCSV.ExecuteNonQuery();
                    MessageBox.Show("Item Imported Successfully, Total Imported Records : " + count + "", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
