using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Threading;
using SistemskeOperacije;

namespace Server
{
    public class NitKlijenta
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public NitKlijenta(NetworkStream tok)
        {
            formater = new BinaryFormatter();
            this.tok = tok;
            ThreadStart ts = obradaPodataka;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        private void obradaPodataka()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    operacija = transfer.Operacija;
                    switch (operacija)
                    {
                        #region LogIn
                        case (int)Operacije.logovanje:
                            Proveri kor = new Proveri();
                            transfer.Uspesnost = kor.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = kor.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        #endregion

                        case (int)Operacije.popuniKorisnika:
                            Proveri popunjenKorisnik = new Proveri();
                            transfer.Uspesnost = popunjenKorisnik.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = popunjenKorisnik.Objekat;
                            formater.Serialize(tok, transfer);
                            break;   

                        case (int)Operacije.unosKorisnika:
                            Sacuvaj noviKorisnik = new Sacuvaj();
                            transfer.Uspesnost = noviKorisnik.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = noviKorisnik.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.izmeniKorisnika:
                            Izmeni izmenjenKorisnik = new Izmeni();
                            transfer.Uspesnost = izmenjenKorisnik.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = izmenjenKorisnik.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.izmeniProjekat:
                            Izmeni izmenjenProjekat = new Izmeni();
                            transfer.Uspesnost = izmenjenProjekat.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = izmenjenProjekat.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.izmeniUcestvovanje:
                            Izmeni izmenjenoUcestvovanje = new Izmeni();
                            transfer.Uspesnost = izmenjenoUcestvovanje.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = izmenjenoUcestvovanje.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.obrisiKorisnika:
                            Obrisi obrisaniKorisnik = new Obrisi();
                            transfer.Uspesnost = obrisaniKorisnik.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = obrisaniKorisnik.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.obrisiProjekat:
                            Obrisi obrisiProjekat = new Obrisi();
                            transfer.Uspesnost = obrisiProjekat.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = obrisiProjekat.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.obrisiUcestvovanje:
                            Obrisi obrisiU = new Obrisi();
                            transfer.Uspesnost = obrisiU.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = obrisiU.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.vratiKorisnike:
                            VratiListu listaKorisnika = new VratiListu();
                            transfer.Uspesnost = listaKorisnika.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = listaKorisnika.Lista;
                            transfer.Signal = listaKorisnika.Lista.Count;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.vratiProjekte:
                            VratiListu listaProjekata = new VratiListu();
                            transfer.Uspesnost = listaProjekata.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = listaProjekata.Lista;
                            transfer.Signal = listaProjekata.Lista.Count;
                            formater.Serialize(tok, transfer);
                            break;
                            
                        case (int)Operacije.vratiSifarnikUcesnika:
                            VratiSlozenuListu listaSifarnikaUcesnika = new VratiSlozenuListu();
                            transfer.Uspesnost = listaSifarnikaUcesnika.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = listaSifarnikaUcesnika.Lista;
                            transfer.Signal = listaSifarnikaUcesnika.Lista.Count;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.vratiSifarnikPozicija:
                            VratiListu listaSifarnikaPozicija = new VratiListu();
                            transfer.Uspesnost = listaSifarnikaPozicija.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = listaSifarnikaPozicija.Lista;
                            transfer.Signal = listaSifarnikaPozicija.Lista.Count;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.unosProjekta:
                            Sacuvaj noviProjekat = new Sacuvaj();
                            transfer.Uspesnost = noviProjekat.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = noviProjekat.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.vratiSifruProjekta:
                            Proveri sifra = new Proveri();
                            transfer.Uspesnost = sifra.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = sifra.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.ubaciUcesnika:
                            Sacuvaj ucesnik = new Sacuvaj();
                            transfer.Uspesnost = ucesnik.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = ucesnik.Objekat;
                            formater.Serialize(tok, transfer);
                            break;

                        case (int)Operacije.vratiAktivnostUcesnikaNaProjektu:
                            VratiAktivnostUcesnikaNaProjektu aktivnost = new VratiAktivnostUcesnikaNaProjektu();
                            transfer.Uspesnost = aktivnost.izvrsiSo(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            transfer.TransferObjekat = aktivnost.Objekat;
                            formater.Serialize(tok, transfer);
                            break;
                            
                        case (int)Operacije.kraj:
                            Console.WriteLine("Hvala na konekciji!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prekid niti:" + ex.Message);
            }
        }
    }
}
