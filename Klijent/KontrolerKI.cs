using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domen;
using System.ComponentModel;

namespace Klijent
{
    public class KontrolerKI
    {
        static Komunikacija k = new Komunikacija();

        public bool poveziSeSaServerom()
        {
            bool rezultat = k.poveziSeSaServerom();
            if (rezultat)
            {
                MessageBox.Show("Uspešna konekcija!", "Obaveštenje");
                return true;
            }
            else
            {
                MessageBox.Show("Neušpesna konekcija!", "Obaveštenje");
                return false;
            }
        }

        public int ulogujSe(TextBox korIme, TextBox loz)
        {
            Korisnik korisnikProvera = new Korisnik();
            korisnikProvera.Username = korIme.Text;
            korisnikProvera.Password = loz.Text;

            Korisnik korisnik = new Korisnik();
            korisnik = k.nadjiKorisnika(korisnikProvera);
            if (korisnik == null)
            {
                return 2;
            }
            else return korisnik.Privilegija;
        }
        
        public Korisnik popuniKorisnika(Korisnik korisnik1)
        {
            Korisnik korisnik = new Korisnik();
            korisnik = k.nadjiKorisnika(korisnik1);
            return korisnik;
        }
        

        public int vratiSifruProjekta(string nazivProjekta)
        {
            Projekat p = new Projekat();
            p.NazivProjekta = nazivProjekta;
            return k.vratiSifruProjekta(p);
        }

        public bool ubaciKorisnika(TextBox korIme, TextBox lozinka, ComboBox privilegija)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.Username = korIme.Text;
            korisnik.Password = lozinka.Text;
            korisnik.Privilegija = privilegija.SelectedIndex;

            return k.ubaciKorisnika(korisnik);
        }

