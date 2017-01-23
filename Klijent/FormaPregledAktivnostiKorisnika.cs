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
    public partial class FormaPregledAktivnostiKorisnika : Form
    {
        Komunikacija k = new Komunikacija();
        KontrolerKI ki = new KontrolerKI();

        public FormaPregledAktivnostiKorisnika()
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
                ki.vratiSveProjekteZaKorisnika(k, dgvPodaci);
                //List<SifarnikUcesnika> lista = 
            }
            catch (Exception)
            {
                MessageBox.Show("Niste izabrali korisnika sistema!");
            }

            /*
            try
            {
                
                List<SifarnikUcesnika> lista = Broker.DajSesiju().PrikaziSveAktivnostiKorisnika(k);
                if (lista.Count > 0)
                {
                    dgvPodaci.DataSource = lista;
                    gbPodaciOKorisniku.Visible = true;
                    MessageBox.Show("Sistem je našao projekte po zadatoj vrednosti");
                }
                else MessageBox.Show("Sistem ne može da pronađe projekte po zadatoj vrednosti");
            }
            catch (Exception)
            {
                
            }
             * */
        }
    }
}
