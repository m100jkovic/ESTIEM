using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Domen;

namespace Sesija
{
    public class Broker
    {
        /*
         * interface A
         * class B:А,C
         * abstract C
         * 1. A a = new A();
         * 2. B b = new B();
         * 3. B b = new A();
         * 4. A a = new B();
         * 5. C c = new A();
         * 6. C c = new C();
         * 7. A a = new C();
         */ 

        OleDbConnection konekcija;
        OleDbTransaction transakcija;
        OleDbCommand komanda;
        private static Broker broker;

        void konektujSe()
        {
            konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Milan Stojkovic 142-09-i\ESTIEM\Baza.accdb;Persist Security Info=False;");
        }

        public static Broker dajBrokera()
        {
            if (broker == null)
            {
                broker = new Broker();
            }
            return broker;
        }

        private Broker()
        {
            konektujSe();
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija.Open();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri otvaranju konekcije!");
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri zatvaranju konekcije!");
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri započinjanju transakcije!");
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri potvrđivanju transakcije!");
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                throw new Exception("Greška pri poništavanju transakcije!");
            }
        }

        public OpstiDomenskiObjekat proveri(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select * FROM " + odo.vratiImeTabele() + " WHERE " + odo.uslovZaNalazenjeSlogova();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                OpstiDomenskiObjekat objekat = odo.vratiObjekat(citac);
                return objekat;
            }
            catch
            {
                throw new Exception("Greška pri vraćanju objekta!");
            }
        }

        public OpstiDomenskiObjekat vratiAktivnost(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select " + odo.ImeJoin() + " WHERE " + odo.uslovZaNalazenjeSlogova();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                OpstiDomenskiObjekat objekat = odo.vratiObjekat(citac);
                return objekat;
            }
            catch
            {
                throw new Exception("Greška pri vraćanju objekta!");
            }
        }

        public bool ubaci(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Insert into " + odo.slozenSelect() + " Values" + odo.vrednostZaInsert();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool izmeni(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "UPDATE " + odo.vratiImeTabele() + " SET " + odo.vrednostiAtributaZaUpdate() + " WHERE " + odo.vratiKljucIUslov() + ";";
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool obrisi(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "DELETE * FROM " + odo.vratiImeTabele() + " WHERE " + odo.vratiKljucIUslov() + ";";
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<OpstiDomenskiObjekat> vratiListu(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select * FROM " + odo.vratiImeTabele() + " ORDER BY " + odo.imeKljucnogAtributa();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                List<OpstiDomenskiObjekat> lista = odo.vratiListu(citac);
                return lista;
            }
            catch
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }

        
        public List<OpstiDomenskiObjekat> vratiSlozenuListu(OpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select " + odo.ImeJoin() + " ORDER BY " + odo.imeKljucnogAtributa();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                List<OpstiDomenskiObjekat> lista = odo.vratiSlozenuListu(citac);
                return lista;
            }
            catch
            {
                throw new Exception("Greska pri vracanju svih objekata!");
            }
        }
        
    }
}
