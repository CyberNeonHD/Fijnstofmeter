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
            "INSERT INTO tblgebruikers (gebruikersnaam, email, wachtwoord, voornaam, familienaam, huisnummer, straat, postcode, gemeente)" +
            "VALUES (@gebruikersnaam,@email, @wachtwoord, @voornaam, @familienaam, @huisnummer, @straat, @postcode, @gemeente)";

        public static readonly string sqlLocatieFijnstofMeter = "SELECT * FROM tblfijnstofmeters";

        public static readonly string sqlFijnstofMeterAanmaken =
           "INSERT INTO tblfijnstofmeters (meterID, meterNaam, latitude, longtitude)" +
           "VALUES (@meterid,@meternaam, @latitude, @longtitude)";


        public static readonly string sqlAlleGegevens = "SELECT * FROM tblgegevens WHERE (meterID = @meterid);";

        public static readonly string sqlDataAanmaken =
           "INSERT INTO tblgegevens (meterID, PM2_5, PM10, temperatuur, vochtigheid, luchtdruk, tijdstip, datum)" +
           "VALUES (@meterid,@PM2_5, @PM10, @temperatuur, @vochtigheid, @luchtdruk, @tijdstip, @datum)";

        public static readonly string sqlMeterID = "SELECT meterID FROM tblfijnstofmeters";

        public static readonly string sqlDataRecordVerwijderen = "DELETE FROM tblgegevens WHERE (gegevensID = @gegevensid)";

        public static readonly string sqlAanpassenDataRecord = "UPDATE tblgegevens " +
         "SET meterID=@meterid, PM2_5=@PM2_5, PM10=@PM10,temperatuur=@temperatuur, vochtigheid=@vochtigheid, luchtdruk=@luchtdruk, tijdstip=@tijdstip,datum=@datum WHERE " + 
         "(gegevensID = @gegevensid) AND (meterID = @meterid)";

        //statistische GEGEVENS -----------------------------------------

        //avarege 

        public static readonly string sqlStatistischeGegevensAVG = "SELECT avg(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensAVG2 = "SELECT avg(PM10) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensAVG3 = "SELECT avg(temperatuur) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensAVG4 = "SELECT avg(vochtigheid) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensAVG5 = "SELECT avg(luchtdruk) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";

        //min
        public static readonly string sqlStatistischeGegevensMIN = "SELECT min(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMIN2 = "SELECT min(PM10) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMIN3 = "SELECT min(temperatuur) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMIN4 = "SELECT min(vochtigheid) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMIN5 = "SELECT min(luchtdruk) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";

        //max
        public static readonly string sqlStatistischeGegevensMAX = "SELECT max(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMAX2 = "SELECT max(PM10) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMAX3 = "SELECT max(temperatuur) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMAX4 = "SELECT max(vochtigheid) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";
        public static readonly string sqlStatistischeGegevensMAX5 = "SELECT max(luchtdruk) FROM tblgegevens WHERE (meterID = @meterid) AND (datum = @datum);";

    }
}
