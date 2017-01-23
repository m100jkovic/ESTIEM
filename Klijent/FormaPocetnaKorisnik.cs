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
    public partial class FormaPocetnaKorisnik : Form
    {
        Korisnik korisnik;
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();

        public FormaPocetnaKorisnik(Korisnik korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program \"Sistem za evidenciju projekata studentske organizacije ESTIEM\" je napravljen za potrebe predmeta \"Projektovanje softvera\". Milan Stojković 142/09/I");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormaPocetnaKorisnik_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gbAktivniProjekti.Visible = false;
        }

        private void projektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korisnik korisnikPopunjavanje = ki.popuniKorisnika(korisnik);
            ki.vratiSveProjekteZaKorisnika(korisnikPopunjavanje, dgvAktivniProjekti);
            gbAktivniProjekti.Visible = true;
        }
    }
}
