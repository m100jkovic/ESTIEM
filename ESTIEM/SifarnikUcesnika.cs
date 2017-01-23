using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.OleDb;

namespace Domen
{
    [Serializable]
    public class SifarnikUcesnika : OpstiDomenskiObjekat
    {
        private int sifarnikUID;
        [Browsable(false)]
        public int SifarnikUID
        {
            get { return sifarnikUID; }
            set { sifarnikUID = value; }
        }

        private int sifraKorisnika;
        [Browsable(false)]
        public int SifraKorisnika
        {
            get { return sifraKorisnika; }
            set { sifraKorisnika = value; }
        }

        private int sifraProjekta;
        [DisplayName("Šifra projekta")]
        public int SifraProjekta
        {
            get { return sifraProjekta; }
            set { sifraProjekta = value; }
        }

        private int sifraPozicije;
        [Browsable(false)]
        public int SifraPozicije
        {
            get { return sifraPozicije; }
            set { sifraPozicije = value; }
        }

        private string imeUcesnika;
        [DisplayName("Ime")]
        public string ImeUcesnika
        {
            get { return imeUcesnika; }
            set { imeUcesnika = value; }
        }
        private string prezimeUcesnika;
        [DisplayName("Prezime")]
        public string PrezimeUcesnika
        {
            get { return prezimeUcesnika; }
            set { prezimeUcesnika = value; }
        }

        private string nazivProjektaUcesnika;
        [DisplayName("Naziv projekta")]
        public string NazivProjektaUcesnika
        {
            get { return nazivProjektaUcesnika; }
            set { nazivProjektaUcesnika = value; }
        }

        private string nazivPozicijeUcesnika;
        [DisplayName("Pozicija")]
        public string NazivPozicijeUcesnika
        {
            get { return nazivPozicijeUcesnika; }
            set { nazivPozicijeUcesnika = value; }
        }

        public string vratiImeTabele()
        {
            return "TSifarnikUcesnika";
        }

        public string vratiKljucIUslov()
        {
            return "SifarnikUID = "+SifarnikUID;
        }

        public string vrednostZaInsert()
        {
            return "(" + sifraKorisnika + "," + sifraProjekta + "," + sifraPozicije + ")";
        }

        public string imeKljucnogAtributa()
        {
            return "SifarnikUID";
        }

        public string uslovZaNalazenjeSlogova()
        {
            return "TSifarnikUcesnika.SifraKorisnika = "+sifraKorisnika+ " AND TSifarnikUcesnika.SifraProjekta = "+SifraProjekta;
        }
        public string vrednostiAtributaZaUpdate()
        {
            return "SifraPozicije = "+SifraPozicije;
        }

        //string ImeJoin();
        public string slozenSelect()
        {
            return "TSifarnikUcesnika (SifraKorisnika, SifraProjekta, SifraPozicije)";
        }

        public OpstiDomenskiObjekat vratiObjekat(OleDbDataReader citac)
        {
            SifarnikUcesnika su = new SifarnikUcesnika();
            if (citac.Read())
            {
                su.SifarnikUID = citac.GetInt32(0);
                su.SifraKorisnika = citac.GetInt32(1);
                su.SifraProjekta = citac.GetInt32(2);
                su.SifraPozicije = citac.GetInt32(3);
                su.ImeUcesnika = citac.GetString(4);
                su.PrezimeUcesnika = citac.GetString(5);
                su.NazivProjektaUcesnika = citac.GetString(6);
                su.NazivPozicijeUcesnika = citac.GetString(7);

                return su;
            }

            else return null;
        }

        public List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> listaUcesnika = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                SifarnikUcesnika su = new SifarnikUcesnika();
                su.SifarnikUID = citac.GetInt32(0);
                su.SifraKorisnika = citac.GetInt32(1);
                su.SifraProjekta = citac.GetInt32(2);
                su.SifraPozicije = citac.GetInt32(3);

                listaUcesnika.Add(su);
            }
            return listaUcesnika;
        }

        public List<OpstiDomenskiObjekat> vratiSlozenuListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> listaUcesnika = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                SifarnikUcesnika su = new SifarnikUcesnika();
                su.SifarnikUID = citac.GetInt32(0);
                su.SifraKorisnika = citac.GetInt32(1);
                su.SifraProjekta = citac.GetInt32(2);
                su.SifraPozicije = citac.GetInt32(3);
                su.ImeUcesnika = citac.GetString(4);
                su.PrezimeUcesnika = citac.GetString(5);
                su.NazivProjektaUcesnika = citac.GetString(6);
                su.NazivPozicijeUcesnika = citac.GetString(7);

                listaUcesnika.Add(su);
            }
            return listaUcesnika;
        }

        /*
        public OpstiDomenskiObjekat vratiAktivnost(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }
         */

        public string ImeJoin()
        {
            return "TSifarnikUcesnika.SifarnikUID, TSifarnikUcesnika.SifraKorisnika, TSifarnikUcesnika.SifraProjekta, TSifarnikUcesnika.SifraPozicije, TKorisnik.Ime, TKorisnik.Prezime, TProjekat.NazivProjekta, TSifarnikPozicija.NazivPozicije FROM TSifarnikPozicija INNER JOIN (TProjekat INNER JOIN (TKorisnik INNER JOIN TSifarnikUcesnika ON TKorisnik.[KorisnikID] = TSifarnikUcesnika.[SifraKorisnika]) ON TProjekat.[ProjekatID] = TSifarnikUcesnika.[SifraProjekta]) ON TSifarnikPozicija.[SifarnikPID] = TSifarnikUcesnika.[SifraPozicije]";
            //return "TSifarnikUcesnika.SifarnikUID, TSifarnikUcesnika.SifraKorisnika, TSifarnikUcesnika.SifraProjekta, TSifarnikUcesnika.SifraPozicije, TProjekat.NazivProjekta, TSifarnikPozicija.NazivPozicije FROM TSifarnikPozicija INNER JOIN (TProjekat INNER JOIN (TKorisnik INNER JOIN TSifarnikUcesnika ON TKorisnik.[KorisnikID] = TSifarnikUcesnika.[SifraKorisnika]) ON TProjekat.[ProjekatID] = TSifarnikUcesnika.[SifraProjekta]) ON TSifarnikPozicija.[SifarnikPID] = TSifarnikUcesnika.[SifraPozicije]";
        }
    }
}
