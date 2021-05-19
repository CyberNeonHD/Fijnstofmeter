using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FijnstofGIP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// GIP Project Kobbe en Alex
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new Aanmeldscherm());
            }
            catch
            {
                MessageBox.Show("Crash: Verbinding mislukt. Heb je internet of blokkeert de firewall de connectie?", "Geen verbinding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
