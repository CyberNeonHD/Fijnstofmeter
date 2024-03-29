﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FijnstofGIP
{
    class SQLScripts
    {

        #region [FormData]
        //alles inladen van de tabel
        public static readonly string sqlDataAlleGegevens = "SELECT * FROM tblgegevens";

        //via meterid alle gegevens van de meter opvragen
        public static readonly string sqlAlleGegevens = "SELECT * FROM tblgegevens WHERE (meterID = @meterID) ORDER By gegevensID ASC";

        //verwijderen van record op basis van gegevensID
        public static readonly string sqlDataRecordVerwijderen = "DELETE FROM tblgegevens WHERE (gegevensID = @gegevensID);";

        //verkrijgen van gegevensID via de data die aanstaat -> dit zorgt ervoor dat we een "bypass" hebben om een redelijke grote bug te omzeilen
        public static readonly string sqlDataRecordVindID = "SELECT gegevensID FROM tblgegevens WHERE (gegevensID = @gegevensID)";

        //aanmaken van record
        public static readonly string sqlDataAanmaken =
           "INSERT INTO tblgegevens (meterID, PM2_5, PM10, temperatuur, vochtigheid, luchtdruk, tijdstip, datum)" +
           "VALUES (@meterid,@PM2_5, @PM10, @temperatuur, @vochtigheid, @luchtdruk, @tijdstip, @datum);";

        //aanpassen van een record
        public static readonly string sqlAanpassenDataRecord = "UPDATE tblgegevens " +
         "SET meterID=@meterid, PM2_5=@PM2_5, PM10=@PM10, temperatuur=@temperatuur, vochtigheid=@vochtigheid, luchtdruk=@luchtdruk, tijdstip=@tijdstip, datum=@datum WHERE " +
         "(gegevensID = @gegevensid) AND (meterID = @meterid)";

        //alle meters ophalen
        public static readonly string sqlMeterID = "SELECT meterID FROM tblfijnstofmeters";

        #endregion

        #region [WachtwoordReset + FormWWVeranderen + FormEmailVeranderen]
        //via de ingevoerde email, de email,voornaam,familienaam opvragen -> 
        //dit doen we om deze op te slaan voor zo de email te kunnen versturen in de code + email extra controleren
        //form: WachtwoordReset
        public static readonly string sqlEmailGebruiker = "SELECT gebruikersID, email,voornaam,familienaam FROM tblgebruikers WHERE (email = @email);";

        //via de gebruikersID het wachtwoordID inladen
        //form: WachtwoordReset en FormWWVeranderen en FormEmailVeranderen
        public static readonly string sqlWachtwoordID = "SELECT wachtwoordID from tblgebruikersWW WHERE (gebruikersID = @gebruikersID);";

        //aanpassen van nieuw wachtwoord
        //form: WachtwoordReset en FormWWVeranderen
        public static readonly string sqlAanpassenWWGebruiker = "UPDATE tblgebruikersWW " +
        "SET gebruikersID=@gebruikersID, wachtwoord=@wachtwoord WHERE (wachtwoordID = @wachtwoordID)";

        //aanpassen van email -> daarvoor moeten we alles updaten 
        public static readonly string sqlAanpassenEmail = "UPDATE tblgebruikers " +
         "SET gebruikersid=@gebruikersid, gebruikersnaam=@gebruikersnaam, email=@email, voornaam=@voornaam, familienaam=@familienaam,straat=@straat, huisnummer=@huisnummer, postcode=@postcode, gemeente=@gemeente WHERE " +
         "(gebruikersnaam = @gebruikersnaam)";

        #endregion

        #region [Aanmeldscherm]

        //verkrijgen van info over een gebruiker
        public static readonly string sqlInfoGebruiker = "SELECT gebruikersID,email,voornaam,familienaam,huisnummer,straat,postcode,gemeente FROM tblgebruikers WHERE (gebruikersnaam = @gebruikersnaam);";
        #endregion

        #region [Registratiescherm]
        //Registreren van gebruiker
        public static readonly string sqlRegistreren =
            "INSERT INTO tblgebruikers (gebruikersID, gebruikersnaam, email, voornaam, familienaam, straat, huisnummer, postcode, gemeente)" +
            "VALUES (@gebruikersid, @gebruikersnaam,@email, @voornaam, @familienaam, @straat, @huisnummer, @postcode, @gemeente);";

        //invoegen van het wachtwoord in aparte tabel -> omslachtige manier maar het werkt wel :P
        public static readonly string sqlWWInvoeren = "INSERT INTO tblgebruikersWW (gebruikersID, wachtwoord)" +
           "VALUES (@gebruikersid, @wachtwoord)";

        //krijgen van gebruikersID via gebruikersnaam -> gebruikersnaam is uniek
        public static readonly string sqltblgebuikersID = "SELECT gebruikersID from tblgebruikers WHERE (gebruikersnaam = @gebruikersnaam);";

        #endregion

        #region statistische GEGEVENS [FormStatisticheData]

        //average "SELECT avg(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensAVG = "SELECT avg(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensAVG2 = "SELECT avg(PM10) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensAVG3 = "SELECT avg(temperatuur) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensAVG4 = "SELECT avg(vochtigheid) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensAVG5 = "SELECT avg(luchtdruk) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";

        //min
        public static readonly string sqlStatistischeGegevensMIN = "SELECT min(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMIN2 = "SELECT min(PM10) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMIN3 = "SELECT min(temperatuur) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMIN4 = "SELECT min(vochtigheid) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMIN5 = "SELECT min(luchtdruk) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";

        //max
        public static readonly string sqlStatistischeGegevensMAX = "SELECT max(PM2_5) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMAX2 = "SELECT max(PM10) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMAX3 = "SELECT max(temperatuur) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMAX4 = "SELECT max(vochtigheid) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        public static readonly string sqlStatistischeGegevensMAX5 = "SELECT max(luchtdruk) FROM tblgegevens WHERE (meterID = @meterid) AND datum BETWEEN (@datumP1) and (@datumP2);";
        #endregion

        #region [FormAdresVeranderen]
        //aanpassen van een record
        public static readonly string sqlAanpassenAdres = "UPDATE tblgebruikers " +
         "SET gebruikersid=@gebruikersid, gebruikersnaam=@gebruikersnaam, email=@email, voornaam=@voornaam, familienaam=@familienaam,straat=@straat, huisnummer=@huisnummer, postcode=@postcode, gemeente=@gemeente WHERE " +
         "(gebruikersnaam = @gebruikersnaam)";
        #endregion

        #region [FormGebruiksersNaamVeranderen]
        //aanpassen van een record
        public static readonly string sqlAanpassenGebruikersnaam = "UPDATE tblgebruikers " +
         "SET gebruikersid=@gebruikersid, gebruikersnaam=@gebruikersnaam, email=@email, voornaam=@voornaam, familienaam=@familienaam,straat=@straat, huisnummer=@huisnummer, postcode=@postcode, gemeente=@gemeente WHERE " +
         "(gebruikersid = @gebruikersid)";
        #endregion

        #region [FormLijstFijnstofmeters + FormFijnstofMetersBewerken]
        //FormLijstFijnstofmeters + FormFijnstofMetersBewerken
        public static readonly string sqlAlleMeters = "SELECT * FROM tblfijnstofmeters;";
        #endregion

        #region [FormFijnstofMetersBewerken]


        //verwijderen van record op basis van meterID
        public static readonly string sqlMeterRecordVerwijderen = "DELETE FROM tblfijnstofmeters WHERE (meterID = @meterid)";

        //aanmaken van een fijnstofmeter in de database
        public static readonly string sqlFijnstofMeterAanmaken =
           "INSERT INTO tblfijnstofmeters (meterID, meterNaam, latitude, longtitude)" +
           "VALUES (@meterid,@meternaam, @latitude, @longtitude)";

        //aanpassen van een record
        public static readonly string sqlAanpassenMeterRecord = "UPDATE tblfijnstofmeters " +
         "SET meterID=@meterid, meterNaam=@meterNaam, latitude=@latitude,longtitude=@longtitude WHERE " +
         "(meterID = @meterid)";
        #endregion
        #region [QRCodeLogin]
        public static readonly string sqlInfoGebruikerQRCode = "SELECT gebruikersnaam,email,voornaam,familienaam,huisnummer,straat,postcode,gemeente FROM tblgebruikers WHERE (gebruikersID = @gebruikersID);";
        #endregion
    }
}
