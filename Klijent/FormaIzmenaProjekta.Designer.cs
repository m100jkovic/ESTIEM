namespace Klijent
{
    partial class FormaIzmenaProjekta
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
            this.btnObrisiProjekat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMestoOdrzavanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPodaciOProjektu = new System.Windows.Forms.GroupBox();
            this.btnSacuvajPodatke = new System.Windows.Forms.Button();
            this.txtBudzet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatumOdrzavanja = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVrstaProjekta = new System.Windows.Forms.ComboBox();
            this.txtGeneralniSponzor = new System.Windows.Forms.TextBox();
            this.txtNazivProjekta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrikaziProjekat = new System.Windows.Forms.Button();
            this.btnPretraziProjekte = new System.Windows.Forms.Button();
            this.dgvListaProjekta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPretragaProjekta = new System.Windows.Forms.GroupBox();
            this.txtPretragaNaziv = new System.Windows.Forms.TextBox();
            this.gbPodaciOProjektu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProjekta)).BeginInit();
            this.gbPretragaProjekta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObrisiProjekat
            // 
            this.btnObrisiProjekat.Location = new System.Drawing.Point(21, 238);
            this.btnObrisiProjekat.Name = "btnObrisiProjekat";
            this.btnObrisiProjekat.Size = new System.Drawing.Size(118, 23);
            this.btnObrisiProjekat.TabIndex = 5;
            this.btnObrisiProjekat.Text = "Obriši projekat";
            this.btnObrisiProjekat.UseVisualStyleBackColor = true;
            this.btnObrisiProjekat.Click += new System.EventHandler(this.btnObrisiProjekat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mesto održavanja";
            // 
            // txtMestoOdrzavanja
            // 
            this.txtMestoOdrzavanja.Location = new System.Drawing.Point(115, 132);
            this.txtMestoOdrzavanja.Name = "txtMestoOdrzavanja";
            this.txtMestoOdrzavanja.Size = new System.Drawing.Size(202, 20);
            this.txtMestoOdrzavanja.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Naziv";
            // 
            // gbPodaciOProjektu
            // 
            this.gbPodaciOProjektu.Controls.Add(this.btnObrisiProjekat);
            this.gbPodaciOProjektu.Controls.Add(this.label2);
            this.gbPodaciOProjektu.Controls.Add(this.txtMestoOdrzavanja);
            this.gbPodaciOProjektu.Controls.Add(this.btnSacuvajPodatke);
            this.gbPodaciOProjektu.Controls.Add(this.txtBudzet);
            this.gbPodaciOProjektu.Controls.Add(this.label9);
            this.gbPodaciOProjektu.Controls.Add(this.dtpDatumOdrzavanja);
            this.gbPodaciOProjektu.Controls.Add(this.label8);
            this.gbPodaciOProjektu.Controls.Add(this.cmbVrstaProjekta);
            this.gbPodaciOProjektu.Controls.Add(this.txtGeneralniSponzor);
            this.gbPodaciOProjektu.Controls.Add(this.txtNazivProjekta);
            this.gbPodaciOProjektu.Controls.Add(this.label6);
            this.gbPodaciOProjektu.Controls.Add(this.label5);
            this.gbPodaciOProjektu.Controls.Add(this.label4);
            this.gbPodaciOProjektu.Location = new System.Drawing.Point(415, 12);
            this.gbPodaciOProjektu.Name = "gbPodaciOProjektu";
            this.gbPodaciOProjektu.Size = new System.Drawing.Size(454, 278);
            this.gbPodaciOProjektu.TabIndex = 8;
            this.gbPodaciOProjektu.TabStop = false;
            this.gbPodaciOProjektu.Text = "Podaci o projektu";
            // 
            // btnSacuvajPodatke
            // 
            this.btnSacuvajPodatke.Location = new System.Drawing.Point(315, 238);
            this.btnSacuvajPodatke.Name = "btnSacuvajPodatke";
            this.btnSacuvajPodatke.Size = new System.Drawing.Size(121, 23);
            this.btnSacuvajPodatke.TabIndex = 16;
            this.btnSacuvajPodatke.Text = "Sačuvaj podatke";
            this.btnSacuvajPodatke.UseVisualStyleBackColor = true;
            this.btnSacuvajPodatke.Click += new System.EventHandler(this.btnSacuvajPodatke_Click);
            // 
            // txtBudzet
            // 
            this.txtBudzet.Location = new System.Drawing.Point(317, 90);
            this.txtBudzet.Name = "txtBudzet";
            this.txtBudzet.Size = new System.Drawing.Size(121, 20);
            this.txtBudzet.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Datum održavanja";
            // 
            // dtpDatumOdrzavanja
            // 
            this.dtpDatumOdrzavanja.Location = new System.Drawing.Point(117, 170);
            this.dtpDatumOdrzavanja.Name = "dtpDatumOdrzavanja";
            this.dtpDatumOdrzavanja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumOdrzavanja.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Budžet";
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
            this.cmbVrstaProjekta.Location = new System.Drawing.Point(317, 44);
            this.cmbVrstaProjekta.Name = "cmbVrstaProjekta";
            this.cmbVrstaProjekta.Size = new System.Drawing.Size(121, 21);
            this.cmbVrstaProjekta.TabIndex = 10;
            // 
            // txtGeneralniSponzor
            // 
            this.txtGeneralniSponzor.Location = new System.Drawing.Point(115, 90);
            this.txtGeneralniSponzor.Name = "txtGeneralniSponzor";
            this.txtGeneralniSponzor.Size = new System.Drawing.Size(121, 20);
            this.txtGeneralniSponzor.TabIndex = 9;
            // 
            // txtNazivProjekta
            // 
            this.txtNazivProjekta.Location = new System.Drawing.Point(115, 45);
            this.txtNazivProjekta.Name = "txtNazivProjekta";
            this.txtNazivProjekta.Size = new System.Drawing.Size(121, 20);
            this.txtNazivProjekta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gen. sponzor";
            // 
            // btnPrikaziProjekat
            // 
            this.btnPrikaziProjekat.Location = new System.Drawing.Point(249, 238);
            this.btnPrikaziProjekat.Name = "btnPrikaziProjekat";
            this.btnPrikaziProjekat.Size = new System.Drawing.Size(118, 23);
            this.btnPrikaziProjekat.TabIndex = 4;
            this.btnPrikaziProjekat.Text = "Prikaži projekat";
            this.btnPrikaziProjekat.UseVisualStyleBackColor = true;
            this.btnPrikaziProjekat.Click += new System.EventHandler(this.btnPrikaziProjekat_Click);
            // 
            // btnPretraziProjekte
            // 
            this.btnPretraziProjekte.Location = new System.Drawing.Point(249, 43);
            this.btnPretraziProjekte.Name = "btnPretraziProjekte";
            this.btnPretraziProjekte.Size = new System.Drawing.Size(118, 23);
            this.btnPretraziProjekte.TabIndex = 2;
            this.btnPretraziProjekte.Text = "Pronađi";
            this.btnPretraziProjekte.UseVisualStyleBackColor = true;
            this.btnPretraziProjekte.Click += new System.EventHandler(this.btnPretraziProjekte_Click);
            // 
            // dgvListaProjekta
            // 
            this.dgvListaProjekta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProjekta.Location = new System.Drawing.Point(19, 85);
            this.dgvListaProjekta.Name = "dgvListaProjekta";
            this.dgvListaProjekta.Size = new System.Drawing.Size(348, 128);
            this.dgvListaProjekta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv projekta čiji se podaci menjaju:";
            // 
            // gbPretragaProjekta
            // 
            this.gbPretragaProjekta.Controls.Add(this.btnPrikaziProjekat);
            this.gbPretragaProjekta.Controls.Add(this.btnPretraziProjekte);
            this.gbPretragaProjekta.Controls.Add(this.dgvListaProjekta);
            this.gbPretragaProjekta.Controls.Add(this.label1);
            this.gbPretragaProjekta.Controls.Add(this.txtPretragaNaziv);
            this.gbPretragaProjekta.Location = new System.Drawing.Point(12, 12);
            this.gbPretragaProjekta.Name = "gbPretragaProjekta";
            this.gbPretragaProjekta.Size = new System.Drawing.Size(384, 278);
            this.gbPretragaProjekta.TabIndex = 9;
            this.gbPretragaProjekta.TabStop = false;
            this.gbPretragaProjekta.Text = "Pretraga projekta";
            // 
            // txtPretragaNaziv
            // 
            this.txtPretragaNaziv.Location = new System.Drawing.Point(19, 45);
            this.txtPretragaNaziv.Name = "txtPretragaNaziv";
            this.txtPretragaNaziv.Size = new System.Drawing.Size(197, 20);
            this.txtPretragaNaziv.TabIndex = 1;
            // 
            // FormaIzmenaProjekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 307);
            this.Controls.Add(this.gbPodaciOProjektu);
            this.Controls.Add(this.gbPretragaProjekta);
            this.Name = "FormaIzmenaProjekta";
            this.Text = "Izmena projekta";
            this.Load += new System.EventHandler(this.FormaIzmenaProjekta_Load);
            this.gbPodaciOProjektu.ResumeLayout(false);
            this.gbPodaciOProjektu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProjekta)).EndInit();
            this.gbPretragaProjekta.ResumeLayout(false);
            this.gbPretragaProjekta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiProjekat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMestoOdrzavanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPodaciOProjektu;
        private System.Windows.Forms.Button btnSacuvajPodatke;
        private System.Windows.Forms.TextBox txtBudzet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatumOdrzavanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVrstaProjekta;
        private System.Windows.Forms.TextBox txtGeneralniSponzor;
        private System.Windows.Forms.TextBox txtNazivProjekta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrikaziProjekat;
        private System.Windows.Forms.Button btnPretraziProjekte;
        private System.Windows.Forms.DataGridView dgvListaProjekta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPretragaProjekta;
        private System.Windows.Forms.TextBox txtPretragaNaziv;
    }
}