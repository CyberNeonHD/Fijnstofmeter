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
            DropMenuDesign();

            //welkom tekst op gebruikersnaam
            lblwelkom.Text = "Welkom "+  InfoGebruiker.gebruikersnaam +", bij de fijnstofmeter van Kalex";

            //gebruiker zijn voornaam en naam
            lblNaamGebruiker.Text = InfoGebruiker.voornaam + " " + InfoGebruiker.familienaam;
        }
        #region Code voor de dropmenu's + openen van forms

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

        private void DropMenuDesign()
        {
            pnlDataDropMenu.Visible = false;
            pnlStatistischeDateDropMenu.Visible = false;
        }

        private void SluitDropMenuDesign()
        {
            if(pnlDataDropMenu.Visible ==true)
            {
                pnlDataDropMenu.Visible = false;
            }
            if (pnlStatistischeDateDropMenu.Visible == true)
            {
                pnlStatistischeDateDropMenu.Visible = false;
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
        private void MenuLogo_Click(object sender, EventArgs e)
        {
            if (actieveForm != null)
            {
                actieveForm.Close();
            }
            SluitDropMenuDesign();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            ToonDropMenuDesign(pnlDataDropMenu);
        }

        private void btnPM2_5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormDataPM2_5());
            SluitDropMenuDesign();
        }

        private void btnPM10_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormDataPM10());
            SluitDropMenuDesign();
        }

        private void btnStatisticheData_Click(object sender, EventArgs e)
        {
            ToonDropMenuDesign(pnlStatistischeDateDropMenu);
        }

        private void btnStatistischePM2_5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormDataStatsPM2_5());
            SluitDropMenuDesign();
        }

        private void btnStatistischePM10_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.FormDataStatsPM10());
            SluitDropMenuDesign();
        }
        private void btnGebruikerSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormsMenu.InstellingenGebuiker());
            SluitDropMenuDesign();
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


        //knop voor uit te loggen
        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            DialogResult Uitloggen = MessageBox.Show("Ben je zeker dat je wilt uitloggen?", "Uitloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Uitloggen == DialogResult.Yes)
            {
                Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
                volgendForm.Show(); //tonen van volgend form
                this.Hide(); //Menu form verbergen
                MessageBox.Show("Succesvol uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Uitloggen == DialogResult.No)
            {
                //er gebeurd dan niks
            }
            else //FOUT PROTECTIE: moest er iets random foutlopen en de waarde is niet ja of nee 0.0
            {
                MessageBox.Show("Er is iets foutgelopen terwijl je op de knop drukte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
