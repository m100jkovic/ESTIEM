using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Domen
{
    [Serializable]
    public class SifarnikPozicija : OpstiDomenskiObjekat
    {
        private int sifarnikPID;

        public int SifarnikPID
        {
            get { return sifarnikPID; }
            set { sifarnikPID = value; }
        }

        private string nazivPozicije;

        public string NazivPozicije
        {
            get { return nazivPozicije; }
            set { nazivPozicije = value; }
        }

        public override string ToString()
        {
            return nazivPozicije;
        }

        public string vratiImeTabele()
        {
            return "TSifarnikPozicija";
        }

        public string vratiKljucIUslov()
        {
            throw new NotImplementedException();
        }

        public string vrednostZaInsert()
        {
            throw new NotImplementedException();
        }

        public string imeKljucnogAtributa()
        {
            return "SifarnikPID";
        }

        public string uslovZaNalazenjeSlogova()
        {
            throw new NotImplementedException();
        }
        public string vrednostiAtributaZaUpdate()
        {
            throw new NotImplementedException();
        }

        //string ImeJoin();
        public string slozenSelect()
        {
            throw new NotImplementedException();
        }

        /*
        public OpstiDomenskiObjekat vratiAktivnost(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }
         */

        public OpstiDomenskiObjekat vratiObjekat(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac)
        {
            List<OpstiDomenskiObjekat> listaSifriPozicija = new List<OpstiDomenskiObjekat>();
            while (citac.Read())
            {
                SifarnikPozicija sp = new SifarnikPozicija();
                sp.SifarnikPID = citac.GetInt32(0);
                sp.NazivPozicije = citac.GetString(1);

                listaSifriPozicija.Add(sp);
            }
            return listaSifriPozicija;
        }

        public string ImeJoin()
        {
            throw new NotImplementedException();
        }

        public List<OpstiDomenskiObjekat> vratiSlozenuListu(System.Data.OleDb.OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }
    }
}
