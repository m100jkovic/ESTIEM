using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public abstract class Opsta
    {
        List<OpstiDomenskiObjekat> lista;
        OpstiDomenskiObjekat objekat;

        public List<OpstiDomenskiObjekat> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        public OpstiDomenskiObjekat Objekat
        {
            get { return objekat; }
            set { objekat = value; }
        }

        public bool izvrsiSo(OpstiDomenskiObjekat odo)
        {
            bool rezultat;

            Broker.dajBrokera().otvoriKonekciju();
            Broker.dajBrokera().zapocniTransakciju();
            rezultat = izvrsi(odo);
            if (rezultat)
            {
                Broker.dajBrokera().potvrdiTransakciju();
            }
            else
            {
                Broker.dajBrokera().ponistiTransakciju();
            }
            Broker.dajBrokera().zatvoriKonekciju();
            return rezultat;
        }

        protected abstract bool izvrsi(OpstiDomenskiObjekat odo);
    }
}
