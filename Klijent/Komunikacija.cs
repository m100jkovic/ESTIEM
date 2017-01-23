using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Domen;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater = new BinaryFormatter();

        public bool poveziSeSaServerom()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 11000);
                tok = klijent.GetStream();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Korisnik nadjiKorisnika(Korisnik korisnik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.logovanje;
            transfer.TransferObjekat = korisnik;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Korisnik k = transfer.TransferObjekat as Korisnik;
            return k;
        }

        /*
        public Korisnik popuniKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.popuniKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Korisnik korisnik = transfer.TransferObjekat as Korisnik;
            return korisnik;
        }
         * */

        public int vratiSifruProjekta(Projekat p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.vratiSifruProjekta;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Projekat projekat = transfer.TransferObjekat as Projekat;
            return projekat.ProjekatID;
        }

        public SifarnikUcesnika vratiAktivnostUcesnikaNaProjektu(SifarnikUcesnika su)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.vratiAktivnostUcesnikaNaProjektu;
            transfer.TransferObjekat = su;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            SifarnikUcesnika suRez = transfer.TransferObjekat as SifarnikUcesnika;
            return suRez;
        }

        public bool obrisiUcestvovanje(SifarnikUcesnika su)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.obrisiUcestvovanje;
            transfer.TransferObjekat = su;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            SifarnikUcesnika s = transfer.TransferObjekat as SifarnikUcesnika;
            return true;
        }

        public bool ubaciKorisnika(Korisnik korisnik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.unosKorisnika;
            transfer.TransferObjekat = korisnik;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Korisnik k = transfer.TransferObjekat as Korisnik;
            return true;
        }

        public bool ubaciProjekat(Projekat projekat)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.unosProjekta;
            transfer.TransferObjekat = projekat;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Projekat p = transfer.TransferObjekat as Projekat;
            return true;
        }

        public bool izmeniKorisnika(Korisnik korisnik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.izmeniKorisnika;
            transfer.TransferObjekat = korisnik;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Korisnik k = transfer.TransferObjekat as Korisnik;
            return true;
        }

        public bool izmeniUcestvovanje(SifarnikUcesnika su)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.izmeniUcestvovanje;
            transfer.TransferObjekat = su;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            SifarnikUcesnika sifarnik = transfer.TransferObjekat as SifarnikUcesnika;
            return true;
        }

        public bool izmeniProjekat(Projekat p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.izmeniProjekat;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Projekat projekat = transfer.TransferObjekat as Projekat;
            return true;
        }

        public bool obrisiKorisnika(Korisnik korisnik)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.obrisiKorisnika;
            transfer.TransferObjekat = korisnik;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Korisnik k = transfer.TransferObjekat as Korisnik;
            return true;
        }

        public bool obrisiProjekat(Projekat p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.obrisiProjekat;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            Projekat pr = transfer.TransferObjekat as Projekat;
            return true;
        }

        public bool ubaciUcesnika(SifarnikUcesnika su)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.ubaciUcesnika;
            transfer.TransferObjekat = su;
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            SifarnikUcesnika sifU = transfer.TransferObjekat as SifarnikUcesnika;
            return true;
        }

        public List<OpstiDomenskiObjekat> vratiSifarnikPozicije()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.vratiSifarnikPozicija;
            transfer.TransferObjekat = new SifarnikPozicija();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public List<OpstiDomenskiObjekat> vratiKorisnike()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.vratiKorisnike;
            transfer.TransferObjekat = new Korisnik();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public List<OpstiDomenskiObjekat> vratiProjekte()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.vratiProjekte;
            transfer.TransferObjekat = new Projekat();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public List<OpstiDomenskiObjekat> vratiSifarnikUcesnika()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.vratiSifarnikUcesnika;
            transfer.TransferObjekat = new SifarnikUcesnika();
            formater.Serialize(tok, transfer);
            transfer = formater.Deserialize(tok) as TransferKlasa;
            if (transfer.Uspesnost)
            {
                return transfer.TransferObjekat as List<OpstiDomenskiObjekat>;
            }
            else
            {
                return null;
            }
        }

        public void zatvori()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = (int)Operacije.kraj;
            formater.Serialize(tok, transfer);
        }

    }
}
