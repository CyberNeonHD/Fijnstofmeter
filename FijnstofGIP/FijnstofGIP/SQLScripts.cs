using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FijnstofGIP
{
    class SQLScripts
    {
        //Registreren van gebruiker
        public static readonly string sqlRegistreren =
            "INSERT INTO tblgebruikers (gebruikersnaam, email, wachtwoord, voornaam, familienaam, huisnummer, straat, postcode, gemeente) " +
            "VALUES (@gebruikersnaam,@email, @wachtwoord, @voornaam, @familienaam, @huisnummer, @straat, @postcode, @gemeente)";
    }
}
