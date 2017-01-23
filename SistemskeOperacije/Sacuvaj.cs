using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sesija;

namespace SistemskeOperacije
{
    public class Sacuvaj : Opsta
    {
        protected override bool izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            return Broker.dajBrokera().ubaci(odo);
        }
    }
}