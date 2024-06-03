namespace _5_WinClassEBikes {
    partial class FeBikeManager {
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
            this.lRahmennummer = new System.Windows.Forms.Label();
            this.lKilometerstand = new System.Windows.Forms.Label();
            this.lLadung = new System.Windows.Forms.Label();
            this.tbRahmennummer = new System.Windows.Forms.TextBox();
            this.tbKilometerstand = new System.Windows.Forms.TextBox();
            this.tbLadung = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbListeBike = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCharge = new System.Windows.Forms.Button();
            this.btnDrive = new System.Windows.Forms.Button();
            this.lbListeSimuBike = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lRahmennummer
            // 
            this.lRahmennummer.AutoSize = true;
            this.lRahmennummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRahmennummer.Location = new System.Drawing.Point(13, 20);
            this.lRahmennummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRahmennummer.Name = "lRahmennummer";
            this.lRahmennummer.Size = new System.Drawing.Size(102, 15);
            this.lRahmennummer.TabIndex = 2;
            this.lRahmennummer.Text = "Rahmennummer";
            // 
            // lKilometerstand
            // 
            this.lKilometerstand.AutoSize = true;
            this.lKilometerstand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKilometerstand.Location = new System.Drawing.Point(13, 47);
            this.lKilometerstand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lKilometerstand.Name = "lKilometerstand";
            this.lKilometerstand.Size = new System.Drawing.Size(116, 15);
            this.lKilometerstand.TabIndex = 3;
            this.lKilometerstand.Text = "Kilometerstand [km]";
            // 
            // lLadung
            // 
            this.lLadung.AutoSize = true;
            this.lLadung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLadung.Location = new System.Drawing.Point(13, 73);
            this.lLadung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLadung.Name = "lLadung";
            this.lLadung.Size = new System.Drawing.Size(69, 15);
            this.lLadung.TabIndex = 4;
            this.lLadung.Text = "Ladung [%]";
            // 
            // tbRahmennummer
            // 
            this.tbRahmennummer.Location = new System.Drawing.Point(151, 20);
            this.tbRahmennummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbRahmennummer.Name = "tbRahmennummer";
            this.tbRahmennummer.Size = new System.Drawing.Size(107, 23);
            this.tbRahmennummer.TabIndex = 5;
            // 
            // tbKilometerstand
            // 
            this.tbKilometerstand.Location = new System.Drawing.Point(151, 47);
            this.tbKilometerstand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbKilometerstand.Name = "tbKilometerstand";
            this.tbKilometerstand.Size = new System.Drawing.Size(107, 23);
            this.tbKilometerstand.TabIndex = 6;
            // 
            // tbLadung
            // 
            this.tbLadung.Location = new System.Drawing.Point(151, 73);
            this.tbLadung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLadung.Name = "tbLadung";
            this.tbLadung.Size = new System.Drawing.Size(107, 23);
            this.tbLadung.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 106);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 60);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Eingabe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbListeBike
            // 
            this.lbListeBike.FormattingEnabled = true;
            this.lbListeBike.ItemHeight = 17;
            this.lbListeBike.Location = new System.Drawing.Point(271, 20);
            this.lbListeBike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbListeBike.Name = "lbListeBike";
            this.lbListeBike.Size = new System.Drawing.Size(461, 123);
            this.lbListeBike.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lRahmennummer);
            this.groupBox1.Controls.Add(this.lKilometerstand);
            this.groupBox1.Controls.Add(this.lLadung);
            this.groupBox1.Controls.Add(this.tbRahmennummer);
            this.groupBox1.Controls.Add(this.lbListeBike);
            this.groupBox1.Controls.Add(this.tbKilometerstand);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbLadung);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(736, 175);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingabe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCharge);
            this.groupBox2.Controls.Add(this.btnDrive);
            this.groupBox2.Controls.Add(this.lbListeSimuBike);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(736, 167);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation";
            // 
            // btnCharge
            // 
            this.btnCharge.Location = new System.Drawing.Point(151, 85);
            this.btnCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.Size = new System.Drawing.Size(106, 60);
            this.btnCharge.TabIndex = 11;
            this.btnCharge.Text = "Laden";
            this.btnCharge.UseVisualStyleBackColor = true;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(151, 20);
            this.btnDrive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(106, 60);
            this.btnDrive.TabIndex = 10;
            this.btnDrive.Text = "Fahren";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // lbListeSimuBike
            // 
            this.lbListeSimuBike.FormattingEnabled = true;
            this.lbListeSimuBike.ItemHeight = 17;
            this.lbListeSimuBike.Location = new System.Drawing.Point(271, 20);
            this.lbListeSimuBike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbListeSimuBike.Name = "lbListeSimuBike";
            this.lbListeSimuBike.Size = new System.Drawing.Size(461, 123);
            this.lbListeSimuBike.TabIndex = 9;
            // 
            // FeBikeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FeBikeManager";
            this.Text = "eBike Verwaltung und Tests";
            this.Load += new System.EventHandler(this.FeBikeManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lRahmennummer;
        private System.Windows.Forms.Label lKilometerstand;
        private System.Windows.Forms.Label lLadung;
        private System.Windows.Forms.TextBox tbRahmennummer;
        private System.Windows.Forms.TextBox tbLadung;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbListeBike;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.ListBox lbListeSimuBike;
        private System.Windows.Forms.TextBox tbKilometerstand;
    }
}

