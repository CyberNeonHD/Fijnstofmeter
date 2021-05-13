using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FijnstofGIP
{
    class SQLScripts
    {


        public static readonly string sqlLocatieFijnstofMeter = "SELECT * FROM tblfijnstofmeters";


        #region [FormFijnstofmeterToevoegen]

        //aanmaken van een fijnstofmeter in de database
        public static readonly string sqlFijnstofMeterAanmaken =
           "INSERT INTO tblfijnstofmeters (meterID, meterNaam, latitude, longtitude)" +
           "VALUES (@meterid,@meternaam, @latitude, @longtitude)";
        #endregion

        #region [FormData]

        //via meterid alle gegevens van de meter opvragen
        public static readonly string sqlAlleGegevens = "SELECT * FROM tblgegevens WHERE (meterID = @meterid);";

        //verwijderen van record op basis van gegevensID
        public static readonly string sqlDataRecordVerwijderen = "DELETE FROM tblgegevens WHERE " +
            "(meterID=@meterid, PM2_5=@PM2_5, PM10=@PM10,temperatuur=@temperatuur, vochtigheid=@vochtigheid, luchtdruk=@luchtdruk, tijdstip=@tijdstip,datum=@datum)";

        //verkrijgen van gegevensID via de data die aanstaat -> dit zorgt ervoor dat we een "bypass" hebben om een redelijke grote bug te omzeilen
        public static readonly string sqlDataRecordVindID = "SELECT gegevensID FROM tblgegevens WHERE (gegevensID = @gegevensid)";
        //aanmaken van record
        public static readonly string sqlDataAanmaken =
           "INSERT INTO tblgegevens (meterID, PM2_5, PM10, temperatuur, vochtigheid, luchtdruk, tijdstip, datum)" +
           "VALUES (@meterid,@PM2_5, @PM10, @temperatuur, @vochtigheid, @luchtdruk, @tijdstip, @datum)";

        //aanpassen van een record
        public static readonly string sqlAanpassenDataRecord = "UPDATE tblgegevens " +
         "SET meterID=@meterid, PM2_5=@PM2_5, PM10=@PM10, temperatuur=@temperatuur, vochtigheid=@vochtigheid, luchtdruk=@luchtdruk, tijdstip=@tijdstip, datum=@datum WHERE " +
         "(gegevensID = @gegevensid) AND (meterID = @meterid)";

        //alle meters ophalen
        public static readonly string sqlMeterID = "SELECT meterID FROM tblfijnstofmeters";

        #endregion

        #region [WachtwoordReset]
        //via de ingevoerde email, de email,voornaam,familienaam opvragen -> dit doen we om deze op te slaan voor zo de email te kunnen versturen in de code + email extra controleren
        public static readonly string sqlEmailGebruiker = "SELECT gebruikersID, email,voornaam,familienaam FROM tblgebruikers WHERE (email = @email);";

        //via de gebruikersID het wachtwoordID inladen
        public static readonly string sqlWachtwoordID = "SELECT wachtwoordID from tblgebruikersWW WHERE (gebruikersID = @gebruikersID);";

        //aanpassen van nieuw wachtwoord
        public static readonly string sqlAanpassenWWGebruiker = "UPDATE tblgebruikersWW " +
        "SET gebruikersID=@gebruikersID, wachtwoord=@wachtwoord WHERE (wachtwoordID = @wachtwoordID)";
        #endregion

        #region [Aanmeldscherm]

        //verkrijgen van info over een gebruiker
        public static readonly string sqlInfoGebruiker = "SELECT gebruikersID,email,voornaam,familienaam,huisnummer,straat,postcode,gemeente FROM tblgebruikers WHERE (gebruikersnaam = @gebruikersnaam);";
        #endregion

        #region [Registratiescherm]
        //Registreren van gebruiker
        public static readonly string sqlRegistreren =
            "INSERT INTO tblgebruikers (gebruikersnaam, email, voornaam, familienaam, straat, huisnummer, postcode, gemeente)" +
            "VALUES (@gebruikersnaam,@email, @voornaam, @familienaam, @straat, @huisnummer, @postcode, @gemeente);";

        //invoegen van het wachtwoord in aparte tabel -> omslachtige manier maar het werkt wel :P
        public static readonly string sqlWWInvoeren = "INSERT INTO tblgebruikersWW (gebruikersID, wachtwoord)" +
           "VALUES (@gebruikersid, @wachtwoord)";

        //krijgen van gebruikersID via gebruikersnaam -> gebruikersnaam is uniek
        public static readonly string sqltblgebuikersID = "SELECT gebruikersID from tblgebruikers WHERE (gebruikersnaam = @gebruikersnaam);";
        #endregion

        #region statistische GEGEVENS [FormStatisticheData]

        //average "SELECT avg(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND WHERE datum BETWEEN (@datumP1) and (@datumP2);";
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
        #endregion

        #region [FormAdresVeranderen]
        //aanpassen van een record

        public static readonly string sqlAanpassenAdres = "UPDATE tblgebruikers " +
         "SET gebruikersnaam=@gebruikersnaam, email=@email, voornaam=@voornaam, familienaam=@familienaam,straat=@straat, huisnummer=@huisnummer, postcode=@postcode, gemeente=@gemeente WHERE " +
         "(gebruikersnaam = @gebruikersnaam)";

        #endregion
    }
}
