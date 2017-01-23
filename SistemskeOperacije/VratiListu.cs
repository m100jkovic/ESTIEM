using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sesija;

namespace SistemskeOperacije
{
    public class VratiListu : Opsta
    {
        protected override bool izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            try
            {
                Lista = Broker.dajBrokera().vratiListu(odo);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
