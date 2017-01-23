using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen;
using Sesija;

namespace SistemskeOperacije
{
    public class Proveri : Opsta
    {
        protected override bool izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            Objekat = Broker.dajBrokera().proveri(odo);
            if (Objekat != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
