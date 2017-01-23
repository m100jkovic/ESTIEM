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
    public partial class FormaIzmenaKorisnika : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();

        public FormaIzmenaKorisnika()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnPronadjiKorisnike_Click(object sender, EventArgs e)
        {
            ki.vratiSveKorisnikePoImenu(txtPretragaIme, dgvListaKorisnika);
        }

        private void btnPrikaziKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                Korisnik k = new Korisnik();
                k = dgvListaKorisnika.SelectedRows[0].DataBoundItem as Korisnik;
                txtUsername.Text = k.Username;
                txtPassword.Text = k.Password;
                txtIme.Text = k.Ime;
                txtPrezime.Text = k.Prezime;
                switch (k.Privilegija)
                {
                    case 0: cmbPrivilegija.SelectedIndex = 0;
                        break;
                    case 1: cmbPrivilegija.SelectedIndex = 1;
                        break;
                }
                switch (k.GodinaStudija)
                {
                    case "Prva": cmbGodina.SelectedIndex = 0;
                        break;
                    case "Druga": cmbGodina.SelectedIndex = 1;
                        break;
                    case "Treća": cmbGodina.SelectedIndex = 2;
                        break;
                    case "Četvrta": cmbGodina.SelectedIndex = 3;
                        break;
                    case "Apsolvent": cmbGodina.SelectedIndex = 4;
                        break;
                    case "Master": cmbGodina.SelectedIndex = 5;
                        break;
                }

                dtpDatumRodjenja.Value = k.DatumRodjenja;
                txtBrojTelefona.Text = k.BrojTelefona;
                gbPodaciOKorisniku.Visible = true;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                MessageBox.Show("Sistem je pronašao korisnika sistema po zadatoj vrednosti");

            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali korisnika sistema!");
            }
        }

        private void btnSacuvajPodatke_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals("") || txtIme.Text.Equals(""))
            {
                MessageBox.Show("Morate uneti username/password/Ime!");
                MessageBox.Show("Sistem ne može da zapamti unete izmene o korisniku");
            }
            else
            {
                bool rezultat = ki.izmeniKorisnika(txtUsername, txtPassword, txtIme, txtPrezime, cmbGodina, dtpDatumRodjenja, txtBrojTelefona);
                if (rezultat)
                {
                    MessageBox.Show("Uspešno unesen korisnik");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unos korisnika nije uspeo!");
                }
            }
        }
    }
}
