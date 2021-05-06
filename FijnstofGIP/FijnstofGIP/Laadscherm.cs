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

namespace FijnstofGIP
{
    public partial class Laadscherm : Form
    {   //DLL die je met importen om de gebogen randen bij het laadscherm te krijgen
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //entrypoint CreateRoundRectRgn laad eigenlijk onze private static extern IntPtr CreateRoundRectRgn in de Gdi32.dll

        private static extern IntPtr CreateRoundRectRgn //we maken een variabele aan die we later gebruiken bij region
            (
             int nLeftRect,
             int nTopRect,
             int RightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
            );

        public Laadscherm()
        {
            InitializeComponent();
            //hier roepen we dus de variabele die we eerder hebben aangemaakt op en geven we het de juiste lengtematen
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            LaadschermPB.Value = 0; //ronde laadbalk op 0 zetten
        }

        private void Laadscherm_Load(object sender, EventArgs e)
        {

        }

        private void LaadschermTimer_Tick(object sender, EventArgs e)
        {   //timer staat op 100 en elke tick is 1%
            LaadschermPB.Value += 1; // via dit vullen we de laadbalk op 
            LaadschermPB.Text = LaadschermPB.Value.ToString() + "%"; //hierbij tonen we het juiste cijfer + % in de cirkel

            if (LaadschermPB.Value == 100)//wanneer de timer 
            {
                LaadschermTimer.Enabled = false; //laadscherm niet langer enabled
                Aanmeldscherm volgendForm = new Aanmeldscherm(); //volgend form declareren
                volgendForm.Show(); //tonen van volgend form
                this.Hide(); //laadscherm form sluiten
            }
        }
    }
}
