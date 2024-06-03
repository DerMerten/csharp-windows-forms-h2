namespace WinClassNotizApp {
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
            this.components = new System.ComponentModel.Container();
            this.lAnzeige = new System.Windows.Forms.Label();
            this.lEingabe = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timerNext = new System.Windows.Forms.Timer(this.components);
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lAnzeige
            // 
            this.lAnzeige.AutoSize = true;
            this.lAnzeige.Location = new System.Drawing.Point(10, 44);
            this.lAnzeige.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAnzeige.Name = "lAnzeige";
            this.lAnzeige.Size = new System.Drawing.Size(45, 13);
            this.lAnzeige.TabIndex = 0;
            this.lAnzeige.Text = "Anzeige";
            // 
            // lEingabe
            // 
            this.lEingabe.AutoSize = true;
            this.lEingabe.Location = new System.Drawing.Point(235, 44);
            this.lEingabe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEingabe.Name = "lEingabe";
            this.lEingabe.Size = new System.Drawing.Size(46, 13);
            this.lEingabe.TabIndex = 1;
            this.lEingabe.Text = "Eingabe";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(237, 71);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(127, 20);
            this.tbMessage.TabIndex = 2;
            // 
            // tbMain
            // 
            this.tbMain.BackColor = System.Drawing.Color.Yellow;
            this.tbMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMain.Location = new System.Drawing.Point(10, 60);
            this.tbMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(224, 168);
            this.tbMain.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 245);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 33);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "nächste Notiz";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(286, 94);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timerNext
            // 
            this.timerNext.Interval = 1000;
            this.timerNext.Tick += new System.EventHandler(this.timerNext_Tick);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(301, 275);
            this.cbAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(78, 17);
            this.cbAuto.TabIndex = 6;
            this.cbAuto.Text = "Auto-Mode";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 366);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lEingabe);
            this.Controls.Add(this.lAnzeige);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Notizen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAnzeige;
        private System.Windows.Forms.Label lEingabe;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Timer timerNext;
        private System.Windows.Forms.CheckBox cbAuto;
    }
}

