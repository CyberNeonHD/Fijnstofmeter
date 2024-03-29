﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FijnstofGIP.FormsMenu
{
    public partial class InstellingenGebuiker : Form
    {
        private Form actieveForm = null;
        public InstellingenGebuiker()
        {
            InitializeComponent();

        }
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
            pnlGebruikerForm.Controls.Add(childForm);
            pnlGebruikerForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnWWAanpassen_Click(object sender, EventArgs e)
        {
            pnlGebruikerMenuLinks.Visible = false;
            btnTerugkeren.Visible = true;
            btnClose.Visible = false;
            openChildForm(new FormsGebruikerInstellingen.FormWWVeranderen());
        }

        private void btnAdresVeranderen_Click(object sender, EventArgs e)
        {
            pnlGebruikerMenuLinks.Visible = false;
            btnTerugkeren.Visible = true;
            btnClose.Visible = false;
            openChildForm(new FormsGebruikerInstellingen.FormAdresVeranderen());

        }

        private void btnGebruikersnaamVeranderen_Click(object sender, EventArgs e)
        {
            pnlGebruikerMenuLinks.Visible = false;
            btnTerugkeren.Visible = true;
            btnClose.Visible = false;
            openChildForm(new FormsGebruikerInstellingen.FormGebruiksersNaamVeranderen());
        }
        private void btnEmailVeranderen_Click(object sender, EventArgs e)
        {
            pnlGebruikerMenuLinks.Visible = false;
            btnTerugkeren.Visible = true;
            btnClose.Visible = false;
            openChildForm(new FormsGebruikerInstellingen.FormEmailVeranderen());
        }
        private void BtnQRCodeAanmaken_Click(object sender, EventArgs e)
        {
            pnlGebruikerMenuLinks.Visible = false;
            btnTerugkeren.Visible = true;
            btnClose.Visible = false;
            openChildForm(new FormsGebruikerInstellingen.FormQRCodeAanmaken());
        }

        private void btnTerugkeren_Click(object sender, EventArgs e)
        {
            actieveForm.Close();
            btnTerugkeren.Visible = false;
            btnClose.Visible = true;
            pnlGebruikerMenuLinks.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
