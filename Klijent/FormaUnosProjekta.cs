using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domen;

namespace Klijent
{
    public partial class FormaUnosProjekta : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();

        Projekat p = new Projekat();
        BindingList<SifarnikUcesnika> listaUcesnika;
        public FormaUnosProjekta()
        {
            InitializeComponent();
            p = new Projekat();
            listaUcesnika = new BindingList<SifarnikUcesnika>();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSacuvajProjekatISpisakUcesnika_Click(object sender, EventArgs e)
        {
            foreach (SifarnikUcesnika su in listaUcesnika)
            {
                su.SifraProjekta = ki.vratiSifruProjekta(txtNazivProjekta.Text);
                ki.ubaciUcesnika(su);
            }
            MessageBox.Show("Novi projekat je uspešno sačuvan");
            this.Close();
        }

        private void btnKreirajNoviProjekat_Click(object sender, EventArgs e)
        {
            bool rezultat = ki.ubaciProjekat(txtNazivProjekta, txtGeneralniSponzor, txtMestoOdrzavanja, cmbVrstaProjekta, txtBudzet, dtpDatumOdrzavanja);
            if (rezultat)
            {
                MessageBox.Show("Novi projekat je uspešno kreiran");
                gbDodavanjeUcesnikaProjekta.Visible = true;
                this.ControlBox = false;
                txtNazivProjekta.Enabled = false;
                txtBudzet.Enabled = false;
                txtGeneralniSponzor.Enabled = false;
                txtMestoOdrzavanja.Enabled = false;
                dtpDatumOdrzavanja.Enabled = false;
                cmbVrstaProjekta.Enabled = false;
                btnKreirajNoviProjekat.Visible = false;
            }
            else MessageBox.Show("Sistem ne može da kreira novi projekat!");
        }

        private void FormaUnosProjekta_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            cmbVrstaProjekta.SelectedIndex = 4;
            cmbPozicija.DataSource = ki.vratiSifarnikPozicija();
            cmbPozicija.DisplayMember = "NazivPozicije";
            gbDodavanjeUcesnikaProjekta.Visible = false;
            dgvSpisakUcesnika.DataSource = listaUcesnika;
        }

        private void btnPronadjiKorisnike_Click(object sender, EventArgs e)
        {
            ki.vratiSveKorisnikePoImenu(txtPretragaIme, dgvListaKorisnika);

            if (dgvListaKorisnika.Rows.Count > 0)
            {
                MessageBox.Show("Sistem je našao korisnike sistema po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne može da nađe korisnike sistema po zadatoj vrednosti");
                txtPretragaIme.Clear();
                txtPretragaIme.Focus();
            }
        }

        private void btnDodajUListu_Click(object sender, EventArgs e)
        {
            int brojacKoordinatora = 0;
            int brojacIstih = 0;
            try
            {
                Korisnik k = dgvListaKorisnika.SelectedRows[0].DataBoundItem as Korisnik;

                foreach (SifarnikUcesnika su in listaUcesnika)
                {
                    if (su.SifraKorisnika == k.KorisnikID) brojacIstih++;
                    if (su.NazivPozicijeUcesnika.Equals("Koordinator projekta")) brojacKoordinatora++;
                }

                if (brojacKoordinatora > 0 && cmbPozicija.SelectedItem.ToString().Equals("Koordinator projekta"))
                {
                    MessageBox.Show("Projekat može imati samo jednog koordinatora!");
                }
                else
                {
                    if (brojacIstih == 0)
                    {
                        SifarnikUcesnika su = new SifarnikUcesnika();
                        SifarnikPozicija sp = new SifarnikPozicija();
                        su.SifraKorisnika = k.KorisnikID;
                        sp = cmbPozicija.SelectedItem as SifarnikPozicija;
                        su.SifraProjekta = p.ProjekatID;
                        su.SifraPozicije = sp.SifarnikPID;
                        su.NazivPozicijeUcesnika = sp.NazivPozicije;
                        su.ImeUcesnika = k.Ime;
                        su.PrezimeUcesnika = k.Prezime;
                        su.NazivProjektaUcesnika = txtNazivProjekta.Text;
                        listaUcesnika.Add(su);
                    }
                    else MessageBox.Show("Korisnik je već u listi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali korisnika sistema!");
            }
        }

        private void btnObrisiUcesnikaIzListe_Click(object sender, EventArgs e)
        {
            try
            {
                SifarnikUcesnika su = dgvSpisakUcesnika.SelectedRows[0].DataBoundItem as SifarnikUcesnika;
                listaUcesnika.Remove(su);
            }
            catch (Exception)
            {

                MessageBox.Show("Niste izabrali korisnika!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            p.ProjekatID = ki.vratiSifruProjekta(txtNazivProjekta.Text);
            ki.obrisiProjekat(p);
            this.Close();
        }
        
    }
}
