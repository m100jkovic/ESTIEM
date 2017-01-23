namespace Klijent
{
    partial class FormaUnosProjekta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVrstaProjekta = new System.Windows.Forms.ComboBox();
            this.txtGeneralniSponzor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSpisakUcesnika = new System.Windows.Forms.DataGridView();
            this.btnDodajUListu = new System.Windows.Forms.Button();
            this.gbInformacijeOProjektu = new System.Windows.Forms.GroupBox();
            this.txtBudzet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDatumOdrzavanja = new System.Windows.Forms.DateTimePicker();
            this.txtMestoOdrzavanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbDodavanjeUcesnikaProjekta = new System.Windows.Forms.GroupBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnObrisiUcesnikaIzListe = new System.Windows.Forms.Button();
            this.btnSacuvajProjekatISpisakUcesnika = new System.Windows.Forms.Button();
            this.dgvListaKorisnika = new System.Windows.Forms.DataGridView();
            this.txtPretragaIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPronadjiKorisnike = new System.Windows.Forms.Button();
            this.cmbPozicija = new System.Windows.Forms.ComboBox();
            this.btnKreirajNoviProjekat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakUcesnika)).BeginInit();
            this.gbInformacijeOProjektu.SuspendLayout();
            this.gbDodavanjeUcesnikaProjekta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pozicija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generalni sponzor";
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(105, 41);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(179, 20);
            this.txtNazivProjekta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv projekta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vrsta projekta";
            // 
            // cmbVrstaProjekta
            // 
            this.cmbVrstaProjekta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrstaProjekta.FormattingEnabled = true;
            this.cmbVrstaProjekta.Items.AddRange(new object[] {
            "Studija slučaja",
            "Seminar",
            "Konferencija",
            "Razmena studenata",
            "Ostalo"});
            this.cmbVrstaProjekta.Location = new System.Drawing.Point(435, 41);
            this.cmbVrstaProjekta.Name = "cmbVrstaProjekta";
            this.cmbVrstaProjekta.Size = new System.Drawing.Size(179, 21);
            this.cmbVrstaProjekta.TabIndex = 4;
            // 
            // txtGeneralniSponzor
            // 
            this.txtGeneralniSponzor.Location = new System.Drawing.Point(105, 67);
            this.txtGeneralniSponzor.Name = "txtGeneralniSponzor";
            this.txtGeneralniSponzor.Size = new System.Drawing.Size(179, 20);
            this.txtGeneralniSponzor.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Budžet";
            // 
            // dgvSpisakUcesnika
            // 
            this.dgvSpisakUcesnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpisakUcesnika.Location = new System.Drawing.Point(10, 219);
            this.dgvSpisakUcesnika.Name = "dgvSpisakUcesnika";
            this.dgvSpisakUcesnika.Size = new System.Drawing.Size(604, 151);
            this.dgvSpisakUcesnika.TabIndex = 20;
            // 
            // btnDodajUListu
            // 
            this.btnDodajUListu.Location = new System.Drawing.Point(240, 177);
            this.btnDodajUListu.Name = "btnDodajUListu";
            this.btnDodajUListu.Size = new System.Drawing.Size(136, 23);
            this.btnDodajUListu.TabIndex = 19;
            this.btnDodajUListu.Text = "Dodaj u listu";
            this.btnDodajUListu.UseVisualStyleBackColor = true;
            this.btnDodajUListu.Click += new System.EventHandler(this.btnDodajUListu_Click);
            // 
            // gbInformacijeOProjektu
            // 
            this.gbInformacijeOProjektu.Controls.Add(this.label3);
            this.gbInformacijeOProjektu.Controls.Add(this.txtNazivProjekta);
            this.gbInformacijeOProjektu.Controls.Add(this.label1);
            this.gbInformacijeOProjektu.Controls.Add(this.label2);
            this.gbInformacijeOProjektu.Controls.Add(this.cmbVrstaProjekta);
            this.gbInformacijeOProjektu.Controls.Add(this.txtGeneralniSponzor);
            this.gbInformacijeOProjektu.Controls.Add(this.label4);
            this.gbInformacijeOProjektu.Controls.Add(this.txtBudzet);
            this.gbInformacijeOProjektu.Controls.Add(this.label5);
            this.gbInformacijeOProjektu.Controls.Add(this.dtpDatumOdrzavanja);
            this.gbInformacijeOProjektu.Controls.Add(this.txtMestoOdrzavanja);
            this.gbInformacijeOProjektu.Controls.Add(this.label6);
            this.gbInformacijeOProjektu.Location = new System.Drawing.Point(19, 12);
            this.gbInformacijeOProjektu.Name = "gbInformacijeOProjektu";
            this.gbInformacijeOProjektu.Size = new System.Drawing.Size(627, 144);
            this.gbInformacijeOProjektu.TabIndex = 24;
            this.gbInformacijeOProjektu.TabStop = false;
            this.gbInformacijeOProjektu.Text = "Informacije o projektu";
            // 
            // txtBudzet
            // 
            this.txtBudzet.Location = new System.Drawing.Point(435, 67);
            this.txtBudzet.Name = "txtBudzet";
            this.txtBudzet.Size = new System.Drawing.Size(179, 20);
            this.txtBudzet.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mesto održavanja";
            // 
            // dtpDatumOdrzavanja
            // 
            this.dtpDatumOdrzavanja.Location = new System.Drawing.Point(435, 93);
            this.dtpDatumOdrzavanja.Name = "dtpDatumOdrzavanja";
            this.dtpDatumOdrzavanja.Size = new System.Drawing.Size(179, 20);
            this.dtpDatumOdrzavanja.TabIndex = 12;
            // 
            // txtMestoOdrzavanja
            // 
            this.txtMestoOdrzavanja.Location = new System.Drawing.Point(105, 93);
            this.txtMestoOdrzavanja.Name = "txtMestoOdrzavanja";
            this.txtMestoOdrzavanja.Size = new System.Drawing.Size(179, 20);
            this.txtMestoOdrzavanja.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum održavanja";
            // 
            // gbDodavanjeUcesnikaProjekta
            // 
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.btnOdustani);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.btnObrisiUcesnikaIzListe);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.btnSacuvajProjekatISpisakUcesnika);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.dgvListaKorisnika);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.txtPretragaIme);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.dgvSpisakUcesnika);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.label7);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.btnDodajUListu);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.btnPronadjiKorisnike);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.cmbPozicija);
            this.gbDodavanjeUcesnikaProjekta.Controls.Add(this.label8);
            this.gbDodavanjeUcesnikaProjekta.Location = new System.Drawing.Point(19, 215);
            this.gbDodavanjeUcesnikaProjekta.Name = "gbDodavanjeUcesnikaProjekta";
            this.gbDodavanjeUcesnikaProjekta.Size = new System.Drawing.Size(627, 428);
            this.gbDodavanjeUcesnikaProjekta.TabIndex = 25;
            this.gbDodavanjeUcesnikaProjekta.TabStop = false;
            this.gbDodavanjeUcesnikaProjekta.Text = "Dodavanje učesnika projekta";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(10, 386);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(136, 23);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnObrisiUcesnikaIzListe
            // 
            this.btnObrisiUcesnikaIzListe.Location = new System.Drawing.Point(240, 386);
            this.btnObrisiUcesnikaIzListe.Name = "btnObrisiUcesnikaIzListe";
            this.btnObrisiUcesnikaIzListe.Size = new System.Drawing.Size(136, 23);
            this.btnObrisiUcesnikaIzListe.TabIndex = 22;
            this.btnObrisiUcesnikaIzListe.Text = "Ukloni učesnika iz liste";
            this.btnObrisiUcesnikaIzListe.UseVisualStyleBackColor = true;
            this.btnObrisiUcesnikaIzListe.Click += new System.EventHandler(this.btnObrisiUcesnikaIzListe_Click);
            // 
            // btnSacuvajProjekatISpisakUcesnika
            // 
            this.btnSacuvajProjekatISpisakUcesnika.Location = new System.Drawing.Point(478, 386);
            this.btnSacuvajProjekatISpisakUcesnika.Name = "btnSacuvajProjekatISpisakUcesnika";
            this.btnSacuvajProjekatISpisakUcesnika.Size = new System.Drawing.Size(136, 23);
            this.btnSacuvajProjekatISpisakUcesnika.TabIndex = 21;
            this.btnSacuvajProjekatISpisakUcesnika.Text = "Sačuvaj projekat i spisak";
            this.btnSacuvajProjekatISpisakUcesnika.UseVisualStyleBackColor = true;
            this.btnSacuvajProjekatISpisakUcesnika.Click += new System.EventHandler(this.btnSacuvajProjekatISpisakUcesnika_Click);
            // 
            // dgvListaKorisnika
            // 
            this.dgvListaKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKorisnika.Location = new System.Drawing.Point(10, 81);
            this.dgvListaKorisnika.Name = "dgvListaKorisnika";
            this.dgvListaKorisnika.Size = new System.Drawing.Size(604, 79);
            this.dgvListaKorisnika.TabIndex = 16;
            // 
            // txtPretragaIme
            // 
            this.txtPretragaIme.Location = new System.Drawing.Point(10, 41);
            this.txtPretragaIme.Name = "txtPretragaIme";
            this.txtPretragaIme.Size = new System.Drawing.Size(197, 20);
            this.txtPretragaIme.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ime korisnika:";
            // 
            // btnPronadjiKorisnike
            // 
            this.btnPronadjiKorisnike.Location = new System.Drawing.Point(240, 39);
            this.btnPronadjiKorisnike.Name = "btnPronadjiKorisnike";
            this.btnPronadjiKorisnike.Size = new System.Drawing.Size(136, 23);
            this.btnPronadjiKorisnike.TabIndex = 15;
            this.btnPronadjiKorisnike.Text = "Pronađi";
            this.btnPronadjiKorisnike.UseVisualStyleBackColor = true;
            this.btnPronadjiKorisnike.Click += new System.EventHandler(this.btnPronadjiKorisnike_Click);
            // 
            // cmbPozicija
            // 
            this.cmbPozicija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozicija.FormattingEnabled = true;
            this.cmbPozicija.Items.AddRange(new object[] {
            "Studija slučaja",
            "Seminar",
            "Konferencija",
            "Razmena studenata",
            "Ostalo"});
            this.cmbPozicija.Location = new System.Drawing.Point(56, 179);
            this.cmbPozicija.Name = "cmbPozicija";
            this.cmbPozicija.Size = new System.Drawing.Size(151, 21);
            this.cmbPozicija.TabIndex = 18;
            // 
            // btnKreirajNoviProjekat
            // 
            this.btnKreirajNoviProjekat.Location = new System.Drawing.Point(186, 162);
            this.btnKreirajNoviProjekat.Name = "btnKreirajNoviProjekat";
            this.btnKreirajNoviProjekat.Size = new System.Drawing.Size(278, 23);
            this.btnKreirajNoviProjekat.TabIndex = 23;
            this.btnKreirajNoviProjekat.Text = "Kreiraj novi projekat";
            this.btnKreirajNoviProjekat.UseVisualStyleBackColor = true;
            this.btnKreirajNoviProjekat.Click += new System.EventHandler(this.btnKreirajNoviProjekat_Click);
            // 
            // FormaUnosProjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 658);
            this.Controls.Add(this.gbInformacijeOProjektu);
            this.Controls.Add(this.gbDodavanjeUcesnikaProjekta);
            this.Controls.Add(this.btnKreirajNoviProjekat);
            this.Name = "FormaUnosProjekta";
            this.Text = "Unos projekta";
            this.Load += new System.EventHandler(this.FormaUnosProjekta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpisakUcesnika)).EndInit();
            this.gbInformacijeOProjektu.ResumeLayout(false);
            this.gbInformacijeOProjektu.PerformLayout();
            this.gbDodavanjeUcesnikaProjekta.ResumeLayout(false);
            this.gbDodavanjeUcesnikaProjekta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKorisnika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVrstaProjekta;
        private System.Windows.Forms.TextBox txtGeneralniSponzor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSpisakUcesnika;
        private System.Windows.Forms.Button btnDodajUListu;
        private System.Windows.Forms.GroupBox gbInformacijeOProjektu;
        private System.Windows.Forms.TextBox txtBudzet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDatumOdrzavanja;
        private System.Windows.Forms.TextBox txtMestoOdrzavanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbDodavanjeUcesnikaProjekta;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnObrisiUcesnikaIzListe;
        private System.Windows.Forms.Button btnSacuvajProjekatISpisakUcesnika;
        private System.Windows.Forms.DataGridView dgvListaKorisnika;
        private System.Windows.Forms.TextBox txtPretragaIme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPronadjiKorisnike;
        private System.Windows.Forms.ComboBox cmbPozicija;
        private System.Windows.Forms.Button btnKreirajNoviProjekat;
    }
}