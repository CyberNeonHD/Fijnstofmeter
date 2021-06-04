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
        private void btnBladeren_Click(object sender, EventArgs e)
        {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();
                txtTekst.Text = fileDialog.FileName;
                CSVInladen(txtTekst.Text);
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                

                for (int i = 0; i < dgvGegevens.Rows.Count -1; i++)
                {
                    OleDbCommand cmd= new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SQLScripts.sqlDataAanmaken;
                    cmd.Connection = MijnVerbinding;

                    cmd.Parameters.AddWithValue("@meterid", Convert.ToString(dgvGegevens.Rows[i].Cells[0].Value));
                    cmd.Parameters.AddWithValue("@PM2_5", dgvGegevens.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@PM10", dgvGegevens.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@temperatuur", dgvGegevens.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@vochtigheid",dgvGegevens.Rows[i].Cells[4].Value);
                    cmd.Parameters.AddWithValue("@luchtdruk", dgvGegevens.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@tijdstip", Convert.ToString(dgvGegevens.Rows[i].Cells[6].Value));
                    cmd.Parameters.AddWithValue("@datum", Convert.ToString(dgvGegevens.Rows[i].Cells[7].Value));

                    MijnVerbinding.Open();
                    cmd.ExecuteNonQuery();
                    MijnVerbinding.Close();
                }
                MessageBox.Show("Gegevens zijn in de database geladen!", "SUCCES: data toegevoegd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CSVInladen(string locatie)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(locatie);
            if (lines.Length > 0)
            {
                string eersteLijn = lines[0];

                string[] hearderLabels = eersteLijn.Split(';');

                foreach (string headerWord in hearderLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in hearderLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }

                    dt.Rows.Add(dr);
                }

            }
            if (dt.Rows.Count > 0)
            {
                dgvGegevens.DataSource = dt;
            }
            
        }

    }

}
