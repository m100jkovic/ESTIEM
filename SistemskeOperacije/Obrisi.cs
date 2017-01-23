using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class Obrisi : Opsta
    {
        protected override bool izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            return Broker.dajBrokera().obrisi(odo);
        }
    }
}
