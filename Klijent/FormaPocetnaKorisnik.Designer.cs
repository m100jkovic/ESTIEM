namespace Klijent
{
    partial class FormaPocetnaKorisnik
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
            this.dgvAktivniProjekti = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAktivniProjekti = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniProjekti)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbAktivniProjekti.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAktivniProjekti
            // 
            this.dgvAktivniProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivniProjekti.Location = new System.Drawing.Point(6, 19);
            this.dgvAktivniProjekti.Name = "dgvAktivniProjekti";
            this.dgvAktivniProjekti.Size = new System.Drawing.Size(517, 150);
            this.dgvAktivniProjekti.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektiToolStripMenuItem,
            this.oProgramuToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projektiToolStripMenuItem
            // 
            this.projektiToolStripMenuItem.Name = "projektiToolStripMenuItem";
            this.projektiToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.projektiToolStripMenuItem.Text = "Aktivni projekti";
            this.projektiToolStripMenuItem.Click += new System.EventHandler(this.projektiToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // gbAktivniProjekti
            // 
            this.gbAktivniProjekti.Controls.Add(this.dgvAktivniProjekti);
            this.gbAktivniProjekti.Location = new System.Drawing.Point(12, 54);
            this.gbAktivniProjekti.Name = "gbAktivniProjekti";
            this.gbAktivniProjekti.Size = new System.Drawing.Size(529, 181);
            this.gbAktivniProjekti.TabIndex = 3;
            this.gbAktivniProjekti.TabStop = false;
            this.gbAktivniProjekti.Text = "Aktivni projekti";
            // 
            // FormaPocetnaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 262);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbAktivniProjekti);
            this.Name = "FormaPocetnaKorisnik";
            this.Text = "ESTIEM evidencija projekata";
            this.Load += new System.EventHandler(this.FormaPocetnaKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniProjekti)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAktivniProjekti.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktivniProjekti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAktivniProjekti;

    }
}