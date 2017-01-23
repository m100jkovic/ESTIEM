using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FormaUnosKorisnika : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();

        public FormaUnosKorisnika()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnKreirajKorisnika_Click(object sender, EventArgs e)
        { 
            if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Greška! Sistem ne može da kreira novog korisnika sistema.");
                MessageBox.Show("Morate uneti username i password!");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            } else 
            {
                bool rezultat = ki.ubaciKorisnika(txtUsername, txtPassword, cmbPrivilegija);
                if (rezultat)
                {
                    MessageBox.Show("Sistem je kreirao novog korisnika");
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    cmbPrivilegija.Enabled = false;
                    gbInformacije.Visible = true;
                    this.ControlBox = false;
                }
                else
                {
                    MessageBox.Show("Greška! Sistem ne može da kreira novog korisnika!");
                }
            } 
        }

        private void btnZapamtiKorisnika_Click(object sender, EventArgs e)
        {
            if (txtIme.Text.Equals(""))
            {
                MessageBox.Show("Greška! Korisnik nije zapamćen.");
                MessageBox.Show("Ime korisnika ne sme biti prazno!");
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
                    bool rezultat2 = ki.obrisiKorisnika(txtUsername);
                    this.Close();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (txtUsername.Enabled == false)
            {
                bool rezultat = ki.obrisiKorisnika(txtUsername);
            }
            this.Close();
        }

    }
}
