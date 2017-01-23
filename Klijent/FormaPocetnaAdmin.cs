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
    public partial class FormaPocetnaAdmin : Form
    {
        public FormaPocetnaAdmin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormaUnosKorisnika().ShowDialog();
        }

        private void izmeniKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormaIzmenaKorisnika().ShowDialog();
        }

        private void aktivnostiKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormaPregledAktivnostiKorisnika().ShowDialog();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program \"Sistem za evidenciju projekata studentske organizacije ESTIEM\" je napravljen za potrebe predmeta \"Projektovanje softvera\". Milan Stojković 142/09/I");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unosProjektaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormaUnosProjekta().ShowDialog();
        }

        private void izmenaProjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormaIzmenaProjekta().ShowDialog();
        }

        private void učesniciNaProjektuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormaIzmenaUcesnikaProjekta().ShowDialog();
        }

    }
}
