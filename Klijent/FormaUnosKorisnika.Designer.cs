namespace Klijent
{
    partial class FormaUnosKorisnika
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnZapamtiKorisnika = new System.Windows.Forms.Button();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbInformacije = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKreirajKorisnika = new System.Windows.Forms.Button();
            this.cmbPrivilegija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInformacije.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(26, 180);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnZapamtiKorisnika
            // 
            this.btnZapamtiKorisnika.Location = new System.Drawing.Point(210, 180);
            this.btnZapamtiKorisnika.Name = "btnZapamtiKorisnika";
            this.btnZapamtiKorisnika.Size = new System.Drawing.Size(102, 23);
            this.btnZapamtiKorisnika.TabIndex = 7;
            this.btnZapamtiKorisnika.Text = "Zapamti korisnika";
            this.btnZapamtiKorisnika.UseVisualStyleBackColor = true;
            this.btnZapamtiKorisnika.Click += new System.EventHandler(this.btnZapamtiKorisnika_Click);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(112, 138);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(200, 20);
            this.txtBrojTelefona.TabIndex = 11;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(112, 49);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(112, 22);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 7;
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
            this.cmbGodina.Location = new System.Drawing.Point(112, 78);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(200, 21);
            this.cmbGodina.TabIndex = 10;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(112, 108);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumRodjenja.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Broj telefona";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Datum rodjenja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Godina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ime";
            // 
            // gbInformacije
            // 
            this.gbInformacije.Controls.Add(this.btnOdustani);
            this.gbInformacije.Controls.Add(this.btnZapamtiKorisnika);
            this.gbInformacije.Controls.Add(this.txtBrojTelefona);
            this.gbInformacije.Controls.Add(this.cmbGodina);
            this.gbInformacije.Controls.Add(this.dtpDatumRodjenja);
            this.gbInformacije.Controls.Add(this.txtPrezime);
            this.gbInformacije.Controls.Add(this.txtIme);
            this.gbInformacije.Controls.Add(this.label8);
            this.gbInformacije.Controls.Add(this.label7);
            this.gbInformacije.Controls.Add(this.label6);
            this.gbInformacije.Controls.Add(this.label5);
            this.gbInformacije.Controls.Add(this.label4);
            this.gbInformacije.Location = new System.Drawing.Point(29, 191);
            this.gbInformacije.Name = "gbInformacije";
            this.gbInformacije.Size = new System.Drawing.Size(343, 223);
            this.gbInformacije.TabIndex = 3;
            this.gbInformacije.TabStop = false;
            this.gbInformacije.Text = "Informacije o korisniku";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKreirajKorisnika);
            this.groupBox1.Controls.Add(this.cmbPrivilegija);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o nalogu";
            // 
            // btnKreirajKorisnika
            // 
            this.btnKreirajKorisnika.Location = new System.Drawing.Point(210, 124);
            this.btnKreirajKorisnika.Name = "btnKreirajKorisnika";
            this.btnKreirajKorisnika.Size = new System.Drawing.Size(102, 23);
            this.btnKreirajKorisnika.TabIndex = 6;
            this.btnKreirajKorisnika.Text = "Kreiraj korisnika";
            this.btnKreirajKorisnika.UseVisualStyleBackColor = true;
            this.btnKreirajKorisnika.Click += new System.EventHandler(this.btnKreirajKorisnika_Click);
            // 
            // cmbPrivilegija
            // 
            this.cmbPrivilegija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilegija.FormattingEnabled = true;
            this.cmbPrivilegija.Items.AddRange(new object[] {
            "Administrator",
            "Običan korisnik"});
            this.cmbPrivilegija.Location = new System.Drawing.Point(112, 81);
            this.cmbPrivilegija.Name = "cmbPrivilegija";
            this.cmbPrivilegija.Size = new System.Drawing.Size(200, 21);
            this.cmbPrivilegija.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Privilegija";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // FormaUnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInformacije);
            this.Name = "FormaUnosKorisnika";
            this.Text = "Dodaj korisnika";
            this.gbInformacije.ResumeLayout(false);
            this.gbInformacije.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnZapamtiKorisnika;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbInformacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKreirajKorisnika;
        private System.Windows.Forms.ComboBox cmbPrivilegija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}