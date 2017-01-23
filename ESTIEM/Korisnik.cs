using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.OleDb;

namespace Domen 
{
    [Serializable]
    public class Korisnik : OpstiDomenskiObjekat
    {
        private int korisnikID;
        [Browsable(false)]
        public int KorisnikID
        {
            get { return korisnikID; }
            set { korisnikID = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        [Browsable(false)]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int privilegija;
        [Browsable(false)]
        public int Privilegija
        {
            get { return privilegija; }
            set { privilegija = value; }
        }

        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private string godinaStudija;
        [Browsable(false)]
        public string GodinaStudija
        {
            get { return godinaStudija; }
            set { godinaStudija = value; }
        }

        private DateTime datumRodjenja;
        [Browsable(false)]
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        private string brojTelefona;
        [Browsable(false)]
        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        public string vratiImeTabele()
        {
            return "TKorisnik";
        }

        public string vratiKljucIUslov()
        {
            return "Username = '" + username + "'";
        }

        public string imeKljucnogAtributa()
        {
            return "KorisnikID";
        }

        public string uslovZaNalazenjeSlogova()
        {
            return " Username='" + username + "' AND Password='" + password + "'";
        }

        public OpstiDomenskiObjekat vratiObjekat(System.Data.OleDb.OleDbDataReader citac)
        {
            Korisnik k = new Korisnik();
            if (citac.Read())
            {
                k.korisnikID = citac.GetInt32(0);
                k.username = citac.GetString(1);
                k.password = citac.GetString(2);
                k.privilegija = citac.GetInt32(3);
                k.ime = citac.GetString(4);
                k.prezime = citac.GetString(5);
                k.godinaStudija = citac.GetString(6);
                k.datumRodjenja = citac.GetDateTime(7);
                k.brojTelefona = citac.GetString(8);
                return k;

            }
            else return null;
        }

        public List<OpstiDomenskiObjekat> vratiListu(System.Data.OleDb.OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> listaClanova = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Korisnik k = new Korisnik();
                k.KorisnikID = citac.GetInt32(0);
                k.Username = citac.GetString(1);
                k.Password = citac.GetString(2);
                k.Privilegija = citac.GetInt32(3);
                k.Ime = citac.GetString(4);
                k.Prezime = citac.GetString(5);
                k.GodinaStudija = citac.GetString(6);
                k.DatumRodjenja = citac.GetDateTime(7);
                k.BrojTelefona = citac.GetString(8);


                listaClanova.Add(k);
            }
            return listaClanova;
        }

        public string vrednostZaInsert()
        {
            return "('" + username + "','" + password + "'," + privilegija + ",'" + ime + "','" + prezime + "','" + godinaStudija + "','" + datumRodjenja + "','" + brojTelefona + "')";
        }

        public string slozenSelect()
        {
            return "TKorisnik ([Username], [Password], Privilegija, Ime, Prezime, GodinaStudija, DatumRodjenja, BrojTelefona)";
        }

        public string vrednostiAtributaZaUpdate()
        {
            return "Ime = '" + ime + "', Prezime = '" + prezime + "', GodinaStudija = '" + godinaStudija + "', DatumRodjenja = '" + datumRodjenja + "', BrojTelefona = '" + brojTelefona + "'";
        }

        public string ImeJoin()
        {
            throw new NotImplementedException();
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
