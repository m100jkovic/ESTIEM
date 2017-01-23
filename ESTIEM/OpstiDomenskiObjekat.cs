using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string vratiImeTabele();

        string vratiKljucIUslov();

        string vrednostZaInsert();

        string imeKljucnogAtributa();

        string uslovZaNalazenjeSlogova();
        string vrednostiAtributaZaUpdate();

        string ImeJoin();
        string slozenSelect();

        OpstiDomenskiObjekat vratiObjekat(OleDbDataReader citac);

        //OpstiDomenskiObjekat vratiAktivnost(OleDbDataReader citac);

        List<OpstiDomenskiObjekat> vratiListu(OleDbDataReader citac);

        List<OpstiDomenskiObjekat> vratiSlozenuListu(OleDbDataReader citac);
    }
}
