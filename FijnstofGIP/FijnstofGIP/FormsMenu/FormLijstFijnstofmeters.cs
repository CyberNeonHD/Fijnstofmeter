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
    public partial class FormLijstFijnstofmeters : Form
    {
        public FormLijstFijnstofmeters()
        {
            InitializeComponent();
        }
        DataSet dsMeters = new DataSet();
        private void FormLijstFijnstofmeters_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQLScripts.sqlAlleMeters, MijnVerbinding);

                dsMeters.Clear();
                adapter.Fill(dsMeters, "MijnTabel");
                GegevensTonen();

                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Problemen bij verbinding van de gegevens", "Verbinding database mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GegevensTonen()
        {
            // Opvullen van de datasource
            dgvMeters.DataSource = dsMeters.Tables["MijnTabel"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
