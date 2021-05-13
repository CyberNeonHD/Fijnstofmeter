using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //system die je moet inladen om de DDLImport werkend te krijgen
using FontAwesome.Sharp;
using System.Data.OleDb;

namespace FijnstofGIP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            tijd.Start();
            //DropMenuDesign();
            //welkom tekst op naam
            lblwelkom.Text = "Welkom "+ InfoGebruiker.voornaam + " " + InfoGebruiker.familienaam + ", bij de fijnstofmeter van Kalex";

            //gebruikersnaam naast de gerbuikersinstellingen
            lblNaamGebruiker.Text = InfoGebruiker.gebruikersnaam;
            
        }

        #region Code voor de dropmenu + openen van alle forms/uitvoeren van knoppen

        private Form actieveForm = null;
        private void openChildForm(Form childForm)
        {
            if (actieveForm != null)
            {
                actieveForm.Close();
            }
            actieveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMainForms.Controls.Add(childForm);
            pnlMainForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        /*
        private void DropMenuDesign()
        {
            pnlDataDropMenu.Visible = false;
        }

        private void SluitDropMenuDesign()
        {
            if(pnlDataDropMenu.Visible ==true)
            {
                pnlDataDropMenu.Visible = false;
            }
        }

        private void ToonDropMenuDesign(Panel DropMenu)
        {
            if (DropMenu.Visible == false)
            {
                SluitDropMenuDesign();
                DropMenu.Visible = true;
            }
            else
            {
                DropMenu.Visible = false;
            }
        }
        */
        private void MenuLogo_Click(object sender, EventArgs e)
        {
            if (actieveForm != null)
            {
                actieveForm.Close();
            }
            //SluitDropMenuDesign();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormData());
        }
        private void btnStatisticheData_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormStatisticheData());
            //SluitDropMenuDesign();
        }
        private void btnDataTabelvorm_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormDataTabelvorm());
        }
        private void btnFijnstofmeterToevoegen_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormFijnstofmeterToevoegen());
            //SluitDropMenuDesign();
        }
        private void btnKaartWeergeven_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormMapWeergeven());
            //SluitDropMenuDesign();
        }
        private void btnGebruikerSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.InstellingenGebuiker());
            //SluitDropMenuDesign();
        }

        //Slepen van de  Form (komt van pas als we de balk zelf maken)
        /*
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        */
        #endregion

        #region knop voor uit te loggen
        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            DialogResult Uitloggen = MessageBox.Show("Ben je zeker dat je wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Uitloggen == DialogResult.Yes)
            {
                Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
                volgendForm.Show(); //tonen van volgend form
                this.Close(); //Menu form verbergen
                MessageBox.Show("Succesvol uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //er gebeurd dan niks
            }
        }
        #endregion

        //timer die de datum update
        private void tijd_Tick(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }

        private void btnCSVToevoegen_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.ForCSVToevoegen());
        }
    }
}
