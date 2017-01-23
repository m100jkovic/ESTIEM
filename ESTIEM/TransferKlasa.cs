using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domen
{
    [Serializable]
    public class TransferKlasa
    {
        Object transferObjekat;

        public Object TransferObjekat
        {
            get { return transferObjekat; }
            set { transferObjekat = value; }
        }
        bool uspesnost;

        public bool Uspesnost
        {
            get { return uspesnost; }
            set { uspesnost = value; }
        }

        int privilegija;
        public int Privilegija
        {
            get { return privilegija; }
            set { privilegija = value; }
        }
        int operacija;

        public int Operacija
        {
            get { return operacija; }
            set { operacija = value; }
        }
        int signal;

        public int Signal
        {
            get { return signal; }
            set { signal = value; }
        }
    }
    public enum Operacije
    {
        logovanje = 1,
        vratiKorisnika,
        unosKorisnika,
        unosProjekta,
        izmeniKorisnika,
        obrisiKorisnika,
        vratiKorisnike,
        vratiSifarnikUcesnika,
        vratiSifarnikPozicija,
        vratiSifruProjekta,
        ubaciUcesnika,
        obrisiProjekat,
        vratiProjekte,
        izmeniProjekat,
        vratiAktivnostUcesnikaNaProjektu,
        izmeniUcestvovanje,
        obrisiUcestvovanje,
        popuniKorisnika,
        kraj,
    }
}
