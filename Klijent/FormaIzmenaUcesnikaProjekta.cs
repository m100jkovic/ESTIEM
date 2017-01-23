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
    public partial class FormaIzmenaUcesnikaProjekta : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();
        Projekat p;
        Korisnik korisnik;
        SifarnikUcesnika su;

        public FormaIzmenaUcesnikaProjekta()
        {
            InitializeComponent();
            p = new Projekat();
            korisnik = new Korisnik();
            su = new SifarnikUcesnika();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormaIzmenaUcesnikaProjekta_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gbPodaciOUcestvovanju.Visible = false;
            cmbNovaPozicija.DataSource = ki.vratiSifarnikPozicija();
            //cmbNovaPozicija.DisplayMember = "NazivPozicije";
            cmbNovaPozicija.SelectedIndex = -1;
            dgvListaKorisnika.Visible = false;
            dgvListaProjekta.VirtualMode = false;
            dgvListaKorisnika.VirtualMode = false;
            btnPrikaziUcesnikeProjekta.Visible = false;
            btnPrikaziPodatkeUcestvovanja.Visible = false;
        }

        private void btnPretraziProjekte_Click(object sender, EventArgs e)
        {
            gbPodaciOUcestvovanju.Visible = false;
            ki.vratiProjektePoImenu(txtPretragaNaziv, dgvListaProjekta);

            if (dgvListaProjekta.Rows.Count > 0)
            {
                dgvListaProjekta.Visible = true;
                btnPrikaziUcesnikeProjekta.Visible = true;
                MessageBox.Show("Sistem je pronašao projekte po zadatoj vrednosti");
            }
            else
            {
                MessageBox.Show("Sistem ne može da pronađe projekte po zadatoj vrednosti");
                txtPretragaNaziv.Clear();
                txtPretragaNaziv.Focus();
                dgvListaProjekta.Visible = false;
            }
        }

        private void btnPrikaziUcesnikeProjekta_Click(object sender, EventArgs e)
        {
            try
            {
                p = dgvListaProjekta.SelectedRows[0].DataBoundItem as Projekat;  
                ki.prikaziUcesnikeProjekta(p, dgvListaKorisnika);

                MessageBox.Show("Sistem je pronašao učesnike na projektu");
                dgvListaKorisnika.Visible = true;
                btnPrikaziPodatkeUcestvovanja.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali projekat!");
                MessageBox.Show("Sistem ne može da pronađe učesnike na izabranom projektu");
            }
        }

        private void btnPrikaziPodatkeUcestvovanja_Click(object sender, EventArgs e)
        {
            cmbNovaPozicija.SelectedIndex = -1;
            try
            {
                SifarnikUcesnika su = dgvListaKorisnika.SelectedRows[0].DataBoundItem as SifarnikUcesnika;
                bool rezultat = ki.vratiAktivnostUcesnikaNaProjektu(su.SifraKorisnika, su.SifraProjekta, txtSifraUcestvovanja, txtSifraKorisnika, txtSifraProjekta, txtStaraPozicija);
                gbPodaciOUcestvovanju.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali učesnika");
                MessageBox.Show("Sistem ne može da prikaže učesnika na izabranom projektu");
            }
        }

        private void btnSacuvajPodatke_Click(object sender, EventArgs e)
        {
            bool rezultat = ki.izmeniUcestvovanje(cmbNovaPozicija, txtSifraUcestvovanja);
            if (rezultat)
            {
                MessageBox.Show("Podaci o učesniku projekta su uspešno sačuvani");
                gbPodaciOUcestvovanju.Visible = false;
            }
            else MessageBox.Show("Sistem ne može da zapamti podatke o učestvovanju na projektu");
        }

        private void btnObrisiUcesnikaProjekta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete učesnika projekta? Svi podaci o učesniku na tom projektu će biti trajno uklonjeni!", "Brisanje učesnika na projektu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool rezultat = ki.obrisiUcestvovanje(txtSifraUcestvovanja);
                if (rezultat)
                {
                    MessageBox.Show("Učesnik projekta je uspešno izbrisan");
                    this.Close();
                }
                else MessageBox.Show("Sistem ne može da izbriše učesnika na projektu");
            }
        }

        
    }
}
