namespace Klijent
{
    partial class FormaIzmenaKorisnika
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
            this.btnPrikaziKorisnika = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPronadjiKorisnike = new System.Windows.Forms.Button();
            this.dgvListaKorisnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaIme = new System.Windows.Forms.TextBox();
            this.btnSacuvajPodatke = new System.Windows.Forms.Button();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.cmbPrivilegija = new System.Windows.Forms.ComboBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPodaciOKorisniku = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKorisnika)).BeginInit();
            this.gbPodaciOKorisniku.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikaziKorisnika
            // 
            this.btnPrikaziKorisnika.Location = new System.Drawing.Point(249, 238);
            this.btnPrikaziKorisnika.Name = "btnPrikaziKorisnika";
            this.btnPrikaziKorisnika.Size = new System.Drawing.Size(118, 23);
            this.btnPrikaziKorisnika.TabIndex = 4;
            this.btnPrikaziKorisnika.Text = "Prikaži korisnika";
            this.btnPrikaziKorisnika.UseVisualStyleBackColor = true;
            this.btnPrikaziKorisnika.Click += new System.EventHandler(this.btnPrikaziKorisnika_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrikaziKorisnika);
            this.groupBox2.Controls.Add(this.btnPronadjiKorisnike);
            this.groupBox2.Controls.Add(this.dgvListaKorisnika);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPretragaIme);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 278);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga korisnika";
            // 
            // btnPronadjiKorisnike
            // 
            this.btnPronadjiKorisnike.Location = new System.Drawing.Point(249, 43);
            this.btnPronadjiKorisnike.Name = "btnPronadjiKorisnike";
            this.btnPronadjiKorisnike.Size = new System.Drawing.Size(118, 23);
            this.btnPronadjiKorisnike.TabIndex = 2;
            this.btnPronadjiKorisnike.Text = "Pronađi";
            this.btnPronadjiKorisnike.UseVisualStyleBackColor = true;
            this.btnPronadjiKorisnike.Click += new System.EventHandler(this.btnPronadjiKorisnike_Click);
            // 
            // dgvListaKorisnika
            // 
            this.dgvListaKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKorisnika.Location = new System.Drawing.Point(19, 85);
            this.dgvListaKorisnika.Name = "dgvListaKorisnika";
            this.dgvListaKorisnika.Size = new System.Drawing.Size(348, 128);
            this.dgvListaKorisnika.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime korisnika čiji se podaci menjaju:";
            // 
            // txtPretragaIme
            // 
            this.txtPretragaIme.Location = new System.Drawing.Point(19, 45);
            this.txtPretragaIme.Name = "txtPretragaIme";
            this.txtPretragaIme.Size = new System.Drawing.Size(197, 20);
            this.txtPretragaIme.TabIndex = 1;
            // 
            // btnSacuvajPodatke
            // 
            this.btnSacuvajPodatke.Location = new System.Drawing.Point(313, 238);
            this.btnSacuvajPodatke.Name = "btnSacuvajPodatke";
            this.btnSacuvajPodatke.Size = new System.Drawing.Size(121, 23);
            this.btnSacuvajPodatke.TabIndex = 16;
            this.btnSacuvajPodatke.Text = "Sačuvaj podatke";
            this.btnSacuvajPodatke.UseVisualStyleBackColor = true;
            this.btnSacuvajPodatke.Click += new System.EventHandler(this.btnSacuvajPodatke_Click);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(99, 161);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(121, 20);
            this.txtBrojTelefona.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Datum rođenja";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(99, 196);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRodjenja.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Broj telefona";
            // 
            // cmbGodina
            // 
            this.cmbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Items.AddRange(new object[] {
            "Prva",
            "Druga",
            "Treća",
            "Četvrta",
            "Apsolvent",
            "Master"});
            this.cmbGodina.Location = new System.Drawing.Point(313, 123);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(121, 21);
            this.cmbGodina.TabIndex = 11;
            // 
            // cmbPrivilegija
            // 
            this.cmbPrivilegija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilegija.FormattingEnabled = true;
            this.cmbPrivilegija.Items.AddRange(new object[] {
            "Administrator",
            "Običan korisnik"});
            this.cmbPrivilegija.Location = new System.Drawing.Point(99, 123);
            this.cmbPrivilegija.Name = "cmbPrivilegija";
            this.cmbPrivilegija.Size = new System.Drawing.Size(121, 21);
            this.cmbPrivilegija.TabIndex = 10;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(313, 85);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(121, 20);
            this.txtPrezime.TabIndex = 9;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(99, 85);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(121, 20);
            this.txtIme.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(313, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(99, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Godina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Privilegija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // gbPodaciOKorisniku
            // 
            this.gbPodaciOKorisniku.Controls.Add(this.btnSacuvajPodatke);
            this.gbPodaciOKorisniku.Controls.Add(this.txtBrojTelefona);
            this.gbPodaciOKorisniku.Controls.Add(this.label9);
            this.gbPodaciOKorisniku.Controls.Add(this.dtpDatumRodjenja);
            this.gbPodaciOKorisniku.Controls.Add(this.label8);
            this.gbPodaciOKorisniku.Controls.Add(this.cmbGodina);
            this.gbPodaciOKorisniku.Controls.Add(this.cmbPrivilegija);
            this.gbPodaciOKorisniku.Controls.Add(this.txtPrezime);
            this.gbPodaciOKorisniku.Controls.Add(this.txtIme);
            this.gbPodaciOKorisniku.Controls.Add(this.txtPassword);
            this.gbPodaciOKorisniku.Controls.Add(this.txtUsername);
            this.gbPodaciOKorisniku.Controls.Add(this.label7);
            this.gbPodaciOKorisniku.Controls.Add(this.label6);
            this.gbPodaciOKorisniku.Controls.Add(this.label5);
            this.gbPodaciOKorisniku.Controls.Add(this.label4);
            this.gbPodaciOKorisniku.Controls.Add(this.label3);
            this.gbPodaciOKorisniku.Controls.Add(this.label2);
            this.gbPodaciOKorisniku.Location = new System.Drawing.Point(415, 12);
            this.gbPodaciOKorisniku.Name = "gbPodaciOKorisniku";
            this.gbPodaciOKorisniku.Size = new System.Drawing.Size(454, 278);
            this.gbPodaciOKorisniku.TabIndex = 6;
            this.gbPodaciOKorisniku.TabStop = false;
            this.gbPodaciOKorisniku.Text = "Podaci o korisniku";
            // 
            // FormaIzmenaKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPodaciOKorisniku);
            this.Name = "FormaIzmenaKorisnika";
            this.Text = "Izmena korisnika";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKorisnika)).EndInit();
            this.gbPodaciOKorisniku.ResumeLayout(false);
            this.gbPodaciOKorisniku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziKorisnika;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPronadjiKorisnike;
        private System.Windows.Forms.DataGridView dgvListaKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaIme;
        private System.Windows.Forms.Button btnSacuvajPodatke;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.ComboBox cmbPrivilegija;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPodaciOKorisniku;

    }
}