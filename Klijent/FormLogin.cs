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
    public partial class FormLogin : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();

        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            // 0: admin, 1: korisnik
            int rezultat = ki.ulogujSe(txtUsername, txtPassword);
            if (rezultat == 0)
            {
                this.Hide();
                MessageBox.Show("Uspešno ste se prijavili na sistem");
                new FormaPocetnaAdmin().ShowDialog();
            }
            else if (rezultat == 1)
            {
                this.Hide();
                MessageBox.Show("Uspešno ste se prijavili na sistem");
                Korisnik k = new Korisnik();
                k.Username = txtUsername.Text;
                k.Password = txtPassword.Text;
                new FormaPocetnaKorisnik(k).ShowDialog();
            }
            else
            {
                MessageBox.Show("Neuspesna kombinacija user/pass");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            poveziSeSaServerom();
        }

        private void poveziSeSaServerom()
        {
            k = new Komunikacija();
            if (!ki.poveziSeSaServerom())
            {
                this.Close();
                Application.Exit();
            }
        }
        
    }
}