        public bool izmeniUcestvovanje(ComboBox cmb, TextBox txtBox)
        {
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Morate izabrati poziciju!");
                return false;
            }
            else
            {
                SifarnikPozicija sp = new SifarnikPozicija();
                SifarnikUcesnika su = new SifarnikUcesnika();
                sp = cmb.SelectedItem as SifarnikPozicija; 
                su.SifarnikUID = Convert.ToInt32(txtBox.Text);
                su.SifraPozicije = sp.SifarnikPID;

                return k.izmeniUcestvovanje(su);
            }
        }

        public bool ubaciProjekat(TextBox nazivProjekta, TextBox generalniSponzor, TextBox mestoOdrzavanja, ComboBox vrstaProjekta, TextBox budzet, DateTimePicker datumOdrzavanja)
        {
            Projekat p = new Projekat();
            p.Budzet = Convert.ToInt32(budzet.Text);
            p.DatumOdrzavanja = datumOdrzavanja.Value.Date;
            p.GeneralniSponzor = generalniSponzor.Text;
            p.MestoOdrzavanja = mestoOdrzavanja.Text;
            p.NazivProjekta = nazivProjekta.Text;
            p.VrstaProjekta = vrstaProjekta.SelectedItem.ToString();

            return k.ubaciProjekat(p);
        }

        public bool izmeniKorisnika(TextBox username, TextBox password, TextBox ime, TextBox prezime, ComboBox godina, DateTimePicker datum, TextBox brTelefona)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.Username = username.Text;
            korisnik.Password = password.Text;
            korisnik.Ime = ime.Text;
            korisnik.Prezime = prezime.Text;
            korisnik.GodinaStudija = godina.Text;
            korisnik.DatumRodjenja = datum.Value.Date;
            korisnik.BrojTelefona = brTelefona.Text;

            return k.izmeniKorisnika(korisnik);
        }

        public bool vratiAktivnostUcesnikaNaProjektu(int korisnikIDPretraga, int projekatIDPretraga, TextBox txtSifraUcestvovanja, TextBox txtSifraKorisnika, TextBox txtSifraProjekta, TextBox txtStaraPozicija)
        {
            SifarnikUcesnika suSlanje = new SifarnikUcesnika();
            suSlanje.SifraKorisnika = korisnikIDPretraga;
            suSlanje.SifraProjekta = projekatIDPretraga;

            SifarnikUcesnika suPrijem = new SifarnikUcesnika();
            suPrijem = k.vratiAktivnostUcesnikaNaProjektu(suSlanje);

            txtSifraUcestvovanja.Text = suPrijem.SifarnikUID.ToString();
            txtSifraKorisnika.Text = suPrijem.SifraKorisnika.ToString();
            txtSifraProjekta.Text = suPrijem.SifraProjekta.ToString();
            txtStaraPozicija.Text = suPrijem.NazivPozicijeUcesnika;

            return true;
        }

        public bool izmeniProjekat(TextBox txtNazivProjekta, ComboBox cmbVrstaProjekta, TextBox txtGeneralniSponzor, TextBox txtBudzet, TextBox txtMestoOdrzavanja, DateTimePicker dtpDatumOdrzavanja)
        {
            try
            {
                try
                {
                    Projekat p = new Projekat();
                    p.Budzet = Convert.ToInt32(txtBudzet.Text);
                    if (txtNazivProjekta.Text.Equals(""))
                    {
                        MessageBox.Show("Sistem ne može da zapamti projekat");
                        MessageBox.Show("Morate uneti naziv projekta");
                        txtNazivProjekta.Focus();
                        return false;
                    }
                    else
                    {
                        p.NazivProjekta = txtNazivProjekta.Text;
                        p.ProjekatID = vratiSifruProjekta(p.NazivProjekta);
                        p.VrstaProjekta = cmbVrstaProjekta.SelectedItem.ToString();
                        p.GeneralniSponzor = txtGeneralniSponzor.Text;
                        p.MestoOdrzavanja = txtMestoOdrzavanja.Text;
                        p.DatumOdrzavanja = dtpDatumOdrzavanja.Value.Date;
                        return k.izmeniProjekat(p);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Za budžet morate uneti broj!");
                    MessageBox.Show("Sistem ne može da zapamti projekat");
                    txtBudzet.Clear();
                    txtBudzet.Focus();
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne može da zapamti projekat");
                return false;
            }
        }

        public bool obrisiKorisnika(TextBox username)
        {
            Korisnik korisnik = new Korisnik();
            korisnik.Username = username.Text;

            return k.obrisiKorisnika(korisnik);
        }

        public bool obrisiProjekat(Projekat p)
        {
            return k.obrisiProjekat(p);
        }

        public bool obrisiUcestvovanje(TextBox tb)
        {
            SifarnikUcesnika su = new SifarnikUcesnika();
            su.SifarnikUID = Convert.ToInt32(tb.Text);
            return k.obrisiUcestvovanje(su);
        }

        public void vratiSveKorisnikePoImenu(TextBox ime, DataGridView dgv)
        {
            dgv.ClearSelection();
            List<Korisnik> listaClanova = k.vratiKorisnike().OfType<Korisnik>().ToList<Korisnik>();
            List<Korisnik> nadjeni = new List<Korisnik>();

            foreach (Korisnik c in listaClanova)
            {
                if (c.Ime.StartsWith(ime.Text))
                {
                    nadjeni.Add(c);
                }
            }

            if (nadjeni.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe korisnika po zadatim vrednostima");
            }
            else dgv.DataSource = nadjeni; ;

            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                if (!(r.Cells[1].Value.ToString()).StartsWith(ime.Text))
                {
                    dgv.Rows.Remove(r);
                }
            }
        }

        public void vratiProjektePoImenu(TextBox ime, DataGridView dgv)
        {
            dgv.ClearSelection();
            List<Projekat> listaProjekata = k.vratiProjekte().OfType<Projekat>().ToList<Projekat>();
            List<Projekat> nadjeni = new List<Projekat>();

            foreach (Projekat c in listaProjekata)
            {
                if (c.NazivProjekta.StartsWith(ime.Text))
                {
                    nadjeni.Add(c);
                }
            }

            if (nadjeni.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe korisnika po zadatim vrednostima");
            }
            else dgv.DataSource = nadjeni; ;

            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                if (!(r.Cells[1].Value.ToString()).StartsWith(ime.Text))
                {
                    dgv.Rows.Remove(r);
                }
            }
        }
        
        public List<SifarnikPozicija> vratiSifarnikPozicija()
        {
            List<SifarnikPozicija> listaPozicija = k.vratiSifarnikPozicije().OfType<SifarnikPozicija>().ToList<SifarnikPozicija>();
            return listaPozicija;
        }

        public bool ubaciUcesnika(SifarnikUcesnika su)
        {
            return k.ubaciUcesnika(su);
        }

        public void prikaziUcesnikeProjekta(Projekat projekat, DataGridView dgv)
        {
            dgv.ClearSelection();
            List<SifarnikUcesnika> listaProjekta = k.vratiSifarnikUcesnika().OfType<SifarnikUcesnika>().ToList<SifarnikUcesnika>();
            List<SifarnikUcesnika> nadjeni = new List<SifarnikUcesnika>();

            foreach (SifarnikUcesnika c in listaProjekta)
            {
                if (c.SifraProjekta == projekat.ProjekatID)
                {
                    nadjeni.Add(c);
                }
            }

            if (nadjeni.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe korisnika po zadatim vrednostima");
            }
            else dgv.DataSource = nadjeni;
        }

        

        public void vratiSveProjekteZaKorisnika(Korisnik korisnik, DataGridView dgv)
        {
            dgv.ClearSelection();
            List<SifarnikUcesnika> listaProjekta = k.vratiSifarnikUcesnika().OfType<SifarnikUcesnika>().ToList<SifarnikUcesnika>();
            List<SifarnikUcesnika> nadjeni = new List<SifarnikUcesnika>();

            foreach (SifarnikUcesnika c in listaProjekta)
            {
                if (c.SifraKorisnika == korisnik.KorisnikID)
                {
                    nadjeni.Add(c);
                }
            }

            if (nadjeni.Count == 0)
            {
                MessageBox.Show("Sistem ne može da nađe korisnika po zadatim vrednostima");
            }
            else dgv.DataSource = nadjeni;

            /*
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                if (!(r.Cells[1].Value.ToString()).StartsWith(naziv.Text))
                {
                    dgv.Rows.Remove(r);
                }
            }
             * */
        }

        public void zatvori()
        {
            k.zatvori();
        }

    }
}