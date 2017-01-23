using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sesija;

namespace SistemskeOperacije
{
    public class VratiAktivnostUcesnikaNaProjektu : Opsta
    {
        protected override bool izvrsi(Domen.OpstiDomenskiObjekat odo)
        {
            Objekat = Broker.dajBrokera().vratiAktivnost(odo);
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
