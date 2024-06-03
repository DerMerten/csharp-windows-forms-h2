namespace WinClassGrundlagen {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose ( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent () {
            this.lNachname = new System.Windows.Forms.Label();
            this.lVorname = new System.Windows.Forms.Label();
            this.lTelefonnummer = new System.Windows.Forms.Label();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbTelefonnummer = new System.Windows.Forms.TextBox();
            this.btnEingabe = new System.Windows.Forms.Button();
            this.btnAusgabe = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lbTelefonbuch = new System.Windows.Forms.ListBox();
            this.lData = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lSuche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lNachname
            // 
            this.lNachname.AutoSize = true;
            this.lNachname.Location = new System.Drawing.Point(13, 25);
            this.lNachname.Name = "lNachname";
            this.lNachname.Size = new System.Drawing.Size(73, 16);
            this.lNachname.TabIndex = 0;
            this.lNachname.Text = "Nachname";
            // 
            // lVorname
            // 
            this.lVorname.AutoSize = true;
            this.lVorname.Location = new System.Drawing.Point(12, 65);
            this.lVorname.Name = "lVorname";
            this.lVorname.Size = new System.Drawing.Size(62, 16);
            this.lVorname.TabIndex = 1;
            this.lVorname.Text = "Vorname";
            // 
            // lTelefonnummer
            // 
            this.lTelefonnummer.AutoSize = true;
            this.lTelefonnummer.Location = new System.Drawing.Point(12, 102);
            this.lTelefonnummer.Name = "lTelefonnummer";
            this.lTelefonnummer.Size = new System.Drawing.Size(101, 16);
            this.lTelefonnummer.TabIndex = 2;
            this.lTelefonnummer.Text = "Telefonnummer";
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(129, 18);
            this.tbNachname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(169, 22);
            this.tbNachname.TabIndex = 3;
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(129, 62);
            this.tbVorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(169, 22);
            this.tbVorname.TabIndex = 4;
            // 
            // tbTelefonnummer
            // 
            this.tbTelefonnummer.Location = new System.Drawing.Point(129, 96);
            this.tbTelefonnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTelefonnummer.Name = "tbTelefonnummer";
            this.tbTelefonnummer.Size = new System.Drawing.Size(169, 22);
            this.tbTelefonnummer.TabIndex = 5;
            // 
            // btnEingabe
            // 
            this.btnEingabe.Location = new System.Drawing.Point(129, 135);
            this.btnEingabe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEingabe.Name = "btnEingabe";
            this.btnEingabe.Size = new System.Drawing.Size(171, 32);
            this.btnEingabe.TabIndex = 6;
            this.btnEingabe.Text = "Eingabe";
            this.btnEingabe.UseVisualStyleBackColor = true;
            this.btnEingabe.Click += new System.EventHandler(this.btnEingabe_Click);
            // 
            // btnAusgabe
            // 
            this.btnAusgabe.Location = new System.Drawing.Point(129, 174);
            this.btnAusgabe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAusgabe.Name = "btnAusgabe";
            this.btnAusgabe.Size = new System.Drawing.Size(171, 33);
            this.btnAusgabe.TabIndex = 7;
            this.btnAusgabe.Text = "Ausgabe";
            this.btnAusgabe.UseVisualStyleBackColor = true;
            this.btnAusgabe.Click += new System.EventHandler(this.btnAusgabe_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(129, 311);
            this.btnSuchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(171, 28);
            this.btnSuchen.TabIndex = 8;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // lbTelefonbuch
            // 
            this.lbTelefonbuch.FormattingEnabled = true;
            this.lbTelefonbuch.ItemHeight = 16;
            this.lbTelefonbuch.Location = new System.Drawing.Point(317, 18);
            this.lbTelefonbuch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTelefonbuch.Name = "lbTelefonbuch";
            this.lbTelefonbuch.Size = new System.Drawing.Size(324, 228);
            this.lbTelefonbuch.TabIndex = 9;
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(443, 262);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(78, 16);
            this.lData.TabIndex = 10;
            this.lData.Text = "Datensätze:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(129, 273);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(169, 22);
            this.tbSearch.TabIndex = 11;
            // 
            // lSuche
            // 
            this.lSuche.AutoSize = true;
            this.lSuche.Location = new System.Drawing.Point(12, 276);
            this.lSuche.Name = "lSuche";
            this.lSuche.Size = new System.Drawing.Size(48, 16);
            this.lSuche.TabIndex = 12;
            this.lSuche.Text = "Suche:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSuche);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lData);
            this.Controls.Add(this.lbTelefonbuch);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnAusgabe);
            this.Controls.Add(this.btnEingabe);
            this.Controls.Add(this.tbTelefonnummer);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.lTelefonnummer);
            this.Controls.Add(this.lVorname);
            this.Controls.Add(this.lNachname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Telefonbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNachname;
        private System.Windows.Forms.Label lVorname;
        private System.Windows.Forms.Label lTelefonnummer;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbTelefonnummer;
        private System.Windows.Forms.Button btnEingabe;
        private System.Windows.Forms.Button btnAusgabe;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.ListBox lbTelefonbuch;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lSuche;
    }
}

