using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.OleDb;

namespace Domen
{
    [Serializable]
    public class Projekat : OpstiDomenskiObjekat
    {
        private int projekatID;
        [Browsable(false)]
        public int ProjekatID
        {
            get { return projekatID; }
            set { projekatID = value; }
        }

        private string nazivProjekta;
        [DisplayName("Naziv projekta")]
        public string NazivProjekta
        {
            get { return nazivProjekta; }
            set { nazivProjekta = value; }
        }

        private string vrstaProjekta;
        [DisplayName("Vrsta projekta")]
        public string VrstaProjekta
        {
            get { return vrstaProjekta; }
            set { vrstaProjekta = value; }
        }

        private string generalniSponzor;
        [Browsable(false)]
        public string GeneralniSponzor
        {
            get { return generalniSponzor; }
            set { generalniSponzor = value; }
        }

        private int budzet;
        [Browsable(false)]
        public int Budzet
        {
            get { return budzet; }
            set { budzet = value; }
        }

        private string mestoOdrzavanja;
        [Browsable(false)]
        public string MestoOdrzavanja
        {
            get { return mestoOdrzavanja; }
            set { mestoOdrzavanja = value; }
        }

        private DateTime datumOdrzavanja;
        [DisplayName("Datum održavanja")]
        public DateTime DatumOdrzavanja
        {
            get { return datumOdrzavanja; }
            set { datumOdrzavanja = value; }
        }

        public string vratiImeTabele()
        {
            return "TProjekat";
        }

        public string vratiKljucIUslov()
        {
            return "ProjekatID = " + projekatID;
            //throw new NotImplementedException();
        }

        public string vrednostZaInsert()
        {
            return "('" + nazivProjekta + "','" + vrstaProjekta + "','" + generalniSponzor + "'," + budzet + ",'" + mestoOdrzavanja + "','" + datumOdrzavanja + "')";
        }

        public string slozenSelect()
        {
            return "TProjekat (NazivProjekta, VrstaProjekta, GeneralniSponzor, Budzet, MestoOdrzavanja, DatumOdrzavanja)";
        }

        public string imeKljucnogAtributa()
        {
            return "ProjekatID";
        }

        public string uslovZaNalazenjeSlogova()
        {
            return "NazivProjekta = '"+nazivProjekta+"'";
        }
        public string vrednostiAtributaZaUpdate()
        {
            return "NazivProjekta = '" + nazivProjekta + "', VrstaProjekta = '" + vrstaProjekta + "', GeneralniSponzor = '" + generalniSponzor + "', Budzet = " + budzet + ", MestoOdrzavanja = '" + mestoOdrzavanja + "', DatumOdrzavanja = '" + datumOdrzavanja + "'";
        }

        public OpstiDomenskiObjekat vratiObjekat(OleDbDataReader citac)
        {
            Projekat p = new Projekat();
            if (citac.Read())
            {
                p.ProjekatID = citac.GetInt32(0);
                p.NazivProjekta = citac.GetString(1);
                p.VrstaProjekta = citac.GetString(2);
                p.GeneralniSponzor = citac.GetString(3);
                p.Budzet = citac.GetInt32(4);
                p.MestoOdrzavanja = citac.GetString(5);
                p.DatumOdrzavanja = citac.GetDateTime(6);
                return p;

            }
            else return null;
        }

        public string ImeJoin()
        {
            return "TSifarnikPozicija INNER JOIN (TProjekat INNER JOIN (TKorisnik INNER JOIN TSifarnikUcesnika ON TKorisnik.[KorisnikID] = TSifarnikUcesnika.[SifraKorisnika]) ON TProjekat.[ProjekatID] = TSifarnikUcesnika.[SifraProjekta]) ON TSifarnikPozicija.[SifarnikPID] = TSifarnikUcesnika.[SifraPozicije]";
        }

        public List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> listaProjekata = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Projekat p = new Projekat();
                p.ProjekatID = citac.GetInt32(0);
                p.NazivProjekta = citac.GetString(1);
                p.VrstaProjekta = citac.GetString(2);
                p.GeneralniSponzor = citac.GetString(3);
                p.Budzet = citac.GetInt32(4);
                p.MestoOdrzavanja = citac.GetString(5);
                p.DatumOdrzavanja = citac.GetDateTime(6);

                listaProjekata.Add(p);
            }
            return listaProjekata;
        }

        /*
        public OpstiDomenskiObjekat vratiAktivnost(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }
         */

        public List<OpstiDomenskiObjekat> vratiSlozenuListu(System.Data.OleDb.OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }
    }
}
