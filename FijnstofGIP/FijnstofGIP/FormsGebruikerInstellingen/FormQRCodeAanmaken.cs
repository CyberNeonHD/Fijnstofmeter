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
using QRCoder;

namespace FijnstofGIP.FormsGebruikerInstellingen
{
    public partial class FormQRCodeAanmaken : Form
    {
        public FormQRCodeAanmaken()
        {
            InitializeComponent();
        }
        DataSet dsWW = new DataSet();

        #region lay-out -> bij klik een kleur
        private void txtWW_Click(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.DeepSkyBlue;
        }
        #endregion

        #region tab support -> kleurtjes
        private void txtWW_Enter(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.DeepSkyBlue;
        }

        private void txtWW_Leave(object sender, EventArgs e)
        {
            pnlWW.BackColor = Color.White;
        }

        #endregion

        #region tekst bij hover -> geeft de gebruiker meer feedback over wat iets doet
        private void btnLockWW_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te tonen.", btnLockWW);
        }

        private void btnOpenLockWW_MouseHover(object sender, EventArgs e)
        {
            //als je nu over met de muis over de icoon gaat zie je deze tekst -> spatie zodat de muis niet voor de tekst zit
            TipTxt.Show("  Klik om jouw wachtwoord te verbergen.", btnOpenLockWW);
        }
        #endregion

        private void btnAanmakenQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QRCode = new QRCodeGenerator();
           
            //instructie voor QR Code aan te maken op wachtwoord ----------------------------------------------------------------------------
            OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
            MijnVerbinding.Open();

            string loginWW = "SELECT wachtwoord FROM tblgebruikersWW WHERE gebruikersID=@gebruikersID";

            OleDbDataAdapter adapterWW = new OleDbDataAdapter(loginWW, MijnVerbinding);
            adapterWW.SelectCommand.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);

            OleDbDataReader drGebrWW = adapterWW.SelectCommand.ExecuteReader();

            //We ontvangend het HASH wachtwoord en houden het HASH voor veiligheid
            string QRTekst = "";
            while (drGebrWW.Read())
            {
                QRTekst = drGebrWW.GetValue(0).ToString();
            }
            var MyData = QRCode.CreateQrCode(QRTekst, QRCodeGenerator.ECCLevel.H);
            var code = new QRCode(MyData);
            QRBox.Image = code.GetGraphic(5);
        }

        private void btnQROpslaan_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            QRBox.Image.Save(dlg.FileName);
            MessageBox.Show("QR code opgeslaan");
            pnlWWCheckSectie.Visible = true;
            pnlSectieMakenQRCode.Visible = false;
            txtWW.Clear();
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection MijnVerbinding = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FijnstofmeterDB.mdb");
                MijnVerbinding.Open();

                //via de gebruikersID die we verkregen hebben via gebruikersnaam nemen we het wachtwoord
                string loginWW = "SELECT wachtwoord FROM tblgebruikersWW WHERE gebruikersID=@gebruikersID";

                OleDbDataAdapter adapterWW = new OleDbDataAdapter(loginWW, MijnVerbinding);
                adapterWW.SelectCommand.Parameters.AddWithValue("@gebruikersID", InfoGebruiker.gebruikersID);

                //we vullen de datasetten in
                adapterWW.Fill(dsWW, "loginWW");

                //We gaan checken of het wachtwoord wel klopt
                if ((Hasher.Hash_SHA1(txtWW.Text) == dsWW.Tables[0].Rows[0]["wachtwoord"].ToString()))
                {   //als de login klopt:
                    pnlWWCheckSectie.Visible = false;
                    pnlSectieMakenQRCode.Visible = true;
                    MessageBox.Show("Wachtwoord klopt", "Juist wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //als een hoofdletter niet klopt krijg deze melding te zien
                    MessageBox.Show("Ongeldig wachtwoord, probeer opnieuw aub", "Login mislukt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MijnVerbinding.Close();
            }
            catch
            {
                MessageBox.Show("ERROR: Fout tijdens controleren van het wachtwoord", "Onverwachte error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region code zichtbaar ww of niet zichtbaar
        private void btnLockWW_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '*')
            {
                btnOpenLockWW.BringToFront();
                txtWW.PasswordChar = '\0';
            }
        }

        private void btnOpenLockWW_Click(object sender, EventArgs e)
        {
            if (txtWW.PasswordChar == '\0')
            {
                btnLockWW.BringToFront();
                txtWW.PasswordChar = '*';
            }
        }


        #endregion
    }
}
