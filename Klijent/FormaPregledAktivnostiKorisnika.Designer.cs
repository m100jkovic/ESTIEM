namespace Klijent
{
    partial class FormaPregledAktivnostiKorisnika
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrikaziKorisnika = new System.Windows.Forms.Button();
            this.btnPronadjiKorisnike = new System.Windows.Forms.Button();
            this.dgvListaKorisnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaIme = new System.Windows.Forms.TextBox();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.gbPodaciOKorisniku = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.gbPodaciOKorisniku.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga korisnika";
            // 
            // btnPrikaziKorisnika
            // 
            this.btnPrikaziKorisnika.Location = new System.Drawing.Point(249, 238);
            this.btnPrikaziKorisnika.Name = "btnPrikaziKorisnika";
            this.btnPrikaziKorisnika.Size = new System.Drawing.Size(118, 23);
            this.btnPrikaziKorisnika.TabIndex = 4;
            this.btnPrikaziKorisnika.Text = "Prikaži projekte";
            this.btnPrikaziKorisnika.UseVisualStyleBackColor = true;
            this.btnPrikaziKorisnika.Click += new System.EventHandler(this.btnPrikaziKorisnika_Click);
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
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime korisnika:";
            // 
            // txtPretragaIme
            // 
            this.txtPretragaIme.Location = new System.Drawing.Point(19, 45);
            this.txtPretragaIme.Name = "txtPretragaIme";
            this.txtPretragaIme.Size = new System.Drawing.Size(197, 20);
            this.txtPretragaIme.TabIndex = 1;
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(18, 85);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.Size = new System.Drawing.Size(430, 128);
            this.dgvPodaci.TabIndex = 5;
            // 
            // gbPodaciOKorisniku
            // 
            this.gbPodaciOKorisniku.Controls.Add(this.dgvPodaci);
            this.gbPodaciOKorisniku.Location = new System.Drawing.Point(415, 12);
            this.gbPodaciOKorisniku.Name = "gbPodaciOKorisniku";
            this.gbPodaciOKorisniku.Size = new System.Drawing.Size(454, 278);
            this.gbPodaciOKorisniku.TabIndex = 8;
            this.gbPodaciOKorisniku.TabStop = false;
            this.gbPodaciOKorisniku.Text = "Podaci o učestvovanju na projektima";
            // 
            // FormaPregledAktivnostiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPodaciOKorisniku);
            this.Name = "FormaPregledAktivnostiKorisnika";
            this.Text = "Pregled aktivnosti korisnika";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.gbPodaciOKorisniku.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrikaziKorisnika;
        private System.Windows.Forms.Button btnPronadjiKorisnike;
        private System.Windows.Forms.DataGridView dgvListaKorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaIme;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.GroupBox gbPodaciOKorisniku;
    }
}