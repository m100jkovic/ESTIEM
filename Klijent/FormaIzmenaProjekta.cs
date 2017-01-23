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
    public partial class FormaIzmenaProjekta : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();
        Projekat p;

        public FormaIzmenaProjekta()
        {
            InitializeComponent();
            p = new Projekat();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormaIzmenaProjekta_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gbPodaciOProjektu.Visible = false;
            dgvListaProjekta.Visible = false;
            btnPrikaziProjekat.Visible = false;
        }

        private void btnPretraziProjekte_Click(object sender, EventArgs e)
        {
            gbPodaciOProjektu.Visible = false;
            ki.vratiProjektePoImenu(txtPretragaNaziv, dgvListaProjekta);

            if (dgvListaProjekta.Rows.Count > 0)
            {
                dgvListaProjekta.Visible = true;
                btnPrikaziProjekat.Visible = true;
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

        private void btnPrikaziProjekat_Click(object sender, EventArgs e)
        {
            try
            {
                p = dgvListaProjekta.SelectedRows[0].DataBoundItem as Projekat;
                txtNazivProjekta.Text = p.NazivProjekta;
                switch (p.VrstaProjekta)
                {
                    case "Studija slučaja": cmbVrstaProjekta.SelectedIndex = 0;
                        break;
                    case "Seminar": cmbVrstaProjekta.SelectedIndex = 1;
                        break;
                    case "Konferencija": cmbVrstaProjekta.SelectedIndex = 2;
                        break;
                    case "Razmena studenata": cmbVrstaProjekta.SelectedIndex = 3;
                        break;
                    case "Ostalo": cmbVrstaProjekta.SelectedIndex = 4;
                        break;
                }
                txtGeneralniSponzor.Text = p.GeneralniSponzor;
                txtBudzet.Text = p.Budzet.ToString();
                txtMestoOdrzavanja.Text = p.MestoOdrzavanja;
                dtpDatumOdrzavanja.Value = p.DatumOdrzavanja;
                gbPodaciOProjektu.Visible = true;
                txtNazivProjekta.Enabled = false;
                MessageBox.Show("Sistem je pronašao projekat po zadatoj vrednosti");

            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali projekat za izmenu!");
                MessageBox.Show("Sistem ne može da prikaže projekat");
            }
        }

        private void btnSacuvajPodatke_Click(object sender, EventArgs e)
        {
            bool rezultat = ki.izmeniProjekat(txtNazivProjekta, cmbVrstaProjekta, txtGeneralniSponzor, txtBudzet, txtMestoOdrzavanja, dtpDatumOdrzavanja);
            if (rezultat)
            {
                MessageBox.Show("Izabrani projekat je uspešno izmenjen");
                this.Close();
            }
            else MessageBox.Show("Brisanje nije uspelo");
        }

        private void btnObrisiProjekat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete projekat? Svi podaci o projektu će biti trajno uklonjeni!", "Brisanje projekta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Projekat p = new Projekat();
                p.ProjekatID = ki.vratiSifruProjekta(txtNazivProjekta.Text);
                bool rezultat = ki.obrisiProjekat(p);
                if (!rezultat) MessageBox.Show("Brisanje nije uspelo");
                else
                {
                    MessageBox.Show("Izabrani projekat je uspešno obrisan");
                    this.Close();
                }
            }
        }
    }
}
